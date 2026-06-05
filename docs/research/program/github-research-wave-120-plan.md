# GitHub Research Wave 120 Plan

- Date: `2026-06-05`
- Goal: study ALVR/WiVRn ecosystem sidecars and platform-specific streaming
  helpers as reusable references for standalone-headset clients, runtime
  bridge variants, face-tracking adapters, USB forwarding, and timing
  inspection utilities.

## Why this wave exists

`ALVR` and `WiVRn` were already studied as major streaming stacks, so this wave
does not restudy the main projects. It focuses on adjacent repositories that
show how a large streaming ecosystem grows through sidecars: platform clients,
runtime forks, tracking modules, wired-mode helpers, and latency/timing viewers.

The reusable value for `VR-apps-lab` is the product boundary: a future VR
utility does not always need to own the whole runtime or streamer. It can be a
small companion that makes one setup path, telemetry path, or data bridge
clearer.

## Search scope

Primary search directions for this wave:

- ALVR platform-specific clients and streamer companions;
- Monado/OpenXR remote-driver and streaming-runtime variants;
- VRCFaceTracking modules that consume ALVR eye/face payloads;
- ADB/USB forwarding helpers for wired headset streaming;
- WiVRn timing, preset, and telemetry micro-utilities.

## Frozen shortlist for code-level study

- `alvr-org/alvr-visionos`
- `alvr-org/Monado-ALVR`
- `alvr-org/VRCFT-ALVR`
- `AtlasTheProto/ADBForwarder`
- `Kierek/WiVRnTimings`

## Execution model

### Step 1: Search and deduplicate

- search GitHub by ALVR, WiVRn, visionOS client, Monado ALVR, VRCFT ALVR, and
  ADB forwarding families;
- deduplicate against `project-registry.md` and `project-families.md`;
- exclude already studied mainline projects such as `alvr-org/ALVR` and
  `WiVRn/WiVRn` from the new shortlist.

### Step 2: Freeze the shortlist

- include one platform client, one runtime bridge variant, one face-tracking
  adapter, one wired-mode helper, and one timing viewer.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- client lifecycle, renderer, decoder, and tracking/event boundaries;
- runtime/remote-driver or OpenXR service integration model;
- eye/face payload parsing and unified-expression mapping;
- ADB server, device monitor, and port-forwarding flow;
- timing preset parsing and visual inspection model;
- constraints and caveats around platform APIs, forks, and thin utilities.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 120 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- mainline ALVR/WiVRn are not duplicated as new discoveries;
- sidecars are placed as ecosystem extensions;
- found projects are not built, launched, or installed;
- `.research-sources/` remains local-only;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in local cache;
3. a Wave 120 synthesis document exists with code-level findings;
4. registry and families represent streaming ecosystem sidecars clearly;
5. methods capture platform-client, telemetry, face-payload, and USB-forwarding
   patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
