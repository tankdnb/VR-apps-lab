# GitHub Research Wave 52 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `overlay render scaffolds`, `UI-to-texture bridges`, and
  `engine-native projection-overlay extensions`.

## Why this wave exists

`VR-apps-lab` already had several overlay hosts and finished utility suites,
but another adjacent branch still needed a cleaner donor map:

- very small overlay samples that show the shortest path from window or texture
  to `OpenVR`;
- modern UI stacks such as `ImGui` rendered into overlay textures with input
  forwarded back from `OpenVR`;
- engine-native overlay extensions that let an ordinary 3D scene behave like a
  projection overlay instead of a full scene application;
- tiny Unity helpers that reduce repeated overlay boilerplate.

This wave exists to make
`overlay render scaffolds, UI-to-texture bridges, and engine-native projection overlays`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- `OpenVR overlay` samples and templates that expose rendering and event loops;
- `ImGui` or immediate-mode UI overlays that forward controller or mouse input;
- engine-specific overlay wrappers for `Godot`, `Unity`, or similar;
- low-friction helper libraries that simplify texture submission and overlay
  transforms.

## Frozen shortlist for code-level study

- `foxt/csharp-openvr-overlay-imgui`
- `hiinaspace/godot-openvr-overlay`
- `ondorela/OpenVROverlay_imgui`
- `thomasmo/SampleVRO`
- `ovrlay/LibOverlay`

## Secondary candidates surfaced in the same wave

- `Marlamin/VROverlayTest`
- `ephemeral-laboratories/ComposeVR`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for `OpenVR overlay`, `ImGui overlay`, `Godot overlay`, and
  `Unity overlay helper` repos;
- compare results against `catalog/project-registry.md`;
- reject repos that only duplicate already-studied mainline donors such as
  `steamvr_overlay_vulkan`, `HeadlessOverlayToolkit`, or `OVROverlayManager`
  without a clearer new lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `construction methods`, not finished end-user
  overlay suites;
- allow both samples and thin helpers when they expose a distinct render loop,
  event bridge, or engine integration boundary.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how overlay handles are created and registered;
- how textures are produced, updated, and submitted;
- where overlay input events are translated back into UI or engine actions;
- whether the repo is a tiny sample, a toolkit, or an engine-native extension.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 52 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies overlay
  scaffold and projection-overlay methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `overlay scaffold` donors stay separate from finished overlay products;
- the family clearly distinguishes `tiny samples`, `UI bridges`,
  `engine-native extensions`, and `thin helper libraries`;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 52 synthesis document exists with code-level findings;
4. the registry and families clearly represent overlay scaffolds and
   projection-overlay extensions;
5. new overlay-construction methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
