# GitHub Research Wave 146 Plan

- Date: `2026-06-05`
- Goal: study audio-reactive VR/WebXR surfaces, spatial/directional audio
  visualizers, and shader/audio pipelines as reusable sound-aware utility
  methods.

## Why this wave exists

Earlier audio waves covered microphone control, spatial audio SDKs, synced
players, and creator-facing audio systems. This wave narrows to the visual
side: how projects turn audio streams into VR scene state, shader uniforms,
frequency textures, and spatial feedback.

## Search scope

Primary search directions:

- WebXR audio visualizers;
- WebAudio analyser pipelines for AR/VR;
- VR music visualizers;
- shader/raymarch audio-reactive scenes;
- A-Frame music visualizer examples.

## Frozen shortlist for code-level study

- `shift/webxr-audio-visualizer`
- `Alex-DG/vite-three-webxr-audio-visualizer`
- `ConorStokes/boondoggle`
- `DranoelMit/seeSound`

## Execution model

### Step 1: Search and deduplicate

- search by WebXR audio visualizer, VR music visualizer, WebAudio VR, spatial
  audio WebXR, and raymarching visualizer families;
- deduplicate against previous audio player, spatial audio SDK, and browser
  video/media waves.

### Step 2: Freeze the shortlist

- include browser/WebXR, Three/WebXR, native Oculus/D3D, and A-Frame examples
  to compare small and heavier approaches.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/`;
- keep all source clones local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- WebAudio `AudioContext`, `AnalyserNode`, and FFT usage;
- stereo or directional analysis;
- audio feature normalization;
- shader uniform updates;
- audio texture/frequency bucket models;
- scene update loops and performance caveats;
- product framing for sound-aware VR utility surfaces.

### Step 5: Promote findings into repository structure

Update Wave 146 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when audio-reactive VR surfaces are documented as a
reusable signal pipeline: `audio input -> analysis -> normalized features ->
scene/shader response`.
