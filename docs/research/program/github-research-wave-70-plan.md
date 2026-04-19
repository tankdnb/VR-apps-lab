# GitHub Research Wave 70 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `mixed-VR controller bridges`, `hand emulation`, and
  `external-tracker interop`.

## Why this wave exists

`VR-apps-lab` already had broad coverage of tracker drivers and some mixed-VR
controller bridges, but it still lacked a clearer map of the
`controller-side interop`
branch between native runtimes, synthetic devices, and external pose sources.

This wave exists to make several donor branches explicit:

- controller bridges that reuse official input profiles and render models;
- OpenHMD-driven mixed-runtime controller paths;
- named-pipe IPC drivers that spawn controllers and trackers on demand;
- gesture-configurable hand-tracking emulation;
- vendor-specific OpenHMD variants;
- body-state-to-tracker bridge attempts whose public repos are still thin.

## Search scope

Primary search directions for this wave:

- mixed-runtime controller bridges;
- hand-tracking to SteamVR controller-emulation tools;
- synthetic controller or tracker drivers with IPC;
- OpenHMD-based interop variants for unusual hardware.

## Frozen shortlist for code-level study

- `mm0zct/Oculus_Touch_Steam_Link`
- `ChristophHaag/SteamVR-OpenHMD`
- `kodowiec/Yet-Another-OpenVR-IPC-Driver`
- `bdub1011/Quest-Link-Hand-Tracking`
- `mSparks43/PSVR-SteamVR-openHMD`
- `krazysh01/VirtualDesktop-OpenVR-Trackers`

## Secondary candidates surfaced in the same wave

- `Notnips/Meta-V66-Fixer`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for mixed-VR bridges, hand emulators, and external-tracker
  drivers;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose a real interop boundary rather than just a user
  setup guide.

### Step 2: Freeze the shortlist

- keep the wave centered on `controller and tracker interop`;
- allow a mix of stronger drivers, rough variants, and thin public snapshots
  when the comparison itself is informative.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how foreign runtime or hardware data reaches SteamVR devices;
- whether the repo reuses official profiles, render models, or skeleton paths;
- whether the repo owns synthetic-device lifecycle, smoothing, or fallback
  poses;
- whether the repo is strongest as a code donor, a product reference, or an
  honest thin comparison node.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 70 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- mixed-VR bridges stay distinct from generic tracker bridges and generic
  driver tutorials;
- thin public snapshots are described honestly instead of over-promoted;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 70 synthesis document exists with code-level findings;
4. the registry and families represent mixed-VR controller and hand-emulation
   donor lines more clearly;
5. new methods are captured where this wave clarified reusable patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
