# GitHub Research Wave 32 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `social overlays`, `communication sidecars`, and
  `VRChat-facing companion surfaces`.

## Why this wave exists

The repository already contained notification overlays, accessibility HUDs, and
some VRChat-adjacent tools, but it still lacked a tighter family around
`social utility surfaces`:

- voice and chat overlays that sit near ordinary desktop or stream workflows;
- local sidecars that expose `OSC`, `WebSocket`, or social-service outputs;
- VR companion tools that are closer to `communication utilities` than to
  generic dashboards.

This wave exists to make `social and communication tooling in VR` a more
explicit product branch inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- Discord or Twitch overlays for `SteamVR/OpenVR`;
- VRChat-adjacent chat, speech, or proximity sidecars;
- local speech or translation tools with `OSC` and `WebSocket` outputs;
- companion apps where the reusable lesson is a
  `communication surface`, `social bridge`, or `overlay sidecar`.

## Frozen shortlist for code-level study

- `designeerlabs/discord-vr`
- `kittynXR/VRCattoChatto`
- `Wolf-G88/vrchat-proximity-app`
- `Sharrnah/whispering`

## Secondary candidates surfaced in the same wave

- `MeroFune/GOpy`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for Discord VR overlay, Twitch OSC chat, VRChat proximity
  overlay, and local speech sidecar queries;
- compare results against `catalog/project-registry.md`;
- reject repos that only add a thin skin over an already better-studied donor.

### Step 2: Freeze the shortlist

- keep the wave centered on `communication surfaces` and `social sidecars`,
  not on generic overlay suites;
- allow one broader speech platform so the family includes a
  `utility host` comparison node, not only micro-overlays.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how the repo connects social, speech, or chat services to VR-facing outputs;
- whether the product is overlay-first, desktop-first, or hybrid;
- where `OSC`, `WebSocket`, browser automation, or local IPC boundaries appear;
- which UX lessons are reusable outside the original social platform.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 32 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies social and
  communication utility methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `social overlays` stay distinct from generic dashboard utilities;
- the family stays focused on communication surfaces, sidecars, and bridges;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 32 synthesis document exists with code-level findings;
4. the registry and families clearly represent social overlays and companion
   sidecars;
5. communication-sidecar methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
