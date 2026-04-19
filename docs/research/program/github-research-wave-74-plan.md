# GitHub Research Wave 74 Plan

- Date: `2026-04-20`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `OpenVR capture`, `replay`, and
  `orchestration toolchains`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of tracking export and some creator
tools, but it still lacked a cleaner map of the
`capture -> replay -> orchestration`
branch where VR runtime state is recorded, transformed, replayed, or fed into
automation and creator workflows.

This wave exists to make several donor branches explicit:

- capture-to-tape plus replay-driver toolchains;
- post-capture spatial offset normalization helpers;
- orchestration shells around synchronized capture and virtual-device control;
- in-VR recording studios with operator-facing menus and export options.

## Search scope

Primary search directions for this wave:

- OpenVR capture or replay repos;
- orchestration or runtime-agent projects that control virtual devices;
- mocap or creator tools that expose reusable recording flows;
- narrow post-capture helpers when they clarify a useful processing boundary.

## Frozen shortlist for code-level study

- `NVIDIA/vr-capture-replay`
- `CodeSmith2000/virtual-camera-offset`
- `wrainw/VRScout_Agent_Orchestration_Unity_Project`
- `TrackLab/ViRe`

## Secondary candidates surfaced in the same wave

- `SKAsApp/ovr-motion-capture`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for OpenVR capture, replay, mocap, and orchestration repos;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose capture contracts, replay surfaces, or operator
  workflows more clearly than generic content projects.

### Step 2: Freeze the shortlist

- keep the wave centered on `capture and orchestration tooling`, not generic
  video or creator stacks;
- allow one thin helper repo when it cleanly exposes an otherwise hidden
  workflow boundary.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how runtime state is captured, stored, replayed, or transformed;
- whether orchestration loops involve inference, IPC, or virtual-device
  control;
- whether operator-facing recording settings live in desktop UI, in-VR menu,
  or both;
- whether the repo is strongest as a code donor, an architecture reference, or
  a workflow reference.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 74 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- record/replay donors stay distinct from plain tracking export bridges;
- orchestration repos are described honestly when they extend wider projects;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 74 synthesis document exists with code-level findings;
4. the registry and families represent this capture-and-orchestration branch
   more clearly;
5. new methods are captured where this wave clarified reusable patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
