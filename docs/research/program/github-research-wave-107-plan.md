# GitHub Research Wave 107 Plan

- Date: `2026-06-05`
- Goal: run the next focused GitHub research wave for repositories that map
  `VRChat avatar dynamics`, `PhysBone migration`, `contact/collision prefabs`,
  and `in-game tuning`.

## Why this wave exists

Recent waves made avatar composition, preview, speech, and face tracking
clearer. The avatar dynamics branch still needed a separate pass because it
contains a different kind of reusable VR knowledge: physical interaction,
contact-based control, PhysBone tuning, migration utilities, and prefab-level
mechanics that users manipulate from inside VRChat.

This wave exists to make `avatar interaction through dynamics and contacts`
visible as a coherent product and implementation family.

## Search scope

Primary search directions for this wave:

- PhysBone migration and conversion tools;
- in-game PhysBone tuning systems;
- component detachment or grouping utilities for outfit toggles;
- grabbable avatar prop prefabs;
- contact or collision detection prefabs and animator bool surfaces.

## Frozen shortlist for code-level study

- `FACS01-01/PhysBone-to-DynamicBone`
- `naqtn/PhysBonesTK`
- `TizzureOne/VRChat_PhysboneDetach`
- `ThatFatKidsMom/Avatar-Prop`
- `VRLabs/Collision-Detection`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for PhysBone, DynamicBone, VRChat avatar prop, contact
  tracker, collision detection, and in-game tuning queries;
- compare surfaced repositories against registry and families;
- avoid flattening prefab-heavy projects into "thin" entries when they expose
  strong product and interaction lessons.

### Step 2: Freeze the shortlist

- keep the wave centered on avatar dynamics and contact-driven interaction;
- include editor conversion, runtime tuning, component grouping, grabbable
  props, and collision-state prefabs.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- editor-window conversion and mapping logic;
- expression menu and animator parameter design;
- component copy/grouping behavior;
- contact, constraint, PhysBone, particle, and FX-controller surfaces;
- product constraints around hierarchy naming, parameter budgets, and prefab
  installation.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 107 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- editor migration tools, runtime tuning prefabs, and contact/collision
  prefabs are classified honestly;
- prefab-heavy references are captured for their interaction patterns even
  when transparent code is thinner;
- constraints and caveats are visible;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 107 synthesis document exists with code-level findings;
4. registry and families represent avatar dynamics, PhysBone migration,
   contact/collision, and grabbable-prop donors clearly;
5. new methods are captured where this wave clarified migration, in-game
   tuning, detached component grouping, contact-driven props, or collision bool
   surfaces;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
