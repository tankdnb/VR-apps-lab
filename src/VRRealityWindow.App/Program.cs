using Valve.VR;
using VRRealityWindow.Core;
using VRRealityWindow.Core.Abstractions;
using VRRealityWindow.Core.Providers;
using VRRealityWindow.Core.Processing;
using VRRealityWindow.Core.Utilities;
using VRRealityWindow.OpenVr;

var exitCode = await RealityWindowCli.RunAsync(args);
return exitCode;

internal static class RealityWindowCli
{
    public static async Task<int> RunAsync(string[] args)
    {
        var command = args.Length > 0 ? args[0].ToLowerInvariant() : "help";
        var options = CommandLineOptions.Parse(args.Skip(1).ToArray());

        try
        {
            return command switch
            {
                "probe" => await RunProbeAsync(options),
                "overlay" => await RunOverlayAsync(options),
                "doctor" => RunDoctor(options),
                "help" or "--help" or "-h" => ShowHelp(),
                _ => ShowHelp($"Unknown command: {command}"),
            };
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[error] {ex.Message}");
            return 1;
        }
    }

    private static async Task<int> RunProbeAsync(CommandLineOptions options)
    {
        var loaded = LoadSettings(options);
        var settings = loaded.Settings;
        ApplyOverrides(settings, options);

        var pipeline = FrameProcessingPipeline.Create(settings.Processing);
        ReportPipeline("probe", pipeline);

        if (settings.Camera.PreferredSource == CameraSourceKind.TestPattern)
        {
            using var testPatternProvider = new TestPatternCameraProvider();
            testPatternProvider.Initialize(CreateProviderConfig(settings, CameraSourceKind.TestPattern));
            testPatternProvider.Start();

            var frame = testPatternProvider.GetFrame() ?? throw new InvalidOperationException("Test pattern provider did not produce a frame.");
            var processedFrame = pipeline.Process(frame);
            ReportFrame(testPatternProvider.Diagnostics, processedFrame);

            if (!string.IsNullOrWhiteSpace(options.SaveFramePath))
            {
                BmpWriter.WriteBgra32(Path.GetFullPath(options.SaveFramePath), processedFrame);
                Console.WriteLine($"[probe] Saved frame to {Path.GetFullPath(options.SaveFramePath)}");
            }

            return 0;
        }

        using var runtime = TryInitializeOpenVr(EVRApplicationType.VRApplication_Utility, out var runtimeInitError);
        var snapshot = CaptureRuntimeSnapshot(runtime);
        var providerSelection = SelectProbeProvider(settings, runtime, snapshot);

        ReportRuntimeSnapshot("probe", snapshot, settings);
        Console.WriteLine($"[probe] Requested source: {settings.Camera.PreferredSource}");
        Console.WriteLine($"[probe] Resolved source: {providerSelection.ResolvedSource}");
        Console.WriteLine($"[probe] Selection reason: {providerSelection.Reason}");

        using var provider = providerSelection.CreateProvider();
        provider.Initialize(CreateProviderConfig(settings, providerSelection.ResolvedSource));

        Console.WriteLine($"[probe] Source: {provider.SourceName}");
        Console.WriteLine($"[probe] Device index: {settings.Camera.DeviceIndex}");

        var available = provider.IsAvailable();
        Console.WriteLine($"[probe] Provider status: {provider.Status}");
        Console.WriteLine($"[probe] Source available: {available}");
        if (!available)
        {
            Console.WriteLine($"[probe] Last error: {provider.Diagnostics.LastError}");
            PrintRecommendedPath(snapshot, settings, runtimeInitError);
            return provider.Status == CameraProviderStatus.Unsupported ? 4 : 2;
        }

        provider.Start();

        CameraFrame? frameResult = null;
        for (var attempt = 1; attempt <= settings.Runtime.ProbeAttempts; attempt++)
        {
            frameResult = provider.GetFrame();
            if (frameResult is not null)
            {
                Console.WriteLine($"[probe] First frame acquired on attempt {attempt}.");
                break;
            }

            await Task.Delay(settings.Runtime.ProbeRetryDelayMs);
        }

        if (frameResult is null)
        {
            Console.WriteLine("[probe] No frame available within retry window.");
            Console.WriteLine($"[probe] Diagnostics: empty_polls={provider.Diagnostics.EmptyPolls}, last_error=\"{provider.Diagnostics.LastError}\"");
            PrintRecommendedPath(snapshot, settings, runtimeInitError);
            return 3;
        }

        var processedProbeFrame = pipeline.Process(frameResult);
        ReportFrame(provider.Diagnostics, processedProbeFrame);

        if (!string.IsNullOrWhiteSpace(options.SaveFramePath))
        {
            BmpWriter.WriteBgra32(Path.GetFullPath(options.SaveFramePath), processedProbeFrame);
            Console.WriteLine($"[probe] Saved frame to {Path.GetFullPath(options.SaveFramePath)}");
        }

        PrintRecommendedPath(snapshot, settings, runtimeInitError);
        return 0;
    }

