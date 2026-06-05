# GitHub Research Wave 151 Plan

- Date: `2026-06-05`
- Goal: study social/world framework shells, scene schemas, and multi-user
  spatial app substrates as reusable references for collaborative VR utilities.

## Why this wave exists

Many VR utilities eventually become shared: remote diagnostics sessions,
collaborative dashboards, guided support, shared data viewers, or training
rooms. This wave studies world/runtime frameworks that manage scene schema,
avatars, media, networking, services, and app modules.

## Search scope

Primary search directions:

- WebXR social world frameworks;
- scene JSON/schema and semantic graph loaders;
- networked A-Frame rooms and avatars;
- MQTT or WebSocket-backed scene state;
- Jitsi/WebRTC spatial media objects;
- headless/social VR clients and avatar packet formats;
- app-runtime/module systems for spatial worlds.

## Frozen shortlist for code-level study

- `phoenixbf/aton`
- `PlumCantaloupe/circlesxr`
- `arenaxr/arena-web-core`
- `BasisVR/Basis`
- `webaverse-studios/webaverse`

## Execution model

### Step 1: Search and deduplicate

- search by social WebXR, scene schema, A-Frame networked worlds, ARENA,
  headless social VR client, and web metaverse runtime families;
- deduplicate against prior networked/social XR waves.

### Step 2: Freeze the shortlist

- include a semantic scene hub, a Networked-AFrame world shell, an MQTT/Jitsi
  scene client, a Unity/social VR server and headless client stack, and a
  browser world/app runtime.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/`;
- keep all source clones local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- scene schema and parser boundaries;
- semantic graph, scene graph, and spatial UI layers;
- avatar and media object flows;
- networked object ownership and world identity;
- controller/hand publishing, text input, screen share, and spatial audio;
- headless avatar clients and compressed packet formats;
- app module/import/runtime and world manager boundaries.

### Step 5: Promote findings into repository structure

Update Wave 151 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when social/world runtime patterns are documented as
reusable references for collaborative `VR-apps-lab` utilities and shared
diagnostics surfaces.
