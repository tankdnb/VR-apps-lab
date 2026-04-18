# GitHub Research Wave 9 Plan

- Date: `2026-04-18`
- Goal: run the next serious GitHub research wave for repositories that are not
  yet tracked by `VR-apps-lab`, then convert the useful findings into structured
  research artifacts.

## Why this wave exists

After Wave 8, the repository had stronger coverage of:

- overlay implementation references;
- SteamVR environment helpers;
- OpenXR overlay utilities;
- battery and small monitoring tools.

What was still underrepresented were:

- `OpenXR runtime intelligence` tools;
- `headless or background-hosted overlays`;
- `dashboard micro-utilities` that bridge into other desktop apps;
- `tracking development helpers` that are not full drivers but still expose
  reusable patterns.

## Search scope

Primary search directions for this wave:

- OpenXR runtime tools, inventories, simulators, and picker utilities
- SteamVR/OpenVR overlays not yet in the registry
- dashboard applications tied to audio, OSC, and VRChat workflows
- pairing, tracking, and scripting helpers around SteamVR/OpenVR

## Frozen shortlist for code-level study

- `KhronosGroup/OpenXR-Inventory`
- `rpavlik/xr-picker`
- `ValveSoftware/OpenXR-Canonical-Pose-Tool`
- `elliotttate/OpenXR-Simulator`
- `Hotrian/HeadlessOverlayToolkit`
- `rrkpp/SpotifyOverlay`
- `cnlohr/openvr_overlay_model`
- `JoeLudwig/overlay_experiments`
- `rrazgriz/VRCMicOverlay`
- `I5UCC/VRCTextboxSTT`
- `I5UCC/SteaMeeter`
- `ugokutennp/watchman-pairing-assistant`
- `TriadSemi/triad_openvr`

## Secondary candidates discovered in the same wave

- `Ybalrid/OpenXR-Runtime-Manager`
- `clear-xr/clearxr-server`
- `pembem22/etvr-openxr-layer`
- `Martin-Oehler/SteamVR-WebApps`
- `I5UCC/ParameterSaveStates`
- `Denwa/vive-wireless-info-overlay`
- `hai-vr/h-view`
- `MeroFune/GOpy`
- `biosmanager/unity-openvr-tracking`
- `MuffinTastic/openvr-device-positions`

## Execution model

### Step 1: Search and deduplicate

- search GitHub with focused `gh search repos` queries;
- compare results against `catalog/project-registry.md`;
- reject duplicates, weak forks, and non-relevant general XR links.

### Step 2: Freeze the shortlist

- keep the wave bounded;
- prefer repositories that add a new method, pattern, or family node.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep cloned sources local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- README and project intent;
- top-level folder layout;
- build/packaging/runtime registration model;
- key overlay/runtime/service modules;
- settings, manifests, or persistence model;
- unusual UX or engineering choices worth extracting.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new wave synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md` if a new method becomes clearer.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- repository structure and navigation remain coherent;
- links are valid and public-facing;
- registry/families/methods/backlog stay aligned;
- `.research-sources/` remains ignored by git;
- no cloned repositories are accidentally vendored into the public repo.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is cloned into the local source cache;
3. a new wave synthesis document exists with extracted findings;
4. newly studied projects are added to the registry and overlap families;
5. newly discovered follow-up candidates are added to the deep-study backlog;
6. methods or repository rules are updated where the new findings justify it;
7. the result is reviewed and pushed to GitHub.
