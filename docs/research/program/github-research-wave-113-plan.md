# GitHub Research Wave 113 Plan

- Date: `2026-06-05`
- Goal: run a focused GitHub research wave for Unity XR interaction and
  workflow toolkits: modern MRTK, scientific rigs, training/workflow graphs,
  and Tilia/VRTK composition.

## Why this wave exists

Earlier waves covered many overlay, runtime, and VRChat-specific projects. A
fresh Unity toolkit pass is useful because toolkits reveal how reusable VR
interaction systems are packaged for creators: modular UX primitives,
movement presets, data capture, training steps, scene-object properties,
prefab-composed rules, and editor validation.

This wave studies Unity XR toolkits as architecture and product references for
future `VR-apps-lab` utilities that need in-headset menus, training flows,
calibration surfaces, or reusable interaction primitives.

## Search scope

Primary search directions for this wave:

- current-generation MRTK and Unity XR Interaction Toolkit extensions;
- scientific or exhibition XR rig/toolkit projects;
- VR training workflow editors and no-code process graphs;
- VRTK/Tilia composition and prefab-rule ecosystems.

## Frozen shortlist for code-level study

- `MixedRealityToolkit/MixedRealityToolkit-Unity`
- `eisclimber/ExPresS-XR`
- `MindPort-GmbH/VR-Builder`
- `ExtendRealityLtd/VRTK`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for Unity XR toolkit, MRTK3, VR training workflow, scientific
  XR rig, and VRTK/Tilia families;
- compare surfaced repositories against registry and family docs;
- treat `MixedRealityToolkit/MixedRealityToolkit-Unity` as a deliberate
  deepening pass because it was previously only marked as not studied deeply.

### Step 2: Freeze the shortlist

- include one modern modular MR toolkit, one scientific/exhibition toolkit,
  one workflow/process-graph toolkit, and one prefab-composition ecosystem.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- interaction primitives and state machines;
- menu, solver, manipulation, and locomotion patterns;
- data capture, quiz, training, or process-flow models;
- editor configuration and validation surfaces;
- prefab composition and rule/action wiring;
- caveats around package size, sparse checkout, and direct code reuse.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 113 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- toolkit roles stay distinct instead of collapsing into "Unity examples";
- modern MRTK is not conflated with the legacy MRTK line;
- sparse-pass limits are labeled clearly;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 113 synthesis document exists with code-level findings;
4. registry and families represent Unity XR toolkit donors clearly;
5. new methods capture MR UX state machines, scientific rigs, workflow graphs,
   and prefab composition;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
