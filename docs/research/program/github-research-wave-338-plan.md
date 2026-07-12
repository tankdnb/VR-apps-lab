# GitHub Research Wave 338 Plan - Browser VR Video Players, Projection Modes, and In-Headset Media Libraries

## Goal

Study browser-based VR video players that expose reusable patterns for 180/360,
stereo layouts, projection switching, file/source selection, and in-headset
media-library UX.

## Research Questions

- How do browser VR players represent mono, side-by-side, top-bottom, 180, 360,
  fisheye, and screen modes?
- Which UI patterns make local media libraries usable inside VR?
- What should future media-surface utilities reuse from video players without
  copying full apps?

## Shortlist

- `TimoWilhelm/vr-player`
- `Bivrost/360WebPlayer`
- `michal-repo/web_vr_video_player`

## Required Checks

- Deduplicate against earlier videojs, WebXR video, and browser media waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.

## Expected Outputs

- Landscape synthesis for Wave 338.
- Registry/family entries for browser VR media surfaces.
- Method catalog entry for projection-aware browser VR media surface.
