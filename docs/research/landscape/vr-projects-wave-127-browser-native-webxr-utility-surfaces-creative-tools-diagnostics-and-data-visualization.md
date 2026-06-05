# VR Projects Wave 127: Browser-Native WebXR Utility Surfaces, Creative Tools, Diagnostics, and Data Visualization

- Date: `2026-06-05`
- Goal: study browser-native WebXR utility surfaces that display, create,
  inspect, or visualize useful information in VR without native runtime
  overlays.

## Why this wave exists

WebXR projects are useful to `VR-apps-lab` when they demonstrate compact VR
surfaces:

- creative tools with controller-specific UX;
- hand and palm menu systems;
- stereo/spatial image viewers;
- headset screen diagnostics;
- audio or EEG visualization;
- gaze/pinch data panels;
- real-time streaming surface framing.

This wave focuses on browser-native VR utility ideas, not on generic WebXR
samples.

## Better workflow used in this wave

1. searched GitHub by WebXR creative tools, VR visualizer, spatial photo,
   headset tester, WebXR EEG, data visualization, and WebRTC/360 streaming
   families;
2. deduplicated against WebXR samples, A-Frame, immersive browser, audio, and
   media waves;
3. froze a bounded shortlist;
4. inspected local-only source clones;
5. labeled source-less or README-only candidates honestly;
6. extracted reusable input, menu, rendering, diagnostics, and data-surface
   methods.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `aframevr/a-painter` | Controller-aware WebXR painting tool with save/load/share workflow |
| `leapmotion/LeapShape` | Three.js/WebXR CAD-like tool with hand/controller input and palm menus |
| `zfox23/spatial-photo-webxr-viewer` | Browser spatial-photo HEIC to stereo WebXR viewer |
| `ivanik7/vr-screen-tester` | Tiny WebXR headset pattern and FPS diagnostic surface |
| `kquizz/vr-visualizer-web` | Audio-reactive Three.js/WebXR visualizer with controller controls |
| `Kineviz/OpenBCI-WebXR-EEG` | WebXR EEG point cloud and data server reference |
| `msitarzewski/prediction-space` | WebXR data market visualization with gaze, pinch, and 3D detail panel |
| `taplivenetwork/taplive-webxr` | README-level WebXR 360/WebRTC viewer reference with no current source |

## Deep-pass notes by project

## `aframevr/a-painter`

