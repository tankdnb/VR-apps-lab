# GitHub Research Wave 185 Plan

- Date: `2026-06-06`
- Theme: `Accessibility, embodied locomotion, redirected walking, and zero-G control`
- Scope: wheelchair rigs, locomotion accessibility kits, zero-G grab/thruster
  movement, natural locomotion hubs, redirected-walking plugins, and thin
  locomotion classroom/demo repositories.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Locomotion research is valuable to `VR-apps-lab` when it becomes reusable
utility knowledge: input abstraction, comfort boundaries, body embodiment,
accessibility options, redirection gains, and diagnostics/logging. This wave
focuses on implementation patterns rather than shipping game mechanics.

## Search Families

- wheelchair and embodied locomotion
- XR accessibility locomotion options
- zero-G grab and thruster movement
- natural locomotion hub/input/modifier splits
- redirected walking and level-design helpers
- classroom/demo locomotion comparisons

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `justinmajetich/vr-wheelchair` | Wheelchair rig using XR Interaction Toolkit, wheel grabs, braking, and haptics | Embodied accessibility locomotion |
| `XR-Access-Initiative/Locomotion-Accessibility-Toolkit` | Accessibility framing around teleport, smooth movement, and snap turning | Accessibility locomotion package |
| `simeonradivoev/echo-unity` | Zero-G movement with grab joints, thrusters, realistic/comfort toggle, and UI | Zero-G embodied locomotion |
| `DigitalDiceworks/ddw-locomotion-system` | Natural locomotion hub with inputs, modifiers, and movement components | Locomotion abstraction donor |
| `curvaturegames/space-extender` | Redirected-walking Unity package with gain redirectors, editor UI, and CSV logging | Redirected walking/tooling donor |
| `LariWa/VR-Locomotion` | Empty clone from search | Empty/source-light exclusion |

## Dedupe Notes

- `ElectricNightOwl/ArmSwinger` was found again but was already studied in an
  earlier redirected-walking/locomotion wave, so it was not reused here.
- This wave adds new neighboring locomotion references rather than repeating
  existing treadmill or arm-swinger coverage.
- `LariWa/VR-Locomotion` cloned empty and is retained only as an exclusion note.

## Code-Level Pass Targets

- XR Interaction Toolkit wheel/grab mediators and haptic feedback;
- accessibility packaging and mode-set framing;
- zero-G static/dynamic grab joints, thruster heat, and comfort toggles;
- hub/input/modifier/movement split;
- redirected-walking translation/rotation gains and data logging;
- source-light or empty repo caveats.

## Expected Outputs

- Wave 185 landscape synthesis.
- Registry/family placement for accessibility and locomotion utility patterns.
- Methods around embodied wheel input, locomotion hubs, redirected-walking
  telemetry, and zero-G grab/thruster control.
