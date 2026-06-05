# VR Projects Wave 141: Browser-Based XR Editors, Live-Coding Sandboxes, Visual Workspaces, and Scene Tooling

- Date: `2026-06-05`
- Goal: study editor-like browser and XR tools for reusable scene authoring,
  asset, live-code, project, and readable 3D UI patterns.

## Why this wave exists

Many future VR utilities in `VR-apps-lab` will need editor behavior even when
they are not called editors: configuration scenes, calibration layouts,
diagnostic panels, tool shelves, 3D labels, live previews, asset lists, and
history. This wave studies those foundations.

## Better workflow used in this wave

1. searched by browser editor, WebXR live-coding, React/Three visual workspace,
   template VR, and Three.js UI/text families;
2. deduplicated against prior creative-tool, A-Frame, WebXR utility, and room
   framework waves;
3. froze a shortlist across full editor, self-contained scene studio,
   source-driven workspace, VR live coding, template platform, and UI toolkit;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `playcanvas/editor` | Browser editor architecture, asset APIs, realtime documents, and plugins |
| `tentone/nunuStudio` | Self-contained scene/project editor with VR toggle |
| `pmndrs/triplex` | Source-code-driven React Three Fiber visual workspace |
| `brianpeiris/RiftSketch` | In-VR live-coding sandbox |
| `teliportme/remixvr` | Template-based VR creation and classroom publishing |
| `protectwise/troika` | Three.js facade/UI/text infrastructure for readable 3D surfaces |

## Deep-pass notes by project

## `playcanvas/editor`

