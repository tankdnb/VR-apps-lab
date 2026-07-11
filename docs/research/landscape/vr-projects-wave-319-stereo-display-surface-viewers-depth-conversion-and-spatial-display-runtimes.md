# Wave 319 - Stereo Display-Surface Viewers, Depth Conversion, and Spatial-Display Runtimes

This wave studies viewer-style XR utilities that turn flat or pre-stereo
surfaces into runtime-driven display experiences, with emphasis on source
ingress, projection/depth transforms, live control planes, and display-geometry
ownership.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- desktop or window capture turned into stereo or XR-viewer output;
- shared-control-plane viewers for SBS/TAB or related 3D surface content;
- spatial-display runtimes and plugins that expose explicit view-rig/display
  geometry;
- small viewer apps that reveal display-centric rendering and interaction
  seams.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Bastian-Noel/DepthVistaXR` | Desktop-capture to depth-estimated stereo viewer | Studied | Strong donor for source capture, depth conversion, OpenXR output threading, and live-control surfaces |
| `BerZerker96/Osiris-Vr-Viewer` | Stereo-surface viewer with shared control plane | Studied | Strong donor for viewer/GUI split, shared-memory live params, persistent presets, and in-VR control UX |
| `DisplayXR/displayxr-unity` | Spatial-display OpenXR runtime plugin for Unity | Studied | Strong donor for camera-centric vs display-centric rig boundaries and local 2D composition over 3D surfaces |
| `DisplayXR/displayxr-demo-gaussiansplat` | Small display-centric runtime viewer app | Studied | Valuable donor for runtime-owned display geometry, focus/orbit behavior, transparent layering, and compact viewer controls |

## Code-Level Findings

### `Bastian-Noel/DepthVistaXR`

- Interesting idea:
  a desktop-to-VR viewer is more reusable when capture, depth inference,
  stereo generation, OpenXR output, and operator controls remain visible as
  separate stages.
- Code donor value:
  high. `openxr_output.py` keeps session/output threading, runtime detection,
  frame readiness, and controller-to-desktop input synthesis explicit.
  `gui_dpg.py` exposes the live control plane cleanly: source selection,
  capture backend choice, curved vs flat projection, recentering, and session
  start/stop are not buried. The capture path also shows a practical backend
  ladder instead of assuming one desktop-capture method will always work.
- Product reference value:
  very high for desktop-in-VR viewers, media panels, 2D-to-3D conversion tools,
  and operator-facing surface viewers.
- What to inspect next:
  output timing under higher load, deeper source-backend tradeoffs, and whether
  the depth-estimation stage can be treated as an interchangeable module.
- Reusable pattern extraction:
  keep `source ingress`, `depth/stereo transform`, `OpenXR output loop`, and
  `operator controls` separate.

### `BerZerker96/Osiris-Vr-Viewer`

- Interesting idea:
  a viewer and its control UI can stay both powerful and debuggable if
  persistent presets and live overrides use different storage and transport
  surfaces.
- Code donor value:
  high. `osiris-shared/src/lib.rs` is the strongest seam: it defines a large
  but explicit shared-memory shape for live viewer control while also keeping a
  persistent JSON preset path. That split lets the viewer keep stable saved
  defaults while the GUI sends fast-changing overrides. The repo also frames
  the in-VR control panel and multi-source viewer behavior as first-class
  product features.
- Product reference value:
  very high for stereo-surface viewers, retrofit companion apps, and any
  utility where a lightweight GUI drives a minimized viewer process.
- What to inspect next:
  viewer-side render loop and source hot-swap internals, plus how well the
  shared-memory contract handles compatibility/version drift.
- Reusable pattern extraction:
  keep `persistent preset`, `live override transport`, and `viewer runtime`
  separate.

### `DisplayXR/displayxr-unity`

- Interesting idea:
  spatial-display runtimes become reusable when they make display geometry,
  rig mode, and 2D-over-3D composition explicit rather than hiding them behind
  one camera prefab.
- Code donor value:
  very high. `DisplayXRCamera.cs` and `DisplayXRDisplay.cs` cleanly separate
  camera-centric and display-centric modes. `DisplayXRLocal2D.cs` is a
  particularly strong donor: it takes over a normal Unity `Canvas`, renders it
  into a dedicated texture, and publishes it into the runtime's local-2D layer
  path with explicit placement and clipping semantics. `DisplayXRProvider.cs`
  makes the app-facing control plane visible instead of forcing all control
  through scene setup.
- Product reference value:
  very high for spatial displays, smart-glasses-adjacent view rigs, and
  runtime plugins that need app-facing knobs for display geometry and
  composition.
- What to inspect next:
  provider lifecycle under engine-version drift, eye-tracking mode surfaces,
  and whether the local-2D layer pattern ports cleanly outside Unity.
- Reusable pattern extraction:
  keep `view rig`, `display geometry`, `provider control plane`, and `2D
  composition layer` separate.

### `DisplayXR/displayxr-demo-gaussiansplat`

- Interesting idea:
  a small viewer app can still be a strong donor when it makes display-centric
  interaction concepts like focus-on-point, pivot/orbit, transparent layering,
  and runtime-owned geometry explicit.
- Code donor value:
  medium-high. The repo is narrower than `displayxr-unity`, but it shows the
  viewer-side consequences of an explicit display rig and exposes useful
  interaction ideas such as virtual-display-height zoom, auto-framing, and
  focus transitions.
- Product reference value:
  high for compact display-centric viewers and "one surface, one strong
  control set" XR utilities.
- What to inspect next:
  how much of the viewer control plane is reusable outside Gaussian splats and
  whether the transparent-background/HUD strategy generalizes to other
  display-surface tools.
- Reusable pattern extraction:
  keep `runtime display rig`, `viewer interaction model`, and `content
  renderer` separate.

## Reusable Pattern Extraction

- Pattern candidate:
  stereo/display-surface viewer boundary across source ingress, transform
  pipeline, live control plane, display geometry ownership, and secondary
  composition layers.
- Problem solved:
  viewer tools become hard to extend when content capture, stereo/depth
  transforms, display geometry, control UIs, and runtime output loops are all
  entangled.
- Reusable core:
  source ingress adapter, transform stage such as depth or stereo conversion,
  runtime output loop, persistent preset store, live override transport,
  display/view-rig geometry model, local 2D or HUD composition layer, and
  viewer interaction controls such as orbit/focus/recenter.
- Source evidence:
  `Bastian-Noel/DepthVistaXR`, `BerZerker96/Osiris-Vr-Viewer`,
  `DisplayXR/displayxr-unity`, and
  `DisplayXR/displayxr-demo-gaussiansplat`.
- Abstraction boundary:
  keep source ingestion, transform pipeline, runtime/display geometry, and live
  operator controls separate.
- What not to copy:
  one-off shared-memory schemas without versioning notes, display-rig
  assumptions hidden inside viewer logic, or control UIs that mutate render
  internals without an explicit surface contract.
- Method catalog action:
  add a stereo/display-surface viewer method.

## Follow-Up Gaps

- Compare shared-memory control planes with file-based or socket-based viewer
  control approaches across other viewer families.
- Revisit `DisplayXR` against other explicit `XR_EXT_view_rig` or spatial
  display stacks.
- Deepen the boundary between 2D-on-3D composition and the main viewer render
  path across Unity and non-Unity implementations.
