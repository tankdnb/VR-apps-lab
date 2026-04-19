# GitHub Research Wave 50 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `XR-glasses workspace shells`, `OpenVR HMD paths`, and
  `head-tracked screen tools`.

## Why this wave exists

`VR-apps-lab` already had a good first pass on XR-glasses and spatial-screen
tools, but several important sub-branches still needed a second code-level pass:

- broader workspace shells layered over driver, compositor, and environment
  integrations;
- thin OpenVR HMD paths that graft glasses IMU data into a headset runtime;
- sidecars that export glasses head tracking into non-XR consumers;
- screen-transformation pipelines that complement driver-led special-display
  stacks.

This wave exists to make
`XR-glasses workspace shells, OpenVR HMD paths, and head-tracked screen tools`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- XR-glasses workspace shells and environment integrations;
- OpenVR HMD drivers for glasses or nonstandard special displays;
- head-tracking sidecars for glasses outside ordinary XR runtimes;
- screen-transformation tools for stereoscopic or head-tracked displays.

## Frozen shortlist for code-level study

- `wheaney/breezy-desktop`
- `lc700x/desktop2stereo`
- `wheaney/OpenVR-xrealAirGlassesHMD`
- `iVideoGameBoss/PhoenixHeadTracker`

## Secondary candidates surfaced in the same wave

- no extra candidate in this wave was stronger than the frozen shortlist

## Execution model

### Step 1: Search and deduplicate

- search GitHub for XR glasses, OpenVR HMD, head tracking, and spatial-screen
  utility repos;
- compare results against `catalog/project-registry.md`;
- reject repos that only duplicate generic virtual-display functionality
  without a clearer glasses-shell, HMD-driver, or tracking-sidecar lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `special-display workflows beyond generic virtual
  display drivers`;
- allow both platform-shell and thinner sidecar donors because the family
  benefits from both extremes.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where driver, compositor, workspace UX, and head-tracking boundaries sit;
- whether the repo is shell-first, OpenVR-device-first, sidecar-first, or
  screen-transformation-first;
- how capture, IMU data, or environment integration are routed.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 50 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies
  XR-glasses shell, OpenVR HMD, and head-tracked screen methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `XR glasses` stay distinct from generic virtual displays and ordinary overlay
  tools;
- the family clearly separates workspace shells, OpenVR HMD paths,
  head-tracking sidecars, and screen-transformation pipelines;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 50 synthesis document exists with code-level findings;
4. the registry and families clearly represent workspace shells, thin HMD
   drivers, and head-tracked screen utilities;
5. new special-display methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
