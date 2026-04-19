# VR Projects Wave 74: OpenVR Capture, Replay, and Orchestration Toolchains

- Date: `2026-04-20`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `OpenVR capture`, `replay`, and
  `orchestration toolchains`.

## Why this wave exists

`VR-apps-lab` already had tracking export, metrics, and some creator tools in
scope, but it still lacked a sharper answer to
`what happens after VR runtime state is captured`.

This wave exists to make that family clearer:

- capture-to-tape plus replay-driver stacks;
- post-capture spatial normalization helpers;
- orchestration shells that connect synchronized capture to inference and
  virtual-device control;
- VR-native recording studios with operator-facing export settings.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with OpenVR capture, replay, mocap, and orchestration queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `NVIDIA/vr-capture-replay` | Strong donor for capture-to-tape plus replay-driver architecture |
| `CodeSmith2000/virtual-camera-offset` | Useful narrow donor for post-capture tracker-to-camera alignment |
| `wrainw/VRScout_Agent_Orchestration_Unity_Project` | Strong donor for capture plus inference plus virtual-device orchestration |
| `TrackLab/ViRe` | Strong donor for a VR-native mocap studio shell with operator menus |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `SKAsApp/ovr-motion-capture` | Public snapshot was too thin to justify a deeper donor claim in this wave |

## Deep-pass notes by project

## `NVIDIA/vr-capture-replay`

- GitHub:
  [NVIDIA/vr-capture-replay](https://github.com/NVIDIA/vr-capture-replay)
- What it is:
  a capture-to-replay toolchain that records headset and controller poses and
  inputs to tape files, then replays them through synthetic devices.
- Why it matters:
  it is the clearest donor in this wave for
  `capture-to-tape plus replay-driver workflow`.
- Interesting ideas:
  keep capture and replay as a reusable toolchain; define helper tools around
  the tape format; make automation easier through `ready.flag` and
  `busy.flag`
  state files.
- Interesting implementation choices:
  the repo's `src/capture`, `src/replay`, `src/convert`, and `src/helper`
  slices make capture, replay, and tape conversion explicit rather than hiding
  them inside one tool.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  larger than a tiny helper, but unusually valuable because the pipeline is
  explicit all the way from recording through replay.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `reproducible record and replay harness`
  donor.

## `CodeSmith2000/virtual-camera-offset`

- GitHub:
  [CodeSmith2000/virtual-camera-offset](https://github.com/CodeSmith2000/virtual-camera-offset)
- What it is:
  a Blender-side helper that compensates for the physical offset between a
  tracked device and a real camera.
- Why it matters:
  it is the clearest donor in this wave for
  `post-capture spatial offset normalization`.
- Interesting ideas:
  treat alignment as a small explicit transform problem; keep the helper
  scriptable and pipeline-friendly; let capture and post-capture correction be
  separate concerns.
- Interesting implementation choices:
  `Solver.py`
  constructs an offset camera and helper hierarchy from tracked camera data
  rather than embedding the logic in a larger capture app.
- Code donor value:
  medium.
- Product reference value:
  medium.
- Architecture reference value:
  medium.
- Caveats:
  small and narrowly scoped, but still useful because it isolates a boundary
  that larger capture tools often blur.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `post-capture transform helper`
  donor.

## `wrainw/VRScout_Agent_Orchestration_Unity_Project`

- GitHub:
  [wrainw/VRScout_Agent_Orchestration_Unity_Project](https://github.com/wrainw/VRScout_Agent_Orchestration_Unity_Project)
- What it is:
  a Unity-based orchestration shell that captures synchronized runtime state,
  talks to inference services, and drives virtual devices or actions back into
  VR.
- Why it matters:
  it is the clearest donor in this wave for
  `capture plus inference plus virtual-device control loop`.
- Interesting ideas:
  treat runtime capture as part of a control loop rather than an offline log;
  pair synchronized image, audio, and pose capture with device-command egress;
  make IPC and virtual-device control first-class runtime surfaces.
- Interesting implementation choices:
  `Assets/Scripts/IPCClient/InferencePoseClient.cs`
  drives synchronized capture and inference messaging while
  `Assets/Scripts/IPCClient/OpenVRDeviceController.cs`
  shows named-pipe control over virtual devices.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  broad enough that the repo remains
  `Partially studied`
  at the system level even though the main orchestration boundary is already
  clear.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `closed-loop XR orchestration shell`
  comparison.

## `TrackLab/ViRe`

- GitHub:
  [TrackLab/ViRe](https://github.com/TrackLab/ViRe)
- What it is:
  a VR-native mocap studio that records motion into `BVH` while exposing
  operator controls and settings inside the VR workflow.
- Why it matters:
  it is the clearest donor in this wave for
  `VR-native recording studio shell`.
- Interesting ideas:
  keep recording controls inside VR; persist capture settings close to the
  recording flow; combine recorder, menu, and spectator workflows in one
  studio-like shell.
- Interesting implementation choices:
  `Assets/Scripts/BVH/BVHRecorder.cs`
  shows export flow while
  `Assets/Scripts/HomegrownScripts/MenuContents/RecOptPanel.cs` and
  `Assets/Scripts/HomegrownScripts/StudioController.cs`
  expose operator settings, save flow, and recording toggles.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  more creator-tool oriented than diagnostic, but exactly because it shows how
  a recording studio can live natively in VR.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs an
  `in-VR recording or mocap studio`
  donor.

## Main takeaways from Wave 74

- `capture and orchestration donors` split more cleanly into:
  - `capture-to-tape plus replay-driver`
  - `post-capture alignment helper`
  - `capture plus inference orchestration shell`
  - `VR-native recording studio`
- The strongest lesson from this wave is that
  `capture tooling`
  is not one category. Replay, orchestration, creator workflows, and alignment
  helpers all occupy different but reusable positions in the same pipeline.
- Another strong lesson is that the most reusable donors make the
  `state contract`
  explicit, whether that contract is a tape file, a named-pipe device command,
  or a recorder UI path.

## Reusable methods clarified by this wave

- `Capture-to-tape and replay-driver workflow with helper utilities and automation flags`
- `XR orchestration workspace that couples synchronized capture, inference loops, and operator controls`

## Recommended next moves after this wave

1. Treat `vr-capture-replay` as the clearest donor in this wave for a
   `capture artifact plus replay driver`
   toolchain.
2. Keep `virtual-camera-offset` visible whenever a future branch needs a
   `small post-capture alignment helper`
   instead of a broad creator suite.
3. Keep `VRScout_Agent_Orchestration_Unity_Project` visible whenever
   `VR-apps-lab` needs a `closed-loop orchestration`
   comparison.
4. Keep `ViRe` visible whenever a future branch needs a stronger
   `VR-native recording studio`
   donor.
