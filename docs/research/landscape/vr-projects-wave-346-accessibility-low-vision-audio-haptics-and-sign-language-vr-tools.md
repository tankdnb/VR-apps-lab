# Wave 346: Accessibility Low Vision Audio Haptics and Sign Language VR Tools

## Scope

This wave studies VR accessibility utilities and sign-language training or
recognition projects. The reusable lesson is to separate sensing, adaptation,
feedback, user consent, training data, validation, and output surfaces.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `microsoft/SeeingVRtoolkit` | Studied | Accessibility toolkit with magnification shaders, post-processing tools, SteamVR bindings, and low-vision support framing |
| `SuHCI/MagniVR` | Studied | Magnifier-focused VR prototype that builds on SeeingVR-style tools, render textures, hand-held magnifier prefabs, and challenge scenes |
| `xability/punch-pulse` | Studied | Accessible VR boxing game with audio-direction cues, boundary collision sounds, menu toggles, haptics/Bhaptics assets, and audio mixers |
| `hojats7731/VRSignify` | Studied as source-light ASL direction marker | Quest 3 ASL-to-text product framing with hand tracking and custom ML claims, but limited visible donor scripts |
| `dillondrum70/ASL-Passthrough` | Studied | Quest hand tracking and passthrough ASL/spell gesture recognizer with HandPose/HandGesture assets, pose stack, hold times, null-time tolerance, two-hand gestures, and editor pose capture |
| `cpvrlab/vrTrainingFingerAlphabet` | Studied | Oculus Quest finger alphabet trainer with saved hand forms, finger-angle/tip-distance/wrist-orientation scoring, debug canvas, virtual hand feedback, and German documentation |

## Reusable Pattern Extraction

- Pattern candidate: `VR accessibility affordance and gesture-training decomposition`.
- Problem solved: accessibility features should not be embedded as one-off
  gameplay hacks; they need reusable sensing, adaptation, feedback, validation,
  and privacy boundaries.
- Reusable core: accessibility profile, magnifier/caption/audio/haptic adapter,
  render-texture or post-process hook, target/object metadata, hand-pose
  schema, pose capture tool, gesture sequence matcher, validation thresholds,
  feedback surface, consent/privacy settings, and capability fallback.
- Source evidence: SeeingVR's magnification shaders/toolkit framing, MagniVR's
  magnifier manager and prefabs, Punch Pulse's directional audio and haptics,
  ASL-Passthrough's pose stack and gesture assets, VRSignify's ASL-to-text
  product framing, and vrTrainingFingerAlphabet's weighted hand validation.
- Abstraction boundary: accessibility transformation and gesture recognition
  should be reusable services that can feed overlays, text, audio, haptics, or
  gameplay events.
- What not to copy: unsupported efficacy claims, hardcoded pose thresholds,
  vendor-only hand tracking without fallback, private microphone/gesture data
  without consent, or accessibility UI buried inside one game.
- Method catalog action: create a new accessibility and gesture-training
  method.

## Project Notes

### `microsoft/SeeingVRtoolkit`

- Interesting idea: accessibility affordances as a toolkit rather than a single
  app.
- Code donor value: high for magnification shaders, post-process hooks, SteamVR
  binding examples, and low-vision UX taxonomy.
- Product reference value: strong baseline for accessibility options panels.
- What to inspect next: all SeeingVR tool scripts and shader parameters.
- Caveats: older SteamVR stack and research-toolkit maturity.

### `SuHCI/MagniVR`

- Interesting idea: magnification as a physical hand-held object and manager.
- Code donor value: good for magnifier prefab wiring, render texture
  composition, controller scripts, and SeeingVR-derived material experiments.
- Product reference value: useful for low-vision interaction metaphors.
- What to inspect next: `Magnifier_controller_left.cs`,
  `AdjustMagnificationLevel.cs`, and accessibility tag usage.
- Caveats: prototype/asset-heavy project.

### `xability/punch-pulse`

- Interesting idea: audio and haptic cues make a spatial boxing game more
  navigable without relying purely on visuals.
- Code donor value: useful for direction-voice assets, boundary collision audio
  hooks, menu toggles, haptics integration, and mixer separation.
- Product reference value: strong for accessibility-first game feedback loops.
- What to inspect next: enemy cue timing, haptic event mapping, and difficulty
  settings.
- Caveats: game-specific; reuse feedback architecture, not boxing logic.

### `hojats7731/VRSignify`

- Interesting idea: ASL-to-text in a Quest 3 environment.
- Code donor value: limited in this pass because visible source is thin and a
  `TempAssembly.dll` is present.
- Product reference value: useful direction marker for communication support.
- What to inspect next: whether source for the custom model/classifier exists
  in releases or branches.
- Caveats: do not rely on undocumented ML claims without source/evaluation.

### `dillondrum70/ASL-Passthrough`

- Interesting idea: hand poses become reusable assets, gestures are sequences
  with hold-time and null-time tolerance.
- Code donor value: high for `HandPoseTracker`, `HandGesture`, two-hand
  gestures, event outputs, editor pose capture, and passthrough framing.
- Product reference value: strong for gesture-to-text, gesture learning, and
  spell/command systems.
- What to inspect next: `HandPose.CheckHandMatch`, pose prefab formats, and
  unsupported finger-pose handling.
- Caveats: Quest hand tracking cannot represent some occluded/crossed finger
  shapes reliably.

### `cpvrlab/vrTrainingFingerAlphabet`

- Interesting idea: training validates saved hand forms against live hand data
  using weighted orientation, finger angles, and fingertip distances.
- Code donor value: high for `HandFormValidator`, `HandSaver`, `HandLoader`,
  debug canvas feedback, and virtual hand visualization.
- Product reference value: strong for structured in-VR learning/assessment.
- What to inspect next: hand data serialization, insight/debug scene, and
  scoring UI.
- Caveats: older Oculus Integration and German-language documentation.

## Product Direction

This wave strengthens an accessibility branch for reusable low-vision helpers,
audio/haptic alternatives, and hand-sign training or recognition surfaces with
explicit limits and consent boundaries.

