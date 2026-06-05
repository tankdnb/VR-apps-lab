# GitHub Research Wave 124 Plan

- Date: `2026-06-05`
- Goal: study VR treadmill, locomotion hardware, and sensor-to-input bridge
  projects for reusable input-adapter and virtual-controller patterns.

## Why this wave exists

VR locomotion hardware projects often look rough, but they expose useful
utility architecture: device discovery, calibration, thresholding, smoothing,
virtual gamepad output, OpenVR driver components, BLE/serial/TCP transport,
and user-visible stop/reconnect states.

## Search scope

Primary search directions:

- VR treadmill utilities;
- walk-in-place and balance-board adapters;
- serial or BLE treadmill firmware;
- OpenVR treadmill or locomotion drivers;
- Unity/Quest controller-state relay projects.

## Frozen shortlist for code-level study

- `fer-sler/VR-Treadmill`
- `TimStewartJ/vr-treadmill`
- `Cycrus/slimstep_vr`
- `jurassicjordan/GoobleBoxVR`
- `srepmub/tacovr`
- `ssohbn/kittywalk-server`
- `cybernetic-research/VR-treadmill-client-app`
- `cybernetic-research/VR-treadmill-server-app`

## Execution model

### Step 1: Search and deduplicate

- search by locomotion hardware and treadmill bridge families;
- remove already studied walk-in-place and overlay locomotion projects;
- keep only projects that add a bridge, state, hardware, or output lesson.

### Step 2: Freeze the shortlist

- include minimal host adapters, a mature ViGEm bridge, an OpenVR driver path,
  firmware, balance-board state detection, and Quest/Unity relay examples.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep all downloaded sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- sensor capture and normalization;
- locomotion state classification;
- keyboard, virtual gamepad, OpenVR, BLE, serial, and TCP output;
- settings, diagnostics, driver readiness, and cleanup;
- caveats around hardware-specific assumptions.

### Step 5: Promote findings into repository structure

Update:

- Wave 124 landscape synthesis;
- project registry;
- project families;
- methods catalog;
- not-yet-studied backlog;
- documentation indexes.

### Step 6: Verify before publishing

- no third-party project is run, built, installed, or launched;
- local cache remains untracked;
- all new projects have family placement and donor/product notes.

## Definition of done

This wave is complete when the locomotion-hardware bridge pattern is documented
and the strongest donors are represented in registry, families, methods, and
indexes.
