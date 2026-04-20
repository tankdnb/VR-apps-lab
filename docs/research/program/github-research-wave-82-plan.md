# GitHub Research Wave 82 Plan

- Date: `2026-04-20`
- Goal: run the next focused GitHub research wave for repositories that map
  `spatial audio SDKs`, `renderers`, and `object-optimization toolchains`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of overlays, runtime tooling, and
media surfaces, but it still lacked a clearer answer to:

`what reusable audio-engine patterns exist below the UI layer when the problem is spatialization, ambisonics, object rendering, or object-budget optimization`.

This wave exists to make that branch explicit.

## Search scope

Primary search directions for this wave:

- Unity or engine spatializer plugins;
- libraries that unify HOA, binaural, object, or speaker rendering;
- browser ambisonic decoders;
- spatial-audio optimization plugins that reduce object count without throwing
  away spatial meaning.

## Frozen shortlist for code-level study

- `microsoft/spatialaudio-unity`
- `videolabs/libspatialaudio`
- `GoogleChrome/omnitone`
- `VoidXH/Cavern`
- `carbonengine/spatial-audio-clustering`

## Secondary candidates surfaced in the same wave

These candidates were useful for context, but the main shortlist already
covered the stronger donor boundaries:

- `resonance-audio-web-sdk`
- `Songbird`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for spatializer plugins, ambisonic renderers, and
  object-optimization repos;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose reusable API and DSP boundaries instead of only
  documentation or marketing framing.

### Step 2: Freeze the shortlist

- keep the wave centered on `audio substrate`, not creator-side reactive tools;
- allow both focused plugins and broad frameworks when they teach different
  rendering boundaries.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how renderers or plugins model sources, listeners, objects, or ambisonic
  channels;
- where backend or platform-specific DSP boundaries live;
- whether optimization happens at the signal layer, object layer, or output
  layout layer;
- whether the repo is strongest as a direct code donor, architecture
  reference, or product reference.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 82 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- general spatial-audio frameworks are described honestly when they are
  broader than VR but still donor-worthy;
- the object-optimization plugin is positioned as `XR-adjacent audio
  substrate`, not a VR UI tool;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 82 synthesis document exists with code-level findings;
4. the registry and families represent spatial-audio donors more clearly;
5. new methods are captured where this wave clarified reusable audio-engine
   patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
