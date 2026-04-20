# GitHub Research Wave 80 Backlog

- Date: `2026-04-20`
- Scope: next GitHub discovery wave focused on
  `microphone control overlays`, `voice-input pipelines`, and
  `audio routing helpers`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for microphone overlays, STT sidecars, and virtual audio device helpers
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist spanning dashboard mic control, multi-output STT, and lower-level routing substrate

## Work package B: Local source acquisition

- `Done` Confirm `OpenVR-MicrophoneControl` in local cache
- `Done` Confirm `VRCTextboxSTT` in local cache
- `Done` Confirm `Virtual-Audio-Driver` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect dashboard overlay, manifest, and Windows audio-manager split in `OpenVR-MicrophoneControl`
- `Done` Inspect transcription, OSC, overlay, websocket, and browser fan-out in `VRCTextboxSTT`
- `Done` Inspect adapter, topology, and WaveRT endpoint structure in `Virtual-Audio-Driver`

## Work package D: Repository updates

- `Done` Add Wave 80 plan document
- `Done` Add Wave 80 backlog document
- `Done` Add Wave 80 synthesis document
- `Done` Update the project registry for audio-control and routing helpers
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new audio-control patterns
- `Done` Update documentation indexes to include Wave 80

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `Virtual-Audio-Driver` visible whenever `VR-apps-lab` needs a `virtual routing substrate` comparison
- `Next` Keep `VRCTextboxSTT` visible whenever a future pass needs a `voice input -> many outputs` donor
- `Next` Keep `OpenVR-MicrophoneControl` visible as a `dashboard mic-state and PTT` reference rather than only as an accessibility note
