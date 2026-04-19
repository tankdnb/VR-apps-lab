# GitHub Research Wave 47 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `simulation telemetry overlays`, `motion-cueing bridges`, and
  `sim-sidecar platforms`.

## Why this wave exists

`VR-apps-lab` already had overlays, diagnostics, and utility sidecars, but one
VR-adjacent systems branch was still under-modeled:

- mature telemetry overlay hosts with modular widget stacks;
- multi-instance sidecars that translate simulator data into force feedback or
  motion-device behavior;
- bridges that normalize many games into common telemetry outputs;
- research simulator platforms with VR integration, sensor streams, and replay
  pipelines.

This wave exists to make
`simulation telemetry overlays, motion-cueing bridges, and sim-sidecar
platforms`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- telemetry overlays for simulators;
- force-feedback or motion-platform sidecars;
- game telemetry normalization bridges;
- VR-capable simulator platforms and XR control-surface prototypes.

## Frozen shortlist for code-level study

- `TinyPedal/TinyPedal`
- `walmis/VPforce-TelemFFB`
- `PHARTGAMES/SpaceMonkey`
- `SimFeedback/SimFeedback-AC-Servo`
- `HARPLab/DReyeVR`
- `giuseppdimaria/Unity-VRlines`

## Secondary candidates surfaced in the same wave

- no extra candidate in this wave was stronger than the frozen shortlist

## Execution model

### Step 1: Search and deduplicate

- search GitHub for telemetry overlays, motion sidecars, and simulator
  companion platforms;
- compare results against `catalog/project-registry.md`;
- reject repos that only wrap one narrow telemetry source without a clearer
  overlay-host, device-sidecar, or simulator-stack lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `sim-sidecar architecture`;
- allow one broader research simulator because it teaches a strong donor line
  around VR-integrated telemetry and replay.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how telemetry acquisition, widgets, outputs, and device control are split;
- whether the repo is overlay-first, sidecar-first, bridge-first, or simulator
  platform-first;
- where IPC, plugin, preset, or extension boundaries sit.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 47 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies
  overlay-host, telemetry-bridge, and sim-sidecar methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `simulation sidecars` stay distinct from ordinary VR overlays and utilities;
- the family clearly separates overlay hosts, FFB or motion-device sidecars,
  telemetry normalization bridges, and research simulator stacks;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 47 synthesis document exists with code-level findings;
4. the registry and families clearly represent telemetry overlays and sim
   sidecar platforms;
5. sidecar and simulator methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
