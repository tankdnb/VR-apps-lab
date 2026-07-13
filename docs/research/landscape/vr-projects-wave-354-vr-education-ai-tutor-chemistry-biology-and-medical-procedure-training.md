# Wave 354: VR Education AI Tutor Chemistry Biology and Medical Procedure Training

## Scope

This wave studies VR education projects where domain state, tutor feedback,
procedural steps, safety, reset, quizzes, and validation caveats matter more
than generic scene presentation.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `kenny2077/ChemAI` | Studied | Quest 3 chemistry lab with four free-order stations, voice-first AI assistant, Azure OpenAI STT/chat/TTS pipeline, live state hub, safety warnings, station failures, reset manager, and source-only credential hygiene |
| `2227500/Team-Chem-Training-VR-App` | Studied | Chemistry training sequence around onboarding, safety room, lab room, manual evaporator experiment, and quiz |
| `37743/Classroom-VR` | Studied | AI tutor classroom direction with RAG/curriculum framing and teacher/persona structure |
| `VR-Biomolecules/HandsOnDNA` | Studied | DNA outreach experience with lab-to-cell/atomic scale transition and a sequence of interactive DNA activities |
| `CRISPGroup/Mission-Control-MRI-VR` | Studied | Quest MRI familiarization app with story mission, bed/glide metaphor, movement feedback, caregiver controller role, and explicit non-validated medical caveat |

## Reusable Pattern Extraction

- Pattern candidate: `AI-assisted educational lab and procedure-training loop`.
- Problem solved: educational VR needs deterministic task state and safety
  rules even when AI/voice guidance is present.
- Reusable core: curriculum graph, station/task state hub, deterministic hint
  layer, optional AI/RAG adapter, STT/TTS adapters, safety/failure state,
  reset manager, quiz/checkpoint, teacher/caregiver role, telemetry/export,
  credential hygiene, and validation/privacy caveat labels.
- Source evidence: ChemAI documents `LabScene2ExperimentStateHub`,
  `LabScene2ChemAgentManager`, `LabScene2AzureOpenAIClient`, reset/failure
  managers, voice pipeline, station state, and blocked unsafe experiment;
  Team-Chem frames onboarding/safety/lab/quiz; HandsOnDNA uses sequenced
  biomolecular tasks and scale shifts; Mission Control MRI adds caregiver role
  and movement feedback.
- Abstraction boundary: AI should explain and guide from verified task state;
  it should not become the source of truth for simulation correctness or safety.
- What not to copy: live credentials, unsupported medical/clinical claims,
  hallucination-prone tutor logic without deterministic guards, or training
  tasks without reset and failure recovery.
- Method catalog action: create a new AI-assisted training-loop method.

## Project Notes

### `kenny2077/ChemAI`

- Interesting idea: a voice-first AI assistant reasons over live chemistry lab
  state and speaks guidance inside a free-order Quest lab.
- Code donor value: high for state hub, AI adapter, voice pipeline, failure
  manager, reset manager, and credential hygiene.
- Product reference value: very strong for AI-assisted training tools.
- What to inspect next: prompt construction, local fallback policy, station
  state serialization, and safety warning routing.
- Caveats: AI services and chemistry safety need strict guardrails.

### `2227500/Team-Chem-Training-VR-App`

- Interesting idea: chemical training is structured as onboarding, safety room,
  lab procedure, and quiz.
- Code donor value: moderate for procedural training flow.
- Product reference value: useful for safety-first industrial education.
- What to inspect next: task gate logic, scoring, and quiz persistence.
- Caveats: student project scope and likely limited polish.

### `37743/Classroom-VR`

- Interesting idea: a classroom shell can use AI tutors with curriculum/RAG
  framing rather than generic chatbot behavior.
- Code donor value: moderate pending deeper source proof.
- Product reference value: useful for tutor/persona direction.
- What to inspect next: RAG data boundary, teacher personas, and assessment
  flow.
- Caveats: verify actual code depth before promoting as donor.

### `VR-Biomolecules/HandsOnDNA`

- Interesting idea: learning starts in a lab and then shrinks the user into
  cell/atomic scale for five DNA activities.
- Code donor value: moderate for activity sequencing and scale-transition UX.
- Product reference value: strong for outreach/science education.
- What to inspect next: activity state machine, completion criteria, and
  accessibility/comfort at scale transitions.
- Caveats: older Rift/Vive/Quest-link assumptions.

### `CRISPGroup/Mission-Control-MRI-VR`

- Interesting idea: MRI familiarization is reframed as a story mission with a
  virtual bed glide, movement feedback, and caregiver controller support.
- Code donor value: moderate for procedure training and caregiver-role pattern.
- Product reference value: strong for medical familiarization UX.
- What to inspect next: movement detection, caregiver controls, privacy terms,
  and validation plans.
- Caveats: explicitly preliminary and non-validated.

## Product Direction

This wave supports an `AI-assisted XR training lab` branch where deterministic
simulation state, reset/failure logic, and teacher/caregiver roles constrain any
LLM or voice layer.

