# GitHub Research Wave 109 Plan

- Date: `2026-06-05`
- Goal: run the next focused GitHub research wave for repositories that map
  `SlimeVR server`, `tracker firmware`, `Joy-Con`, `Mocopi`, `HaritoraX`, and
  `calibration ecosystem` patterns.

## Why this wave exists

The repository already contains many tracker and OSC bridge references, but
the SlimeVR ecosystem deserves a separate pass because it is a complete
tracking stack: firmware, server hub, skeleton calibration, runtime bridges,
consumer-device adapters, BLE normalization, and guided hardware onboarding.

This wave exists to study SlimeVR as a reusable architecture model for tracker
helpers, not merely as one open-source full-body-tracking project.

## Search scope

Primary search directions for this wave:

- SlimeVR server and desktop GUI architecture;
- ESP tracker firmware and diagnostics protocol;
- Joy-Con-to-SlimeVR adapters;
- Sony Mocopi BLE-to-SlimeVR adapters;
- HaritoraX-to-SlimeVR desktop adapter shells.

## Frozen shortlist for code-level study

- `SlimeVR/SlimeVR-Server`
- `SlimeVR/SlimeVR-Tracker-ESP`
- `carl-anders/slimevr-wrangler`
- `moslime/moslime`
- `OCSYT/SlimeTora`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for SlimeVR server, SlimeVR firmware, Joy-Con tracker,
  Mocopi SlimeVR, and HaritoraX SlimeVR queries;
- compare surfaced repositories against registry and family docs;
- classify adapters by the hardware stream they normalize rather than by name.

### Step 2: Freeze the shortlist

- keep the wave centered on a full tracker ecosystem;
- include the server hub, firmware, and three external hardware adapter types.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- tracker protocol and packet shapes;
- server-to-driver bridge model;
- OSC, VMC, BVH, WebSocket, RPC, or FlatBuffer surfaces;
- calibration and skeleton setup UX;
- hardware connection, autodiscovery, battery, and drop diagnostics;
- caveats around platform support and maintenance.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 109 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- firmware, server, and adapter responsibilities remain separated;
- the wave does not collapse all SlimeVR-related projects into one note;
- bridge protocols and diagnostics are captured explicitly;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 109 synthesis document exists with code-level findings;
4. registry and families represent SlimeVR server, firmware, and adapter donors
   clearly;
5. new methods are captured where this wave clarified tracker hubs, firmware
   protocols, hardware adapters, and guided setup UX;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
