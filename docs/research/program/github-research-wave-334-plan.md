# GitHub Research Wave 334 Plan - Godot XR Hand Poses, Spatial Entities, Wrist UI, and Android Surface Bridges

## Goal

Study Godot XR projects that expose reusable interaction and surface patterns:
hand pose detection, auto hand tracking, radial menus, spatial entities,
persistent anchors, wrist UI, Android surface composition layers, and Android
plugin boundaries.

## Research Questions

- How do Godot projects separate OpenXR tracker data, gesture state, menu
  selection, and scene objects?
- What can be reused for VR utility menus, wrist control panels, and in-headset
  diagnostics?
- Where are Android surface/plugin boundaries useful for media and notification
  utilities?

## Shortlist

- `Malcolmnixon/GodotXRHandPoseDetector`
- `Godot-Dojo/Godot-XR-AH`
- `BastiaanOlij/spatial-entities-demo`
- `GodotVR/godot-openxr-android-surface-plugin-example`
- `yelrom0/godot-openxr-notification-handler-plugin`

## Required Checks

- Deduplicate against Godot XR template, desktop, tracker, and vendor waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.
- Mark template-derived Android plugin repos and unfinished notification
  plugin code clearly.

## Expected Outputs

- Landscape synthesis for Wave 334.
- Registry/family entries for studied projects.
- Method catalog entry for Godot XR gesture/menu/surface bridge boundaries.
