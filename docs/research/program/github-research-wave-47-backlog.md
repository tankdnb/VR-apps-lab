# GitHub Research Wave 47 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `simulation telemetry overlays`, `motion-cueing bridges`, and
  `sim-sidecar platforms`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for telemetry overlays, force-feedback sidecars, motion-platform bridges, and VR-capable simulator stacks
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans overlay hosts, multi-instance force-feedback sidecars, telemetry normalization bridges, motion-platform ecosystems, and a research simulator stack

## Work package B: Local source acquisition

- `Done` Confirm `TinyPedal` in local cache
- `Done` Confirm `VPforce-TelemFFB` in local cache
- `Done` Confirm `SpaceMonkey` in local cache
- `Done` Confirm `SimFeedback-AC-Servo` in local cache
- `Done` Confirm `DReyeVR` in local cache
- `Done` Confirm `Unity-VRlines` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect overlay state, module control, and adapter boundaries in `TinyPedal`
- `Done` Inspect startup orchestration, IPC, and multi-device ownership in `VPforce-TelemFFB`
- `Done` Inspect telemetry outputs, MMF or UDP routing, and provider breadth in `SpaceMonkey`
- `Done` Inspect extension facade and telemetry-provider ecosystem in `SimFeedback-AC-Servo`
- `Done` Inspect VR ego-vehicle sensor and recorder or replayer boundaries in `DReyeVR`
- `Done` Inspect VR controller mapping and modular aircraft-control flow in `Unity-VRlines`

## Work package D: Repository updates

- `Done` Add Wave 47 plan document
- `Done` Add Wave 47 backlog document
- `Done` Add Wave 47 synthesis document
- `Done` Update the project registry for telemetry overlays and sim-sidecar platforms
- `Done` Update overlap families for overlay hosts, multi-instance device sidecars, telemetry normalizers, and research simulator stacks
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes
- `Done` Update the methods catalog with telemetry and simulator-sidecar methods
- `Done` Update documentation indexes to include Wave 47

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare `TinyPedal`, `VPforce-TelemFFB`, and `SpaceMonkey` directly as `overlay host`, `device-effect sidecar`, and `telemetry normalization bridge`
- `Next` Keep `DReyeVR` visible whenever a future branch needs a richer `simulator platform plus replay analytics` donor instead of a thin desktop sidecar
