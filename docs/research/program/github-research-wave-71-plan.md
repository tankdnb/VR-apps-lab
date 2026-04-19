# GitHub Research Wave 71 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `OpenVR driver learning paths`, `synthetic devices`, and
  `remote-input ingress`.

## Why this wave exists

`VR-apps-lab` already had several driver tutorials and hardware bridges in
scope, but it still lacked a cleaner map of the
`lower-bound driver learning path`
from tutorials to DIY HMDs and rough remote-ingress experiments.

This wave exists to make several donor branches explicit:

- tutorial-grade OpenVR driver shells;
- narrow controller-input emulation drivers;
- HMD-relative synthetic controller helpers;
- DIY HMD drivers fed by serial IMU data;
- file-backed or browser-fed synthetic VR drivers;
- tracking-override harnesses for head-pose replacement.

## Search scope

Primary search directions for this wave:

- OpenVR driver tutorials and worked examples;
- synthetic controller or tracker baselines;
- DIY HMD driver repos;
- remote-input or browser-fed driver experiments;
- tracking-override examples for third-party systems.

## Frozen shortlist for code-level study

- `terminal29/Simple-OpenVR-Driver-Tutorial`
- `finallyfunctional/openvr-driver-example`
- `puresoul/Barebone`
- `r57zone/OpenVR-ArduinoHMD`
- `Somebody32x2/RemoteVVR`
- `codeysun/OpenVR-Tracker-Driver-Example`

## Secondary candidates surfaced in the same wave

- `cwlmyjm/openvr_treadmill`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for OpenVR driver tutorials, synthetic-device examples, and
  DIY HMD or remote-input repos;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose a real worked driver boundary, even when the project
  itself is rough.

### Step 2: Freeze the shortlist

- keep the wave centered on `driver learning path and ingress baselines`;
- allow a mix of polished tutorials and rough lower-bound experiments when the
  comparison is instructive.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how devices are registered and updated;
- whether input comes from keyboard, gamepad, serial, file, or browser-fed
  channels;
- whether the repo is strongest as a learning donor, a product reference, or a
  rough but useful ingress experiment.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 71 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- tutorial donors stay distinct from mixed-VR bridges and tracker platforms;
- rough remote-ingress repos are described honestly;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 71 synthesis document exists with code-level findings;
4. the registry and families represent these lower-bound driver donors more
   clearly;
5. new methods are captured where this wave clarified reusable patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
