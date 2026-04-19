# GitHub Research Wave 46 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `XR latency measurement`, `recording parsers`, and
  `experiment harnesses`.

## Why this wave exists

`VR-apps-lab` already had metrics overlays, logging helpers, and some capture
tools, but one research and diagnostics branch was still weaker than it should
be:

- tools that explicitly measure motion-to-photon or tracking latency;
- experiment harnesses that combine screen coding, external sensors, or serial
  capture;
- parser and analysis stacks for rich XR recordings;
- reusable lab frameworks for display, tracking, and end-to-end latency tests.

This wave exists to make
`XR latency measurement, recording parsers, and experiment harnesses`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- motion-to-photon or tracking-latency tools for VR;
- Unity or VRChat experiments that encode movement into visual state changes;
- microcontroller-assisted latency rigs;
- parsers and notebook stacks for XR simulator recordings.

## Frozen shortlist for code-level study

- `immersivecognition/motion-to-photon-measurement`
- `vr-thi/VRLate`
- `Greendayle/VR-Motion-to-photon-latency-`
- `HARPLab/dreyevr_recording_analyzer`
- `HARPLab/DReyeVR-parser`
- `ratcave/vrlatency`

## Secondary candidates surfaced in the same wave

- no extra candidate in this wave was stronger than the frozen shortlist

## Execution model

### Step 1: Search and deduplicate

- search GitHub for latency rigs, motion-to-photon tools, and XR recording
  parsers;
- compare results against `catalog/project-registry.md`;
- reject repos that only publish results without a reusable implementation or
  experiment lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `measurement and analysis tooling`;
- allow both lab rigs and parser-only repos because they describe different
  layers of the same research workflow.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how movement or visual signals are encoded for later alignment;
- whether external hardware, serial capture, or slow-motion video is part of
  the measurement model;
- whether the reusable lesson is experiment orchestration, parser structure, or
  analysis packaging.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 46 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies latency
  measurement and recording-analysis methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `latency measurement` stays distinct from general metrics overlays;
- the family clearly separates engine-side visual coding, external hardware
  rigs, parser packages, and notebook analyzers;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 46 synthesis document exists with code-level findings;
4. the registry and families clearly represent latency rigs and analysis tools;
5. latency and parser methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
