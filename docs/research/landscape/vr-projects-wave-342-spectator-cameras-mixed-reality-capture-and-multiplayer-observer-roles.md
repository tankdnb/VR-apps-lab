# Wave 342 - Spectator Cameras, Mixed-Reality Capture, and Multiplayer Observer Roles

This wave studies spectator-camera, mixed-reality capture, and observer-role
projects that make VR experiences visible to people outside the headset.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to minimal spectator cameras, mature MRC calibration and
compositing stacks, companion capture/tooling kits, and multiplayer spectator
roles.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Unity-Technologies/VR-Spectator-Sample` | Minimal Unity spectator camera sample | Studied | Clear two-camera spectator rig with overlay-only UI camera, movable spectator camera, attachment points, and preview displays |
| `microsoft/MixedReality-SpectatorView` | Mature MRC calibration/compositor stack | Studied | Strong architecture donor for camera intrinsics/extrinsics, spatial alignment, marker detection, pose cache, time sync, compositor wrapper, networking, and recording services |
| `Microsoft/MixedRealityCompanionKit` | Companion capture and remote tool kit | Studied | Broad reference for MRC-era companion utilities: remoting host, KinectIPD, remote compositor, spectator view, commander, asset bundler, spatial mapping, and network state |
| `spatialos/sdk-for-unity-vr-starter-project` | Multiplayer VR spectator role baseline | Studied | Useful role-separation reference for headset players, mouse/keyboard spectators, replicated peripheral offsets, teleport, server-validated grabbing, and cloud-era caveats |

## Code-Level Findings

### `Unity-Technologies/VR-Spectator-Sample`

- Interesting idea: spectator support can start as a small camera rig rather
  than a full capture pipeline.
- Code donor value: medium. The sample uses `SpectatorController`, a static
  direct-to-screen spectator view camera, a movable spectator camera, camera
  attachment points, preview displays, and clearly named visual/UI objects for
  easy replacement.
- Product reference value: high for simple demo/stream surfaces.
- What to inspect next: `SpectatorController.cs`, `CameraAttachPoint.cs`,
  preview-display materials, and next-camera input routing.
- Caveat: old sample and not an MRC compositor.

### `microsoft/MixedReality-SpectatorView`

- Interesting idea: MRC should be decomposed into calibration, localization,
  camera acquisition, compositing, networking, and recording instead of treated
  as one camera script.
- Code donor value: high as architecture reference. The repo exposes
  `CalibrationDataProvider`, camera pose providers, camera intrinsics and
  extrinsics, `SpatialCoordinateService`, Azure Spatial Anchors and marker
  localization, QR/ArUco detectors, `CompositionManager`, `CompositorWrapper`,
  `SpectatorViewPoseCache`, time synchronization, texture manager, TCP
  networking, HolographicCamera broadcaster, and Android/iOS recording services.
- Product reference value: high for production capture workflow.
- What to inspect next: architecture docs, compositor interface, marker
  localization flow, package creation scripts, and setup/debug docs.
- Caveat: heavy Windows/UWP/HoloLens/Azure/deprecated-era dependencies.

### `Microsoft/MixedRealityCompanionKit`

- Interesting idea: companion tooling around XR can bundle multiple adjacent
  needs: remoting, IPD/calibration, remote compositor, spectator view, commander,
  asset bundling, and spatial mapping.
- Code donor value: medium. The repository includes asset bundling processor
  and viewer, network discovery/state managers, remote mapping mesh serializers,
  persistence/calibration zones, stage/menu managers, input-state models, and
  HoloLens commander/remoting references.
- Product reference value: medium-high for companion-kit composition.
- What to inspect next: `MixedRemoteViewCompositor`, `HoloLensCommander`,
  `Bundler`, spatial mapping remote mesh source/target, and calibration zones.
- Caveat: legacy HoloToolkit/Unity Networking era; reuse only concepts.

### `spatialos/sdk-for-unity-vr-starter-project`

- Interesting idea: a multiplayer VR project should model spectators as a
  first-class role, not as a debug camera bolted onto a headset client.
- Code donor value: medium. The README and source identify `SpectatorFlycam`,
  VR peripheral handlers, replicated headset/controller offsets, client-side
  teleport targeting, server-validated grabbing, grabbable transform/rigidbody
  handlers, player connection cleanup, and cloud/local worker build configs.
- Product reference value: medium for remote observer and multiplayer demo
  utilities.
- What to inspect next: `SpectatorFlycam.cs`, `VrPeripheralHandler.cs`,
  `GrabbingSender/Receiver`, entity templates, and authority boundaries.
- Caveat: SpatialOS SDK is obsolete; use as role/authority reference only.

## Reusable Pattern Extraction

- Pattern candidate: spectator/MRC capture decomposition.
- Problem solved: VR capture work often mixes spectator cameras, device
  calibration, spatial alignment, compositor IO, recording, and multiplayer
  observer roles in one fragile stack.
- Reusable core: spectator camera rig, overlay-only UI camera, camera attach
  points, preview displays, calibration artifact, intrinsics/extrinsics,
  coordinate service, marker/anchor localization, pose provider, pose cache,
  time sync, compositor adapter, network connection manager, recording service,
  setup/debug docs, and observer-role input model.
- Source evidence: `Unity-Technologies/VR-Spectator-Sample`,
  `microsoft/MixedReality-SpectatorView`,
  `Microsoft/MixedRealityCompanionKit`, and
  `spatialos/sdk-for-unity-vr-starter-project`.
- Abstraction boundary: keep demo spectator view, calibrated MRC, companion
  tooling, network transport, recording, and multiplayer roles separate.
- What not to copy: old HoloToolkit/SpatialOS dependencies, camera pipelines
  without calibration provenance, hidden native compositor requirements, or
  spectators that share player authority.
- Method catalog action: add spectator/MRC capture decomposition.

## Follow-Up Gaps

- Compare Microsoft SpectatorView with existing RealityMixerVisionPro notes as
  legacy HoloLens versus Vision Pro/iPhone MRC architectures.
- Extract a minimal spectator-camera component checklist for demos and docs.
- Add a future matrix for observer role, stream role, operator role, and replay
  role separation.
