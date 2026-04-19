# GitHub Research Wave 71 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `OpenVR driver learning paths`, `synthetic devices`, and
  `remote-input ingress`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for OpenVR driver tutorials, synthetic-device baselines, and remote-ingress experiments
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans a full tutorial shell, a narrow locomotion driver, HMD-relative synthetic controllers, a DIY HMD, a file-backed remote-ingress experiment, and a tracking-override example

## Work package B: Local source acquisition

- `Done` Confirm `Simple-OpenVR-Driver-Tutorial` in local cache
- `Done` Confirm `openvr-driver-example` in local cache
- `Done` Confirm `Barebone` in local cache
- `Done` Confirm `OpenVR-ArduinoHMD` in local cache
- `Done` Confirm `RemoteVVR` in local cache
- `Done` Confirm `OpenVR-Tracker-Driver-Example` in local cache
- `Done` Keep treadmill-style variants as comparison nodes only
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect central provider and reusable device-class patterns in `Simple-OpenVR-Driver-Tutorial`
- `Done` Inspect controller scalar-component setup in `openvr-driver-example`
- `Done` Inspect HMD-relative controller placement and gamepad handling in `Barebone`
- `Done` Inspect serial IMU ingest and config-defined display model in `OpenVR-ArduinoHMD`
- `Done` Inspect file-backed and browser-fed remote-input flow in `RemoteVVR`
- `Done` Inspect generic tracker plus tracking-override flow in `OpenVR-Tracker-Driver-Example`

## Work package D: Repository updates

- `Done` Add Wave 71 plan document
- `Done` Add Wave 71 backlog document
- `Done` Add Wave 71 synthesis document
- `Done` Update the project registry for lower-bound driver donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up nodes changed
- `Done` Update the methods catalog with new tutorial, DIY HMD, and remote-ingress patterns
- `Done` Update documentation indexes to include Wave 71

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `Simple-OpenVR-Driver-Tutorial` visible whenever a future branch needs a stronger `tutorial-grade central driver shell`
- `Next` Keep `openvr-driver-example` visible whenever `VR-apps-lab` needs a narrower `external locomotion input -> controller component` donor
- `Next` Keep `RemoteVVR` visible as a rough but useful `browser or file-fed synthetic VR driver` comparison
- `Next` Keep `OpenVR-Tracker-Driver-Example` visible whenever a future branch needs a `tracking-override generic tracker` reference
