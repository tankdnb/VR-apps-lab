# VR Projects Wave 409 - WebView Browser Panel Bridges And Texture-Backed Web Surfaces

- Date: `2026-07-13`
- Scope: Unity/Android/Editor WebView bridges that expose browser content,
  JavaScript callbacks, texture surfaces, native windows, or synthetic input.
- Rule: source/documentation reading only; no builds, installs, launches, or
  device tests were performed.

## Shortlist

- `gree/unity-webview`
- `umetaman/UnityWebView2`
- `olegmrzv/UnityWebViewInEditor`
- `t-34400/UnityWebViewLib`

## Why This Wave Matters

Browser-backed panels are a recurring VR utility need: settings pages,
dashboards, OAuth/device pairing screens, help docs, logs, media controls, and
remote diagnostics all want web UI. The main architecture decision is whether
the browser is a native overlay outside the 3D scene, a captured texture in the
scene, or an editor/runtime bridge for tooling.

## Project Notes

### `gree/unity-webview`

- Interesting idea: cross-platform Unity WebView wrapper with native
  WebView/WKWebView/WebView2 implementations and JavaScript callbacks.
- Architecture pattern: `WebViewObject` centralizes callbacks, margins,
  visibility, native object handles, and platform-specific lifecycle branches.
- Code donor value: strong callback/lifecycle matrix for URL loading, JS
  messages, errors, HTTP errors, focus, texture update cost, permissions, and
  platform caveats.
- Product reference value: useful baseline for companion-app or desktop-tool
  web panels where native overlay ownership is acceptable.
- Source evidence: `plugins/WebViewObject.cs`, platform plugin folders, README
  sections for Android, iOS, Mac, Windows WebView2, and Fragment variants.
- Reusable core: one wrapper facade over platform WebView lifecycle, callbacks,
  and rectangle/margin placement.
- What not to copy: its own README warns native mobile views overlay Unity's
  rendering view and do not become true 3D surfaces; for VR use, treat that as a
  caveat unless using Windows texture capture or a non-HMD companion view.
- What to inspect next: split native-overlay and texture-backed approaches in
  future utility architecture notes.

### `umetaman/UnityWebView2`

- Interesting idea: minimal Unity/Windows WebView2 bridge driven by a UI
  `RectTransform` and native P/Invoke calls.
- Architecture pattern: C# component maps Unity UI rectangle to native WebView2
  bounds, while `WebView2Native` owns create/navigate/update/close calls.
- Code donor value: compact reference for native WebView2 ownership and
  rectangle synchronization from Unity UI.
- Product reference value: good for desktop-side control surfaces, launcher
  panels, and Windows companion tooling around a VR utility.
- Source evidence: `WebView2Unity.cs`, `WebView2Native.cs`, and `UIHelper`.
- Reusable core: native browser lifecycle behind a small C# facade.
- What not to copy: does not solve true in-headset texture interaction by
  itself.
- What to inspect next: pair with texture-backed Android/WebViewLib patterns to
  define a platform-agnostic browser-panel abstraction.

### `olegmrzv/UnityWebViewInEditor`

- Interesting idea: Unity Editor `WebView` wrapper with JavaScript-to-C# bridge
  via hidden editor APIs.
- Architecture pattern: reflection wrapper over internal `UnityEditor.WebView`
  APIs, `DefineScriptObject`, delegate object, file/URL load, and JS execution.
- Code donor value: useful for research tooling, documentation preview panes,
  internal inspectors, or editor-side Web UI without leaving Unity.
- Product reference value: confirms that a web bridge can be an authoring tool,
  not only a runtime VR panel.
- Source evidence: `WebWindow.cs` and `WebProvider.cs`.
- Reusable core: editor-only web panel plus JS callback bridge.
- What not to copy: internal Unity editor APIs are fragile; keep this as an
  editor-tool pattern, not runtime infrastructure.
- What to inspect next: whether a research assistant/editor plugin could use
  this bridge for browsing project notes or local docs.

### `t-34400/UnityWebViewLib`

- Interesting idea: Android WebView rendered as bytes/frames for Unity, with
  synthetic touch input and JavaScript bridge support.
- Architecture pattern: `WebViewUnityBridge` manages WebView, bitmap manager,
  Unity callbacks, instance pool, lifecycle monitor, touch injection, and
  keyboard state; `WebViewController` owns Android WebView settings and JS
  interface registration.
- Code donor value: strongest donor in this wave for in-world browser panels:
  texture frames, `sendTouchDown/Move/Up`, `evaluateJavascript`, frame bytes,
  lifecycle, and permission handling.
- Product reference value: useful for headset-side dashboards where web content
  must become a real VR surface rather than a phone/desktop overlay.
- Source evidence: `WebViewUnityBridge.kt`, `WebViewController.kt`,
  `WebViewBitmapManager`, and injected input-monitor script path.
- Reusable core: texture-backed WebView surface with synthetic input bridge and
  explicit lifecycle manager.
- What not to copy: Android-only implementation details and WebView permission
  policy should be isolated behind a platform adapter.
- What to inspect next: combine with Godot SubViewport and Unity render-texture
  UI methods for a general `browser panel as VR surface` pattern.

## Extracted Method Candidate

`Texture-backed WebView panel bridge with synthetic input`: browser content is
owned by a native WebView, copied or rendered into a texture/frame buffer, and
controlled through synthetic touch/mouse/keyboard plus JavaScript callback
channels.

## Follow-Up

- Keep native overlay and texture-backed browser panels as separate method
  variants.
- Revisit Waves 39, 56, 136, 150, 175, 208, and 225 for browser-backed overlay
  overlap.
