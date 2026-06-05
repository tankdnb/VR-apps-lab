# GitHub Research Wave 163 Backlog

- Date: `2026-06-05`
- Theme: `External pose, object, and sensor data to VRChat OSC bridges`
- Status: `Completed`

## Completed Pass

1. Search VRChat OSC tracker, OpenVR object tracking, OptiTrack, MediaPipe,
   Quest/SteamVR FBT, and camera pose-estimation bridge projects.
2. Deduplicate against earlier VMC/VMT/SlimeVR/VRChat OSC and
   axis-vrc-osc-bridge coverage.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect avatar package setup, calibration workflows, OpenVR pose polling,
   matrix math, NatNet rigid body ingestion, OSC tracker endpoint writes,
   Electron/Webcam motion mapping, Python SteamVR tracker scripts, and
   MediaPipe camera calibration.
5. Promote four new repositories and deepen `takana-v/quest_steamvr_fbt_tool`
   from not-studied to Wave 163 studied context.
6. Integrate results into registry, families, methods, not-yet queue, current
   focus, and indexes.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `jangxx/VRC-Tracked-Objects` | Added as full avatar-relative tracked-object OSC bridge donor |
| `FizzyApple12/VRChatOSCOptitrack` | Added as NatNet rigid-body to VRChat OSC tracker bridge reference |
| `rogeraabbccdd/VRChat-MotionOSC` | Added as webcam motion and face-expression OSC controller reference |
| `takana-v/quest_steamvr_fbt_tool` | Promoted from not-studied queue as simple OpenVR-to-OSC FBT script reference |
| `Alpyg/vrc_osc_tracker` | Added as MediaPipe camera pose-estimation OSC tracker reference |

## Useful Follow-Up Work

- Build a pose-ingress comparison matrix across OpenVR, NatNet, MediaPipe,
  VMC, SlimeVR, VMT, and VRChat OSC tracker endpoints.
- Separate calibration workflows into avatar-relative, playspace-relative,
  camera-relative, and device-relative categories.
- Keep the caveat that several useful tracker scripts are proof-of-concept or
  primitive and should be treated as method donors, not product-ready code.

## Not Pursued In This Wave

- No SteamVR, VRChat, OpenVR runtime, OptiTrack/NatNet stream, webcam, MediaPipe
  model, Quest, avatar package, or OSC endpoint was launched.
- No found repository was run, built, installed, or tested.
