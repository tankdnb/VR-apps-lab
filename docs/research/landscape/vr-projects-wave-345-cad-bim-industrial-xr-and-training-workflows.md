# Wave 345: CAD BIM Industrial XR and Training Workflows

## Scope

This wave focuses on VR utilities that inspect, slice, annotate, train on, or
round-trip industrial and AEC data. The important lesson is that model viewing,
metadata import, training validation, assistant panels, and authoring-tool
writeback are separate concerns.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `LukeA25/vrCadViewer` | Studied | Quest CAD viewer with grab, slice, explode, draw, pointer tools, mode switching, EzySlice integration, and original-position mapping |
| `UnityCommunity/CADImportExport` | Studied as source-light package marker | Runtime CAD import/export direction for Unity desktop and Quest/Android targets |
| `giorgosfatouros/XR2IND-VR` | Studied | Industrial VR training app with tutorial/assembly/troubleshooting rooms, task whiteboards, interactive network-equipment models, STT, LLM assistant REST calls, and RAG/manual dependency |
| `krishnahsanghani-netizen/visualyze-core` | Studied | Visualyze MVP with Unity VR client plus Revit edit applier that reads JSON edit logs and moves elements inside a transaction |
| `isaddiq/BIMUniXchange` | Studied | BIM-to-Unity pipeline with Archicad Python metadata extraction, Revit/Archicad/Unity documentation, CSV samples, and export summaries |
| `game4automation/realvirtual-WEB` | Studied | Web industrial digital-twin/HMI surface with React/TypeScript annotation panels, tooltips, sim-controller toolbar, layout planner, MCP bridge, and Teams shell |

## Reusable Pattern Extraction

- Pattern candidate: `CAD/BIM XR round-trip utility decomposition`.
- Problem solved: industrial XR tools often fail when geometry, metadata,
  training state, annotation, assistant prompts, and authoring-tool mutation
  are handled as one monolith.
- Reusable core: model importer, metadata table, object ID mapping, in-VR
  inspect/slice/explode/draw tools, task/step validation, voice assistant
  panel, edit-log schema, coordinate/unit conversion, authoring-tool applier,
  transaction/rollback UI, and HMI/tooltip surface.
- Source evidence: vrCadViewer's slicer and tool modes, CADImportExport's
  runtime import/export framing, XR2IND's training whiteboards and STT/LLM
  screen, Visualyze's Revit edit applier, BIMUniXchange's Archicad/Revit CSV
  metadata extraction, and realvirtual-WEB's annotation/HMI panels.
- Abstraction boundary: VR scene manipulation should output validated
  operations; external CAD/BIM systems should apply them through explicit
  adapters with confirmation, unit conversion, and rollback.
- What not to copy: hardcoded edit paths, raw string JSON construction, hidden
  API keys, unvalidated LLM answers, proprietary CAD packages, and destructive
  model mutation without previews.
- Method catalog action: create a new method for CAD/BIM industrial XR
  round-trip workflows.

## Project Notes

### `LukeA25/vrCadViewer`

- Interesting idea: one in-headset CAD utility bundles inspect, slice, explode,
  draw, and pointer modes.
- Code donor value: good for slicer mode cadence, temporary hull lifecycle,
  original-position mapping, held slice plane, and tool-mode UX.
- Product reference value: strong for lightweight engineering-review tools.
- What to inspect next: explode/draw/pointer scripts and model part mapping.
- Caveats: student-scale Unity app with Quest/Meta dependencies.

### `UnityCommunity/CADImportExport`

- Interesting idea: runtime CAD import/export positioned explicitly for Unity
  apps and Quest/Android.
- Code donor value: low in this pass because repository is source-light, but
  useful as a package direction marker.
- Product reference value: useful for keeping import/export in a library layer
  instead of embedding it into each viewer.
- What to inspect next: releases, package contents, supported formats, and
  license details.
- Caveats: source-light clone; do not promote as donor until code is available.

### `giorgosfatouros/XR2IND-VR`

- Interesting idea: industrial VR training with task whiteboards and an LLM
  assistant that is mediated through speech-to-text and REST.
- Code donor value: useful for task panels, microphone capture to WAV,
  HuggingFace STT integration, LLM panel lifecycle, and room/scene structure.
- Product reference value: strong for guided training utilities.
- What to inspect next: task validation scripts, whiteboard state, RAG upload
  boundary, and API-key handling.
- Caveats: raw request construction and environment-variable endpoint require
  security hardening.

### `krishnahsanghani-netizen/visualyze-core`

- Interesting idea: VR edits are written as JSON logs, then a Revit external
  command applies them transactionally.
- Code donor value: strong for edit-log applier, coordinate conversion,
  confirmation dialog, success/failure aggregation, and Revit transaction
  boundary.
- Product reference value: strong for `edit in headset, apply in CAD/BIM tool`
  workflows.
- What to inspect next: Unity-side edit-log writer and element-ID mapping.
- Caveats: hardcoded Windows path and name-based lookup need replacement.

### `isaddiq/BIMUniXchange`

- Interesting idea: export geometry plus metadata from authoring tools into
  Unity/XR.
- Code donor value: good for Archicad metadata extraction, batch export
  summary, category/type distribution, CSV samples, and Revit/Archicad/Unity
  workflow docs.
- Product reference value: strong for AEC-to-XR pipeline documentation.
- What to inspect next: Revit app-store package output schema and Unity
  package import behavior.
- Caveats: much of the Unity/Revit implementation is release-side, not fully
  present in source.

### `game4automation/realvirtual-WEB`

- Interesting idea: industrial digital-twin surface exposes HMI tooltips,
  annotations, simulation controls, layout planning, and collaboration shells.
- Code donor value: useful for web-side HMI panel decomposition and annotation
  architecture, even if not VR-native.
- Product reference value: useful for future XR dashboards around industrial
  scene state.
- What to inspect next: state model, WebSocket/MCP bridge, auth, and
  simulation-controller transport.
- Caveats: web/Teams product boundary, not a direct headset app.

## Product Direction

This wave supports a future `XR engineering workbench` branch: import geometry
and metadata, inspect or annotate it in VR, export explicit edit logs, and
apply changes through safe CAD/BIM adapters.

