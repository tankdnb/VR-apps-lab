# GitHub Research Wave 318 Plan - Runtime Launch Sidecars, Overlay Autostart, and Session Operator Helpers

## Goal

Study runtime-adjacent operator helpers as reusable references for runtime
watchers, autostart hooks, task orchestration, runtime switching, overlay-sidecar
companions, and session bring-up UX.

## Research Questions

- How do small operator tools react to runtime/session state without becoming
  full launchers or full runtimes?
- What are the strongest donor patterns for runtime switching, backup/restore,
  start/stop task policy, and input arbitration?
- Which projects are architecture donors versus mainly product/reference shells?
- How much value comes from file-coupled sidecars or wizard UX rather than deep
  runtime internals?

## Shortlist

- `dreiekk/OpenVR-Autostarter`
- `Eidenz/monadeck`
- `Eidenz/monado-frame`
- `EllieWasteland/CaronteLauncherVR`

## Required Checks

- Deduplicate against earlier launcher, startup orchestration, and overlay
  micro-surface waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep rollback, runtime ownership, file-coupled helper, and source-light
  product-reference caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 318.
- Registry/family entries for runtime operator sidecars and session helpers.
- Method catalog entry for runtime operator sidecar boundaries.
- Follow-up gaps for runtime switching, input arbitration, and overlay
  companion generalization.
