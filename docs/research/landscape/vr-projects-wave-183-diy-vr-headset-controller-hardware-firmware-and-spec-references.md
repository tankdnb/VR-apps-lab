# VR Projects Wave 183: DIY VR Headset/Controller Hardware, Firmware, and Spec References

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 183 studies DIY VR headset/controller repositories as reusable boundary
references: firmware packets, HID report descriptors, BLE HID input/output,
OpenVR driver shells, haptics, camera marker tracking, headset BOM/CAD/PCB
constraints, and headset specification datasets.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `vis3r/NxtVR` | DIY headset firmware and HID HMD reports | Strong firmware/HID reference |
| `Kwiatens/FloV3R` | DIY 6DoF headset/controller BOM, PCB, CAD, and driver-dependency plan | Hardware documentation reference |
| `Jade-Vincent/Persephone-VR-Headset` | DIY headset CAD/BOM reference | Thin CAD/BOM reference |
| `CSParnell78/OpenVision` | Source-light headset concept | Thin concept reference |
| `vrrare/vr-headset-specs` | JSON/CSV headset specs dataset | Strong spec-schema reference |
| `dhfmzk/VRController` | Arduino/MPU9250 Bluetooth controller packet firmware | Compact firmware/protocol donor |
| `BlaiseSaunders/DIY-VR-Controller-OpenCV` | OpenCV IR marker coordinate sender | Compact vision-tracker donor |
| `Windastella/open-vr-controller` | No-progress DIY OpenXR controller concept | Excluded/thin reference |
| `shehraan/DIY_VR_Controller` | ESP32 BLE HID controller plus OpenVR driver shell | Strong end-to-end controller-stack donor |

## `vis3r/NxtVR`

- Interesting idea:
  build a low-cost DIY headset around Pico/STM32 firmware that exposes IMU
  motion through a Virtual Reality HID report descriptor.
- Code donor value:
  high for TinyUSB HID descriptors, raw IMU report structure, Pico I2C sensor
  loop, mount/suspend status callbacks, and MPU6050 calibration flow.
- Product reference value:
  high for DIY hardware bring-up, headset diagnostics, and understanding
  firmware-to-runtime boundaries.
- What to inspect next:
  compare the HID HMD report shape with OpenHMD/OpenVR driver expectations.
- Source evidence:
  `nxtvr.cpp`, `usb_descriptors.cpp`, `NxtVR_pico/nxtvr.cpp`,
  `NxtVR_pico/calibration.cpp`, `NxtVR_pico/sensors/mpu6050/mpu6050.cpp`, and
  `NxtVR_sketch/NxtVR_sketch.ino`.
- Reusable pattern extraction:
  microcontroller HMD HID report pipeline.
- Reusable core:
  initialize I2C and IMU, read accel/gyro at a steady cadence, define a VR HID
  report descriptor with accel/gyro/magnetometer axes, send packed HID reports
  through TinyUSB/USBComposite, and keep a separate offset-calibration program.
- Do not copy directly:
  raw IMU drift assumptions or old OpenHMD-specific dependency expectations.
- Caveats:
  valuable firmware boundary, but not a complete modern headset runtime.

## `Kwiatens/FloV3R`

- Interesting idea:
  document a full DIY 6DoF headset and controller build around affordable
  parts, PCBs, controller transceivers, LiPo batteries, PSMoveServiceEx
  tracking, and HadesVR driver dependency.
- Code donor value:
  low for firmware because firmware/driver folders are mostly `todo`, but high
  for hardware documentation shape, BOM, PCB constraints, and dependency map.
- Product reference value:
  high for explaining hardware tradeoffs, build cost, optics/display choices,
  camera-tracked controllers, and maker-oriented onboarding.
- What to inspect next:
  revisit if real firmware/driver source lands.
- Source evidence:
  `README.md`, `Instructions/About the project.md`,
  `Instructions/List of All Parts.md`,
  `Instructions/FloV3R R1 Headset PCB Guide.md`,
  `Instructions/FloV3R R1 Controller PCB Guide.md`, and
  `Firmware and Driver/*/todo`.
- Reusable pattern extraction:
  DIY headset/controller hardware documentation pack.
- Reusable core:
  keep BOM, PCB guide, assembly guide, printing guide, optics/display notes,
  firmware/driver plan, external tracker dependency, and project maturity
  warning together so builders understand constraints before implementation.