    private static async Task<int> RunOverlayAsync(CommandLineOptions options)
    {
        var loaded = LoadSettings(options);
        var settings = loaded.Settings;
        ApplyOverrides(settings, options);

        using var runtime = TryInitializeOpenVr(EVRApplicationType.VRApplication_Overlay, out var runtimeInitError);
        if (runtime is null)
        {
            throw new InvalidOperationException(runtimeInitError ?? "OpenVR runtime is unavailable.");
        }

        var snapshot = CaptureRuntimeSnapshot(runtime);
        ReportRuntimeSnapshot("overlay", snapshot, settings);

        var selection = SelectOverlayProvider(settings, runtime, snapshot);
        Console.WriteLine($"[overlay] Requested source: {settings.Camera.PreferredSource}");
        Console.WriteLine($"[overlay] Resolved source: {selection.ResolvedSource}");
        Console.WriteLine($"[overlay] Selection reason: {selection.Reason}");

        using var provider = selection.CreateProvider();
        provider.Initialize(CreateProviderConfig(settings, selection.ResolvedSource));

        if (!provider.IsAvailable())
        {
            if (settings.Camera.FallbackToTestPattern && selection.ResolvedSource != CameraSourceKind.TestPattern)
            {
                Console.WriteLine($"[overlay] Source unavailable: {provider.Diagnostics.LastError}");
                Console.WriteLine("[overlay] Falling back to test pattern provider so the overlay UX can still be tested.");

                using var fallbackProvider = new TestPatternCameraProvider();
                fallbackProvider.Initialize(CreateProviderConfig(settings, CameraSourceKind.TestPattern));
                return await RunOverlayLoopAsync(fallbackProvider, runtime, settings);
            }

            throw new InvalidOperationException(provider.Diagnostics.LastError);
        }

        return await RunOverlayLoopAsync(provider, runtime, settings);
    }

    private static int RunDoctor(CommandLineOptions options)
    {
        var loaded = LoadSettings(options);
        var settings = loaded.Settings;
        ApplyOverrides(settings, options);

        Console.WriteLine("[doctor] Reality Window MVP environment report");
        Console.WriteLine($"[doctor] Preferred source: {settings.Camera.PreferredSource}");
        Console.WriteLine($"[doctor] Preferred runtime path: {settings.Camera.PreferredRuntimePath}");
        Console.WriteLine($"[doctor] Target headset: {settings.Camera.TargetHeadset}");
        Console.WriteLine($"[doctor] Test-pattern fallback: {settings.Camera.FallbackToTestPattern}");

        using var runtime = TryInitializeOpenVr(EVRApplicationType.VRApplication_Utility, out var runtimeInitError);
        var snapshot = CaptureRuntimeSnapshot(runtime);
        ReportRuntimeSnapshot("doctor", snapshot, settings);

        if (runtime is not null)
        {
            var openVrAvailable = CanUseOpenVrTrackedCamera(settings, runtime);
            Console.WriteLine($"[doctor] OpenVR tracked camera probe: {(openVrAvailable.IsAvailable ? "available" : "unavailable")}");
            if (!string.IsNullOrWhiteSpace(openVrAvailable.Message))
            {
                Console.WriteLine($"[doctor] OpenVR tracked camera details: {openVrAvailable.Message}");
            }
        }
        else
        {
            Console.WriteLine($"[doctor] OpenVR runtime: unavailable ({runtimeInitError})");
        }

        using var picoProvider = new PicoOfficialCameraProvider();
        picoProvider.Initialize(CreateProviderConfig(settings, CameraSourceKind.PicoOfficial));
        var picoAvailable = picoProvider.IsAvailable();
        Console.WriteLine($"[doctor] PICO official provider in this build: {(picoAvailable ? "available" : "not available")}");
        Console.WriteLine($"[doctor] PICO official details: {picoProvider.Diagnostics.LastError}");
        PrintPicoOfficialPathFacts();

        PrintRecommendedPath(snapshot, settings, runtimeInitError);
        Console.WriteLine("[doctor] Recommended local test command: dotnet run --project .\\src\\VRRealityWindow.App -- overlay --source test-pattern");
        Console.WriteLine("[doctor] Recommended on-device next step: see .\\spikes\\PicoOpenXrExtensionProbe\\README.md");
        return 0;
    }

