# Wave 284 - VRCFaceTracking Face/Eye Tracking Modules, Templates, and Receiver Bridges

This wave studies VRCFaceTracking-adjacent modules, avatar preparation tools,
receiver bridges, and DIY face-input experiments. The focus is hardware module
boundaries, expression schema translation, smoothing, avatar parameter
authoring, OSC/LiveLink ingress, and what a reusable face-tracking utility
matrix should separate.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- VRCFaceTracking module implementations and docs;
- vendor/device-specific eye and face tracking ingress;
- avatar template and parameter-generation helpers;
- OSC/LiveLink/UDP receiver boundaries;
- DIY camera/ONNX mouth tracking references.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `VRCFaceTracking/docs` | VRCFT compatibility and setup documentation | Studied as documentation taxonomy | Hardware/addon compatibility and user-facing setup boundaries |
| `guygodin/VirtualDesktop.VRCFaceTracking` | Virtual Desktop to VRCFT module | Studied | Memory-mapped face state, wait-handle cadence, unified expression mapping |
| `Adjerry91/VRCFaceTracking-Templates` | Avatar preparation templates | Studied with asset-heavy caveat | Reusable avatar-side ARKit/Unified Expressions setup and VPM packaging |
| `hazre/VRCFTReceiver` | OSC receiver and stream bridge | Studied | FT/v2 OSC parsing, avatar parameter request, ValueStream creation |
| `regzo2/BinaryParameterTool` | VRChat avatar parameter authoring helper | Studied | Parameter cost guards and generated animator/expression assets |
| `200Tigersbloxed/VRCFTOmniceptModule` | HP Omnicept eye module | Studied | Glia subscription, eye data conversion, smoothing worker lifecycle |
| `lonelyicer/VRCFTPicoModule` | PICO face/eye UDP module | Studied | Dual-port/legacy UDP packet handling, disable flags, localized module metadata |
| `ghostiam/VRCFTTobiiAdvanced` | Tobii/BrokenEye eye module | Studied | API fallback, channel handoff, low-pass filtering, pupil/openness handling |
| `kusomaigo/VRCFaceTracking-LiveLink` | LiveLink/ARKit VRCFT module | Studied | UDP LiveLink receive, config file, ARKit blendshape-to-Unified mapping |
| `xverse-engine/XVRFaceTracking` | DIY camera and ONNX mouth tracking | Studied with prototype caveats | ESP32/camera stream, PyQt tuning UI, One Euro smoothing, OSC blendshape output |

## Code-Level Findings

### `VRCFaceTracking/docs`

- Interesting idea:
  documentation is treated as part of the compatibility surface, with hardware,
  addon, desktop, VR, and interface pages rather than only one install guide.
- Code donor value:
  low as code, but useful as taxonomy for hardware support tables, module
  documentation shape, and compatibility language.
- Product reference value:
  high for any `VR-apps-lab` matrix that needs to explain supported headsets,
  eye/face capabilities, avatar requirements, and setup responsibilities.
- What to inspect next:
  hardware support table evolution, addon interface wording, and how docs map
  to VRCFT module metadata.

### `guygodin/VirtualDesktop.VRCFaceTracking`

- Interesting idea:
  a VRCFT module reads Virtual Desktop face state through a named memory-mapped
  file and event wait handle, then converts vendor expressions into VRCFT
  unified eye and expression data.
- Code donor value:
  high: `TrackingModule.cs` shows `ExtTrackingModule` lifecycle, support flags,
  `MemoryMappedFile.OpenExisting`, wait-handle driven `Update`, tracking-state
  detection, and explicit `UnifiedExpressions` mapping.
- Product reference value:
  high for device-to-avatar bridges where the producer process should remain
  outside the avatar/runtime module.
- What to inspect next:
  `FaceState` binary compatibility, stale event behavior, coordinate
  conversion, and how memory-map permissions fail on user machines.

### `Adjerry91/VRCFaceTracking-Templates`

