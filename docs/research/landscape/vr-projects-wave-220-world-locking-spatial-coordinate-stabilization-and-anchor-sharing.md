# VR Projects Wave 220: World-Locking, Spatial Coordinate Stabilization, and Anchor Sharing

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-220-plan.md`
- `docs/research/program/github-research-wave-220-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

Many VR and MR utilities assume that the runtime's tracking origin is stable.
In real tools, users cross rooms, lose tracking, restart sessions, or need two
devices to agree on the same physical space. The reusable lesson in this wave
is to make coordinate stability explicit: raw tracking space, stabilized world
space, anchor graph, alignment pins, persistence, and user-facing recovery UI
should not be hidden inside one camera script.

## Project Findings

### `microsoft/MixedReality-WorldLockingTools-Unity`

- Interesting idea: world locking is modeled as a layered coordinate system:
  raw tracking is "spongy", stabilized space is "locked/frozen", anchors build
  a graph, SpacePins add real-world alignment constraints, and an adjustment
  frame moves Unity content into the corrected frame.
- Code donor value: very high as architecture reference. `WorldLockingManager.cs`
  exposes `IAnchorManager`, `IFragmentManager`, `IAttachmentPointManager`, and
  `IAlignmentManager`, plus settings for manager, linkage, anchors, diagnostics,
  auto load/save, auto refreeze, and transform accessors such as
  `FrozenFromSpongy`, `LockedFromSpongy`, and `FrozenFromLocked`.
- Product reference value: high for any tool that needs stable spatial
  references, saved workspaces, or physical alignment UX.
- Architecture pattern: service manager plus anchor graph plus alignment manager
  plus component-level SpacePins.
- Reusable method: separate raw tracking drift from stable world coordinates
  and expose a named alignment component rather than baking offsets into scene
  objects.
- Constraints and caveats: Microsoft/FrozenWorld internals, HoloLens/MR
  assumptions, Unity integration, and cloud/service extensions should be
  treated as reference material rather than drop-in code.
- What to inspect next: fragment manager behavior, diagnostics visualizers, and
  failure/recovery UI.
- Why it matters for `VR-apps-lab`: it gives the cleanest vocabulary for
  tracking-origin stability.

#### Reusable Pattern Extraction

- Pattern candidate: world-locked coordinate stabilization with marker and
  cloud-anchor binding.
- Problem solved: runtime tracking origins can drift, reset, or disagree across
  devices/sessions, making overlays, CAD tools, calibration helpers, and shared
  scenes spatially unreliable.
- Reusable core: raw tracking frame, stabilized frame, anchor graph, alignment
  pins, persistent bindings, explicit transform API, diagnostics, and reset or
  refreeze controls.
- Source evidence: `WorldLockingManager.cs`, `AlignmentManager.cs`,
  `AnchorManager.cs`, and `SpacePin.cs`.
- Abstraction boundary: anchor management, alignment binding, persistence,
  diagnostics, and engine camera hierarchy should remain separable.
- What not to copy: FrozenWorld implementation details, Microsoft service
  assumptions, or Unity-specific transform names without adapting the target
  runtime.
- Method catalog action: create Method 665.

### `microsoft/MixedReality-WorldLockingTools-Samples`

- Interesting idea: environment alignment becomes usable when QR markers or
  cloud anchors are wrapped as discoverable SpacePin bindings with explicit
  UI actions.
- Code donor value: high for product framing. The QR Space Pins sample maps a
  physical QR pose to a matching virtual proxy pose, derives a SpacePin index
  from QR data, supports subscene alignment through `AlignSubtree`, and exposes
  clear/toggle commands. The ASA sample uses binding interfaces such as
  `IBinding`, `IPublisher`, `IBindingOracle`, and `ILocalPeg`, plus
  `SpacePinBinder`, `PublisherASA`, `SpacePinBinderFile`, and `SpacePinASA`.
- Product reference value: very high for save/load/publish/search/purge UX.
- Architecture pattern: physical marker or cloud-anchor binding plus local
  oracle plus alignment pins.
- Reusable method: expose anchor state through user actions: toggle pins,
  publish, load oracle, clear oracle, search, purge, and reset.
- Constraints and caveats: ASA credentials, WiFi/location permissions, service
  availability, and ARFoundation version issues are real product risks.
- What to inspect next: error state presentation and how users recover when an
  anchor cannot be found.
- Why it matters for `VR-apps-lab`: this is a product reference for turning
  spatial alignment from hidden math into operator-facing workflow.

### `microsoft/WorldLockingTools-Unreal`

- Interesting idea: the world-locking model ports across engines when the
  anchor manager, camera hierarchy, and adjustment transform are explicit.
- Code donor value: high as a cross-engine comparison. `AnchorManager.cpp`
  uses Unreal AR pins, HMD data, tracking-to-world transforms, local AR pin
  storage, anchor creation/culling, edge submission, and FrozenWorld plugin
  calls such as `ClearSpongyAnchors`, `Step_Init`, `AddSpongyAnchors`,
  `SetMostSignificantSpongyAnchorId`, `AddSpongyEdges`, and `Step_Finish`.
- Product reference value: medium-high for Unreal MR utilities and porting
  checklists.
- Architecture pattern: the engine-specific layer translates runtime tracking
  and AR pins into the same graph/refreeze/alignment model.
- Reusable method: isolate camera/pawn hierarchy adjustments from anchor graph
  solving so the same conceptual method can be ported.
- Constraints and caveats: HoloLens/Microsoft OpenXR orientation, FrozenWorld
  binaries, and Unreal AR session dependencies.
- What to inspect next: example project SpacePin flows and QR code alignment
  scenes.
- Why it matters for `VR-apps-lab`: it confirms that world locking is an
  engine-independent pattern when the boundaries are named.

### `brunoshine/StereoKit.Samples.AzureSpatialAnchors`

- Interesting idea: anchor persistence can be shown with a very small UI:
  start cloud session, save anchor, delete anchor, and show feedback state.
- Code donor value: medium. `ASADemoScene.cs` owns `CloudSpatialAnchorSession`,
  event handlers, `ASASessionState`, `PlatformLocationProvider`,
  `NearDeviceCriteria`, `CreateWatcher`, `CreateAnchorAsync`, cloud anchor
  deletion, and StereoKit/Windows spatial pose conversion.
- Product reference value: high as a minimal anchor save/load UX.
- Architecture pattern: session state machine plus nearby search plus anchor
  creation/deletion plus user feedback.
- Reusable method: keep cloud/session state visible instead of hiding it behind
  one "save" call.
- Constraints and caveats: Azure Spatial Anchors credentials, HoloLens testing
  context, platform permissions, and service dependency.
- What to inspect next: local fallback behavior and how anchor IDs are stored
  outside the demo.
- Why it matters for `VR-apps-lab`: it is a compact reference for anchor
  persistence UI without a large toolkit around it.

## Cross-Project Synthesis

The strongest reusable pattern is a coordinate-stability stack:

- raw tracking frame
- stabilized world frame
- anchor graph or anchor set
- alignment pins or marker bindings
- persistence/cloud binding
- explicit reset/refreeze/search/delete UI
- diagnostics and failure state

For `VR-apps-lab`, this should feed future calibration helpers, CAD/workspace
tools, shared-room alignment, anchor diagnostics, and mixed-reality utility
designs. The key is to copy the boundaries, not the vendor internals.
