# VR Projects Wave 121: XR Glasses WebHID, Virtual Displays, and Head-Tracked Desktop Helpers

- Date: `2026-06-05`
- Goal: add a focused GitHub discovery wave for smaller XR-glasses utilities
  around browser-side HID access, Linux screen capture, low-level protocol
  helpers, desktop-control product framing, and macOS head-tracked virtual
  display workflows.

## Why this wave exists

The repository already knows the large XR-glasses anchors. This wave studies
the smaller tools around them, because they show sharply bounded implementation
patterns: WebHID discovery, IMU packet inspection, display slicing, virtual
display lifecycle, menu-bar controls, and head orientation mapped into a
viewport.

These are directly relevant to `VR-apps-lab` because many future utilities will
look more like small companion surfaces than full spatial desktops.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by XREAL/Nreal WebHID, desktop, IMU, virtual display, and
   ultrawide families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist of new adjacent projects;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, product value, caveats, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `jakedowns/xreal-webxr` | Browser WebHID protocol workbench for XREAL/Nreal devices |
| `alexwilson1/nreal_linux_test` | Linux/X11 multi-screen viewport POC for Nreal Air |
| `Mailbot/Nreal_Air_Desktop_tool` | Thin product reference for using Nreal Air as a desktop-control helper |
| `edwatt/real_utilities` | Low-level C++ protocol utility around Nreal Air commands and reports |
| `DannyDesert/XReal-Ultrawide` | macOS menu-bar virtual ultrawide display with XREAL IMU and spatial viewport |

## Deep-pass notes by project

## `jakedowns/xreal-webxr`

