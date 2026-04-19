# GitHub Research Wave 68 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `VirtualMotionTracker adapters`, `OSC action compilers`, and
  `skeletal validation utilities`.

## Why this wave exists

`VR-apps-lab` already had strong surface-level coverage for
`VirtualMotionTracker`, `SteamVR_To_OSC`, and adjacent OSC tools, but it still
lacked a clearer picture of the sub-branches inside that family:

- mature manager-plus-driver virtual-tracker platforms;
- thin `OpenVR -> OSC` exporters;
- protocol adapters that feed a stronger host rather than writing a new driver;
- config-defined action compilers that turn controller state into OSC payloads;
- validation utilities for custom skeletal-input paths.

## Search scope

Primary search directions for this wave:

- `VirtualMotionTracker` adapters and adjacent repos;
- `OpenVR -> OSC` exporters and controller-to-OSC utilities;
- SteamVR skeletal-input testers and validation tools;
- avatar-facing or performer-facing bridges that feed `VMT`.

## Frozen shortlist for code-level study

- `gpsnmeajp/VirtualMotionTracker`
- `Greendayle/SteamVR_To_OSC`
- `BarakChamo/OpenVR-OSC`
- `faidra/VMC2VMT`
- `gpsnmeajp/SkeletonPoseTester`
- `logicmachine/OVR-VRC-OSC-Bridge`

## Secondary candidates surfaced in the same wave

- `ArT-Programming/VRtoOSC`
- `thakyuu/VirtualTrackerPositionManager`
- `rtlcopymemory/open_scale`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for `VMT`, SteamVR OSC export, and skeletal validation helpers;
- compare results against `catalog/project-registry.md`;
- reject repos that only repeat the same OSC-export lesson without a stronger
  architectural distinction.

### Step 2: Freeze the shortlist

- keep the wave centered on
  `VirtualMotionTracker-adjacent transport and validation patterns`;
- allow a mix of mature donor platforms, narrow exporters, and validation
  micro-tools.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where transport and runtime boundaries are drawn;
- whether the repo owns a driver, a manager, a thin utility app, or only an
  adapter;
- how controller or skeletal state becomes OSC or virtual-tracker state;
- whether the repo is strongest as a code donor, a product reference, or a
  validation reference.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 68 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- the `VirtualMotionTracker / OSC` family is split into clearer donor branches;
- validation tools stay visible instead of being buried under bigger drivers;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 68 synthesis document exists with code-level findings;
4. the registry and families reflect the new adapter and validation branches;
5. new methods are captured where this wave clarified reusable patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
