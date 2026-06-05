# GitHub Research Wave 163 Plan

- Date: `2026-06-05`
- Theme: `External pose, object, and sensor data to VRChat OSC bridges`
- Scope: OpenVR tracked-object bridges, OptiTrack/NatNet to OSC trackers,
  webcam/MediaPipe motion controls, Quest/SteamVR FBT scripts, and camera pose
  estimation trackers.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier tracker waves covered SlimeVR, VMT, OpenVR drivers, VMC, and
avatar-facing OSC helpers. Wave 163 focuses on external data ingress into
VRChat's OSC tracker or avatar-parameter boundary: real objects, mocap rigs,
webcam pose estimation, and SteamVR devices bridged through OSC.

## Search Families

- VRChat OSC tracker bridges
- OpenVR tracked-object utilities
- OptiTrack/NatNet VRChat adapters
- Quest/SteamVR FBT scripts
- webcam and MediaPipe motion-to-OSC tools
- avatar-side calibration and tracked-object setup helpers

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `jangxx/VRC-Tracked-Objects` | Full tracked-object app with avatar package, calibration, OpenVR pose math, and OSC state | Avatar-relative tracked object bridges |
| `FizzyApple12/VRChatOSCOptitrack` | NatNet rigid bodies to VRChat OSC tracker endpoints with ImGui/OpenGL visualizer | Mocap-system to OSC tracker bridges |
| `rogeraabbccdd/VRChat-MotionOSC` | Electron/Webcam/MediaPipe-style motion and face-expression OSC controller | Vision-based motion controls |
| `takana-v/quest_steamvr_fbt_tool` | Python OpenVR to `/tracking/trackers` bridge for SteamVR trackers and Quest/PC VRChat use | SteamVR tracker to OSC FBT bridges |
| `Alpyg/vrc_osc_tracker` | MediaPipe pose landmarker to hip/foot/head OSC tracker messages with calibration commands | Camera pose-estimation OSC trackers |

## Dedupe Notes

- `axis-vrc-osc-bridge` and several VRChat OSC utilities were already covered
  earlier and remain comparison context.
- `takana-v/quest_steamvr_fbt_tool` was previously listed as not studied
  deeply and is promoted by this wave.

## Code-Level Pass Targets

- avatar package contract and expression/menu requirements;
- OpenVR device selection, serial lookup, and pose polling;
- controller-relative object calibration matrices;
- OSC tracker endpoint naming and bundling;
- NatNet rigid body conversion and visualization;
- MediaPipe pose mapping, camera calibration, and tracker smoothing;
- config, status, thread/process, and caveat handling.

## Expected Outputs

- New Wave 163 landscape synthesis.
- Registry/family updates for external pose/object/sensor to VRChat OSC
  bridges.
- Methods around avatar-relative tracked objects, NatNet-to-OSC tracker
  bridges, webcam motion controllers, simple SteamVR-to-OSC FBT scripts, and
  camera-calibrated MediaPipe tracker senders.
