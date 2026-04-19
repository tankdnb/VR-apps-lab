# GitHub Research Wave 72 Plan

- Date: `2026-04-20`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `OpenVR overlay access layers`, `starter variants`, and
  `minimal shell experiments`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of overlay products, dashboards, and
template repos, but it still lacked a cleaner map of the
`lower-bound overlay implementation layer`
between full utility apps and raw API bindings.

This wave exists to make several donor branches explicit:

- overlay-focused OpenVR access layers;
- tiny dashboard overlay bootstraps;
- early architecture-sketch shells for static and window overlays;
- desktop-window control shells over shared overlay backends.

## Search scope

Primary search directions for this wave:

- OpenVR overlay wrappers or focused binding layers;
- very small dashboard overlay starters;
- C++ or C# overlay-shell experiments;
- managed overlay backends that separate desktop UI from runtime ownership.

## Frozen shortlist for code-level study

- `TheButlah/ovr_overlay`
- `ViveIsAwesome/OpenVROverlayTest`
- `scudzey/UniversalVROverlay`
- `albrt-vr/OpenVR.ALBRT.overlay`

## Secondary candidates surfaced in the same wave

No additional genuinely new candidates survived deduplication strongly enough
to justify widening this wave.

## Execution model

### Step 1: Search and deduplicate

- search GitHub for overlay wrappers, starter repos, and small shell variants;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose overlay ownership, lifecycle, and shell boundaries
  more clearly than larger user-facing products.

### Step 2: Freeze the shortlist

- keep the wave centered on `overlay implementation baselines`, not broader
  dashboard products;
- allow both thin lower-bound samples and richer managed-shell repos when they
  teach different implementation boundaries.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how OpenVR is initialized and owned;
- whether overlay creation is wrapped or kept explicit;
- how textures, files, events, and desktop UI are routed into the overlay
  runtime;
- whether the repo is strongest as a code donor, a product reference, or a
  minimal lower-bound starter.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 72 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- overlay wrappers stay distinct from overlay hosts and dashboards;
- thin starter repos are described honestly instead of overstated;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 72 synthesis document exists with code-level findings;
4. the registry and families represent these overlay starter donors more
   clearly;
5. new methods are captured where this wave clarified reusable patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
