# VR Projects Wave 126: Immersive Browser Shells, WebXR Runtimes, Home Spaces, and Spatial Web Frontends

- Date: `2026-06-05`
- Goal: study immersive browser and spatial web shell projects as references
  for multi-window VR browser architecture, WebXR runtime shims, spatial home
  scenes, menu/front-end split, and headset-native browser UX.

## Why this wave exists

Browser-in-VR projects are larger than most `VR-apps-lab` utilities, but they
teach important architecture:

- shell activity and native render world split;
- windows, sessions, tabs, panels, and widgets;
- keyboard, tray, navigation, and permission surfaces;
- WebXR interstitials and immersive-mode escape UX;
- environment/home-space management;
- WebXR runtime emulation and JS API boundaries.

This wave studies them as reference architecture, not as code to vendor into
the repository.

## Better workflow used in this wave

1. searched GitHub by immersive browser, WebXR browser, Firefox Reality,
   Wolvic, Exokit, spatial home, and VR web shell families;
2. deduplicated against WebXR API, A-Frame, spatial desktop, and overlay
   families;
3. froze a bounded shortlist;
4. inspected local source clones without running or building;
5. separated huge architecture references from smaller code donors;
6. promoted shell/runtime/home-space patterns into the research system.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `Igalia/wolvic` | Current standalone headset browser shell with window/widget/native-world architecture |
| `MozillaReality/FirefoxReality` | Historical Android VR browser architecture and WebXR rendering lineage |
| `MozillaReality/FirefoxRealityPC` | Unity/OpenVR desktop Firefox launcher and PC VR shell |
| `exokitxr/exokit` | JavaScript WebXR runtime/session/input shim |
| `exokitxr/exokit-browser` | Minimal Exokit static browser shell |
| `exokitxr/exokit-frontend` | Frontend/menu/engine UI split around Exokit |
| `madjin/home-space` | Spatial home/startpage and media-prop reference |

## Deep-pass notes by project

## `Igalia/wolvic`

