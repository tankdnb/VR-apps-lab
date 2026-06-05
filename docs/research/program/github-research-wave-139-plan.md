# GitHub Research Wave 139 Plan

- Date: `2026-06-05`
- Goal: study OpenGloves sidecars, protocols, named-pipe input, OSC ingress,
  and force-feedback adapters as reusable hand-device integration patterns.

## Why this wave exists

Hand hardware and haptic adapters are valuable for `VR-apps-lab` because they
show how external devices enter a VR runtime through sidecars, calibration UI,
protocol contracts, named pipes, OSC, serial encodings, and game-specific
force-feedback bridges.

## Search scope

Primary search directions:

- OpenGloves UI and protocol projects;
- named-pipe glove input helpers;
- OSC-to-glove bridges;
- serial/alpha encoding helpers;
- Unity force-feedback demos;
- game integration sidecars.

## Frozen shortlist for code-level study

- `LucidVR/opengloves-ui`
- `LucidVR/opengloves-protocol`
- `PerlinWarp/pygloves`
- `senseshift/opengloves-lib`
- `Rin-Wilson/CS-OpenGloves-Named-Pipe-Input-Library`
- `Python1320/opengloves-osc`
- `LucidVR/opengloves-force-feedback-unity-demo`
- `LucidVR/opengloves-hl-alyx-integration`

## Execution model

### Step 1: Search and deduplicate

- search by OpenGloves, LucidGloves, named pipe, OSC, force feedback, serial,
  and DIY glove helper families;
- deduplicate against prior haptics, driver, virtual controller, and hardware
  bridge waves.

### Step 2: Freeze the shortlist

- include canonical UI/protocol repos, language helpers, protocol adapters,
  and force-feedback/game-side examples.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- sidecar UI to local driver API boundaries;
- proto contracts for driver input/output and force feedback;
- named-pipe paths and binary struct layout;
- OSC address mapping;
- serial alpha encoding;
- Unity skeleton-to-curl FFB mapping;
- game log/file-watcher sidecar adapters.

### Step 5: Promote findings into repository structure

Update Wave 139 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when the OpenGloves ecosystem is documented as a family
of reusable sidecar, protocol, input-ingress, serial, OSC, and force-feedback
methods rather than as one hardware project.
