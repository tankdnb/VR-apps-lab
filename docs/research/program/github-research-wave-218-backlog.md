# GitHub Research Wave 218 Backlog

Date: 2026-06-06

Theme: VRChat/Udon runtime diagnostics, data structures, and predictive sync
utilities.

## Completed In This Wave

- Deepened `Guribo/UdonUtils` for `TlpBaseBehaviour`, logging, pending
  serialization retry, local sync pause, setup/validation flow, accurate sync,
  physics/history helpers, events, factories, and test scaffolding.
- Studied `Guribo/UdonProfiling` as a ScreenSpace Udon performance overlay with
  MVC-style stat model/controller and a global profiler handler that measures
  Udon time across FixedUpdate/Update/LateUpdate/PostLateUpdate.
- Recorded `Guribo/UdonLeaderBoard` as a package/product reference rather than
  a code donor because the checked-out package contains only `.gitkeep` and no
  substantive runtime source.
- Studied `Guribo/UdonAVLTree` as a Udon-compatible AVL tree using `DataList`
  nodes, node pools, wire flags for in-order traversal, and explicit rotation
  helpers.
- Studied `Guribo/UdonVehicleSync` as a predictive rigidbody sync package with
  network-time send stamps, dynamic send-rate thresholds, circular/linear
  prediction, teleport/respawn, debug trails, and an in-world sync tweaker.
- Added a reusable method entry for an Udon runtime utility substrate.

## Follow-Up Queue

1. Compare `TlpAccurateSyncBehaviour` and `UdonVehicleSync` with previous Udon
   sync/event helper waves.
2. Build an Udon runtime substrate matrix: base lifecycle, logging, network
   time, dirty serialization, snapshot history, data structures, profiling,
   prediction, and UI tuning.
3. Revisit leaderboard/search/list packages to find a source-rich leaderboard
   implementation or older tag if needed.
4. Treat `UdonProfiling` as a reference for in-world diagnostics even when the
   final product is not VRChat-specific.
5. Compare DataList-backed data structures with earlier Udon encoding/query
   micro-libraries.

## Do Not Spend Time On Yet

- Do not import or run Unity/VRChat projects.
- Do not treat `UdonLeaderBoard` as a code donor until source-rich package
  contents are available.
- Do not copy predictive sync thresholds or physics assumptions without a
  specific world/use case.
