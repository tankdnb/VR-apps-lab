# GitHub Research Wave 127 Plan

- Date: `2026-06-05`
- Goal: study browser-native WebXR utilities for creative tools, stereo media,
  diagnostics, audio/biometric visualization, and data dashboards.

## Why this wave exists

Browser-native WebXR can deliver small utility surfaces without native overlay
drivers. The useful lessons are in input mapping, hand menus, gaze/pinch detail
panels, local media conversion, diagnostic patterns, and real-time data
visualization.

## Search scope

Primary search directions:

- WebXR creative tools;
- hand/controller menu systems;
- spatial photo and stereo viewers;
- VR headset screen testers;
- WebXR audio, EEG, and data visualizers;
- WebXR 360/WebRTC streaming viewers.

## Frozen shortlist for code-level study

- `aframevr/a-painter`
- `leapmotion/LeapShape`
- `zfox23/spatial-photo-webxr-viewer`
- `ivanik7/vr-screen-tester`
- `kquizz/vr-visualizer-web`
- `Kineviz/OpenBCI-WebXR-EEG`
- `msitarzewski/prediction-space`
- `taplivenetwork/taplive-webxr`

## Execution model

### Step 1: Search and deduplicate

- search by WebXR creative, viewer, diagnostic, visualizer, EEG, and streaming
  families;
- deduplicate against existing WebXR samples, A-Frame, media, audio, and
  browser-shell waves.

### Step 2: Freeze the shortlist

- include creative, hand-menu, stereo media, diagnostics, audio visualizer,
  biometric point cloud, data dashboard, and streaming-reference examples.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- input mapping, controller, hand, gaze, and pinch UX;
- media conversion and per-eye rendering;
- diagnostic pattern surfaces;
- stream/data server boundaries;
- WebXR render loop and panel placement.

### Step 5: Promote findings into repository structure

Update Wave 127 landscape, registry, families, methods, backlog, and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- source-less projects are labelled honestly.

## Definition of done

This wave is complete when browser-native utility-surface patterns are
documented and placed in the canonical research system.
