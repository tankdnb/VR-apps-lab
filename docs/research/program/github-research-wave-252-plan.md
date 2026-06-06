# GitHub Research Wave 252 Plan

Date: 2026-06-06

Theme: hands-free OpenXR hand tracking input and wrist UI microtools.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The repository has many overlay and keyboard references, but less explicit
coverage of small controllerless input translators. This wave studies head
pose, hand curls, pinch rays, and wrist menus as utility input boundaries.

## Search Families

- OpenXR head-to-cursor utilities.
- Hand-tracking chording keyboards.
- Vendor OpenXR hand-tracking samples.
- Godot/OpenXR raw hand joint and wrist UI experiments.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `SimForgeEngineering/DCS-HandsFree` | StereoKit head-pose to foreground-window cursor mapper. | Hands-free cursor microtool |
| `JonahSagers/VRChord` | Unity XR Hands chording keyboard with curl dictionaries and visual feedback. | Hands-only text input donor |
| `Haidere1/VarjoXR-CustomHandTracking-Test` | Unreal/Varjo OpenXR hand keypoint, pinch, HUD, and scene manipulation sample. | Vendor hand-tracking reference |
| `zodiepupper/godothandtrackingtests` | Godot OpenXR raw joint tracker, wrist menu, and 3D panel experiment. | Godot hand UI donor |

## Dedupe Notes

Earlier waves cover VR keyboard surfaces, WebXR hands, and cockpit hand
clicking. This wave keeps only new repositories that add source-level
controllerless input boundaries.

## Code-Level Pass Targets

- Head/hand data source.
- Calibration or normalization.
- Gesture/chord interpretation.
- Output adapter: cursor, text, scene ray, wrist UI, or panel.
- Feedback, latches, and caveats.

## Expected Outputs

- Wave 252 landscape synthesis.
- Registry/family entry for hands-free input microtools.
- Method catalog entry for hand-derived utility input.
- Follow-up backlog for calibration and safety comparisons.
