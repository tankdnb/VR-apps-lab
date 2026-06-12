# Wave 280 - VR Training, Assessment, Scenario Grading, and Skill-Practice Prototypes

This wave studies VR and XR training prototypes as references for scenario
state, task gates, scoring, feedback, per-user notes, metric export, and
source-light skill-practice product framing.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- medical, emergency, nursing, dental, motor-skill, welding, and study-training
  prototypes;
- explicit scoring, grading, feedback, task-gating, or session-metric code;
- source-light training concepts only when they clarify product framing or
  caveats;
- web, Unity, Unreal, and WebXR projects where the reusable value is the
  training loop rather than engine completeness.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `cepdnaclk/e16-4yp-Virtual-Patient-Simulator-for-Skill-Training-in-Dentistry` | Dental decision-training web simulator | Studied | Multi-domain clinical score reducer, case feedback, Firebase-backed evaluation |
| `sharnajh/VR_CPR_Training` | CPR movement prototype | Source-light | Minimal movement/crouch shell, weak training logic |
| `Carolina-Riddick/Parkinson-App-Virtual-Reality` | Rehab-adjacent motor task prototype | Studied with medical caveats | Socket/task-count gates and next-level unlocks |
| `SLVNE/VRNurseTrainingProgram` | Nursing procedure auto-grader | Studied with caveats | BP/lung answer grading and immediate verdict UI |
| `DarkSmiling/OpenVRTraining` | Unreal/SteamVR training scene | Asset-heavy reference | Training-scene packaging, VRExpansion/SteamVR bindings |
| `pspacewoman/Emergency-Quest-VR-Game-MasterThesis` | First-aid scenario reference | README/thesis reference with license caveat | Checklist-guided emergency flow and feedback framing |
| `KosmidisMixalis/ViRtus-A-Virtual-Reality-Application-for-Training-and-Performance-Analysis` | Performance-analysis training study | Source-light methodology reference | VR task metrics exported to text and analyzed with Python |
| `E5H4/m.e.-simulator` | Medical emergency simulator | Studied | Score/timer/grade panel, difficulty branch, prerequisite interaction checks |
| `Hannah-Ashna/VRWalkin-UE-Plugin` | Locomotion-training plugin | Blueprint-heavy reference | Locomotion-mode comparison plugin packaging |
| `hasanhaswary/CSVRSystem` | Crime-scene training system | Studied | Firebase auth, case selection, per-user notes |
| `37743/VR-Welding-101` | Welding skill-practice prototype | Studied with caveats | Physical push-button toggles and welding education product framing |
| `MPL-projects/vr-aim-study` | VR throwing accuracy study | Studied | Simple throw scoring and reset loop |
| `glenbo111/webxr-medical-training-simulation` | WebXR medical micro-scene | Source-light | One-file A-Frame medical scenario skeleton |
| `byebyenin10dog/KHXR` | Unity WebXR training shell | Studied with artifact caveat | WebXR-to-Unity browser bridge and XR capability callbacks |
| `fxnode2000/webxr.github.io` | Empty WebXR intent node | Skipped/no-source | Empty inspected branch; retained only as dedupe evidence |

## Mandatory Extraction Table

