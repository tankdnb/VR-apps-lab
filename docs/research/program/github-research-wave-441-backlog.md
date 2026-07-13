# GitHub Research Wave 441 Backlog: Body Face Hand Tracking and Avatar Motion Donor Stack

Date: 2026-07-13

## Completed

- Studied `Unity-Movement` as a Meta body/face/eye tracking package with setup
  validation, runtime toggles, and retargeting UI.
- Studied `MMVR` as a low-sensor avatar motion pipeline using HMD/controller
  feature vectors, calibration, motion matching, and direction prediction.
- Studied `UnityHandTrackingWithMediapipe` as an Android MediaPipe sidecar that
  streams hand landmarks to Unity over ADB reverse TCP/protobuf.
- Studied `MediaPipeUnityPlugin` as a general Unity graph/task runner with image
  source abstraction, asset loading, CPU/GPU mode, and timestamped packets.

## Follow-Up

- Define a neutral tracking-provider schema covering body, face, eye, hand,
  landmarks, confidence, timestamps, calibration, and retargeting output.
- Compare sidecar transports for landmark data: ADB reverse TCP, UDP, OSC,
  WebSocket, gRPC, logcat, and shared memory.
