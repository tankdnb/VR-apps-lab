# GitHub Research Wave 247 Backlog

Date: 2026-06-06

Theme: Webcam avatar body tracking bridges and VRM motion surfaces.

## Completed In This Wave

- Studied `zekailin00/VR-Full-Body-Tracking-System` as an IMU plus
  headset/controller pose system with ESP8266 HTTP firmware upload, Flask
  tracker and Unity endpoints, shared input/output structs, smoothing buffers,
  IMU-to-body mapping, Unity HMD/controller upload, Unity pose polling, and
  avatar bone application.
- Studied `Raraph84/Cameras-Full-Body-Tracking` as a browser multi-camera
  bridge with HTTPS static serving, WebSocket/WebRTC signaling, MediaPipe
  Tasks Vision, four-corner square calibration, homography/focal estimation,
  DLT triangulation, smoothing, and OSC tracker output.
- Studied `DubbsPi/Mediapipe-SteamVR-Full-Body-Tracking-for-Linux` as a Linux
  CV-to-SteamVR bridge with Python webcam/MediaPipe inference, GUI tuning,
  landmark smoothing, Unix-domain socket packets, and an OpenVR server driver
  exposing generic trackers.
- Studied `yeemachine/kalidoface-3d` as a browser VRM/Vtubing product
  reference with MediaPipe/Kalidokit, Three/VRM, localforage persistence,
  custom backgrounds/stickers, chroma/OBS mode, and P2P voice/social framing.
- Studied `Neleac/MesekaiUnity` as a Unity avatar retargeting donor with pose,
  hand, and face solvers, mirror mode, smoothing, blendshape mapping,
  template-avatar motion transfer, ReadyPlayerMe custom avatars, and Photon
  serialization.
- Added a reusable method entry for camera/avatar tracking bridge pipelines.

## Follow-Up Queue

1. Build a transport matrix comparing HTTP polling, WebSocket/WebRTC, OSC,
   Unix socket, Photon, and OpenVR driver outputs for body tracking.
2. Compare retargeting approaches across MediaPipe Unity, Kalidokit/VRM,
   SteamVR synthetic trackers, and SlimeVR-style tracker bridges.
3. Extract a calibration UX checklist for square calibration, reprojection
   preview, stream identity, offsets, smoothing, and validity feedback.

## Do Not Spend Time On Yet

- Do not run webcam, SteamVR, Flask, Unity, or browser tracking projects.
- Do not copy hardcoded IPs, WiFi credentials, fixed dimensions, or student
  polling loops as reusable architecture.
- Do not treat bundled/minified browser builds as clean code donor evidence.
