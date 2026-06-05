# GitHub Research Wave 138 Plan

- Date: `2026-06-05`
- Goal: study networked/social XR frameworks, room clients, and multi-user
  state substrates as reusable references for collaborative VR utilities.

## Why this wave exists

Many future VR utility tools will need rooms, presence, permissions, remote
state, avatars, voice, media, or diagnostic collaboration. Social XR projects
are often too large to reuse directly, but they contain strong architecture
patterns for room channels, network scenes, ownership, permissions, and
component-level state sync.

## Search scope

Primary search directions:

- Unity research networking frameworks;
- WebXR social room clients;
- spatial web/world clients;
- room/presence/permission systems;
- shared avatar, media, voice, and component-state substrates.

## Frozen shortlist for code-level study

- `UCL-VR/ubiq`
- `mozilla/hubs`
- `janusvr/janusweb`
- `vrsys/vrsys-core`

## Execution model

### Step 1: Search and deduplicate

- search by social XR, WebXR rooms, Unity networking, spatial web, and VR
  collaboration framework families;
- deduplicate against browser shell, WebXR samples, and social VR ecosystem
  waves.

### Step 2: Freeze the shortlist

- include one research-friendly Unity networking substrate, two web/spatial
  clients, and one Unity framework composition baseline.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- room servers and clients;
- peer connection and WebRTC signaling;
- presence and permission events;
- networked component models;
- declarative world/viewer embedding;
- Unity prefab/package composition.

### Step 5: Promote findings into repository structure

Update Wave 138 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when social/networked XR substrates are documented as
reusable room, presence, permission, state-sync, and collaborative-diagnostics
patterns.
