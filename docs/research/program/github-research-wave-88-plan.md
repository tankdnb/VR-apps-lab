# GitHub Research Wave 88 Plan

- Date: `2026-04-21`
- Goal: run the next focused GitHub research wave for repositories that map
  `VRChat world-authoring toolkits`, `Udon optimization helpers`, and
  `prefab ecosystem baselines`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of VRChat-facing media systems,
chatbox tools, and OSC-side utilities, but it still lacked a cleaner answer to:

`what the strongest creator-side donors look like before runtime, at authoring time, when the value sits in editor tooling, build checks, optimization passes, and prefab ecosystems`.

This wave exists to make that branch explicit.

## Search scope

Primary search directions for this wave:

- VRChat world-editor utility packs;
- Udon or UdonSharp optimization helpers;
- prefab suites for world creation;
- package ecosystems that break creator utilities into reusable modules.

## Frozen shortlist for code-level study

- `oneVR/VRWorldToolkit`
- `BlueAmulet/UdonSharpOptimizer`
- `Varneon/UdonEssentials`
- `Varneon/VUdon`

## Secondary candidates surfaced in the same wave

These candidates were checked but not promoted into the main shortlist:

- individual `VUdon-*` package repositories
  stayed outside this wave so the first pass could map the ecosystem shape
  before exploding it into many smaller repos;
- already tracked VRChat creator-side systems such as `AudioManager`,
  `USharpVideo`, and `VideoTXL`
  remained comparison anchors instead of widening the wave.

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRChat creator toolkits, prefab suites, and Udon
  optimization helpers;
- compare surfaced repos against `catalog/project-registry.md`;
- prefer repos where editor-time policy, build gating, optimization, or package
  decomposition are visible in source.

### Step 2: Freeze the shortlist

- keep the wave centered on `world-authoring and prefab ecosystems`, not on
  every VRChat world utility repo;
- allow both concrete toolkits and ecosystem umbrella repos when they clarify
  a different architectural role.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where editor hooks or build callbacks enter the VRChat toolchain;
- how prefab ecosystems are packaged and divided;
- whether the repo is strongest as a direct donor, a historical lineage node,
  or an ecosystem map;
- what reusable creator-side methods belong in the methods catalog.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 88 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- creator-side editor tooling stays distinct from world runtime infrastructure;
- deprecated prefab suites are described honestly when their strongest value is
  lineage or migration context rather than fresh code donation;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 88 synthesis document exists with code-level findings;
4. the registry and families represent VRChat world-authoring donors more
   clearly;
5. new methods are captured where this wave clarified reusable creator-side
   patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
