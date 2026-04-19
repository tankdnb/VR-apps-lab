# GitHub Research Wave 63 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `specialized effect overlays`, `visibility shaping`, and
  `passthrough cutout surfaces`.

## Why this wave exists

The overlay corpus in `VR-apps-lab` already covered dashboards, notes, media,
and companion surfaces, but another important product branch was still diffuse:

- overlays that exist primarily to change perception rather than show app UI;
- visibility masks, half-rings, and top-of-view bars aimed at comfort or
  focused attention;
- chroma-key passthrough cutouts where the overlay becomes a spatial hole into
  the physical world.

This wave exists to make
`specialized effect overlays, visibility shaping, and passthrough cutout surfaces`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- passthrough or chroma-key overlays that create world-space cutouts;
- comfort overlays that reduce motion sickness or reshape the visible field;
- niche overlays whose main job is a visual effect, masking, or environmental
  trick rather than ordinary UI.

## Frozen shortlist for code-level study

- `Alex-J-Lopez/OpenMixerXR`
- `joaoseabra/SteamVRBlackBarOverlay`
- `tnsgud9/VR-Overlay-Half_Ring`
- `RedHawk989/OpenVR-Windows-Activation`

## Secondary candidates surfaced in the same wave

- `emymin/EmyOverlay`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for visibility-shaping overlays, passthrough cutouts, and
  comfort overlays;
- compare results against `catalog/project-registry.md`;
- reject repos that are only media shells or ordinary dashboard overlays with
  no distinct visual-effect lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `effect-first overlays`, not on general overlay
  hosts;
- allow low-complexity repos when the product lesson is unusually clear.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- whether the visual effect is driven by a dashboard, a static image, or a
  tracked comfort overlay;
- how placement, resizing, opacity, or comfort logic is represented in code;
- whether the repo is strongest as a direct donor, a product reference, or a
  thin comparison node.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 63 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies visual
  masking, cutout, and comfort-overlay patterns.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `effect-first overlays` stay distinct from broader creator or media surfaces;
- the family clearly separates `passthrough cutout manager`,
  `FOV-shaping mask`, `comfort ring`, and `static environmental effect`;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 63 synthesis document exists with code-level findings;
4. the registry and families clearly represent specialized effect overlays;
5. new effect-overlay methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
