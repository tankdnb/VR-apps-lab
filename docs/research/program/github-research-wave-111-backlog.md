# GitHub Research Wave 111 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on `no-HMD`, `virtual-HMD`,
  `phone-HMD`, and `controllable null-driver` workflows.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for phone VR, fake HMD, no-HMD OpenVR, null driver, and
  controllable virtual-device repositories
- `Done` Deduplicate surfaced repositories against registry and families
- `Done` Freeze a bounded shortlist spanning phone bridge, desktop display
  driver, controller/tracker fake-HMD driver, ZMQ-controlled harness, and
  keyboard/mouse fake rig

## Work package B: Local source acquisition

- `Done` Confirm `PhoneVR` in local cache
- `Done` Confirm `driver_hmd` in local cache
- `Done` Confirm `faceless` in local cache
- `Done` Confirm `OpenVRsim` in local cache
- `Done` Confirm `Pepper` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect PhoneVR OpenVR driver, TCP pairing, projection exchange,
  virtual display present path, pose stream, Android ALVR/Cardboard path, and
  latency diagnostics
- `Done` Inspect driver_hmd HMD display component, desktop display flags,
  keyboard transform controls, debug transform request, pose update loop, and
  config fields
- `Done` Inspect faceless fake HMD display component, controller/tracker pose
  inference, calibration keybinds, settings persistence, and no-HMD caveats
- `Done` Inspect OpenVRsim sample driver, ZMQ command server, Python controller,
  pose/button command vocabulary, test-case CSV model, and optional eye data
  path
- `Done` Inspect Pepper provider, fake HMD, fake controllers, keyboard/mouse
  input state, controller component handles, and tutorial-oriented driver
  framing

## Work package D: Repository updates

- `Done` Add Wave 111 plan document
- `Done` Add Wave 111 backlog document
- `Done` Add Wave 111 synthesis document
- `Done` Update the project registry for no-HMD, phone-HMD, and controllable
  driver-stub donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with phone-HMD, display component,
  external control harness, and fake-rig methods
- `Done` Update documentation indexes to include Wave 111

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare OpenVRsim with capture/replay and automated test harness
  references whenever VR regression testing becomes a product branch
- `Next` Revisit PhoneVR only as architecture history unless a phone-HMD or
  streaming bridge pass needs deeper ALVR comparison
- `Next` Compare faceless, driver_hmd, and Pepper as minimum viable fake-HMD
  surfaces before building any local no-HMD helper prototype
