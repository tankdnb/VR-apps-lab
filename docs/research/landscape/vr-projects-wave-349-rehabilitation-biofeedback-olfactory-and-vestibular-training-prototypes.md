# Wave 349: Rehabilitation Biofeedback Olfactory and Vestibular Training Prototypes

## Scope

This wave studies VR/MR projects where the user performs therapeutic,
biofeedback, or clinically motivated tasks. The reusable pattern is the
patient-task loop: calibrate body/hardware state, present a safe task, adapt
difficulty, collect signals, generate progress artifacts, and keep clinical
claims bounded.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `praggam/REVIRE` | Partially studied | Quest rehab prototype with recording folders and LSL script evidence; useful as a follow-up for session telemetry |
| `vladyslav-tsalko/REMIRE` | Partially studied | Quest rehabilitation app marker with APK/docs/source layout and moderate donor value pending script deep-dive |
| `omarrayyann/A-Fine-Day` | Studied | Stroke rehab minigame with Oculus Rift, Ultraleap hand tracking, Whack-A-Mole/Baskets exercises, velocity/acceleration graphs, calibration, menu delay, and therapist progress framing |
| `aneall/NeuroScent` | Studied | Neuro/biofeedback VR concept combining OpenBCI Galea signals, Varjo Aero, olfactory Project Nebula output, and multimodal mental-wellbeing framing |
| `soheilbr82/Mind-Controlled-Virtual-Car` | Studied | Unity virtual car controlled by EEG/Matlab signals over asynchronous UDP/TCP-style commands with SSVEP/SMR gating and multi-camera feedback |
| `JDGuldager/AR-and-VR-Application-for-Vestibular-Dysfunction-in-Elderly` | Studied | Quest 3 vestibular rehab prototype with controllers mounted to feet, frog/lily-pad stepping guidance, VR versus passthrough AR modes, SSQ/interview evaluation, and safety findings |

## Reusable Pattern Extraction

- Pattern candidate: `rehabilitation biofeedback task loop`.
- Problem solved: therapy-oriented VR needs more than a game scene; it needs
  body calibration, safe task presentation, adaptive difficulty, signal capture,
  progress artifacts, therapist review, and careful claims.
- Reusable core: patient/profile setup, hardware capability check, calibration
  warm-up, task definition, difficulty parameters, body/hand/foot/biosignal
  ingress, gating logic, motivational feedback, progress graph, session log,
  therapist-facing summary, safety mode, and clinical caveat label.
- Source evidence: A Fine Day logs hand movement and generates velocity/
  acceleration graphs; VRStepulake uses foot-mounted controllers and compares
  VR versus AR safety; NeuroScent combines biosignals with scent output;
  Mind-Controlled Virtual Car gates movement through EEG decoding states.
- Abstraction boundary: therapeutic task state should not directly own device
  APIs, clinical claims, or long-term patient records.
- What not to copy: unsupported efficacy claims, fixed difficulty ramps,
  unsafe foot/controller attachment assumptions, raw biosignal capture without
  consent, hidden proprietary SDK dependencies, or menus that accept accidental
  hand input immediately after opening.
- Method catalog action: create a new rehab/biofeedback task-loop method.

## Project Notes

### `praggam/REVIRE`

- Interesting idea: rehab projects benefit from synchronized recording and LSL
  hooks alongside the headset application.
- Code donor value: modest-to-moderate pending deeper script inspection.
- Product reference value: useful as a Quest rehab app direction marker.
- What to inspect next: LSL integration, recording schema, patient/session
  state, and whether the app separates tasks from telemetry.
- Caveats: not enough visible evidence in this pass for a strong donor rating.

### `vladyslav-tsalko/REMIRE`

- Interesting idea: lightweight Quest rehabilitation app packaging can serve as
  a deployment reference for therapy prototypes.
- Code donor value: modest until a deeper Unity script pass is performed.
- Product reference value: useful as a comparison node for REVIRE-style rehab.
- What to inspect next: exercise flow, config, data logging, and build/package
  boundaries.
- Caveats: keep as partially studied.

### `omarrayyann/A-Fine-Day`

- Interesting idea: rehab minigames target range of motion, motor skills,
  speed, grasping, and hand-eye coordination while producing progress graphs.
- Code donor value: high for task loop, Ultraleap collision caveats,
  calibration script idea, DataManager/GraphingMenu/Levels concepts, and menu
  delay UX.
- Product reference value: strong for patient motivation plus therapist review.
- What to inspect next: graph data schema, adaptive level spawning, and
  therapist summary UI.
- Caveats: Oculus Rift/Ultraleap-era stack and student-project polish.

### `aneall/NeuroScent`

- Interesting idea: mental-wellbeing VR can combine biosignal sensing, scent
  output, and immersive visuals as a biofeedback loop.
- Code donor value: moderate for hardware integration framing across OpenBCI
  Galea, Varjo, and Project Nebula; source evidence is stronger in setup
  documentation than reusable scripts.
- Product reference value: strong for multimodal therapy product framing.
- What to inspect next: Arduino/STL updates, biosignal-to-scent mapping, and
  safety/consent UX.
- Caveats: depends on proprietary/owner-only OpenBCI Galea software and Varjo
  plugin setup.

### `soheilbr82/Mind-Controlled-Virtual-Car`

- Interesting idea: BCI commands can gate virtual vehicle motion through a
  hybrid SSVEP direction detector and SMR move/stop state.
- Code donor value: moderate for Unity UDP command ingress and feedback-loop
  framing.
- Product reference value: useful for BCI training and educational biofeedback.
- What to inspect next: UDP parser, command schema, MATLAB/Simulink interface,
  and latency/error handling.
- Caveats: not fully VR-specific in visible code and relies on external EEG/
  MATLAB decoding.

### `JDGuldager/AR-and-VR-Application-for-Vestibular-Dysfunction-in-Elderly`

- Interesting idea: the same stepping task is implemented as immersive VR and
  passthrough AR, then compared for motivation, safety, and disorientation.
- Code donor value: high for foot-controller stepping, lily-pad/frog guidance,
  step-distance/timing difficulty, and safety-oriented modality comparison.
- Product reference value: strong for older-adult vestibular rehab design.
- What to inspect next: foot pose detection thresholds, AR floor placement,
  session logs, and therapist monitoring.
- Caveats: research prototype; clinical effectiveness requires longitudinal
  validation.

## Product Direction

This wave supports a `rehab and biofeedback utility` branch around calibration,
task prescription, adaptive difficulty, multisensory feedback, patient-safe
input, progress logging, and therapist-review surfaces.

