# GitHub Research Wave 145 Plan

- Date: `2026-06-05`
- Goal: study immersive video players, stereo/360 projection controls, local
  media loading, and VR video UI surfaces as reusable media utility patterns.

## Why this wave exists

Previous media waves covered VR players, panoramic viewers, VRChat video
systems, and nonstandard 3D video. This wave adds newer browser/WebXR and
Vision Pro-oriented references that make projection, stereo layout, local file
loading, and in-headset playback controls explicit.

## Search scope

Primary search directions:

- WebXR video players;
- VR180 and stereoscopic A-Frame players;
- single-file 360 image/video viewers;
- desktop-packaged local 360 video players;
- Apple Vision Pro immersive/spatial video players.

## Frozen shortlist for code-level study

- `greggman/webxr-video`
- `brandynbuchanan/VR180-video-player`
- `ProGamerGov/html-360-viewer`
- `thehancode/360-video-player`
- `acuteimmersive/openimmersive`

## Execution model

### Step 1: Search and deduplicate

- search by WebXR video player, VR180 player, 360 video viewer, stereoscopic
  video, local 360 player, and Vision Pro immersive video families;
- deduplicate against previous video/player waves and known `VR-cam` /
  `BIVROST` entries.

### Step 2: Freeze the shortlist

- include one WebXR renderer-heavy player, one minimal VR180 example, one
  one-file web viewer, one desktop-packaged local player, and one Vision Pro
  spatial/immersive player.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/`;
- keep all source clones local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- video element and texture flow;
- layout, projection, and stereo controls;
- WebXR layers, WebGL/WebGPU renderer split, and in-XR UI texture projection;
- local file and drag/drop workflows;
- Vision Pro projection/frame-packing option model;
- caveats around CORS, browser autoplay, and format support.

### Step 5: Promote findings into repository structure

Update Wave 145 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when immersive video playback is documented as a
projection-aware utility surface, not just as another content-player category.