    private static async Task<int> RunOverlayLoopAsync(ICameraProvider provider, OpenVrRuntime runtime, MvpSettings settings)
    {
        var pipeline = FrameProcessingPipeline.Create(settings.Processing);

        Console.WriteLine($"[overlay] Source: {provider.SourceName}");
        Console.WriteLine($"[overlay] Anchor: {settings.Overlay.AnchorMode}");
        ReportPipeline("overlay", pipeline);

        provider.Start();

        using var presenter = new OpenVrOverlayPresenter(runtime, settings.Overlay);
        presenter.Initialize();
        presenter.Show();

        using var cancellation = new CancellationTokenSource();
        Console.CancelKeyPress += (_, eventArgs) =>
        {
            eventArgs.Cancel = true;
            cancellation.Cancel();
        };

        if (settings.Runtime.OverlayDurationSeconds > 0)
        {
            cancellation.CancelAfter(TimeSpan.FromSeconds(settings.Runtime.OverlayDurationSeconds));
        }

        Console.WriteLine("[overlay] Running.");
        Console.WriteLine("[overlay] Keys: T=toggle, R=reset, 1/2/3=anchor, -/+=size, O/P=opacity, </>=tilt, C=toggle crop, Z/X=crop ratio, Q=quit");

        var canReadKeys = !Console.IsInputRedirected;
        if (!canReadKeys)
        {
            Console.WriteLine("[overlay] Interactive keyboard controls are unavailable in redirected/non-interactive console mode.");
        }

        Console.WriteLine("[overlay] Controller test bindings:");
        Console.WriteLine("[overlay] - Left Grip: attach to left hand");
        Console.WriteLine("[overlay] - Right Grip: attach to right hand");
        Console.WriteLine("[overlay] - Trigger on attached hand: freeze current hand-held pose into world");
        Console.WriteLine("[overlay] - Right stick Y: size, Right stick X: opacity");
        Console.WriteLine("[overlay] - Left stick Y: tilt, Left stick X: crop ratio");
        Console.WriteLine("[overlay] - A/Menu button: toggle visibility");

        var delayMs = Math.Max(1, 1000 / Math.Max(1, settings.Runtime.UpdateRateHz));
        var previousLeftState = default(VRControllerState_t);
        var previousRightState = default(VRControllerState_t);

        while (!cancellation.IsCancellationRequested)
        {
            while (canReadKeys && Console.KeyAvailable)
            {
                var key = Console.ReadKey(intercept: true).Key;
                switch (key)
                {
                    case ConsoleKey.Q:
                        cancellation.Cancel();
                        break;

                    case ConsoleKey.T:
                        presenter.ToggleVisibility();
                        Console.WriteLine($"[overlay] Visibility: {(presenter.IsVisible ? "shown" : "hidden")}");
                        break;

                    case ConsoleKey.R:
                        presenter.SetAnchorMode(AnchorMode.WorldLocked);
                        Console.WriteLine("[overlay] Reset to world-locked pose in front of HMD.");
                        break;

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        presenter.SetAnchorMode(AnchorMode.WorldLocked);
                        Console.WriteLine("[overlay] Anchor mode: WorldLocked");
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        presenter.SetAnchorMode(AnchorMode.LeftHandLocked);
                        Console.WriteLine("[overlay] Anchor mode: LeftHandLocked");
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        presenter.SetAnchorMode(AnchorMode.RightHandLocked);
                        Console.WriteLine("[overlay] Anchor mode: RightHandLocked");
                        break;

                    case ConsoleKey.OemMinus:
                    case ConsoleKey.Subtract:
                        presenter.SetWidth(presenter.WidthInMeters - 0.03f);
                        Console.WriteLine($"[overlay] Width: {presenter.WidthInMeters:0.00} m");
                        break;

                    case ConsoleKey.OemPlus:
                    case ConsoleKey.Add:
                        presenter.SetWidth(presenter.WidthInMeters + 0.03f);
                        Console.WriteLine($"[overlay] Width: {presenter.WidthInMeters:0.00} m");
                        break;

                    case ConsoleKey.O:
                        presenter.SetOpacity(presenter.Opacity - 0.05f);
                        Console.WriteLine($"[overlay] Opacity: {presenter.Opacity:0.00}");
                        break;

                    case ConsoleKey.P:
                        presenter.SetOpacity(presenter.Opacity + 0.05f);
                        Console.WriteLine($"[overlay] Opacity: {presenter.Opacity:0.00}");
                        break;

                    case ConsoleKey.OemComma:
                        presenter.SetTilt(presenter.TiltDegrees - 2f);
                        Console.WriteLine($"[overlay] Tilt: {presenter.TiltDegrees:0.0} deg");
                        break;

                    case ConsoleKey.OemPeriod:
                        presenter.SetTilt(presenter.TiltDegrees + 2f);
                        Console.WriteLine($"[overlay] Tilt: {presenter.TiltDegrees:0.0} deg");
                        break;

                    case ConsoleKey.C:
                        settings.Processing.EnableBottomFocusCrop = !settings.Processing.EnableBottomFocusCrop;
                        pipeline = FrameProcessingPipeline.Create(settings.Processing);
                        ReportPipeline("overlay", pipeline);
                        break;

                    case ConsoleKey.Z:
                        settings.Processing.BottomFocusHeightRatio = Math.Clamp(settings.Processing.BottomFocusHeightRatio - 0.05f, 0.10f, 1.00f);
                        pipeline = FrameProcessingPipeline.Create(settings.Processing);
                        Console.WriteLine($"[overlay] Bottom focus ratio: {settings.Processing.BottomFocusHeightRatio:0.00}");
                        ReportPipeline("overlay", pipeline);
                        break;

                    case ConsoleKey.X:
                        settings.Processing.BottomFocusHeightRatio = Math.Clamp(settings.Processing.BottomFocusHeightRatio + 0.05f, 0.10f, 1.00f);
                        pipeline = FrameProcessingPipeline.Create(settings.Processing);
                        Console.WriteLine($"[overlay] Bottom focus ratio: {settings.Processing.BottomFocusHeightRatio:0.00}");
                        ReportPipeline("overlay", pipeline);
                        break;
                }
            }

            var leftController = PollController(runtime, ETrackedControllerRole.LeftHand);
            var rightController = PollController(runtime, ETrackedControllerRole.RightHand);

            HandleControllerButtons(
                presenter,
                leftController,
                previousLeftState,
                rightController,
                previousRightState);

            ApplyControllerAxes(settings, presenter, leftController, rightController, ref pipeline, delayMs / 1000f);

            previousLeftState = leftController.State;
            previousRightState = rightController.State;

            var frame = provider.GetFrame();
            if (frame is not null)
            {
                presenter.UpdateFrame(pipeline.Process(frame));
            }

            try
            {
                await Task.Delay(delayMs, cancellation.Token);
            }
            catch (TaskCanceledException)
            {
                break;
            }
        }

        return 0;
    }

