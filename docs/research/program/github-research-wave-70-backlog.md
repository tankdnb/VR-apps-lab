# GitHub Research Wave 70 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `mixed-VR controller bridges`, `hand emulation`, and
  `external-tracker interop`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for mixed-VR controller bridges, OpenHMD interop variants, and hand-emulation drivers
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans strong bridges, an IPC-driven synthetic controller host, a hand-tracking emulator, and thinner comparison nodes

## Work package B: Local source acquisition

- `Done` Confirm `Oculus_Touch_Steam_Link` in local cache
- `Done` Confirm `SteamVR-OpenHMD` in local cache
- `Done` Confirm `Yet-Another-OpenVR-IPC-Driver` in local cache
- `Done` Confirm `Quest-Link-Hand-Tracking` in local cache
- `Done` Confirm `PSVR-SteamVR-openHMD` in local cache
- `Done` Confirm `VirtualDesktop-OpenVR-Trackers` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect controller-profile reuse and mixed-runtime packaging in `Oculus_Touch_Steam_Link`
- `Done` Inspect OpenHMD device mapping and controller property setup in `SteamVR-OpenHMD`
- `Done` Inspect command grammar, smoothing hooks, and controller state model in `Yet-Another-OpenVR-IPC-Driver`
- `Done` Inspect current public gesture-config structure in `Quest-Link-Hand-Tracking`
- `Done` Inspect PSVR-specific modifications and overlap with the main OpenHMD bridge in `PSVR-SteamVR-openHMD`
- `Done` Inspect the current public tracker-bridge surface in `VirtualDesktop-OpenVR-Trackers`

## Work package D: Repository updates

- `Done` Add Wave 70 plan document
- `Done` Add Wave 70 backlog document
- `Done` Add Wave 70 synthesis document
- `Done` Update the project registry for mixed-VR bridge donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up nodes changed
- `Done` Update the methods catalog with new mixed-VR controller and hand-emulation patterns
- `Done` Update documentation indexes to include Wave 70

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `Yet-Another-OpenVR-IPC-Driver` visible whenever a future branch needs a stronger `external-command synthetic controller` donor
- `Next` Keep `Oculus_Touch_Steam_Link` and `SteamVR-OpenHMD` visible whenever `VR-apps-lab` needs a `foreign runtime reusing native controller profiles` reference
- `Next` Revisit `Quest-Link-Hand-Tracking` only if the public driver source grows beyond the current thin placeholder state
- `Next` Revisit `VirtualDesktop-OpenVR-Trackers` only if its public repo exposes a clearer data-ingress or tracker-role mapping layer
