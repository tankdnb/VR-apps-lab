# GitHub Research Wave 273 Backlog - VR Performance Tuning, FSR, and FPS Helper Surfaces

## Executed Scope

- Searched and deduplicated VR performance helper projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted Steam library scanning, DLL backup/restore, config schemas,
  runtime extraction/loading, binary-only config caveats, and FPS comfort
  baselines.

## Studied Projects

- `tappi287/openvr_fsr_app`
- `LavaGang/ML_OpenVR_FSR`
- `komori/vrperfkit-ocq2`
- `GodotVR/godot_openvr_fps`

## Backlog Findings

- Build a performance-tuning manager matrix across target discovery, DLL
  replacement, runtime loader extraction, config schema, version detection,
  backup/restore, and compatibility warnings.
- Treat binary-only tuning bundles as reference-only until source evidence is
  available.
- Extract a setting-schema pattern with range/select/key-combo fields and
  per-setting descriptions.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a VR performance tuning manager method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
