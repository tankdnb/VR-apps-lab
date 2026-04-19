# GitHub Research Wave 61 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `managed-language overlay starters`, `UIToolkit templates`, and
  `higher-level scaffolds`.

## Why this wave exists

The previous overlay waves clarified native hosts and low-level construction,
but another adjacent branch still needed a cleaner donor map:

- managed-language overlays that keep `OpenVR` explicit without dropping to
  raw `C++`;
- Unity-side templates that bridge overlay events into a real UI framework;
- higher-level overlay shells that combine texture upload, controller
  anchoring, and app-specific services.

This wave exists to make
`managed-language overlay starters, UIToolkit templates, and higher-level scaffolds`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- Unity or C# overlay templates with reusable event or lifecycle boundaries;
- managed-language overlay hosts that expose GPU interop or controller
  anchoring clearly;
- app-specific higher-level overlay repos that are still valuable as scaffold
  or lineage donors.

## Frozen shortlist for code-level study

- `someka-vrc/uitoko-ovr`
- `AanthonyRusso/BasicOverlay`
- `Spacefish/OpenVR-Overlay`
- `Daniel-Webster/WT-OpenVR-Overlay`

## Secondary candidates surfaced in the same wave

- `kurohuku7/zenn-overlay-tutorial`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for managed-language overlay starters and Unity overlay
  scaffolds;
- compare results against `catalog/project-registry.md`;
- reject repos that are only thin wrappers over already-tracked overlay hosts
  without clearer event, UI, or lifecycle lessons.

### Step 2: Freeze the shortlist

- keep the wave centered on `starter patterns` and `higher-level scaffolds`,
  not on all overlay products;
- allow app-specific repos when they expose a reusable UI, runtime, or service
  boundary.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how the overlay lifecycle is initialized and shut down;
- how input events reach the UI layer;
- how textures reach the compositor;
- whether the repo is strongest as a clean starter, a texture-interop donor, or
  an app-specific scaffold worth partially promoting.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 61 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies managed UI
  and starter patterns.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `starter templates` stay distinct from `app-specific overlay products`;
- the family clearly separates `UIToolkit event bridge`,
  `managed GPU interop host`, and `desktop-side content feeder`;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 61 synthesis document exists with code-level findings;
4. the registry and families clearly represent managed-language and higher-level
   overlay scaffolds;
5. new starter or UI-bridge methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
