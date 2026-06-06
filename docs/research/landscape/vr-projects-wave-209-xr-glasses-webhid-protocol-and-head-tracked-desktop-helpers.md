# VR Projects Wave 209: XR Glasses WebHID Protocol and Head-Tracked Desktop Helpers

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-209-plan.md`
- `docs/research/program/github-research-wave-209-backlog.md`

Research mode: static source reading only. No external repository was run, built, installed, or launched.

## Why This Wave Matters

The XR glasses projects are useful for `VR-apps-lab` because they expose reusable utility patterns outside heavyweight VR runtimes: device discovery, packet parsing, calibration retrieval, head pose intake, drift correction, and desktop surface control.

The main reusable split is simple: keep protocol workbench code separate from the product surface that uses the sensor/display data.

## Project Findings

### `jakedowns/xreal-webxr`

- Interesting idea: use browser WebHID as a protocol workbench for Xreal/Nreal glasses, with device filtering, connection state, message parsing, and command helpers visible in a JavaScript app.
- Code donor value: high for protocol exploration. `common.js` handles WebHID support checks, vendor/product filtering, connect/disconnect events, Air/Light routing, current-glasses state, and hex-stream parsing. `js_air/manager.js` separates activation, firmware/status reads, wait-for-boot-device logic, and command helpers. `js_air/protocol.js` defines message constants, packet offsets, IMU packet fields, CRC helpers, and command construction/parsing.
- Product reference value: medium. It is workbench-like rather than polished, but the browser-permission flow is a useful UX boundary for device tools.
- Architecture pattern: browser HID adapter plus protocol table plus device manager plus workbench UI.
- Reusable method: isolate device discovery, message definitions, packet parsing, and risky commands so diagnostic tooling can expose read-only modes safely.
- Constraints and caveats: WIP status, browser HID permission constraints, firmware-command risk, and some encoding/noise in source comments.
- What to inspect next: whether read-only IMU/status extraction can be factored away from firmware update paths.
- Why it matters for `VR-apps-lab`: it is a strong donor for browser-based XR device diagnostics and protocol notebooks.

#### Reusable Pattern Extraction

- Pattern candidate: browser HID protocol workbench.
- Problem solved: explore and diagnose XR glasses without first building a native driver or OpenXR runtime integration.
- Reusable core: vendor/product filtering, permission flow, device state manager, message table, parser/build helpers, and safe command grouping.
- Source evidence: `common.js`, `js_air/manager.js`, and `js_air/protocol.js`.
- Abstraction boundary: separate read-only diagnostic parsing from firmware/control commands.
- What not to copy: firmware update flows as default utility behavior.
- Method catalog action: create Method 654.

### `alexwilson1/nreal_linux_test`

- Interesting idea: use Nreal yaw data to slice and display a wide X11 desktop inside the glasses, creating a crude head-tracked virtual desktop.
- Code donor value: medium as a proof of concept. `main.py` launches an external Nreal driver, parses `Pitch/Roll/Yaw` from stdout, captures a multi-screen X11 root image through GStreamer `ximagesrc`, calibrates left/right yaw with user prompts, slices monitor regions based on normalized yaw, and displays the result in a fullscreen OpenCV window moved to the glasses display.
- Product reference value: medium. The UX is rough, but the "turn head to reveal desktop span" idea is directly relevant to virtual display helpers.
- Architecture pattern: external device driver process plus stdout pose parsing plus desktop capture/slicing display loop.
- Reusable method: decouple pose source, desktop capture source, viewport selection, and final display surface.
- Constraints and caveats: Ubuntu/X11/Gnome-specific, root/docker setup notes, yaw-only tracking, external driver dependency, and no robust compositor integration.
- What to inspect next: whether newer Linux XR glasses projects replace X11 slicing with Wayland, Monado, or virtual display surfaces.
- Why it matters for `VR-apps-lab`: it gives a tiny model for head-tracked viewport selection and calibration prompts.

### `edwatt/real_utilities`

- Interesting idea: a native command-line utility can expose XR glasses protocol details through explicit HID interface selection, command summaries, packet build/parse helpers, and calibration reads.
- Code donor value: high for low-level protocol boundaries. `real_utilities.cpp` opens separate IMU/control HID interfaces, routes reads/writes, and handles calibration data segment reads. `protocol.cpp` contains command metadata, packet offsets, CRC32 support, command building, and response parsing/printing.
- Product reference value: low to medium. It is more diagnostic/protocol reference than end-user utility.
- Architecture pattern: native protocol tool with explicit interface roles and command parser module.
- Reusable method: define command metadata and parser code as a reusable protocol layer before adding UI, overlays, or desktop behavior.
- Constraints and caveats: low-level device access, vendor-specific protocol, and command safety needs careful handling.
- What to inspect next: read-only calibration/IMU extraction that could feed diagnostics without writing to the device.
- Why it matters for `VR-apps-lab`: it complements browser WebHID examples with a native protocol utility baseline.

### `Mailbot/Nreal_Air_Desktop_tool`

- Interesting idea: an AR desktop helper can frame its value around movable windows/desktops, curvature, saved layouts, drift correction, focus regain, and headset-friendly controls.
- Code donor value: low in this pass because source evidence is limited to README/product description.
- Product reference value: high. The described UX features map cleanly to future desktop-in-VR and lightweight display-surface tools.
- Architecture pattern: unknown from source, but product framing implies display surface manager plus layout persistence plus drift correction controls.
- Reusable method: preserve layout, curvature, focus, and drift controls as first-class product features rather than hidden settings.
- Constraints and caveats: README-only source evidence, Windows/NReal-specific scope, and no inspected implementation.
- What to inspect next: source availability, settings file format, window capture/creation strategy, drift correction model, and input-focus flow.
- Why it matters for `VR-apps-lab`: it is a concise product checklist for head-worn desktop tools.

## Cross-Project Lessons

- Protocol tools should isolate discovery, interface roles, command metadata, parser/build helpers, and read/write safety.
- Head-tracked desktop helpers need calibration, drift correction, layout persistence, and focus recovery as core UX.
- Browser WebHID is valuable for diagnostics and workbench tooling, while native HID tools are better for deeper protocol inspection.
- README-only product tools can still be valuable if they clarify missing UX requirements.

## Method Catalog Actions

- Added Method 654: XR glasses protocol workbench and head-tracked desktop viewport.

## Follow-Up Gaps

- Compare XR glasses protocol readers against OpenXR driver and Monado integration paths.
- Find modern display-surface managers that solve drift correction, window persistence, and safe focus recovery cleanly.
- Split future XR glasses research into read-only diagnostics, display UX, and runtime integration families.
