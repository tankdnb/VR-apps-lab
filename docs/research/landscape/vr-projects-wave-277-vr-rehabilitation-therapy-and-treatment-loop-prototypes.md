# Wave 277 - VR Rehabilitation, Therapy, and Treatment-Loop Prototypes

This wave studies VR rehabilitation, therapy, and treatment-loop prototypes as
source material for calibration flows, hand/biometric input loops,
personalized difficulty, feedback surfaces, and safety caveats.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- VR or WebVR rehab/training prototypes;
- hand, pinch, grasp, EEG, or exercise input loops;
- calibration and personalized difficulty;
- therapist/operator feedback and logging;
- explicit caveats around medical claims, privacy, and validation.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `mahmoud1yaser/VR-Therapist-Virtual-Mental-Health-Experience` | Voice therapy loop prototype | Studied with medical/privacy caveats | Unity mic capture to local Flask STT/LLM/TTS loop |
| `jessieyang0320/VHab` | Web hand-rehab microgames | Partially studied | Finger angle, pinch, grab, and whack-a-mole exercises |
| `reboot-corp/Reboot-Hackathon` | Neurofeedback rehab prototype | Studied with prototype caveats | LSL/BrainFlow EEG ingress and feedback ring |
| `EyalMaoz/Pinch_Rehabilitation_VR_Personalized_Treatment` | Personalized pinch therapy pipeline | Studied | Calibration, pinch classification, treatment plans, adaptive object placement |
| `TheBananaGuy/rehab-in-vr` | Leap/Oculus grab-hold exercise | Studied with source-light caveats | Sustained grab target loop |
| `pcallej/ADHD-Unity` | Attention-training VR games | Studied with legacy caveats | GoogleVR divided-attention path/target exercises |
| `WestonBDev/Modules-for-Burn-Injury-Rehabilitation` | Modular rehab components | Studied | Timed trigger boxes, haptic parameters, CSV movement logging |
| `songer1993/vr-cat-bath-study` | Gamified hand-strength study | Studied | Cat-care tasks, grasp/pinch meters, timers, optional capture |
| `harr-data/Simple-VR-Rehab` | Web rehab metrics reference | Source-light reference | Tracking/reflex/memory tasks and simple performance metrics |

## Code-Level Findings

### `mahmoud1yaser/VR-Therapist-Virtual-Mental-Health-Experience`

- Interesting idea:
  a Unity scene records patient speech, sends it to a local service, and plays
  a generated therapist response back through an avatar.
- Code donor value:
  useful architecture boundary between Unity microphone capture, HTTP upload,
  polling status, local Flask processing, speech recognition, LLM response, and
  AWS Polly synthesis.
- Product reference value:
  good voice-loop prototype reference, but not a clinical product reference.
- What to inspect next:
  consent UX, local-only processing, auth, credentials, logs, crisis behavior,
  and safe framing for non-clinical assistant tools.
- Reusable pattern:
  Unity voice loop plus companion AI service.
- Caveats:
  privacy-sensitive audio, credential/config risk, no auth, global server
  state, debug server settings, and unsafe medical/therapy claims if copied
  directly.

### `jessieyang0320/VHab`

- Interesting idea:
  a browser rehab prototype decomposes hand therapy into small tasks around
  finger angle, pinch strength, grab strength, selectors, buttons, and
  whack-a-mole style targets.
- Code donor value:
  medium as a microgame taxonomy and controller split reference.
- Product reference value:
  useful for thinking about rehab as short measurable loops rather than one
  large experience.
- What to inspect next:
  input device assumptions, scoring, persistence, therapist views, and whether
  the legacy dependencies can be reduced.
- Reusable pattern:
  hand-rehab microtask pack.
- Caveats:
  legacy web stack and partial source-depth in this pass.

### `reboot-corp/Reboot-Hackathon`

- Interesting idea:
  a pain/neurofeedback prototype streams EEG-like LSL data into Unity and maps
  concentration or band-power values into a feedback ring.
- Code donor value:
  useful source for `StreamInlet` discovery, sample pulls, channel mapping,
  Unity UI fill feedback, and basic BrainFlow/math integration.
- Product reference value:
  good hackathon reference for "sensor ingress becomes visible feedback."
- What to inspect next:
  classifier provenance, data buffering, calibration, artifact rejection,
  privacy, and whether the feedback signal is meaningful.
- Reusable pattern:
  biometric stream ingress plus simple VR feedback surface.
- Caveats:
  prototype-level code, unfinished serialization, local test files, and no
  validated therapeutic claims.

### `EyalMaoz/Pinch_Rehabilitation_VR_Personalized_Treatment`

- Interesting idea:
  personalized pinch rehabilitation is modeled as calibration first, then
  patient-specific treatment difficulty and object generation.
- Code donor value:
  strongest donor in the wave: pinch-type calibration, OVR hand-state access,
  tip/pad/finger classification, patient motion-range persistence, treatment
  plan data objects, difficulty parameters, challenge generation, and
  pinchable object placement around anchors.
- Product reference value:
  excellent reference for a rehab loop that separates assessment, plan,
  generated task, feedback, and progression.
