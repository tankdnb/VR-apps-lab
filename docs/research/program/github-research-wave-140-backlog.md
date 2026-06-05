# GitHub Research Wave 140 Backlog

- Date: `2026-06-05`
- Scope: WebXR engine/export bridges, device-display adapters, composition
  layers, browser test scaffolds, and showcase feature flows.

## Completed in this wave

- Studied `De-Panther/unity-webxr-export` as a Unity XR loader package that
  serializes reference spaces, optional features, framebuffer scale, manager
  autoload, and XR subsystem choices into the WebGL bridge.
- Studied `Rufus31415/Simple-WebXR-Unity` as a tiny Unity WebXR bridge with a
  single session component, shared JS/C# arrays, input source events, hit-test
  state, and editor simulation.
- Studied `Looking-Glass/looking-glass-webxr` as a non-HMD WebXR device
  adapter that wraps the polyfill device model, redirects canvas/window
  lifecycle, and renders multi-view/quilt-style output.
- Studied `immersive-web/webxr-layers-polyfill` as a session-patching layers
  shim with WebGL/media bindings and projection, quad, cube, cylinder, and
  equirect renderers.
- Studied `immersive-web/webxr-test-api` as a deterministic testing surface for
  simulated XR devices, views, poses, input sources, hit-test worlds, and DOM
  overlay pointer events.
- Studied `meta-quest/webxr-showcases` as product-scale WebXR examples for
  anchors, plane detection, measurement, controller input, pointer modes, and
  product configuration.

## Reuse candidates

- `unity-webxr-export` and `Simple-WebXR-Unity` are the strongest donors for
  engine-to-browser bridge boundaries.
- `looking-glass-webxr` is a strong reference for non-HMD XR display adapters.
- `webxr-layers-polyfill` and `webxr-test-api` are infrastructure references
  rather than product references.
- `webxr-showcases` is a compact product UX reference set for feature-gated
  browser XR scenes.

## Follow-up backlog

1. Compare Unity WebXR export settings with Godot/A-Frame/WebXR toolkit
   feature-gating models.
2. Extract a browser-XR feature matrix covering reference spaces, hit-test,
   hand tracking, layers, anchors, plane detection, and depth/light modules.
3. Consider a small `WebXR utility shell` reuse plan if browser-backed overlay
   or setup-panel work becomes active.
4. Pair `webxr-test-api` with local fake-device/no-HMD flows from previous
   OpenVR/OpenXR waves.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
