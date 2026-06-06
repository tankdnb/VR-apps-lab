# VR Projects Wave 246: SlimeVR DIY Tracker Hardware, PCB, Case, and Firmware Boundaries

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies SlimeVR-adjacent DIY tracker projects: full hardware kits,
PCB variants, multi-IMU board families, case ergonomics, source-light compact
tracker boards, and a Zephyr firmware skeleton.

## Why It Matters For `VR-apps-lab`

Tracker bridges and body tracking have appeared across many waves, but hardware
repositories add a different kind of reusable knowledge: board family choices,
IMU compatibility, battery/charging constraints, case/strap ergonomics,
calibration boundaries, firmware packet schemas, and manufacturing caveats.
This wave makes those hardware boundaries visible without turning the
repository into an electronics build guide.

## Project Notes

### `zhangwenchao1992/SlimeVR_DeftTracker`

- Interesting idea:
  a tracker reference can be a full kit: main tracker, auxiliary tracker,
  charging hub, cases, PCBs, pictures, and a vendored firmware tree.
- Code donor value:
  the repository contains `Main_Tracker`, `Auxiliary_tracker`, and
  `Charge_Hub` folders with 3D models, STL case parts, PCB BOM/Gerber/JSON,
  schematic PDFs, and photos. The firmware subtree includes SlimeVR tracker
  firmware components for multiple IMUs, quaternion/math filters, calibration,
  OTA, network/UDP, WiFi provisioning, battery monitor, LED manager, and
  configuration.
- Product reference value:
  strong reference for documenting a physical tracker as a complete product
  package rather than only firmware or only a PCB.
- What to inspect next:
  if hardware reuse becomes a target, build a matrix of board, enclosure,
  charger, battery, IMU, and firmware boundaries across SlimeVR derivatives.
- Architecture pattern:
  main tracker hardware + auxiliary tracker hardware + charge hub + enclosure
  files + firmware subtree.
- Reusable method:
  describe tracker hardware as a system-of-parts with explicit manufacturing
  and firmware handoff points.
- Caveats:
  large vendored firmware tree, hardware files require electronics review, and
  licensing/source provenance needs checking before reuse.

### `frosty6742/frozen-slimes-v2`

- Interesting idea:
  a DIY tracker PCB can use assembly UX as a design feature: strap slots,
  battery hot-swap, IMU-selection solder bridges, and firmware flashing notes.
- Code donor value:
  the README documents Wemos D1 mini, MPU6050/BMI160/BNO085 compatibility,
  TP4056 charging, 18650 battery, strap slots built into the PCB, bridge pads
  for IMU selection, assembly checklist, firmware flasher settings, IMU
  orientation values, BMI calibration notes, and CH340 driver caveats. Source
  files include Gerbers, EasyEDA JSON/PDFs, and older board versions.
- Product reference value:
  strong product/documentation reference for maker-friendly assembly guidance.
- What to inspect next:
  compare bridge-pad IMU selection with software IMU abstraction in firmware
  and config documents.
- Architecture pattern:
  multi-IMU PCB -> solder bridge selection -> standard flasher config ->
  battery/charger/strap integrated mechanical design.
- Reusable method:
  hardware variants should surface assembly decisions in docs, not hide them
  in schematic files.
- Caveats:
  electronics/manufacturing assumptions, older board versions, and no runtime
  code beyond configuration guidance.

### `TheButlah/slimevr_pcb`

- Interesting idea:
  a tracker PCB repository can split board families by maturity and ambition:
  simple breakout board versus production-ish SMT/RISC-V/BLE board.
- Code donor value:
  `breakout_slime` is documented as an easy two-layer through-hole/breakout
  board. `ferrous_slime` targets ESP32-C3 with USB-serial/JTAG, BLE 5,
  additional RAM, lower-power/security rationale, and compatibility with
  BNO08X, MPU6050, MPU9250/6500, and ICM20948 through solder jumpers. The
  `icm20948-breakout` notes explain voltage translation and optional socketing.
  KiCad changelog notes mention Adafruit BNO085 support, flush soldering,
  polarity/TP4056 fixes, and USB ESD migration.
