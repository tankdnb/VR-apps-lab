# GitHub Research Wave 148 Plan

- Date: `2026-06-05`
- Goal: study A-Frame GUI, locomotion, and reusable interaction component
  primitives that can inform browser-backed VR utility menus and control
  surfaces.

## Why this wave exists

Recent WebXR waves mapped framework-level session and input substrates. This
wave steps one level up into reusable A-Frame UI and interaction components:
buttons, flex-like panels, teleport rays, semantic grab/drop events, menu
registries, and hand-tracking press surfaces.

## Search scope

Primary search directions:

- A-Frame GUI component libraries;
- teleportation and locomotion helpers;
- controller, hand, mouse, and touch interaction normalizers;
- menu registries and lifecycle-managed spatial UI;
- A-Frame world/menu construction kits.

## Frozen shortlist for code-level study

- `rdub80/aframe-gui`
- `fernandojsg/aframe-teleport-controls`
- `wmurphyrd/aframe-super-hands-component`
- `Minty-Crisp/AUXL`
- `SvetimFM/aframe-webxr-ui-toolkit`

## Execution model

### Step 1: Search and deduplicate

- search by A-Frame GUI, teleport controls, grab/drop interactions, hand UI,
  spatial menu registry, and WebXR UI toolkit families;
- deduplicate against prior A-Frame, hand-input, spatial UI, and framework
  waves.

### Step 2: Freeze the shortlist

- include a widget library, a locomotion helper, a semantic interaction
  normalizer, a large world/menu factory stack, and a small menu registry with
  hand press support.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/`;
- keep all source clones local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- component schemas and entry points;
- interaction event vocabularies;
- hover, focus, press, click, grab, stretch, drag, and drop flows;
- menu lifecycle and cleanup;
- controller, hand, mouse, and touch normalization;
- layout, styling, and callback binding models;
- caveats around global callbacks, framework scope, and old A-Frame patterns.

### Step 5: Promote findings into repository structure

Update Wave 148 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when reusable A-Frame GUI, locomotion, interaction, and
menu patterns are documented as component-level donors for future
`VR-apps-lab` browser utility shells.