- Do not copy directly:
  incomplete firmware/driver placeholders or hardware claims as validated.
- Caveats:
  research value is documentation/product framing, not executable code.

## `Jade-Vincent/Persephone-VR-Headset`

- Interesting idea:
  maintain a small DIY headset CAD/BOM reference around a 2K LCD, Pro Micro or
  future Pico W, Cardboard lenses, and MPU6050.
- Code donor value:
  low; source is mainly CAD and BOM.
- Product reference value:
  medium for headset mechanical/BOM lineage and how open hardware projects
  communicate maturity warnings.
- What to inspect next:
  revisit if firmware or driver source appears.
- Source evidence:
  `README.md` and `CAD Files/STEP`.
- Reusable pattern extraction:
  source-light DIY headset CAD/BOM note.
- Reusable core:
  capture display, lens, microcontroller, IMU, CAD format, and maturity warning
  in one compact project note.
- Do not copy directly:
  unfinished build guidance or hardware assumptions.
- Caveats:
  useful as CAD/BOM reference only.

## `CSParnell78/OpenVision`

- Interesting idea:
  define a source-light open headset concept around commodity display options,
  Pro Micro/ATmega32U4, gyro module, phone-style shell, and wireless
  transmitter choices.
- Code donor value:
  low because no substantial firmware/driver was present in the read pass.
- Product reference value:
  medium as a hardware-option checklist for very early DIY headset concepts.
- What to inspect next:
  only deepen if source code, CAD, or driver content is added.
- Source evidence:
  `README.md`.
- Reusable pattern extraction:
  early hardware-option checklist.
- Reusable core:
  list candidate display, microcontroller, IMU, enclosure, and wireless
  transmitter parts while making project maturity explicit.
- Do not copy directly:
  unvalidated hardware assumptions.
- Caveats:
  concept reference, not a donor.

## `vrrare/vr-headset-specs`

- Interesting idea:
  store headset specifications as open JSON/CSV data with a JSON Schema that
  covers display, optics, tracking, physical traits, features, and target use.
- Code donor value:
  high for compatibility datasets, device inventory, recommendations,
  comparison tables, and schema-driven validation.
- Product reference value:
  high for future VR utility docs, headset selection helpers, capability
  matrices, and diagnostics/compatibility screens.
- What to inspect next:
  add source/provenance fields if this shape is adapted for serious
  compatibility tooling.
- Source evidence:
  `schema.json`, `data/headsets.json`, and `data/headsets.csv`.
- Reusable pattern extraction:
  headset specification dataset with validation schema.
- Reusable core:
  define stable headset IDs, split specs into display/optics/tracking/audio/
  connectivity/battery/physical/features/best-for fields, offer JSON plus CSV,
  and validate contributions with schema.
- Do not copy directly:
  unsourced specs or stale prices without current verification.
- Caveats:
  dataset freshness matters; treat as schema/reference, not authoritative
  current market truth.

## `dhfmzk/VRController`

- Interesting idea:
  stream a fixed 34-byte Bluetooth packet from Arduino/MPU9250 containing
  quaternion, dead-reckoned position, joystick, and trigger state.
- Code donor value:
  medium-high for compact binary packet layout, MPU DMP integration, start/end
  markers, joystick packing, and firmware-side trigger state.
- Product reference value:
  medium for early DIY controller protocol experiments and firmware packet
  shape discussions.
- What to inspect next:
  compare its dead-reckoned position with camera/tracker-assisted controller
  systems.
- Source evidence:
  `README.md` and `DIY.ino`.
- Reusable pattern extraction:
  fixed-size controller packet over serial/Bluetooth.
- Reusable core:
  pack quaternion floats, position floats, joystick/button bytes, and trigger
  state into a marker-delimited packet, transmit at sensor-update cadence, and
  keep packet layout documented in the README.
- Do not copy directly:
  naive accelerometer integration as reliable 6DoF position tracking.
- Caveats:
  protocol lesson is stronger than tracking quality.

## `BlaiseSaunders/DIY-VR-Controller-OpenCV`

- Interesting idea:
  use an IR camera/OpenCV threshold to find bright controller markers and send
  normalized coordinates over UDP.
- Code donor value:
  medium for compact marker-detection and UDP coordinate forwarding.
- Product reference value:
  medium for camera-assisted DIY controller experiments and calibration
  prototyping.