- Product reference value:
  strong donor for board-family documentation, IMU compatibility strategy, and
  open hardware licensing posture.
- What to inspect next:
  inspect schematic nets and BOMs in a deeper electronics-specific pass if the
  repository ever adds hardware reference notes.
- Architecture pattern:
  simple board family + advanced board family + IMU breakout adapters +
  changelogged hardware constraints.
- Reusable method:
  document hardware maturity levels and compatibility jumpers as first-class
  architecture, not just files.
- Caveats:
  hardware expertise required, LFS artifact warnings during sparse clone, and
  no assumption that board files are production-ready.

### `gumorr/GummySlime`

- Interesting idea:
  a compact SlimeVR-compatible board can prioritize hand-solderability by
  choosing larger passives, module-based IMU boards, and exposed auxiliary pads.
- Code donor value:
  README notes describe Cheesecake compatibility, 0603 passives instead of
  0402, BMI-compatible module PCBs instead of direct IMU soldering,
  ESP32-C3-WROOM-02, auxiliary pads, 1mm PCB thickness, USB-C soldering order,
  BOM guidance, and PlatformIO defines for ESP32-C3, USB CDC, LSM6DSO,
  optional second IMU, external battery monitor, and pins. KiCad files expose
  BMI160/LSM footprints, ESP32-C3, USB-C, and TP4057 charging.
- Product reference value:
  useful reference for making tracker PCBs more approachable without losing
  SlimeVR compatibility.
- What to inspect next:
  compare with frozen-slimes and ferrous_slime around MCU/IMU selection,
  solderability, USB, and auxiliary tracker support.
- Architecture pattern:
  hand-solderable board -> module IMU boundary -> explicit firmware defines
  -> auxiliary expansion pads.
- Reusable method:
  pair hardware files with exact firmware config macros.
- Caveats:
  board-specific manufacturing choices, not a software donor, and requires
  hardware validation before reuse.

### `Tropingenie/Caribou-Slime`

- Interesting idea:
  hardware documentation can be explicit about BOM/cost, assembly intent,
  license reciprocity, and silkscreen source visibility.
- Code donor value:
  README describes an ESP32-C3 SuperMini plus BMI270 SlimeVR PCB, intended for
  hand assembly or PCBA. It lists major BOM items, battery/charging components,
  diode/resistor/capacitor choices, TP4056 USB-C board, and licensing under
  CERN-OHL-S with a requirement to keep source location visible.
- Product reference value:
  useful reference for open-hardware transparency and maker BOM discipline.
- What to inspect next:
  compare license obligations across open hardware tracker repositories before
  copying any board files.
- Architecture pattern:
  small MCU module + BMI270 board + charger/battery BOM + reciprocal hardware
  license.
- Reusable method:
  record license and manufacturing expectations alongside board architecture.
- Caveats:
  source files need electronics review, license obligations are stronger than
  typical software snippets, and not a runtime donor.

### `infopcgood/SMORES`

- Interesting idea:
  even source-light hardware repositories can signal new tracker directions,
  such as very small boards using nRF52840-class radios and newer IMUs.
- Code donor value:
  README is minimal, but the repository contains KiCad files, an EBYTE
  E73-2G4M08S1C footprint, switch assets, and GitHub metadata describing small
  SlimeVR PCBs around E73/nRF52840 and ICM-45686.
- Product reference value:
  source-light reference for the tiny-board and BLE/nRF tracker direction.
- What to inspect next:
  perform a schematic-specific pass if nRF52840 tracker firmware/hardware
  becomes relevant.
- Architecture pattern:
  compact KiCad board around nRF52840 module plus modern IMU direction.
