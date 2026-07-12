# GitHub Research Wave 338 Backlog - Browser VR Video Players, Projection Modes, and In-Headset Media Libraries

## Executed Scope

- Searched and deduplicated browser VR video/player candidates against earlier
  WebXR/media waves.
- Froze a three-project shortlist covering a modern WebXR player, a mature
  embeddable 360 player, and a full in-headset media-library player.
- Read source and documentation statically from local-only cache.
- Extracted layout enums, frame-aware texture upload, auto-detection, HLS/source
  embedding, CORS/HTTPS caveats, JSON media catalogs, VR file browser panels,
  draggable controls, controller shortcuts, and projection switching.

## Studied Projects

- `TimoWilhelm/vr-player`
- `Bivrost/360WebPlayer`
- `michal-repo/web_vr_video_player`

## Backlog Findings

- Treat projection/layout metadata as a reusable method independent from player
  UI.
- Preserve file/source picking and catalog generation as separate companion
  concerns.
- Reuse in-headset media-library UX concepts carefully; browser VR media apps
  have strong CORS/HTTPS/browser support constraints.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include studied projects.
- Method catalog captures projection-aware browser media surface.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
