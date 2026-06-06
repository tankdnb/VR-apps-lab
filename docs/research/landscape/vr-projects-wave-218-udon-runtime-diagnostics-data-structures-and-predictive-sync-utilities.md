# VR Projects Wave 218: Udon Runtime Diagnostics, Data Structures, and Predictive Sync Utilities

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-218-plan.md`
- `docs/research/program/github-research-wave-218-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

VRChat/Udon utility value often lives below the visible prefab: base lifecycle
contracts, logging, network time, dirty serialization, snapshot hooks, data
structures, profiling, prediction, and tuning panels. Wave 218 studies the TLP
cluster to extract these runtime substrate patterns and the caveats around
package-only or placeholder repositories.

## Project Findings

### `Guribo/UdonUtils`

- Interesting idea: TLP packages share a base Udon substrate that standardizes
  lifecycle validation, logging, network dirty state, retry-on-serialization
  failure, sync pause, events, time sources, physics helpers, factories, tests,
  and utility components.
- Code donor value: very high. `TlpBaseBehaviour.cs` documents VRChat event
  order, owns `SetupAndValidate`, logging severity, `SyncPaused`,
  `MarkNetworkDirty`, pending serialization counters, delayed serialization,
  retry behavior, and ownership checks. `TlpAccurateSyncBehaviour.cs` adds
  network/game time sources, compressed send time, deserialization sanity
  checks, latency calculation, prediction reduction, snapshot creation hooks,
  and abstract `PredictMovement`.
- Product reference value: very high for any Udon utility package that needs
  predictable setup, logging, network behavior, and tests.
- Architecture pattern: shared base behavior plus optional sync/prediction
  subclass plus reusable utility modules.
- Reusable method: create a runtime substrate before building many prefabs so
  logging, validation, timing, and serialization rules are consistent.
- Constraints and caveats: VRChat/Udon-specific, many package dependencies,
  compile-symbol behavior, and world-specific performance constraints.
- What to inspect next: `TlpNetworkTime`, `RigidbodyHistory`,
  `SyncedEvents`, task scheduler, and test helpers.
- Why it matters for `VR-apps-lab`: it is a strong donor for Udon utility
  framework boundaries.

#### Reusable Pattern Extraction

- Pattern candidate: Udon runtime utility substrate with profiling, data
  structures, and predictive sync.
- Problem solved: VRChat world tools need repeatable lifecycle, logging,
  serialization, time, diagnostics, and prediction foundations before product
  prefabs can stay maintainable.
- Reusable core: base behavior, setup validation, logging severity,
  compile-time debug mode, dirty serialization queue, retry/failure handling,
  local sync pause, network time source, snapshot hooks, prediction boundary,
  data-structure helpers, profiling overlay, and tuning UI.
- Source evidence: `TlpBaseBehaviour.cs`, `TlpAccurateSyncBehaviour.cs`,
  `PerformanceStatController.cs`, `GlobalProfileHandler.cs`, `AvlTree.cs`,
  `AvlTreeNodeUtils.cs`, `PredictingSync.cs`, `PositionSendController.cs`,
  and `SyncTweakerController.cs`.
- Abstraction boundary: runtime substrate, diagnostics UI, data structure,
  predictive sync logic, and product prefab should remain separate.
- What not to copy: package defines, world-specific thresholds, hidden prefab
  references, or predictive physics constants without target testing.
- Method catalog action: create Method 663.

### `Guribo/UdonProfiling`

- Interesting idea: Udon performance can be surfaced inside the world through a
  ScreenSpace overlay that measures frame rate, average frame time, profiled
  Udon time, max time, too-slow state, and player-count changes.
- Code donor value: high. `PerformanceStatController.cs` initializes an
  MVC-style single-object model, schedules a refresh loop, uses `Stopwatch`,
  counts frames, computes average frame time, marks the model dirty, and
  notifies views. `GlobalProfileHandler.cs` accumulates stopwatch elapsed time
  across `FixedUpdate`, `Update`, `LateUpdate`, and `PostLateUpdate`, tracks
  max/average Udon frame time, compares against threshold, and can emit a
  debug frame log.
- Product reference value: high for in-world diagnostics and developer HUDs.
- Architecture pattern: profiling handler plus performance model/controller
  plus UI view.
- Reusable method: keep profiler measurement, stat model, UI rendering, and
  logging separate.
- Constraints and caveats: Udon timing is approximate and world-dependent;
  screen-space overlay UX may not fit every world.
- What to inspect next: view/model fields, prefab setup, and how debug logs are
  bounded.
- Why it matters for `VR-apps-lab`: it shows diagnostics as a reusable utility
  surface, not just editor tooling.