    private static void ReportFrame(ProviderDiagnostics diagnostics, CameraFrame frame)
    {
        Console.WriteLine($"[probe] Frame source: {frame.SourceName}");
        Console.WriteLine($"[probe] Frame size: {frame.Width}x{frame.Height}");
        Console.WriteLine($"[probe] Bytes per pixel: {frame.BytesPerPixel}");
        Console.WriteLine($"[probe] Sequence: {frame.Sequence}");
        Console.WriteLine($"[probe] Exposure timestamp: {frame.ExposureTimestamp}");
        Console.WriteLine($"[probe] Diagnostics: frames_received={diagnostics.FramesReceived}, empty_polls={diagnostics.EmptyPolls}");
    }

    private static void ReportPipeline(string scope, FrameProcessingPipeline pipeline)
    {
        Console.WriteLine($"[{scope}] Frame pipeline: {pipeline.Description}");
    }

    private static void ReportRuntimeSnapshot(string scope, RuntimeSnapshot snapshot, MvpSettings settings)
    {
        Console.WriteLine($"[{scope}] Preferred runtime path: {settings.Camera.PreferredRuntimePath}");
        Console.WriteLine($"[{scope}] Target headset: {settings.Camera.TargetHeadset}");

        if (!snapshot.OpenVrRuntimeAvailable)
        {
            Console.WriteLine($"[{scope}] OpenVR runtime: unavailable");
            return;
        }

        Console.WriteLine($"[{scope}] OpenVR runtime: available");
        Console.WriteLine($"[{scope}] HMD model: {snapshot.HmdModel}");
        Console.WriteLine($"[{scope}] HMD driver: {snapshot.HmdDriver}");
        Console.WriteLine($"[{scope}] HMD Prop_HasCamera_Bool: {(snapshot.HmdHasCameraPropertyKnown ? snapshot.HmdHasCameraProperty.ToString() : "unknown")}");
    }

    private static ControllerSnapshot PollController(OpenVrRuntime runtime, ETrackedControllerRole role)
    {
        return runtime.TryGetControllerState(role, out var deviceIndex, out var state, out var pose)
            ? new ControllerSnapshot(role, deviceIndex, true, state, pose)
            : new ControllerSnapshot(role, Valve.VR.OpenVR.k_unTrackedDeviceIndexInvalid, false, default, default);
    }

