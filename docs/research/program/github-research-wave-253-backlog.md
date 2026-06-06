# GitHub Research Wave 253 Backlog

Date: 2026-06-06

Theme: SteamVR dashboard menu, keyboard, and gamepad navigation shims.

## Completed In This Wave

- Studied `mbucchia/SteamVR-Dashboard-KeyboardNav` as an OpenVR HMD driver
  shim with `TrackedDeviceAdded` hook, input profile override, shared-memory
  click flag, background client utility, and Windows-key dashboard/click
  mapping.
- Studied `lmore377/quest-steamvr-system-button` as an ADB/logcat watcher that
  converts Quest system button events into SteamVR dashboard debug URI toggles.
- Studied `AJBats/pad-vr` as a synthetic OpenVR controller driver with XInput
  companion, shared-memory state, HMD-derived chest pose, trigger/system/stick
  components, and SteamVR-running gate.
- Studied `MagnaLunas/SteamVRKeyboardLayoutChanger` as an obsolete SteamVR
  dashboard web-resource keyboard layout patcher.
- Studied `bpbwaite/ahk-svrvmr` as an AutoHotkey bridge from SteamVR/Windows
  volume value to Voicemeeter bus gain through remote DLL calls.
- Added a reusable method entry for SteamVR dashboard control shims.

## Follow-Up Queue

1. Compare dashboard control paths: driver shim, debug URI, synthetic
   controller, web resource patch, and external audio proxy.
2. Extract an input ownership checklist for SteamVR helpers.
3. Compare gamepad/keyboard dashboard shims with accessibility and no-controller
   workflows.

## Do Not Spend Time On Yet

- Do not run SteamVR, driver registration scripts, ADB, AutoHotkey, companion
  utilities, or packaged executables.
- Do not copy hidden global hooks, obsolete dashboard patching, or synthetic
  controller role stealing without safety notes.
- Do not treat `vrmonitor://debugcommands` as a stable public API.
