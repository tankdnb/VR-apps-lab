# Wave 475: XR file/model/media intake and local viewer surfaces

- Date: `2026-07-18`
- Scope: local file/model intake, GLB folder browsers, browser point-cloud
  viewers, local HTTPS model serving, Unity video/GLB import surfaces, and
  browser-control panels for VR assets.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `ClassOutside/WebXR-Model-Viewer` | Studied | React host plus HTTPS media service that browses local GLB folders and feeds a Unity WebGL surface |
| `Betakontext/rgbtoxyzpointcloud` | Studied | A-Frame browser utility that converts uploaded images into RGB/XYZ point clouds with cache-backed VR viewing |
| `immerse-zhaw/VR_Video_Player_GLB` | Studied | Unity XR project with WebSocket commands for 2D/360 video playback and persistentData GLB import |
| `lxseguin/local-vr-viewer` | Studied | Python HTTPS micro-server and Three.js/WebXR viewer for local GLB/GLTF/OBJ/STL files |
| `jjhna/UnityBrowserAssetsVR` | Lightly studied | Older browser-panel assets and HTML control demos for Unity/VR browser surfaces |

## Project notes

### `ClassOutside/WebXR-Model-Viewer`

- Interesting idea: a local media service can expose a paginated GLB folder
  browser to a Unity WebGL build embedded in a React host.
- Code donor value: medium for local folder browsing, media streaming, and
  browser-to-Unity `SendMessage` glue.
- Product reference value: medium to high for local asset library and model
  review utilities.
- Source evidence: `README.md`, `Frontend/src/index.js`,
  `Frontend/src/UnityLoader.js`, `MediaService/server.js`,
  `FolderController.js`, `ModelController.js`, `FolderService.js`, and
  `ModelService.js`.
- Reusable core: HTTPS Express media service, CORS gate, starting-folder config,
  folder/page endpoints, directory/folder/file entries, valid `.glb` filter,
  streamed `model/gltf-binary`, React iframe host, Unity instance polling, and
  `ExplorerManager.SetBaseURL` message.
- What not to copy: broad filesystem exposure, weak path-scope validation,
  GLB-only filter as a default, hard-coded iframe sizing, and localhost
  certificate/key assumptions.
- What to inspect next: safe folder root policy, thumbnails/metadata, model
  provenance, and Unity-side explorer components.

### `Betakontext/rgbtoxyzpointcloud`

- Interesting idea: an uploaded 2D image can become an explorable VR point
  cloud by treating RGB values as XYZ coordinates and rendering the result in
  A-Frame.
- Code donor value: high for browser-only intake, cache-backed large data, and
  VR-optimized media resolution choices.
- Product reference value: high for playful visualizers, education, image-to-3D
  experiments, and WebXR asset preview microtools.
- Source evidence: `README.md`, `public/index.html`, `public/script.js`,
  `public/upload.js`, and `public/styles.css`.
- Reusable core: A-Frame scene with `local-floor`, file input, URL/image
  resolver, Wikimedia thumbnail fallback, CORS hints, image pixel packing to
  RGB8 binary, Cache API storage, localStorage backup, app-version cache
  invalidation, point-cloud component, GPU resource disposal, fit-to-view, and
  RGB/XYZ transform mode.
- What not to copy: unbounded point count without device labels, alert-based
  error UX, mixed CDN/runtime dependencies, AI-generated code caveat, and
  public-image URL assumptions.
- What to inspect next: point budget presets for Quest, offline sample pack
  provenance, export format, and accessibility labels for color/space meaning.

### `immerse-zhaw/VR_Video_Player_GLB`

- Interesting idea: a Unity XR viewer can expose a simple WebSocket command API
  for local video playback, 2D/360 mode switching, seeking, video listing, and
  GLB import into a grabbable scene.
- Code donor value: high for command-to-main-thread dispatch and file-backed
  media/runtime import.
- Product reference value: high for local media companion tools, museum/video
  kiosks, training playback, and asset review labs.
- Source evidence: `Assets/Scripts/WebSocketServer.cs`,
  `VideoManager.cs`, `GLBImporter.cs`, `Assets/Scenes/VideoPlayer.unity`, and
  `WebControl`.
