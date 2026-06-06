# GitHub Research Wave 240 Backlog

Date: 2026-06-06

Theme: VR WebView browser surfaces, spatial keyboards, and Quest-native web
content.

## Completed In This Wave

- Studied `TLabAltoh/TLabWebViewVR` as the main Quest WebView sample with
  Meta XR and XR Interaction Toolkit package folders, prefab resources, sample
  scenes, spatial keyboard scene, `XRBrowserInputField` focus-gated key-event
  forwarding, search/load callbacks, Android-only runtime caveats, OpenXR
  Internet permission notes, `HardwareBuffer`/`ByteBuffer`, Vulkan/OpenGLES,
  and Unity 6000 caveats.
- Studied `TLabAltoh/TLabWebViewVR-XRInteractionToolkit-2022` as a minimal
  Unity 2022 XRI browser surface sample with a `TLabWebView_XRInteractionToolkit`
  prefab, searchbar example, package manifests, and XRI 2.5.4 compatibility
  boundary.
- Studied `TLabAltoh/TLabWebViewVR-OculusIntegration-2022` as a Meta XR
  WebView variant with `TLabWebView_MetaXR`, searchbar callbacks, dialog/error
  events, input-field components, and DOM focus/focusout driven virtual
  keyboard visibility.
- Added a reusable method entry for VR WebView surfaces with focus-gated
  keyboard routing and device/rendering fallback controls.

## Follow-Up Queue

1. Inspect upstream `TLabWebView` and `TLabVKeyborad` before any prototype uses
   these patterns.
2. Compare WebView keyboard focus handling with prior VR text-entry, mesh/UV,
   canvas texture, and avatar keyboard methods.
3. Extract a small "web panel in VR utility" checklist covering permission,
   runtime rendering, keyboard focus, pointer routing, graphics fallback, and
   editor placeholder behavior.

## Do Not Spend Time On Yet

- Do not build or deploy the sample projects to Quest during research waves.
- Do not import TLab packages into `VR-apps-lab` until there is a concrete
  prototype branch.
- Do not assume `HardwareBuffer` plus Vulkan is safe across all Android XR
  devices.