### `Guribo/UdonLeaderBoard`

- Interesting idea: leaderboard/package lineage remains product-relevant for
  Udon sortable lists and player data displays, but the current checkout does
  not expose source-rich implementation files.
- Code donor value: low in this pass. The package folder contains only a
  `.gitkeep` placeholder, while README/changelog references leaderboard
  history, model/view/controller ideas, selectable categories, entry
  synchronizers, and AVL/tree lineage.
- Product reference value: medium as a package/product direction and follow-up
  queue item.
- Architecture pattern: not confirmed from source in this pass.
- Reusable method: do not promote placeholder package repos to donor status
  without source evidence.
- Constraints and caveats: insufficient code evidence in current checkout.
- What to inspect next: release packages, tags, or related repos that contain
  actual leaderboard source.
- Why it matters for `VR-apps-lab`: it is a useful example of honest donor
  triage.

### `Guribo/UdonAVLTree`

- Interesting idea: Udon can implement a balanced tree using `VRC.SDK3.Data`
  `DataList` nodes rather than GameObjects, with empty child references reused
  as in-order traversal wires.
- Code donor value: high. `AvlTreeNodeUtils.cs` defines the node layout:
  parent, payload, left/right node, left/right wire flags, node count, and tree
  height. It implements node pooling, getters/setters, validity checks, value
  updates, balance calculation, and rotations. `AvlTree.cs` uses a comparer,
  adds/removes payloads, connects wires during insert, balances nodes, and
  keeps size state.
- Product reference value: high for sortable Udon lists, leaderboards, player
  registries, and data-heavy world tools.
- Architecture pattern: data-list node encoding plus comparer plus node pool
  plus tree operations.
- Reusable method: encode complex structures into explicit index layouts when
  Udon object allocation or generics are constrained.
- Constraints and caveats: manual index layout, Udon/DataList quirks, comparer
  requirements, and test coverage importance.
- What to inspect next: tests, traversal helpers, and integration with
  leaderboard/list views.
- Why it matters for `VR-apps-lab`: it is a strong data-structure workaround
  reference.

### `Guribo/UdonVehicleSync`

- Interesting idea: non-kinematic rigidbody sync can combine network-time send
  stamps, prediction, dynamic send-rate thresholds, teleport/respawn markers,
  debug trails, and in-world settings UI.
- Code donor value: very high. `PredictingSync.cs` subclasses
  `TlpAccurateSyncBehaviourUpdate`, syncs position/velocity/acceleration,
  rotation/angular velocity, teleport flip-flop, and circular angular velocity;
  validates rigidbody settings, handles respawn, creates network state from
  working state, and predicts movement. `PositionSendController.cs` samples a
  velocity provider, converts game time to network time, requests serialization
  in `PostLateUpdate`, and skips sends when current prediction stays within
  position/rotation/velocity thresholds. `SyncTweakerController.cs` exposes
  owner-claiming UI updates for send rate, smoothing, prediction reduction,
  dynamic send rate, and debug trails.
- Product reference value: very high for vehicle worlds, physics-heavy worlds,
  and any networked motion diagnostic surface.
- Architecture pattern: sender/controller plus predictive receiver plus
  network-time substrate plus tuning UI.
- Reusable method: decide send cadence from prediction error, not only from a
  fixed timer.
- Constraints and caveats: experimental/unstable warning, VRChat physics
  constraints, ownership transfer, collision overshoot, and world-specific
  thresholds.
- What to inspect next: receiver prediction continuation, debug trail UX,
  fixed-update assumptions, and tests.
- Why it matters for `VR-apps-lab`: it supplies a rich predictive-sync method
  reference.

## Cross-Project Lessons

- Udon packages need a substrate layer before product prefabs: setup,
  validation, logging, timing, sync, tests, and helper APIs.
- In-world diagnostics can use the same model/controller/view pattern as
  ordinary UI, but measurements should stay isolated from display.
- Data structures in constrained runtimes may require explicit encoded layouts
  and stronger tests.
- Predictive sync is most reusable when sender cadence, receiver prediction,
  network time, teleport flags, and tuning UI are separate.
- Placeholder/package-only repos should be recorded honestly as references, not
  promoted to code donors.

## Method Catalog Actions

- Added Method 663: Udon runtime utility substrate with profiling, data
  structures, and predictive sync.

## Follow-Up Gaps

- Build an Udon runtime substrate matrix across base behavior, logging,
  network time, serialization, events, profiling, data structures, and sync.
- Find source-rich leaderboard/list view donors to complement `UdonAVLTree`.
- Compare dynamic send-rate prediction with earlier Udon sync/event helpers and
  non-VRChat networked motion patterns.