- Interesting idea:
  avatar preparation is packaged as a reusable Unity/VPM asset set rather than
  leaving every avatar author to create ARKit and Unified Expression animation
  assets manually.
- Code donor value:
  medium: much of the value is assets and workflows, but the repository is a
  strong reference for generated animation/parameter layout.
- Product reference value:
  high for avatar-facing setup UX and "make the target asset ready for data"
  flows.
- What to inspect next:
  exact parameter names, animation clip layout, ModularAvatar/VRCSDK
  assumptions, and package release metadata.

### `hazre/VRCFTReceiver`

- Interesting idea:
  a receiver listens to VRChat/VRCFT OSC values, creates streams lazily for
  `FT/v2` paths, and can request an avatar change to a parameter JSON target.
- Code donor value:
  medium/high: `VRCFTOSC.cs` shows UDP socket binding, OSC message encoding and
  parsing, thread-based listen loop, `ParametersFile.Create`, and
  `Loader.CreateStream` handoff.
- Product reference value:
  medium for inspection/relay tools that want to watch avatar expression data
  without embedding in the tracking source.
- What to inspect next:
  OSC parser edge cases, reconnect behavior, thread shutdown, avatar JSON
  schema, and stream lifetime cleanup.

### `regzo2/BinaryParameterTool`

- Interesting idea:
  the avatar-side parameter problem is handled as an editor utility with cost
  calculation, parameter creation/removal, and animator controller parameter
  checks.
- Code donor value:
  high for editor tooling: `ParameterGenerator.cs` checks
  `VRCExpressionParameters.MAX_PARAMETER_COST`, avoids duplicates, creates or
  removes parameters, and updates animator controller parameter sets.
- Product reference value:
  high for any wizard that prepares avatars for high-dimensional tracking while
  preserving VRChat expression budget constraints.
- What to inspect next:
  generated layer shapes, binary float driver behavior, rollback strategy, and
  compatibility with current VRChat SDK versions.

### `200Tigersbloxed/VRCFTOmniceptModule`

- Interesting idea:
  HP Omnicept eye tracking is wrapped as a VRCFT module with a vendor SDK
  subscription, NetMQ/Glia cleanup, and dedicated smoothing worker lifecycle.
- Code donor value:
  medium: `OmniceptModule.cs` shows `Glia` session setup, eye-tracking message
  subscription, transport error handling, `VRCFTEyeTrackingData` update, and
  teardown cleanup.
- Product reference value:
  medium for vendor-module compatibility matrices and eye-only module
  constraints.
- What to inspect next:
  `VRCFTEyeTracking.cs`, smoothing thresholds, licensing requirements, and how
  failures are surfaced to users.

### `lonelyicer/VRCFTPicoModule`

- Interesting idea:
  PICO face tracking is exposed through a VRCFT module with dual UDP ports,
  legacy protocol detection, local disable flags, localization, and an updater
  helper.
- Code donor value:
  high: `VRCFTPicoModule.cs`, `DataPacket.cs`, `LegacyDataPacket.cs`, and
  `Updater.cs` separate packet ingress, protocol compatibility, module
  metadata, and data update flow.
- Product reference value:
  high for headset-specific modules that need graceful partial support:
  eye-only, expression-only, full face, or legacy protocol.
- What to inspect next:
  packet schema, timeout handling, updater security, and user-facing
  diagnostics when ports are occupied.

### `ghostiam/VRCFTTobiiAdvanced`

- Interesting idea:
  Tobii support is implemented with fallback between BrokenEye and native
  Tobii APIs, then buffered through a channel before updating VRCFT eye data.
- Code donor value:
  high: `TobiiAdvanced.cs` shows API fallback, `Channel<EyeData>` handoff,
  low-pass filter creation, gaze/openness/pupil conversion, min pupil
  overwrite behavior, and config loading.
- Product reference value:
  high for eye-tracking modules where validity flags and fallback APIs matter
  more than a single happy path.
