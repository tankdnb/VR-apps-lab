# Wave 470: Virtual display and spatial desktop sidecars

- Date: `2026-07-16`
- Scope: Windows virtual-display drivers, monitor capture, AR-glasses pinning,
  and Unity/XR display surfaces that create or arrange desktop monitors for
  headset and spatial-screen workflows.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `StevenRice99/Virtual-Monitors` | Studied | Unity XR monitor viewer using Windows Display API, uWindowCapture, and virtual monitor driver scripts |
| `arigandores/AirPin` | Studied | RayNeo/XREAL-style screen pinning sidecar using DXGI capture, IMU head tracking, and transparent overlay rendering |
| `KtzeAbyss/Easy-Virtual-Display` | Studied | Managed host around virtual display driver installation, status, display inventory, and error taxonomy |
| `timminator/Virtual-Display-Driver` | Studied as driver reference | Windows indirect display driver with adapter selection, monitor count/mode config, and installer caveats |
| `wheaney/breezy-desktop` / `lc700x/desktop2stereo` | Existing overlap references | Already studied XR-glasses desktop and stereo desktop workflows |

## Project notes

### `StevenRice99/Virtual-Monitors`

- Interesting idea: mirror every Windows monitor into Unity XR using captured
  desktop textures and Windows monitor layout coordinates, with optional
  virtual-display driver scripts for more screens.
- Code donor value: high conceptually; `Assets/Scripts/Manager.cs` shows the
  monitor enumeration, capture prefab creation, position caching, centering,
  and performance caveats.
- Product reference value: high for VR desktop shells, lab dashboards, and
  in-headset multi-monitor panels.
- Source evidence: `readme.md`, `Assets/Scripts/Manager.cs`,
  `Drivers/*.bat`, `Assets/Packages/WindowsDisplayAPI.*`, and Unity package
  manifest.
- Reusable core: monitor inventory, display coordinate cache, desktop texture
  prefab, WindowsGraphicsCapture mode, title update throttling, monitor layout
  centering, scale-per-pixel setting, and driver setup notes.
- What not to copy: admin batch flows, bundled DLLs without provenance review,
  Windows-only assumptions, and no runtime monitor creation/removal UX.
- What to inspect next: whether monitor layout should become a standalone
  schema shared with remote desktop and overlay panel families.

### `arigandores/AirPin`

- Interesting idea: pin a duplicate-mode desktop in AR glasses by capturing
  the screen, applying IMU head-tracking offset, and rendering a capture-proof,
  mouse-transparent fullscreen overlay.
- Code donor value: medium; the architecture notes are more important than the
  Python implementation.
- Product reference value: high for spatial desktop pinning and "head-tracked
  screen without full compositor" utilities.
- Source evidence: `CLAUDE.md`, `spatial_renderer.py`, `window_capture.py`,
  IMU/renderer notes, and configuration constants.
- Reusable core: DXGI desktop duplication, BGRA texture upload, orthographic
  1:1 pixel mapping, FOV-to-pixels-per-degree, yaw decay, transparent/topmost
  overlay, EXCLUDEFROMCAPTURE, and capture limitations.
- What not to copy: duplicate-mode-only design, game capture assumptions,
  device-specific IMU mapping, and click mismatch between pinned image and real
  screen.
- What to inspect next: relation to XREAL/Breezy workspace shells and whether
  input remapping belongs in the same sidecar.

### `KtzeAbyss/Easy-Virtual-Display`

- Interesting idea: wrap virtual display driver operations in a managed host
  with explicit CLI/admin commands, display summaries, driver status checks,
  and machine-readable error codes.
- Code donor value: high for operator UX; `native/EasyVirtualDisplay.*` exposes
  a clean host/service/contract/error split.
- Product reference value: high for any VR utility that needs virtual display
  lifecycle management without raw batch scripts.
- Source evidence: `native/EasyVirtualDisplay.Host/Cli/AdminCli.cs`,
  `Errors/HostErrorMapper.cs`, `Vdd/Services/Core.cs`,
  `Vdd/Services/ContractMapper.cs`, and tests.
- Reusable core: install/uninstall commands, driver presence/version detection,
  display inventory, supported resolutions, current mode, unsupported-mode
  flag, error codes, and driver restart/disabled states.
- What not to copy: bundled installer assumptions, privileged driver changes
  without user-visible safety gates, and Windows-only implementation details.
- What to inspect next: API shape for a future "virtual display doctor" panel.

### `timminator/Virtual-Display-Driver`

- Interesting idea: expose multiple virtual monitors through an indirect
  display driver, with adapter selection, monitor modes, HDR variants, and
  installer/community packaging.
- Code donor value: medium to high as lower-level reference; direct reuse is
  risky, but the state model matters.
- Product reference value: high for understanding the actual driver boundary
  behind virtual desktop utilities.
- Source evidence: `Virtual Display Driver (HDR)/MttVDD/Driver.cpp`,
  `Driver.h`, `Common/Include/AdapterOption.h`, community scripts, and driver
  README files.
- Reusable core: IddCx adapter init, DXGI adapter selection, monitor count,
  mode list, EDID/monitor descriptors, swap-chain processing, config files,
  logs, and reload behavior.
- What not to copy: driver code or installers into this repo, certificates,
  community installer payloads, and kernel/driver operations without a separate
  security and license review.
- What to inspect next: how virtual display drivers should be documented as
  dependency boundaries rather than vendored donor code.

## Reusable pattern extraction

- Pattern candidate: `Virtual display sidecar with monitor inventory, driver
  lifecycle, and XR capture surface`.
- Problem solved: VR desktop utilities need monitors that may not physically
  exist, plus safe inventory, capture, placement, and teardown flows.
- Reusable core: virtual display dependency label, install/uninstall gate,
  driver status, monitor inventory, mode/resolution list, layout coordinates,
  capture backend, XR panel placement, operator errors, safety warnings, and
  cleanup instructions.
- Source evidence: `Virtual-Monitors/Assets/Scripts/Manager.cs`,
  `Easy-Virtual-Display/native/*`, `Virtual-Display-Driver/*/Driver.cpp`, and
  `AirPin/CLAUDE.md`.
- Abstraction boundary: keep driver operations, monitor inventory, capture,
  spatial layout, and headset UI as separate layers.
- What not to copy: privileged scripts, driver binaries, certificates,
  Windows-only assumptions without labels, and pointer/input mismatches hidden
  from users.
- Method catalog action: add `Method 915`.

## Why this matters for VR-apps-lab

Previous waves covered remote desktop, overlays, and XR-glasses shells. This
wave strengthens the lower-level "display surface exists" layer: virtual
monitors, capture, inventory, driver safety, and spatial placement.

