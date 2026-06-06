# GitHub Research Wave 251 Backlog

Date: 2026-06-06

Theme: OpenVR legacy sensor compatibility and synthetic driver shims.

## Completed In This Wave

- Studied `SDraw/driver_leap` as a Leap Motion to SteamVR controller driver
  with Leap poller thread, tracking reference registration, left/right
  controller devices, skeleton/input mapping, controller overlays, and
  companion settings app.
- Studied `SDraw/driver_kinectV1` as a Kinect skeleton to SteamVR generic
  tracker driver with joint filters, Vive Tracker-style identity properties,
  dashboard settings, tracker toggles, and controller-driven calibration.
- Studied `SDraw/driver_kinectV2` as the Kinect V2 sensor variant with similar
  driver/dashboard/calibration boundaries and runtime-specific caveats.
- Studied `schellingb/PseudoVive` as an early-load OpenVR driver shim using
  MinHook around property writes to force Vive manufacturer/model identity,
  with optional systray toggling.
- Studied `r57zone/Half-Life-Alyx-novr` as a game-specific no-HMD driver and
  control-mapping reference with SteamVR sample driver lineage, INI key maps,
  virtual HMD/controller setup, and heavy caveats.
- Studied `lixiangwuxian/Viulux-V9-Driver-for-SteamVR` as a README-only
  vendor headset bridge reference tying Viulux, Relativty, OpenHMD, and Nolo
  kit requirements together with explicit bug warnings.
- Studied `Blockmann2K/MurlokVR` as a DIY headset experiment with firmware,
  Rust serial runtime, shared-memory pose contract, OpenVR factory/provider,
  HMD settings, input profile, and pose snapshot polling.
- Added a reusable method entry for OpenVR compatibility driver boundaries.

## Follow-Up Queue

1. Build a matrix comparing sensor polling, device identity, calibration,
   companion UI, and transport across Leap, Kinect, PseudoVive, no-HMD, Viulux,
   and MurlokVR.
2. Compare legacy OpenVR skeleton/tracker drivers with modern OpenXR hand and
   tracker approaches.
3. Extract a minimal safe checklist for custom OpenVR driver notes.

## Do Not Spend Time On Yet

- Do not run SteamVR, drivers, installers, firmware, serial runtimes, or
  hardware tests.
- Do not copy identity spoofing, global key injection, obsolete SDK setup, or
  README-only hardware claims as recommended implementation.
- Do not treat game-specific no-HMD mappings as a general VR utility pattern.