- What to inspect next:
  `Tobii/Client.cs`, `BrokenEye.Client`, low-pass filter math, config file
  defaults, and blocking update behavior.

### `kusomaigo/VRCFaceTracking-LiveLink`

- Interesting idea:
  Apple ARKit/LiveLink packets are accepted over UDP and mapped into VRCFT
  unified eye, brow, and mouth expressions.
- Code donor value:
  high: `LiveLinkExtTrackingInterface.cs` shows `LiveLinkModuleConfig.json`,
  configurable port, first-packet wait, `UdpClient` receive, and explicit
  ARKit-to-`UnifiedExpressions` mapping.
- Product reference value:
  high for phone-as-face-tracker bridges and reusable blendshape mapping
  tables.
- What to inspect next:
  `LiveLinkTrackingDataStruct`, packet size/version assumptions, timeout UX,
  and whether eye gaze mapping is complete enough for current ARKit sources.

### `xverse-engine/XVRFaceTracking`

- Interesting idea:
  a DIY camera/ESP32 stream and Python ONNX UI can output mouth blendshape-like
  OSC parameters with runtime ROI, rotation, GPU/CPU, and smoothing controls.
- Code donor value:
  medium: `XverseVRfaceMouthDetectionUI.py` provides a compact camera-to-ONNX
  loop with PyQt controls, One Euro filtering, OpenCV capture, ONNX Runtime,
  and OSC parameter sends; firmware files show camera streaming and remote post
  pieces.
- Product reference value:
  high for low-cost face-input experiments, calibration panels, and camera ROI
  tuning UX.
- What to inspect next:
  model provenance, firmware protocol, lighting/calibration requirements,
  parameter normalization, and privacy/security caveats for camera streams.

## Reusable Pattern Extraction

- Pattern candidate:
  face/eye tracking module boundary across hardware drivers, expression
  schemas, avatar preparation, and receiver bridges.
- Problem solved:
  multiple hardware and software sources need to land in avatar-ready eye,
  mouth, brow, and parameter data without coupling device transport, smoothing,
  avatar setup, and diagnostics into one tool.
- Reusable core:
  module lifecycle, support flags, hardware/source adapter, packet or
  shared-memory ingress, validity flags, smoothing/filtering, unified
  expression mapping, avatar parameter budget checks, template generation,
  OSC/LiveLink receiver bridge, user-facing diagnostics, and follow-up matrix
  for partial support.
- Source evidence:
  `VirtualDesktop.VRCFaceTracking`, `VRCFTPicoModule`,
  `VRCFTTobiiAdvanced`, `VRCFTOmniceptModule`, `VRCFaceTracking-LiveLink`,
  `VRCFTReceiver`, `BinaryParameterTool`, `VRCFaceTracking-Templates`, and
  `XVRFaceTracking`.
- Abstraction boundary:
  keep sensor capture, transport, schema normalization, avatar authoring,
  runtime update loop, diagnostics, and privacy/licensing notes separate.
- What not to copy:
  hardcoded ports without diagnostics, unversioned packet structs, blocking
  waits as a universal update model, camera streams without privacy framing,
  or avatar parameter generation without rollback and budget checks.
- Method catalog action:
  add a face/eye tracking module matrix method.

## Follow-Up Gaps

- Build a face/eye tracking matrix across VRCFT modules, Virtual Desktop,
  PICO, Tobii/BrokenEye, Omnicept, LiveLink, templates, binary parameters, OSC
  receivers, DIY camera input, smoothing, and privacy.
- Deepen `VRCFTPicoModule`, `VirtualDesktop.VRCFaceTracking`, and
  `VRCFTTobiiAdvanced` as the strongest module donors.
- Deepen avatar-side preparation tools around parameter cost, binary
  compression, templates, generated layers, rollback, and package release
  hygiene.
- Treat `XVRFaceTracking` as a prototype reference until model provenance,
  normalization, and firmware/security boundaries are clearer.
