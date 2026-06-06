# GitHub Research Wave 235 Backlog

Date: 2026-06-06

Theme: Browser-native WebXR drawing, whiteboard, and creative surfaces.

## Completed In This Wave

- Studied `localtoast42/webxr-whiteboard` as a thin Three/WebXR interaction
  probe with engine/player/controller boundaries, XRButton, controller grip and
  ray spaces, gamepad wrapper, squeeze-driven object hit checks, and bounding
  box material feedback.
- Studied `felixtrz/canvrs` as an Elixr/Three AR painting micro-tool with
  GLTF multitool attachment to the right controller, mode toggle, pressure
  threshold, color cycling, line buffer draw ranges, min-distance sampling,
  line bounding boxes, and eraser-size variants.
- Studied `n1ckfg/LightningLoops` as a networked/generative LATK stroke surface
  with Express/socket.io frame server, client stroke upload, frame requests,
  local/remote layers, 12 fps frame motor, WebSocket fallback, turtle-generated
  stroke morphs, Magenta piano input, JSON save, and stroke lifetime cleanup.
- Studied `nuonical/webxr-babylon` as a browser-native Babylon creative
  workbench with XR lifecycle, controller locomotion, trigger drawing, palette
  toggles, pointer blocking while selecting palette, desktop fallback drawing,
  tube/ribbon/metaball stroke modes, chunk splitting, stroke/point limits,
  haptics, portal tests, and FPS in-world diagnostics.
- Studied `sierrajanson/Harold-in-VR` as an A-Frame drawing/prototyping tool
  with global tool state, left-trigger menu, shape submenu, tool isolation,
  gradient color picker via raycast UV canvas sampling, ruler measurements,
  shape drag/resize workflows, grid/background UX, and clear/erase surfaces.
- Studied `cpufreestyle/vr-paint` as an A-Painter fork with input mappings for
  Vive/Oculus/Windows MR, brush registration API, pressure-aware strokes,
  shared buffer geometry, undo/clear/remove, JSON and binary `.apa` save/load,
  URL-based load, upload/share event flow, tooltip fade, and controller model
  feedback.
- Added a reusable method entry for browser-native creative stroke workbench
  boundaries.

## Follow-Up Queue

1. Compare brush/stroke storage across A-Painter, Open Brush/Tilt lineage,
   `canvrs`, `LightningLoops`, `webxr-babylon`, and A-Frame projects.
2. Extract a reusable VR tool menu pattern: menu-open disables drawing,
   one active tool, submenu mode, palette blocking, and mode feedback.
3. Compare geometry strategies: line segments, tubes, ribbons, metaballs,
   shared buffer geometry, chunking, and point caps.
4. Compare persistence and sharing: `.apa`, JSON, URL-load, upload/share,
   local/remote layers, and collaborative frame exchange.
5. Decide which creative-surface donor should guide future annotation,
   measurement, or whiteboard utility prototypes.

## Do Not Spend Time On Yet

- Do not run the demos or install npm packages.
- Do not copy large bundled assets, old vendor libraries, or dist builds.
- Do not treat classroom/demo UX as production-ready without menu, comfort,
  persistence, and performance review.