| Project | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|
| `cepdnaclk/e16-4yp-Virtual-Patient-Simulator-for-Skill-Training-in-Dentistry` | Dental virtual-patient decisions are scored across history, diagnosis, exam, investigation, periodontal, caries, radiology, and tooling dimensions. | `ScoreReducer`, score actions, and feedback/evaluation flow show a reusable multi-domain grading state model. | Strong reference for case-based tutoring, collaborative dental scenarios, and post-session feedback. | Case schema, Firebase writes, collaboration model, data privacy, and medical-validation boundary. |
| `sharnajh/VR_CPR_Training` | CPR training shell with locomotion and crouch state. | Low; `UserMovement.cs` is a basic WASD/crouch controller. | Weak but useful as a source-light CPR intent node. | Whether actual CPR compression, timing, feedback, or assessment logic exists elsewhere. |
| `Carolina-Riddick/Parkinson-App-Virtual-Reality` | Training tasks progress when socketed elements reach the expected count. | `CheckElements.cs` and `LaunchObjects.cs` show task gates, unlock events, and force-launch interaction. | Reference for simple motor-skill practice loops and level unlocks. | Rehab framing, XR Interaction Toolkit setup, scoring, accessibility, and clinical claim caveats. |
| `SLVNE/VRNurseTrainingProgram` | Nursing learners answer instrument-reading questions and get immediate correctness feedback. | `BloodPressureGrader.cs` and `LungGrader.cs` are compact auto-grader donors. | Good micro-reference for medical procedure quizzes embedded in VR scenes. | Decouple hardcoded UI strings, add case schema, and validate clinical content. |
| `DarkSmiling/OpenVRTraining` | Unreal/SteamVR crane or industrial training scene packaged with VRExpansion and bindings. | Low readable-code donor; most custom logic is Blueprint/asset-heavy. | Useful Unreal training-scene product reference. | Blueprint behavior, controller-binding map, scene flow, and whether readable training logic exists. |
| `pspacewoman/Emergency-Quest-VR-Game-MasterThesis` | First-aid Quest scenario uses checklist guidance, hazards, NPC/audio, score, and feedback. | None from source in this pass. | Good UX/reference for guided emergency assessment and feedback screens. | Thesis details, available source, licensing, and safe non-derivative reuse. |
| `KosmidisMixalis/ViRtus-A-Virtual-Reality-Application-for-Training-and-Performance-Analysis` | VR panel-construction training exports performance metrics for statistical analysis. | Python stats scripts show study-analysis handoff, not app internals. | Strong methodology reference for task metric export and human-study reporting. | App source, metric schema, export cadence, and questionnaire linkage. |
| `E5H4/m.e.-simulator` | Medical emergency simulation scores actions, time, difficulty, AED pad placement, and grade panels. | `ScoreTracker.cs`, `Difficulty.cs`, and `AEDPadsChecker.cs` form a reusable scoring/timer/prerequisite loop. | Good training reference for emergency scenario grading. | Replace hardcoded names, separate scoring policy, and validate medical assumptions. |
| `Hannah-Ashna/VRWalkin-UE-Plugin` | UE plugin packages multiple locomotion paradigms for independent travel training. | Low static-code donor because logic is mostly Blueprint assets. | Good product reference for comparing locomotion modes in a training simulator. | Blueprint graphs, UE 4.27 compatibility, and locomotion comfort metrics. |
| `hasanhaswary/CSVRSystem` | Crime-scene VR training combines authentication, case selection, and private notes. | `AuthManager.cs`, `CasesManager.cs`, and `NoteManager.cs` show Firebase user/session note boundaries. | Good reference for case-library training with per-user notebooks. | Firestore schema, note privacy, case progress, and evidence collection mechanics. |
| `37743/VR-Welding-101` | Welding education scene frames AI feedback, welding procedure practice, and physical UI toggles. | `InstantiateToggleButton.cs` shows a configurable joint press-depth button that toggles child prefabs. | Useful welding skill-practice product reference, with AI claims treated cautiously. | Actual feedback/AI logic, welding telemetry, and Quest deployment constraints. |
| `MPL-projects/vr-aim-study` | Throwing accuracy study scores distance to a target and resets the ball. | `score.cs` and `ball_comme_back.cs` show a minimal metric-plus-reset loop. | Good micro-reference for controlled motor-skill experiments. | Data logging, trial randomization, participant IDs, and feedback conditions. |
| `glenbo111/webxr-medical-training-simulation` | Minimal A-Frame medical scene with an injured-patient interaction target. | Very low; one HTML scene with simple cursor interaction. | Source-light WebXR scenario skeleton. | Add actual tasks, scoring, state, and dependency correctness. |
| `byebyenin10dog/KHXR` | Unity WebXR shell bridges browser XR capabilities, sessions, controllers, and gamepad state back into Unity. | `webxr.js` is useful for capability detection, session lifecycle, controller packets, coordinate conversion, and performance HUD toggles. | Reference for web-hosted Unity XR training delivery. | Separate authored app logic from built artifact, security, telemetry, and WebXR polyfill limits. |
| `fxnode2000/webxr.github.io` | Discovered WebXR intent repository with no readable branch content. | None. | Dedupe/no-source marker only. | Check if another branch or upstream contains actual WebXR training code. |

## Reusable Pattern Extraction

- Pattern candidate:
  training scenario assessment loop.
- Problem solved:
  turn immersive scenario actions into evidence, score, feedback, and next-step
  guidance without tying the whole training product to one scene.
- Reusable core:
  scenario/case schema, task gate, input/action evidence, scoring dimensions,
  timer and difficulty, immediate verdict, end-of-session feedback, per-user
  notes, metric export, privacy/validation boundary, and source-light triage.
- Source evidence:
  the dentistry simulator, `VRNurseTrainingProgram`, `m.e.-simulator`,
  `CSVRSystem`, `vr-aim-study`, `Emergency-Quest`, `ViRtus`, `VRWalkin`,
  and `KHXR`.
- Abstraction boundary:
  keep scenario state, learner input, grading policy, feedback UI, persistence,
  and study export as separate layers.
- What not to copy:
  unvalidated clinical claims, hardcoded strings/object names, checked-in
  engine artifacts, Firebase/auth without privacy design, and README-only
  training claims as code donors.
- Method catalog action:
  add a training scenario assessment method.

## Follow-Up Gaps

- Build a training assessment matrix across case state, task gates, difficulty,
  scoring, feedback, notes/auth, and study metric export.
- Deepen `E5H4/m.e.-simulator` and the dentistry simulator as the strongest
  score/feedback donors.
- Deepen `CSVRSystem` for authenticated case-notebook training workflows.
- Keep `sharnajh/VR_CPR_Training`, `glenbo111/webxr-medical-training-simulation`,
  and `fxnode2000/webxr.github.io` as source-light or no-source nodes unless
  better source evidence appears.
