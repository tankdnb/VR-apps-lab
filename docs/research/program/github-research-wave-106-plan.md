# GitHub Research Wave 106 Plan

- Date: `2026-06-05`
- Goal: run the next focused GitHub research wave for repositories that map
  `VRCFaceTracking`, `tracking modules`, `cross-platform face-tracking shells`,
  and `blendshape preparation`.

## Why this wave exists

The repository already had tracker and OSC bridge coverage, but face tracking
deserves its own branch. The interesting pattern is not one device. It is the
pipeline:

`sensor or app module -> normalized expression model -> OSC or VRChat output -> avatar authoring requirements`.

This wave exists to make that pipeline visible as a reusable architecture.

## Search scope

Primary search directions for this wave:

- VRCFaceTracking core and SDK repositories;
- external tracking modules for phone, camera, or local OSC input;
- cross-platform face-tracking shells and module registries;
- DCC-side blendshape preparation tools;
- unified expression mapping and avatar parameter preparation.

## Frozen shortlist for code-level study

- `benaclejames/VRCFaceTracking`
- `dfgHiatus/VRCFaceTracking.Avalonia`
- `dfgHiatus/VRCFT-Babble`
- `regzo2/VRCFaceTracking-MeowFace`
- `Adjerry91/VRCFaceTracking-blender-plugin`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRCFaceTracking, VRCFT module, face tracking OSC, MeowFace,
  Project Babble, and VRChat blendshape helper queries;
- compare surfaced repositories against registry and family docs;
- avoid treating every hardware module as a separate wave unless it contributes
  a new mapping or architecture lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on the full face-tracking pipeline;
- include one core app, one cross-platform app, two provider modules, and one
  authoring-side blendshape tool.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- module SDK and lifecycle boundaries;
- normalized tracking data model;
- OSC, UDP, JSON, and module registry flow;
- sandboxing or module-process isolation;
- UI and diagnostics surfaces;
- authoring-side blendshape and parameter preparation.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 106 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- face tracking is represented as a pipeline family rather than only hardware
  support;
- modules and authoring tools are classified separately;
- cross-platform shells are captured for architecture and product lessons;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 106 synthesis document exists with code-level findings;
4. registry and families represent face-tracking core, modules, and
   blendshape-preparation donors clearly;
5. new methods are captured where this wave clarified module sandboxing,
   registry, UDP/OSC mapping, unified expressions, or DCC-side shape-key
   preparation;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
