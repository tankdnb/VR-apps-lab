# GitHub Research Wave 147 Plan

- Date: `2026-06-05`
- Goal: study core WebXR framework foundations and engine-level XR abstractions
  that can inform future browser-backed VR utility shells.

## Why this wave exists

Many prior waves studied individual WebXR apps and samples. This wave studies
the framework substrate underneath them: how engines expose XR sessions,
input, hands, DOM overlays, feature managers, locomotion, layers, and
testable/runtime control surfaces.

## Search scope

Primary search directions:

- core WebXR renderer/session managers;
- engine feature managers for WebXR modules;
- controller/hand abstractions;
- DOM overlay and layer surfaces;
- action/locomotion systems;
- testable XR development tooling.

## Frozen shortlist for code-level study

- `mrdoob/three.js`
- `BabylonJS/Babylon.js`
- `playcanvas/engine`
- `facebook/immersive-web-sdk`

## Execution model

### Step 1: Search and deduplicate

- search by WebXR engine, WebXR manager, WebXR hand/input, WebXR DOM overlay,
  WebXR layers, and XR dev tooling families;
- deduplicate against prior WebXR sample and wrapper waves where these engines
  appeared only indirectly.

### Step 2: Freeze the shortlist

- include a minimal renderer-level manager, two engine feature/service manager
  stacks, and one newer framework with ECS, spatial UI, and dev-control tools.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/`;
- keep all source clones local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- XR session lifecycle and reference-space handling;
- controller target-ray, grip, and hand coordinate spaces;
- input source change handling and event normalization;
- hand joint/finger abstractions;
- feature registration and session-init extension;
- DOM overlay, layers, hit-test, and teleportation surfaces;
- runtime/dev tooling that can simulate or control XR sessions.

### Step 5: Promote findings into repository structure

Update Wave 147 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when WebXR framework foundations are documented as
reusable session, input, feature, and testing patterns for future
`VR-apps-lab` browser utility shells.
