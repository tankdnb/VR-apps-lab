# GitHub Research Wave 90 Plan

- Date: `2026-04-21`
- Goal: run the next focused GitHub research wave for repositories that map
  `VRChat camera systems`, `staging and admin control`, and
  `creator-side event coverage`.

## Why this wave exists

`VR-apps-lab` already had strong generic overlay and media-surface coverage,
but it still lacked a cleaner answer to:

`what the strongest creator-side camera and admin-control donors look like when the value sits in multicam staging, permission-gated control consoles, watch cameras, and avatar-side OSC camera paths`.

This wave exists to make that branch explicit.

## Search scope

Primary search directions for this wave:

- VRChat world camera systems and staging rigs;
- admin or moderator menus with camera-control surfaces;
- avatar-side or OSC camera-path systems;
- event or venue camera helpers for creators.

## Frozen shortlist for code-level study

- `laserimouto/VRChatCameraWorks`
- `rhaamo/CameraSystem`
- `VRLabs/Camera-System`
- `SylanTroh/GMMenu`

## Secondary candidates surfaced in the same wave

These candidates were checked but not promoted into the main shortlist:

- already tracked synced media-player repos with camera-adjacent features
  stayed outside this wave because the focus here is
  `camera control and creator operations`,
  not playback;
- thinner event-menu helpers were deferred until the stronger camera and admin
  donors were mapped first.

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRChat camera systems, event-camera rigs, and GM or admin
  menu packages;
- compare surfaced repos against `catalog/project-registry.md`;
- prefer repos where live-output switching, permissions, watch flows, or
  off-project companion boundaries are explicit.

### Step 2: Freeze the shortlist

- keep the wave centered on `camera and admin-control systems`, not all
  creator-world utilities;
- allow both world-side camera rigs and avatar-side camera-path systems when
  they reveal a different system split clearly.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how camera switching, rendering, and preview/output are modeled;
- where permissions and operator control gates sit;
- whether a companion executable or OSC bridge is part of the product shape;
- what reusable control-surface or staging methods belong in the methods
  catalog.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 90 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- creator camera rigs stay distinct from synced video-player systems;
- avatar-side OSC camera systems are described honestly when their strongest
  value is companion-bound architecture rather than standalone source;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 90 synthesis document exists with code-level findings;
4. the registry and families represent VRChat camera and admin-control donors
   more clearly;
5. new methods are captured where this wave clarified reusable staging and
   control-surface patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
