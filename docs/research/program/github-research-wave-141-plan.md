# GitHub Research Wave 141 Plan

- Date: `2026-06-05`
- Goal: study browser-based XR editors, live-coding sandboxes, visual
  workspaces, and scene tooling as reusable authoring and utility-surface
  references.

## Why this wave exists

VR utilities often need editor-like behavior: asset selection, scene panels,
runtime previews, project files, live code, persistent state, and readable 3D
text/UI. Browser/editor projects expose those patterns without requiring a
single shipping VR app.

## Search scope

Primary search directions:

- browser scene editors and asset pipelines;
- WebXR/live-coding sandboxes;
- React/Three visual workspaces;
- template-based VR creation systems;
- Three.js UI/text infrastructure useful for VR surfaces.

## Frozen shortlist for code-level study

- `playcanvas/editor`
- `tentone/nunuStudio`
- `pmndrs/triplex`
- `brianpeiris/RiftSketch`
- `teliportme/remixvr`
- `protectwise/troika`

## Execution model

### Step 1: Search and deduplicate

- search by WebXR editor, browser 3D editor, live-coding VR, WebGL scene
  editor, and Three.js UI/text families;
- deduplicate against prior creative-tool, A-Frame, WebXR utility, and social
  XR waves.

### Step 2: Freeze the shortlist

- include large editor architecture, self-contained editor apps, source-driven
  visual workspaces, live-coding VR, template publishing, and UI/text
  infrastructure.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- method/event buses;
- observer history and asset virtual paths;
- realtime document/room state;
- scene/resource/project-file models;
- code-to-visual editor metadata extraction;
- in-VR code panels and error surfaces;
- template publishing flows;
- 3D text, flex layout, facade, worker, and SDF infrastructure.

### Step 5: Promote findings into repository structure

Update Wave 141 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when browser/editor patterns are documented as reusable
methods for future VR utility tools, not as generic web-app references.