- GitHub:
  [aframevr/a-painter](https://github.com/aframevr/a-painter)
- What it is:
  a browser-native VR painting tool built on A-Frame.
- Interesting idea:
  a creative WebXR tool can make controller-specific input mappings,
  brush-tip feedback, save/load, URL import, upload, and social sharing part of
  the core utility shell.
- Code-level notes:
  `src/systems/painter.js` maps Vive, Oculus, and WMR controls to painting,
  undo, brush size, menu toggles, teleport, background parameters, URL-loaded
  paintings, JSON/binary save, Cloudinary upload, and stroke/upload events.
  `src/components/paint-controls.js` creates controller models and brush tips,
  handles absolute/incremental brush size, controller connection state,
  color/size feedback, button highlighting, and tooltip fade after a few
  strokes.
- Code donor value:
  high for controller-specific creative tool UX and save/load/share flow.
- Product reference value:
  high for browser-native utility surfaces with real user value.
- Caveats:
  older A-Frame-era code and service-specific upload path.
- What to inspect next:
  compare input mapping with LeapShape's hand/controller tool selection.

## `leapmotion/LeapShape`

- GitHub:
  [leapmotion/LeapShape](https://github.com/leapmotion/LeapShape)
- What it is:
  an experimental WebXR/Three.js CAD-like modelling tool.
- Interesting idea:
  a WebXR utility can blend controllers, hands, pinch state, hover colors,
  camera-facing icons, and palm/secondary-hand menu placement into a rich
  direct-manipulation surface.
- Code-level notes:
  `OpenXRInput.js` builds controller and hand models, tracks pinch state,
  switches main/secondary hand, owns interaction rays, hover colors, palm-facing
  menu placement, and active-ray timing. `Menu.js` lays out spherical tool menu
  items with icons, camera-facing billboards, hover/pressed/held/active colors,
  contextual visibility, hold/release activation, lerped motion, and VR/non-VR
  aspect handling. The backend includes OpenCascade meshing, workers, tools,
  boolean operations, history, and file IO.
- Code donor value:
  very high for hand/controller input and contextual tool menu design.
- Product reference value:
  very high for serious browser-native VR tooling.
- Caveats:
  ambitious modelling stack with more complexity than most utilities need.
- What to inspect next:
  extract a small hand-menu method independent of CAD operations.

## `zfox23/spatial-photo-webxr-viewer`

- GitHub:
  [zfox23/spatial-photo-webxr-viewer](https://github.com/zfox23/spatial-photo-webxr-viewer)
- What it is:
  a React Three Fiber WebXR viewer for Apple Spatial Photo `.heic` files.
- Interesting idea:
  stereo photo viewing can be a local-first browser utility: drag/drop a HEIC,
  convert it on-device, split layers, build side-by-side textures, and assign
  left/right eye layers in WebXR.
- Code-level notes:
  `Viewer.jsx` creates a React Three Fiber canvas, XR store, drag/drop and file
  input, XR enter/exit button, XR origin placement, desktop FOV reset, and
  local object URLs. `ImmersiveImageMesh.jsx` fetches the local object URL,
  converts HEIC to multiple PNG layers with `heic2any`, discards the extra
  Apple layer when needed, draws left/right images into an offscreen side-by-
  side canvas, creates two cloned textures with `repeat` and `offset`, assigns
  them to separate layers, and disposes textures on cleanup.
- Code donor value:
  high for local-first stereo media conversion and per-eye texture handling.
- Product reference value:
  high for tiny browser VR utilities that do one thing well.
- Caveats:
  HEIC conversion and Apple Spatial Photo layer assumptions.
- What to inspect next:
  compare with VR180/video playback waves for projection and layer handling.

## `ivanik7/vr-screen-tester`

- GitHub:
  [ivanik7/vr-screen-tester](https://github.com/ivanik7/vr-screen-tester)
- What it is:
  a browser WebXR headset screen pattern tester.
- Interesting idea:
  a diagnostic VR utility can be only a few pattern surfaces plus FPS/control
  state and still be useful.
- Code-level notes:
  `XRApp.jsx` hosts a hidden React Three Fiber canvas with an XR store and
  frame-rate state. The project includes white, red, green, blue, black, gray,
  and glare patterns, state contexts, XR scene/control components, a head-linked
  object, and FPS display.
- Code donor value:
  medium for tiny diagnostic surface anatomy.
- Product reference value:
  high as a micro-utility proof.
- Caveats:
  intentionally narrow.
- What to inspect next:
  extend the diagnostic method with lens, mura, persistence, and color test
  references if more screen-test projects appear.

## `kquizz/vr-visualizer-web`

- GitHub:
  [kquizz/vr-visualizer-web](https://github.com/kquizz/vr-visualizer-web)
- What it is:
  a Three.js/WebXR audio-reactive VR visualizer.
- Interesting idea:
  a browser visualizer can expose controller-driven preset and parameter
  changes in VR while keeping audio analysis and rendering in one utility
  surface.
- Code-level notes:
  `src/vr.ts` maps a Milkdrop snapshot canvas onto an inverted sphere, uses
  bass energy for pulse, supports optional Quest passthrough fallback,
  integrates controller input through `VRControls`, navigates presets, maps
  thumbstick modes to zoom, rotation, warp, decay, color, gamma, and scale, and
  runs through `renderer.setAnimationLoop`.
- Code donor value:
  medium-high for audio-to-WebXR visual surface and controller parameter modes.
- Product reference value:
  high for immersive media/utility surfaces.
- Caveats:
  visualizer-specific and not a general diagnostics tool.
- What to inspect next:
  connect with spatial audio and immersive media waves.

## `Kineviz/OpenBCI-WebXR-EEG`

- GitHub:
  [Kineviz/OpenBCI-WebXR-EEG](https://github.com/Kineviz/OpenBCI-WebXR-EEG)
- What it is:
  a WebXR EEG visualization experiment around OpenBCI data.
- Interesting idea:
  biometric streams can be visualized as spatial point clouds when device
  profiles, data server boundaries, color mapping, and point-size mapping are
  explicit.
- Code-level notes:
  `server/dataServer.js` conditionally attaches CSV playback and OpenBCI Cyton
  or Ganglion modules before starting an Express data server. `eegPointcloud.js`
  loads a device profile, builds point positions/colors/sizes in
  `BufferGeometry`, uses custom shader attributes, and updates color/size from
  frequency/intensity values with clamped range mapping.
- Code donor value:
  medium for streaming-data-to-pointcloud visualization.
- Product reference value:
  medium-high for biometric and diagnostics surfaces.
- Caveats:
  older Three.js style and research prototype assumptions.
- What to inspect next:
  compare with biometric bridge and neurofeedback waves.

## `msitarzewski/prediction-space`

- GitHub:
  [msitarzewski/prediction-space](https://github.com/msitarzewski/prediction-space)
- What it is:
  a Three.js/WebXR prediction-market data visualization.
- Interesting idea:
  dense external data can become a VR information surface through volume-sized
  spheres, category zones, gaze hover, pinch selection, 3D detail panels, and
  two-hand scene manipulation.
- Code-level notes:
  `visualization.js` maps market events into grouped sphere objects, category
  zones, volume-scaled radius, price/activity color, labels that fade by
  camera distance, update/diff removal, and volume-spike pulsing.
  `interaction.js` keeps desktop HTML panels separate from VR canvas panels,
  renders detail UI to a canvas texture, places it 1.5 meters ahead of the XR
  camera, uses gaze raycasting and a reticle for hover, opens/closes with
  pinch/select, and maps two-hand pinch to zoom, rotate, lateral movement, and
  vertical translation while decoupling head movement from scene manipulation.
- Code donor value:
  high for browser-native data visualization and interaction patterns.
- Product reference value:
  high for diagnostics dashboards and information surfaces.
- Caveats:
  domain-specific data source and prototype UI.
- What to inspect next:
  compare with overlay dashboards and telemetry visualization methods.

## `taplivenetwork/taplive-webxr`

- GitHub:
  [taplivenetwork/taplive-webxr](https://github.com/taplivenetwork/taplive-webxr)
- What it is:
  a README-level WebXR/WebRTC 360 streaming viewer reference.
- Interesting idea:
  360 live-streaming in WebXR is product-framed as a browser client sharing
  backend rooms, tokens, signaling, and WebRTC SFU infrastructure with native
  XR clients.
- Code-level notes:
  the current clone contains README and `.gitignore` only. The README describes
  planned Three.js/WebXR, WebRTC/LiveKit, panoramic video sphere, room join,
  search preview, HUD, controller, and API modules, but source files are not
  present in this pass.
- Code donor value:
  low until source appears.
- Product reference value:
  medium as a streaming-surface follow-up marker.
- Caveats:
  not a current code donor.
- What to inspect next:
  revisit only if implementation source is published.

## Cross-project synthesis

This wave adds a reusable `browser-native VR utility surface` pattern:

- use WebXR as a deployable utility shell;
- keep data/media processing local when possible;
- map controllers, gaze, hands, and pinch to a small number of meaningful
  actions;
- render 2D detail panels onto textures when DOM is not enough in XR;
- support compact diagnostics, creative tools, visualizers, and information
  surfaces without native overlay dependencies;
- label README-only projects as product references instead of code donors.

The strongest donors are `LeapShape` for hand/menu input, `a-painter` for
controller-aware creative workflow, `spatial-photo-webxr-viewer` for local
stereo media handling, and `prediction-space` for VR data dashboards.

## Follow-up

1. Extract a WebXR utility-surface pattern matrix: creative, media,
   diagnostic, data, and streaming.
2. Compare palm menu, gaze/pinch, and controller-specific mappings with native
   overlay menu waves.
3. Revisit `taplive-webxr` only if source appears.
