# GitHub Research Wave 108 Plan

- Date: `2026-06-05`
- Goal: run the next focused GitHub research wave for repositories that map
  `VRChat companion apps`, `OSC routers`, `plugin senders`, `data hubs`, and
  `web debug surfaces`.

## Why this wave exists

Recent avatar and world waves covered creator-side assets, prefabs, and
runtime helpers. A separate companion-app pass is useful because VR utilities
often live outside Unity and outside the headset runtime: desktop shells,
overlay feeds, OSC routers, plugin senders, TCP hubs, and browser panels.

This wave exists to make the `VRChat companion surface` branch more explicit:
not one app, but a family of external tools that expose social state, avatar
parameters, routing, telemetry, and operator control.

## Search scope

Primary search directions for this wave:

- VRChat companion apps with overlay or desktop surfaces;
- OSC routers and fan-out tools;
- plugin-hosted OSC sender frameworks;
- OSC-to-TCP or local data hubs;
- browser-based avatar parameter debug/control surfaces.

## Frozen shortlist for code-level study

- `vrcx-team/VRCX`
- `SutekhVRC/VOR`
- `YABam/VRCOSCGUI`
- `PlagueVRC/VRCOSCDataHub`
- `EveryDayCompute/VRCOSCWeb`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRChat companion, OSC router, OSC GUI, data hub, and web
  control-surface queries;
- compare surfaced repositories against registry and family docs;
- reject already-covered OSC tools unless they add a new architecture lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on companion and routing surfaces;
- include one large companion app, one router, one plugin sender host, one data
  hub, and one browser debug surface.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- app/runtime split and UI entry points;
- overlay rendering and feed model;
- OSC receive/send/routing code;
- packet filtering, debug, and route status;
- plugin extension contracts;
- TCP, WebSocket, or browser bridge model;
- caveats around scale, maintenance, and protocol assumptions.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 108 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- every companion or routing tool has a clear family placement;
- README-only descriptions are avoided for important donors;
- route, overlay, plugin, and web-surface caveats are visible;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 108 synthesis document exists with code-level findings;
4. registry and families represent VRChat companion, OSC routing, plugin,
   data-hub, and browser debug donors clearly;
5. new methods are captured where this wave clarified overlay feeds, OSC
   routers, plugin senders, TCP data hubs, or web avatar controls;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
