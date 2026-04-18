# GitHub Research Wave 10 Plan

- Date: `2026-04-18`
- Goal: run the next serious GitHub research wave for repositories that were
  not yet represented in `VR-apps-lab`, then convert the extracted ideas into
  structured research artifacts.

## Why this wave exists

After Wave 9, the repository had stronger coverage of:

- OpenXR runtime diagnostics and inventories;
- headless overlay hosts;
- dashboard micro-utilities;
- creator and research helper tools.

What was still underrepresented were:

- `full OpenXR runtime implementations` that can inform doctor/runtime tooling;
- `vendor shell replacement` and runtime auto-redirect helpers;
- `headsetless and null-driver workflows` for SteamVR development;
- `mixed-runtime and mixed-controller bridge drivers`;
- `capture bridges` that pull SteamVR imagery into external creator tools;
- `runtime hygiene and compositor-fix layers` for narrow platform pain points.

## Search scope

Primary search directions for this wave:

- OpenXR runtimes and runtime replacements
- SteamVR/OpenVR environment helpers and no-HMD workflows
- mixed-VR controller or headset bridge drivers
- capture and streaming-side OpenVR integrations
- custom SteamVR drivers useful for development without real hardware

## Frozen shortlist for code-level study

- `mbucchia/VirtualDesktop-OpenXR`
- `BnuuySolutions/OculusKiller`
- `ChristophHaag/SteamVR-OpenHMD`
- `username223/SteamVRNoHeadset`
- `baffler/OBS-OpenVR-Input-Plugin`
- `Hotrian/OpenVRTwitchChat`
- `mm0zct/Oculus_Touch_Steam_Link`
- `SlimeVR/SlimeVR-OpenVR-Driver`
- `n1ckfg/ViveTrackerExample`
- `BnuuySolutions/SteamVRLinuxFixes`
- `oleuzop/VirtualSteamVRDriver`
- `craftyinsomniac/WFOVFix`

## Secondary candidates discovered in the same wave

- `alexander-clarke/openvr-room-mapping`

## Execution model

### Step 1: Search and deduplicate

- search GitHub with focused `gh search repos` queries;
- compare candidate repositories against `catalog/project-registry.md`;
- reject duplicates, shallow forks, and off-scope XR links.

### Step 2: Freeze the shortlist

- keep the wave bounded;
- prefer repositories that add a clear new method, family node, or product
  pattern.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep cloned sources local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- README and project intent;
- build, install, or runtime-registration model;
- key runtime, overlay, driver, or service modules;
- settings, manifests, registry hooks, or persistence model;
- unusual UX or engineering choices worth extracting.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new wave synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md` if the wave clarifies new reusable
  methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- repository structure and navigation remain coherent;
- links are valid and public-facing;
- registry, families, methods, and backlog stay aligned;
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
