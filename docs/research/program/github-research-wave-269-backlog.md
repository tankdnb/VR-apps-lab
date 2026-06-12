# GitHub Research Wave 269 Backlog - OpenXR Action/Input Command and Hotkey Utility Bridges

## Executed Scope

- Searched and deduplicated OpenXR action/input, UEVR, Unity input, codegen,
  Monado-fork, and VRChat OSC hotkey candidates.
- Froze an eight-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted action schema, gesture recognition, keyboard/OSC dispatch,
  codegen, runtime-fork, and safety caveats.

## Studied Projects

- `art0007i/openxr-command-runner`
- `swirllyman/SimpleOpenXRInput`
- `gameflorist/uevr-touch-buttons-mapping-plugin`
- `germansmedia/openxr-actions-test`
- `danwillm/openxr-actions-tester`
- `brycehutchings/OpenXR-Action-Code-Generator`
- `tmddn0230/monado-input-system`
- `Somahc/VRCVoiceHotkey`

## Backlog Findings

- Build a VR hotkey/action bridge matrix across OpenXR, Unity, UEVR,
  keyboard hooks, and OSC.
- Deepen `openxr-command-runner` before any arbitrary-command prototype.
- Use `openxr-actions-tester` and `OpenXR-Action-Code-Generator` as diagnostic
  and boilerplate-reduction references.
- Keep `tmddn0230/monado-input-system` as a Monado variant until unique diff is
  isolated.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an input/action bridge method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
