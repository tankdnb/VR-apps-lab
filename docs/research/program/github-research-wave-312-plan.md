# GitHub Research Wave 312 Plan - VRCFaceTracking Vendor Modules, Shared Memory, Vendor SDKs, and Loopback Bridges

## Goal

Study vendor-specific VRCFaceTracking modules as reusable references for
shared-memory ingestion, vendor DLL bootstrap, local UDP/JSON bridges,
smoothing/fallback policy, stale gating, and slot coexistence.

## Research Questions

- How thin can a VRCFT module become when a separate process owns the real
  headset integration?
- Which transport boundaries recur across memory map, vendor DLL, and UDP/JSON
  variants?
- Where do these modules place smoothing, blink handling, stale-state
  neutralization, and tracking-loss fallback?
- How do eye-only modules differ from eye-plus-expression bridges in slot
  ownership and coexistence?

## Shortlist

- `BigscreenVR/VRCFT-Beyond`
- `benaclejames/VRCFTPimaxModule`
- `UikaMisumi/DreamAirTracking.VrcftModule`

## Required Checks

- Deduplicate against earlier VRCFaceTracking, eye-tracking, and avatar-bridge
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep vendor dependency, stale transport, slot contention, and signal-quality
  caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 312.
- Registry/family entries for vendor-specific VRCFT module variants.
- Method catalog entry for vendor VRCFT module boundaries.
- Follow-up gaps for producers, schema versioning, and module coexistence.
