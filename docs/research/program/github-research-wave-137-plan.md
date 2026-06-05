# GitHub Research Wave 137 Plan

- Date: `2026-06-05`
- Goal: study VR creative authoring, drawing/modeling tools, and in-headset
  tool/menu systems as reusable references for complex VR utility UX.

## Why this wave exists

Creative VR tools are rich examples of menus, shelves, brush catalogs,
controller command maps, undoable edit histories, exports, and in-headset
workflow state. Even when the projects are too large to copy directly, they
teach how mature VR utilities organize tools, modes, panels, and assets.

## Search scope

Primary search directions:

- VR painting and sketching tools;
- Tilt Brush/Open Brush lineage;
- VR modeling and export tools;
- WebXR/A-Frame authoring surfaces;
- in-headset shelves, menus, brush catalogs, and command systems.

## Frozen shortlist for code-level study

- `googlevr/tilt-brush`
- `icosa-foundation/open-brush`
- `googlevr/blocks`
- `SideQuestVR/SideSketch`
- `zach-capalbo/vartiste`

## Execution model

### Step 1: Search and deduplicate

- search by VR painting, VR modeling, WebXR authoring, brush catalog, and tool
  shelf families;
- deduplicate against prior browser-native creative and WebXR utility waves.

### Step 2: Freeze the shortlist

- include canonical archived projects, active fork lineage, and browser-native
  creative tool variants;
- mark forks/variants honestly instead of treating every fork as a new donor.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- app-state and initialization lifecycles;
- brush, environment, and asset catalogs;
- panel/shelf/menu systems;
- command and undo models;
- export/upload flows;
- scripting/API and multiplayer extension points.

### Step 5: Promote findings into repository structure

Update Wave 137 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when VR creative-tool architecture is documented as
reusable menu, catalog, command, shelf, and export patterns rather than as a
generic list of art apps.
