# GitHub Research Wave 45 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `redirected walking`, `locomotion adaptation`, and
  `space-redirection research toolkits`.

## Why this wave exists

`VR-apps-lab` already had calibration, motion-manipulation, and tracking-space
helpers, but it still lacked a good view of one broader locomotion branch:

- redirected-walking platforms with pluggable redirectors and resetters;
- simulation and batch tooling for physical-space redirection studies;
- multi-user redirected-walking research stacks;
- comfort-heavy locomotion modules that solve related `room limits` problems in
  another way.

This wave exists to make
`redirected walking, locomotion adaptation, and space-redirection research`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- Unity redirected-walking toolkits;
- redirection and reset algorithm benchmark platforms;
- multi-user or networked redirected-walking experiments;
- locomotion systems that explicitly solve room-boundary and comfort limits.

## Frozen shortlist for code-level study

- `USC-ICT-MxR/RDWT`
- `yaoling1997/OpenRDW`
- `omegafantasy/OpenRDW2`
- `ElectricNightOwl/ArmSwinger`
- `Knerten0815/VR_Dodge_Study`

## Secondary candidates surfaced in the same wave

- no extra candidate in this wave was stronger than the frozen shortlist

## Execution model

### Step 1: Search and deduplicate

- search GitHub for redirected-walking toolkits, locomotion adaptation, and
  space-redirection experiments;
- compare results against `catalog/project-registry.md`;
- reject repos that only repackage a known toolkit without a clearer algorithm,
  experiment, or comfort-stack lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `physical-space adaptation`;
- allow one strong locomotion sidecar because it teaches a parallel answer to
  room-boundary constraints.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how redirectors, resetters, and movement controllers are composed;
- whether the repo is a runtime toolkit, a simulation harness, a networked
  experiment platform, or a comfort locomotion module;
- where experiment batching, path generation, and safety logic are modeled.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 45 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies
  redirected-walking and locomotion-adaptation methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `redirected walking` stays distinct from calibration and generic tracker
  bridges;
- the family clearly separates algorithm harnesses, multi-user research stacks,
  and comfort-heavy locomotion modules;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 45 synthesis document exists with code-level findings;
4. the registry and families clearly represent redirected-walking and
   locomotion-adaptation donors;
5. locomotion methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
