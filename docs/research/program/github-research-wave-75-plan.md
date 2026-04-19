# GitHub Research Wave 75 Plan

- Date: `2026-04-20`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `OpenXR micro-layers`, `view shaping`, `streamout`,
  `debugging capture`, and `frame-time intervention`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of OpenXR templates, runtime
switchers, and larger utility platforms, but it still lacked a sharper map of
the
`small operator-facing or developer-facing API layers`
that patch one narrow runtime behavior exceptionally well.

This wave exists to make several donor branches explicit:

- per-app recenter and view-shaping layers;
- crop or FOV layers with bootstrapped settings;
- frame-streamout layers that bridge rendered output outward;
- developer-tool bridge layers for capture or inspection;
- heavier intervention layers that decompose frame processing into stages.

## Search scope

Primary search directions for this wave:

- OpenXR micro-layers with one clear runtime patch or control surface;
- per-app configuration layers;
- stream-out or capture-related API layers;
- debug-tool integration layers;
- ambitious frame-intervention layers that are still architecturally readable.

## Frozen shortlist for code-level study

- `rublev/OpenXR-RecenterOverride`
- `mledour/OpenXR-Layer-crop-fov`
- `haraldsteinlechner/openxr_streamout_layer`
- `rAzoR8/openxr-renderdoc-layer`
- `fzeruhn/Smoothing-OpenXR-Layer`

## Secondary candidates surfaced in the same wave

No additional genuinely new candidates survived deduplication strongly enough
to justify widening this wave.

## Execution model

### Step 1: Search and deduplicate

- search GitHub for OpenXR micro-layers, stream-out layers, and per-app patch
  layers;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose narrow, reusable layer patterns rather than only a
  generic layer template.

### Step 2: Freeze the shortlist

- keep the wave centered on `small but strong runtime interventions`;
- allow one heavier repo when it exposes a reusable decomposition for advanced
  frame processing.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how the layer discovers application identity and config;
- where it hooks session, swapchain, view, or frame-lifecycle functions;
- whether it feeds external tools, transport layers, or staged compute
  pipelines;
- whether the repo is strongest as a code donor, an operator reference, or a
  research architecture reference.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 75 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- per-app operator layers stay distinct from generic templates;
- developer-tool bridge layers stay distinct from broader utility platforms;
- heavier intervention repos are described honestly where study depth remains
  bounded;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 75 synthesis document exists with code-level findings;
4. the registry and families represent these OpenXR micro-layer donors more
   clearly;
5. new methods are captured where this wave clarified reusable patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