- What to inspect next:
  patient file format, difficulty adjustment evidence, therapist override UX,
  privacy, and non-OVR abstraction.
- Reusable pattern:
  calibration-to-personalized-treatment pipeline.
- Caveats:
  Oculus/OVR-specific hand tracking, local patient files, medical data risk,
  hardcoded/debug paths, and validation requirements.

### `TheBananaGuy/rehab-in-vr`

- Interesting idea:
  a simple Leap/Oculus exercise asks the user to grab a frog target and hold it
  until task completion.
- Code donor value:
  low to medium as a sustained-hold target-loop reference.
- Product reference value:
  useful educational example for simple motor engagement.
- What to inspect next:
  exact scoring, hold timers, hand confidence, and modern XR input replacement.
- Reusable pattern:
  sustained grab-and-hold rehab target.
- Caveats:
  old LeapMotion/Oculus dependency payload and limited original source depth.

### `pcallej/ADHD-Unity`

- Interesting idea:
  GoogleVR-era attention games use train/path following and counters as
  divided-attention exercises for children.
- Code donor value:
  medium as a legacy target/path/training-game reference.
- Product reference value:
  useful for studying cognitive task framing, not for validated diagnosis or
  treatment.
- What to inspect next:
  scoring, difficulty, session logs, and migration from GoogleVR assumptions.
- Reusable pattern:
  attention-training path target loop.
- Caveats:
  legacy GoogleVR, vendor payload, limited documentation, and no medical-grade
  evidence.

### `WestonBDev/Modules-for-Burn-Injury-Rehabilitation`

- Interesting idea:
  burn-injury rehab is decomposed into reusable modules: timed triggers,
  adaptive input, haptic feedback, movement logging, therapist feedback, and
  accessibility.
- Code donor value:
  good microcomponent donor for prolonged interaction trigger boxes, haptic
  intensity/frequency settings through XR input devices, and CSV movement
  logging of position, speed, and acceleration.
- Product reference value:
  strong reference for building rehab tools as composable modules instead of
  one monolithic experience.
- What to inspect next:
  therapist UI, data schemas, comfort/accessibility settings, and file-path
  safety.
- Reusable pattern:
  modular rehab component kit.
- Caveats:
  simple scripts, integration gaps, and logging/storage choices that need
  product hardening.

### `songer1993/vr-cat-bath-study`

- Interesting idea:
  hand-strength rehab is wrapped in playful cat-care activities, with grasp and
  pinch indicators, timers, and optional capture tools.
- Code donor value:
  useful for gamified task composition: body-part targets, feeding points,
  snack cubes, hair dryer behavior, strength bars, value pointers, and capture
  hooks.
- Product reference value:
  good reference for making repetitive therapy feel like a small caring task.
- What to inspect next:
  study protocol, scoring, data export, and how strength thresholds are
  calibrated.
- Reusable pattern:
  gamified rehab task wrapper around strength metrics.
- Caveats:
  study-specific assets and likely non-generalized protocol.

### `harr-data/Simple-VR-Rehab`

- Interesting idea:
  a small web suite frames rehab as target tracking, reflex response, and
  memory sequence tests with simple metrics.
- Code donor value:
  low as a VR implementation donor, useful as a metric taxonomy reference.
- Product reference value:
  useful for quick rehab-session metric sketching.
- What to inspect next:
  whether a true immersive implementation exists and how metrics are persisted.
- Reusable pattern:
  lightweight task-and-metric suite.
- Caveats:
  source-light, browser-only, and not validated as clinical evidence.

## Reusable Pattern Extraction

- Pattern candidate:
  rehabilitation treatment-loop boundary.
- Problem solved:
  turn sensor input and therapy goals into measurable, repeatable, and
  personalized VR tasks without hiding medical/privacy risk.
- Reusable core:
  assessment/calibration, input confidence, personalized range, task generator,
  feedback surface, session log, therapist/operator override, consent, and
  validation caveats.
- Source evidence:
  `EyalMaoz/Pinch_Rehabilitation_VR_Personalized_Treatment`,
  `WestonBDev/Modules-for-Burn-Injury-Rehabilitation`,
  `reboot-corp/Reboot-Hackathon`,
  `songer1993/vr-cat-bath-study`, and
  `mahmoud1yaser/VR-Therapist-Virtual-Mental-Health-Experience`.
- Abstraction boundary:
  keep clinical claims, patient data, sensor processing, game task logic,
  feedback, and logs as separate layers.
- What not to copy:
  unguarded AI therapist claims, unauthenticated local medical services,
  hardcoded patient paths, raw biometric logging without consent, or prototype
  classifiers as validated treatment.
- Method catalog action:
  add a rehabilitation treatment-loop method.

## Follow-Up Gaps

- Build a rehab matrix across calibration, hand/EEG input, personalized
  difficulty, haptics, feedback, logging, and safety caveats.
- Deepen the pinch rehabilitation repo as the strongest architecture donor.
- Deepen burn-rehab modules as a microcomponent kit.
- Keep medical and privacy claims explicitly separated from reusable
  engineering patterns.
