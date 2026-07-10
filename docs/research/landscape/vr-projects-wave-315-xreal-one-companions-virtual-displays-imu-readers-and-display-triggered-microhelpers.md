# Wave 315 - XREAL One Companions, Virtual Displays, IMU Readers, and Display-Triggered Microhelpers

This wave studies XREAL One and adjacent smart-glasses companions as reusable
references for IMU transport access, virtual-display lifecycle, privileged or
permissioned helper services, display-triggered automations, and cross-language
driver boundaries.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- XREAL One / One Pro companion utilities and drivers;
- smart-glasses workspace managers and virtual-display helpers;
- low-level IMU transport readers over network or HID-style equivalents;
- Android display-triggered micro-helpers;
- Linux XREAL/VIO stack markers where patch-level evidence exists.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `dripster82/ar_workspace_manager_for_xreal` | Full smart-glasses workspace manager | Studied | Rich reference for IMU transport split, virtual-display lifecycle, HUD/media widgets, diagnostics, and helper-service boundaries |
| `SamiMitwalli/One-Pro-IMU-Retriever-Demo` | Lightweight XREAL One Pro IMU proof-of-access | Studied | Small protocol decoder and complementary-filter head tracker over the XREAL network IMU stream |
| `rohitsangwan01/xreal_one_driver` | Rust plus C FFI IMU driver core | Studied | Buffer parser, axis remap, safety checks, and minimal native ABI for reuse by other stacks |
| `shugi12345/xreal-show-taps` | Android display-triggered micro-helper | Studied | Foreground monitor service that toggles Android `show_touches` through a Shizuku sidecar |
| `DeskUnreal/xreal-vio-vr` | Linux XREAL VIO/Monado/overlay stack direction marker | Studied | Valuable mainly as stack framing and patch evidence; much of the bridge code is still skeletal |

## Code-Level Findings

### `dripster82/ar_workspace_manager_for_xreal`

- Interesting idea:
  a smart-glasses workspace product can stay understandable if IMU transport,
  virtual displays, HUD/widgets, diagnostics, capture, media, and helper
  privileges are all explicit subsystems rather than hidden inside one render
  loop.
- Code donor value:
  very high. `AppCoordinator.swift` shows a large but legible orchestration
  layer: a `LiveStats` object exists solely to avoid whole-panel rerenders that
  caused tracking judder; workspace, voice, widget, media, and diagnostics
  services are separated; and virtual-display churn is tracked explicitly for
  ColorSync/WindowServer troubleshooting. `VirtualDisplayService.swift`
  captures the real donor core: workspace screen config schema, placement
  modes, persistent backgrounds, slot-based stable virtual-display identities,
  and reuse-vs-create bookkeeping to limit macOS display-registry churn.
  `IMUService.swift` keeps HID-style and network IMU transport, mount
  calibration, drift correction, and restart behavior explicit.
- Product reference value:
  extremely high for smart-glasses workspace products, diagnostics-heavy
  utilities, and "thin AR desktop shell with many optional helpers" design.
- What to inspect next:
  the compositor/capture pipeline, helper-service installation path, voice and
  widget service contracts, and workspace persistence details.
- Reusable pattern extraction:
  keep `IMU transport`, `virtual display lifecycle`, `workspace schema`,
  `diagnostics/churn telemetry`, and `helper-service boundaries` separate.

### `SamiMitwalli/One-Pro-IMU-Retriever-Demo`

- Interesting idea:
  the path to reuse can start with a tiny protocol decoder and a simple
  complementary filter, not a full runtime.
- Code donor value:
  medium-high. `imu_reader.py` connects to `169.254.2.1:52998`, frames packets
  with known header/footer markers, extracts six floats, and publishes samples
  through a callback. `head_tracker.py` adds 500-sample gyro calibration, zero
  view, angle wrapping, simple motion descriptions, and a complementary filter
  that keeps yaw on gyro-only while pitch/roll drift back toward accelerometer
  estimates.
- Product reference value:
  medium-high for protocol bring-up, head-tracking diagnostics, and rapid proof
  that a constrained device still exposes a reusable transport seam.
- What to inspect next:
  timestamp use, mount correction for device tilt, reconnect behavior, and
  validation against other One/One Pro readers.
- Reusable pattern extraction:
  keep `packet framing`, `sample decoding`, `bias calibration`, and `simple
  fusion` separate.

### `rohitsangwan01/xreal_one_driver`

- Interesting idea:
  a low-level smart-glasses driver becomes more reusable when it exposes one
  minimal native core with a clean FFI boundary rather than tying itself to one
  runtime or engine.
