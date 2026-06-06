# VR Projects Wave 229: Immersive Data, Robotics, and Scientific Visualization Workbenches

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies data-first XR tools: Python-to-browser scene bridges,
generated immersive plots, WebXR scientific layouts, collaborative callout
rooms, and robotics model viewer dispatchers.

## Why It Matters For `VR-apps-lab`

The repository already has many overlay and media surfaces. This wave adds a
different utility line: turn data, robot models, or scientific state into a
spatial workbench with explicit source, transform, layout, interaction, and
export boundaries.

## Project Notes

### `vuer-ai/vuer`

- Interesting idea:
  Python sessions can drive a browser/WebXR scene through declarative schema
  objects and async scene operations.
- Code donor value:
  `server.py` creates an aiohttp/WebSocket bridge, msgpack serialization,
  workspace asset serving, and `SceneOps` commands like set/update/add/upsert.
  `events.py` separates client and server events, while schema modules expose
  scene components for robotics and visualization.
- Product reference value:
  strong donor for diagnostics or teleoperation tools where Python owns the
  data/robot side and a browser owns immersive display.
- What to inspect next:
  compare its scene-delta protocol against WebRTC/teleoperation waves and
  decide how much schema complexity future utilities actually need.
- Architecture pattern:
  Python async command bridge to browser/WebXR scene graph.
- Caveats:
  not an overlay, browser/client bundle is broad, WebSocket/SSL/ngrok and
  remote-data boundaries need security review.

### `thomann/plotAR`

- Interesting idea:
  a data-science session can generate an immersive plot artifact, expose it by
  URL/QR, and let a phone/headset load the scene without a custom app.
- Code donor value:
  Python and R packages generate data/model output; server code exposes
  `data.json`/VR pages; HTML pages handle keyboard/controller WebSocket
  commands and reload glTF revisions.
- Product reference value:
  useful as a product reference for "make current data visible in VR now" and
  for QR-paired local tool flows.
- What to inspect next:
  modernize the WebVR-era assumptions into WebXR and add safer local-network
  access controls.
- Architecture pattern:
  generated immersive artifact plus lightweight control channel.
- Caveats:
  older WebVR/polyfill lineage, security warnings around unencrypted data and
  open clients, and simple single-model assumptions.

### `TsatsuAmable/nemosyne`

- Interesting idea:
  data visualization is treated as a pipeline: raw data, semantic mappings,
  transform DSL, layout engine, artifacts, and WebXR/A-Frame display.
- Code donor value:
  `PropertyMapper.js` maps semantics to geometry/color/material/animation.
  `LayoutEngine.js` has VR-aware layouts including scatter, globe, grid,
  timeline, tree, and spherical layouts. `TransformDSL.js` compiles
  declarative field transforms.
- Product reference value:
  strong reference for future data dashboards where values must become
  spatial encodings, not just labels on panels.
- What to inspect next:
  separate stable core abstractions from research-preview and legacy files.
- Architecture pattern:
  semantic data-to-spatial-encoding pipeline.
- Caveats:
  research preview, broad/legacy material in the repo, and no validation run in
  this wave.

### `smrghsh/brahma`

- Interesting idea:
  scientific WebXR can be framed as a shared room with presence, callouts,
  grasp/select modules, locomotion, and collaboration state.
- Code donor value:
  `Brahma.js` exports environment, controller, button, grasp, locomotion,
  selectable, path, networking, and avatar modules. `Networking.js` handles
  user identity, WebSocket connection, embodiment updates, callout PUT/DELETE,
  retries, and remote avatar state.
- Product reference value:
  useful for collaborative diagnostics and remote review surfaces where users
  need presence plus annotations.
- What to inspect next:
  replace hardcoded endpoint assumptions with a configurable local or hosted
  room-service boundary.
- Architecture pattern:
  collaborative scientific room shell with callout and embodiment state.
- Caveats:
  alpha status, hardcoded production service, broad singleton assumptions, and
  not enough packaging clarity.

### `jurmy24/mechaverse`

- Interesting idea:
  a browser viewer can dispatch robot files by format and route each payload to
  a specialized renderer instead of forcing one universal loader path.
- Code donor value:
  `DragAndDropContext.tsx` detects URDF, USD, and MJCF/XML file groups,
  prefers scene-like MJCF files with includes, publishes payload events, and
  switches `ViewerSwitch` between URDF, MJCF, and USD viewers.
- Product reference value:
  useful adjacent reference for future robot/XR diagnostics, asset inspection,
  and file-drop viewer shells.
- What to inspect next:
  add an actual XR/spatial-panel viewer layer before treating it as a VR donor.
- Architecture pattern:
  file-detection and viewer-dispatch shell for robotics assets.
- Caveats:
  not VR/WebXR yet, desktop-browser focused, mobile/large-model caveats.

## Reusable Pattern Extraction

- Pattern candidate:
  Data-to-spatial-encoding workbench pipeline.
- Problem solved:
  immersive data tools become brittle when data loading, field mapping, layout,
  interaction, transport, and export are hidden in one scene.
- Reusable core:
  separate source ingestion, schema or semantic fields, transform/mapping,
  layout, scene artifact creation, live update/event transport, interaction,
  export, and security/trust policy.
- Source evidence:
  `vuer-ai/vuer`, `thomann/plotAR`, `TsatsuAmable/nemosyne`,
  `smrghsh/brahma`, and `jurmy24/mechaverse`.
- Abstraction boundary:
  keep data/session owners outside the XR renderer and let the renderer consume
  typed scene operations, generated artifacts, or format-specific viewer
  payloads.
- What not to copy:
  hardcoded collaboration endpoints, open local servers without trust policy,
  old WebVR pages, and desktop-only robotics viewers as if they were finished
  immersive products.
- Method catalog action:
  add a new method entry for data-to-spatial-encoding workbench pipelines.

## Follow-Up Gaps

- Compare data bridge protocols across `vuer`, `plotAR`, WebRTC panels, and
  VR teleoperation waves.
- Build a robotics viewer matrix across URDF, MJCF, USD, MuJoCo, ROS, and
  WebXR/spatial display readiness.
- Extract security guidance for generated local immersive data artifacts.
