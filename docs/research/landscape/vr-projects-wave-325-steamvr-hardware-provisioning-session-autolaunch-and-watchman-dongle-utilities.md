# Wave 325 - SteamVR Hardware Provisioning, Session Autolaunch, and Watchman Dongle Utilities

This wave studies operational SteamVR helpers that make hardware and session
bring-up easier rather than rendering a VR UI directly.

No external project was run, built, installed, flashed, or launched.

## Scope

The wave was bounded to:

- USB-triggered SteamVR session launch helpers;
- SteamVR/Watchman dongle flashing guides and scripts;
- DIY Watchman dongle hardware packaging;
- projects not already tracked in registry/families.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `The-Graze/PSVR2-SteamVR-AutoLaunch` | USB-triggered SteamVR autolaunch microhelper | Studied | Thin tray utility showing WMI USB insertion watch, PSVR2 device-name match, SteamVR URI launch, manual tray fallback, and single-instance guard |
| `ykeara/SteamVR-Dongle-Flash` | Watchman dongle firmware provisioning guide/script | Studied | Source-light but useful as destructive-action documentation reference for SteamVR `lighthouse_watchman_update.exe` use and permanent-flash warnings |
| `ugokutennp/flowing-dongle-ccd` | DIY multi-device Watchman dongle hardware reference | Studied as hardware/product reference | Useful reference for nRF52840 plus USB-hub hardware packaging, KiCad/3D/BOM artifacts, firmware-source notes, and hardware caveats |

## Code-Level Findings

### `The-Graze/PSVR2-SteamVR-AutoLaunch`

- Interesting idea:
  a tray helper can launch SteamVR exactly when a headset-like USB device
  appears, avoiding manual runtime startup for PSVR2 sessions.
- Code donor value:
  medium. `Program.cs` uses a global mutex, `NotifyIcon`, WMI
  `ManagementEventWatcher` on `Win32_USBControllerDevice`, a device-name match
  for `PS VR2 Data 9`, and `steam://run/250820` through a detached `cmd.exe`
  start.
- Product reference value:
  high for session operator helpers because it is intentionally tiny and
  user-facing.
- What to inspect next:
  stable hardware IDs instead of display names, multiple locale/device-name
  variants, debounce behavior, and failure reporting when Steam is unavailable.
- Reusable method:
  device-presence-triggered runtime autolaunch.
- Caveat:
  matching a user-visible device name is fragile; a reusable helper should use
  vendor/product IDs, inventory display, and override config.

### `ykeara/SteamVR-Dongle-Flash`

- Interesting idea:
  a provisioning repo can package a high-risk SteamVR hardware operation as a
  short checklist plus script, while explicitly warning about irreversibility.
- Code donor value:
  low to medium. `flash.bat` hardcodes the default SteamVR path and calls
  `tools\lighthouse\bin\win32\lighthouse_watchman_update.exe -D ...bin`.
- Product reference value:
  high for hardware tool safety copy and destructive-action gating.
- What to inspect next:
  safer device enumeration, dry-run output, single-target selection, backup or
  rollback impossibility messaging, and non-default SteamVR path discovery.
- Reusable method:
  irreversible firmware provisioning checklist with explicit target selection.
- Caveat:
  the repo warns that all connected dongles may be flashed and the change may
  be permanent; do not copy the one-click script shape without adding guards.

### `ugokutennp/flowing-dongle-ccd`

- Interesting idea:
  VR hardware utility value can come from PCB, enclosure, BOM, and firmware
  provenance rather than an app codebase.
- Code donor value:
  low as software, medium as hardware packaging reference. The repo includes
  KiCad PCB data, case STL/STEP files, JLCPCB outputs, firmware hex files, and
  README-level bootloader/SoftDevice/application source locations.
- Product reference value:
  medium to high for VR hardware helper docs and DIY tracker/dongle ecosystems.
- What to inspect next:
  firmware licensing/provenance, flashing workflow, pairing constraints,
  multi-device connection limits, and validation notes.
- Reusable method:
  hardware artifact bundle with BOM, PCB, case, firmware provenance, and
  caveats.
- Caveat:
  this is a hardware reference, not a software donor; license and firmware
  source constraints should remain explicit.

## Reusable Pattern Extraction

- Pattern candidate:
  VR hardware/session microhelper with explicit provisioning gates.
- Problem solved:
  VR users need small helpers for headset startup, dongle provisioning, and
  hardware readiness, but these utilities can become unsafe if destructive
  device actions are hidden behind one-click scripts.
- Reusable core:
  device inventory, stable hardware matching, explicit target selection,
  launch/provision command, manual fallback, status/tray surface, dry-run,
  warnings, rollback or no-rollback statement, and artifact provenance.
- Source evidence:
  `The-Graze/PSVR2-SteamVR-AutoLaunch`,
  `ykeara/SteamVR-Dongle-Flash`, and `ugokutennp/flowing-dongle-ccd`.
- Abstraction boundary:
  keep detection, command execution, user confirmation, hardware artifacts,
  firmware provenance, and diagnostics separate.
- What not to copy:
  display-name-only hardware matching, hardcoded SteamVR paths, flash-all
  scripts without target selection, or firmware bundles without provenance and
  license notes.
- Method catalog action:
  add a hardware/session microhelper method.

## Follow-Up Gaps

- Compare USB-triggered launch helpers against broader runtime operator
  sidecars.
- Add a hardware-provisioning safety checklist if `VR-apps-lab` later includes
  scripts for SteamVR devices.
- Revisit DIY dongle/tracker hardware projects as a separate hardware-artifact
  family.
