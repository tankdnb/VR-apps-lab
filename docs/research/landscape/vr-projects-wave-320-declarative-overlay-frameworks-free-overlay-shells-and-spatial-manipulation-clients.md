# Wave 320 - Declarative Overlay Frameworks, Free Overlay Shells, and Spatial Manipulation Clients

This wave studies projects that expose VR overlay or spatial UI work as a
reusable shell: declarative overlay frameworks, free desktop-overlay
prototypes, and StardustXR-style spatial manipulation clients.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- overlay frameworks with explicit UI/render/runtime boundaries;
- free/open overlay shells that reveal product direction even when source is
  compact;
- spatial manipulation clients that model hand/ray selection and object
  movement;
- projects not already tracked in registry/families.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `sumx21t-3310/FloatSoda` | Declarative SteamVR overlay framework | Studied | Strong donor for widget/render/layer tree separation, OpenVR overlay windows, render-thread texture submission, and dashboard/world/device-tracked window types |
| `DelfinVT-uwu/FreeOverlay` | Free/open desktop overlay shell | Studied with maturity caveats | Product reference for a small XSOverlay-like desktop/media/notification shell with themes and persistence, but prototype-monolith code limits donor value |
| `Schmarni-Dev/absolute-solver` | StardustXR spatial manipulation client | Studied | Strong reference for hand/ray selection, capture-to-mover flow, accent-color integration, and spatial-object manipulation outside flat overlay panels |

## Code-Level Findings

### `sumx21t-3310/FloatSoda`

- Interesting idea:
  a SteamVR overlay app can be treated like a Flutter-style UI framework, with
  widget, element, render-object, layer, renderer, and OpenVR overlay seams kept
  visible.
- Code donor value:
  very high. `FloatSoda.Engine.OverlayWindow` renders a cloned layer tree into
  an OpenGL texture and submits it through `Overlay.Texture`. `FloatSoda.OVR`
  separates `DashboardOverlay`, `WorldSpaceOverlay`, and
  `DeviceTrackedOverlay` with common opacity, width, curvature, texture, state,
  vibration, input, and event-dispatch surfaces. The samples show dashboard,
  world-space, and controller-attached windows created from the same app model.
- Product reference value:
  very high for future overlay toolkits, dashboards, wrist panels, notification
  cards, and reusable utility shells.
- What to inspect next:
  input-event dispatch, dirty-tree scheduling, render-thread lifecycle, and
  whether the framework can host dynamic companion-data sources.
- Reusable pattern extraction:
  keep `declarative UI tree`, `render/layer tree`, `GPU texture bridge`,
  `runtime overlay identity`, and `overlay placement type` separate.

### `DelfinVT-uwu/FreeOverlay`

- Interesting idea:
  a small free/open overlay can be product-useful even when it is implemented
  as a compact prototype: desktop visibility, media controls, notifications,
  calendar/reminders, themes, and simple persistence all support a recognizable
  headset companion shell.
- Code donor value:
  low-medium. `cyber_watch.py` shows direct OpenVR, GLFW/OpenGL, PIL drawing,
  Windows media-session polling, pyautogui media keys, JSON persistence, and
  notification/calendar managers, but the monolithic structure and broad
  exception swallowing make it a weak direct donor.
- Product reference value:
  medium-high as a thin overlay utility direction: one glanceable panel with
  desktop, media, notification, theme, and reminder affordances.
- What to inspect next:
  whether later commits split renderer/input/data managers, whether desktop
  capture is robust, and how privacy is handled for notifications.
- Reusable pattern extraction:
  borrow the feature bundle and theme/persistence idea, not the monolithic
  implementation shape.

### `Schmarni-Dev/absolute-solver`

- Interesting idea:
  spatial manipulation does not have to be a flat overlay panel: the app uses
  StardustXR input, object registry, lines, models, ring input, and hand-tip
  geometry to select and move scene objects.
- Code donor value:
  high for StardustXR-style spatial tools. `main.rs` connects to a StardustXR
  client, creates resources/models/lines, derives selection rays from hand or
  tip input, captures selected objects into a `Mover`, and uses a solver model
  plus accent-color updates for in-world feedback.
- Product reference value:
  high for hand-driven manipulation helpers, spatial admin tools, calibration
  handles, and object-placement utilities.
- What to inspect next:
  `selection`, `mover`, and `ring` modules in a deeper StardustXR wave, plus
  save-state behavior and object-registry compatibility.
- Reusable pattern extraction:
  keep `input attachment`, `selection ray`, `captured object`, `mover`, and
  `feedback model/lines` separate.

## Reusable Pattern Extraction

- Pattern candidate:
  declarative overlay/spatial shell boundary across UI tree, render tree,
  runtime overlay identity, placement mode, and input/manipulation adapters.
- Problem solved:
  overlay utilities become hard to reuse when UI construction, rendering,
  OpenVR submission, placement, input, and data sources are collapsed into one
  loop.
- Reusable core:
  declarative UI/widget model, render object and layer tree, render-thread
  texture bridge, overlay identity and placement type, event/input dispatcher,
  source-data adapters, and optional spatial manipulation adapter.
- Source evidence:
  `sumx21t-3310/FloatSoda`, `DelfinVT-uwu/FreeOverlay`, and
  `Schmarni-Dev/absolute-solver`.
- Abstraction boundary:
  separate UI composition from runtime overlay submission, and separate flat
  panel controls from spatial object manipulation.
- What not to copy:
  monolithic overlay scripts, broad exception swallowing, hidden privacy
  choices for notifications, or spatial manipulation logic coupled directly to
  one visual indicator.
- Method catalog action:
  add a declarative overlay/spatial shell method.

## Follow-Up Gaps

- Compare FloatSoda with immediate-mode overlay renderers and existing
  dashboard/wrist-panel frameworks.
- Deepen StardustXR manipulation clients as a family of spatial admin tools.
- Search for stronger open desktop overlay shells with cleaner modularity.
