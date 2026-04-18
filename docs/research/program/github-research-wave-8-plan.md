# GitHub Research Wave 8 Plan

- Date: `2026-04-18`
- Goal: run a serious GitHub discovery wave for VR utility/tool/helper app
  repositories that are not yet in `VR.app`, then turn the results into
  structured research artifacts.

## Adjustment to the original idea

The original sequence was directionally right, but it needed one improvement:

do not clone everything immediately.

The better workflow is:

1. search broadly;
2. deduplicate against the registry;
3. freeze a shortlist;
4. clone only the shortlist into a local-only cache;
5. do code-level study;
6. promote findings into the repository structure.

This keeps the research repeatable and avoids turning the workspace into an
unbounded mirror of GitHub.

## Wave objectives

This wave should:

- find repositories missing from the current registry;
- deepen coverage on mature but still untracked utility patterns;
- improve repository structure so future waves are easier;
- extract reusable methods, not only repository names.

## Search scope

Primary families targeted in this wave:

- SteamVR/OpenVR overlay implementations
- OpenXR overlay utilities
- SteamVR environment helpers
- battery and micro-monitor tools
- lightweight accessibility and communication helpers

## Shortlist frozen for code-level study

- `sh-akira/VROverlay`
- `BenWoodford/SteamVR-Webkit`
- `beniwtv/vr-streaming-overlay`
- `Nyabsi/steamvr_overlay_vulkan`
- `Beyley/eepyxr`
- `matzman666/OpenVR-MicrophoneControl`
- `simonowen/dashfix`
- `sencercoltu/steamvr-undistort`
- `W-Drew/SteamVR-Toggle`
- `elvissteinjr/SteamVR-VoidScene`
- `copperpixel/steamvrbattery`

## Secondary candidates discovered in the same wave

- `KainosSoftwareLtd/VRSceneOverlay`
- `artumino/SteamVR_HUDCenter`
- `LapisGit/LapisOverlay`
- `elvissteinjr/SteamVR-PrimaryDesktopOverlay`
- `Nexz/turncountervr`
- `vrkit-platform/vrkit-platform`
- `LunarG/OpenXR-Overlays-UE4-Plugin`
- `KaftanOS/SteamVR-Battery-Checker`
- `DavidRisch/steamvr_utils`
- `choyai/SteamVRTrackerUtility`
- `mbucchia/_ARCHIVE_OverXR`

## Execution model

### Step 1: Audit current coverage

Use:

- `catalog/project-registry.md`
- `landscape/project-families.md`
- `landscape/not-yet-studied-deeply.md`

### Step 2: Search GitHub

Use `gh search repos` across focused VR utility queries and remove what is
already in the registry.

### Step 3: Freeze shortlist

Promote only the most useful repositories into the current wave.

### Step 4: Sync local source cache

Clone shortlisted repositories into `.research-sources/github/` using the local
cache workflow.

### Step 5: Deep pass

Inspect:

- README and project goals;
- folder structure;
- build and packaging choices;
- manifests and settings;
- key overlay/runtime/service modules;
- unusual UX patterns or runtime hacks.

### Step 6: Extract into repository structure

Update:

- `landscape/` for wave synthesis;
- `catalog/` for canonical coverage;
- `project-families.md` for overlap grouping;
- `methods/` for reusable approaches;
- `discovery/` for process and next search directions.

### Step 7: Verify before publishing

Check:

- links and navigation updates;
- registry and family consistency;
- local source cache stays ignored;
- no accidental vendoring of cloned repos.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlisted repos are cloned locally and inspected;
3. a new wave synthesis doc exists with per-project extraction;
4. the registry and families include the new coverage;
5. methods and discovery docs are updated;
6. the result is verified and pushed to GitHub.
