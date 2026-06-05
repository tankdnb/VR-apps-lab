# GitHub Research Wave 105 Plan

- Date: `2026-06-05`
- Goal: run the next focused GitHub research wave for repositories that map
  `VRCFury installer automation`, `toggle generation`,
  `avatar animator DSLs`, and `editor QoL overlays`.

## Why this wave exists

Wave 101 already made avatar composition and package management much clearer,
but VRCFury-specific automation deserved a separate look. This branch is not
only "avatar install helpers"; it includes feature builders, menu pagination,
component APIs, inspector overlays, clone preview, and code-first animator
authoring.

This wave exists to make that `avatar feature automation` branch explicit.

## Search scope

Primary search directions for this wave:

- VRCFury feature-builder and public API repositories;
- editor QoL overlays around VRCFury;
- one-click toggle and menu generators;
- VRChat animator DSLs and parameter-driver helper libraries;
- micro-utilities that prove the value of thin public APIs.

## Frozen shortlist for code-level study

- `VRCFury/VRCFury`
- `RealWhyKnot/wk-vrcfury-qol`
- `SuperFlue/VRCToggleToolkit`
- `hai-vr/animator-as-code-vrchat`
- `vr-voyage/vrchat-quick-toggle-vrcfury`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRCFury, toggle toolkit, animator-as-code, VRChat toggle,
  and editor QoL queries;
- compare surfaced repositories against the registry and families;
- keep already-covered Modular Avatar and generic package-manager projects as
  comparison context rather than main targets.

### Step 2: Freeze the shortlist

- keep the wave centered on avatar feature automation and editor workflow;
- include both large architecture donors and tiny micro-utilities.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- feature builder or public API boundaries;
- menu, parameter, controller, and action generation flow;
- inspector overlay or reflection-extension pattern;
- preview, hot reload, or cleanup behavior;
- DSL design for animator behaviors and safe defaults.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 105 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- VRCFury-specific tools are not confused with the broader avatar composition
  family;
- micro-utilities are captured for their reusable workflow shape;
- clone preview and reflection-extension risks are documented honestly;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 105 synthesis document exists with code-level findings;
4. registry and families represent VRCFury automation, toggle generation, and
   animator DSL donors clearly;
5. new methods are captured where this wave clarified feature builders,
   inspector overlays, clone preview, toggle generation, or code-first
   animator authoring;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
