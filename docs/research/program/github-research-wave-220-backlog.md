# GitHub Research Wave 220 Backlog

Date: 2026-06-06

Theme: world-locking, spatial coordinate stabilization, and anchor-sharing
bindings.

## Completed In This Wave

- Studied `microsoft/MixedReality-WorldLockingTools-Unity` as a canonical
  coordinate-stabilization architecture with `WorldLockingManager`,
  `AnchorManager`, `AlignmentManager`, `SpacePin`, spongy/locked/frozen
  transforms, anchor graph management, diagnostics, auto refreeze/load/save,
  and persistent alignment pins.
- Studied `microsoft/MixedReality-WorldLockingTools-Samples` as QR and Azure
  Spatial Anchors product UX around SpacePins, QR proxy matching, binding
  oracles, publish/load/search/purge controls, and multi-device scene
  alignment.
- Studied `microsoft/WorldLockingTools-Unreal` as an Unreal translation of the
  same model through AR pins, FrozenWorld plugin calls, tracking-to-world
  transforms, and pawn/camera hierarchy adjustment.
- Studied `brunoshine/StereoKit.Samples.AzureSpatialAnchors` as a minimal
  StereoKit cloud-anchor UI with `CloudSpatialAnchorSession`, nearby-anchor
  search, save/delete buttons, platform location provider, and feedback state.
- Rejected `kojoopuni/azureSpatialAnchorsUnityARFoundationExplorations` as an
  empty/no-donor checkout.
- Added a reusable method entry for world-locked coordinate stabilization with
  marker/cloud-anchor binding.

## Follow-Up Queue

1. Build a spatial-stability matrix across raw tracking origin, locked world,
   local marker binding, cloud anchor binding, colocation, and per-engine
   camera hierarchy requirements.
2. Compare WLT `SpacePin` and FreeCAD-style CAD working-plane anchors after
   Wave 223, because both expose physical references as product UX.
3. Revisit Meta/Magic Leap/ARFoundation anchor waves and align terminology
   around local anchor, cloud anchor, shared anchor, and world-locked frame.
4. Extract a small "anchor UX checklist" for save/load/search/delete/reset,
   feedback messages, credential boundaries, and stale-anchor handling.
5. Track whether any modern open-source anchor projects avoid cloud credentials
   while still supporting multi-device persistence.

## Do Not Spend Time On Yet

- Do not copy FrozenWorld internals or ASA credential handling directly.
- Do not treat WLT as a general VR runtime layer; it is mostly MR/HoloLens and
  engine integration material.
- Do not run or build Unity, Unreal, StereoKit, or ASA samples during research.
