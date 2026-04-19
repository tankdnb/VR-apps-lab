# GitHub Research Wave 53 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `media launcher overlays`, `playback surfaces`, and
  `lightweight in-headset display shells`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for launcher overlays, `MPRIS` overlays, VR video overlays, and media-embedding repos
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans launcher shells, media controllers, playback surfaces, and proof-of-concept media embedding

## Work package B: Local source acquisition

- `Done` Confirm `launcher-openvr-overlay` in local cache
- `Done` Confirm `mpris-openvr-overlay` in local cache
- `Done` Confirm `vr-video-player-overlay` in local cache
- `Done` Confirm `MPVR` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect app-launch flow, `gamescope` wrapping, and optional video-player handoff in `launcher-openvr-overlay`
- `Done` Inspect egui renderer, `MPRIS` player discovery, and OpenVR event handling in `mpris-openvr-overlay`
- `Done` Inspect playback modes, window-capture path, and overlay mode in `vr-video-player-overlay`
- `Done` Inspect rough libmpv embed and overlay submission path in `MPVR`

## Work package D: Repository updates

- `Done` Add Wave 53 plan document
- `Done` Add Wave 53 backlog document
- `Done` Add Wave 53 synthesis document
- `Done` Update the project registry for media launcher and playback overlay surfaces
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes where needed
- `Done` Update the methods catalog with focused media/display-shell methods
- `Done` Update documentation indexes to include Wave 53

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `MPVR` only if a future branch needs a cleaner `libmpv embedded directly inside overlay` comparison node
- `Next` Keep `vr-video-player-overlay` visible whenever a future branch needs a fuller `window capture or video playback as VR surface` donor
- `Next` Use `launcher-openvr-overlay` as the main donor whenever a future branch needs `overlay shell as a process orchestrator` rather than a window mirror
