# GitHub Research Wave 91 Plan

- Date: `2026-04-21`
- Goal: run the next focused GitHub research wave for repositories that map
  `VRChat interaction prefabs`, `utility UI`, and
  `dynamic information-surface tools`.

## Why this wave exists

`VR-apps-lab` already had better coverage of creator media systems and OSC-side
utilities than of small world-side interaction prefabs. It still lacked a
cleaner answer to:

`what the strongest reusable world utility donors look like when the value sits in keypads, markers, dynamic text carriers, and reusable UI infrastructure for lists or scoreboards`.

This wave exists to make that branch explicit.

## Search scope

Primary search directions for this wave:

- VRChat keypads, access-control prefabs, and world interaction widgets;
- marker or drawing tools for creator worlds;
- data or text display carriers for dynamic world information;
- reusable Udon UI infrastructure such as scrolling lists or recycled cells.

## Frozen shortlist for code-level study

- `Reava/U-Key`
- `z3y/VRCMarker`
- `Miner28/AvatarImageReader`
- `Guribo/UdonRecyclingScrollRect`

## Secondary candidates surfaced in the same wave

These candidates were checked but not promoted into the main shortlist:

- `Guribo/UdonLeaderBoard`
  stayed outside the main shortlist because its public repo is still too thin
  to support a serious source pass, but it matters as a follow-up next to the
  stronger list or UI infrastructure donors;
- broader UI frameworks already tracked in earlier waves
  remained comparison anchors instead of widening the wave.

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRChat keypads, marker tools, dynamic text or board
  systems, and Udon UI infrastructure;
- compare surfaced repos against `catalog/project-registry.md`;
- prefer repos where interaction flow, sync model, or data-carrier boundary is
  explicit in code.

### Step 2: Freeze the shortlist

- keep the wave centered on `world interaction prefabs and utility UI`, not
  all creator packages;
- allow both user-facing prefabs and lower-level UI infrastructure when they
  reveal a different reusable method clearly.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how interaction state and permissions are stored;
- where sync boundaries sit for shared drawing or shared UI;
- whether the repo is strongest as a direct donor, a deprecated reference, or
  a lower-layer infrastructure package;
- what reusable methods belong in the methods catalog.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 91 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- prefab-shaped interaction tools stay distinct from deeper UI infrastructure;
- deprecated dynamic-data carriers are described honestly when the underlying
  platform assumption has shifted;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 91 synthesis document exists with code-level findings;
4. the registry and families represent VRChat interaction and utility-UI
   donors more clearly;
5. new methods are captured where this wave clarified reusable prefab or UI
   patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
