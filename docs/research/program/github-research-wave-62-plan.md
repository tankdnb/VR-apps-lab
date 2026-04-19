# GitHub Research Wave 62 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `desktop-adjacent companion overlays`, `phone bridges`, and
  `media or text control surfaces`.

## Why this wave exists

`VR-apps-lab` already tracked media shells and communication overlays, but a
more `companion-surface` branch still needed cleaner donor coverage:

- overlays that proxy a desktop, phone, or text workflow rather than becoming
  full runtime hosts;
- tabbed or stateful overlays that depend on a local bridge or external
  metadata plane;
- tiny one-value tools that turn pasted text or operator actions into a VR
  surface.

This wave exists to make
`desktop-adjacent companion overlays, phone bridges, and media or text control surfaces`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- phone-companion overlays and notification mirrors;
- narrow media or volume control overlays;
- text-paste or note-like overlays driven from desktop workflows;
- Linux or desktop overlays where the desktop proxy itself is the value.

## Frozen shortlist for code-level study

- `happysmash27/OVR_SLDO`
- `Desuuuu/OVRPhoneBridge`
- `adks3489/ViveOverlayPaster`
- `Wulkop/VolumeVR`

## Secondary candidates surfaced in the same wave

- `emymin/EmyOverlay`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for phone bridges, volume overlays, desktop proxy surfaces, and
  tiny text-driven overlays;
- compare results against `catalog/project-registry.md`;
- reject repos that only duplicate already studied general-purpose overlay
  hosts.

### Step 2: Freeze the shortlist

- keep the wave centered on `companion overlays` and `narrow surfaces`, not on
  broad runtime platforms;
- allow partial promotion when a public repo exposes the runtime shell more
  clearly than the final overlay behavior.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how desktop or phone state reaches the overlay;
- whether the repo uses encryption, local sockets, file refresh, or browser
  runtimes;
- whether the repo is strongest as a focused donor, a narrow product reference,
  or an honest follow-up node.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 62 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies companion
  bridges and tiny operator-driven surfaces.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `desktop-adjacent companion overlays` stay distinct from generic browser
  hosts or dashboard suites;
- the family clearly separates `desktop proxy`, `encrypted phone bridge`,
  `paste/send micro-tool`, and `browser-based control shell`;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 62 synthesis document exists with code-level findings;
4. the registry and families clearly represent companion-overlay donors;
5. new companion-bridge or text-surface methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