- GitHub:
  [Igalia/wolvic](https://github.com/Igalia/wolvic)
- What it is:
  a standalone browser for XR headsets descended from Firefox Reality.
- Interesting idea:
  a headset browser can be structured as an Android shell activity, Java
  session/window/widget layer, engine backend adapters, and a native render
  world that owns spatial placement, controllers, environments, and WebXR
  interstitials.
- Code-level notes:
  `VRBrowserActivity.java` owns the high-level browser shell: offscreen
  display, windows, root widget, keyboard, navigation bar, tray, permissions,
  WebXR listeners, battery updates, controller/hand state, brightness, and
  immersive launch extras. `SessionStore.java` owns browser runtime sessions,
  built-in web extensions, bookmarks/history/downloads, private sessions, and
  max-session limits. `Windows.java` manages regular/private windows, window
  state JSON, tabs, content panels, focused window placement, and immersive
  launch XPath parameters. `WebXRInterstitialController.java` builds an
  in-scene WebXR interstitial/exit surface. `BrowserWorld.cpp` owns native
  rendering, widgets, environment, controllers, external VR, blitter,
  performance monitor, window mover/resizer, and tracked keyboard renderer.
- Code donor value:
  very high as reference architecture, but too large to copy directly.
- Product reference value:
  very high for future browser-backed VR utility shells.
- Caveats:
  large Android/browser-engine codebase with multiple backends and platform
  assumptions.
- What to inspect next:
  build a small shell decomposition matrix: session, window, widget, native
  world, environment, and WebXR interstitial.

## `MozillaReality/FirefoxReality`

- GitHub:
  [MozillaReality/FirefoxReality](https://github.com/MozillaReality/FirefoxReality)
- What it is:
  the archived Firefox Reality Android VR browser.
- Interesting idea:
  Wolvic's current architecture is easier to understand when compared with the
  older Firefox Reality world/rendering lineage.
- Code-level notes:
  `BrowserWorld.cpp` includes Gecko surface texture handling, external VR,
  VR browser/video layers, widget mover/resizer/placement, root WebXR
  interstitial, controller focus updates, performance monitor, and WebXR
  rendering state.
- Code donor value:
  medium-high as historical architecture reference.
- Product reference value:
  high as a comparison node for browser shell evolution.
- Caveats:
  archived and superseded by Wolvic for current use.
- What to inspect next:
  compare with Wolvic only for lineage and boundary changes.

## `MozillaReality/FirefoxRealityPC`

- GitHub:
  [MozillaReality/FirefoxRealityPC](https://github.com/MozillaReality/FirefoxRealityPC)
- What it is:
  a Unity/OpenVR PC VR shell around Firefox Desktop.
- Interesting idea:
  a PC VR browser shell can act as a launcher and controller surface around an
  existing desktop browser instead of embedding a full browser engine.
- Code-level notes:
  `FxRBootstrapper.cs` redirects Unity console output, checks app update state,
  validates Firefox Desktop installation/configuration unless embedded, loads
  OpenVR device state and loading scenes, launches Firefox Desktop, or exits.
  `FxRFirefoxDesktopInstallation.cs` handles installed/downloaded/embedded
  Firefox paths, version checks, download/install dialogs, localized messages,
  and progress. The repo includes SteamVR action bindings, webcompat
  extensions, environment loaders, laser pointer, and 2D UI input scripts.
- Code donor value:
  medium-high for launcher and dependency-readiness shell anatomy.
- Product reference value:
  high for companion shells around existing desktop tools.
- Caveats:
  archived, PC VR/OpenVR, and Firefox-specific.
- What to inspect next:
  compare dependency readiness with runtime/setup-doctor methods.

## `exokitxr/exokit`

- GitHub:
  [exokitxr/exokit](https://github.com/exokitxr/exokit)
- What it is:
  an experimental JavaScript browser/runtime project with WebXR API surface.
- Interesting idea:
  a JS runtime can emulate or host WebXR sessions by making `navigator.xr`,
  `XRSession`, input sources, layers, and extension state explicit objects.
- Code-level notes:
  `src/XR.js` implements `navigator.xr.requestSession`, session lifecycle,
  requestAnimationFrame, end events, select/selectstart/selectend events,
  gamepad/hand/eye input sources, layer state, and toggles for meshing, plane
  tracking, hand tracking, and eye tracking.
- Code donor value:
  high for understanding WebXR API boundary modeling.
- Product reference value:
  medium-high for browser-native XR tooling and synthetic session tests.
- Caveats:
  experimental and not a current production browser.
- What to inspect next:
  compare with WebXR emulator and React/Three XR store patterns.

## `exokitxr/exokit-browser`

- GitHub:
  [exokitxr/exokit-browser](https://github.com/exokitxr/exokit-browser)
- What it is:
  a small static browser shell/front-end for Exokit.
- Interesting idea:
  a spatial browser front-end can start as an HTTPS static server plus a small
  interface, site list, keyboard assets, service worker, and API bridge.
- Code-level notes:
  `index.js` serves static browser assets over HTTPS with Express. The repo
  includes `interface.html`, `app.html`, `api.js`, `sw.js`, `sites.json`, and
  keyboard/icon assets.
- Code donor value:
  medium for minimal spatial browser shell anatomy.
- Product reference value:
  medium for quick browser-backed utility frontends.
- Caveats:
  thin and dependent on Exokit context.
- What to inspect next:
  compare with `exokit-frontend` menu and engine components.

## `exokitxr/exokit-frontend`

- GitHub:
  [exokitxr/exokit-frontend](https://github.com/exokitxr/exokit-frontend)
- What it is:
  a React frontend around Exokit engine/menu surfaces.
- Interesting idea:
  a browser XR tool can split engine hosting, launch surface, console, DOM
  panels, and menu UI into separate frontend components.
- Code-level notes:
  `ui/src/App.js` hosts the engine layer. The repository includes `Engine`,
  `Dom`, `Console`, `Launch`, and `menu/src/components/Menu.jsx` surfaces.
- Code donor value:
  medium for frontend component separation.
- Product reference value:
  medium for menu and shell layout around a runtime.
- Caveats:
  experimental and tied to Exokit.
- What to inspect next:
  compare with modern React/Three XR and browser utility shells.

## `madjin/home-space`

- GitHub:
  [madjin/home-space](https://github.com/madjin/home-space)
- What it is:
  a spatial home/startpage scene with Janus/WebXR/VRChat-style media assets.
- Interesting idea:
  a spatial browser home can be product-framed as a room/startpage containing
  screens, media props, portals, and lightweight scripts rather than a flat tab
  list.
- Code-level notes:
  the repository is asset-heavy and includes Janus markup, glTF/vox assets,
  Unity/VRChat material, and scripts such as `radio_mute.js` and
  `videoscreen.js`.
- Code donor value:
  low-medium for media-prop scripting.
- Product reference value:
  high for spatial home/startpage UX.
- Caveats:
  not a clean library and mostly useful as UX reference.
- What to inspect next:
  compare with immersive browser environments and spatial desktop launchers.

## Cross-project synthesis

This wave adds a reusable `immersive browser shell` decomposition:

- host activity or app bootstrap;
- browser runtime/session store;
- windows, tabs, panels, and saved window state;
- widgets for keyboard, navigation, tray, permissions, and interstitials;
- native render world for placement, controllers, environments, and resizing;
- WebXR runtime/session/input API layer;
- spatial home or startpage surface.

The strongest reference is `wolvic`. The strongest small-method donor is
`exokit` for explicit WebXR session/input boundary modeling.

## Follow-up

1. Build a browser-shell boundary matrix across Wolvic, Firefox Reality, PC
   shell, Exokit, and WebXR framework stores.
2. Extract WebXR interstitial and escape-surface patterns for future browser or
   overlay tools.
3. Treat spatial home scenes as product reference, not code donors.
