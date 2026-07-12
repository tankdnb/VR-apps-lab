# Wave 329 - SteamVR Runtime Settings, Recovery, and WMR Patch Microtools

This wave studies small SteamVR operational utilities that toggle runtime
availability, patch settings, recover crashed sessions, or edit WMR driver
configuration.

No external project was run, installed, or launched.

## Scope

The wave was bounded to:

- SteamVR runtime enable/disable and process cleanup;
- OpenVR settings CLI mutation;
- crash recovery and last-world relaunch workflows;
- WMR driver settings toggles.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `demonixis/SteamVREnabler` | SteamVR runtime folder toggle and kill switch | Studied | Small WinForms reference for reading `openvrpaths.vrpath`, renaming `SteamVR` to `_SteamVR`, and killing SteamVR process families |
| `ZipFile/ovr-update-settings` | OpenVR settings CLI microtool | Studied | Clean low-level donor for `IVRSettings` get/set/delete/add/neg operations with type inference and `VRApplication_Utility` init |
| `Raphiiko/Raphiis-SteamVR-Crash-Recovery` | VRChat and SteamVR crash recovery script | Studied | Rust microtool reference for process detection, latest VRChat log parsing, SteamVR relaunch, and `vrchat://launch?id=...` world restore |
| `Burnt-Delta/ez-wmr` | WMR SteamVR driver config patcher | Studied | C++/Win32 reference for targeted `default.vrsettings` thumbstick toggles, config persistence, and direct file-patch caveats |

## Code-Level Findings

### `demonixis/SteamVREnabler`

- Interesting idea:
  runtime disabling can be implemented as a blunt but understandable folder
  rename plus a visible process kill button.
- Code donor value:
  medium as a cautionary microtool. `Form1.cs` reads
  `%LocalAppData%\openvr\openvrpaths.vrpath`, derives the SteamVR install
  directory, checks `SteamVR` versus `_SteamVR`, kills known SteamVR processes,
  and renames the runtime folder.
- Product reference value:
  medium for operator-facing runtime toggles and emergency stop UX.
- What to inspect next:
  safer runtime disable mechanisms, restore verification, admin/elevation
  behavior, and multi-library Steam installs.
- Caveat:
  folder renaming is fragile and should not be copied without backup,
  permission checks, and explicit restore flow.

### `ZipFile/ovr-update-settings`

- Interesting idea:
  SteamVR settings can be patched through `IVRSettings` instead of editing JSON
  files directly.
- Code donor value:
  high for a small CLI. `main.cpp` initializes OpenVR as
  `VRApplication_Utility`, grabs `VRSettings`, dispatches operations through
  an `OPMap`, and shuts down cleanly. `ops.cpp` supports `get`, `set`, `del`,
  `add`, and `neg`, with simple value type inference for bool/int/float/string.
- Product reference value:
  high for config patch microtools and automated diagnostics.
- What to inspect next:
  command output schema, dry-run/list support, settings error propagation, and
  batch transaction/rollback model.
- Caveat:
  current numeric `add` implementation initializes local variables to zero
  instead of using the fetched value; treat as a pattern reference, not
  drop-in code.

### `Raphiiko/Raphiis-SteamVR-Crash-Recovery`

- Interesting idea:
  a recovery helper can restore the last VRChat world by parsing the newest
  client log before killing/relaunching SteamVR and VRChat.
- Code donor value:
  medium. `main.rs` uses `sysinfo` process discovery, extracts the latest
  `output_log_*.txt`, searches reversed lines for join records, kills
  `VRChat.exe` and `vrmonitor.exe`, starts SteamVR from a fixed path, then
  launches `vrchat://launch?id=<world>`.
- Product reference value:
  high for crash-recovery UX and session continuity.
- What to inspect next:
  friend/private instance privacy, configurable paths, dry-run, timeouts,
  SteamVR URI alternatives, and process shutdown grace.
- Caveat:
  hardcoded SteamVR path, forced kills, and log parsing should be wrapped in a
  safer operator preview before reuse.

### `Burnt-Delta/ez-wmr`

- Interesting idea:
  some useful VR QoL tools are just small UI wrappers around fragile driver
  config toggles.
- Code donor value:
  medium-low. `ToggleFunctions.cpp` searches `default.vrsettings` lines for
  thumbstick movement/turn keys, records byte offsets, writes `true`/`false`
  in place, and stores file path plus checkbox defaults in `config.txt`.
- Product reference value:
  medium for WMR-specific comfort/config UX.
- What to inspect next:
  safer JSON parsing, backup/restore, SteamVR closed-state detection, and
  per-driver version checks.
- Caveat:
  direct seek-based file patching is fragile; future tools should parse and
  rewrite structured config with backups.

## Reusable Pattern Extraction

- Pattern candidate:
  reversible SteamVR operation microtool.
- Problem solved:
  users often need a tiny tool to toggle runtime availability, update a setting,
  repair a session, or patch a driver option without opening a full dashboard.
- Reusable core:
  runtime/path discovery, process inventory, typed settings API, config
  mutation layer, dry-run, backup, restore, graceful shutdown policy, forced
  kill fallback, visible status, and exact caveat/warning copy.
- Source evidence:
  `demonixis/SteamVREnabler`, `ZipFile/ovr-update-settings`,
  `Raphiiko/Raphiis-SteamVR-Crash-Recovery`, and `Burnt-Delta/ez-wmr`.
- Abstraction boundary:
  keep discovery, mutation, process control, recovery action, config
  persistence, and operator UI/CLI feedback separate.
- What not to copy:
  hardcoded paths, raw config seek writes, silent process kills, folder renames
  without restore checks, or log-derived relaunch without user-visible target.
- Method catalog action:
  add a SteamVR operation microtool method.

## Follow-Up Gaps

- Compare `IVRSettings` mutation with JSON config editing and dashboard
  settings surfaces.
- Build a dry-run/rollback checklist for SteamVR config patchers.
- Revisit WMR-specific settings tools if newer OpenXR/WMR projects appear.
