# GitHub Research Wave 143 Plan

- Date: `2026-06-05`
- Goal: study WebAR marker/image tracking, model-viewer AR surfaces, A-Frame
  AR helpers, and lightweight scene-understanding utilities as reusable
  browser XR placement patterns.

## Why this wave exists

The repository has many VR overlay and runtime references, but AR placement and
scene-understanding flows are also reusable for future mixed-reality utility
tools. This wave focuses on browser-native AR tracking, model placement,
fallback launch surfaces, and lightweight feature wrappers.

## Search scope

Primary search directions:

- marker/image tracking libraries;
- A-Frame AR component layers;
- model-viewer AR placement and fallback launchers;
- WebXR hit-test, anchors, planes, light, and depth helpers;
- small WebAR starter references.

## Frozen shortlist for code-level study

- `hiukim/mind-ar-js`
- `AR-js-org/AR.js`
- `akbartus/Simple-AR`
- `chenzlabs/aframe-ar`
- `google/model-viewer`
- `tentone/enva-xr`

## Execution model

### Step 1: Search and deduplicate

- search by WebAR, marker tracking, image target, A-Frame AR, model-viewer AR,
  hit-test, planes, light estimation, and depth families;
- deduplicate against prior passthrough, WebXR samples, A-Frame, and Quest MR
  waves.

### Step 2: Freeze the shortlist

- include canonical marker/image tracking, micro-starter, AR component layer,
  production model viewer, and environment-aware WebXR renderer references.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- target compilers and tracking controllers;
- A-Frame systems/components for anchors, planes, cameras, and raycasters;
- marker found/lost and location-based event flows;
- model-viewer AR mode selection and hotspot/annotation surfaces;
- WebXR session feature negotiation for hit-test, anchors, light, and depth;
- caveats around browser/device support and older WebAR stacks.

### Step 5: Promote findings into repository structure

Update Wave 143 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when browser AR placement, marker tracking, and
scene-understanding patterns are documented as reusable methods for future MR
utility surfaces.
