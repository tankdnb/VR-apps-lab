# GitHub Research Wave 33 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `alternative OpenXR runtimes`, `special-display paths`, and
  `platform experiments outside the ordinary headset runtime model`.

## Why this wave exists

The repository already contained OpenXR switchers, API layers, and simulator
paths, but it still needed a clearer family around
`nonstandard runtime targets`:

- runtimes for spatial displays and glasses-like form factors;
- embedded or platform-native runtime experiments;
- proof-of-concept runtimes that matter architecturally even when they are not
  production-ready.

This wave exists to make `alternative OpenXR platform architecture` a stronger
research branch inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- OpenXR runtimes for 3D displays and spatial laptops;
- non-Windows or platform-native runtime experiments;
- embedded runtime frameworks that break from the ordinary desktop loader model;
- proof-of-concept runtimes where the donor value lies in architecture or
  platform decomposition.

## Frozen shortlist for code-level study

- `DisplayXR/displayxr-runtime`
- `JoeyAnthony/XRGameBridge`
- `warrenm/OpenXRKit`
- `rinsuki/FruitXR`

## Secondary candidates surfaced in the same wave

- `maximum-game-22/openxr-3d-display`
- `Kartaverse/OpenDisplayXR`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for special-display OpenXR runtimes, Apple OpenXR runtime
  experiments, and embedded runtime frameworks;
- compare results against `catalog/project-registry.md`;
- reject repos that only mirror Monado or add thin packaging without a visible
  architectural lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `runtime architecture`, not on ordinary utility
  apps;
- allow both cleaner runtime implementations and rougher platform experiments
  so the family stays comparative.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how the runtime is layered or decomposed;
- which transport, graphics, or platform modules are isolated;
- whether the repo behaves like an installable runtime, an embedded framework,
  or a server-backed proof of concept.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 33 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies
  alternative-runtime methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `alternative runtimes` stay distinct from ordinary runtime switchers and
  API-layer tools;
- the family stays focused on platform architecture and special-display paths;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 33 synthesis document exists with code-level findings;
4. the registry and families clearly represent alternative OpenXR runtime
   architecture;
5. runtime-architecture methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
