# GitHub Research Wave 312 Backlog - VRCFaceTracking Vendor Modules, Shared Memory, Vendor SDKs, and Loopback Bridges

## Executed Scope

- Searched and deduplicated vendor-specific VRCFaceTracking module variants.
- Froze a three-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted shared-memory ingest, vendor DLL bootstrap, config-tuned
  smoothing, eye-loss fallback, loopback UDP/JSON ingestion, stale timeouts,
  neutralization, and slot coexistence patterns.

## Studied Projects

- `BigscreenVR/VRCFT-Beyond`
- `benaclejames/VRCFTPimaxModule`
- `UikaMisumi/DreamAirTracking.VrcftModule`

## Backlog Findings

- Compare these modules directly with earlier Quest Pro, PICO, Omnicept, and
  template VRCFT module lines.
- Deepen the external producers behind `VRCFT-Beyond` and `DreamAirTracking`.
- Revisit `VRCFTPimaxModule` for config-load correctness and failure handling
  when the vendor DLL/runtime is missing.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a vendor VRCFT module boundary method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
