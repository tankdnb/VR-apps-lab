# GitHub Research Wave 110 Plan

- Date: `2026-06-05`
- Goal: run the next focused GitHub research wave for repositories that map
  `bHaptics SDKs`, `OSC bridges`, `lightweight relay wrappers`, and
  `telemetry-to-haptic adapters`.

## Why this wave exists

Haptics are a useful VR utility branch because they sit between game events,
avatar parameters, telemetry streams, log lines, browser apps, and physical
wearable devices. A haptics pass is also a good counterweight to visual overlay
research: useful VR tools can output through touch, not only through windows.

This wave exists to capture bHaptics as an integration surface: native SDK,
web SDK, Python API, VRChat OSC bridge, and generic relay tool.

## Search scope

Primary search directions for this wave:

- bHaptics native library and Player bridge APIs;
- browser or TypeScript haptics SDKs;
- Python haptics command surfaces;
- VRChat OSC-to-haptics bridges;
- generic log-tail or WebSocket relay wrappers.

## Frozen shortlist for code-level study

- `bhaptics/haptic-library`
- `bhaptics/tact-js`
- `bhaptics/tact-python`
- `HerpDerpinstine/bHapticsOSC`
- `Dteyn/bHapticsRelay`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for bHaptics SDK, tact-js, tact-python, bHaptics OSC, and
  haptics relay queries;
- compare surfaced repositories against registry and family docs;
- keep official SDKs and community bridge wrappers separate.

### Step 2: Freeze the shortlist

- keep the wave centered on haptics integration surfaces;
- include SDK facades, web/Python command layers, an avatar OSC bridge, and a
  generic app/game relay.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- registration and playback API shape;
- event, dot, path, glove, status, and device-management calls;
- WebSocket or Player connection model;
- OSC address mapping and avatar safety gates;
- log-tail and WebSocket command relay parsing;
- offline fallback, device status, and maintenance caveats.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 110 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- SDK references are not mistaken for product shells;
- community bridges are documented with maintenance and config caveats;
- haptics output is captured as an interaction channel, not only as a device
  list;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 110 synthesis document exists with code-level findings;
4. registry and families represent bHaptics SDK, OSC bridge, and relay donors
   clearly;
5. new methods are captured where this wave clarified SDK facades,
   avatar-OSC haptics, and generic command relays;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
