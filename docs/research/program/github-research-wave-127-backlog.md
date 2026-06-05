# GitHub Research Wave 127 Backlog

- Date: `2026-06-05`
- Scope: browser-native WebXR utility surfaces, creative tools, stereo media,
  diagnostics, audio/biometric visualizers, and data dashboards.

## Completed in this wave

- Studied `aframevr/a-painter` as a controller-aware WebXR painting utility
  with save/load/share flow.
- Studied `leapmotion/LeapShape` as a hand/controller CAD-like WebXR tool with
  contextual palm menus.
- Studied `zfox23/spatial-photo-webxr-viewer` as a local-first Apple Spatial
  Photo to stereo WebXR viewer.
- Studied `ivanik7/vr-screen-tester` as a compact headset pattern and FPS
  diagnostic surface.
- Studied `kquizz/vr-visualizer-web` as an audio-reactive WebXR visualizer with
  controller parameter modes.
- Studied `Kineviz/OpenBCI-WebXR-EEG` as a biometric stream to WebXR
  point-cloud visualization.
- Studied `msitarzewski/prediction-space` as a gaze/pinch VR data dashboard.
- Studied `taplivenetwork/taplive-webxr` as a README-level 360/WebRTC WebXR
  streaming reference with no current source.

## Reuse candidates

- `LeapShape` is the strongest donor for hand/controller input and contextual
  tool menus.
- `a-painter` is the strongest donor for controller-specific creative workflow
  and save/load/share behavior.
- `spatial-photo-webxr-viewer` is a strong local-first stereo media donor.
- `prediction-space` is a strong donor for gaze/pinch data dashboards and
  canvas-texture detail panels.
- `vr-screen-tester` is a strong micro-utility reference.

## Follow-up backlog

1. Extract a WebXR utility-surface matrix across creative, media, diagnostics,
   data, and streaming.
2. Compare WebXR hand/palm menus with native overlay menu waves.
3. Revisit `taplive-webxr` only after source appears.
4. Consider a reuse plan for `LeapShape` if browser-native hand UI becomes an
   active prototype direction.

## Quality notes

- No found project was built, launched, installed, or run.
- Source-less projects were labelled as product references or gaps, not donors.
