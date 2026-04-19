# GitHub Research Wave 54 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `Discord voice overlays`, `note surfaces`, and
  `context-status micro-overlays`.

## Why this wave exists

`VR-apps-lab` already had some communication sidecars and micro-utilities, but
another branch still needed a more honest donor map:

- Discord overlays that use either local IPC or a browser widget as their data
  source;
- overlays whose job is not to mirror a desktop but to display one narrow
  stateful workflow in VR;
- session-scoped drawing or annotation surfaces;
- game-specific status overlays that show the value of extremely focused
  in-headset displays.

This wave exists to make
`Discord voice overlays, note surfaces, and context-status micro-overlays`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- Discord voice or message overlays for `SteamVR/OpenVR`;
- narrow status overlays tied to one game or one workflow;
- note-taking or annotation overlays;
- domain-specific wrist or micro-display overlays.

## Frozen shortlist for code-level study

- `Larsundso/SteamVR-Discord-Overlay`
- `Artemol/DiscOverlay`
- `hiinaspace/vr-notes-anywhere`
- `jacklul/SteamVR-PhasmoMatrix`
- `SteveMarkhamGIT/SmudgeTimerOpenVR`

## Secondary candidates surfaced in the same wave

- `beareogaming/BD-XSOverlay-notify`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for Discord overlays, note overlays, and game-specific overlay
  utilities;
- compare results against `catalog/project-registry.md`;
- reject repos that only repeat already-studied generic social or notification
  tools without a clearer narrow display lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `narrow, stateful overlay surfaces`, not broad chat
  or browser platforms;
- allow very small repos when they demonstrate a distinct product framing or
  interaction pattern.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where the overlay data comes from: local IPC, web widget, session state, or
  game-specific timers;
- whether the repo uses dashboard overlays, projection overlays, wrist surfaces,
  or auxiliary button overlays;
- how config, persistence, and optional desktop dashboards are exposed.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 54 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies
  communication-sidecar and domain-specific micro-overlay methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `Discord overlays`, `annotation tools`, and `domain micro-overlays` stay
  distinct from generic desktop mirrors;
- the family clearly separates `Discord IPC overlay`, `browser-widget overlay`,
  `annotation overlay`, and `game-specific status surface`;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 54 synthesis document exists with code-level findings;
4. the registry and families clearly represent Discord, notes, and
   context-status overlays;
5. new narrow-overlay methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
