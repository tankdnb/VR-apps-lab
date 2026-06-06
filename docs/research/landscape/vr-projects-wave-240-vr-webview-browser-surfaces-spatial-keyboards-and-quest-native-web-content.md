# VR Projects Wave 240: VR WebView Browser Surfaces, Spatial Keyboards, and Quest-Native Web Content

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies Unity Quest WebView samples that turn Android-native web
content into controller or hand-addressable VR surfaces. The useful material is
not "a browser app" by itself, but the input bridge around it: search bars,
world-space keyboard routing, focus handling, WebView capture-mode caveats, and
parallel Meta XR versus XR Interaction Toolkit packaging.

## Why It Matters For `VR-apps-lab`

Many future VR utilities need web panels: docs, dashboards, login-lite flows,
media controls, remote admin pages, local web UIs, or help surfaces. The
TLabWebViewVR family is useful because it exposes the boring but important
parts: texture-backed browser prefab, Android-only constraints, graphics API
fallbacks, text input events, and package variants for different Unity XR
stacks.

## Project Notes

### `TLabAltoh/TLabWebViewVR`

- Interesting idea:
  ship a VR WebView as reusable prefabs for both Meta XR and XR Interaction
  Toolkit instead of binding the browser surface to one scene.
- Code donor value:
  `Assets/TLab/TLabWebViewVR/XRInteractionToolkit/Runtime/XRBrowserInputField.cs`
  connects `TMP_InputField` focus with `XRKeyboard` events and forwards keys
  into the browser through `BrowserContainer.browser.KeyEvent`. The TLab package
  folders split `MetaXR` and `XRInteractionToolkit` samples, each with prefab
  resources and sample scenes. The README documents Quest-only behavior,
  `HardwareBuffer` versus `ByteBuffer`, Vulkan versus OpenGLES caveats, and
  OpenXR Internet-permission setup.
- Product reference value:
  strong donor for in-headset browser or documentation panels where the browser
  is a surface component, not the whole product.
- What to inspect next:
  inspect upstream `TLabWebView` and `TLabVKeyborad` APIs before copying the
  input bridge shape.
- Architecture pattern:
  WebView prefab plus XR-stack-specific package adapters plus spatial keyboard
  focus bridge.
- Reusable method:
  treat browser input as a focus-gated text bridge: UI field focus decides when
  spatial keyboard events are forwarded to the native WebView.
- Caveats:
  Android/Quest focused, WebView does not render in Unity Editor, capture-mode
  and graphics API compatibility must be surfaced in any product settings UI.

### `TLabAltoh/TLabWebViewVR-XRInteractionToolkit-2022`

- Interesting idea:
  keep a minimum Unity 2022 XR Interaction Toolkit sample as a smaller reference
  separate from the larger all-in-one Quest sample.
- Code donor value:
  the sparse pass found a minimal `TLabWebView_XRInteractionToolkit.prefab`,
  `SampleScene.unity`, package manifests, and XR template assets. The README
  says this variant intentionally stays on XRI 2.5.4 because the upgraded Unity
  2021 VR template cannot safely move to XRI 3.x.
- Product reference value:
  useful as a compatibility baseline when a project wants a lightweight XRI
  browser surface without Meta-specific scene samples.
- What to inspect next:
  compare prefab wiring against the main `TLabWebViewVR` XRI prefab after
  upstream submodules are available.
- Architecture pattern:
  minimal sample project around one WebView prefab and a searchbar example.
- Reusable method:
  preserve version-pinned samples when the newer toolkit path is risky.
- Caveats:
  sample is intentionally archived/rebuild-oriented; no broad donor value
  beyond package shape and compatibility notes.

### `TLabAltoh/TLabWebViewVR-OculusIntegration-2022`

- Interesting idea:
  expose a Meta XR specific WebView path with text-area focus/focusout events
  for virtual keyboard visibility.
- Code donor value:
  the prefab contains `TLabWebView_MetaXR`, search bar callbacks into
  `TLab.WebView.SearchBar.LoadUrl`, WebView download/error dialog callbacks,
  and input-field components. The README repeats the Android-only,
  `HardwareBuffer`, Vulkan/OpenGLES, and Unity 6000 caveats, but the important
  addition is keyboard visibility tied to JavaScript focus/focusout events.
- Product reference value:
  good reference for Quest utilities that need web text entry and should not
  show a keyboard unless the browser has focus.
- What to inspect next:
  inspect the JavaScript event bridge in upstream `TLabWebView` to understand
  how text-area focus leaves the native WebView.
- Architecture pattern:
  Meta XR prefab with searchbar, dialog/download callbacks, browser text input,
  and focus-driven keyboard visibility.
- Reusable method:
  use browser DOM focus events as an explicit keyboard lifecycle signal.
- Caveats:
  Meta XR SDK version risk, Unity version caveats, and native Android-only
  rendering limits.

## Reusable Pattern Extraction

- Pattern candidate:
  Quest-native WebView surface with XR keyboard and focus routing.
- Problem solved:
  VR utilities often need web content, but the hard parts are text entry,
  focus, surface rendering, and device/runtime caveats rather than loading a
  URL.
- Reusable core:
  package the WebView as a scene-independent prefab, keep adapter variants per
  XR stack, route keyboard events only when an input field/browser element has
  focus, expose search/load callbacks, and document capture-mode plus graphics
  API fallback settings.
- Source evidence:
  `TLabWebViewVR`, `TLabWebViewVR-XRInteractionToolkit-2022`, and
  `TLabWebViewVR-OculusIntegration-2022`.
- Abstraction boundary:
  keep native WebView plugin code separate from XR input/keyboard adapters;
  keep browser prefab configuration separate from product-specific panels.
- What not to copy:
  hardcoded Unity/editor versions, Android-only assumptions as universal
  behavior, or default `HardwareBuffer`/Vulkan choices without user-visible
  fallback controls.
- Method catalog action:
  add a method entry for VR WebView surfaces with focus-gated keyboard routing.

## Follow-Up Gaps

- Compare TLab WebView input routing with prior VR text-entry and WebView
  keyboard waves.
- Study upstream `TLabWebView` for native Android capture, JavaScript events,
  and browser lifecycle APIs.
- Extract a small "web panel in VR utility" checklist: rendering path, input
  focus, keyboard visibility, permission, graphics fallback, and editor
  placeholder behavior.
