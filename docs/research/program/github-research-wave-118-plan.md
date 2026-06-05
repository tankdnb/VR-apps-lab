# GitHub Research Wave 118 Plan

- Date: `2026-06-05`
- Goal: study Unreal VR interaction, hand tracking, comfort, tracker, and
  multiplayer interaction plugin repositories as reusable references for
  engine-side XR utility architecture.

## Why this wave exists

Unity XR and Quest MR samples are already represented in recent waves. Unreal
has a different reuse shape: plugin modules, motion-controller components,
Blueprint-friendly primitives, replicated grip systems, OpenXR extension
plugins, and comfort post-process effects.

This wave studies Unreal VR projects as references for interaction frameworks,
near/far UI, replicated hand/controller behavior, comfort settings, tracker
role exposure, and compact OpenXR hand-tracking adapters.

## Search scope

Primary search directions for this wave:

- Unreal VR interaction and grip frameworks;
- Blueprint/C++ locomotion, grab, gaze, gesture, and climb components;
- MR/hand UI toolkits for Unreal;
- comfort vignette/tunnelling plugins;
- OpenXR hand tracking and Vive tracker extension plugins;
- modern Unreal XR multiplayer interaction utilities.

## Frozen shortlist for code-level study

- `mordentral/VRExpansionPlugin`
- `1runeberg/RunebergVRPlugin`
- `microsoft/MixedReality-UXTools-Unreal`
- `sigtrapgames/VrTunnellingPro-UE4`
- `demonixis/FSOpenXRHandTracking`
- `Rectus/UE4OpenXRViveTrackerPlugin`
- `V4C38/ue5-xrcore`

## Execution model

### Step 1: Search and deduplicate

- search GitHub by Unreal VR interaction, OpenXR hand tracking, Vive tracker,
  comfort tunnelling, replicated grip, hand menu, near/far UI, and XRCore
  families;
- compare candidates against registry and family docs;
- mark archived projects clearly if their value is primarily reference rather
  than current support.

### Step 2: Freeze the shortlist

- include replicated grip/movement, compact Blueprint-oriented components,
  MR UX primitives, comfort tunnelling, hand tracking, tracker extension, and a
  modern multiplayer interaction framework.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- plugin modules and public/private source boundaries;
- controller, grip, replication, movement, and locomotion components;
- hand tracking, skeleton, pinch, ray, and input action adapters;
- MR UI primitives, near/far pointers, simulation, manipulation constraints,
  menus, and touchables;
- comfort post-process materials and preset structures;
- OpenXR extension plugin role mapping and caveats.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 118 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- replicated interaction frameworks, UX primitives, comfort plugins, hand
  adapters, and tracker extension plugins remain separate method families;
- archived Microsoft UXTools is described as a reference, not a current support
  guarantee;
- Unreal plugin lessons are compared to Unity/Godot/WebXR toolkits without
  flattening engine-specific boundaries;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 118 synthesis document exists with code-level findings;
4. registry and families represent Unreal XR donors clearly;
5. methods capture replicated grip, MR UX, comfort, hand tracking, tracker
   roles, and multiplayer interaction patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
