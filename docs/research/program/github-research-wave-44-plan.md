# GitHub Research Wave 44 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `playspace editors`, `chaperone and guardian tooling`, and
  `shared-space helpers`.

## Why this wave exists

`VR-apps-lab` already had calibration tools, motion-compensation flows, tracker
bridges, and overlays, but one room-space branch was still weaker than it
should be:

- tools that edit or rewrite room boundaries directly;
- utilities that import boundary data from one ecosystem into another;
- runtime-side playspace movers and zero-pose manipulators;
- helpers that make shared physical spaces visible inside SteamVR.

This wave exists to make
`playspace editing, boundary import, and shared-space helpers`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- SteamVR or OpenVR chaperone editors;
- OpenXR room-boundary tools with service or setup splits;
- Oculus Guardian to SteamVR transfer helpers;
- runtime playspace movers, re-centering tools, and transform rotators;
- small shared-space overlays or peer-visualization helpers.

## Frozen shortlist for code-level study

- `Xavr0k/ChaperoneTweak`
- `FrostyCoolSlug/xr-chaperone`
- `Sgeo/Guardian2Chaperone`
- `hai-vr/unity-chaperone-tweaker`
- `Rafacasari/Playspace-Mover`
- `mdovgialo/OpenVRSharedPlayspace`
- `LIV/RotatoExpress`

## Secondary candidates surfaced in the same wave

- no extra candidate in this wave was stronger than the frozen shortlist

## Execution model

### Step 1: Search and deduplicate

- search GitHub for chaperone editors, guardian importers, and playspace
  rotation or movement tools;
- compare results against `catalog/project-registry.md`;
- reject repos that only duplicate simple recentering behavior without a clear
  new editing, import, or shared-space lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `room-space manipulation`;
- allow both live runtime tools and file-based editors because the family is
  stronger when both are compared.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- whether it edits the working chaperone copy, raw config files, or imported
  vendor boundary data;
- how controller input, desktop UI, or service mode are used;
- whether the reusable lesson is boundary authoring, transform manipulation, or
  peer-space awareness.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 44 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies
  playspace-editing and shared-space methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `playspace editors` stay distinct from calibration and motion-compensation
  families;
- the family clearly separates live editors, import tools, file editors, and
  peer-space helpers;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 44 synthesis document exists with code-level findings;
4. the registry and families clearly represent playspace editors and boundary
   tooling;
5. playspace methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