    private static void HandleControllerButtons(
        OpenVrOverlayPresenter presenter,
        ControllerSnapshot leftController,
        VRControllerState_t previousLeftState,
        ControllerSnapshot rightController,
        VRControllerState_t previousRightState)
    {
        if (leftController.IsConnected && IsPressed(leftController.State, EVRButtonId.k_EButton_Grip) && !IsPressed(previousLeftState, EVRButtonId.k_EButton_Grip))
        {
            presenter.AttachToHandPreservingWorldPose(leftController.Pose.mDeviceToAbsoluteTracking, ETrackedControllerRole.LeftHand, leftHand: true);
            Console.WriteLine("[overlay] Controller: attached to left hand");
        }

        if (rightController.IsConnected && IsPressed(rightController.State, EVRButtonId.k_EButton_Grip) && !IsPressed(previousRightState, EVRButtonId.k_EButton_Grip))
        {
            presenter.AttachToHandPreservingWorldPose(rightController.Pose.mDeviceToAbsoluteTracking, ETrackedControllerRole.RightHand, leftHand: false);
            Console.WriteLine("[overlay] Controller: attached to right hand");
        }

        if (presenter.CurrentAnchorMode == AnchorMode.LeftHandLocked &&
            leftController.IsConnected &&
            IsTriggerPressed(leftController.State) &&
            !IsTriggerPressed(previousLeftState))
        {
            presenter.FreezeHandLockedToWorld(leftController.Pose.mDeviceToAbsoluteTracking, leftHand: true);
            Console.WriteLine("[overlay] Controller: current left-hand pose frozen into world");
        }

        if (presenter.CurrentAnchorMode == AnchorMode.RightHandLocked &&
            rightController.IsConnected &&
            IsTriggerPressed(rightController.State) &&
            !IsTriggerPressed(previousRightState))
        {
            presenter.FreezeHandLockedToWorld(rightController.Pose.mDeviceToAbsoluteTracking, leftHand: false);
            Console.WriteLine("[overlay] Controller: current right-hand pose frozen into world");
        }

        var leftToggle = leftController.IsConnected &&
            (IsPressed(leftController.State, EVRButtonId.k_EButton_ApplicationMenu) || IsPressed(leftController.State, EVRButtonId.k_EButton_A)) &&
            !(IsPressed(previousLeftState, EVRButtonId.k_EButton_ApplicationMenu) || IsPressed(previousLeftState, EVRButtonId.k_EButton_A));

        var rightToggle = rightController.IsConnected &&
            (IsPressed(rightController.State, EVRButtonId.k_EButton_ApplicationMenu) || IsPressed(rightController.State, EVRButtonId.k_EButton_A)) &&
            !(IsPressed(previousRightState, EVRButtonId.k_EButton_ApplicationMenu) || IsPressed(previousRightState, EVRButtonId.k_EButton_A));

        if (leftToggle || rightToggle)
        {
            presenter.ToggleVisibility();
            Console.WriteLine($"[overlay] Controller: visibility {(presenter.IsVisible ? "shown" : "hidden")}");
        }
    }

    private static void ApplyControllerAxes(
        MvpSettings settings,
        OpenVrOverlayPresenter presenter,
        ControllerSnapshot leftController,
        ControllerSnapshot rightController,
        ref FrameProcessingPipeline pipeline,
        float deltaSeconds)
    {
        const float deadzone = 0.35f;

        if (rightController.IsConnected)
        {
            var sizeAxis = ApplyDeadzone(rightController.State.rAxis0.y, deadzone);
            var opacityAxis = ApplyDeadzone(rightController.State.rAxis0.x, deadzone);

            if (MathF.Abs(sizeAxis) > 0f)
            {
                presenter.SetWidth(presenter.WidthInMeters + (sizeAxis * 0.45f * deltaSeconds));
            }

            if (MathF.Abs(opacityAxis) > 0f)
            {
                presenter.SetOpacity(presenter.Opacity + (opacityAxis * 0.70f * deltaSeconds));
            }
        }

        if (leftController.IsConnected)
        {
            var tiltAxis = ApplyDeadzone(leftController.State.rAxis0.y, deadzone);
            var cropAxis = ApplyDeadzone(leftController.State.rAxis0.x, deadzone);

            if (MathF.Abs(tiltAxis) > 0f)
            {
                presenter.SetTilt(presenter.TiltDegrees + (tiltAxis * 90f * deltaSeconds));
            }

            if (MathF.Abs(cropAxis) > 0f)
            {
                settings.Processing.EnableBottomFocusCrop = true;
                settings.Processing.BottomFocusHeightRatio = Math.Clamp(
                    settings.Processing.BottomFocusHeightRatio + (cropAxis * 0.70f * deltaSeconds),
                    0.10f,
                    1.00f);
                pipeline = FrameProcessingPipeline.Create(settings.Processing);
            }
        }
    }

    private static bool IsPressed(VRControllerState_t state, EVRButtonId button)
    {
        var mask = 1UL << (int)button;
        return (state.ulButtonPressed & mask) != 0;
    }

    private static bool IsTriggerPressed(VRControllerState_t state)
    {
        return IsPressed(state, EVRButtonId.k_EButton_SteamVR_Trigger) || state.rAxis1.x > 0.75f;
    }

    private static float ApplyDeadzone(float value, float deadzone)
    {
        return MathF.Abs(value) < deadzone ? 0f : value;
    }

