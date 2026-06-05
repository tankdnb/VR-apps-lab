# GitHub Research Wave 123 Backlog

- Date: `2026-06-05`
- Scope: mixed-reality capture, calibration, foreground/background rendering,
  external camera streaming, Oculus/Quest MRC helpers, and browser
  segmentation/green-screen workflows.

## Completed in this wave

- Studied `fabio914/reality-mixer-js` as a WebXR/Three.js mixed-reality
  capture module with JSON calibration, chroma key, frame delay, and
  foreground/background render targets.
- Studied `fabio914/RealityMixerVisionPro` as a Vision Pro plus iPhone
  mixed-reality capture stack with image tracking, camera pose updates,
  renderer/encoder/server boundaries, and foreground/background texture
  packing.
- Studied `jonathanperret/mrc-client` as a minimal Oculus MRC TCP client that
  parses framed payloads and pipes video into `ffplay`.
- Studied `zengmmm00/MixedRealityCapture` as a thin Quest 3 MRC placeholder
  with an open-source plan but no toolkit source yet.
- Studied `TonyViT/MrcXrtHelpers` as Unity helpers for Oculus MRC in XR
  Interaction Toolkit projects, including default external camera updates and
  removal of unwanted tracked-pose drivers from MRC cameras.
- Studied `smaerdlatigid/ArtificialGreenScreen` as a browser BodyPix
  segmentation tool for artificial green-screen capture.
- Rejected `LIV/CalibrationForQuest` as an empty repository in the current
  clone; it was not promoted as a studied donor.

## Reuse candidates

- `reality-mixer-js` is the strongest donor for browser-side MRC calibration
  schema, chroma key setup, frame-delay handling, and foreground/background
  render split.
- `RealityMixerVisionPro` is the strongest donor for mobile camera plus
  headset capture architecture: image tracking, camera extrinsics, server,
  renderer, encoder, and payload protocol boundaries.
- `MrcXrtHelpers` is a useful Unity micro-donor for external camera intrinsics,
  extrinsics, tracking-space conversion, and persistent removal of unwanted MRC
  camera tracking components.
- `ArtificialGreenScreen` is useful as a segmentation-based fallback when a
  physical green screen or chroma key workflow is not available.

## Follow-up backlog

1. Extract a generic `mixed reality capture utility` blueprint: calibration
   wizard, camera model, foreground/background split, real-video layer,
   delay/sync, and export/recording boundary.
2. Compare WebXR, Vision Pro, Unity/OVR, and OBS-oriented capture workflows.
3. Revisit `zengmmm00/MixedRealityCapture` after its planned toolkit source is
   released.
4. Keep empty/source-less MRC repos out of `Already studied` status unless a
   future pass finds code.
5. Consider a reuse-plan only if capture/compositing becomes an active
   prototype branch.

## Quality notes

- No third-party project was built, launched, installed, or run.
- Empty/source-less repositories were labelled honestly.
- Downloaded source clones belong only in local cache and should be removed
  after the wave is committed.
