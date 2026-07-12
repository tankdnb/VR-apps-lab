# GitHub Research Wave 336 Backlog - Headsetless OpenXR, Godot, Bevy, and Runtime Simulator Harnesses

## Executed Scope

- Searched and deduplicated headsetless XR simulator candidates.
- Froze a five-project shortlist spanning OpenXR runtime, Godot autoload,
  Unreal plugin, Bevy template, and cross-platform runtime selector/client.
- Read source and documentation statically from local-only cache.
- Extracted keyboard/mouse pose driving, tracker injection, editor panel,
  record/replay, runtime manifest selection, and companion-client caveats.

## Studied Projects

- `jrng/openxr_simulator`
- `Cafezinhu/godot-vr-simulator`
- `sanky369/OpenXRSim`
- `kcking/bevy_xr_app`
- `demonixis/OpenXR-OSX`

## Backlog Findings

- Treat simulator support as a first-class utility family, not only as test
  convenience.
- Prefer adapters that preserve the same action/input surface used by real
  devices.
- Keep runtime registration, editor toggles, injected input, and replay data
  separate.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include studied projects.
- Method catalog captures no-headset simulator harness boundaries.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
