# GitHub Research Wave 206 Plan

- Date: `2026-06-06`
- Theme: `Godot XR addon periphery: hands, tracker bridges, recording, and reference plugin baselines`
- Scope: Godot XR hand/pose addons, VMC/Rokoko/Axis/OpenXR tracker bridge
  plugins, animation/tracker recording, reference XRInterface plugin, and
  modular toolkit v2 components.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier Godot XR waves covered templates, OpenXR vendors, function nodes,
export paths, and broad toolkit families. Wave 206 focuses on the periphery
that turns Godot into a VR utility lab: hand-pose recognition, pose-gated
pickup, vendor tracker input, animation capture, and reference plugin
boundaries.

## Search Families

- Godot XR hand-tracking addons
- Godot hand-pose recognition and pickup tools
- Godot VMC, Rokoko, Axis Studio, and OpenXR tracker bridges
- Godot XR animation and tracker recorders
- Godot XR reference/plugin authoring baselines
- Godot XR toolkit v2 components

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `patrykkalinowski/godot-xr-kit` | Addon pack with hand pose recognition, physics movement, smoothing, and cinematic view | XR addon kit reference |
| `RevolNoom/godot_xr_handtracking` | Hand pose matcher, pose-gated pick areas, and hand snap contracts | Hand interaction donor |
| `Malcolmnixon/GodotXRVmcTracker` | OSC/VMC body and face tracker bridge into Godot XRServer | Strong tracker bridge donor |
| `Malcolmnixon/GodotXRAxisStudioTracker` | Axis Studio body tracker bridge into Godot XRServer | Vendor tracker bridge variant |
| `Malcolmnixon/GodotXRRokokoTracker` | Rokoko body/face/finger tracker bridge into Godot XRServer | Vendor tracker bridge variant |
| `Malcolmnixon/GodotXROpenXRTracker` | OpenXR tracker demo/reference for body/hand tracker scaling | Thin tracker reference |
| `Malcolmnixon/GodotXRAnimationRecorder` | Tracker streams and skeleton/blendshape animation recording | Strong recorder donor |
| `GodotVR/godot_xr_reference` | Reference XRInterface plugin for Godot extension authors | Runtime plugin baseline |
| `BastiaanOlij/godot-xr-tools2` | WIP toolkit v2 with movement, teleport, hands, UI, pickup, debug, and spectator nodes | Toolkit architecture donor |

## Dedupe Notes

- `GodotVR/godot-xr-tools` and `GodotVR/godot-xr-template` were already covered
  in earlier waves; this pass uses `godot-xr-tools2` as a newer toolkit-shape
  comparison node.
- `GodotXRDesktop` was already studied and explicitly excluded.
- Thin tracker demos are retained only when they clarify Godot XRServer
  contracts or tracker scaling behavior.

## Code-Level Pass Targets

- Hand-pose template matching, thresholds, skeleton access, and pose-change
  events.
- Pose-gated pickup areas, hand-snap contracts, and configuration warnings.
- OSC/VMC or vendor tracker source parsing into `XRBodyTracker`,
  `XRFaceTracker`, and hand/body joint maps.
- Position modes, root transform handling, calibration, and confidence flags.
- Animation recorder tracks for skeleton, face blendshapes, root motion, and
  tracker streams.
- Minimal native `XRInterface` plugin lifecycle and display/view transforms.
- Toolkit v2 teleport gating, movement provider disable, fade, and collision
  checks.

## Expected Outputs

- Wave 206 landscape synthesis.
- Registry/family placement for Godot XR addon periphery.
- Methods for Godot tracker-source bridges, tracker/animation recording, and
  modular XR toolkit primitives.
