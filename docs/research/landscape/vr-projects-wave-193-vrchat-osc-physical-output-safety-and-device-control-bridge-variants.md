# VR Projects Wave 193: VRChat OSC Physical-Output Safety and Device-Control Bridge Variants

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 193 studies avatar OSC bridges that can control physical devices. The
reusable value is safety-first architecture: source gates, cooldowns, queues,
panic stops, max limits, status feedback, consent boundaries, and clear device
abstractions. These projects are documented as risky physical-output references,
not as recipes to copy blindly.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `ccvrc/DG-LAB-VRCOSC` | DG-LAB desktop bridge with OSCQuery and command queue | Strong router/UI donor with caveats |
| `amoeet/VRChat_X_DGLAB` | C# DG-LAB bridge variant | Thin Windows GUI reference |
| `boyqiu-001/VRCHAT-OSC-to-DGLAB` | Tkinter parameter-rule mapper | Simple rule editor donor |
| `ion-aluminium/VRC-DGLAB` | FastAPI/React DG-LAB bridge | Strong service-split donor |
| `Null-K/DG-LAB-VRChat-Sensora` | DG-LAB bridge with safety window and modes | Strong safety-mode donor |
| `noideaman/ShockVRC` | PiShock/OpenShock avatar menu bridge | Thin schema reference |
| `DesMakesStuff/PiShockTouch` | PiShock contact receiver bridge and OSC JSON installer | Installer/contact reference |
| `poprox24/VRChat-Shocker-Link-CPP` | C++ OSCQuery multi-backend shocker bridge | Strongest safety architecture donor |

## `ccvrc/DG-LAB-VRCOSC`

- Interesting idea:
  a PySide6 app combines GUI tabs, OSCQuery discovery, DG-LAB control,
  multi-source command routing, chatbox telemetry, source cooldowns, and logs.
- Code donor value:
  high for UI/service split, command queue, source enable flags, source
  cooldown, chatbox feedback, OSCQuery service, and status/log surfaces.
- Product reference value:
  high for how a physical-output bridge can make state visible instead of
  hiding it behind raw OSC callbacks.
- What to inspect next:
  safety guarantees, consent flow, source trust model, and robustness claims
  because the repository itself warns that code was LLM-generated and not fully
  tested.
- Source evidence:
  `src/app.py`, `src/config.py`, `src/dglab_controller.py`, and
  `src/services/oscquery_service.py`.
- Reusable pattern extraction:
  multi-source physical-output router with priority queue and visible status.
- Reusable core:
  expose a local UI, validate network config, discover VRChat OSC/OSCQuery,
  route commands through a single queue, tag commands by source, apply
  per-source cooldowns and enable flags, publish status through chatbox/logs,
  and keep device state explicit.
- Do not copy directly:
  physical-output behavior without consent/safety review, unvalidated generated
  code paths, or any default that lets external sources trigger output freely.
- Caveats:
  strong architecture sketch, but safety claims need independent design.

## `amoeet/VRChat_X_DGLAB`

- Interesting idea:
  a Windows DG-LAB bridge variant around avatar parameter to waveform output.
- Code donor value:
  low-to-medium as a GUI/reference variant.
- Product reference value:
  medium as evidence that users want simple avatar-parameter device bridges.
- What to inspect next:
  exact parameter schema, waveform queue, and safety behavior if promoted.
- Source evidence:
  repository structure and C# app files.
- Reusable pattern extraction:
  source-light DG-LAB bridge variant.
- Do not copy directly:
  unclear safety behavior or device-control logic without deeper review.
- Caveats:
  retained as a variant, not a primary donor.

## `boyqiu-001/VRCHAT-OSC-to-DGLAB`

- Interesting idea:
  a Tkinter app maps avatar OSC parameter rules to DG-LAB waveform patterns,
  channels, intensity, and tick counts.
- Code donor value:
  medium for a readable rule-editor baseline.
- Product reference value:
  medium for low-complexity physical-output configuration UX.
- What to inspect next:
  rule conflict handling, max output limits, and emergency disable behavior.
- Source evidence:
  `main.py`, `defaultData.py`, and `patterns.json`.
- Reusable pattern extraction:
  parameter-threshold physical-output rule editor.
- Reusable core:
  let users select an avatar parameter, choose judge mode/value, select a
  waveform pattern, pick channel/intensity/ticks, persist the rule, and apply
  the result only when the parameter condition matches.
- Do not copy directly:
  minimal safety checks, default parameter mappings, or raw intensity/tick
  assumptions as safe defaults.
- Caveats:
  useful because it is small and legible, not because it is complete.

## `ion-aluminium/VRC-DGLAB`

- Interesting idea:
  a FastAPI backend and React frontend split OSC listening, job evaluation,
  config, waveforms, DG-LAB service, and status endpoints.
- Code donor value:
  high for service boundaries, listener registration, regex/exact OSC routing,
  job debounce, waveform filling, and API-driven control UI.
- Product reference value:
  high for modernizing risky device bridges into inspectable services.
- What to inspect next:
  authentication, consent, config validation, and hard physical safety limits.
- Source evidence:
  `backend/app/main.py`, `services/osc_service.py`, and
  `services/job_service.py`.
- Reusable pattern extraction:
  service-oriented avatar OSC device bridge.
- Reusable core:
  start services from a bounded application lifespan, keep OSC receive/send in
  one service, register job callbacks from config, compute debounces from
  waveform timing, route actions through a device service, expose status/API
  endpoints, and keep frontend control separate from device execution.
- Do not copy directly:
  physical-output assumptions, local API exposure, or config schemas without
  explicit safety and auth layers.
- Caveats:
  strong backend shape; safety policy still needs to be first-class.

