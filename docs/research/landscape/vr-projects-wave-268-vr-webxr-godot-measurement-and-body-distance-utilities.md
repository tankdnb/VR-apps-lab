# Wave 268 - VR/WebXR/Godot Measurement and Body-Distance Utilities

This wave studies small measurement and calibration utilities: visual IPD
measurement, Godot body-measurement state, mobile/browser distance capture, and
camera/WebRTC measurement demos.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to projects that expose one of these measurement surfaces:

- visual calibration without a full XR runtime;
- engine-side user measurement persistence;
- browser/mobile camera distance capture;
- WebRTC-assisted remote measurement and annotation plumbing;
- source-light or empty measurement repos that should be classified honestly.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `leetarry/VR_Measure` | Source-light measurement placeholder | Empty/source-light | Search result with no donor evidence in the inspected branch |
| `rlaboiss/ipd-vr-measure` | Visual IPD calibration microtool | Studied | Tiny Pygame visual-convergence measurement approach |
| `AyOhEe/Godot-VR-Measurements` | Godot XR body-measurement helper | Studied | Measurement autoload, config persistence, and rig offset correction |
| `NeosoftMadhuri/webxr-measure` | Source-light WebXR measurement placeholder | Empty/source-light | No source found in inspected branch |
| `maverickjimmx/webxr-measure` | Browser/mobile inspection measurement form | Studied with caveats | Camera, orientation, sketch/signature, and Google Sheets workflow |
| `Vedant22-marda/webxr-measurement-app` | Camera/WebRTC measurement demo | Studied with caveats | Tap-to-measure overlay plus Flask-SocketIO WebRTC signaling |

## Code-Level Findings

### `leetarry/VR_Measure`

- Interesting idea:
  VR measurement intent only.
- Code donor value:
  none found; inspected branch was empty.
- Product reference value:
  only as source-light evidence that measurement keywords produce empty
  candidates.
- What to inspect next:
  branches, releases, or forks with actual source.
- Caveats:
  do not count as a donor.

### `rlaboiss/ipd-vr-measure`

- Interesting idea:
  a no-runtime IPD helper that shows two moving cross/circle targets and lets
  the user key-capture visual convergence limits.
- Code donor value:
  useful as a micro-calibration baseline: Pygame no-frame window, target
  converge/diverge loop, two key-captured extrema, and a simple pixel-to-mm
  transform.
- Product reference value:
  good reminder that some VR calibration tools can be extremely narrow and
  still useful.
- What to inspect next:
  configurable display geometry, multi-monitor detection, user language, and
  validation against headset/runtime IPD.
- Caveats:
  hardcoded screen position, screen size, axis distance, and no modern XR
  runtime integration.

### `AyOhEe/Godot-VR-Measurements`

- Interesting idea:
  expose user body measurements as a Godot autoload singleton and use them to
  correct a VR camera rig offset.
- Code donor value:
  strong for engine-side measurement state: `VRUserMeasurements` static
  facade, `MeasurementsAutoload` config load/save, measurement-changed signal,
  estimation fallbacks, and `CorrectedCameraRig` applying
  `TrackedOffsetVector`.
- Product reference value:
  useful for avatar/body calibration UIs, accessibility presets, and
  per-user measurement persistence.
- What to inspect next:
  UI for editing values, unit handling, estimation provenance, and Godot 4/XR
  plugin compatibility.
- Caveats:
  some estimation formulas are explicitly rough and should stay transparent to
  users.

### `NeosoftMadhuri/webxr-measure`

- Interesting idea:
  WebXR measurement intent only.
- Code donor value:
  none found; inspected branch was empty.
- Product reference value:
  source-light classification only.
- What to inspect next:
  branches, releases, or related deployments.
- Caveats:
  do not promote to method evidence.

### `maverickjimmx/webxr-measure`

- Interesting idea:
  a mobile browser inspection form that turns camera orientation and captured
  points into a cable-route measurement workflow with sketch/signature capture.
- Code donor value:
  useful for browser-side operator flow: `DeviceOrientationEvent` permission,
  pitch coaching, point adding, floor/vertical/final meter fields, canvas
  sketch/signature capture, progress gating, and JSON submission to Google
  Apps Script.
- Product reference value:
  strong UX reference for guided measurement forms, even though it is not a
  clean WebXR utility.
- What to inspect next:
  real measurement accuracy, WebXR API usage, privacy of captured sketches and
  signatures, and configurable backend endpoint.
- Caveats:
  hardcoded Google Apps Script URL, EV-inspection-specific domain, and no clear
  WebXR runtime use despite the repository name.

### `Vedant22-marda/webxr-measurement-app`

- Interesting idea:
  combine camera capture, a two-point overlay measurement fallback, and
  WebRTC signaling for remote viewing.
- Code donor value:
  useful as a compact surface-ingress example: `getUserMedia` environment
  camera, click/tap overlay canvas, pixel-distance estimation, Flask static
  serving, SocketIO rooms, STUN config, offer/answer/candidate forwarding, and
  dynamic remote video insertion.
- Product reference value:
  good low-cost sketch for remote-assisted measurement or inspector tools.
- What to inspect next:
  calibrated scale, mobile touch handling, HTTPS requirements, room naming,
  auth, and whether OpenCV.js is actually used beyond the simple fallback.
- Caveats:
  rough `pixelDist / 400` distance scale and unauthenticated default room.

## Reusable Pattern Extraction

- Pattern candidate:
  measurement utility boundary across visual calibration, body measurements,
  camera measurement, and remote inspection.
- Problem solved:
  VR utilities often need real-world dimensions before a full feature can work:
  IPD, height, tracked offsets, arm/span/body values, cable distance, or
  external measurement annotations.
- Reusable core:
  measurement source, unit/scale model, user-editable config, calibration
  confidence, capture UI, persistence, signal/update boundary, and follow-up
  diagnostics.
- Source evidence:
  Pygame convergence in `ipd-vr-measure`, Godot autoload and corrected rig in
  `Godot-VR-Measurements`, phone orientation form in `webxr-measure`, and
  camera/WebRTC overlay in `webxr-measurement-app`.
- Abstraction boundary:
  keep measurement capture separate from runtime application logic so a future
  VR tool can replace the source with headset, camera, manual, or companion
  data.
- What not to copy:
  hardcoded display geometry, opaque estimation formulas, fixed backend URLs,
  unauthenticated signaling, or empty repos as donor evidence.
- Method catalog action:
  create a method for measurement/calibration utility boundaries.

## Family Placement

This wave creates a measurement and calibration utility family. It overlaps
with spatial workbenches, Quest companion helpers, and browser surface-ingress
patterns, but its main value is making the measurement source and confidence
boundary explicit.

## Backlog Impact

- Build a measurement/capture matrix across visual IPD, body values, camera
  taps, orientation-derived distance, and remote assistant flows.
- Deepen `Godot-VR-Measurements` if a Godot XR calibration baseline is needed.
- Keep empty measurement repos as source-light, not donors.