- Reusable method:
  keep thin hardware variants as "needs deeper schematic study" rather than
  promoting them to donors prematurely.
- Caveats:
  README-light, no firmware studied, and implementation value is not proven in
  this wave.

### `ZRock35/TinyOfficial-Case`

- Interesting idea:
  tracker ergonomics often live in case repositories, not firmware: strap
  loops, open/closed tops, battery orientation, foam pads, and connector
  fragility.
- Code donor value:
  README describes a case remix for the official SlimeVR PCB and battery,
  clip/backplate options, open and closed tops, v1.2 angled strap loops for
  ankle use, battery orientation, foam pad warnings, and battery connector
  fragility notes.
- Product reference value:
  useful mechanical/UX reference for tracker wearing comfort and repair risk.
- What to inspect next:
  compare case/strap guidance across full tracker kits and official SlimeVR
  hardware docs.
- Architecture pattern:
  official board enclosure -> strap/clip variants -> user assembly warnings.
- Reusable method:
  include mechanical ergonomics and connector-risk notes in tracker product
  docs.
- Caveats:
  no code donor value and mostly STL/package reference.

### `1vers1on/vr_trackers`

- Interesting idea:
  a modern tracker firmware skeleton can be useful even before it is complete
  because it exposes packet schema, Zephyr device-tree boundaries, calibration,
  fuel gauge, charger state, and USB/ESB intent.
- Code donor value:
  `main.c` initializes IMU, magnetometer, MAX17048 fuel gauge, button, charger
  status GPIO, and USB while leaving the runtime loop as TODO. `data.h` defines
  a packed tracker packet with type, sequence number, quaternion, magnetometer
  data, battery, and status. `imu.c` uses Zephyr sensor APIs for LSM6DSV,
  reads gyro/accelerometer data, and includes a 500-sample gyroscope
  calibration routine. Board files include Zephyr device tree and KiCad
  hardware.
- Product reference value:
  strong firmware-boundary reference for future tracker bridge notes.
- What to inspect next:
  revisit when communication loop and host protocol are implemented.
- Architecture pattern:
  Zephyr board definition -> sensor/fuel/charger/button init -> packet schema
  -> calibration routines -> pending transport loop.
- Reusable method:
  define tracker packet and calibration boundaries before transport details.
- Caveats:
  incomplete runtime loop, no validated host bridge in this pass, and hardware
  specifics require review.

## Reusable Pattern Extraction

- Pattern candidate:
  DIY tracker hardware boundary matrix.
- Problem solved:
  body tracker projects mix hardware, firmware, battery, enclosure, calibration,
  and manufacturing decisions; reusing them safely requires clear boundaries.
- Reusable core:
  MCU choice, IMU compatibility, auxiliary tracker support, charger/battery
  model, enclosure/strap ergonomics, manufacturing outputs, BOM, firmware
  defines, calibration flow, packet schema, licensing, and known caveats.
- Source evidence:
  `SlimeVR_DeftTracker`, `frozen-slimes-v2`, `slimevr_pcb`,
  `GummySlime`, `Caribou-Slime`, `SMORES`, `TinyOfficial-Case`, and
  `vr_trackers`.
- Abstraction boundary:
  separate board design, enclosure, battery/charging, firmware configuration,
  packet transport, calibration, and user assembly documentation.
- What not to copy:
  hardware files without electronics review, license-restricted board sources
  without compliance checks, README-light boards as proven donors, or one
  tracker's IMU orientation as a universal default.
- Method catalog action:
  add a method entry for DIY tracker hardware and firmware boundary capture.

## Follow-Up Gaps

- Build a SlimeVR derivative matrix covering MCU, IMU, charger, battery, case,
  firmware, license, and maturity.
- Compare firmware packet schemas across SlimeVR, Zephyr tracker skeletons,
  OSC/WebSocket bridges, and SteamVR driver feeds.
- Extract a "tracker hardware note" template if the repository continues to
  collect electronics references.
