# GitHub Research Wave 35 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `expressive tracking`, `face and eye input`, and
  `avatar-facing input bridges`.

## Why this wave exists

The repository already contained camera body tracking, hand bridges, and some
eye-tracking layers, but it still lacked a tighter family around
`expressive avatar-facing input`:

- face and eye-tracking platforms with calibration or trainer overlays;
- hand-skeleton or gesture remappers that bridge incompatible provider models;
- driver or API-layer paths that turn vendor-specific data into broadly usable
  VR inputs.

This wave exists to make `expressive tracking and avatar-facing bridges` a more
explicit product branch inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- face or eye tracking platforms that target social VR;
- SteamVR hand-tracking drivers and hand-skeleton remappers;
- avatar-facing bridges that export to `OSC`, `OpenXR`, or SteamVR inputs;
- vendor-specific gaze or face paths that are reusable beyond one single app.

## Frozen shortlist for code-level study

- `Project-Babble/Baballonia`
- `jcorvinus/HandshakeVR`
- `moshimeow/mercury_steamvr_driver`
- `BattleAxeVR/PSVR2_OpenXR_Eye_Tracking`

## Secondary candidates surfaced in the same wave

- `takana-v/quest_steamvr_fbt_tool`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for face tracking, eye tracking, hand remapping, and avatar
  bridge utilities;
- compare results against `catalog/project-registry.md`;
- reject repos that only duplicate a broader already-studied bridge without a
  new expressive-input lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `expressive input and avatar-facing bridges`, not
  on generic full-body tracking alone;
- allow both broad platforms and thinner bridge layers so the family stays
  comparative.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how face, eye, hand, or gesture data is captured or adapted;
- where calibration, provider switching, or IPC boundaries sit;
- whether the reusable lesson is a broad platform, a remapper, a driver, or an
  API layer.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 35 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies
  expressive-input methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `expressive tracking` stays distinct from generic body-tracking ingestion;
- the family stays focused on face, eye, hand, and avatar-facing adaptation;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 35 synthesis document exists with code-level findings;
4. the registry and families clearly represent expressive tracking and
   avatar-facing bridges;
5. expressive-input methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
