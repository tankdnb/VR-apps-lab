# GitHub Research Wave 324 Plan - VRChat Parameter State Dashboards and Local Web Control Mirrors

## Goal

Deepen the long-standing `I5UCC/ParameterSaveStates` follow-up into a full
dashboard/state-management study and extract reusable patterns for avatar
parameter profiles, mirrored local web UIs, and SteamVR dashboard apps.

## Research Questions

- How can an in-headset dashboard save and replay per-avatar parameter state?
- What boundary is useful between OSCQuery discovery, profile persistence,
  dashboard controls, and local browser control?
- Which parts are reusable for future VR utility dashboards without copying a
  VRChat-specific app wholesale?

## Shortlist

- `I5UCC/ParameterSaveStates`

## Required Checks

- Deduplicate against earlier VRChat OSC, SteaMeeter, and dashboard waves.
- Treat this as a deepening pass because the repo was tracked as `Not studied
  deeply`.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch the project.

## Expected Outputs

- Landscape synthesis for Wave 324.
- Registry/family status upgraded from `Not studied deeply` to `Studied`.
- Method catalog entry for avatar/runtime state profile dashboards with local
  web-control mirrors.