- Code donor value:
  high. `lib.rs` keeps the driver to a narrow surface: connect to the One's
  network IMU endpoint, maintain a receive buffer, search for known header and
  sensor markers, decode timestamp/gyro/accel values, reject NaN/infinite or
  unreasonable readings, remap axes, and expose `xo_new`, `xo_next`, and
  `xo_free` as a C ABI around a Rust implementation.
- Product reference value:
  high for native sidecars, multi-language smart-glasses integrations, and
  runtime-neutral sensor drivers.
- What to inspect next:
  reconnection behavior, error taxonomy, timestamp meaning, and how this core
  could back higher-level OpenXR/OpenVR bridges.
- Reusable pattern extraction:
  keep `transport parser`, `sanity guards`, and `FFI boundary` separate.

### `shugi12345/xreal-show-taps`

- Interesting idea:
  a tiny Android companion can watch for external display attachment and
  temporarily change a privileged system setting, then restore it on detach.
- Code donor value:
  high. `XrealMonitorService.kt` is a foreground `DisplayManager` listener that
  keeps a saved restore value, syncs state on display add/remove/change, and
  updates a low-noise notification. `ShizukuController.kt` wraps binder
  availability, permission requests, user-service binding, and a tiny AIDL
  boundary for reading/writing `show_touches`.
- Product reference value:
  high for micro-helpers on constrained Android stacks, especially where the
  user value is one narrow automation rather than a full companion app.
- What to inspect next:
  more reliable XREAL-only detection, boot persistence/recovery, and broader
  patterns for "external display connected" Android automations.
- Reusable pattern extraction:
  keep `display event observer`, `restore-state store`, and `privileged sidecar
  service` separate.

### `DeskUnreal/xreal-vio-vr`

- Interesting idea:
  the repository is stronger as a direction marker than as a direct donor: it
  names a Linux stack that wants Basalt, Monado, and overlay composition to fit
  together, and that framing is still worth recording.
- Code donor value:
  low-medium right now. The README and patch files matter more than the current
  runtime code. `basalt_fisheye624.patch` adds a `Fisheye624` camera model and
  relaxes strict frame/timestamp assertions. The OpenVR driver and bridge files
  are currently skeletal, and multiple AR runtime sources are placeholders.
  `ground_calibration_fsm.h` is interesting mainly as intent: use the headset
  itself as a ground-reference controller when a normal controller is absent.
- Product reference value:
  medium-high for Linux smart-glasses stack framing, dependency graphs, and
  "what the stack wants to become" documentation.
- What to inspect next:
  whether the bridge/overlay/runtime code becomes real, how Monado pose
  injection is implemented, and whether the calibration FSM survives beyond the
  concept stage.
- Reusable pattern extraction:
  keep this one as `product direction and patch evidence`, not as a strong code
  donor yet.

## Reusable Pattern Extraction

- Pattern candidate:
  smart-glasses companion boundary across IMU transport, virtual displays,
  helper permissions, cross-language driver cores, and display-triggered
  micro-automations.
- Problem solved:
  smart-glasses utilities span unusual seams: network/HID-ish sensors, private
  or platform-specific display APIs, privilege helpers, and tiny user-value
  automations. Reuse depends on keeping those seams explicit.
- Reusable core:
  IMU transport reader, sample parser, bias/mount/drift calibration, workspace
  and screen schema, stable display identity strategy, create/reuse/destroy
  display lifecycle, diagnostics/churn telemetry, privileged helper or sidecar
  service, and narrow display-triggered automations.
- Source evidence:
  `dripster82/ar_workspace_manager_for_xreal`,
  `SamiMitwalli/One-Pro-IMU-Retriever-Demo`,
  `rohitsangwan01/xreal_one_driver`, `shugi12345/xreal-show-taps`, and
  `DeskUnreal/xreal-vio-vr`.
- Abstraction boundary:
  keep sensor transport, display lifecycle, privileged operations, and
  user-facing automation separate.
- What not to copy:
  platform-private display tricks without fallback notes, unbounded helper
  privileges, placeholder stack claims presented as finished donors, or
  device-detection logic that silently triggers on unrelated displays.
- Method catalog action:
  add a smart-glasses companion boundary method.

## Follow-Up Gaps

- Deepen `ar_workspace_manager_for_xreal` capture/compositor/helper subsystems.
- Compare the various One/One Pro IMU readers directly for protocol,
  coordinate, drift, and reconnect differences.
- Revisit `xreal-vio-vr` only if the bridge/runtime code becomes more than a
  stack skeleton and patch set.
