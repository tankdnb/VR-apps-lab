# GitHub Research Wave 81 Plan

- Date: `2026-04-20`
- Goal: run the next focused GitHub research wave for repositories that map
  `immersive music players`, `VR media playback surfaces`, and
  `browser-backed or engine-backed video shells`.

## Why this wave exists

`VR-apps-lab` already had overlay media surfaces and launcher overlays, but it
still lacked a clearer answer to:

`what reusable patterns exist when media playback itself becomes the main VR utility rather than one feature inside a broader overlay host`.

This wave exists to make that branch explicit.

## Search scope

Primary search directions for this wave:

- VR-native music players;
- headset-aware immersive media shells;
- WebXR video-player repos with explicit projection logic;
- engine-side media playback frameworks that already expose 360 or immersive
  playback patterns.

## Frozen shortlist for code-level study

- `JustinLin905/around-sound`
- `BIVROST/360PlayerWindows`
- `VR-cam/WebXR-video-player`
- `videolan/vlc-unity`

## Secondary candidates surfaced in the same wave

These candidates already overlapped strongly with the tracked overlay-media
branch, so they were kept as comparison context instead of widening this wave:

- `Mon-Ouie/vr-video-player-overlay`
- `iigomaru/MPVR`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VR music players, immersive media shells, and WebXR video
  shells;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose reusable playback, projection, or headset backend
  splits.

### Step 2: Freeze the shortlist

- keep the wave centered on `playback architecture`, not just content viewers;
- allow both apps and frameworks when they teach different media-host
  boundaries.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how local files, URLs, streams, or media libraries are ingested;
- where playback state, backend selection, and headset integration live;
- how projection logic, UI surfaces, or speaker topology are modeled;
- whether the repo is strongest as a product reference, code donor, or
  framework substrate.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 81 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- immersive media apps stay distinct from general overlay hosts;
- engine media frameworks are described honestly when they are stronger as
  substrate than as end-user product references;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 81 synthesis document exists with code-level findings;
4. the registry and families represent immersive media donors more clearly;
5. new methods are captured where this wave clarified reusable playback
   patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