- GitHub:
  [jakedowns/xreal-webxr](https://github.com/jakedowns/xreal-webxr)
- What it is:
  a browser-side WebHID workbench for XREAL/Nreal Air and Light devices.
- Interesting idea:
  device protocol exploration can live in a browser if the tool cleanly
  separates device filtering, permission request, product-family managers,
  report parsing, and live packet logging.
- Code-level notes:
  `common.js` filters HID devices by vendor/product IDs, handles connect and
  disconnect events, distinguishes Air and Light devices, and requests browser
  permissions. `js_air/glasses.js` wraps `sendReport`, `sendReportTimeout`,
  input-report handling, IMU polling, report maps, packet length/status
  distributions, brightness button reports, and CSV-like packet capture.
  `js_air/manager.js` exposes capability checks, firmware reads, firmware
  update scaffolding, sleep/brightness functions, and boot-device flows.
- Code donor value:
  high for browser-native HID probing, command/report wrappers, live protocol
  logging, and device-family split.
- Product reference value:
  high for in-browser XR hardware diagnostics and community protocol tools.
- Caveats:
  WebHID support and firmware-command risk; many paths are exploratory.
- What to inspect next:
  compare with native protocol utilities and Monado/XRLinuxDriver device
  drivers if hardware diagnostics become a branch.

## `alexwilson1/nreal_linux_test`

- GitHub:
  [alexwilson1/nreal_linux_test](https://github.com/alexwilson1/nreal_linux_test)
- What it is:
  an early Linux/X11 POC for multiple virtual displays in AR space on Nreal
  Air.
- Interesting idea:
  a minimal AR desktop can be prototyped as screen capture plus head-yaw
  calibration and viewport slicing, before building a full compositor or
  spatial desktop shell.
- Code-level notes:
  `main.py` uses GStreamer `ximagesrc` capture through OpenCV, assumes several
  1920x1080 input screens, prompts the user to look at left/right reference
  points, normalizes yaw, and slices or blends monitor regions into an output
  window positioned on the glasses display. The README documents X11/Gnome
  assumptions and possible `xrandr` virtual-display setup.
- Code donor value:
  medium for calibration prompts, multi-monitor capture, and viewport slicing
  math.
- Product reference value:
  medium for quick desktop-in-glasses experiments.
- Caveats:
  early alpha, X11/GStreamer assumptions, and no robust window-manager
  isolation.
- What to inspect next:
  compare with `breezy-desktop`, `Simula`, and `XReal-Ultrawide` for stronger
  desktop-surface architecture.

## `Mailbot/Nreal_Air_Desktop_tool`

- GitHub:
  [Mailbot/Nreal_Air_Desktop_tool](https://github.com/Mailbot/Nreal_Air_Desktop_tool)
- What it is:
  a small desktop-control concept/tool around Nreal Air glasses.
- Interesting idea:
  the product value of XR glasses can be framed as one simple desktop-control
  workflow rather than as a full XR runtime.
- Code-level notes:
  this repository currently exposes mainly README-level product framing rather
  than a rich source tree. It is useful as a product-reference marker, not as a
  code donor.
- Code donor value:
  low until source depth improves.
- Product reference value:
  medium for thin, user-value-first desktop helper framing.
- Caveats:
  no meaningful code-level donor found in this pass.
- What to inspect next:
  revisit only if the repository later gains source code or clearer releases.

## `edwatt/real_utilities`

- GitHub:
  [edwatt/real_utilities](https://github.com/edwatt/real_utilities)
- What it is:
  a C++ utility project for interfacing with Nreal Air devices.
- Interesting idea:
  low-level device helpers are useful when they keep protocol parsing and
  command surfaces separate from product shell code.
- Code-level notes:
  `real_utilities.cpp`, `protocol.cpp`, and `protocol3.cpp` expose a native
  command/protocol utility structure around Nreal Air device reports. In this
  wave it was primarily useful as a comparison point against `xreal-webxr` and
  `XReal-Ultrawide`'s vendored IMU/HID paths.
- Code donor value:
  medium for protocol utility boundaries.
- Product reference value:
  medium for device diagnostic or firmware/protocol helper tools.
- Caveats:
  sparse README; needs a targeted future pass before copying any protocol
  details conceptually.
- What to inspect next:
  compare against WebHID and native driver stacks in a dedicated XREAL protocol
  pass.

## `DannyDesert/XReal-Ultrawide`

- GitHub:
  [DannyDesert/XReal-Ultrawide](https://github.com/DannyDesert/XReal-Ultrawide)
- What it is:
  a macOS menu-bar app that creates a virtual ultrawide display for XREAL Air
  glasses and optionally turns it into a head-tracked spatial viewport.
- Interesting idea:
  a head-tracked desktop utility can be built as a virtual canvas plus
  capture/render viewport, with IMU orientation driving crop position and
  optional lean-to-zoom.
- Code-level notes:
  `VirtualDisplayManager.swift` manages private `CGVirtualDisplay` lifecycle,
  resolution changes, sleep/wake handling, and a separate spatial canvas.
  `XRealIMUService.swift` wraps vendored C HID/IMU code, reads orientation at
  about 60 Hz, publishes quaternions, and supports recenter. `SpatialTracker.swift`
  maps relative quaternions to yaw/pitch, applies dead zone and EMA smoothing,
  clamps viewport offsets inside a 3840x2160 canvas, and implements pitch-based
  lean-to-zoom. The README documents ScreenCaptureKit/IOSurface/Metal viewport
  rendering, vendored dependencies, and private API caveats.
- Code donor value:
  very high for virtual display lifecycle, head-tracked viewport math,
  smoothing, recenter, and IMU-service wrapping.
- Product reference value:
  very high for a focused menu-bar utility with one clear user value.
- Caveats:
  macOS private API, screen-recording permission, USB HID access, and
  heuristic 3DoF depth/zoom.
- What to inspect next:
  compare with Linux XR desktop shells and prior XR-glasses driver families.

## Cross-project synthesis

This wave strengthens the `head-tracked display utility` branch:

- device access can be browser WebHID, native HID, or driver-backed;
- display surfaces can start as X11/GStreamer capture, virtual displays, or
  desktop mirroring;
- IMU data needs recenter, smoothing, dead zones, and clear caveats;
- the best product shape is often a menu-bar/helper app with one strong
  workflow.

## Follow-up

1. Extract a cross-platform virtual-display/head-tracked viewport blueprint.
2. Compare XREAL-specific WebHID and native protocol utilities against driver
   stacks from earlier waves.
3. Keep private API and firmware/protocol caveats prominent in any reuse plan.
