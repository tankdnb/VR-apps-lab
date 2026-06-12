# Wave 278 - Camera-to-VRM Avatar Retargeting and Virtual-Camera Output

This wave studies camera-driven avatar retargeting projects that turn monocular
camera input into VRM/avatar motion, face/hand/body tracking, and virtual
camera or video output surfaces.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- camera-to-avatar body, hand, and face tracking;
- MediaPipe-like landmark processing and score thresholds;
- smoothing/filtering and bone/blendshape mapping;
- virtual camera or rendered output surfaces;
- fork/variant handling for duplicate avatar-retargeting projects.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Kariaro/VRigUnity` | Camera/avatar output tool | Studied with side-effect caveats | Camera capture, annotations, EVMC/VMC periphery, Windows virtual camera output |
| `creativeIKEP/HolisticMotionCapture` | Camera-to-VRM retargeting package | Studied | MediaPipe pipeline, VRM avatar pose/face/hand mapping, smoothing and thresholds |
| `zacharyguan/VRigUnity` | VRigUnity fork/variant | Variant only | Duplicate/variant line for dedupe rather than independent donor |

## Code-Level Findings

### `Kariaro/VRigUnity`

- Interesting idea:
  a Unity avatar rigging app combines camera capture, visual tracking overlays,
  VMC/EVMC ecosystem pieces, and rendered output through a virtual camera.
- Code donor value:
  useful for the capture/output boundary: configurable camera texture size,
  main-camera mirroring, UnityCapture install/uninstall script hooks,
  visualization/annotation modules, thread-awareness helper, and EVMC receiver
  package periphery.
- Product reference value:
  good reference for a "camera in, avatar out" creator utility where the output
  surface matters as much as tracking.
- What to inspect next:
  current upstream, tracking pipeline entry points, VMC output path, virtual
  camera install safety, and platform fallback.
- Reusable pattern:
  avatar capture utility with virtual output adapter.
- Caveats:
  virtual camera install scripts are side-effectful, Windows-focused, package
  payload is broad, and some tracking pipeline files are not cleanly exposed in
  this pass.

### `creativeIKEP/HolisticMotionCapture`

- Interesting idea:
  a package-level pipeline processes camera frames into body pose, hand pose,
  face blendshapes, gaze/look targets, and VRM avatar output.
- Code donor value:
  strongest donor in the wave: `HolisticMotionCapturePipeline` lifecycle,
  max-FPS throttling, pose/hand/face sub-pipelines, landmark score thresholds,
  low-pass filters, upper-body mode, VRM blendshape proxy, look-at handling,
  reset behavior, default T-to-A pose arm rotations, and bone-chain maps.
- Product reference value:
  excellent reference for a creator-facing avatar retargeting tool that treats
  camera visibility, confidence scores, smoothing, and reset as first-class UX.
- What to inspect next:
  calibration UX, package dependencies, virtual camera/Syphon output, privacy,
  and runtime performance boundaries.
- Reusable pattern:
  camera-to-avatar retargeting pipeline with score gates and smoothing.
- Caveats:
  MediaPipe/VRM dependency footprint, threshold tuning requirements, camera
  privacy risk, and output-device side effects.

### `zacharyguan/VRigUnity`

- Interesting idea:
  a fork/variant line of `Kariaro/VRigUnity` preserves the same avatar capture
  and virtual-camera tool direction.
- Code donor value:
  low until a meaningful diff is isolated.
- Product reference value:
  useful for dedupe and lineage tracking.
- What to inspect next:
  commit history and diff against `Kariaro/VRigUnity`.
- Reusable pattern:
  fork-line handling for avatar tooling.
- Caveats:
  do not promote as an independent donor without unique source evidence.

## Reusable Pattern Extraction

- Pattern candidate:
  camera-to-avatar retargeting pipeline.
- Problem solved:
  convert noisy camera landmarks into believable avatar motion and usable
  video/virtual-camera output.
- Reusable core:
  camera frame source, model inference boundary, confidence scores, low-pass
  smoothing, body bone map, hand pose map, face blendshapes, gaze/look target,
  reset state, FPS throttle, and output adapter.
- Source evidence:
  `creativeIKEP/HolisticMotionCapture` and `Kariaro/VRigUnity`.
- Abstraction boundary:
  keep camera capture, inference, retargeting, avatar-specific output, and
  virtual-camera publishing as separate layers.
- What not to copy:
  side-effectful virtual-camera installers without explicit confirmation,
  platform-specific output assumptions, duplicate forks without diff evidence,
  or privacy-sensitive camera capture without clear local-processing policy.
- Method catalog action:
  add a camera-to-avatar retargeting method.

## Follow-Up Gaps

- Build a retargeting matrix across landmark sources, score thresholds,
  smoothing filters, bone maps, blendshapes, gaze, reset, and output adapters.
- Deepen `HolisticMotionCapture` as the cleanest pipeline donor.
- Inspect VRigUnity lineage only after isolating unique deltas.
- Compare camera-to-avatar output with earlier camera-inference-to-tracker and
  VMC bridge waves.
