# GitHub Research Wave 83 Plan

- Date: `2026-04-20`
- Goal: run the next focused GitHub research wave for repositories that map
  `creator-facing audio systems`, `synced player frameworks`, and
  `world-side voice management`.

## Why this wave exists

`VR-apps-lab` already had many VRChat-side text, OSC, and overlay references,
but it still lacked a clearer answer to:

`what the strongest reusable audio and media systems look like inside creator ecosystems where syncing, world state, shader hooks, and user permissions all matter at once`.

This wave exists to make that branch explicit.

## Search scope

Primary search directions for this wave:

- audio-reactive creator frameworks;
- synced VRChat video players and queue companions;
- modular media frontends with multiple control or integration surfaces;
- world-side voice management and fake-occlusion systems.

## Frozen shortlist for code-level study

- `llealloo/audiolink`
- `MerlinVR/USharpVideo`
- `sam-ln/USharpVideoQueue`
- `JLChnToZ/VVMW`
- `SylanTroh/AudioManager`

## Secondary candidates surfaced in the same wave

These candidates overlapped strongly with already-tracked text or creator UI
families and were kept as context rather than widening the wave:

- `AudioLink-USharpVideo-Adapter`
- `VRCLiveCaptionsMod`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for creator audio frameworks, synced video players, and
  world-side voice-control systems;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose reusable sync, state, or integration boundaries.

### Step 2: Freeze the shortlist

- keep the wave centered on `creator-side audio and media systems`, not generic
  avatar assets;
- allow both core frameworks and companion systems when they teach different
  orchestration boundaries.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where audio-reactive, sync, queue, or permission state actually lives;
- how the repo splits core player logic from UI, backend, or integration
  helpers;
- whether the repo is strongest as a code donor, architecture reference, or
  creator-product reference.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 83 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- creator frameworks are described honestly when they are large ecosystems and
  not tiny donors;
- the distinction between `audio-reactive system`, `synced media player`, and
  `world voice manager` remains clear;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 83 synthesis document exists with code-level findings;
4. the registry and families represent creator-side audio and media donors more
   clearly;
5. new methods are captured where this wave clarified reusable creator-system
   patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
