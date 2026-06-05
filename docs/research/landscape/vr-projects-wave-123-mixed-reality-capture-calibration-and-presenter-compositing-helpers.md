# VR Projects Wave 123: Mixed Reality Capture, Calibration, and Presenter Compositing Helpers

- Date: `2026-06-05`
- Goal: add a focused GitHub discovery wave for mixed-reality capture projects
  that align real cameras with XR scenes, split foreground/background layers,
  stream or decode camera/video payloads, and provide chroma or segmentation
  workflows.

## Why this wave exists

Mixed-reality capture is adjacent to overlays and media playback, but it has
its own reusable architecture:

- calibration wizard;
- camera intrinsics/extrinsics;
- foreground/background split;
- real camera layer;
- chroma key or segmentation;
- frame delay/sync;
- streaming, decoding, or recording boundary.

This wave studies capture/compositing helpers as reusable utility references,
not as software to run from `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by mixed reality capture, Reality Mixer, WebXR MRC, Oculus
   MRC, Quest MRC, Unity MRC, and artificial green-screen families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. reject empty/source-less candidates honestly;
6. extract methods, donor value, product value, caveats, and family overlap;
7. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `fabio914/reality-mixer-js` | WebXR/Three.js MRC module with calibration schema, chroma key, frame delay, and layer split |
| `fabio914/RealityMixerVisionPro` | Vision Pro/iPhone MRC stack with image tracking, camera pose, server, renderer, and encoder boundaries |
| `jonathanperret/mrc-client` | Minimal Oculus MRC TCP client and video payload parser |
| `zengmmm00/MixedRealityCapture` | Quest 3 MRC placeholder/reference with source still planned |
| `TonyViT/MrcXrtHelpers` | Unity XR Interaction Toolkit helpers for Oculus MRC camera setup |
| `smaerdlatigid/ArtificialGreenScreen` | Browser BodyPix artificial green-screen utility for OBS-style capture |

Rejected:

- `LIV/CalibrationForQuest` was empty in the current clone and was not counted
  as a studied donor.

## Deep-pass notes by project

## `fabio914/reality-mixer-js`

- GitHub:
  [fabio914/reality-mixer-js](https://github.com/fabio914/reality-mixer-js)
- What it is:
  a WebXR and Three.js mixed-reality capture module.
- Interesting idea:
  browser-side MRC can be packaged as a calibration object plus compositor that
  renders virtual foreground/background layers around a real webcam layer and
  compensates for camera delay.
- Code-level notes:
  `src/mrc.js` defines `CameraCalibration`, `ChromaKey`, and `Calibration`,
  validates JSON, opens `navigator.mediaDevices` webcam input, creates a
  virtual mixed-reality camera, allocates delayed foreground/background
  `WebGLRenderTarget` buffers, builds chroma-key middle layer material, disables
  WebXR rendering temporarily, renders background and foreground separately,
  then composites the output scene. `examples/calibration/` implements a
  multi-step setup flow for video size, chroma key, camera pose, JSON input,
  local persistence, and drag/drop calibration loading.
- Code donor value:
  very high for browser calibration schema, chroma key, frame delay, render
  target ring buffer, and foreground/background split.
- Product reference value:
  high for capture/debug tools that need user-guided calibration.
- Caveats:
  prototype quality; browser permissions, green screen, and OBS/external
  recording assumptions remain.
- What to inspect next:
  compare with Vision Pro and Unity MRC helpers for calibration UX.

## `fabio914/RealityMixerVisionPro`

- GitHub:
  [fabio914/RealityMixerVisionPro](https://github.com/fabio914/RealityMixerVisionPro)
- What it is:
  a mixed-reality capture package for Apple Vision Pro plus an iPhone camera
  companion.
- Interesting idea:
  a mobile-camera capture stack can be split into image tracking, camera pose
  updates, server/payload protocol, RealityKit rendering, texture packing, and
  video encoding.
- Code-level notes:
  `MixedRealityCaptureManager.swift` manages image tracking, camera extrinsics,
  device pose queries, display-link updates, renderer/encoder lifecycle, and
  server updates. `MixedRealityServer.swift`, `ReceivedPayload.swift`,
  `Protocol.swift`, and `Payloads.swift` define camera update, button, and
  video payload boundaries. `MixedRealityRenderer.swift` renders foreground and
  background RealityKit passes with near/far split, extracts alpha, and packs
  textures. `VideoEncoder.swift` encodes frames. The iPhone project mirrors the
  protocol from the capture side and uses ARKit person segmentation/depth and
  camera update sending.
- Code donor value:
  very high for mobile camera plus headset capture architecture, payload
  protocol, renderer split, and encoder boundary.
- Product reference value:
  very high for future presenter/capture utilities.
- Caveats:
  Apple platform stack and prototype assumptions; not a cross-platform capture
  library.
- What to inspect next:
  compare protocol framing with `mrc-client` and WebXR calibration JSON.

## `jonathanperret/mrc-client`

- GitHub:
  [jonathanperret/mrc-client](https://github.com/jonathanperret/mrc-client)
- What it is:
  a minimal Oculus Mixed Reality Capture client.
- Interesting idea:
  a capture client can be a tiny parser that reconnects to a TCP stream,
  reads typed length-prefixed frames, waits for video dimensions, then pipes
  video data into an external viewer.
- Code-level notes:
  `index.js` connects to port `28734`, parses payload type and length from a
  fixed frame header, handles `VIDEO_DIMENSION` and `VIDEO_DATA`, spawns
  `ffplay`, crops the side-by-side stream, flips/scales it, and reconnects on
  closure unless the viewer exits.
- Code donor value:
  medium-high for framed payload parsing and minimal video-client anatomy.
- Product reference value:
  medium for debug clients and capture transport probes.
- Caveats:
  depends on external `ffplay` and Oculus MRC protocol assumptions.
- What to inspect next:
  compare with any official/modern Quest MRC stream docs if capture tooling
  becomes active.

## `zengmmm00/MixedRealityCapture`

- GitHub:
  [zengmmm00/MixedRealityCapture](https://github.com/zengmmm00/MixedRealityCapture)
- What it is:
  a thin Quest 3 mixed-reality capture placeholder with a stated toolkit
  release plan.
- Interesting idea:
  the project signals demand for phone/computer Quest 3 capture workflows, but
  currently does not expose enough source to act as a code donor.
- Code-level notes:
  the repository currently contains README-level framing and an open-source
  plan, not a toolkit implementation.
- Code donor value:
  low until source is released.
- Product reference value:
  medium as a follow-up marker for Quest 3 capture workflows.
- Caveats:
  source not available in this pass.
- What to inspect next:
  revisit after the planned toolkit release.

## `TonyViT/MrcXrtHelpers`

- GitHub:
  [TonyViT/MrcXrtHelpers](https://github.com/TonyViT/MrcXrtHelpers)
- What it is:
  Unity helpers for Oculus MRC in XR Interaction Toolkit projects.
- Interesting idea:
  MRC integration bugs can be solved with narrow helper scripts that keep
  camera intrinsics/extrinsics updated and prevent auto-added tracking
  components from moving external capture cameras incorrectly.
- Code-level notes:
  `OVRMixedRealityCaptureTestMod.cs` enables mixed reality, resets default
  external camera state, calculates intrinsics from a Unity camera's field of
  view and 1080p target resolution, converts camera pose into tracking-space
  relative pose, handles Quest-stage origin differences, and updates default
  external camera data every frame. `RemoveMRCamerasTracking.cs` repeatedly
  removes `TrackedPoseDriver` components from Oculus MRC foreground/background
  cameras because Unity may recreate them.
- Code donor value:
  high for external-camera intrinsics/extrinsics and Unity MRC repair helpers.
- Product reference value:
  medium-high for creator-facing capture setup utilities.
- Caveats:
  Oculus/OVRPlugin and Unity XRT assumptions.
- What to inspect next:
  compare against newer Meta MR camera/depth samples from Wave 114.

## `smaerdlatigid/ArtificialGreenScreen`

- GitHub:
  [smaerdlatigid/ArtificialGreenScreen](https://github.com/smaerdlatigid/ArtificialGreenScreen)
- What it is:
  a browser BodyPix person-segmentation utility for artificial green-screen
  effects.
- Interesting idea:
  capture utilities can support users without a physical green screen by
  generating a mask from a person-segmentation model and feeding the result to
  OBS or a browser compositor.
- Code-level notes:
  `static/js/webcam.js` loads BodyPix, opens a webcam through TensorFlow.js,
  repeatedly segments the person, converts the segmentation to a mask, and
  draws it to a canvas. `webcam_worker.js` contains a slower color-filter path
  that modifies mask colors/alpha for green-screen-style output.
- Code donor value:
  medium for segmentation-as-chroma-key fallback.
- Product reference value:
  medium for capture setup helpers and accessibility to MRC workflows.
- Caveats:
  older TensorFlow.js/BodyPix style and prototype UI.
- What to inspect next:
  compare with modern segmentation APIs if presenter-compositing tools become
  active.

## Cross-project synthesis

This wave adds a reusable `mixed reality capture utility` pattern:

- define or receive camera intrinsics/extrinsics;
- guide calibration through UI or image tracking;
- render virtual foreground/background passes;
- place real camera video or segmentation/chroma layer in the middle;
- delay/synchronize frames;
- stream, encode, decode, or hand off to OBS/external viewers;
- expose repair helpers for runtime-created capture cameras.

The strongest donor direction is not one repo. It is a portable decomposition
of MRC into calibration, layer split, camera stream, and recording boundary.

## Follow-up

1. Build a capture/compositing method matrix across WebXR, Vision Pro,
   Unity/OVR, and browser segmentation references.
2. Revisit Quest 3 MRC placeholders only after source appears.
3. Consider a reuse plan if `VR-apps-lab` starts a presenter/capture utility
   branch.
