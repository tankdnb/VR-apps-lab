# GitHub Research Wave 14 Plan

- Date: `2026-04-19`
- Goal: run the next serious GitHub research wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `tracker-ingress drivers`, `OSC/input export`, `SteamVR role reuse`, and
  `direct-to-consumer bridge utilities` across `SteamVR/OpenVR` and
  `VRChat-adjacent` workflows.

## Why this wave exists

After Wave 13, the repository had much stronger coverage of:

- vision-based tracking and camera sidecars;
- plugin-based tracking hosts and body-tracking platforms;
- classic virtual-tracker drivers and OSC-driven tracker families;
- mixed-runtime and headsetless workflow research.

What was still underrepresented were:

- `generic external-program -> SteamVR driver ingress` paths that expose a
  named pipe or WebSocket instead of expecting a full in-driver sensor stack;
- `minimal OpenVR pose -> OSC exporters` that are useful as thin donor
  patterns even when they are not large products;
- `engine-side adapters` that reuse SteamVR tracker-role bindings and
  no-HMD-friendly tracking inside Unity or other host apps;
- `direct tracker/controller -> VRChat OSC` tools that bypass the need for a
  new SteamVR driver entirely.

## Search scope

Primary search directions for this wave:

- named-pipe and local-socket OpenVR bridge drivers;
- WebSocket tracker-driver forks and comparison variants;
- OpenVR pose-to-OSC exporters and control bridges;
- tracker-role helpers and no-HMD engine-side tracking adapters;
- VRChat OSC bridges driven by SteamVR inputs, trackers, or vendor SDK data.

## Frozen shortlist for code-level study

- `ju1ce/Simple-OpenVR-Bridge-Driver`
- `3NekoSystem/OpenVR-Tracker-Websocket-Driver`
- `v0xie/OpenVR-Tracker-Websocket-Driver`
- `BarakChamo/OpenVR-OSC`
- `choyai/SteamVRTrackerUtility`
- `biosmanager/unity-openvr-tracking`
- `JLChnToZ/axis-vrc-osc-bridge`
- `I5UCC/VRCThumbParamsOSC`

## Secondary candidates discovered in the same wave

- `TheNexusAvenger/Enigma`
- `ThatGuyThimo/leapmotion-osc`

## Execution model

### Step 1: Search and deduplicate

- search GitHub by `bridge family` and `transport pattern`, not by generic XR
  keywords only;
- compare every candidate against `catalog/project-registry.md`;
- reject already-covered repos unless the current note is too shallow or the
  fork adds a materially different ingress/egress pattern.

### Step 2: Freeze the shortlist

- keep the wave bounded around `tracker ingress`, `OSC export`, and
  `role-binding reuse`;
- prefer repositories that expose a reusable transport boundary, pose-export
  model, no-HMD workflow, or direct-consumer product pattern.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep cloned sources local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- README and actual product framing;
- driver, sidecar, or host-app split;
- transport boundary such as `named pipe`, `WebSocket`, `OSC`, or
  `SteamVR action manifest`;
- settings, role mapping, persistence, and auto-launch behavior;
- whether the repo is a real donor, a product reference, or only a useful
  comparison variant.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 14 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md` where this wave sharpens reusable
  tracker-ingress, role-reuse, and OSC-export methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- repository structure and navigation remain coherent;
- newly added or promoted projects land in the correct registry section and
  overlap families;
- follow-up backlog stays honest about true variants versus real new donors;
- `.research-sources/` remains ignored by git;
- no local-only source clones are accidentally vendored into the public repo.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 14 synthesis document exists with code-level findings;
4. newly studied repositories are promoted into the registry and overlap
   families;
5. new follow-up candidates and variant decisions are reflected in the
   backlog;
6. methods and navigation are updated where justified;
7. the result is reviewed and pushed to GitHub.
