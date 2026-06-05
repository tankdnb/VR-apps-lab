# GitHub Research Wave 142 Plan

- Date: `2026-06-05`
- Goal: study VRM/avatar web stacks, model specs, runtime loaders, and browser
  avatar/mocap surfaces as reusable avatar integration references.

## Why this wave exists

Avatar systems connect many existing `VR-apps-lab` families: OSC pose streams,
VMC, MediaPipe tracking, VRChat face/body inputs, browser XR, and creator
tools. This wave focuses on VRM as the common model/runtime/spec layer.

## Search scope

Primary search directions:

- VRM Unity runtime/editor tooling;
- Three.js VRM loaders and runtime modules;
- A-Frame VRM components;
- browser avatar/mocap surfaces;
- VRM specification and extension schema repositories.

## Frozen shortlist for code-level study

- `vrm-c/UniVRM`
- `pixiv/three-vrm`
- `binzume/aframe-vrm`
- `ButzYung/SystemAnimatorOnline`
- `vrm-c/vrm-specification`

## Execution model

### Step 1: Search and deduplicate

- search by VRM, three-vrm, A-Frame VRM, browser avatar, MediaPipe avatar, and
  VRM specification families;
- deduplicate against prior VMC/VRM, MediaPipe, avatar setup, and face-tracking
  waves.

### Step 2: Freeze the shortlist

- include canonical spec/runtime projects, engine/web loaders, component glue,
  and a browser avatar/mocap surface.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- import/export and migration flows;
- humanoid, first-person, expression, look-at, spring-bone, constraint, and
  metadata systems;
- Three.js loader plugin composition;
- A-Frame component APIs and mimic/poser helpers;
- browser mocap/avatar rendering and legacy constraints;
- spec extension schemas and compatibility notes.

### Step 5: Promote findings into repository structure

Update Wave 142 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when VRM is documented as a reusable avatar runtime and
protocol layer for future VR utilities rather than only as a character model
format.
