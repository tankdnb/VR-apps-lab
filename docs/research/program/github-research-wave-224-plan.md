# GitHub Research Wave 224 Plan

Date: 2026-06-06

Theme: XR research data lifecycle templates, validation, and analysis pipelines.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

`VR-apps-lab` has many utility and overlay references, but research-grade XR
tools need a stronger view of data capture, session structure, event markers,
continuous tracking streams, validation, reporting, and downstream analysis.
This wave studies XR research templates and pipelines as reusable data-lifecycle
patterns rather than as applications to compile.

## Search Families

- Unity XR experiment templates.
- Quest/OVR research data capture shells.
- Scientific VR toolkits and replay systems.
- Data export, validation, and analysis pipelines.
- Editor-guided experiment setup and data binding helpers.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `ResXR/resxr-unity-research-template` | Clear-box Unity Quest research template with session/task/trial flow, tracking capture, room calibration, events, metadata, and custom CSV data classes. | XR research capture template |
| `ResXR/resxr-python-pipeline` | Downstream BIDS conversion, stream splitting, validation registry, quality flags, derivatives, and HTML reports for XR experiment data. | XR data processing pipeline |
| `ixperience-lab/VRSTK` | Legacy scientific VR toolkit with phase control, tracking, biosignals, questionnaires, replay, and analysis scripts. | Scientific VR toolkit |
| `eisclimber/ExPresS-XR` | Existing partial study deepened for data-gathering bindings, local/HTTP CSV export, editor setup dialogs, and authoring wizards. | Experiment authoring/data binding |

## Dedupe Notes

`ExPresS-XR` was already tracked and was used as a deepening/overlap reference,
not as a new repository. Broader Unity XR experiment framework waves already
exist, so this wave is bounded to data lifecycle and research instrumentation.

## Code-Level Pass Targets

- Session, task, trial, and event capture models.
- Continuous tracking and face/eye/body stream boundaries.
- Custom data schemas and CSV/BIDS export contracts.
- Validation registry and quality-flag behavior.
- Replay, questionnaire, biosignal, and analysis-script boundaries.
- Editor setup wizards and component/member data-binding helpers.

## Expected Outputs

- Wave 224 landscape synthesis.
- Registry/family entries for XR research data lifecycles.
- Method catalog entry for in-app capture plus downstream validation/export.
- Follow-up backlog for an XR research data lifecycle matrix.
