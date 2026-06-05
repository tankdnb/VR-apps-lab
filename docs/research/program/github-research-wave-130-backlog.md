# GitHub Research Wave 130 Backlog

- Date: `2026-06-05`
- Scope: Resonite/Neos modding, manifests, mod managers, SDKs, headless
  deployment, companion clients, and metrics tooling.

## Completed in this wave

- Studied `resonite-modding-group/ResoniteModLoader` as a loader lifecycle,
  config, Harmony conflict, duplicate-mod, and headless-aware donor.
- Studied `Gawdl3y/Resolute` as a manifest-backed Tauri/Rust/Vue mod manager.
- Studied `resonite-modding-group/resonite-mod-manifest` as a schema-first
  manifest and generator reference.
- Studied `Yellow-Dog-Man/ResoniteLink` as an external WebSocket data-model SDK
  and REPL reference.
- Studied `shadowpanther/resonite-headless` as a headless deployment packaging
  reference.
- Studied `Nutcake/ReCon` as a social companion client with API auth and live
  hub events.
- Studied `esnya/ResoniteMetricsCounter` as in-world metrics/profiling and
  UIX diagnostics tooling.

## Reuse candidates

- `ResoniteModLoader` is the strongest loader/config/conflict donor.
- `resonite-mod-manifest` plus `Resolute` are the strongest manifest-manager
  donors.
- `ResoniteLink` is the strongest external automation SDK donor.
- `ResoniteMetricsCounter` is the strongest social VR diagnostics donor.

## Follow-up backlog

1. Compare mod/package schemas across QMOD, Resonite manifests, and future
   `VR-apps-lab` package metadata.
2. Extract a manifest-backed manager blueprint for plugin-like VR utilities.
3. Compare social companion clients across Resonite and VRChat ecosystems.
4. Revisit `ResoniteLink` if external control/inspection prototypes become
   active.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
