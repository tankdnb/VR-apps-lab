# GitHub Research Wave 81 Backlog

- Date: `2026-04-20`
- Scope: next GitHub discovery wave focused on
  `immersive music players`, `VR media playback surfaces`, and
  `browser-backed or engine-backed video shells`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for VR music players, immersive media shells, and WebXR video players
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist spanning VR-native music playback, headset-aware desktop media shells, browser video players, and engine-side playback substrate

## Work package B: Local source acquisition

- `Done` Confirm `around-sound` in local cache
- `Done` Confirm `360PlayerWindows` in local cache
- `Done` Confirm `WebXR-video-player` in local cache
- `Done` Confirm `vlc-unity` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect local-file ingestion, speaker tagging, and multi-speaker catch-up logic in `around-sound`
- `Done` Inspect shell, decoder, and headset-backend split in `360PlayerWindows`
- `Done` Inspect projection manager, UI components, and device abstractions in `WebXR-video-player`
- `Done` Inspect demos, backend packaging, and VR-facing playback references in `vlc-unity`

## Work package D: Repository updates

- `Done` Add Wave 81 plan document
- `Done` Add Wave 81 backlog document
- `Done` Add Wave 81 synthesis document
- `Done` Update the project registry for immersive playback donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new media-player patterns
- `Done` Update documentation indexes to include Wave 81

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `360PlayerWindows` visible as a `multi-headset immersive media shell` comparison node
- `Next` Keep `vlc-unity` visible as a `media substrate inside an engine` donor rather than only as a player example
- `Next` Keep `around-sound` visible whenever a future pass needs a `speaker-topology-first music player` reference
