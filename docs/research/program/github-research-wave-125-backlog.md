# GitHub Research Wave 125 Backlog

- Date: `2026-06-05`
- Scope: Unity VR experiment frameworks, trial orchestration, data capture,
  trackers, remote settings, and upload sidecars.

## Completed in this wave

- Studied `immersivecognition/unity-experiment-framework` as the canonical UXF
  session/block/trial/tracker/data-handler framework.
- Studied `BioMotionLab/TUX` as an editor-authored experiment design and
  runtime-runner toolkit.
- Studied `jinwook31/Unity-Experiment-Trial-Manager` as a lightweight
  CSV-driven trial loop.
- Studied `Nesbi/PsyWueVR` as a psychology VR controller with subject profile,
  instruction, blackout, and headtracking state.
- Studied `social-spatial-interaction-lab/VR_Motion_Tracker` as a UXF plus
  MR/OpenXR pose-logging shell.
- Studied `SensoriMotorControlLab/vr_experiment_framework_v3` as a
  JSON/UXF task generator with pseudo-randomization and resume behavior.
- Studied `jackbrookes/uxf-s3-uploader` as a cloud upload sidecar.
- Studied `jackbrookes/uxf-web-settings` as remote settings plus local fallback
  session setup.

## Reuse candidates

- UXF is the strongest donor for session/trial/tracker/data-handler
  boundaries.
- TUX is strongest for editor-authored design and runtime runner separation.
- `vr_experiment_framework_v3` is strongest for settings-prefix task
  generation, pseudo-randomization, and resume.
- `uxf-web-settings` and `uxf-s3-uploader` are strong deployment sidecars.

## Follow-up backlog

1. Extract a minimal study-harness method for diagnostics and calibration
   tools.
2. Compare CSV, JSON, ScriptableObject, and remote-settings approaches.
3. Add a reuse plan only if a runnable guided-test prototype starts.
4. Keep lab-specific logic out of `VR-apps-lab` unless it generalizes into
   session/data-capture infrastructure.

## Quality notes

- No found project was built, launched, installed, or run.
- The wave documents reusable patterns rather than adopting dependencies.