    private static ProviderSelection SelectProbeProvider(MvpSettings settings, OpenVrRuntime? runtime, RuntimeSnapshot snapshot)
    {
        if (settings.Camera.PreferredSource != CameraSourceKind.Auto)
        {
            return CreateExplicitSelection(settings.Camera.PreferredSource, runtime, "explicitly requested");
        }

        if (runtime is not null)
        {
            var openVrAssessment = CanUseOpenVrTrackedCamera(settings, runtime);
            if (openVrAssessment.IsAvailable)
            {
                return CreateExplicitSelection(CameraSourceKind.OpenVrTrackedCamera, runtime, "auto selected OpenVR tracked camera because it is available");
            }

            if (ShouldPreferPicoOfficial(snapshot, settings))
            {
                return CreateExplicitSelection(CameraSourceKind.PicoOfficial, runtime, $"auto selected PICO official path because OpenVR tracked camera is unavailable ({openVrAssessment.Message})");
            }

            return CreateExplicitSelection(CameraSourceKind.OpenVrTrackedCamera, runtime, $"auto fell back to OpenVR tracked camera probe to report the failure reason ({openVrAssessment.Message})");
        }

        return CreateExplicitSelection(
            ShouldPreferPicoOfficial(snapshot, settings) ? CameraSourceKind.PicoOfficial : CameraSourceKind.OpenVrTrackedCamera,
            runtime,
            "OpenVR runtime was unavailable during probe");
    }

    private static ProviderSelection SelectOverlayProvider(MvpSettings settings, OpenVrRuntime runtime, RuntimeSnapshot snapshot)
    {
        if (settings.Camera.PreferredSource != CameraSourceKind.Auto)
        {
            return CreateExplicitSelection(settings.Camera.PreferredSource, runtime, "explicitly requested");
        }

        var openVrAssessment = CanUseOpenVrTrackedCamera(settings, runtime);
        if (openVrAssessment.IsAvailable)
        {
            return CreateExplicitSelection(CameraSourceKind.OpenVrTrackedCamera, runtime, "auto selected OpenVR tracked camera because it is available");
        }

        if (settings.Camera.FallbackToTestPattern)
        {
            return CreateExplicitSelection(CameraSourceKind.TestPattern, runtime, $"auto selected test-pattern so the overlay UX can be tested now ({openVrAssessment.Message})");
        }

        if (ShouldPreferPicoOfficial(snapshot, settings))
        {
            return CreateExplicitSelection(CameraSourceKind.PicoOfficial, runtime, $"auto selected PICO official path because OpenVR tracked camera is unavailable ({openVrAssessment.Message})");
        }

        return CreateExplicitSelection(CameraSourceKind.OpenVrTrackedCamera, runtime, $"auto fell back to OpenVR tracked camera because no alternative source was allowed ({openVrAssessment.Message})");
    }

    private static ProviderSelection CreateExplicitSelection(CameraSourceKind source, OpenVrRuntime? runtime, string reason)
    {
        return new ProviderSelection(source, reason, () => CreateProvider(source, runtime));
    }

    private static ICameraProvider CreateProvider(CameraSourceKind source, OpenVrRuntime? runtime)
    {
        return source switch
        {
            CameraSourceKind.OpenVrTrackedCamera => runtime is not null
                ? new OpenVrTrackedCameraProvider(runtime)
                : throw new InvalidOperationException("OpenVR runtime is required for the tracked camera provider."),
            CameraSourceKind.PicoOfficial => new PicoOfficialCameraProvider(),
            CameraSourceKind.TestPattern => new TestPatternCameraProvider(),
            CameraSourceKind.Auto => throw new InvalidOperationException("Auto source must be resolved before provider creation."),
            _ => throw new InvalidOperationException($"Unsupported source: {source}"),
        };
    }

    private static CameraProviderConfig CreateProviderConfig(MvpSettings settings, CameraSourceKind resolvedSource)
    {
        return new CameraProviderConfig
        {
            Source = resolvedSource,
            FrameType = settings.Camera.FrameType,
            DeviceIndex = settings.Camera.DeviceIndex,
            TestPatternWidth = settings.Camera.TestPatternWidth,
            TestPatternHeight = settings.Camera.TestPatternHeight,
            PreferredRuntimePath = settings.Camera.PreferredRuntimePath,
            TargetHeadset = settings.Camera.TargetHeadset,
        };
    }

    private static void ApplyOverrides(MvpSettings settings, CommandLineOptions options)
    {
        if (options.SourceOverride is not null)
        {
            settings.Camera.PreferredSource = options.SourceOverride.Value;
        }

        if (options.RuntimePathOverride is not null)
        {
            settings.Camera.PreferredRuntimePath = options.RuntimePathOverride.Value;
        }

        if (options.TargetHeadsetOverride is not null)
        {
            settings.Camera.TargetHeadset = options.TargetHeadsetOverride.Value;
        }

        if (options.AnchorOverride is not null)
        {
            settings.Overlay.AnchorMode = options.AnchorOverride.Value;
        }

        if (options.DurationSeconds is not null)
        {
            settings.Runtime.OverlayDurationSeconds = options.DurationSeconds.Value;
        }
    }

    private static LoadedSettings LoadSettings(CommandLineOptions options)
    {
        var settingsPath = Path.GetFullPath(options.SettingsPath ?? Path.Combine(Environment.CurrentDirectory, "config", "mvp.settings.json"));
        var settings = SettingsStore.LoadOrCreate(settingsPath);
        Console.WriteLine($"[settings] Using {settingsPath}");
        return new LoadedSettings(settingsPath, settings);
    }

