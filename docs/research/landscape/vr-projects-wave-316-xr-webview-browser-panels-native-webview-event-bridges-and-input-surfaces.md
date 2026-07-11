# Wave 316 - XR WebView Browser Panels, Native WebView Event Bridges, and Input Surfaces

This wave studies XR browser-panel implementations as reusable references for
native WebView hosting, texture capture, pointer and keyboard routing, event
policy surfaces, and engine-side browser panel integration.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Quest and Android-native WebView bridges for Unity XR;
- world-space browser panels and pointer/UV input paths;
- browser event, permission, and download callback surfaces;
- thin integration samples that show how browser panels connect to XR
  interaction stacks.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `rwpersson/OpenWebView-Unity` | Full native WebView bridge for Unity/Quest | Studied | Strong donor for native Android WebView hosting, texture capture, event relay, and browser policy boundaries |
| `t-34400/SimpleUnity3DWebView` | Minimal Android/Quest browser panel | Studied | Compact baseline for pointer mapping, Java bridge, texture updates, and lightweight 3D browser surfaces |
| `vuplex/meta-xr-webview-example` | Thin Meta XR integration sample | Studied | Product/reference value for Meta XR-specific setup and prefab integration rather than browser core architecture |
| `vuplex/xr-interaction-webview-example` | Thin XRI browser-panel integration sample | Studied | Good checklist for connecting a browser surface to XR Interaction Toolkit ray/input plumbing |

## Code-Level Findings

### `rwpersson/OpenWebView-Unity`

- Interesting idea:
  a reusable XR browser shell becomes much stronger when native page hosting,
  texture transport, input routing, and browser policy callbacks are all kept
  explicit instead of hidden behind one prefab.
- Code donor value:
  very high. The project splits panel logic (`OpenWebView.cs`,
  `WebViewPanel.cs`), native bridge (`OpenWebViewNativePlugin.cs`), callback
  routing (`WebViewCallbackRelay.cs`), and sample controls
  (`WebViewDemoController.cs`) into clear seams. The Android side uses a real
  `WebView` rendered through `Presentation`/`VirtualDisplay`, then copied into a
  Unity texture path rather than treating browser rendering as opaque magic.
  The event surface is unusually rich: URL/title/progress, JS dialogs, new
  windows, SSL/auth, file chooser, downloads, permissions, external schemes,
  text selection, context menu, scroll, and request blocking are all explicit.
- Product reference value:
  very high for browser-first XR tools, in-headset dashboards, documentation
  panels, and remote-control/operator shells that need a full browser rather
  than a static texture.
- What to inspect next:
  GPU or zero-copy transport maturity, keyboard/focus ownership across
  different shells, multi-window policy, and how stable the plugin remains
  across Unity/Quest/Android version drift.
- Reusable pattern extraction:
  keep `native page host`, `texture transport`, `input mapper`, and `browser
  policy/event bridge` separate.

### `t-34400/SimpleUnity3DWebView`

- Interesting idea:
  a smaller browser-panel donor can still be valuable if it isolates the
  minimum viable bridge between a Unity surface, pointer source, Java calls,
  and texture refresh path.
- Code donor value:
  medium-high. `WebViewManager.cs` owns the main browser lifecycle while
  `PointerEventSource.cs`, `WebViewJavaBridge.cs`, `WebViewTextureUpdater.cs`,
  and `WebViewDataReceiver.cs` keep pointer UV mapping, Java/native calls, and
  texture updates visible. Compared with `OpenWebView-Unity`, it is far thinner
  on policy hooks, but that simplicity is useful when the desired product is a
  narrow browser panel instead of a full browser framework.
- Product reference value:
  medium-high for quick browser notes, documentation panes, kiosk-like panels,
  or smaller Quest utilities where a very broad browser event surface is not
  required.
- What to inspect next:
  keyboard/text-entry ownership, texture update cadence under heavier content,
  and whether the input bridge scales to more complex browser UX.
- Reusable pattern extraction:
  keep `surface manager`, `pointer source`, `Java bridge`, and `texture update
  loop` separate.

### `vuplex/meta-xr-webview-example`

- Interesting idea:
  even a thin vendor sample is useful when it shows the minimum scene and
  component shape needed to put a browser panel into a specific XR stack.
- Code donor value:
  low-medium. The visible code is mostly setup-level glue around a prefab and
  Meta XR integration path rather than a reusable browser core.
- Product reference value:
  medium-high for teams that need a quick Meta XR example of how a browser
  panel is expected to sit inside a headset-oriented scene.
- What to inspect next:
  whether broader Vuplex samples expose stronger keyboard, focus, file upload,
  or permission-management seams than this thin example.
- Reusable pattern extraction:
  keep this as an `integration checklist and prefab reference`, not as the main
  donor for browser internals.

### `vuplex/xr-interaction-webview-example`

- Interesting idea:
  XR browser integrations often fail at the interaction seam, so a sample that
  shows exact XRI raycaster and event-camera expectations is still worth
  documenting.
- Code donor value:
  low-medium. The strongest value is the interaction wiring around the browser
  prefab rather than deep browser implementation details.
- Product reference value:
  high as an XRI compatibility checklist: world-space canvas expectations,
  tracked-device raycasting, and event-system setup are all the practical seams
  that tend to cause friction.
- What to inspect next:
  keyboard and text-entry handoff within XRI, direct-interaction support, and
  how to keep browser focus explicit when multiple input modules coexist.
- Reusable pattern extraction:
  keep this as an `interaction-stack integration reference`, not as a browser
  engine donor.

## Reusable Pattern Extraction

- Pattern candidate:
  XR WebView/browser surface boundary across native page host, texture capture,
  pointer and keyboard routing, event-policy callbacks, and engine-side panel
  integration.
- Problem solved:
  XR browser panels become fragile when native hosting, page events, texture
  transport, and input ownership are fused into one prefab with hidden
  assumptions.
- Reusable core:
  native page host, texture capture or transport path, panel surface manager,
  pointer-to-UV mapper, keyboard/focus owner, JS/app message bridge, page
  policy callbacks, and XR interaction-stack adapter.
- Source evidence:
  `rwpersson/OpenWebView-Unity`, `t-34400/SimpleUnity3DWebView`,
  `vuplex/meta-xr-webview-example`, and
  `vuplex/xr-interaction-webview-example`.
- Abstraction boundary:
  keep browser core, texture/input transport, and engine-specific interaction
  integration separate.
- What not to copy:
  browser prefabs that hide focus and keyboard ownership, vendor-sample setup
  treated as a complete browser architecture, or Android/Quest assumptions
  baked directly into product logic without capability checks.
- Method catalog action:
  add an XR WebView/browser surface method.

## Follow-Up Gaps

- Deepen the Android/native side of `OpenWebView-Unity` around GPU transport,
  file chooser, download, and permission handling.
- Compare Quest browser panels against non-Unity or non-Android equivalents to
  separate engine-specific and platform-specific constraints.
- Revisit text-entry and focus ownership specifically as a cross-wave bridge
  between browser panels and the keyboard/text-entry studies.
