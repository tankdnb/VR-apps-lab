# Wave 330 - SteamVR Device Provisioning, Base-Station Diagnostics, and Visual Asset Patchers

This wave studies SteamVR hardware-adjacent utilities for dongle flashing,
base-station diagnostics, and device icon/render-model patching.

No external project was run, installed, or launched.

## Scope

The wave was bounded to:

- Watchman/nRF52840 dongle firmware generation and UF2 flashing;
- base-station serial diagnostics and fault classification;
- SteamVR icon replacement;
- SteamVR render-model replacement.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `jaki-gh/Viva-Dongle-Flasher` | Watchman dongle GUI flasher | Studied | Useful donor for prerequisite-gated firmware generation/flash UI, SteamVR firmware zip lookup, UF2 conversion, drive selection, and irreversible action copy |
| `TerayTech/SteamVR_BaseStation2.0_Diagnostic_Tool` | Base-station serial diagnostic viewer | Studied | Useful hardware doctor reference for serial worker queues, parameter parsing, category/status classification, thresholds, and bounded UI log tables |
| `nicolas-riera/SteamVR-IconsSwitcher` | SteamVR device icon patcher | Studied | Source-light-to-medium patcher reference for Steam path lookup, current-state detection, custom/default icon sets, and update-overwrite caveats |
| `nicolas-riera/SteamVR-RenderModelSwitcher` | SteamVR render-model patcher | Studied | Resource-patcher reference for copying Quest/Vive render-model assets into SteamVR resources with current-model detection and restore options |

## Code-Level Findings

### `jaki-gh/Viva-Dongle-Flasher`

- Interesting idea:
  a firmware flasher can reduce risk by staging generation and flashing as two
  separate UI actions, with flash buttons disabled until both UF2 and drive
  prerequisites exist.
- Code donor value:
  high for provisioning UX. `main.py` locates SteamVR radio firmware zip,
  converts firmware/SoftDevice bytes to UF2, supports device-type selection,
  generates output files, finds/uses mounted USB drives, asks confirmation
  before flashing, copies UF2 to the device, and logs operator steps.
- Product reference value:
  high for SteamVR hardware setup tools.
- What to inspect next:
  target drive identity validation, checksum/provenance display, rollback
  impossibility copy, and pairing-assistant handoff.
- Caveat:
  flashing is irreversible/physical-device-sensitive; do not copy without
  explicit target confirmation and firmware provenance.

### `TerayTech/SteamVR_BaseStation2.0_Diagnostic_Tool`

- Interesting idea:
  a small serial diagnostic viewer can classify base-station telemetry into
  operator-readable categories and statuses.
- Code donor value:
  medium. `bs_diagnosis.py` has a serial worker thread, read/write queues,
  bounded raw/table line counts, parser rules for registers and key/value
  telemetry, category inference (`LASER`, `MOTOR`, `PLL`, `POWER`, etc.), and
  status judging thresholds for laser power/current and fault counts.
- Product reference value:
  high for future SteamVR hardware doctor surfaces.
- What to inspect next:
  command list, localization cleanup, export/report format, base-station model
  gates, and safety around sending serial commands.
- Caveat:
  source strings are partially mojibake in this checkout; thresholds need
  hardware validation.

### `nicolas-riera/SteamVR-IconsSwitcher`

- Interesting idea:
  device visual identity in SteamVR can be patched by swapping icon assets in
  driver resource folders.
- Code donor value:
  medium-low. The Python scripts find Steam via Windows registry, derive the
  SteamVR path, check current icon state by presence of marker files/assets, and
  copy custom/default icon folders for Vive and Quest devices.
- Product reference value:
  medium as a user-facing customization utility.
- What to inspect next:
  backup/restore, SteamVR version detection, update overwrite handling, and
  non-Windows path support.
- Caveat:
  copying into SteamVR driver resources is fragile and should be wrapped in a
  reversible patcher with backups.

### `nicolas-riera/SteamVR-RenderModelSwitcher`

- Interesting idea:
  render-model replacement is the same patcher problem as icons, but with
  higher compatibility risk because JSON, OBJ, MTL, textures, and input paths
  all travel together.
- Code donor value:
  medium. The repo includes asset folders for Touch/Vive variants and scripts
  that detect SteamVR path/current model state, remove or overwrite target
  render-model directories, and copy replacement asset trees.
- Product reference value:
  medium for device identity/customization and compatibility notes.
- What to inspect next:
  exact restore semantics, JSON action/path compatibility, asset provenance,
  and SteamVR update repair workflow.
- Caveat:
  destructive directory replacement without robust backup/version guards should
  not be reused directly.

## Reusable Pattern Extraction

- Pattern candidate:
  target-aware SteamVR hardware provisioning and resource patcher.
- Problem solved:
  hardware and resource tools often perform risky actions against physical
  devices or SteamVR install folders; reuse requires clear target identity,
  disabled actions, provenance, and rollback status.
- Reusable core:
  device/runtime discovery, explicit target selector, prerequisite checks,
  disabled action buttons, generated artifact path, checksum/provenance, backup
  folder, restore action, serial/log parser, bounded UI logs, category/status
  model, and irreversible-action warning copy.
- Source evidence:
  `jaki-gh/Viva-Dongle-Flasher`,
  `TerayTech/SteamVR_BaseStation2.0_Diagnostic_Tool`,
  `nicolas-riera/SteamVR-IconsSwitcher`, and
  `nicolas-riera/SteamVR-RenderModelSwitcher`.
- Abstraction boundary:
  keep target discovery, artifact generation, flash/patch execution,
  diagnostics, backups, and UI gating separate.
- What not to copy:
  flash-all behavior, ambiguous removable-drive selection, resource replacement
  without backup, unverified firmware/assets, or diagnostics thresholds without
  hardware/version context.
- Method catalog action:
  extend hardware provisioning into target-aware provisioning/resource patching.

## Follow-Up Gaps

- Compare `Viva-Dongle-Flasher` with earlier Watchman dongle guides.
- Build a SteamVR hardware doctor matrix across base stations, dongles,
  trackers, icons, and render models.
- Define a backup/restore contract for any future SteamVR resource patcher.