    private static OpenVrRuntime? TryInitializeOpenVr(EVRApplicationType applicationType, out string? error)
    {
        try
        {
            var runtime = new OpenVrRuntime();
            runtime.Initialize(applicationType);
            error = null;
            return runtime;
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return null;
        }
    }

    private static RuntimeSnapshot CaptureRuntimeSnapshot(OpenVrRuntime? runtime)
    {
        if (runtime is null)
        {
            return new RuntimeSnapshot();
        }

        var model = runtime.GetTrackedDeviceString(OpenVR.k_unTrackedDeviceIndex_Hmd, ETrackedDeviceProperty.Prop_ModelNumber_String);
        var driver = runtime.GetTrackedDeviceString(OpenVR.k_unTrackedDeviceIndex_Hmd, ETrackedDeviceProperty.Prop_TrackingSystemName_String);
        var hasCameraKnown = runtime.TryGetHasCamera(OpenVR.k_unTrackedDeviceIndex_Hmd, out var hasCamera);

        return new RuntimeSnapshot
        {
            OpenVrRuntimeAvailable = true,
            HmdModel = model,
            HmdDriver = driver,
            HmdHasCameraPropertyKnown = hasCameraKnown,
            HmdHasCameraProperty = hasCamera,
        };
    }

    private static AvailabilityAssessment CanUseOpenVrTrackedCamera(MvpSettings settings, OpenVrRuntime runtime)
    {
        using var provider = new OpenVrTrackedCameraProvider(runtime);
        provider.Initialize(CreateProviderConfig(settings, CameraSourceKind.OpenVrTrackedCamera));
        var available = provider.IsAvailable();
        return new AvailabilityAssessment(available, provider.Diagnostics.LastError);
    }

    private static bool ShouldPreferPicoOfficial(RuntimeSnapshot snapshot, MvpSettings settings)
    {
        if (settings.Camera.PreferredRuntimePath == RuntimePathKind.PicoOfficial)
        {
            return true;
        }

        if (settings.Camera.TargetHeadset == TargetHeadsetKind.Pico4Pro)
        {
            return true;
        }

        return snapshot.IsPicoRuntime;
    }

    private static void PrintPicoOfficialPathFacts()
    {
        Console.WriteLine("[doctor] PICO official raw camera candidate: XR_PICO_camera_image");
        Console.WriteLine("[doctor] PICO raw camera dependency: XR_EXT_future");
        Console.WriteLine("[doctor] PICO privacy-preserving MR path: XR_PICO_secure_mixed_reality");
        Console.WriteLine("[doctor] SecureMR limitation: camera and sensor data are not returned to the calling app.");
    }

    private static void PrintRecommendedPath(RuntimeSnapshot snapshot, MvpSettings settings, string? runtimeInitError)
    {
        Console.WriteLine("[verdict] Recommended implementation path:");

        if (ShouldPreferPicoOfficial(snapshot, settings))
        {
            Console.WriteLine("[verdict] - Primary: PICO official / OpenXR / on-device passthrough spike.");
            Console.WriteLine("[verdict] - Gate 1: confirm XR_PICO_camera_image and XR_EXT_future on the headset runtime.");
            Console.WriteLine("[verdict] - Gate 2: if only XR_PICO_secure_mixed_reality is present, the app will not receive raw frames back.");
            Console.WriteLine("[verdict] - Desktop MVP value right now: validate overlay UX, sizing, tilt, opacity, anchoring, and crop using test-pattern fallback.");
            if (!string.IsNullOrWhiteSpace(runtimeInitError))
            {
                Console.WriteLine($"[verdict] - OpenVR runtime note: {runtimeInitError}");
            }

            return;
        }

        if (snapshot.OpenVrRuntimeAvailable)
        {
            Console.WriteLine("[verdict] - Primary: SteamVR/OpenVR tracked camera path.");
            return;
        }

        Console.WriteLine("[verdict] - Primary: external camera or fallback source until a headset-specific runtime path is confirmed.");
    }

    private static int ShowHelp(string? message = null)
    {
        if (!string.IsNullOrWhiteSpace(message))
        {
            Console.Error.WriteLine(message);
        }

        Console.WriteLine("VR Reality Window MVP");
        Console.WriteLine();
        Console.WriteLine("Commands:");
        Console.WriteLine("  probe    Checks whether a requested source can produce a frame.");
        Console.WriteLine("  overlay  Starts a minimal OpenVR overlay fed by camera or test pattern.");
        Console.WriteLine("  doctor   Prints a device/runtime feasibility report for this MVP build.");
        Console.WriteLine();
        Console.WriteLine("Options:");
        Console.WriteLine("  --settings <path>         JSON settings file. Default: ./config/mvp.settings.json");
        Console.WriteLine("  --source <auto|tracked-camera|pico-official|test-pattern>");
        Console.WriteLine("  --runtime-path <auto|steamvr|pico-official>");
        Console.WriteLine("  --target-headset <generic|pico-4-pro>");
        Console.WriteLine("  --anchor <world|left-hand|right-hand>   overlay command only");
        Console.WriteLine("  --duration-seconds <n>    overlay command only");
        Console.WriteLine("  --save-frame <path>       probe command only");
        return string.IsNullOrWhiteSpace(message) ? 0 : 1;
    }
}

