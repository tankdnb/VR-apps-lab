# VR Projects Wave 238: VR Training, Rehabilitation, and Simulated-User Evaluation Harnesses

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies VR training and evaluation systems: simulated user loops,
scenario reward/reset hooks, weapon/equipment training, rehab biofeedback,
sensor filtering, live graphs, actuator commands, AI coaching, and training
session lookup.

## Why It Matters For `VR-apps-lab`

Research tooling is not only overlays and runtimes. A good VR lab also needs
ways to evaluate interactions, capture sensor data, guide users, and turn
scenarios into reusable harnesses. These projects help name the boundary
between scenario content, data capture, feedback, coach logic, and safety.

## Project Notes

### `fl0fischer/sim2vr`

- Interesting idea:
  a Unity VR app can become a biomechanical evaluation environment when HMD and
  controller poses, RGB-D observations, reward, reset, and logs are exchanged
  with an external simulated user.
- Code donor value:
  `RLEnv.cs` defines abstract game-specific reward, reset, time feature,
  logging, and termination hooks. `SimulatedUser.cs` disables normal tracked
  camera pose, receives simulated HMD/controller transforms, manually renders
  RGB-D images, and sends reward/observation/log payloads. `ZmqServer.cs`
  uses NetMQ request/reply with JSON state and observations. `Recorder.cs`
  captures environment and headset camera frames into separate folders.
- Product reference value:
  strong evaluation-harness donor for future VR utility testing.
- What to inspect next:
  compare against existing XR research data lifecycle templates and decide how
  a smaller utility can expose reward/reset/log hooks.
- Architecture pattern:
  Unity scenario plus external simulated user over ZMQ with explicit episode
  state and observation channel.
- Caveats:
  research stack depends on User-in-the-Box, MuJoCo, OpenXR Unity setup, and
  task-specific reward implementations.

### `kaayran/ShootingRangeVR`

- Interesting idea:
  realistic training value comes from stateful object mechanics, not only a
  target scene.
- Code donor value:
  weapon/ammunition/grenade/equipment scripts separate cartridges, magazine
  containers, loaders, extractors, armor, helmet, damage, audio, and particle
  effects. `HumanTarget.cs` computes hit accuracy from contact distance to a
  center point and emits hit count/accuracy. `AccuracyPanel.cs` maintains
  average accuracy and shot count. `RemoteControl.cs` moves the target forward
  or backward at configured speed.
- Product reference value:
  good training scenario reference for scoring, equipment state, and target
  control.
- What to inspect next:
  compare scenario object decomposition with less weapon-specific training
  tools.
- Architecture pattern:
  scenario mechanics split into object modules, scoring panel, and remote
  control surface.
- Caveats:
  product domain is weapon training; reuse only generic scenario/scoring
  patterns, not assets or domain assumptions.

### `GxRay/Trunk-Rehabilitation-VR-Training-Simulator-`

- Interesting idea:
  rehab VR can be modeled as sensor ingress, filtering, live feedback,
  gamified movement, and external actuator command, not just a scene.
- Code donor value:
  `Data_Aquisition.cs` reads comma-separated EMG/accelerometer data over TCP on
  a background thread, parses muscle channels, applies notch filters, and
  stores EMG points. `FilterData.cs` implements reusable IIR filter state.
  `SpaceBall_Sender.cs` emits three-digit motion commands over TCP based on
  difficulty and random movement selection. `Window_Graph.cs` draws simple
  line graphs from point lists. `Player_Statistics.cs` updates score/life HUD.
- Product reference value:
  strong rehab/biofeedback donor for sensor feedback loops.
- What to inspect next:
  compare with broader sensor-to-avatar/device bridge families and research
  data export templates.
- Architecture pattern:
  wearable sensor ingress, signal filter, feedback graph, game state, and
  external actuator command loop.
- Caveats:
  hardcoded IPs, research prototype maturity, hardware-specific belt/Spaceball
  assumptions, and old mobile/Cardboard framing.

### `Nelliel2/VR-training-simulator`

- Interesting idea:
  construction/worksite training repositories can be useful scenario references
  even when the code tree is asset-heavy.
- Code donor value:
  this pass saw a large Unity tree with animations, materials, and project
  assets; no compact script donor was extracted in the bounded pass.
- Product reference value:
  retained as a scenario-family reference for future construction safety
  training comparisons.
- What to inspect next:
  script-level checkout or narrow path search if this family becomes a focus.
- Architecture pattern:
  asset-heavy Unity training scenario.
- Caveats:
  not promoted to a method donor in this wave.

### `NagashreeSP/VR-Fire-Safety-Training-Simulator`

- Interesting idea:
  fire-safety training is a relevant family, but this repository currently
  exposes only a concept-level README in the checked tree.
- Code donor value:
  none from this pass.
- Product reference value:
  source-light concept note only.
- What to inspect next:
  revisit only if source appears or a richer fork is found.
- Architecture pattern:
  README-only training concept.
- Caveats:
  not a studied donor.

### `superjaviko/RESILIENCE`

- Interesting idea:
  VR training can pair immersive scenarios with an AI/voice coach and external
  operator knowledge data, but this requires strict security boundaries.
- Code donor value:
  UPBGE scripts include socket-based training-session lookup, Google Sheets
  training-session fetch in a background thread, voice-recognition plus TTS
  coach flow, procedure-context prompt construction, navigation-arrow setup,
  audio command triggers, and training-session UI text updates.
- Product reference value:
  useful AI-coach/product reference for multilingual or industrial training
  support.
- What to inspect next:
  extract only the safe architecture: local coach state, procedure knowledge
  boundary, voice I/O abstraction, and external data adapter.
- Architecture pattern:
  scenario plus voice coach plus external operator-data adapter.
- Caveats:
  scripts contain hardcoded API keys, local absolute paths, service-account
  paths, microphone indexes, and cloud dependencies; these are anti-patterns
  and must not be copied.

## Reusable Pattern Extraction

- Pattern candidate:
  scenario training harness with sensor, coach, and evaluation loop.
- Problem solved:
  VR training tools need a repeatable way to connect scenario state, user or
  simulated-user input, scoring/reward, sensor data, feedback, coaching, and
  logs.
- Reusable core:
  isolate scenario state, episode reset, observation/render capture,
  reward/scoring, sensor ingress/filtering, live feedback, coach/advisor
  interface, external data adapter, logging/export, and safety/security policy.
- Source evidence:
  `sim2vr`, `ShootingRangeVR`,
  `Trunk-Rehabilitation-VR-Training-Simulator-`, `VR-training-simulator`,
  `VR-Fire-Safety-Training-Simulator`, and `RESILIENCE`.
- Abstraction boundary:
  keep scenario mechanics separate from evaluation harness; keep sensor and
  actuator transports separate from gameplay; keep AI/cloud coaching behind a
  replaceable adapter with no embedded secrets.
- What not to copy:
  hardcoded API keys, local credential paths, patient/research artifacts,
  hardware IPs, weapon assets, giant Unity asset trees, or README-only concepts
  as implementation donors.
- Method catalog action:
  add a method entry for scenario training harness boundaries.

## Follow-Up Gaps

- Compare simulated user harnesses, rehab sensor loops, scenario scoring, AI
  coach loops, and research data export into a single training matrix.
- Extract a minimal `RLEnv`-style hook contract for future utility testing:
  initialize, reset, reward, done, log, time feature, observation.
- Add a security checklist for AI/voice/cloud training examples.
