# GitHub Research Wave 73 Backlog

- Date: `2026-04-20`
- Scope: next GitHub discovery wave focused on the
  `WayVR ecosystem`, `Linux dashboard extensions`, and
  `IPC-backed overlay surfaces`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for WayVR repos, Linux dashboard extensions, and IPC-backed overlay surfaces
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans host core, dashboard client, protocol crate, and script-driven extension module

## Work package B: Local source acquisition

- `Done` Confirm `wayvr` in local cache
- `Done` Confirm `wayvr-dashboard` in local cache
- `Done` Confirm `wayvr-ipc` in local cache
- `Done` Confirm `WayvrWalltaker` in local cache
- `Done` Keep `wivrn-stack-control` as a secondary comparison node only
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect compositor core, display model, and window hosting in `wayvr`
- `Done` Inspect dashboard-side commands and frontend IPC in `wayvr-dashboard`
- `Done` Inspect handshake, socket transport, and request queueing in `wayvr-ipc`
- `Done` Inspect panel XML plus shell-script extension flow in `WayvrWalltaker`

## Work package D: Repository updates

- `Done` Add Wave 73 plan document
- `Done` Add Wave 73 backlog document
- `Done` Add Wave 73 synthesis document
- `Done` Update the project registry for WayVR ecosystem layers
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new Linux overlay host and extension patterns
- `Done` Update documentation indexes to include Wave 73

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `wayvr` visible whenever a future branch needs an `embedded compositor as VR surface host`
- `Next` Keep `wayvr-dashboard` and `wayvr-ipc` visible whenever `VR-apps-lab` needs a stronger `host core plus protocol plus dashboard client` split
- `Next` Keep `WayvrWalltaker` visible as a practical `script and panel XML extension` donor
