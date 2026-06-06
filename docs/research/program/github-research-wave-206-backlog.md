# GitHub Research Wave 206 Backlog

- Date: `2026-06-06`
- Theme: `Godot XR addon periphery: hands, tracker bridges, recording, and reference plugin baselines`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for Godot XR hand, pickup, tracker, recorder, toolkit,
  and reference plugin addons.
- `Done` Dedupe against earlier Godot XR templates, OpenXR vendors, function
  nodes, and `GodotXRDesktop` coverage.
- `Done` Freeze a shortlist spanning hand interaction, vendor trackers,
  recorder, reference plugin, and toolkit v2 roles.

## Source Sync

- `Done` Confirm `godot-xr-kit` in local-only cache.
- `Done` Confirm `godot_xr_handtracking` in local-only cache.
- `Done` Confirm `GodotXRVmcTracker` in local-only cache.
- `Done` Confirm `GodotXRAxisStudioTracker` in local-only cache.
- `Done` Confirm `GodotXRRokokoTracker` in local-only cache.
- `Done` Confirm `GodotXROpenXRTracker` in local-only cache.
- `Done` Confirm `GodotXRAnimationRecorder` in local-only cache.
- `Done` Confirm `godot_xr_reference` in local-only cache.
- `Done` Confirm `godot-xr-tools2` in local-only cache.

## Code Reading

- `Done` Inspect hand-pose template loading, quaternion comparison,
  thresholding, timer-based recognition, and pose-change events in
  `godot-xr-kit`.
- `Done` Inspect pose catalog matching, stabilization, pose-gated pick areas,
  hand snap lookup, ranged/touch/pose-change pickup modes, and configuration
  warnings in `godot_xr_handtracking`.
- `Done` Inspect OSC packet parsing, VMC bone/blend paths, body/face tracker
  registration, position modes, joint transforms, root handling, and confidence
  flags in `GodotXRVmcTracker`.
- `Done` Inspect Axis Studio and Rokoko source plugins as vendor tracker
  bridge variants with the same Godot XRServer output boundary.
- `Done` Inspect OpenXR tracker demo setup and world-scale/controller controls
  in `GodotXROpenXRTracker`.
- `Done` Inspect tracker stream capture, skeleton/face blendshape animation
  tracks, root motion, timing, and optimization in `GodotXRAnimationRecorder`.
- `Done` Inspect native `XRInterface` reference plugin lifecycle, properties,
  reference-space transforms, projections, and head tracker registration in
  `godot_xr_reference`.
- `Done` Inspect `godot-xr-tools2` teleport function, hand attachment pattern,
  movement-provider disable, fade tween, ray/arc target, collision and slope
  checks.

## Integration

- `Done` Create Wave 206 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for Godot tracker bridges, recording, and
  toolkit primitives.
- `Next` Build a Godot XR addon matrix across hand pose, pickup, tracker source,
  recorder, toolkit node, and native interface layers.
