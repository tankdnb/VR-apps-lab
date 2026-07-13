# Wave 458: Quest ADB device-operator sidecars

- Date: `2026-07-13`
- Scope: Meta Quest wireless ADB helpers, on-device service/watchdog patterns,
  mDNS discovery, accessibility popup automation, and desktop batch operator
  toolboxes.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `thedroidgeek/oculus-wireless-adb` | Studied | On-device wireless ADB activator |
| `project-SIMPLE/adb-auto-enable` | Studied | ADB watchdog and accessibility automation |
| `DevOculus-Meta-Quest/QuestADBServices` | Lightly studied | Thin Quest ADB service variant |
| `mitchv2020/QuestToolbox` | Studied | Desktop batch Quest operator toolbox |

## Why this wave matters

VR utility work often needs an operator layer around the headset: enabling ADB,
discovering the device, mirroring, installing, reading packages, or keeping
developer transport alive. This wave extracts the safe reusable ideas without
promoting these tools as dependencies.

## Project notes

### `thedroidgeek/oculus-wireless-adb`

- Interesting idea:
  Quest-side Android app that toggles `adb_wifi_enabled`, discovers the local
  ADB service through mDNS/JmDNS, optionally switches to tcpip mode, and exposes
  a host/port status UI with copy-to-clipboard behavior.
- Code donor value:
  strong donor for on-device operator helpers: permission gating,
  `WRITE_SECURE_SETTINGS`, `Settings.Global`, JmDNS service discovery,
  multicast lock, and embedded `libadb.so` invocation are clear.
- Product reference value:
  suggests an operator workflow where the headset can bootstrap its own debug
  connection before a desktop companion attaches.
- Source evidence:
  `app/src/main/java/tdg/oculuswirelessadb/MainActivity.kt`,
  `app/src/main/java/tdg/oculuswirelessadb/JmDNSAdbDiscovery.kt`,
  `app/src/main/AndroidManifest.xml`, `script/discover-and-connect.py`, and
  `app/src/main/jniLibs/arm64-v8a/libadb.so`.
- Reusable core:
  secure-settings permission check, ADB wifi toggle, tcpip-mode option, mDNS
  service discovery for `_adb-tls-connect._tcp.local.` and
  `_adb_secure_connect._tcp.local.`, multicast lock, status text, command copy,
  and Termux handoff.
- What not to copy:
  bundled binaries, privileged-setting mutation without user-visible gates, or
  hard-coded local port assumptions.
- What to inspect next:
  ADB command wrapper, failure states, UI permission copy, and how tcpip mode
  behaves on different Quest OS versions.

### `project-SIMPLE/adb-auto-enable`

- Interesting idea:
  foreground Android service that watches network/settings changes and
  periodically enforces `adb_wifi_enabled`, plus an AccessibilityService that
  detects Quest `VrUsb` trust windows and sends a blind TAB/TAB/TAB/ENTER
  sequence.
- Code donor value:
  valuable as an automation-boundary warning: watchdog, content observer,
  network callback, foreground notification, accessibility enablement, and
  popup interaction are explicit.
- Product reference value:
  useful for thinking about robust developer-mode utilities, but also a strong
  reminder that unsafe automation must be gated, logged, and reversible.
- Source evidence:
  `app/src/main/java/eu/project_simple/adbautoenable/AdbConfigService.java`,
  `AdbPopupAccessibilityService.java`, `BootReceiver.java`,
  `MainActivity.java`, and `app/src/main/res/xml/adb_popup_accessibility_config.xml`.
- Reusable core:
  foreground watchdog service, settings observer, Wi-Fi network callback,
  debounce, periodic fallback, boot receiver, accessibility window scan, popup
  title detection, and operator-visible notification.
- What not to copy:
  blind trust-popup key sequence, silent accessibility enabling, or persistent
  privileged setting writes without explicit safety controls.
- What to inspect next:
  boot lifecycle, user opt-out, notification affordance, and safer UI-driven
  approval alternatives.

### `mitchv2020/QuestToolbox`

- Interesting idea:
  Windows batch toolbox that bundles ADB, scrcpy, ffmpeg/curl, helper batch
  scripts, package listing, keepalive, wired ALVR, and update checks behind a
  menu-style operator workflow.
- Code donor value:
  useful as product reference for operator menus and dependency bundling rather
  than as code to copy.
- Product reference value:
  shows what users expect from a Quest utility sidecar: mirror, package tools,
  ADB commands, keepalive, connection helpers, and one-menu access.
- Source evidence:
  `QuestToolbox.bat`, `Requirements/packages.bat`,
  `Requirements/keepalive*.bat`, `Requirements/checkforupdates.bat`, bundled
  `adb.exe`, `scrcpy.exe`, and `ffmpeg.exe`.
- Reusable core:
  operation catalog, dependency folder, package listing command, keepalive
  loops, mirror helpers, update check, and menu-driven command dispatch.
- What not to copy:
  bundled third-party executables, opaque batch side effects, or commands
  without dry-run/safety labels.
- What to inspect next:
  exact command catalog, rollback/backup behavior, and how dependencies are
  licensed and updated.

### `DevOculus-Meta-Quest/QuestADBServices`

- Interesting idea:
  small Kotlin/Gradle Quest ADB service variant with app shell and manifest
  structure that overlaps the on-device ADB-helper family.
- Code donor value:
  currently light; useful mainly as a variant marker for how thin these tools
  can be.
- Product reference value:
  reinforces that there is demand for on-device ADB enabling as a standalone
  micro-utility.
- Source evidence:
  `README.md`, `app/src/main/AndroidManifest.xml`,
  `app/src/main/java/com/purefusion/questadbservices/*`, and Gradle files.
- Reusable core:
  Android app shell, package/manifest shape, and service naming.
- What not to copy:
  incomplete or thin app structure before deeper review.
- What to inspect next:
  main activity/service behavior and whether it adds a distinct safety or UX
  pattern.

## Reusable pattern extraction

- Pattern candidate:
  `Quest operator sidecar with explicit safety gates`.
- Problem solved:
  give developers a controlled way to enable, discover, connect to, and inspect
  Quest devices without burying privileged actions in ad-hoc scripts.
- Reusable core:
  permission checklist, device discovery, ADB transport state, command catalog,
  dry-run/preview, foreground status, user-visible notification, dependency
  provenance, safety labels, rollback/disable action, and cache/log hygiene.
- Abstraction boundary:
  headset app owns local settings and discovery; desktop sidecar owns host
  commands and package/mirror tools; shared schema owns device identity,
  operation ids, state, and safety metadata.
- Method catalog action:
  create a new method for Quest operator sidecars.

## Caveats

- Several approaches require privileged settings or bundled binaries; they
  should be documented as sensitive operator tooling, not ordinary app UX.
- Accessibility automation is a warning pattern: record the risk and design a
  safer approval path before reuse.
- Do not turn these repos into dependencies without reviewing licenses,
  binaries, and current Quest OS behavior.

