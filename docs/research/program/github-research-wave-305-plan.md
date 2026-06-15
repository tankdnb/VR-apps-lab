# GitHub Research Wave 305 Plan - VR Wayfinding, Navigation Guidance, and Spatial Navigation Study Tasks

## Goal

Study VR wayfinding, navigation guidance, spatial navigation, haptic boundary,
and cybersickness comfort projects as reusable references for target state,
gaze-to-destination movement, agent advice, room transitions, comfort aids, and
navigation telemetry.

## Research Questions

- How do projects represent active targets, route progression, and room
  transitions?
- Which movement adapters are reusable for gaze-to-NavMesh, target sequencing,
  and guided navigation?
- How are NPC/agent hints, haptics, and comfort interventions kept separate
  from experiment logic?
- Which logs make navigation decisions reconstructable after a session?

## Shortlist

- `pepwuper/Google-Cardboard-VR-Navigation`
- `npresearchlab/NavCity_Toolkit`
- `zcbtmfc/Wayfinding-Task`
- `maxleblanc/sightless-vr`
- `angsamuel/GingerVR`

## Required Checks

- Deduplicate against earlier locomotion, comfort, training, and spatial-study
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep source-light, global-state, logging-path, comfort, and haptic safety
  caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 305.
- Registry/family entries for VR wayfinding and spatial navigation tasks.
- Method catalog entry for navigation-study boundaries.
- Follow-up gaps around wayfinding task scripts, haptic/no-HMD navigation, and
  comfort/navigation matrices.
