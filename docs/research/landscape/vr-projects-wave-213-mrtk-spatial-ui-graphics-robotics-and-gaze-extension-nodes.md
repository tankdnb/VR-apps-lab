# VR Projects Wave 213: MRTK Spatial UI, Graphics, Robotics, and Gaze Extension Nodes

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-213-plan.md`
- `docs/research/program/github-research-wave-213-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

Spatial utility UI becomes easier to reuse when interaction, visual feedback,
data binding, placement, accessibility, and extension services are separate
contracts. MRTK and adjacent packages are useful because they make these
contracts explicit.

Wave 213 extracts those contracts without treating MRTK itself as the only
future platform for `VR-apps-lab`.

## Project Findings

### `MixedRealityToolkit/MixedRealityToolkit-Unity`

- Interesting idea: MRTK3 decomposes mixed-reality UX into packages for input,
  spatial manipulation, UX components, data binding, diagnostics, accessibility,
  and tools, instead of hiding everything inside one UI framework.
- Code donor value: very high. `StatefulInteractable.cs` models select/toggle,
  gaze/far dwell, voice keywords, timed flag changes, and event state.
  `PressableButton.cs` separates press progress from visuals and handles
  push-plane logic, proximity hover, and rolloff rejection. Data binding
  documentation and `DataConsumerCollection.cs` show data sources, key paths,
  list paging, prefab pooling, item placers, and predictive prefetch.
  `SolverHandler.cs` abstracts tracked targets and offsets. Accessibility
  classes expose provider-owned object classification and text-color inversion.
- Product reference value: very high for spatial panels, menus, slates, lists,
  and accessible interaction systems.
- Architecture pattern: package-level feature split plus component contracts for
  interaction state, data binding, placement, and accessibility.
- Reusable method: keep UI state machines, visual response, data source,
  placement solver, and accessibility provider separate.
- Constraints and caveats: Unity/XRI/OpenXR assumptions, package versioning,
  and MRTK-specific component names should not be copied blindly.
- What to inspect next: hand menus, slate behavior, dialog/list UX, and
  diagnostics package boundaries.
- Why it matters for `VR-apps-lab`: it is the strongest source in this wave for
  engine-facing spatial UI contracts.

#### Reusable Pattern Extraction

- Pattern candidate: layered spatial UI package boundary.
- Problem solved: build complex spatial UI without binding input state, visuals,
  data, placement, and accessibility into one untestable object.
- Reusable core: interactable state machine, press/toggle/dwell state,
  data-source key paths, pooled list consumers, placement solver, visual
  material feedback, and accessibility provider.
- Source evidence: `StatefulInteractable.cs`, `PressableButton.cs`,
  `DataConsumerCollection.cs`, `SolverHandler.cs`, `AccessibilitySubsystem.cs`,
  and `TextAccessibility.cs`.
- Abstraction boundary: input state, data binding, visual rendering, placement,
  and accessibility each own separate responsibilities.
- What not to copy: MRTK package names, Unity-only lifecycle assumptions, or
  experimental data-binding APIs without version review.
- Method catalog action: create Method 658.

### `microsoft/MixedReality-GraphicsTools-Unity`

- Interesting idea: spatial UI feedback can be implemented as a dedicated
  graphics package with shader/material utilities rather than ad hoc visual
  scripts inside every button or panel.
- Code donor value: high. `ProximityLight.cs` pushes global shader state for
  near-hand highlights. `CanvasMaterialAnimatorBase.cs` exposes material
  properties to animation flows. `MeshInstancer.cs` batches instances with
  per-instance material properties and diagnostics. `AccessibilityUtilities.cs`
  toggles text inversion shader keywords. `MagnifierManager.cs` injects URP
  renderer features for magnification.
- Product reference value: high for polished spatial feedback, readable text,
  performance-aware scene decoration, and accessibility visuals.
- Architecture pattern: visual fidelity package that serves UI components
  through shader/material contracts.
