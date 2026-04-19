# GitHub Research Wave 34 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `tracked-device geometry`, `CAD-to-tracker workflows`, and
  `auxiliary tracker tooling`.

## Why this wave exists

The repository already contained tracker bridges, driver tutorials, and role
binding tools, but it still lacked a tighter family around
`physical tracked-device design`:

- reverse-engineered device geometry and sensor-layout knowledge;
- CAD or authoring tools that emit SteamVR tracker definitions;
- auxiliary tracker utilities that derive or configure tracked bodies rather
  than only ingesting OSC or network data.

This wave exists to make `tracked-device design and auxiliary tracker tooling`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- SteamVR tracked-device reverse engineering;
- CAD or authoring helpers for Lighthouse tracker geometry;
- synthetic or derived trackers with role-specific device registration;
- DIY tracker stacks that include firmware, desktop tools, and a driver.

## Frozen shortlist for code-level study

- `fughilli/ViveTrackedDevice`
- `TriadSemi/Fusion360_SteamVR_Json`
- `aughip/augmented-hip`
- `m9cd0n9ld/IMU-VR-Full-Body-Tracker`

## Secondary candidates surfaced in the same wave

- `ebadier/ViveTrackers`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for Lighthouse device design, SteamVR tracking JSON generation,
  derived trackers, and IMU full-body stacks;
- compare results against `catalog/project-registry.md`;
- reject repos that only repackage an existing tracker driver without new
  geometry, role, or hardware lessons.

### Step 2: Freeze the shortlist

- keep the wave centered on `tracked-device design and auxiliary tooling`, not
  on generic OSC bridges;
- allow both documentation-heavy reverse engineering and more applied
  firmware-plus-driver stacks so the family stays comparative.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where physical geometry, sensor layout, or role assignment enters the stack;
- whether the repo is a hardware reference, an authoring tool, or a derived
  tracker implementation;
- what the reusable lesson is for future `VR-apps-lab` device tooling.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 34 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies tracked
  device and auxiliary-tracker methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `tracked-device design` stays distinct from generic tracker ingress tooling;
- the family stays focused on geometry, CAD, role generation, and hardware
  decomposition;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 34 synthesis document exists with code-level findings;
4. the registry and families clearly represent tracked-device design and
   auxiliary tracker tooling;
5. tracked-device methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
