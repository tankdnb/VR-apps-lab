# Wave 275 - VR Launchers, Startup Orchestration, and App-Library Surfaces

This wave studies VR launchers and startup orchestration surfaces across Quest
hidden `systemux://` launchers, SteamVR shortcuts, CLI profile runners,
background OpenVR agents, game-specific VR carousels, and VRChat launcher
workbenches.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- VR runtime and app launch shortcuts;
- hidden Quest system surfaces and versioned URI catalogs;
- config/profile orchestration;
- external process launch, focus, and return-to-menu lifecycle;
- game-specific launcher workflows and safety caveats.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `ptrpaws/vrLauncher` | Quest hidden system launcher | Studied as variant | Versioned `systemux://` catalog and `vrshell` intent launch |
| `conexto/vrLauncher` | Quest hidden system launcher variant | Variant/fork-line | Same pattern as `ptrpaws`, useful for dedupe handling |
| `blakeblair/uvrl` | Universal VR launch/profile orchestrator | Studied | SQLite app/config registry, profile steps, backups, discovery catalog |
| `marianhlavac/immersion-vr-agent` | OpenVR background launcher agent | Studied with caveats | Polls scene app changes and relaunches Immersion launcher |
| `dewaffled/vr-launcher` | WMR device toggle micro-utility | Studied with safety caveats | Self-elevating PowerShell enable/disable for Holographic PnP devices |
| `Paladinleeds/PaladinVR-Launcher` | WMR Cliff House SteamVR shortcut | Studied with caveats | UWP tile that launches SteamVR URI and exits |
| `keithbphillips/vr-pinball-launcher` | VR game-library carousel | Studied with caveats | VR menu, table scanner, external process monitor, XR stop/restart |
| `CactusVRStudios/Lambda1VR_Launcher` | Quest game commandline launcher | Studied with artifact caveat | Writes commandline file and launches package via Android `PackageManager` |
| `Bluscream/VRChatLauncher` | Deprecated VRChat launcher/workbench | Studied with caveats | URI handler, IPC singleton, argument parser, mod/setup checks |

## Code-Level Findings

### `ptrpaws/vrLauncher` and `conexto/vrLauncher`

- Interesting idea:
  expose hidden Oculus/Quest system panels and dialogs through a searchable
  versioned launcher.
- Code donor value:
  useful Android pattern: Kotlin `Activity`, SearchableSpinner, Quest version
  selector, arrays of option names and `systemux://` URIs, update check through
  GitHub releases API, and `Intent.ACTION_VIEW` targeted at
  `com.oculus.vrshell/.MainActivity`.
- Product reference value:
  strong Quest utility reference for "catalog hidden system surfaces, show the
  selected URI, and launch explicitly."
- What to inspect next:
  maintained upstream lineage, current Quest OS URI drift, permission/failure
  handling, and safer URI metadata.
- Caveats:
  the inspected repos are the same variant/fork-line, version arrays are large
  hardcoded tables, some URIs may be obsolete, and UI is intentionally simple.

### `blakeblair/uvrl`

- Interesting idea:
  a Universal VR Launcher that treats startup as ordered profile steps over app
  registry entries, config variants, backups, waits, delays, URLs, and launch
  arguments.
- Code donor value:
  strong architecture donor: SQLite schema for apps/configs/variants/backups/
  profiles/steps, discovery catalog for SteamVR, overlays, trackers, haptics,
  and tools, scanner with match types, config apply with SHA-256 backups and
  exported files, profile validation with errors/warnings, dry-run mode,
  Steam URL launch, Flatpak/native/script launch paths, `.desktop` argument
  handling, terminal/detached log modes, wait-for-process, delay, and
  failure-behavior handling.
- Product reference value:
  excellent reference for a future VR stack launcher or "profile runner" that
  starts runtime, overlays, trackers, OSC tools, config variants, and web
  helpers in a controlled order.
- What to inspect next:
  UI layer, profile export/import, secrets handling, rollback-on-exit behavior,
  Windows admin boundaries, and package/install model.
- Caveats:
  CLI-first, still evolving, launches real processes by design, and config
  writes require strong UX guardrails before reuse.

### `marianhlavac/immersion-vr-agent`

- Interesting idea:
  an OpenVR background app watches scene-application events and launches an
  Immersion VR launcher/tutorial when no other VR app is active.
- Code donor value:
  useful agent-loop reference: OpenVR init as `VRApplication_Background`,
  event polling, scene-application-changed and quit handling, status enum,
  WPF background worker, user-configurable launcher executable path, and
  `ProcessStartInfo` arguments (`-launcher`) for relaunch behavior.
- Product reference value:
  good product framing for small background agents that keep a VR home or
  utility launcher available.
- What to inspect next:
  modern OpenVR event constants, process identity handling, tray mode,
  lifecycle shutdown, and replacement with OpenXR/runtime-neutral hooks.
- Caveats:
  old WPF/OpenVR project, sparse README, swallowed launch exceptions, and
  status handling is minimal.

### `dewaffled/vr-launcher`

- Interesting idea:
  a one-script helper to enable or disable Windows Mixed Reality headset
  devices.
- Code donor value:
  narrow but useful cautionary microtool: self-elevation, build-number check,
  `Get-PnpDevice -Class Holographic`, `Enable-PnpDevice`, and
  `Disable-PnpDevice`.
- Product reference value:
  strong "one painful action, one utility" reference for runtime/device
  toggles.
- What to inspect next:
  dry-run mode, explicit device list, confirmations, rollback, and non-admin
  UX.
