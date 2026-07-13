# Wave 356: Guided Breathing Meditation Wellness and Stress Protocol VR

## Scope

This wave studies VR projects that structure relaxation, breath pacing,
mindfulness, or stress induction as a session loop. The reusable lesson is not
clinical efficacy; it is how to separate phase timing, cue rendering, environment
feedback, session state, and caveat labels.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `Mohit-Bagri/windmill-vr` | Studied | Four-phase inhale/hold/exhale/relax coroutine with countdown text, rounds, text fade, and windmill speed as exhale feedback |
| `InderSinghMehrok/breatheEase--CS-458-Project` | Studied | Multi-exercise wellness shell with box breathing, 4-7-8/10-second variants, meditation cards, session data, scene fade, orb pulse, yoga/qigong modules, and scene switching |
| `Roseburgendy/VR_Breathing_Intervention` | Studied | Breath rhythm controller with inhale/exhale durations, beam segments, movement patterns, hand tracking, haptics, phase managers, crystal/fog/season responders, and narrative progression |
| `IrtazaDevs/VR-Meditation` | Source-light marker | Mystical forest meditation reference with dynamic perspectives, spline movement, optimized environment, guided breathing cues, and settings framing |
| `luffy-yu/FloatMind` | Studied | AI-powered AR/VR meditation product reference with hand gestures, STT/TTS/LLM mood analysis, emotion bubbles, portal transition, scene blending, and controller-free flow |
| `kalpthakkar/MindFit-Realm` | Source-light marker | Mindfulness/wellness direction marker for future comparison of guided activities and emotional-state UX |
| `MIEC/vr-tsst` | Studied | VR Trier Social Stress Test protocol with participant IDs, NBack/Stroop tasks, NPC gaze/head behavior, timers, panels, and research-session management |

## Reusable Pattern Extraction

- Pattern candidate: `guided wellness session and stress-protocol loop`.
- Problem solved: wellness and stress VR projects need repeatable session flow
  without mixing timers, cues, environment effects, data capture, and claims.
- Reusable core: session catalog, phase scheduler, cue renderer, breathing
  visualizer, optional hand/movement validator, scene transition, session data,
  comfort gate, protocol task module, participant/session ID, reset, and caveat
  labels.
- Source evidence: windmill-vr uses `BreathControl`, `Windmill`, and
  `TextFader`; breatheEase exposes exercise cards, `SessionData`, scene fading,
  box-breathing scripts, and orb pulse; VR_Breathing_Intervention includes
  `BreathRhythmController`, `BreathPacer`, `MovementType`, `PhaseManager`, and
  effect modules; vr-tsst includes participant/task/timer/NPC scripts.
- Abstraction boundary: breath or protocol timing should publish phase events;
  visuals, audio, haptics, dialogue, and logging should subscribe rather than
  own the session.
- What not to copy: medical or therapeutic claims without validation,
  stress-induction defaults without ethics framing, AI mood analysis without
  privacy labels, or hardcoded session timings as the only data model.
- Method catalog action: create a new wellness-session method.

## Project Notes

### `Mohit-Bagri/windmill-vr`

- Interesting idea: exhalation powers a windmill, making breath rhythm visible
  through simple motion rather than dense UI.
- Code donor value: high for a compact coroutine-driven breath phase loop,
  round counter, countdown text, and visual feedback object.
- Product reference value: strong for one-value meditation microtools.
- What to inspect next: data-driven phase presets and comfort/onboarding copy.
- Caveats: simple demo scope; reuse conceptually rather than as a full wellness
  platform.

### `InderSinghMehrok/breatheEase--CS-458-Project`

- Interesting idea: multiple wellness activities live behind a card/session
  shell instead of separate apps.
- Code donor value: high for exercise cards, `SessionData`, scene fading,
  box-breathing variants, orb pulse, and qigong/yoga scene controllers.
- Product reference value: strong for a reusable wellness launcher.
- What to inspect next: session persistence, activity taxonomy, and settings
  schema.
- Caveats: student-project breadth; needs cleanup before code reuse.

### `Roseburgendy/VR_Breathing_Intervention`

- Interesting idea: breath phases drive world transformation: beams, crystals,
  fog clearing, season effects, hand paths, haptics, and narrative phases.
- Code donor value: high for evented breath rhythm, movement type enum,
  path calculator, visual responders, phase controllers, and hand/haptic hooks.
- Product reference value: strong for breath-as-world-control UX.
- What to inspect next: phase data authoring, failure feedback, and accessibility
  alternatives for hand movement.
- Caveats: contains third-party assets; keep extracted patterns separate from
  asset/vendor content.

### `luffy-yu/FloatMind`

- Interesting idea: AI/mood input creates interactable emotion bubbles before
  transitioning into guided meditation.
- Code donor value: moderate to high for product architecture: hand gestures,
  STT/TTS/LLM adapter, scene/portal transition, and 3D CTA framing.
- Product reference value: very strong for controller-free wellness UX.
- What to inspect next: privacy boundaries, prompt/response cancellation, and
  fallback when AI services fail.
- Caveats: AI mental-wellness claims need careful non-clinical framing.

### `MIEC/vr-tsst`

- Interesting idea: a VR stress protocol is a task/session engine with
  participant IDs, timed cognitive tasks, NPC social pressure, and panel flow.
- Code donor value: high for research-protocol orchestration, NBack/Stroop
  modules, timers, NPC gaze/head logic, and participant/session storage.
- Product reference value: useful for research harnesses and controlled
  task-loop design, not casual wellness.
- What to inspect next: data export, consent/ethics handling, and protocol
  parameterization.
- Caveats: GPL and stress-induction ethics; do not copy as product UX without
  review.

## Product Direction

This wave supports a `wellness session shell` branch: a small reusable system
where phase timing, cue channels, environment responders, and caveat labels are
explicit modules.

