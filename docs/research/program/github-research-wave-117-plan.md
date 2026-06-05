# GitHub Research Wave 117 Plan

- Date: `2026-06-05`
- Goal: study A-Frame and adjacent WebXR component repositories as reusable
  browser-native patterns for declarative XR utilities, scene inspection,
  locomotion, networked scenes, diagnostics, and hand UI.

## Why this wave exists

Wave 112 covered core WebXR APIs, input profiles, emulators, polyfills, and
React/Three wrappers. This wave moves one layer up: mature declarative
component ecosystems where XR utilities are assembled from HTML-like entities,
components, inspectors, controls, schemas, and browser-side debugging surfaces.

The target is not a game stack. The target is a browser utility substrate for
fast VR panels, diagnostics, operator UIs, hand/controller experiments, and
multi-user WebXR prototypes.

## Search scope

Primary search directions for this wave:

- A-Frame core and entity-component architecture;
- visual scene inspectors and live component editors;
- locomotion and input-control add-on packs;
- networked A-Frame and adapter-based scene synchronization;
- component libraries with in-VR logging, haptics, state, layout, and input
  helpers;
- hand-tracking extras and pinch/drag/teleport locomotion components.

## Frozen shortlist for code-level study

- `aframevr/aframe`
- `aframevr/aframe-inspector`
- `c-frame/aframe-extras`
- `networked-aframe/networked-aframe`
- `supermedium/superframe`
- `gftruj/aframe-hand-tracking-controls-extras`

## Execution model

### Step 1: Search and deduplicate

- search GitHub by A-Frame, WebXR component, inspector, networked scene,
  hand-tracking controls, locomotion, and in-VR diagnostics families;
- compare candidates against registry and family docs;
- avoid duplicating Wave 112 low-level WebXR API coverage by focusing on
  component composition and utility-level UX.

### Step 2: Freeze the shortlist

- include A-Frame core, visual inspector, locomotion/input extras, networked
  scene sync, component-library diagnostics, and hand-tracking extras.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- component, system, primitive, and scene-registration boundaries;
- inspector injection, scene graph, history, component editing, and entity
  export flows;
- locomotion aggregation and navmesh constraints;
- network adapter, schema, entity sync, and hand-control propagation;
- in-VR logs, haptics, input normalization, state, and reusable component
  packs;
- hand-joint helper API and pinch locomotion behaviors.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 117 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- A-Frame component-level findings are separated from lower-level WebXR API
  samples;
- devtool/inspector patterns remain visible as first-class utility methods;
- networked scene sync is captured as schema plus adapter architecture;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 117 synthesis document exists with code-level findings;
4. registry and families represent A-Frame/WebXR component donors clearly;
5. methods capture declarative components, inspectors, networked sync, and
   hand-locomotion extras;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
