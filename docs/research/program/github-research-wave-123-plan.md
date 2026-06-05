# GitHub Research Wave 123 Plan

- Date: `2026-06-05`
- Goal: study mixed-reality capture and presenter-compositing helpers for
  WebXR, Vision Pro, Oculus/Quest MRC, Unity XR Interaction Toolkit, and
  browser-based artificial green-screen workflows.

## Why this wave exists

Mixed-reality capture projects sit near overlays and display surfaces but solve
a different utility problem: align an external camera with a virtual scene,
split foreground/background layers, handle chroma/segmentation, stream or
decode video payloads, and provide calibration UX.

This wave adds capture/compositing references without turning `VR-apps-lab`
into a media player or OBS plugin.

## Search scope

Primary search directions for this wave:

- WebXR/Three.js mixed reality capture modules;
- Apple Vision Pro/iPhone capture and streaming helpers;
- Oculus/Quest MRC client utilities;
- Unity XR Interaction Toolkit MRC helpers;
- browser AI green-screen or segmentation utilities for capture workflows.

## Frozen shortlist for code-level study

- `fabio914/reality-mixer-js`
- `fabio914/RealityMixerVisionPro`
- `jonathanperret/mrc-client`
- `zengmmm00/MixedRealityCapture`
- `TonyViT/MrcXrtHelpers`
- `smaerdlatigid/ArtificialGreenScreen`

Rejected/empty reference:

- `LIV/CalibrationForQuest` cloned as an empty repository and was not promoted
  as a studied donor.

## Execution model

### Step 1: Search and deduplicate

- search GitHub by mixed reality capture, WebXR MRC, Reality Mixer, Oculus MRC,
  Quest MRC, LIV calibration, and artificial green-screen families;
- deduplicate against registry and family docs;
- reject empty or source-less candidates honestly.

### Step 2: Freeze the shortlist

- include browser WebXR compositor, Vision Pro capture stack, Oculus MRC TCP
  client, Quest MRC placeholder/reference, Unity XRT helpers, and browser
  segmentation/green-screen utility.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- camera calibration schema and setup flow;
- foreground/background render target split;
- chroma key or segmentation model;
- TCP/video payload protocol and decoder/encoder boundaries;
- external camera intrinsics/extrinsics handling;
- Unity/OVR camera helper behavior;
- caveats around prototypes, private APIs, and missing source.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 123 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- capture projects are documented as compositing references, not as runnable
  repo dependencies;
- empty/source-less repos are labelled honestly;
- found projects are not built, launched, or installed;
- `.research-sources/` remains local-only;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in local cache;
3. a Wave 123 synthesis document exists with code-level findings;
4. registry and families represent capture/compositing helpers clearly;
5. methods capture calibration, layer split, mobile-camera streaming, MRC
   camera helpers, and AI green-screen patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