- GitHub:
  [playcanvas/editor](https://github.com/playcanvas/editor)
- What it is:
  the PlayCanvas browser editor source.
- Interesting idea:
  a browser editor can be organized as an API/method bus with observer history,
  asset virtual paths, realtime room/document state, and plugins.
- Code-level notes:
  `caller.ts` provides a method/error bus. The asset API wraps observer
  history, reload/subscribe behavior, thumbnails, virtual file URLs, template
  instantiation, replace, and delete. Code-editor document loading connects
  realtime auth/disconnect events to document dirty/loading state. Presence
  code joins scene-specific realtime rooms. Plugins add context tools such as
  texture LOD conversion and OBJ export.
- Architecture pattern:
  editor shell built around method calls, observable state, history, realtime
  rooms, and plugin actions.
- Reusable method:
  VR utility editors should separate commands, assets, presence, and preview
  from the rendering surface.
- Code donor value:
  high for editor architecture and realtime/asset abstractions.
- Product reference value:
  high for professional browser authoring UX.
- Caveats:
  large production codebase; reuse should be conceptual and boundary-focused.
- What to inspect next:
  build a compact editor-boundary matrix rather than trying to port full
  subsystems.

## `tentone/nunuStudio`

- GitHub:
  [tentone/nunuStudio](https://github.com/tentone/nunuStudio)
- What it is:
  a web/desktop 3D editor and runtime with project files and scene tooling.
- Interesting idea:
  a self-contained scene editor can include resource crawling, tabbed tools,
  action history, run/stop lifecycle, and VR entry without a cloud service.
- Code-level notes:
  `App.js` owns program lifecycle and `toggleVR()` entry/exit flow. `Editor.js`
  initializes settings, GUI, tabs, arguments, project loading, selection,
  history, shortcuts, scene/code/run views, object copy/paste/delete, resource
  scanning, and action bundles.
- Architecture pattern:
  project-file scene studio with editor/runtime split and explicit VR toggle.
- Reusable method:
  utility prototypes can use local project documents plus action history before
  adding collaboration.
- Code donor value:
  high for self-contained editor organization and resource/action patterns.
- Product reference value:
  medium-high for local-first 3D utility tooling.
- Caveats:
  broader than VR; WebXR-specific behavior is only one mode.
- What to inspect next:
  compare with PlayCanvas and Triplex for editor state ownership.

## `pmndrs/triplex`

- GitHub:
  [pmndrs/triplex](https://github.com/pmndrs/triplex)
- What it is:
  a visual workspace for React Three Fiber scenes.
- Interesting idea:
  the source code itself can be the scene schema if a tool extracts component
  metadata and isolates previews.
- Code-level notes:
  the client serves scene endpoints, module transforms, providers, and renderer
  config. The Babel plugin extracts component metadata from JSX and tracks
  transform props. Scene plugins create virtual modules for provider/global
  provider and bootstrapping. The editor UI manages scene/assets panels, while
  the renderer can render scenes and screenshots with providers.
- Architecture pattern:
  source-code-driven 3D workspace with metadata extraction and preview
  isolation.
- Reusable method:
  editor tools can annotate existing app code rather than force a separate
  scene database.
- Code donor value:
  high for source-to-visual workspace architecture.
- Product reference value:
  high for creator-facing 3D tooling.
- Caveats:
  React/Three specific and tied to build tooling.
- What to inspect next:
  compare provider injection with WebXR utility shell composition.

## `brianpeiris/RiftSketch`

- GitHub:
  [brianpeiris/RiftSketch](https://github.com/brianpeiris/RiftSketch)
- What it is:
  a historical WebVR/WebXR live-coding sandbox in VR.
- Interesting idea:
  code, errors, and scene output can all live inside VR as text/monitor panels.
- Code-level notes:
  `RiftSandbox.js` builds a Three scene, dolly, ground, monitor, WebXR renderer,
  and text areas as canvas textures. It intercepts `scene.add` to track
  user-created objects and implements scene cleanup. The controller stores
  sketches in `localStorage`, builds code with a function wrapper, evaluates it
  against `THREE`, `scene`, `camera`, `sketch`, and `renderer`, catches errors,
  and renders feedback into in-VR text panels.
- Architecture pattern:
  in-VR live-code loop with persistent sketches, scene interception, and error
  overlay.
- Reusable method:
  quick utility scripting can be made inspectable if errors appear in the same
  headset surface as the tool.
- Code donor value:
  high for live-code sandbox and text-panel feedback patterns.
- Product reference value:
  medium-high for developer-facing VR tools.
- Caveats:
  runtime eval is powerful but risky; production tools need sandbox limits.
- What to inspect next:
  pair with command/history patterns from VR creative tools.

## `teliportme/remixvr`

- GitHub:
  [teliportme/remixvr](https://github.com/teliportme/remixvr)
- What it is:
  a VR education/template creation platform with backend, frontend, docs, and
  A-Frame template packages.
- Interesting idea:
  reusable VR templates can turn one scaffolding into many authored
  experiences while a backend tracks classrooms, activities, submissions, and
  reactions.
- Code-level notes:
  backend models and views expose classroom/activity/submission/reaction flows
  with short activity codes. The frontend API layer wraps spaces, activity
  types, activities, classrooms, and submissions. The `themes/` tree contains
  reusable A-Frame/WebVR templates such as 360 images, 360 tours, object VR,
  particle scenes, and starter templates.
- Architecture pattern:
  template package plus publishing/activity backend plus learner submission
  loop.
- Reusable method:
  VR creation systems should separate reusable scaffold, authored content,
  publishing code, and audience response.
- Code donor value:
  medium for template/package and activity-flow references.
- Product reference value:
  high for no-code/low-code VR creation framing.
- Caveats:
  older WebVR/A-Frame lineage and education-specific product model.
- What to inspect next:
  compare with modern WebXR authoring tools before any template branch.

## `protectwise/troika`

- GitHub:
  [protectwise/troika](https://github.com/protectwise/troika)
- What it is:
  a family of Three.js libraries for 3D UI, text, facades, worker utilities,
  instancing, flex layout, and derived materials.
- Interesting idea:
  readable 3D UI is infrastructure: text layout, SDF glyphs, fallback fonts,
  batching, facades, flex nodes, workers, and material derivation need to be
  solved below the product layer.
- Code-level notes:
  `troika-core` exports facade and world base classes. `troika-3d` adds scene,
  object, group, HTML overlay, camera, primitive, and instancing facades.
  `troika-3d-ui` adds UI blocks, images, dat-gui facade, and flex layout.
  `troika-three-text` implements font resolution, worker-backed SDF generation,
  glyph geometry with instanced attributes, selection helpers, and batched text.
- Architecture pattern:
  facade-based 3D UI toolkit plus worker-backed text rendering.
- Reusable method:
  make readable VR text a platform concern, not a per-overlay hack.
- Code donor value:
  high for 3D text/UI internals and worker/SDF patterns.
- Product reference value:
  medium-high for any headset-readable labels, panels, captions, chat, and
  editor surfaces.
- Caveats:
  not VR-specific; integration still needs input, comfort, and placement rules.
- What to inspect next:
  combine with subtitles, chat overlays, keyboard, and browser WebXR panels for
  a readable-surface checklist.

## Cross-project synthesis

- Strongest editor donors:
  `playcanvas/editor`, `nunuStudio`, `triplex`.
- Strongest headset-native dev UX:
  `RiftSketch`.
- Strongest authoring product reference:
  `remixvr`.
- Strongest low-level UI donor:
  `troika`.
- Main reusable methods:
  editor method bus, project-file/action history, source-code metadata
  extraction, in-VR live coding, template publishing, and 3D text/UI
  infrastructure.

## Fit for `VR-apps-lab`

This wave strengthens future utility-tool architecture: scene editors,
calibration workspaces, diagnostic panels, browser-backed authoring, readable
3D labels, and live-code/dev surfaces.
