# GitHub Research Wave 149 Plan

- Date: `2026-06-05`
- Goal: study immersive analytics, spatial data visualization, and scientific
  viewer substrates as reusable foundations for VR diagnostics and data-rich
  utility surfaces.

## Why this wave exists

Many VR utilities eventually need to show data: graphs, device state,
measurements, scientific models, or time-varying telemetry. This wave studies
projects that make data visualization and scientific inspection work inside
3D, WebXR, A-Frame, or notebook-backed environments.

## Search scope

Primary search directions:

- immersive analytics grammars;
- A-Frame/Three graph visualization components;
- scientific viewer plugin shells;
- XR-aware camera, selection, and state managers;
- notebook-to-WebGL visualization bridges;
- volume, scatter, and graph data transfer patterns.

## Frozen shortlist for code-level study

- `vriajs/vria`
- `vasturiano/3d-force-graph-vr`
- `vasturiano/aframe-forcegraph-component`
- `molstar/molstar`
- `widgetti/ipyvolume`

## Execution model

### Step 1: Search and deduplicate

- search by immersive analytics, WebXR graph, A-Frame graph, scientific
  WebGL viewer, XR molecule viewer, and notebook 3D visualization families;
- deduplicate against prior browser-native utility and data-visualization
  waves.

### Step 2: Freeze the shortlist

- include one immersive analytics grammar, two force-graph layers, one large
  scientific viewer with XR support, and one notebook/widget data bridge.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/`;
- keep all source clones local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- config grammar and compiler boundaries;
- view, axis, legend, filter, selection, and mark rendering;
- graph accessor schemas and raycaster event handling;
- viewer state, command, manager, and snapshot architecture;
- XR input and camera mapping for scientific viewers;
- notebook trait synchronization and data serialization.

### Step 5: Promote findings into repository structure

Update Wave 149 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when immersive analytics and scientific viewer patterns
are documented as reusable data-surface donors for future `VR-apps-lab`
diagnostics, dashboards, and inspection tools.
