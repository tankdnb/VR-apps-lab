# VR Projects Wave 235: Browser-Native WebXR Drawing, Whiteboard, and Creative Surfaces

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies browser-native creative surfaces: WebXR whiteboards, AR/VR
paint tools, stroke systems, color palettes, rulers, shape placement, sharing,
and collaborative or generative drawing loops.

## Why It Matters For `VR-apps-lab`

Drawing tools look like art projects, but the reusable methods are general:
controller pressure, mode gating, palette blocking, point sampling, geometry
chunking, undo/storage, measurement, and in-headset tool menus. These patterns
can support future annotation, diagnostics, whiteboard, calibration, and
operator surfaces.

## Project Notes

### `localtoast42/webxr-whiteboard`

- Interesting idea:
  a very small WebXR probe can isolate controller connection, grip/ray space,
  and object hit feedback without a full product shell.
- Code donor value:
  `engine/controller.ts` owns XR controller/grip spaces, controller models,
  gamepad wrapper, connected/disconnected visibility, and handedness
  registration. `whiteboard.ts` checks right-hand squeeze, tests grip position
  against item bounding boxes, and swaps materials when hit.
- Product reference value:
  useful micro-pattern for object hit testing and controller plumbing.
- What to inspect next:
  compare against richer paint tools before copying anything beyond the
  controller/entity split.
- Architecture pattern:
  thin WebXR interaction probe with entity and controller boundaries.
- Caveats:
  not yet a real whiteboard; donor value is in the micro-interaction, not the
  product.

### `felixtrz/canvrs`

- Interesting idea:
  a controller-attached multitool can combine paint, erase, color cycling,
  pressure, and visual tool animation in a small WebXR system.
- Code donor value:
  `MultiToolInitSystem.js` loads a GLTF pen, attaches tip/eraser/button/stick
  references, and attaches the tool to the right controller. `PaintToolSystem`
  samples trigger pressure, enforces min point distance, creates line buffer
  geometries, and tracks line bounding boxes. `EraseToolSystem` checks eraser
  distance against stored line points. `MultiToolAnimationSystem` maps buttons
  and thumbstick axes into visible tool animation.
- Product reference value:
  strong compact WebXR painting micro-tool donor.
- What to inspect next:
  compare line storage and eraser behavior with A-Painter and Babylon strokes.
- Architecture pattern:
  controller-attached multitool with mode-specific systems.
- Caveats:
  minimal README, AR button focus, old bundled dist, and limited persistence.

### `n1ckfg/LightningLoops`

- Interesting idea:
  strokes can be collaborative, animated, short-lived, and generative rather
  than static geometry.
- Code donor value:
  `app.js` stores strokes in frames/layers, accepts socket.io stroke uploads,
  serves requested frames, and trims old strokes. `public/index.html` builds
  local/remote LATK layers, frame motor, local/remote line buffers, JSON save,
  and refresh loops. `latk-stroke-morph.js` mutates strokes with turtle
  commands. `networking.js` recreates remote strokes and triggers Magenta
  output.
- Product reference value:
  strong reference for collaborative/generative stroke surfaces and remote
  frame exchange.
- What to inspect next:
  compare socket frame exchange against Networked-AFrame and collaborative
  drawing tools.
- Architecture pattern:
  socket-backed LATK frame/layer stroke loop.
- Caveats:
  old WebVR-era dependencies, webhook/deploy code, public server assumptions,
  and generative art focus.

### `nuonical/webxr-babylon`

- Interesting idea:
  a browser-native workbench can combine game-like locomotion, drawing,
  palette selection, portals, physics, and tests while still keeping drawing
  state explicit.
- Code donor value:
  `xr.js` handles WebXR lifecycle, controller axes, trigger drawing, snap turn,
  palette toggles, and state restoration on exit. `draw.js` defines stroke
  state, controller tip offsets, desktop fallback drawing, palette pointer
  blocking, haptics, tube/ribbon/metaball render modes, periodic mesh rebuilds,
  chunk splitting, stroke/point limits, material cache, and palette selection.
  Tests cover portal transform scenarios and screenshot sanity.
