# VR Projects Wave 192: PSVR2 OpenXR Passthrough, Eye-Tracking, and SteamVR Integration Shims

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 192 studies PSVR2-specific integration work around OpenXR passthrough,
SteamVR eye-tracking shims, Monado driver plumbing, and archived multi-tracker
gaze layers. The reusable value is not "PSVR2 support" as a product promise;
it is the set of boundaries between vendor hardware streams, runtime layers,
driver shims, calibration, config, and gaze/passthrough feature exposure.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Obsidiate/psvr2passthrough` | OpenXR implicit API layer for PSVR2 passthrough | Strong API-layer composition donor |
| `BattleAxeVR/PSVR2_STEAMVR_EYE_TRACKING_SHIM` | SteamVR driver shim for PSVR2 gaze | High-risk but useful shim reference |
| `DMJC/monado-psvr2` | Monado PSVR2 driver fork | Runtime-driver integration reference |
| `etwodev/Volby` | PSVR2 SteamVR integration wrapper | Source-light product reference |
| `mbucchia/_ARCHIVE_OpenXR-Eye-Trackers` | Archived OpenXR gaze layer | Strong multi-tracker abstraction lineage |

## `Obsidiate/psvr2passthrough`

- Interesting idea:
  an OpenXR implicit API layer injects stereo passthrough from PSVR2 bottom
  cameras into OpenXR app frames under SteamVR.
- Code donor value:
  high for API-layer dispatch interception, session adoption, shared-memory
  camera ingestion, per-eye composition, visibility gating, config persistence,
  and runtime safety switches.
- Product reference value:
  high for experimental passthrough utilities and runtime-side view
  augmentation tools.
- What to inspect next:
  latency mitigation, calibration quality, non-D3D11 graphics paths, and
  safer install/uninstall workflow.
- Source evidence:
  `src/layer/layer_main.cpp`, `src/layer/layer_session.cpp`,
  `src/core/camera_source.cpp`, and `src/config/config.cpp`.
- Reusable pattern extraction:
  OpenXR passthrough API layer with shared camera feed and button-gated
  composition.
- Reusable core:
  negotiate an API-layer interface, wrap `xrGetInstanceProcAddr`, adopt only
  supported sessions, read a calibrated camera feed through a separate
  provider, create per-eye swapchains, inject only when target layers and
  visibility state allow it, and keep user-controlled alpha/geometry/toggle
  config outside the app.
- Do not copy directly:
  PSVR2-specific shared-memory assumptions, reverse-engineered calibration,
  registry install details, D3D11-only assumptions, or passthrough defaults
  that can cause discomfort.
- Caveats:
  experimental runtime intervention, alpha/latency caveats, and device-specific
  dependencies make this an architecture donor rather than a drop-in baseline.

## `BattleAxeVR/PSVR2_STEAMVR_EYE_TRACKING_SHIM`

- Interesting idea:
  a SteamVR driver shim wraps the PSVR2 HMD driver and exposes vendor gaze data
  through a standard gaze interaction path.
- Code donor value:
  medium-to-high for driver-factory boundaries, tracked-device wrapping,
  named-pipe gaze ingestion, validity checks, and shim placement.
- Product reference value:
  high for understanding how users bridge vendor data into standard APIs when
  native runtime support is incomplete.
- What to inspect next:
  calibration status, failure states, security of the pipe protocol, and
  compatibility with modern PSVR2 drivers.
- Source evidence:
  `driver_shim/Driver.cpp`, `ShimDriverManager.cpp`, and
  `psvr2_eye_tracking.cpp`.
- Reusable pattern extraction:
  SteamVR server-driver shim that exposes a vendor data stream as gaze state.
- Reusable core:
  hook driver registration at the server-driver boundary, detect the target HMD
  driver, wrap only the intended tracked-device class, connect to a local
  vendor data pipe, request combined/per-eye gaze, validate samples, and expose
  a standard gaze surface to consumers.
- Do not copy directly:
  Detours-based driver hooking, bundled binaries, exact driver names, or
  unfinished calibration behavior without a separate safety review.
- Caveats:
  technically instructive but high-risk because it sits inside SteamVR driver
  plumbing.

## `DMJC/monado-psvr2`

- Interesting idea:
  a Monado fork wires PSVR2 support through a runtime driver, including USB
  endpoints, prober integration, distortion, pose, status, camera, and SLAM
  paths.
- Code donor value:
  high for runtime-driver anatomy and hardware bring-up boundaries.
- Product reference value:
  medium for PSVR2-on-PC feasibility and runtime integration complexity.
- What to inspect next:
  upstream status, calibration completeness, camera privacy constraints, and
  which pieces remain experimental versus merged.
- Source evidence:
  `CMakeLists.txt`, `src/xrt/drivers/CMakeLists.txt`,
  `src/xrt/drivers/psvr2/psvr2.h`, and `src/xrt/drivers/psvr2/psvr2.c`.
- Reusable pattern extraction:
  runtime driver integration path for a non-native headset.
- Reusable core:
  register a build option and enabled driver, define device interfaces and USB
  endpoints, expose a prober, parse status/SLAM/camera streams, compute view
  poses and distortion, and plug the driver into the runtime's headset driver
  list.
- Do not copy directly:
  fork-specific Monado internals, device endpoint constants, or experimental
  hardware handling as generic runtime code.
- Caveats:
  valuable as a map of driver responsibilities, not as a small utility donor.

## `etwodev/Volby`

- Interesting idea:
  source-light product framing for seamless PSVR2 SteamVR integration.
- Code donor value:
  low until more source detail is available.
- Product reference value:
  low-to-medium as a signpost that users want turnkey PSVR2 integration.
- What to inspect next:
  release artifacts, actual runtime boundary, and whether the project exposes
  reusable setup or diagnostics.
- Source evidence:
  README and repository structure.
- Reusable pattern extraction:
  source-light integration wrapper reference.
- Do not copy directly:
  product promises without source-backed architecture.
- Caveats:
  keep as a thin reference only.

## `mbucchia/_ARCHIVE_OpenXR-Eye-Trackers`

- Interesting idea:
  an archived OpenXR API layer exposes multiple eye-tracker sources through
  `XR_EXT_eye_gaze_interaction`, including runtime passthrough, simulated
  gaze, Quest, Omnicept, Pimax, Virtual Desktop/Steam Link, PSVR2 Toolkit,
  VRChat OSC, and Varjo paths.
- Code donor value:
  high for tracker abstraction, extension gating, source priority, stale-data
  checks, and API-layer gaze action/pose implementation.
- Product reference value:
  high as lineage for provider-neutral gaze sidecars.
- What to inspect next:
  maintained successors, tracker-specific legal/runtime caveats, and a modern
  test matrix for gaze validity.
- Source evidence:
  `openxr-api-layer/layer.cpp` and `psvr2_toolkit.cpp`.
- Reusable pattern extraction:
  multi-source eye-tracker adapter exposed through OpenXR gaze interaction.
- Reusable core:
  detect whether the app requested the gaze extension, decide whether runtime
  support is present or should be supplied by a tracker backend, choose a
  tracker by priority, poll tracker-specific transports, reject stale samples,
  and expose the latest valid gaze as OpenXR action/pose data.
- Do not copy directly:
  archived code, tracker SDK assumptions, Windows-only layer setup, or
  device-specific transports without current compatibility review.
- Caveats:
  strong concept donor despite archival status.

## Cross-Project Lessons

- PSVR2 utility work repeatedly splits into three boundaries: runtime layer,
  driver shim, and external data provider.
- Passthrough and gaze are both calibration-sensitive; reusable docs must
  include validity, latency, stale-data, and user-comfort caveats.
- Driver hooks can unlock features but are much riskier than API-layer or
  sidecar approaches.
- Source-light wrappers should stay product references until their runtime
  boundaries are visible.

## Reuse Recommendations

1. Use `psvr2passthrough` for the OpenXR layer and composition boundary.
2. Use `PSVR2_STEAMVR_EYE_TRACKING_SHIM` as a cautionary SteamVR shim map.
3. Use `monado-psvr2` for runtime-driver anatomy.
4. Use `_ARCHIVE_OpenXR-Eye-Trackers` for provider-neutral gaze abstraction.

## Follow-Up Gaps

- Build a PSVR2 calibration matrix covering camera intrinsics, distortion,
  reprojection, IPD, latency, gaze validity, and stale data.
- Compare API-layer, driver-shim, and runtime-driver risk levels.
- Track maintained successors for archived eye-tracker layers.
- Decide whether future PSVR2 notes belong under passthrough, gaze, runtime
  driver, or vendor enhancement families.
