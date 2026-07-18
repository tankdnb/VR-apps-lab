# Wave 479: VRM GLB Pose-Scene Authoring And Downstream Generator Adapters

- Date: `2026-07-18`
- Scope: browser and ComfyUI VRM/GLB pose editors, scene capture adapters,
  multi-channel generator outputs, and Unity WebXR packaging references.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `ketle-man/comfyui-vrm-pose-editor` | Studied | ComfyUI node-local VRM/GLB editor that captures browser pose renders into graph tensors |
| `hidenoji1/comfyui-vrm-scene-editor` | Studied | Standalone ComfyUI VRM scene studio with image/mask/depth/normal/openpose capture channels |
| `k3peta/web-vrm-poser` | Studied | Serverless browser VRM poser and `.vroidpose` to Three.js/VRoid conversion tool |
| `Module-Code/WebXR_DePanther` | Studied as packaging reference | Unity project showing WebXR Export package, templates, XR settings, and simulator assets |

## Project Notes

### `ketle-man/comfyui-vrm-pose-editor`

- Interesting idea:
  Embed a full browser 3D pose editor inside a ComfyUI node, then turn captured
  canvas images into graph outputs.
- Code donor value:
  Strong donor for node-local editor UI, VRM/GLB/GLTF intake, pose library,
  thumbnail routes, timer capture, background compositing, PIL-to-torch output,
  and path-safe server endpoints.
- Product reference value:
  Useful reference for downstream generator adapters where a spatial/avatar
  editor produces image or pose evidence for another pipeline.
- Source evidence:
  `pose_editor_node_3d.py`, `pose_library_server.py`,
  `js/pose_editor_3d.js`, `js/pose_editor_core.js`,
  `js/pose_library.js`, and `js/light_editor.js`.
- Reusable core:
  ComfyUI extension registration, hidden widgets, DOM canvas/buttons, file
  accept list, 50 MB cap, model cache per node, object URL cleanup, pose
  export/download/save, thumbnail/meta/content routes, path traversal guard,
  background image/color, timed capture, and image tensor conversion.
- What not to copy:
  Bundled vendor libraries, local server writes without a policy, and alert-only
  error handling.
- What to inspect next:
  Generalize the node-local 3D editor into a reusable generator adapter pattern.

### `hidenoji1/comfyui-vrm-scene-editor`

- Interesting idea:
  Make pose and scene authoring a standalone studio that streams multiple
  capture channels back into graph nodes without queueing the workflow.
- Code donor value:
  Very strong donor for editor launch buttons, backend routes, channel registry,
  live node preview, thumbnail extraction from VRM/GLB chunks, sanitized file
  tokens, multi-camera capture, and generated channel outputs.
- Product reference value:
  Strong reference for VRM/GLB scene staging tools, creator workflows, and
  synthetic dataset/image generation support.
- Source evidence:
  `__init__.py`, `editor/main.js`, `web/vrm_scene_editor_button.js`, and
  `web/vrm_scene_capture_live.js`.
- Reusable core:
  `/vrm-scene-editor` route, model/pose/scene folders, capture endpoint,
  `_REGISTRY[camera][type]`, `vrm_capture` WebSocket event, in-node preview,
  angle-widget sync, camera1-camera9, image/mask/depth/normal/openpose channel
  list, GLB thumbnail extraction, FK/IK controls, hand poses, gaze target,
  studio lighting, transparent capture, and localStorage editor preferences.
- What not to copy:
  Large single-file editor complexity, unrestricted local file assumptions, and
  local write routes without a clear workspace policy.
- What to inspect next:
  Define a multi-channel capture artifact schema for image/mask/depth/normal
  and pose outputs.

### `k3peta/web-vrm-poser`

- Interesting idea:
  Keep VRM pose authoring fully local in the browser and convert between
  `.vroidpose` quaternion records and Three.js Euler JSON for downstream apps.
- Code donor value:
  Good compact donor for drag/drop `.vrm` and `.vroidpose`, `three-vrm`
  loading, humanoid bone maps, grouped GUI sliders, hand presets, background
  controls, code copy, and `.vroidpose` download.
- Product reference value:
  Useful as a serverless creator microtool and as a conversion reference for
  avatar pipeline helpers.
- Source evidence:
  `index.html`, `README_EN.md`, and `README.md`.
- Reusable core:
  import maps, `GLTFLoader` plus `VRMLoaderPlugin`, `VRMUtils` cleanup,
  `BONE_GROUPS`, `VRM_BONE_MAP`, `currentPoseAngles`, normalized bone lookup,
  Euler application, Unity left-handed quaternion conversion, lil-gui sliders,
  hand presets, green-screen/background image, drag/drop intake, copy code, and
  download blob.
- What not to copy:
  Single-file app structure, CDN-only dependencies for production use, alert
  errors, and no formal file-size/provenance limits.
- What to inspect next:
  Split format conversion, pose schema, GUI controls, and render/capture into
  separate reusable modules.

### `Module-Code/WebXR_DePanther`

- Interesting idea:
  A Unity project can act as a packaging reference for getting XR Interaction
  Toolkit scenes into browser WebXR with visible Enter VR/AR buttons.
- Code donor value:
  Low direct code donor value, but useful configuration evidence around
  `com.de-panther.webxr`, input profiles, interactions, OpenUPM registry,
  WebXR settings, WebXR loader assets, WebGL templates, and XR simulator
  samples.
- Product reference value:
  Good reference for documenting how a Unity XR prototype can become a browser
  WebXR deliverable without implying the generated project is the reusable core.
- Source evidence:
  `Packages/manifest.json`, `Assets/XR/Settings/WebXRSettings.asset`,
  `Assets/WebGLTemplates/WebXR2020/index.html`, loader assets, and XRI sample
  input actions.
- Reusable core:
  scoped registry record, package manifest, WebXR settings asset, auto-load
  manager/input system, WebXR loader, OpenXR loader, WebGL template with Enter
  VR/AR buttons, support-check events, and XRI simulator assets.
- What not to copy:
  The whole Unity project, sample scenes, generated settings, and package
  versions without a provenance/version label.
- What to inspect next:
  Build a WebXR packaging checklist for Unity prototypes in this repository.

## Reusable Pattern Extraction

- Pattern candidate:
  `Browser VRM GLB pose scene adapter with downstream generator export`.
- Problem solved:
  Creator utilities often need an in-browser 3D editor whose output is not a
  game scene but an artifact for another tool: image, mask, depth, normal,
  pose JSON, `.vroidpose`, or WebXR package.
- Reusable core:
  local model intake, pose schema, bone map, GUI controls, capture button,
  timer capture, background/lighting controls, output channel registry, preview
  update, artifact route, path guard, thumbnail/meta store, format conversion,
  and provenance/version labels.
- Source evidence:
  `ketle-man/comfyui-vrm-pose-editor`,
  `hidenoji1/comfyui-vrm-scene-editor`, `k3peta/web-vrm-poser`, and
  `Module-Code/WebXR_DePanther`.
- Abstraction boundary:
  Keep editor state, model storage, capture artifacts, generator-node plumbing,
  and WebXR packaging as separable adapters.
- What not to copy:
  Vendor bundles, generated Unity projects, local file writes without policy,
  CDN-only production dependencies, or single-file editor sprawl.
- Method catalog action:
  Add `Method 924`.

## Why This Matters For `VR-apps-lab`

The wave adds a creator-tool branch: VR utilities can be authoring surfaces that
produce reusable downstream artifacts for AI/generator pipelines, WebXR demos,
avatar tools, and documentation scenes.
