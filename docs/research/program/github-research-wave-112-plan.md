# GitHub Research Wave 112 Plan

- Date: `2026-06-05`
- Goal: run a focused GitHub research wave for `WebXR` browser APIs,
  input-profile registries, emulator/devtools layers, polyfill lineage, and
  React/Three XR wrappers.

## Why this wave exists

`VR-apps-lab` has many native, Unity, OpenVR, and OpenXR references, but browser
XR deserves its own family because it exposes a different product shape:
instant-access demos, web-based operator panels, controller-profile rendering,
browser emulator workflows, and framework-level session stores.

This wave studies WebXR projects as reusable references for lightweight XR
tools, browser-first diagnostics, controller visualization, and rapid UI
experiments.

## Search scope

Primary search directions for this wave:

- WebXR sample applications and canonical API exercises;
- WebXR input profile registries and controller asset tooling;
- browser extension or devtools-style WebXR emulation;
- historical WebXR/WebVR polyfill layers;
- React Three Fiber or Three.js wrappers around WebXR sessions and input.

## Frozen shortlist for code-level study

- `immersive-web/webxr-samples`
- `immersive-web/webxr-input-profiles`
- `meta-quest/immersive-web-emulator`
- `mozilla/webxr-polyfill`
- `pmndrs/xr`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for WebXR samples, input profiles, emulator, polyfill, and
  React/Three XR wrapper families;
- compare surfaced repositories against registry and family docs;
- treat deprecated polyfill lineage as architecture history, not as a modern
  implementation recommendation.

### Step 2: Freeze the shortlist

- keep the wave centered on browser-native XR workflows;
- include one canonical sample suite, one input-profile registry, one emulator
  extension, one historical polyfill, and one modern framework wrapper.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- session creation and feature negotiation;
- inline versus immersive mode handling;
- reference-space and teleport models;
- input-source, gamepad, hand, and controller-profile handling;
- emulator or runtime-injection boundary;
- framework store and event abstractions;
- caveats around browser support, deprecation, and framework coupling.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 112 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- WebXR browser references are not mixed with native OpenXR runtime layers;
- deprecated polyfill material is labeled clearly;
- controller-profile and emulator methods are extracted as reusable patterns;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 112 synthesis document exists with code-level findings;
4. registry and families represent browser-native XR donors clearly;
5. new methods capture WebXR session shells, input profiles, emulators,
   polyfills, and framework stores;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
