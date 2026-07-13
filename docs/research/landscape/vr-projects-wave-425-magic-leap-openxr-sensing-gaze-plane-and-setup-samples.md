# VR Projects Wave 425 - Magic Leap OpenXR Sensing Gaze Plane And Setup Samples

- Date: `2026-07-13`
- Theme: Magic Leap/OpenXR sensing samples, gaze interaction, plane detection, and vendor setup tooling.

## Shortlist

| Project | Study status | Why it matters |
|---|---|---|
| `dilmerv/MagicLeapPlaneDetection` | Studied | Unity/OpenXR plane-detection sample with Magic Leap SDK package setup and spatial mapping permission/query flow |
| `dilmerv/MagicLeapEyeTracking` | Studied | Unity/OpenXR eye-tracking and gaze sample with permission gate and dwell-passcode UX |
| `magicleap/MixedRealityToolkit-Unity-PreGA` | Studied | Magic Leap-oriented MRTK fork/reference showing cross-platform toolkit and vendor pre-GA integration context |

## Cross-Project Synthesis

This wave focuses on vendor OpenXR feature bring-up, not on one finished app.
The reusable lesson is that sensing features need a visible setup lane:
package source, loader/features, permissions, capability state, sample scene,
and fallback behavior all need to be documented together.

The strongest donor value is the combination of permission-gated feature
adapters and small UX demos that prove the data is usable.

## Project Notes

### `dilmerv/MagicLeapPlaneDetection`

- Interesting idea:
  provide a ready Unity sample for Magic Leap OpenXR plane detection with
  vendor package setup and semantic plane queries.
- Code donor value:
  `PlaneConfigurationManager.cs` uses Magic Leap OpenXR/ARFoundation APIs,
  requests spatial mapping permission, and configures `XRPlaneSubsystem` query
  flags and minimum plane area.
- Product reference value:
  useful reference for future "feature doctor" flows that explain why plane
  detection is unavailable: package, loader, permission, query, or scene state.
- Source evidence:
  package manifest uses Magic Leap scoped registry and `com.magicleap.unitysdk`;
  scripts reference `UnityEngine.XR.MagicLeap`,
  `MagicLeapSupport`, `ARPlaneManager`, `MLPermission.SpatialMapping`,
  `MLXrPlaneSubsystem.Query`, semantic flags, and `MinPlaneArea`.
- Reusable core:
  vendor package manifest, permission request, subsystem lookup, plane query
  builder, semantic/type flags, and sample visualization.
- What not to copy:
  vendor sample structure as a product shell, Magic Leap-only code paths
  without feature probes, or permission requests without explanation.
- What to inspect next:
  modern SDK API changes, plane classification confidence, and OpenXR
  cross-vendor equivalent abstractions.

### `dilmerv/MagicLeapEyeTracking`

- Interesting idea:
  combine an eye-tracking permission gate with a small gaze-dwell passcode
  interaction that demonstrates the UX value of the signal.
- Code donor value:
  `GazeInputManager.cs` requests `MLPermission.EyeTracking`, queries
  eye-tracking devices, and exposes gaze pose; `GazePasscodeFeature.cs`
  raycasts from gaze and fills passcode targets over dwell time.
- Product reference value:
  strong reference for gaze-select UI, calibration checks, and permission-aware
  input fallback design.
- Source evidence:
  source uses `InputDevices.GetDevicesWithCharacteristics(EyeTracking)`,
  `CommonUsages.isTracked`, `EyeTrackingUsages.gazePosition`,
  `EyeTrackingUsages.gazeRotation`, `minGazeTimeOverNumbers`, material
  `_FillProgress`, and `UnityEvent` success/failure callbacks.
- Reusable core:
  permission gate, device discovery, tracked-state flag, gaze pose adapter,
  dwell timer, progress visualization, and interaction callbacks.
- What not to copy:
  gaze passcodes as security, hard-coded dwell defaults, or eye data retention
  without privacy labels.
- What to inspect next:
  calibration status APIs, confidence/validity fields, and mixed gaze/hand
  fallback.

### `magicleap/MixedRealityToolkit-Unity-PreGA`

- Interesting idea:
  show how a broad Unity MR toolkit can be carried into a vendor-specific,
  pre-general-availability OpenXR integration context.
- Code donor value:
  project README documents MRTK as a cross-platform input/building-blocks
  framework with editor simulation, UI controls, solvers, hand/eye tracking,
  diagnostics, and OpenXR support.
- Product reference value:
  useful cautionary reference: a large toolkit helps with interaction
  primitives, but vendor forks need explicit maturity and support labels.
- Source evidence:
  README describes MRTK features, OpenXR plugin support, HoloLens/WMR/Meta
  Quest/SteamVR targets, input system, hand/eye tracking, spatial awareness,
  diagnostics, and UI components.
- Reusable core:
  interaction toolkit facade, sample scenes, editor simulation, diagnostics,
  vendor capability notes, and support-boundary labels.
- What not to copy:
  pre-GA fork assumptions, full toolkit weight for a narrow utility, or
  platform support claims without current validation.
- What to inspect next:
  Magic Leap-specific changes from upstream MRTK and whether current MRTK/XRI
  packages cover the same feature set.

## Reusable Pattern Extraction

- Pattern candidate:
  `Vendor OpenXR sensing feature setup`.
- Problem solved:
  vendor sensing features fail for many reasons beyond code: package source,
  loader settings, feature toggles, permission state, and runtime capability
  all matter.
- Reusable core:
  package/scoped-registry record, setup checklist, loader/feature toggle,
  permission request, capability polling, sample signal visualizer, UX fallback,
  and support/maturity label.
- Source evidence:
  `dilmerv/MagicLeapPlaneDetection`, `dilmerv/MagicLeapEyeTracking`, and
  `magicleap/MixedRealityToolkit-Unity-PreGA`.
- Abstraction boundary:
  separate vendor setup automation from app logic, and keep permission/capability
  state visible to users.
- What not to copy:
  one-vendor assumptions, silent project setting mutation, or sensitive gaze
  data handling without consent and retention rules.
- Method catalog action:
  add new method for vendor OpenXR sensing setup.

## Follow-Up Gaps

- Build a cross-vendor sensing feature matrix for planes, gaze, hands, scene,
  anchors, and passthrough.
- Define a project-setting mutation audit format for vendor setup tools.
- Extract gaze UX rules for dwell, progress, cancellation, privacy, and fallback.