- Caveats:
  destructive/system-level side effect, admin elevation, interactive prompt,
  and Windows/WMR-only scope.

### `Paladinleeds/PaladinVR-Launcher`

- Interesting idea:
  place a simple SteamVR launcher tile inside Windows Mixed Reality Cliff
  House.
- Code donor value:
  tiny UWP reference: `Windows.System.Launcher.LaunchUriAsync` with
  `steam://rungameid/250820`, failure dialog, and auto-exit after launch.
- Product reference value:
  good reference for an app-library shortcut where platform shell access is the
  main product value.
- What to inspect next:
  current WMR shell behavior, URI failure reporting, and migration relevance.
- Caveats:
  project is archived by its own README because Microsoft added equivalent
  functionality.

### `keithbphillips/vr-pinball-launcher`

- Interesting idea:
  an immersive VR menu browses Visual Pinball tables and launches each table
  as an external process, then restores the launcher menu when the table exits.
- Code donor value:
  strong lifecycle donor: JSON config with autodetected common paths, table
  scanner for `.vpx`, optional subdirectories, wheel-image matching, world
  menu positioning in front of the camera, item creation, external
  `ProcessStartInfo` with `-Play`, process exit event, main-thread dispatcher,
  VPinball window focus/topmost attempts, XR subsystem stop before launch, XR
  loader restart after exit, and menu hide/show.
- Product reference value:
  excellent for VR app-library surfaces and external-app handoff loops.
- What to inspect next:
  controller-to-keyboard simulation layer, focus robustness, multiple runtime
  compatibility, and non-Windows alternatives.
- Caveats:
  game-specific, Windows/Visual Pinball-specific, process kill path, checked-in
  Unity assets, and launching/focusing external processes needs explicit user
  control.

### `CactusVRStudios/Lambda1VR_Launcher`

- Interesting idea:
  a Quest-native Unity launcher for Lambda1VR that detects installed game/mod
  folders, builds commandline text, writes it to `/sdcard/xash`, and starts
  the target package.
- Code donor value:
  useful standalone Quest launch pattern: fixed game folder checks, dynamic
  unsupported mod buttons, sliders for supersampling/MSAA/CPU/GPU, saved custom
  command lines, `AndroidJavaClass`/`PackageManager.getLaunchIntentForPackage`,
  `startActivity`, SideQuest fallback URL, and `OVRRaycaster` replacement for
  dropdown UI.
- Product reference value:
  good reference for game/mod launchers that configure a file-based commandline
  contract before starting another Quest app.
- What to inspect next:
  storage permission model, command validation, mod list scaling, package
  existence/failure UX, and artifact cleanup.
- Caveats:
  huge Unity/Oculus/vendor/Library payload, hardcoded `/sdcard/xash`, fixed
  package id, fragile button indexing, and command strings need validation.

### `Bluscream/VRChatLauncher`

- Interesting idea:
  a deprecated but rich VRChat launcher that wraps URI handling, IPC singleton
  behavior, game launch arguments, setup checks, mods, news, logs, and API-ish
  surfaces.
- Code donor value:
  useful historical architecture reference: app argument parser with launcher,
  game, and VRCTools prefixes; `vrchat://` command parsing; world/instance ID
  modeling; registry URI handler install/check; IPC server for "is launcher
  running"; duplicate-instance handoff; clipboard command tunnel; process
  already-running check; mod-loader DLL detection; INI config helpers; and UI
  tabs for users/worlds/mods/logs.
- Product reference value:
  useful cautionary reference for all-in-one social VR launchers and companion
  workbenches.
- What to inspect next:
  deprecated dependencies, security model, credential/API handling, and which
  ideas were superseded by VRCX.
- Caveats:
  deprecated by README, old VRChat/modding assumptions, registry mutation,
  clipboard side effects, process kill on exit, and likely not reusable as-is.

## Cross-Project Synthesis

The reusable launcher/orchestration boundary is:

1. identify a target app/runtime/system surface;
2. model launch metadata separately from UI;
3. validate paths, packages, URIs, or configs before action;
4. apply config changes only with backup/restore or explicit file contracts;
5. launch through the correct platform channel;
6. monitor process/runtime state when the launcher must return;
7. expose dry-run, failure, rollback, and compatibility states.

`uvrl` is the strongest architecture donor. `vr-pinball-launcher` is the
strongest VR UI and external-process handoff donor. Quest `vrLauncher` and
`Lambda1VR_Launcher` are useful for standalone headset launch surfaces.
`PaladinVR` and `dewaffled/vr-launcher` show the value of tiny shell/runtime
shortcuts. `VRChatLauncher` is a rich but deprecated cautionary reference.

## Method/Catalog Actions

- Add a method for VR launcher/startup orchestration across hidden intents,
  SteamVR URLs, app registries, profile steps, config backups, agents,
  game-specific carousels, and guardrails.
- Add a follow-up matrix for launcher metadata, launch channels, process
  lifecycle, config rollback, and safety UX.
- Mark fork/variant launcher lines explicitly to avoid duplicate promotion.

## Follow-Up Backlog

- Compare app-launch channels: Android `PackageManager`, `systemux://`, Steam
  URI, native process, Flatpak, UWP URI launch, and web URL.
- Design a reusable launch profile schema for runtime, overlays, trackers,
  OSC tools, config variants, delays, waits, and rollback.
- Create safety rules for launcher utilities that mutate registry, device
  state, config files, commandline files, or external processes.
