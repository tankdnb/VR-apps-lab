# GitHub Research Wave 53 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `media launcher overlays`, `playback surfaces`, and
  `lightweight in-headset display shells`.

## Why this wave exists

`VR-apps-lab` already had desktop mirrors and generic overlay suites, but a
more specific `display shell` branch was still too blurry:

- overlays that mainly launch, route, or wrap other desktop applications;
- media-controller surfaces that show state and send commands in VR;
- video or window-capture paths that treat `OpenVR` as a display target rather
  than a general-purpose desktop suite;
- rough proof-of-concept repos that embed a media engine directly in an
  overlay.

This wave exists to make
`media launcher overlays, playback surfaces, and lightweight in-headset display shells`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- overlay launchers for desktop applications or `gamescope`-style wrapped apps;
- media-controller overlays and `MPRIS`-driven desktop sidecars;
- VR video players with overlay mode or window-capture display paths;
- proof-of-concept media-embedding overlays.

## Frozen shortlist for code-level study

- `Mon-Ouie/launcher-openvr-overlay`
- `Mon-Ouie/mpris-openvr-overlay`
- `Mon-Ouie/vr-video-player-overlay`
- `iigomaru/MPVR`

## Secondary candidates surfaced in the same wave

- `PhialsBasement/fnuidesktop-VR` as an already-tracked comparison anchor

## Execution model

### Step 1: Search and deduplicate

- search GitHub for media-player overlays, launcher overlays, and window-capture
  display repos;
- compare results against `catalog/project-registry.md`;
- reject repos that only repeat already-tracked desktop mirror suites without a
  clearer `launcher`, `player`, or `media control` lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `display shells` and `media surfaces`, not generic
  productivity overlays;
- allow both polished shells and rough proof-of-concepts when they show a
  distinct media or launcher boundary.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where the app list, media state, or playback source comes from;
- whether the repo renders captured windows, mpv output, or an ordinary UI
  shell into the overlay;
- how the overlay and the external launcher or media tool communicate.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 53 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` where this wave leaves honest follow-up
  nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies focused
  `launcher/media overlay` methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `media shells` stay distinct from generic desktop mirror suites;
- the family clearly separates `launcher shell`, `player state controller`,
  `window/video display surface`, and `rough embed proof-of-concept`;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 53 synthesis document exists with code-level findings;
4. the registry and families clearly represent media launcher and playback
   overlay surfaces;
5. new focused `media/control overlay` methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
