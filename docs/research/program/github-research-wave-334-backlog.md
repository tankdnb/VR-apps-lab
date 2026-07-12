# GitHub Research Wave 334 Backlog - Godot XR Hand Poses, Spatial Entities, Wrist UI, and Android Surface Bridges

## Executed Scope

- Searched and deduplicated Godot XR interaction/surface projects.
- Froze a five-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted hand pose resources, fitness functions, pose hold/release timing,
  auto hand tracker skeleton mapping, controller-to-hand fallback, radial menu
  ray selection, spatial entity manager lifecycle, persistent UUID to scene
  mapping, wrist SubViewport input injection, Android surface composition layer
  bridge, and unfinished Android notification plugin caveats.

## Studied Projects

- `Malcolmnixon/GodotXRHandPoseDetector`
- `Godot-Dojo/Godot-XR-AH`
- `BastiaanOlij/spatial-entities-demo`
- `GodotVR/godot-openxr-android-surface-plugin-example`
- `yelrom0/godot-openxr-notification-handler-plugin`

## Backlog Findings

- Treat hand-pose resources plus hold/release timing as a strong reusable
  gesture recognizer pattern.
- Treat radial menu and wrist UI as high-value VR utility control surfaces.
- Treat Android surface composition as a media/surface bridge pattern.
- Keep the notification plugin as a low-maturity follow-up only; current source
  still looks close to the Godot Android plugin template.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog captures Godot XR gesture/menu/surface bridge boundaries.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