- Reusable method: treat proximity, magnification, text inversion, instancing,
  and material animation as reusable visual services.
- Constraints and caveats: Unity URP/shader assumptions and generated animator
  code need platform-specific adaptation.
- What to inspect next: sample scenes that combine Graphics Tools with MRTK UX
  components.
- Why it matters for `VR-apps-lab`: it reinforces the separation between UI
  logic and visual-material feedback.

### `ms-iot/ros_msft_mrtk`

- Interesting idea: robotics or device integration can be surfaced in MRTK as
  extension services, provider/renderer pairs, and hand-menu calibration
  commands.
- Code donor value: medium. `ROS2Listener.cs` owns the ROS2 node lifecycle and
  spins from Unity update. `ROS2LidarSubscription.cs` exposes an `ILidarDataProvider`.
  `LidarVisualizer.cs` separates topic/provider/renderer factories and render
  cadence. `SpatialPinningService.cs` handles QR watcher events, permissions,
  transform listener state, and main-thread event queues. `ROSHandMenuHandler.cs`
  binds calibration to the MRTK hand menu.
- Product reference value: medium for spatial calibration and sensor
  visualization flows.
- Architecture pattern: MRTK extension service plus sensor provider/renderer
  plus hand-menu action.
- Reusable method: keep external runtime state behind a service and make
  calibration an explicit spatial action.
- Constraints and caveats: archived repository, old HoloLens/ROS2 stack,
  platform permissions, and robotics-specific assumptions.
- What to inspect next: spatial pinning event lifecycle and how calibration
  status was presented to users.
- Why it matters for `VR-apps-lab`: it is a compact donor for service-backed
  calibration menus.

### `The-COGAIN-Association/EyeMRTK`

- Interesting idea: gaze input can be normalized into ray sources, smoothed,
  classified into fixations/saccades, dispatched as interaction events, and
  confirmed through dwell, mouse, controller, or head gestures.
- Code donor value: medium to high. `OutputRay.cs` normalizes raw, smooth,
  fixation, saccade, reticle, laser, and custom rays. `ProcessGaze.cs` handles
  smoothing history, velocity, and saccade onset. `InteractionRay.cs` emits
  ray enter/exit/in events. `GazeInteractionGeneric.cs` tracks per-object
  pointing status, dwell timers, progress, frame-loss grace, and confirmation.
- Product reference value: high for accessibility, hands-free interaction, and
  gaze-assisted menu flows.
- Architecture pattern: source-specific gaze providers plus normalized ray
  pipeline plus generic interaction events.
- Reusable method: separate gaze source adapters from smoothing, event dispatch,
  dwell progress, and confirmation rules.
- Constraints and caveats: Unity 2017-era code, old Tobii/SMI/Pupil SDKs, and
  legacy SteamVR assumptions.
- What to inspect next: dwell UX, frame-loss grace behavior, and how source
  confidence could be surfaced in a modern UI.
- Why it matters for `VR-apps-lab`: it gives a reusable alternate-input
  pipeline for future accessibility-aware VR utilities.

## Cross-Project Lessons

- Mature spatial UI needs layered contracts: input state, visual response, data,
  placement, accessibility, and runtime extensions.
- Graphics feedback should be a shared service, not copy-pasted into each
  interactable.
- Calibration and external-service actions belong in visible spatial controls,
  not hidden developer menus.
- Alternate input such as gaze needs a normalization and confirmation pipeline,
  not one-off raycast code.

## Method Catalog Actions

- Added Method 658: spatial UI package boundary with interaction, data,
  visual, and accessibility layers.

## Follow-Up Gaps

- Compare MRTK hand menus, data-bound lists, and accessibility providers with
  VRChat/Udon and WebXR spatial UI patterns.
- Translate EyeMRTK's gaze-source pipeline into a modern engine-neutral method
  note.
- Build a small checklist for future spatial UI prototypes: state machine,
  visual material response, data binding, placement, accessibility, and
  diagnostics.
