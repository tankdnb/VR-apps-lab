# GitHub Research Wave 11 Plan

- Date: `2026-04-18`
- Goal: run the next serious GitHub research wave for repositories not yet
  represented in `VR.app`, focusing on runtime adapters, virtual-display
  drivers, validation helpers, driver examples, and creator/workflow
  micro-utilities.

## Why this wave exists

After Wave 10, the repository had stronger coverage of:

- runtime switchers and OpenXR doctor-style tools;
- bridge drivers and headsetless workflows;
- overlay hosts and creator-side capture integrations;
- SteamVR environment helpers and runtime hygiene tools.

What was still underrepresented were:

- `runtime adapter` projects that bridge incompatible graphics/runtime
  expectations;
- `library + sandbox` OpenXR frameworks that teach clean app bring-up;
- `virtual display and remote presentation` drivers;
- `driver examples` that stay much smaller than full bridge stacks;
- `validation and config-patch micro-tools`;
- `creator screenshot workflow` utilities and timed capture helpers.

## Search scope

Primary search directions for this wave:

- OpenXR API layers and runtime-adapter utilities
- engine-side runtime selector helpers
- OpenVR driver examples and virtual controller references
- virtual display and display-repurposing drivers
- SteamVR creator screenshot helpers
- SteamVR validation, manifest linting, and focused config patch tools

## Frozen shortlist for code-level study

- `mbucchia/OpenXR-Vk-D3D12`
- `shiena/OpenXRRuntimeSelector`
- `1runeberg/OpenXRProvider`
- `ValveSoftware/virtual_display`
- `finallyfunctional/openvr-driver-example`
- `SecondReality/VirtualControllerDriver`
- `oneup03/VRto3D`
- `BOLL7708/SuperScreenShotterVR`
- `iigomaru/Periodic-Immersive-SteamVR-Screenshots`
- `Virus-vr/SteamVRAdaptiveBrightness`
- `username223/SteamVR-ActionsManifestValidator`
- `Erimelowo/Lighthouse-Scale-Fix`

## Secondary candidates discovered in the same wave

- `OpenDisplayXR/OpenDisplayXR-VDD`

## Execution model

### Step 1: Search and deduplicate

- search GitHub with focused `gh search repos` queries;
- compare candidates against `catalog/project-registry.md`;
- reject repositories already covered in prior waves.

### Step 2: Freeze the shortlist

- keep the wave bounded around one coherent axis;
- prefer repositories that add a new method or sharpen an underdeveloped
  family.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep cloned sources local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- README and product intent;
- runtime registration, driver, or manifest model;
- key modules that reveal architecture;
- unusual workflow, UX, or automation patterns;
- settings, validation, or patch strategy where applicable.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 11 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md` where the wave adds reusable
  implementation methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- repository structure and navigation remain coherent;
- newly added projects land in the correct registry sections;
- family overlap stays understandable after the additions;
- follow-up backlog stays honest about partially studied entries;
- `.research-sources/` remains ignored by git.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 11 synthesis document exists with code-level findings;
4. newly studied repositories are promoted into the registry and overlap
   families;
5. newly exposed follow-up gaps are added to the deep-study backlog;
6. methods and navigation are updated where justified;
7. the result is reviewed and pushed to GitHub.
