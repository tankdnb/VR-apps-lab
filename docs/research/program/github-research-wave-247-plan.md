# GitHub Research Wave 247 Plan

Date: 2026-06-06

Theme: Webcam avatar body tracking bridges and VRM motion surfaces.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

After the tracker hardware wave, this wave studies software bridges that turn
camera, IMU, or headset/controller inputs into avatar motion, synthetic tracker
poses, OSC output, or VRM/Vtubing surfaces. The focus is the pipeline boundary,
not whether the tracking quality is production-ready.

## Search Families

- Webcam and MediaPipe body tracking.
- Camera-to-OSC and camera-to-SteamVR bridges.
- Browser VRM/Vtubing surfaces.
- Unity avatar retargeting and multiplayer motion replication.
- IMU plus headset/controller pose solver prototypes.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `zekailin00/VR-Full-Body-Tracking-System` | ESP8266 IMU firmware, Flask pose solver, Unity HMD/controller upload, and Unity pose polling/apply loop. | IMU/HTTP pose solver reference |
| `Raraph84/Cameras-Full-Body-Tracking` | Browser/WebRTC multi-camera MediaPipe bridge with four-corner calibration, DLT triangulation, smoothing, and OSC output. | Camera-to-OSC donor |
| `DubbsPi/Mediapipe-SteamVR-Full-Body-Tracking-for-Linux` | Python MediaPipe process feeding a Linux OpenVR server driver through a Unix socket. | CV-to-SteamVR driver donor |
| `yeemachine/kalidoface-3d` | Browser VRM/Vtubing product surface with MediaPipe/Kalidokit, local personalization, OBS mode, and P2P voice framing. | Browser avatar product reference |
| `Neleac/MesekaiUnity` | Unity MediaPipe avatar solvers, ReadyPlayerMe retargeting, blendshape transfer, and Photon network replication. | Unity retargeting donor |

## Dedupe Notes

Existing registry entries cover KinectToVR, SlimeVR, OSC bridges, WebSocket
bridges, tracker hardware, avatar embodiment, and CV tracking. This wave keeps
only projects that add a new pipeline boundary: HTTP IMU+Unity loop,
browser-WebRTC triangulation to OSC, Linux CV-to-driver socket, browser VRM
product flow, or Unity template-avatar retargeting.

## Code-Level Pass Targets

- Sensor/camera capture boundaries.
- Calibration and smoothing.
- Transport: HTTP, WebRTC, WebSocket, OSC, Unix socket, Photon.
- Pose solving and retargeting.
- Synthetic tracker output and avatar bone/blendshape application.
- Product UX around model import, tuning, and streaming.

## Expected Outputs

- Wave 247 landscape synthesis.
- Registry/family entry for webcam/avatar body tracking bridges.
- Method catalog entry for camera/avatar tracking bridge pipelines.
- Follow-up backlog for transport, calibration, and retargeting matrices.
