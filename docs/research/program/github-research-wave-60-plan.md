# GitHub Research Wave 60 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `code-first overlay scaffolds`, `projection samples`, and
  `window-to-texture baselines`.

## Why this wave exists

`VR-apps-lab` already had stronger `overlay hosts`, `dashboard shells`, and
`higher-level scaffolds`, but a lower-level donor layer was still missing:

- tiny `OpenVR` overlay samples that show the absolute minimum
  `texture -> overlay` path;
- window-capture bridges that make `desktop or app window -> VR surface`
  explicit at code level;
- projection-overlay examples where frusta, eye transforms, and overlay math
  are explained honestly instead of hidden behind engine wrappers.

This wave exists to make
`code-first overlay scaffolds, projection samples, and window-to-texture baselines`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- small `C`, `C++`, Zig, or Python overlay repositories with visible
  `SetOverlayTexture` or `SetOverlayTransformProjection` usage;
- Linux or desktop-window capture overlays that pipe real window content into
  SteamVR;
- projection-overlay worked examples that explain transform direction and eye
  metadata instead of only exposing a finished demo.

## Frozen shortlist for code-level study

- `stevenjwheeler/OpenGL-VROverlay`
- `ChristophHaag/OpenVRWindowOverlay`
- `pfgithub/openvr-overlay-test`
- `hiinaspace/openvr-overlay-bunny`

## Secondary candidates surfaced in the same wave

- `Daniel-Webster/WT-OpenVR-Overlay`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for minimal overlay scaffolds, window-capture overlays, and
  projection samples;
- compare results against `catalog/project-registry.md`;
- reject repos that only repeat already-tracked high-level overlay hosts
  without adding a lower-level donor lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on low-level `overlay construction patterns`, not on
  broader overlay products;
- prefer code donors that expose transform setup, texture upload, and event
  flow directly.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- the exact API path from rendered pixels to `OpenVR` overlay submission;
- how the repo handles transform anchoring, eye-specific projection, or window
  capture;
- whether the repo is strongest as a minimal donor, an architecture reference,
  or a projection-math explainer.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 60 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies low-level
  overlay construction patterns.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `low-level overlay baselines` stay distinct from broader host frameworks;
- the family clearly separates `minimal texture-submit sample`,
  `window-capture bridge`, and `projection-overlay example`;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 60 synthesis document exists with code-level findings;
4. the registry and families clearly represent low-level overlay construction
   donors;
5. new overlay-baseline methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
