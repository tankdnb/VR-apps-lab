# GitHub Research Wave 69 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `OpenXR platform shells`, `layer managers`, and
  `runtime inspection workbenches`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of OpenXR switchers and API-layer
templates, but it still lacked a clearer map of the
`larger runtime-side utility platforms`
that sit between tiny switchers and full runtimes.

This wave exists to make several donor branches explicit:

- plugin-manifest-driven runtime or overlay platforms;
- desktop XR shells that own pairing and session lifecycle;
- API-layer state editors with lint-and-fix workflows;
- runtime inspectors that reuse one information model across GUI and CLI.

## Search scope

Primary search directions for this wave:

- OpenXR platform or service shells;
- API-layer managers and diagnostics GUIs;
- runtime inspection or explorer tools;
- monorepos with explicit plugin and overlay component systems.

## Frozen shortlist for code-level study

- `vrkit-platform/vrkit-platform`
- `clear-xr/clearxr-server`
- `maluoi/openxr-explorer`
- `fredemmott/OpenXR-API-Layers-GUI`

## Secondary candidates surfaced in the same wave

- `mbucchia/OpenXR-Layer-Template`
- `Ybalrid/OpenXR-API-Layer-Template`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for OpenXR platform shells, layer managers, and inspectors;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose real runtime boundaries rather than only a small
  settings window.

### Step 2: Freeze the shortlist

- keep the wave centered on `runtime-side utility platforms`, not ordinary app
  samples;
- allow both broad platforms and narrow diagnostics tools when their runtime
  boundaries are especially clear.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how the repo splits desktop shell, layer logic, runtime inspection, and XR
  app surfaces;
- whether plugin or component manifests exist;
- whether state snapshots, linting, or repair logic are modeled explicitly;
- whether the repo is strongest as a code donor, a product reference, or a
  platform-architecture reference.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 69 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- the OpenXR utility family is split into clearer `platform`, `layer`,
  `inspector`, and `linter` branches;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 69 synthesis document exists with code-level findings;
4. the registry and families clearly represent these OpenXR utility branches;
5. new methods are captured where this wave clarified reusable patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
