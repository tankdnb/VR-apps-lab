# GitHub Research Wave 246 Backlog

Date: 2026-06-06

Theme: SlimeVR DIY tracker hardware, PCB, case, and firmware boundaries.

## Completed In This Wave

- Studied `zhangwenchao1992/SlimeVR_DeftTracker` as a full hardware kit with
  main tracker, auxiliary tracker, charging hub, STL/case models, PCB
  BOM/Gerber/schematic files, photos, and a broad SlimeVR firmware subtree.
- Studied `frosty6742/frozen-slimes-v2` as a maker-friendly PCB reference with
  Wemos D1 mini, multiple IMU options, TP4056 charging, hotswappable 18650,
  strap slots, bridge pads, assembly checklist, firmware orientation notes,
  BMI calibration notes, and CH340 caveat.
- Studied `TheButlah/slimevr_pcb` as a board-family donor with simple
  `breakout_slime`, advanced ESP32-C3 `ferrous_slime`, IMU breakout adapters,
  compatibility jumpers, changelogged hardware fixes, and open-hardware
  license posture.
- Studied `gumorr/GummySlime` as a hand-solderability reference with 0603
  passives, module IMU boards, ESP32-C3-WROOM-02, auxiliary pads, USB-C order,
  BOM, KiCad files, and PlatformIO defines.
- Studied `Tropingenie/Caribou-Slime` as a compact ESP32-C3/BMI270 board with
  BOM/cost notes, charger/battery design, and reciprocal open-hardware license
  requirements.
- Checked `infopcgood/SMORES` as a source-light tiny-board direction around
  EBYTE E73/nRF52840 and ICM-45686.
- Checked `ZRock35/TinyOfficial-Case` as a mechanical/ergonomics reference for
  official SlimeVR board cases, strap loops, battery orientation, foam, and
  connector fragility.
- Studied `1vers1on/vr_trackers` as a Zephyr firmware-boundary skeleton with
  IMU/magnetometer/fuel/charger/button/USB init, packed tracker packet schema,
  and gyroscope calibration.
- Added a reusable method entry for DIY tracker hardware boundary matrices.

## Follow-Up Queue

1. Build a SlimeVR derivative matrix across MCU, IMU, battery, charger, case,
   firmware, packet schema, license, and maturity.
2. Compare packet schemas and calibration routines across hardware trackers,
   OSC bridges, WebSocket bridges, and SteamVR custom drivers.
3. Create a tracker hardware note template if the repository continues to
   catalog electronics projects.

## Do Not Spend Time On Yet

- Do not manufacture, flash, or test hardware from these repositories.
- Do not copy board files without electronics review and license compliance.
- Do not promote source-light PCB variants as proven donors without deeper
  schematic and firmware evidence.