internal sealed class CommandLineOptions
{
    public string? SettingsPath { get; init; }
    public CameraSourceKind? SourceOverride { get; init; }
    public RuntimePathKind? RuntimePathOverride { get; init; }
    public TargetHeadsetKind? TargetHeadsetOverride { get; init; }
    public AnchorMode? AnchorOverride { get; init; }
    public string? SaveFramePath { get; init; }
    public int? DurationSeconds { get; init; }

    public static CommandLineOptions Parse(string[] args)
    {
        string? settingsPath = null;
        CameraSourceKind? sourceOverride = null;
        RuntimePathKind? runtimePathOverride = null;
        TargetHeadsetKind? targetHeadsetOverride = null;
        AnchorMode? anchorOverride = null;
        string? saveFramePath = null;
        int? durationSeconds = null;

        for (var i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--settings" when i + 1 < args.Length:
                    settingsPath = args[++i];
                    break;

                case "--source" when i + 1 < args.Length:
                    sourceOverride = args[++i].ToLowerInvariant() switch
                    {
                        "auto" => CameraSourceKind.Auto,
                        "tracked-camera" => CameraSourceKind.OpenVrTrackedCamera,
                        "pico-official" => CameraSourceKind.PicoOfficial,
                        "test-pattern" => CameraSourceKind.TestPattern,
                        _ => throw new ArgumentException($"Unsupported source: {args[i]}"),
                    };
                    break;

                case "--runtime-path" when i + 1 < args.Length:
                    runtimePathOverride = args[++i].ToLowerInvariant() switch
                    {
                        "auto" => RuntimePathKind.Auto,
                        "steamvr" => RuntimePathKind.SteamVrOpenVr,
                        "pico-official" => RuntimePathKind.PicoOfficial,
                        _ => throw new ArgumentException($"Unsupported runtime path: {args[i]}"),
                    };
                    break;

                case "--target-headset" when i + 1 < args.Length:
                    targetHeadsetOverride = args[++i].ToLowerInvariant() switch
                    {
                        "generic" => TargetHeadsetKind.Generic,
                        "pico-4-pro" => TargetHeadsetKind.Pico4Pro,
                        _ => throw new ArgumentException($"Unsupported target headset: {args[i]}"),
                    };
                    break;

                case "--anchor" when i + 1 < args.Length:
                    anchorOverride = args[++i].ToLowerInvariant() switch
                    {
                        "world" => AnchorMode.WorldLocked,
                        "left-hand" => AnchorMode.LeftHandLocked,
                        "right-hand" => AnchorMode.RightHandLocked,
                        _ => throw new ArgumentException($"Unsupported anchor mode: {args[i]}"),
                    };
                    break;

                case "--save-frame" when i + 1 < args.Length:
                    saveFramePath = args[++i];
                    break;

                case "--duration-seconds" when i + 1 < args.Length && int.TryParse(args[++i], out var seconds):
                    durationSeconds = seconds;
                    break;

                default:
                    throw new ArgumentException($"Unknown option: {args[i]}");
            }
        }

        return new CommandLineOptions
        {
            SettingsPath = settingsPath,
            SourceOverride = sourceOverride,
            RuntimePathOverride = runtimePathOverride,
            TargetHeadsetOverride = targetHeadsetOverride,
            AnchorOverride = anchorOverride,
            SaveFramePath = saveFramePath,
            DurationSeconds = durationSeconds,
        };
    }
}

internal sealed record LoadedSettings(string Path, MvpSettings Settings);

internal sealed record ProviderSelection(CameraSourceKind ResolvedSource, string Reason, Func<ICameraProvider> CreateProvider);

internal sealed record AvailabilityAssessment(bool IsAvailable, string Message);

internal sealed class RuntimeSnapshot
{
    public bool OpenVrRuntimeAvailable { get; init; }
    public string HmdModel { get; init; } = string.Empty;
    public string HmdDriver { get; init; } = string.Empty;
    public bool HmdHasCameraPropertyKnown { get; init; }
    public bool HmdHasCameraProperty { get; init; }

    public bool IsPicoRuntime =>
        HmdDriver.Contains("pico", StringComparison.OrdinalIgnoreCase) ||
        HmdModel.Contains("pico", StringComparison.OrdinalIgnoreCase);
}

internal readonly record struct ControllerSnapshot(
    ETrackedControllerRole Role,
    uint DeviceIndex,
    bool IsConnected,
    VRControllerState_t State,
    TrackedDevicePose_t Pose);