- Product reference value:
  richest browser-native creative workbench donor in this wave.
- What to inspect next:
  isolate drawing/palette/limit logic from unrelated game playground features.
- Architecture pattern:
  Babylon creative workbench with explicit draw system and feature modules.
- Caveats:
  broad playground scope, lots of globals, and mixed game/demo concerns.

### `sierrajanson/Harold-in-VR`

- Interesting idea:
  a VR drawing tool menu should isolate modes so drawing, color picking, ruler,
  clear, and shape creation do not fight for the same trigger.
- Code donor value:
  `menu.js` uses shared global state for drawingEnabled, menuOpen, currentTool,
  submenuOpen, and shapeMode, closes menus after tool selection, and disables
  tools while submenus are open. `colorWheel.js` samples a gradient image via
  raycast UV and canvas pixels. `addShape.js` creates and resizes cube/sphere/
  cylinder primitives from controller drag. `ruler.js` creates two-point
  measurements with preview line and distance state.
- Product reference value:
  good A-Frame UX reference for tool menus, color picking, ruler, and shape
  workflows.
- What to inspect next:
  compare menu state isolation with A-Painter, Vartiste, and Open Brush.
- Architecture pattern:
  A-Frame component set with shared tool-mode state.
- Caveats:
  student/project demo maturity and some global-state coupling.

### `cpufreestyle/vr-paint`

- Interesting idea:
  A-Painter remains a strong reference for brush registration, pressure-aware
  strokes, shared geometry buffers, save/load, upload/share, and input mapping.
- Code donor value:
  `systems/brush.js` registers brushes with init/addPoint/tick, wraps point
  storage with position/orientation/pressure/timestamp, saves JSON and binary
  `.apa`, loads from URL, handles undo/clear/remove, and tracks used brushes.
  `sharedbuffergeometry.js` preallocates large buffer geometries and updates
  draw ranges. `painter.js` maps controller events across Vive/Oculus/Windows
  MR, saves/uploads drawings, and supports URL parameters. `paint-controls.js`
  maps controller buttons/axes to brush size, menu, teleport, tooltip, and
  model feedback.
- Product reference value:
  strongest mature brush/storage donor in this wave, with caveat that it is a
  fork of A-Painter.
- What to inspect next:
  compare directly with upstream A-Painter/Open Brush before reusing code.
- Architecture pattern:
  A-Frame brush engine with binary/JSON persistence and shared geometry.
- Caveats:
  fork lineage, older dependencies, bundled assets, and Chinese/mojibake README
  text in the current checkout.

## Reusable Pattern Extraction

- Pattern candidate:
  browser-native WebXR creative stroke workbench.
- Problem solved:
  VR annotation and creative tools need consistent handling of controller
  pressure, point sampling, mode state, palette/menu interaction, geometry
  limits, persistence, and sharing.
- Reusable core:
  separate controller input, tool/mode state, active stroke state, geometry
  builder, eraser/selection, palette/menu blocking, persistence/export, and
  collaboration transport.
- Source evidence:
  `webxr-whiteboard`, `canvrs`, `LightningLoops`, `webxr-babylon`,
  `Harold-in-VR`, and `vr-paint`.
- Abstraction boundary:
  keep drawing engine independent from scene/product content; keep tool menu
  state independent from brush geometry; keep storage/transport behind import
  and export adapters.
- What not to copy:
  classroom/demo globals, old WebVR bundles, large assets/dist builds, public
  socket servers, or forked brush code without checking upstream license and
  maintenance.
- Method catalog action:
  add a method entry for browser-native creative stroke workbench boundaries.

## Follow-Up Gaps

- Build a brush/stroke matrix across A-Painter, Open Brush/Tilt lineage,
  `canvrs`, `LightningLoops`, `webxr-babylon`, and A-Frame tools.
- Compare tool menu state patterns: menu-open disables drawing, one active
  tool, palette blocks drawing, shape mode, ruler mode, and clear confirmation.
- Extract annotation/whiteboard utility patterns separately from full art
  tools.
