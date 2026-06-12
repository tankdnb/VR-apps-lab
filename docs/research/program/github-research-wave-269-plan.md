# GitHub Research Wave 269 Plan - OpenXR Action/Input Command and Hotkey Utility Bridges

## Goal

Study OpenXR/action/input bridge projects that connect VR controller or desktop
input to commands, hotkeys, diagnostics, generated code, and VRChat OSC
actions.

## Research Questions

- How do projects separate input acquisition from command dispatch?
- Which action/binding schemas are most reusable?
- What safety gates are needed around shell commands, keyboard injection, OSC
  pulses, and runtime forks?
- Which projects are diagnostics/codegen references rather than product donors?

## Shortlist

- `art0007i/openxr-command-runner`
- `swirllyman/SimpleOpenXRInput`
- `gameflorist/uevr-touch-buttons-mapping-plugin`
- `germansmedia/openxr-actions-test`
- `danwillm/openxr-actions-tester`
- `brycehutchings/OpenXR-Action-Code-Generator`
- `tmddn0230/monado-input-system`
- `Somahc/VRCVoiceHotkey`

## Required Checks

- Deduplicate against OpenXR diagnostics, VRChat OSC micro-control, and
  SteamVR dashboard navigation waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Update registry, families, methods, not-yet-studied, current focus, and
  indexes.

## Expected Outputs

- Landscape synthesis for Wave 269.
- Registry/family entries for OpenXR/action input bridges.
- Method catalog entry for input/action-to-command bridge boundaries.
- Follow-up gaps around command safety, OpenXR input doctoring, and codegen.
