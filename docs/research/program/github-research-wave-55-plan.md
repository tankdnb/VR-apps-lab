# GitHub Research Wave 55 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `creator control overlays`, `research stations`, and
  `specialized companion-presence surfaces`.

## Why this wave exists

`VR-apps-lab` already had creator tools, simulator helpers, and communication
sidecars, but one adjacent branch still needed a cleaner donor map:

- creator overlays that control another desktop tool through a local bridge;
- research overlays that turn questionnaires or study flow into a standalone VR
  station;
- overlays that visualize a remote collaborator or a fixed environmental object
  rather than a desktop window;
- small companion surfaces where the value comes from context, not from general
  desktop utility.

This wave exists to make
`creator control overlays, research stations, and specialized companion-presence surfaces`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- OBS or creator-control overlays for SteamVR;
- overlay-based questionnaire or VR-study tooling;
- overlays that visualize another user or another tracked entity;
- overlays anchored to a known object or environmental landmark.

## Frozen shortlist for code-level study

- `99oblivius/VRBro-Overlay`
- `kuentzel/ROVER`
- `imagitama/steamvr-overlay-vrbuddy`
- `lukis101/VRPoleOverlay`

## Secondary candidates surfaced in the same wave

- no additional secondary candidates were strong enough to justify displacing
  the frozen shortlist

## Execution model

### Step 1: Search and deduplicate

- search GitHub for OBS overlays, VR questionnaire overlays, companion
  visualization overlays, and anchored environmental overlays;
- compare results against `catalog/project-registry.md`;
- reject repos that only duplicate already-tracked creator or communication
  tools without a clearer contextual display lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `context-aware display surfaces`, not generic
  dashboard or desktop overlays;
- allow both polished creator tools and niche overlays when they expose a clear
  new architecture or UX pattern.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- what external state or study model drives the overlay;
- how the repo handles dashboard surface versus always-visible surface;
- whether the overlay is anchored to a wrist, another user, a pole, or a study
  station in world space.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 55 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies creator,
  research-station, and companion-visualization methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `creator overlays`, `research stations`, and `companion visualization`
  surfaces stay distinct from generic social or desktop overlays;
- the family clearly separates `creator control`, `questionnaire station`,
  `remote buddy visualization`, and `anchored safety or awareness overlay`;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 55 synthesis document exists with code-level findings;
4. the registry and families clearly represent creator-control, research, and
   specialized companion overlay surfaces;
5. new contextual-overlay methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
