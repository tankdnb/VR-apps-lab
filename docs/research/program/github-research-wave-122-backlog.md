# GitHub Research Wave 122 Backlog

- Date: `2026-06-05`
- Scope: camera/MediaPipe tracking bridges for SlimeVR, VRChat, VRM, Unity,
  and virtual-controller outputs.

## Completed in this wave

- Studied `TkskKurumi/SlimeVR-Tracker-Mediapipe` as a Python MediaPipe body
  tracker that derives limb axes, smooths quaternions, calibrates by pose
  neighborhood, and sends SlimeVR-compatible UDP tracker packets.
- Studied `hotaru86/MediapipeFaceTracking_VRC` as a Python webcam face tracker
  for VRChat that maps MediaPipe face blendshapes into OSC-style avatar
  parameters.
- Studied `how-people-lived/mediapipe-vrm-tracking` as a browser-only
  MediaPipe/VRM face, hand, and arm tracking app with ARKit-compatible
  blendshape intent.
- Studied `Metastazius/VRBodyTrack` as a Python MediaPipe world-landmark
  server plus Unity avatar project connected through a Windows named pipe.
- Studied `vwitted/mediapipe_VR_controller` as a minimal MediaPipe Hands to
  virtual-controller OSC bridge.

## Reuse candidates

- `SlimeVR-Tracker-Mediapipe` is the strongest donor for landmark-to-axis,
  quaternion smoothing, calibration lookup, and SlimeVR UDP packet anatomy.
- `MediapipeFaceTracking_VRC` and `mediapipe-vrm-tracking` are useful
  references for camera face tracking into avatar-facing expression models.
- `VRBodyTrack` is useful for Python camera process plus Unity consumer
  separation, but the checked-in Unity cache/build artifacts are a caveat.
- `mediapipe_VR_controller` is a tiny proof that even one wrist landmark can
  validate a virtual-controller transport.

## Follow-up backlog

1. Compare MediaPipe bridge outputs across SlimeVR UDP, VMT/OSC, VRChat OSC,
   Unity pipes, and browser-local VRM.
2. Extract a generic `camera landmark bridge` blueprint: capture, landmark
   confidence, axis construction, smoothing, calibration, transport, and target
   schema.
3. Revisit `MasonSakai/VR-AI-Full-Body-Tracking` only if a future pass needs
   the InputEmulator-era lineage.
4. Keep micro-bridge caveats visible: hardcoded camera indices, local ports,
   target schemas, and fragile calibration.

## Quality notes

- No third-party project was built, launched, installed, or run.
- Projects were treated as reference bridges, not as production-ready tracking
  systems.
- Downloaded source clones belong only in local cache and should be removed
  after the wave is committed.