- What to inspect next:
  compare with PSMoveServiceEx and MediaPipe-style marker/hand tracking.
- Source evidence:
  `CvUnityTrack.py`.
- Reusable pattern extraction:
  bright-marker camera tracker to UDP.
- Reusable core:
  capture camera frames, threshold grayscale brightness, find contours,
  choose marker candidates, normalize coordinates, retain last known position,
  send coordinates over UDP, and draw debug rectangles.
- Do not copy directly:
  Python2/OpenCV API assumptions, fixed thresholds, or single-camera depth
  shortcuts.
- Caveats:
  compact proof of concept, not robust 6DoF tracking.

## `Windastella/open-vr-controller`

- Interesting idea:
  declare an intention for open DIY 6DoF controllers targeting OpenXR-capable
  platforms.
- Code donor value:
  none in this pass; README states no progress yet.
- Product reference value:
  low; useful only as a signal that OpenXR-targeted DIY controllers are a
  desired direction.
- What to inspect next:
  only revisit if source appears.
- Source evidence:
  `README.md`.
- Caveats:
  excluded from strong donor status.

## `shehraan/DIY_VR_Controller`

- Interesting idea:
  implement a fuller DIY controller stack: ESP32 firmware, MPU6050 filtering,
  BLE HID input reports, rumble output commands, Python HID tests, and an
  OpenVR driver that maps the reports into SteamVR controller components.
- Code donor value:
  high for firmware/driver protocol alignment, Madgwick filtering, EEPROM
  calibration, adaptive haptics mapping, BLE HID descriptor, packet IDs,
  freshness/stale thresholds, HID read thread, input profiles, and haptic
  round-trip.
- Product reference value:
  high for end-to-end controller-stack research and driver-boundary education.
- What to inspect next:
  separate built binaries/third-party artifacts from clean source and compare
  the OpenVR driver shell with existing driver tutorials.
- Source evidence:
  `src/main.cpp`, `lib/HIDTransport/HIDTransport.cpp`,
  `Drivers/vr_controller/include/controller_protocol.h`,
  `Drivers/vr_controller/src/hid_transport.cpp`,
  `Drivers/vr_controller/src/driver_main.cpp`,
  `Drivers/vr_controller/resources/input/vr_controller_profile.json`,
  `Drivers/vr_controller/resources/settings/default.vrsettings`, and
  `test/BLE_Simultaneous_Input_Test.py`.
- Reusable pattern extraction:
  DIY controller firmware to OpenVR driver boundary.
- Reusable core:
  define one shared controller protocol, send quaternion/buttons/joystick/
  packet timing through BLE HID, expose haptic output reports back to firmware,
  map rumble into firmware motor patterns, read HID on a driver thread, parse
  packets with report-ID handling, track dropped packets and staleness, update
  OpenVR pose/input components, and keep input profiles/settings explicit.
- Do not copy directly:
  built DLLs, bundled third-party binaries, device IDs, or one-controller
  assumptions without cleanup.
- Caveats:
  strongest donor in the wave, but should be mined for boundaries and methods,
  not imported wholesale.

## Cross-Project Lessons

- DIY VR hardware research is most reusable when it captures boundaries:
  sensor readout, calibration, packet schema, transport, driver mapping,
  haptics, and user-facing specs.
- Firmware packet documentation is a product asset; `VRController`, `NxtVR`,
  and `DIY_VR_Controller` are valuable because their data layout is visible.
- Hardware docs need maturity flags. Several projects are concept, TODO, CAD,
  or BOM references rather than build-ready systems.

## Methods Added Or Reinforced

- Microcontroller HMD HID report pipeline.
- DIY headset/controller hardware documentation pack.
- Headset specification dataset with validation schema.
- Fixed-size controller packet over serial/Bluetooth.
- Bright-marker camera tracker to UDP.
- DIY controller firmware to OpenVR driver boundary.

## Follow-Up Gaps

- Build a DIY XR hardware boundary matrix across firmware, driver, transport,
  calibration, haptics, CAD/BOM, and specs.
- Compare OpenVR, OpenXR, HadesVR, PSMoveServiceEx, HID-only, and UDP-tracker
  strategies for DIY controllers.
- Keep hardware sources out of `VR-apps-lab` history and extract only methods,
  schemas, and notes unless a specific prototype is planned.
