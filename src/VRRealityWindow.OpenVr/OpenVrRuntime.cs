using System.Text;
using Valve.VR;

namespace VRRealityWindow.OpenVr;

public sealed class OpenVrRuntime : IDisposable
{
    private bool _initialized;

    public CVRSystem System { get; private set; } = null!;

    public CVROverlay Overlay => Valve.VR.OpenVR.Overlay;

    public CVRTrackedCamera TrackedCamera => Valve.VR.OpenVR.TrackedCamera;

    public void Initialize(EVRApplicationType applicationType)
    {
        if (_initialized)
        {
            return;
        }

        var error = EVRInitError.None;
        System = Valve.VR.OpenVR.Init(ref error, applicationType);

        if (error != EVRInitError.None || System is null)
        {
            throw new InvalidOperationException($"OpenVR init failed: {error}");
        }

        _initialized = true;
    }

    public bool IsInitialized => _initialized;

    public bool TryGetHmdPose(out HmdMatrix34_t pose, ETrackingUniverseOrigin origin = ETrackingUniverseOrigin.TrackingUniverseStanding)
    {
        EnsureInitialized();

        var poses = new TrackedDevicePose_t[Valve.VR.OpenVR.k_unMaxTrackedDeviceCount];
        System.GetDeviceToAbsoluteTrackingPose(origin, 0f, poses);

        var hmdPose = poses[Valve.VR.OpenVR.k_unTrackedDeviceIndex_Hmd];
        if (!hmdPose.bDeviceIsConnected || !hmdPose.bPoseIsValid)
        {
            pose = default;
            return false;
        }

        pose = hmdPose.mDeviceToAbsoluteTracking;
        return true;
    }

    public uint GetControllerIndex(ETrackedControllerRole role)
    {
        EnsureInitialized();
        return System.GetTrackedDeviceIndexForControllerRole(role);
    }

    public bool TryGetControllerState(ETrackedControllerRole role, out uint deviceIndex, out VRControllerState_t state, out TrackedDevicePose_t pose)
    {
        EnsureInitialized();

        deviceIndex = GetControllerIndex(role);
        state = default;
        pose = default;

        if (deviceIndex == Valve.VR.OpenVR.k_unTrackedDeviceIndexInvalid)
        {
            return false;
        }

        return System.GetControllerStateWithPose(
            ETrackingUniverseOrigin.TrackingUniverseStanding,
            deviceIndex,
            ref state,
            (uint)global::System.Runtime.InteropServices.Marshal.SizeOf<VRControllerState_t>(),
            ref pose);
    }

    public bool TryGetHasCamera(uint deviceIndex, out bool hasCamera)
    {
        EnsureInitialized();

        hasCamera = false;
        var error = ETrackedPropertyError.TrackedProp_Success;
        hasCamera = System.GetBoolTrackedDeviceProperty(deviceIndex, ETrackedDeviceProperty.Prop_HasCamera_Bool, ref error);
        return error == ETrackedPropertyError.TrackedProp_Success;
    }

    public string GetTrackedDeviceString(uint deviceIndex, ETrackedDeviceProperty property)
    {
        EnsureInitialized();

        var error = ETrackedPropertyError.TrackedProp_Success;
        var builder = new StringBuilder(256);
        System.GetStringTrackedDeviceProperty(deviceIndex, property, builder, (uint)builder.Capacity, ref error);
        return error == ETrackedPropertyError.TrackedProp_Success ? builder.ToString() : string.Empty;
    }

    public void EnsureInitialized()
    {
        if (!_initialized)
        {
            throw new InvalidOperationException("OpenVR runtime is not initialized.");
        }
    }

    public void Dispose()
    {
        if (_initialized)
        {
            Valve.VR.OpenVR.Shutdown();
            _initialized = false;
        }
    }
}