- Reusable core: Fleck WebSocket server, JSON command envelope, main-thread
  action queue, `SampleVids` and `GLB_Objects` persistent folders, video list
  response, `VideoPlayer` URL playback, 2D/360 player split, skybox texture mode,
  pause/resume/seek, GLTFast import, spawn transform, collider/rigidbody setup,
  and `XRGrabInteractable` attachment.
- What not to copy: unauthenticated `ws://0.0.0.0:8080`, raw file paths in
  messages, all-files-in-persistentData assumptions, sample XR package bulk, and
  no explicit file-size/provenance checks.
- What to inspect next: command authorization, file picker/SAF bridge, media
  progress events, and per-asset metadata.

### `lxseguin/local-vr-viewer`

- Interesting idea: a single-file local CLI can serve one model over HTTPS and
  open it in a Quest browser with WebXR controls, no full Unity project needed.
- Code donor value: high as a focused local viewer micro-utility.
- Product reference value: high for quick model review, scan QA, and local
  spatial asset previews.
- Source evidence: `server.py` and `public/index.html`.
- Reusable core: supported extension whitelist, self-signed certificate
  creation, local IP discovery, port fallback, `/api/model-info`, model and
  model-dir routes, correct model MIME types, GLTF/OBJ/MTL/STL loaders,
  loading overlay, auto-fit, floor-height and scale sliders, sky brightness,
  floor grid, controller locomotion, snap turn, teleport arc, and explicit Quest
  URL hints.
- What not to copy: automatic OpenSSL dependency without fallback, self-signed
  certificate warning as a permanent UX, no auth, and CDN importmap reliance.
- What to inspect next: Windows/macOS launch wrappers, drag-and-drop file
  selection, thumbnail cache, and source-root sandboxing.

### `jjhna/UnityBrowserAssetsVR`

- Interesting idea: browser surfaces embedded in Unity/VR can use small HTML
  panels for URL navigation, tab switching, resizing, HUDs, and control
  dashboards.
- Code donor value: low to medium; this is an older collection of HTML/JS
  panels, not a modern WebXR or Unity package.
- Product reference value: medium for browser-panel UX primitives and warnings
  about too many animated tabs causing frame-rate/sickness issues.
- Source evidence: `demo/VRMainControlPanel.html`,
  `demo/VRControlPanel.html`, `demo/SelectDemoPanel.html`, and
  `resize/ScreenResizeScript.js`.
- Reusable core: compact browser control panel, URL form, back/forward/refresh,
  close, tab switcher, displayed current URL, numeric size fields, and explicit
  performance/sickness warning.
- What not to copy: bundled old jQuery/Bootstrap, missing Unity C# bridge files
  in the checked source, old browser-control assumptions, and non-XR-specific
  HTML styling.
- What to inspect next: whether related Unity scripts are available and how HTML
  panel events map into Unity browser texture controls.

## Reusable pattern extraction

- Pattern candidate: `Local XR file and media intake surface`.
- Problem solved: VR utilities often need to bring local models, media, or
  images into an XR view while making file scope, transport, format support, and
  control state understandable.
- Reusable core: provider/scope descriptor, supported format whitelist,
  local-only HTTPS or WebSocket sidecar, model-info endpoint, media/file list,
  correct MIME types, viewer loading/progress/errors, auto-fit and floor/scale
  controls, WebXR enter state, command bridge into Unity main thread, persistent
  asset folders, provenance labels, and cleanup/security boundaries.
- Source evidence: `WebXR-Model-Viewer/MediaService/*`,
  `WebXR-Model-Viewer/Frontend/src/*`,
  `rgbtoxyzpointcloud/public/*`, `VR_Video_Player_GLB/Assets/Scripts/*`,
  `local-vr-viewer/server.py`, `local-vr-viewer/public/index.html`, and
  `UnityBrowserAssetsVR/demo/*`.
- Abstraction boundary: keep file discovery, local transport, asset loading,
  viewer controls, command bridge, and provenance/security UI independent.
- What not to copy: unrestricted filesystem browsing, unauthenticated LAN
  servers, raw file paths, embedded cert/key assumptions, CDN-only dependencies,
  and unbounded asset complexity without device labels.
- Method catalog action: add `Method 920`.

## Why this matters for VR-apps-lab

This wave strengthens the practical "bring content into VR" line. The strongest
lesson is that file/media intake should be treated as a utility surface with
format scope, transport scope, progress/error UX, and provenance, not just a
loader call.
