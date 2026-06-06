# GitHub Research Wave 258 Backlog - VRChat OSC Micro-Control, Input, and Avatar-Parameter Utilities

## Executed Scope

- Searched and deduplicated VRChat OSC micro-control, input, CLI, sensor, and
  library candidates.
- Froze a shortlist spanning AFK/mute, controller axes, eye height, rapid input,
  robust tray hotkeys, shell wrappers, toolkit UI, status composition, BLE
  heart rate, and typed Rust OSC libraries.
- Read source and documentation statically from local-only cache.
- Extracted source-adapter, state mirror, queue/cooldown, safety release,
  privacy, and address-contract lessons.

## Studied Projects

- `Sayamame-beans/VRC_AFK_AutoMuter`
- `03milo/InputFixer`
- `Airbee/VRChat-OSC-Scaling`
- `koturn/OscRapidUseRight`
- `Hino-VRChat/vrchat-mute-toggle`
- `SourLemonJuice/VRChat-OSC-Shell`
- `YimuQrrr/OSC_Tool`
- `xiaoBingge114514/VRChat-OSC-Chat-Tool`
- `Ero-Cat/hr_push`
- `kb10uy/phorcys`

## Backlog Findings

- Add a microtool safety checklist covering queueing, release pulses, cooldowns,
  process gates, and port conflicts.
- Compare typed OSC libraries and direct-address senders across Python, C#,
  Rust, C, and Flutter/Dart.
- Deepen biometric privacy handling for heart-rate, sensor, and public chatbox
  outputs.
- Track `phorcys` as a potential library donor for typed tests and avatar JSON
  validation.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes VRChat OSC micro-control method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
