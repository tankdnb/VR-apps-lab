# Wave 378: OpenXR Vendor Camera Rig and Passthrough Adapter Packages

## Theme

Camera rig and vendor SDK adapter packages that hide OpenXR/Pico/Wave/Vive
passthrough and device records behind reusable rig boundaries.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `ExtendRealityLtd/Tilia.CameraRigs.OpenXR.Unity` | Studied | OpenXR camera rig node records and passthrough manager boundary |
| `ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity` | Studied | PICO device record, passthrough toggle, dominant-hand priority, and haptics wrapper direction |
| `ExtendRealityLtd/Tilia.SDK.WaveXR.Unity` | Studied | HTC WaveXR SDK wrapper package and camera-rig integration direction |

## Dedupe Notes

Wave 374 covered XR Plugin Framework and spatial simulator camera rig packages.
This wave focuses on OpenXR/vendor SDK integration and passthrough/device
capability boundaries.

## Code-Level Findings

### `ExtendRealityLtd/Tilia.CameraRigs.OpenXR.Unity`

- Interesting idea: OpenXR nodes are described through records that can expose
  pass-through capability through a `BasePassthroughManager`.
- Code donor value: `OpenXRNodeRecord` keeps `XRNode`, passthrough manager,
  `HasPassThroughCamera`, and enable/disable passthrough calls behind the rig
  record boundary.
- Product reference value: useful for mixed-reality utilities that need to ask
  "does this node/rig support passthrough?" without hardcoding vendor APIs.
- What to inspect next: `BasePassthroughManager` subclasses and profile
  switching helpers.
- Caveat: runtime/plugin detection must be explicit and reversible.

### Vendor SDK wrappers

- Interesting idea: vendor-specific device status, priority, and passthrough
  calls are wrapped as camera rig/device record details.
- Code donor value: `PXRDeviceDetailsRecord` maps `XRNode` to PICO controller
  enums, checks connectivity, uses dominant-hand priority, and toggles
  see-through; the OpenXR Vive sample validates runtime name before underlay
  passthrough operations.
- Product reference value: helpful for vendor capability adapters, device
  inventory panels, passthrough toggles, and runtime feature gates.
- What to inspect next: WaveXR node/manager class names and haptic capability
  wrappers.
- Caveat: vendor SDK calls should never leak into generic utility feature code.

## Reusable Pattern Extraction

- Pattern candidate: vendor capability adapter behind rig/device records.
- Problem solved: passthrough, controller connectivity, dominant hand, and
  runtime-specific features vary by vendor but utility code needs one capability
  surface.
- Reusable core: rig record, node type, connected state, priority,
  passthrough manager, enable/disable lifecycle, runtime validity probe,
  vendor-controller mapping, haptic wrapper, profile switcher, and unsupported
  state label.
- Source evidence: `OpenXRNodeRecord`, `PXRDeviceDetailsRecord`,
  Vive OpenXR passthrough processor, and SDK package prefab creators.
- Abstraction boundary: generic tools consume capability records; vendor SDKs
  remain isolated adapter modules.
- What not to copy: vendor APIs in feature scripts, runtime-name checks without
  fallback UI, or passthrough toggles without permission/capability labels.
- Method catalog action: add Method 823.

## Family Placement

Creates a family for OpenXR/vendor rig and passthrough adapters. It connects to
platform foundation, passthrough, diagnostics, and runtime helper families.

## Follow-Up Gaps

- Compare this with prior Quest camera, passthrough, and vendor OpenXR waves.
- Draft a generic capability record schema for rig/device/passthrough state.
- Inspect safe runtime/profile switching UX.
