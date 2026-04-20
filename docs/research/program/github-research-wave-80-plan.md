# GitHub Research Wave 80 Plan

- Date: `2026-04-20`
- Goal: run the next focused GitHub research wave for repositories that help
  map `microphone control overlays`, `voice-input pipelines`, and
  `audio routing helpers`.

## Why this wave exists

`VR-apps-lab` already had isolated references for captions, mic-state overlays,
and media surfaces, but it still lacked a clearer answer to:

`what the best VR-adjacent audio utility patterns look like when the problem is microphone state, transcription fan-out, or routing substrate`.

This wave exists to make that family explicit.

## Search scope

Primary search directions for this wave:

- SteamVR or OpenVR microphone overlays and push-to-talk tools;
- VRChat-oriented speech-to-text sidecars;
- virtual audio device layers that could act as routing substrate for VR voice
  or streaming helpers;
- smaller audio-control tools that sit between OS endpoints and VR utility UX.

## Frozen shortlist for code-level study

- `matzman666/OpenVR-MicrophoneControl`
- `I5UCC/VRCTextboxSTT`
- `VirtualDrivers/Virtual-Audio-Driver`

## Secondary candidates surfaced in the same wave

These candidates overlapped strongly with already-tracked directions and were
kept as comparison context rather than widening the wave:

- `Dragon092/OpenVR_Audio_Manager`
- `rrazgriz/VRCMicOverlay`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for microphone overlays, STT sidecars, and virtual-audio
  routing layers;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose reusable control-plane or routing patterns, not only
  end-user screenshots.

### Step 2: Freeze the shortlist

- keep the wave centered on `voice control and routing`, not general media
  players;
- allow both VR-facing shells and lower-level routing substrate repos when they
  teach different boundaries.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where overlay UX, STT pipeline, or device-routing logic actually lives;
- how audio endpoint state, microphone status, or transcription output is
  exposed to the rest of the app;
- whether the repo is strongest as a code donor, a product reference, or a
  substrate reference.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 80 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- voice-input tools stay distinct from general accessibility overlays;
- OS-level routing substrate is described honestly as `VR-adjacent` rather than
  VR-native;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 80 synthesis document exists with code-level findings;
4. the registry and families represent voice-control and routing donors more
   clearly;
5. new methods are captured where this wave clarified reusable patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
