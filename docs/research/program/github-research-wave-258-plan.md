# GitHub Research Wave 258 Plan - VRChat OSC Micro-Control, Input, and Avatar-Parameter Utilities

## Goal

Study compact VRChat OSC utilities that control avatar parameters, chatbox
messages, input endpoints, and external sensor or hotkey sources.

## Research Questions

- What separates safe OSC micro-control from raw unbounded OSC packet spam?
- Which projects show reusable queue, cooldown, state mirror, process gate, and
  visible operator state patterns?
- How should `VR-apps-lab` document OSC microtools that are smaller than full
  apps but still strategically useful?

## Shortlist

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

## Required Checks

- Deduplicate against prior chatbox, biometric, MIDI, haptics, OSCQuery, and
  VRChat companion waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields plus reusable pattern bridge fields.
- Update registry, families, not-yet-studied queue, methods, and indexes.

## Expected Outputs

- Landscape synthesis for Wave 258.
- Registry section and family entry for VRChat OSC micro-control utilities.
- Method catalog entry for OSC micro-control source adapters, safety gates, and
  visible state.
- Follow-up gaps for port conflicts, OSCQuery discovery, typed address
  contracts, and privacy.
