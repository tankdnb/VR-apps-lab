# GitHub Research Wave 89 Plan

- Date: `2026-04-21`
- Goal: run the next focused GitHub research wave for repositories that map
  `VRChat world runtime infrastructure`, `voice and networking helpers`, and
  `per-player state systems`.

## Why this wave exists

`VR-apps-lab` already had good creator-facing media and VRChat-side control
coverage, but it still lacked a cleaner answer to:

`what the strongest reusable world-runtime donors look like when the value sits in voice-state control, message transport, moving-platform locomotion, and stable per-player object anchoring`.

This wave exists to make that branch explicit.

## Search scope

Primary search directions for this wave:

- VRChat world voice and audio-control packages;
- Udon networking or transport helpers;
- player-state or per-player object infrastructure;
- narrow world-runtime helpers that solve locomotion or per-player anchoring.

## Frozen shortlist for code-level study

- `Guribo/UdonVoiceUtils`
- `Xytabich/UNet`
- `Superbstingray/UdonPlayerPlatformHook`
- `CyanLaser/CyanPlayerObjectPool`

## Secondary candidates surfaced in the same wave

These candidates were checked but not promoted into the main shortlist:

- `Guribo/UdonLeaderBoard`
  stayed outside the main shortlist because its public repo is currently too
  thin and works better as a follow-up node next to stronger list or state
  infrastructure donors;
- already tracked creator-side audio and synced media repos
  remained comparison anchors instead of widening the wave.

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRChat world runtime helpers, audio-control packages,
  Udon networking, and per-player infrastructure;
- compare surfaced repos against `catalog/project-registry.md`;
- prefer repos with explicit runtime boundaries such as controller models,
  transport layers, or assignment state.

### Step 2: Freeze the shortlist

- keep the wave centered on `world runtime infrastructure`, not on general
  creator packages;
- allow both broad packages and narrow helpers if they reveal a different
  reusable boundary clearly.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how runtime state is modeled and updated;
- where per-player ownership or assignment is stored;
- how network transport or voice overrides are abstracted;
- whether the repo is strongest as a direct donor, a lower-bound utility, or a
  comparison node around creator-world infrastructure.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 89 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- voice-state systems stay distinct from media-player or creator-audio systems;
- transport abstractions stay distinct from per-player object assignment tools;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 89 synthesis document exists with code-level findings;
4. the registry and families represent VRChat world-runtime donors more
   clearly;
5. new methods are captured where this wave clarified reusable runtime-side
   patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
