# GitHub Research Wave 111 Plan

- Date: `2026-06-05`
- Goal: run the next focused GitHub research wave for repositories that map
  `no-HMD`, `virtual-HMD`, `phone-HMD`, and `controllable null-driver`
  workflows.

## Why this wave exists

Many VR tools need a way to develop, debug, or integrate without a normal HMD
session. No-HMD and virtual-HMD projects are valuable because they expose the
minimum pieces SteamVR needs to believe a device exists: display component,
pose source, controller input, driver factory, configuration, and sometimes
external scripted control.

This wave exists to capture headsetless and virtual-device workflows as a
research family for future diagnostics, automated tests, and development
harnesses.

## Search scope

Primary search directions for this wave:

- phone-as-HMD bridges;
- desktop-display-as-HMD drivers;
- controller-only or tracker-driven fake HMD drivers;
- socket-controlled null drivers;
- keyboard and mouse fake HMD/controller rigs.

## Frozen shortlist for code-level study

- `PhoneVR-Developers/PhoneVR`
- `SDraw/driver_hmd`
- `pema99/faceless`
- `kajsaantonigelstrom/OpenVRsim`
- `blakebeckcoding/Pepper`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for OpenVR fake HMD, no headset, phone VR, null driver, and
  controllable virtual device queries;
- compare surfaced repositories against registry and family docs;
- classify old or rough projects as architecture/tutorial references where
  appropriate instead of treating them as modern drop-in donors.

### Step 2: Freeze the shortlist

- keep the wave centered on headsetless and virtual-device workflows;
- include one phone bridge, two no-HMD/fake-HMD display paths, one socket
  harness, and one keyboard/mouse fake-rig tutorial.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- OpenVR driver factory and provider entry points;
- HMD display component implementation;
- pose ingress and calibration model;
- virtual display, phone streaming, or desktop display path;
- controller input and button/axis simulation;
- external control sockets and scripted test-case models;
- caveats around age, platform assumptions, and compile quality.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 111 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- old driver projects are framed as references, not promised runnable tools;
- fake-HMD, phone-HMD, and controller-simulation roles stay distinct;
- driver entry points and pose/control ingress are captured explicitly;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 111 synthesis document exists with code-level findings;
4. registry and families represent no-HMD, phone-HMD, virtual display, and
   controllable driver-stub donors clearly;
5. new methods are captured where this wave clarified phone bridges,
   display components, socket-controlled harnesses, and keyboard/mouse fake
   rigs;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
