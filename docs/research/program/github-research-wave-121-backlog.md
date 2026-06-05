# GitHub Research Wave 121 Backlog

- Date: `2026-06-05`
- Scope: XR-glasses WebHID, desktop-display, IMU, protocol, and virtual-display
  micro-utilities.

## Completed in this wave

- Studied `jakedowns/xreal-webxr` as a browser-side WebHID/protocol probing
  toolkit for XREAL/Nreal Air and Light devices.
- Studied `alexwilson1/nreal_linux_test` as a Linux/X11/GStreamer/OpenCV POC
  for multi-screen capture and head-yaw-driven viewport blending on Nreal Air.
- Studied `Mailbot/Nreal_Air_Desktop_tool` as a thin product reference for
  simple desktop control with Nreal Air glasses.
- Studied `edwatt/real_utilities` as a low-level C++ protocol utility around
  Nreal Air device commands and reports.
- Studied `DannyDesert/XReal-Ultrawide` as a macOS menu-bar app that creates a
  virtual ultrawide canvas, mirrors/captures it, reads XREAL IMU, and maps head
  orientation into a spatial viewport.

## Reuse candidates

- `XReal-Ultrawide` is the strongest donor in this wave for virtual display
  lifecycle, ScreenCaptureKit/Metal viewport rendering, IMU service wrapping,
  smoothing, recenter, and lean-to-zoom UX.
- `xreal-webxr` is the strongest browser-side donor for WebHID device
  filtering, command/report wrappers, IMU packet capture, and firmware/protocol
  exploration surfaces.
- `nreal_linux_test` is valuable as a minimal Linux POC for screen capture,
  calibration prompts, yaw normalization, and viewport slicing across multiple
  real/virtual displays.
- `real_utilities` is useful as a low-level protocol comparison node, though it
  needs a future targeted read if XREAL protocol tooling becomes active.

## Follow-up backlog

1. Compare `XReal-Ultrawide`, `breezy-desktop`, `XRLinuxDriver`, and
   `nreal_linux_test` as virtual-display/shell/driver/Poc layers.
2. Extract a cross-platform `head-tracked display utility` blueprint:
   virtual canvas, capture, IMU service, recenter, smoothing, viewport crop,
   and platform caveats.
3. Revisit `xreal-webxr` if browser-native device diagnostics become a target.
4. Treat `Mailbot/Nreal_Air_Desktop_tool` as product framing only unless source
   code appears later.
5. Keep private API and firmware-command risks visible in any future reuse
   plan.

## Quality notes

- No third-party project was built, launched, installed, or run.
- Already studied XR-glasses anchors were not duplicated as new projects.
- Downloaded source clones belong only in local cache and should be removed
  after the wave is committed.
