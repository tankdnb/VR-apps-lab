# GitHub Research Wave 54 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `Discord voice overlays`, `note surfaces`, and
  `context-status micro-overlays`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for Discord overlays, note overlays, and narrow game-status overlay repos
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans local IPC overlays, browser-widget overlays, annotation surfaces, and game-specific status surfaces

## Work package B: Local source acquisition

- `Done` Confirm `SteamVR-Discord-Overlay` in local cache
- `Done` Confirm `DiscOverlay` in local cache
- `Done` Confirm `vr-notes-anywhere` in local cache
- `Done` Confirm `SteamVR-PhasmoMatrix` in local cache
- `Done` Confirm `SmudgeTimerOpenVR` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect Discord local IPC, web dashboard, and button-overlay split in `SteamVR-Discord-Overlay`
- `Done` Inspect Unity WebBrowser and dashboard-positioning flow in `DiscOverlay`
- `Done` Inspect projection-overlay runtime, stroke scene state, and desktop control window in `vr-notes-anywhere`
- `Done` Inspect SteamVR-Webkit wrapper pattern in `SteamVR-PhasmoMatrix`
- `Done` Inspect wrist anchor, texture refresh, and controller-distance gesture flow in `SmudgeTimerOpenVR`

## Work package D: Repository updates

- `Done` Add Wave 54 plan document
- `Done` Add Wave 54 backlog document
- `Done` Add Wave 54 synthesis document
- `Done` Update the project registry for Discord, note, and status overlays
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes
- `Done` Update the methods catalog with narrow communication and micro-overlay methods
- `Done` Update documentation indexes to include Wave 54

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `beareogaming/BD-XSOverlay-notify` only if a future pass needs the `plugin sends notifications into external overlay host` pattern more explicitly
- `Next` Keep `SteamVR-Discord-Overlay` visible whenever a future branch needs `overlay plus localhost dashboard` rather than a thin browser widget
- `Next` Keep `vr-notes-anywhere` and `SmudgeTimerOpenVR` visible as proof that narrow, stateful overlay surfaces can justify their own product branch
