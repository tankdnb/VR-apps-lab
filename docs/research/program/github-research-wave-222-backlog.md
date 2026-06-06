# GitHub Research Wave 222 Backlog

Date: 2026-06-06

Theme: cockpit hand-clicking, calibration, observer, and passthrough
microhelpers.

## Completed In This Wave

- Studied `fredemmott/HTCC` as a safety-bounded OpenXR API layer that hides
  raw hand tracking from target apps, reads hand/aim/PointCTRL sources, and
  exposes virtual controller, pointer, click, scroll, and app-specific cockpit
  actions through per-exe configuration.
- Studied `galister/motoc` as a Monado/WiVRn tracking-origin calibration CLI
  with device/origin enumeration, sampled SVD calibration, continuous offset
  smoothing, recentering, monitor mode, saved JSON profiles, anomaly handling,
  and transform serialization.
- Studied `dag10/HoloViveObserver` as a historical HoloLens/Vive observer
  prototype with Unity cloud multiplayer, VR/HoloLens player roles, alignment
  manager events, controller-click calibration, and legacy build/artifact
  caveats.
- Studied `yshui/index_camera_passthrough` as a Linux camera-to-overlay
  passthrough helper with V4L Index camera discovery, one-buffer capture,
  Vulkan YUYV/correction/projection pipeline, HMD/sticky/absolute positioning,
  two-controller toggle state, and OpenVR/OpenXR backend trait boundary.
- Added a reusable method entry for purpose-bounded VR input, calibration, and
  display helper translation.

## Follow-Up Queue

1. Build a microhelper safety matrix: input source, translated action, target
   app/runtime, configuration authority, wake/sleep state, and caveats.
2. Compare HTCC with previous hand/controller emulation waves to separate
   API-layer translation from virtual driver approaches.
3. Compare `motoc` with OpenVR Space Calibrator lineage and note what Monado
   exposes more cleanly through tracking-origin APIs.
4. Revisit Linux passthrough and camera capture projects if camera-to-overlay
   surfaces become active prototype scope.
5. Keep HoloViveObserver as historical alignment UX only unless a modern
   shared-observer project appears.

## Do Not Spend Time On Yet

- Do not run cockpit simulators, Monado tools, camera capture, or Unity builds.
- Do not treat HoloViveObserver as modern production code.
- Do not copy simulator-specific action maps or Linux hardware assumptions as
  defaults.
