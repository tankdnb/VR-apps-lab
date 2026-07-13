# Wave 394: Sign Language, Hand Pose, and Gesture Recognition Training

## Theme

Hand tracking as a learning and recognition system: ASL/sign practice,
finger-alphabet scoring, and reusable gesture-recognition engines.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `Somanyloopholes/SignPoseVR` | Studied | Quest ASL alphabet/digit trainer with learn/quiz modes and hold-to-confirm feedback |
| `cpvrlab/vrTrainingFingerAlphabet` | Deepened | Quest finger alphabet trainer with saved hand forms and multi-feature scoring |
| `MARUI-PlugIn/MiVRy` | Studied | Cross-engine VR gesture recognition plugin with Unity/Unreal/native platform folders |

## Dedupe Notes

`vrTrainingFingerAlphabet` was studied in Wave 346. It is deepened here as a
comparison node beside a newer ASL trainer and a general gesture-recognition
plugin.

## Code-Level Findings

### `Somanyloopholes/SignPoseVR`

- Interesting idea: teach ASL with learn mode, quiz mode, reference images,
  real-time visual feedback, hold-to-confirm, and no-controller hand tracking.
- Code donor value: Unity project structure, README mode descriptions, 36-sign
  vocabulary, and feedback timing show a compact learning loop.
- Product reference value: useful for sign-learning utilities and hand-pose
  validation UX.
- What to inspect next: pose definitions, tolerance thresholds, hold timer,
  score persistence, and accessibility of feedback.
- Caveat: hand-shape recognition must be validated with diverse users and
  signing styles.

### `cpvrlab/vrTrainingFingerAlphabet`

- Interesting idea: compare current hand data with saved hand forms using
  finger angles, fingertip distances, wrist orientation, debug canvas, and
  virtual hand feedback.
- Code donor value: `Assets`, editor VR UI component scripts, German docs, and
  handform validation tables show a structured pose-scoring approach.
- Product reference value: strong donor/reference for explainable hand-pose
  scoring rather than black-box recognition only.
- What to inspect next: scoring weights, saved form schema, debug visualizers,
  and multilingual lesson data.
- Caveat: already studied; use as method evidence, not duplicate discovery.

### `MARUI-PlugIn/MiVRy`

- Interesting idea: gesture recognition can be packaged for multiple engines
  and platforms: Unity, Unreal, Android, Windows, Linux, macOS, UWP.
- Code donor value: `unity`, `unreal`, `android`, `windows`, `linux`, `macos`,
  and README show cross-platform plugin packaging.
- Product reference value: useful for separating gesture capture/training
  engine from VR app UX.
- What to inspect next: gesture model format, training workflow, confidence
  outputs, and licensing/runtime constraints.
- Caveat: plugin binary/API reuse needs license and maturity review.

## Reusable Pattern Extraction

- Pattern candidate: hand-pose learning and gesture-recognition loop.
- Problem solved: hand-driven tools need pose definitions, tolerance/confidence,
  hold confirmation, feedback, lesson/quiz state, and explainable scoring.
- Reusable core: pose asset, saved hand form, feature extractor, angle/distance
  scoring, wrist orientation, hold timer, confidence label, reference image,
  quiz state, feedback border/glow, gesture engine adapter, and user-variation
  caveat.
- Source evidence: SignPoseVR README/project, vrTrainingFingerAlphabet
  validation docs/assets, and MiVRy multi-engine plugin folders.
- Abstraction boundary: gesture engine and pose lesson content should stay
  separate from app-specific scoring and language pedagogy.
- What not to copy: fixed thresholds without calibration, black-box labels
  without confidence, or sign-language claims without community validation.
- Method catalog action: add Method 839.

## Family Placement

Creates a hand-pose/sign-language learning family, linked to prior ASL and hand
input waves.

## Follow-Up Gaps

- Define a hand-pose asset schema with features, tolerance, confidence, and
  lesson metadata.
- Compare explainable scoring versus trained recognizer confidence.
- Add calibration and cultural/community validation caveats to sign tools.