## `Null-K/DG-LAB-VRChat-Sensora`

- Interesting idea:
  a Python DG-LAB bridge combines WebSocket, HTTP, OSC, web UI, channel modes,
  chatbox status, waveform monitoring, rate limits, and a safety window.
- Code donor value:
  high for safety-window logic, mode-specific mappers, channel limits,
  chatbox/status templates, and runtime observability.
- Product reference value:
  high for turning physical output into a visible, bounded control surface.
- What to inspect next:
  consent UX, config editing workflow, and whether safety constants are
  sufficient for real devices.
- Source evidence:
  `settings.py`, `osc_handler.py`, `app.py`, and `constants.py`.
- Reusable pattern extraction:
  mode-aware physical-output bridge with safety window and rate limit.
- Reusable core:
  define per-channel max strengths, expose modes such as distance/shock/touch,
  map avatar parameters into normalized device actions, apply cooldown and
  rate-limit checks, clamp output duration, monitor recent output in a safety
  window, and send chatbox/status feedback.
- Do not copy directly:
  device-specific intensity semantics or safety constants without domain review.
- Caveats:
  one of the best references in this wave because safety is visible in code.

## `noideaman/ShockVRC`

- Interesting idea:
  an avatar expression-menu schema controls PiShock/OpenShock type, target,
  intensity, duration, shock trigger, and touchpoint values.
- Code donor value:
  medium for a compact avatar-menu parameter contract.
- Product reference value:
  medium for showing how physical-output controls can live inside an avatar UI.
- What to inspect next:
  OSCQuery plan, multi-device target safety, credential handling, and cooldown.
- Source evidence:
  `script/pishockasync.py`, README, and config notes.
- Reusable pattern extraction:
  avatar expression-menu physical-output parameter schema.
- Reusable core:
  define avatar parameters for output type, intensity, duration, target, and
  trigger, read those values through OSC, map normalized floats to bounded API
  values, and provide user-visible avatar controls.
- Do not copy directly:
  credential storage, thin safety behavior, or direct API calls as a complete
  product boundary.
- Caveats:
  useful schema reference, thin implementation.

## `DesMakesStuff/PiShockTouch`

- Interesting idea:
  a small installer patches VRChat avatar OSC JSON and a runtime script maps a
  contact receiver plus expression-menu parameters to PiShock API calls.
- Code donor value:
  medium for installer/backup flow and contact-receiver schema.
- Product reference value:
  medium for creator-facing setup automation.
- What to inspect next:
  safer patch preview, rollback UX, sharecode limits, and runtime failsafe.
- Source evidence:
  `Install.py` and `PiShockTouchVRC.py`.
- Reusable pattern extraction:
  avatar OSC JSON patcher plus contact receiver device bridge.
- Reusable core:
  locate an avatar OSC config, back it up, append needed parameters, ask for
  device credentials/settings, listen for contact/menu parameters, map floats
  to duration/intensity, and trigger the device API.
- Do not copy directly:
  silent file mutation, credential prompts, or missing runtime safety gates.
- Caveats:
  good reminder that setup automation needs rollback and user confirmation.

## `poprox24/VRChat-Shocker-Link-CPP`

- Interesting idea:
  a C++/ImGui bridge routes OSC/OSCQuery parameters to PiShock, OpenShock, and
  serial backends through queues, curve presets, dynamic cooldowns, a panic
  hotkey, chatbox feedback, and notifications.
- Code donor value:
  very high for safety architecture: queue ownership, global disable, empty
  queue, dynamic cooldown, panic hotkey, backend abstraction, status telemetry,
  and output curves.
- Product reference value:
  very high for what a responsible physical-output bridge must expose.
- What to inspect next:
  consent model, local access control, notification integrations, and audit log
  shape.
- Source evidence:
  `src/main.cpp`, `src/shockerhub.cpp`, `src/config/settings.cpp`, and
  `src/ui/ui.h`.
- Reusable pattern extraction:
  safety-first physical-output command hub.
- Reusable core:
  discover OSCQuery parameters, normalize pending avatar commands into a queue,
  disable output globally when requested, clear queued commands on panic, apply
  cooldown curves and per-output limits, choose a backend, emit chatbox or
  notification status, and persist user-controlled presets/settings.
- Do not copy directly:
  shocker-specific behavior, external API assumptions, or any physical-output
  action without consent, local auth, and explicit hard limits.
- Caveats:
  strongest donor in the wave, precisely because safety controls are central.

## Cross-Project Lessons

- Physical-output bridges need a safety model before they need more device
  integrations.
- OSCQuery is useful for setup, but discovery must not imply trust.
- Queues, cooldowns, panic stops, and global disable switches should be core
  architecture, not optional UI decorations.
- Chatbox/status feedback helps users and bystanders understand current state.
- Tiny rule editors are valuable, but only when paired with hard output caps.

## Reuse Recommendations

1. Use `VRChat-Shocker-Link-CPP` as the strongest safety architecture donor.
2. Use `DG-LAB-VRChat-Sensora` for safety-window and mode-specific mapping.
3. Use `VRC-DGLAB` for service-oriented backend boundaries.
4. Use `DG-LAB-VRCOSC` for GUI, OSCQuery, command queue, and status surfaces.
5. Use `VRCHAT-OSC-to-DGLAB`, `ShockVRC`, and `PiShockTouch` as compact schema
   and setup references only.

## Follow-Up Gaps

- Build a consent and safety matrix across all physical-output bridges.
- Compare panic-stop semantics: disable only, clear queue, reset parameters,
  close backend, and notify user.
- Extract a reusable avatar-parameter schema that separates intent from device
  actuation.
- Document minimum requirements before any physical-output prototype enters
  `VR-apps-lab`.
