# Wave 357: VR Music Instruments Hand Tracked Piano Drums and Biosignal Audiovisual Tools

## Scope

This wave studies projects where embodied input becomes sound: hand tracking,
Leap Motion, collision volumes, drums, piano keys, lesson files, or biosignals.
The reusable lesson is an input-to-sound boundary with clear timing, confidence,
and feedback instead of one-off collider scripts.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `SeungWon0927/VR_Piano` | Studied | Quest hand-tracked piano where finger/key collisions trigger audio with semitone pitch offsets; README documents bright-room and beta hand-tracking caveats |
| `JustinLin905/Pear-Piano` | Studied | Oculus Interaction-heavy piano direction for comparing modern hand interaction substrate against simple collision keys |
| `waltzaround/Matter-VR` | Partially studied | Embodied/physics music direction marker for further instrument-surface inspection |
| `magicinthesky/VR-Drumming` | Partially studied | Drum-hit interaction direction marker for timing, collision, and percussive feedback comparison |
| `kahogeoff/vr-war-drum` | Partially studied | War-drum/percussion Unity marker with many vendor/assets; useful mainly for follow-up hit-surface triage |
| `HackTheBrain/B-vr` | Studied | EEG/OpenViBE-driven visual music architecture where alpha/beta/theta and trained parameters shape audio/visual state |
| `krebsm249/Vr-LeapMotion-playing-a-Piano` | Studied | Leap Motion piano lesson/reference with CSV reader, teacher scripts, menu loaders, and Leap Interaction Engine physics buttons |

## Reusable Pattern Extraction

- Pattern candidate: `embodied VR instrument input-to-sound boundary`.
- Problem solved: instrument projects often fuse hand input, collision, audio
  playback, visual feedback, and lesson logic into scene objects.
- Reusable core: input provider, playable surface map, hit/key detector,
  velocity/confidence gate, note/hit event schema, audio adapter, visual
  feedback, lesson/teacher track, calibration note, and latency caveat.
- Source evidence: VR_Piano uses custom `PianoKeyScript` with `AudioSource`,
  semitone pitch offsets, and collision-based sound; Leap piano includes
  `CSVReader`, `TeacherScript`, menu scripts, and Leap Interaction Engine
  physics UI; B-vr documents EEG/OpenViBE to Unity audiovisual parameter flow.
- Abstraction boundary: hands, controllers, Leap, or EEG should produce neutral
  events; instrument surfaces and sound engines should consume those events.
- What not to copy: brittle per-key scripts without central mapping, hand
  tracking assumptions without lighting/confidence feedback, EEG claims without
  calibration, or third-party SDK trees as donor code.
- Method catalog action: create a new embodied instrument method.

## Project Notes

### `SeungWon0927/VR_Piano`

- Interesting idea: a Quest hand-tracking piano can use physical finger
  collisions as a simple musical input layer.
- Code donor value: moderate for `PianoKeyScript`, audio pitch offsets, and
  collision-to-note behavior.
- Product reference value: strong for low-friction hand-tracked instruments.
- What to inspect next: debouncing, multi-finger tracking confidence, note map
  data, and latency.
- Caveats: README explicitly notes beta hand-tracking instability and lighting
  sensitivity.

### `krebsm249/Vr-LeapMotion-playing-a-Piano`

- Interesting idea: piano interaction is paired with a teacher/lesson layer and
  CSV data rather than only free play.
- Code donor value: moderate for CSV lesson input, teacher scripts, menu flow,
  and Leap interaction comparison.
- Product reference value: useful for tutorial-driven instrument tools.
- What to inspect next: CSV schema, lesson feedback, and hand/key mapping.
- Caveats: large Leap SDK tree; extract only the app-level lesson boundary.

### `HackTheBrain/B-vr`

- Interesting idea: biosignals become a visual music instrument through an
  OpenViBE-to-Unity architecture.
- Code donor value: low to moderate from this checkout because the Unity side
  is external/submodule-style, but architecture value is high.
- Product reference value: strong for biosignal audiovisual utility concepts.
- What to inspect next: transport schema between OpenViBE and Unity, signal
  smoothing, and safety/interpretation labels.
- Caveats: EEG input needs setup, calibration, and privacy/claims caveats.

### `JustinLin905/Pear-Piano`

- Interesting idea: piano can be rebuilt on modern Oculus Interaction SDK
  primitives instead of older direct collider-only hand tracking.
- Code donor value: moderate pending deeper custom script isolation.
- Product reference value: useful comparison point for Interaction SDK input.
- What to inspect next: key press affordance, hand pose filtering, and audio
  event ownership.
- Caveats: vendor-heavy tree; do not treat SDK code as project donor material.

## Product Direction

This wave supports an `embodied audio utility` branch: VR tools can expose a
neutral note/hit event stream that later drives audio, haptics, visuals, OSC,
MIDI, lessons, or accessibility feedback.

