# VR Projects Wave 128: Quest App Sideloading, Modding, Version Management, and Store Metadata Tooling

- Date: `2026-06-05`
- Goal: study Quest-side app management tooling as reusable utility
  architecture: ADB bootstrap, sideloading, package metadata, mod schemas,
  patch/sign flows, backup/version switching, and store metadata indexing.

## Why this wave exists

Quest utilities are often not VR overlays. They are companion and device
management tools that make headset workflows practical:

- managed ADB/platform-tools bootstrap;
- app package discovery, sideloading, and launch helpers;
- mod package schemas and install paths;
- APK manifest/library patching and signing;
- backup, downgrade, and app-version metadata flows;
- store metadata scraping/indexing that supports user-facing version tools.

This wave studies those workflows without running or installing any found
project.

## Better workflow used in this wave

1. searched by Quest sideloading, patching, launcher, downgrade, and Oculus
   metadata families;
2. deduplicated against earlier overlay, Android, and Quest MR waves;
3. froze a bounded Quest app-management shortlist;
4. synced sources into `.research-sources/github/`;
5. inspected source structure, entry points, schema files, and device I/O code;
6. extracted reusable methods for future headset companion utilities.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `SideQuestVR/SideQuest` | Mature desktop/mobile Quest sideloading and install workflow |
| `SideQuestVR/SideQuestAppLauncher` | On-device launcher surface and wrapper apps |
| `Lauriethefish/QuestPatcher` | APK patching, mod install, ADB, signing, and manifest modification |
| `Lauriethefish/QuestPatcher.QMod` | Formal QMOD package format and schema reference |
| `ComputerElite/QuestAppVersionSwitcher` | Backup, downgrade, on-device ADB, and mod/version management |
| `ComputerElite/OculusDB` | Oculus app metadata scraping and database reference |

## Deep-pass notes by project

## `SideQuestVR/SideQuest`

- GitHub:
  [SideQuestVR/SideQuest](https://github.com/SideQuestVR/SideQuest)
- What it is:
  a desktop/mobile companion for Quest sideloading, app discovery, device
  operations, and install flows.
- Interesting idea:
  a VR utility companion can own the whole device-management shell: platform
  tools bootstrap, install queue, package checks, progress reporting, and
  remote metadata lookup.
- Code-level notes:
  `electron/platform-tools.ts` selects the correct Google platform-tools
  archive by OS, downloads it, extracts it, and moves only the needed ADB
  files into the app bundle. `electron/app.ts` wraps `adbkit`, tracks ADB path,
  computes file hashes with progress, checks APK hashes against a blacklist
  API, and turns install tokens into APK/OBB/mod tasks.
- Code donor value:
  high for managed ADB bootstrap, install progress, and device-companion
  boundary design.
- Product reference value:
  very high for a Quest utility shell that is useful outside the headset.
- Caveats:
  large product surface, API/service coupling, and some platform-specific
  packaging assumptions.
- What to inspect next:
  compare its install queue and device status UX with QuestPatcher and QAVS.

## `SideQuestVR/SideQuestAppLauncher`

- GitHub:
  [SideQuestVR/SideQuestAppLauncher](https://github.com/SideQuestVR/SideQuestAppLauncher)
- What it is:
  Android launcher and wrapper applications for SideQuest-style on-device app
  access.
- Interesting idea:
  an on-device launcher can provide app drawer, app details, updater dialogs,
  settings overlays, sorting, wallpaper, and wrapper activities as a small
  headset-local companion.
- Code-level notes:
  the repo is split into launcher and wrapper Gradle apps. The launcher keeps
  Java GUI classes for main activity, app grid/list adapters, app settings
  overlays, info dialogs, updater activities, file dialogs, and settings
  provider logic. Wrapper apps are thin Android entry points.
- Code donor value:
  medium for headset-local app drawer and updater UI anatomy.
- Product reference value:
  high for Quest companion UX that does not require a native VR overlay.
- Caveats:
  older Android/Java style and narrow SideQuest product framing.
- What to inspect next:
  extract a generic "headset local launcher surface" checklist.

## `Lauriethefish/QuestPatcher`

- GitHub:
  [Lauriethefish/QuestPatcher](https://github.com/Lauriethefish/QuestPatcher)
- What it is:
  a desktop patcher for Quest APK modding, especially around Beat Saber style
  mod workflows.
- Interesting idea:
  a safe patcher should treat ADB ownership, app selection, manifest changes,
  external files, mod directories, mod config, and APK signing as explicit
  stages rather than a one-shot script.
- Code-level notes:
  `AndroidDebugBridge.cs` prefers an already-running compatible ADB server,
  falls back to PATH or downloaded platform-tools, validates minimum ADB
  version, and excludes system/vendor package prefixes from patchable app
  lists. `PatchingManager.cs` edits Android binary XML manifests, adds storage,
  microphone, hand tracking, OpenXR, passthrough, body tracking, debug, legacy
  storage, and MRC workaround entries, can replace Unity libraries, add
  flatscreen support, and rebuild the APK. `ModManager.cs` creates QuestLoader
  and Scotland2 mod/lib directories, grants storage appops where possible,
  repairs chmod failures, stores `modsStatus.json`, and routes package formats
  through mod providers.
- Code donor value:
  very high for ADB hygiene, manifest patching, mod-directory setup, staged
  patching, and device config persistence.
- Product reference value:
  high for a user-facing "patcher as workflow" utility.
- Caveats:
  app-specific assumptions, patching risk, and dependency on external modloader
  conventions.
- What to inspect next:
  isolate an APK patch/sign/rollback checklist independent of Beat Saber.

## `Lauriethefish/QuestPatcher.QMod`

- GitHub:
  [Lauriethefish/QuestPatcher.QMod](https://github.com/Lauriethefish/QuestPatcher.QMod)
- What it is:
  a C# QMOD reader/model plus the QMOD package specification and JSON schema.
- Interesting idea:
  mod packages should be formal artifacts: ZIP rules, one manifest entry,
  schema validation, cover images, mod/library file lists, and file-copy
  instructions.
- Code-level notes:
  `SPECIFICATION.md` defines QMOD as a ZIP with exactly one `mod.json`, UTF-8
  JSON, no ZIP64, and schema compliance. The library models manifest metadata
  and package contents for QuestPatcher providers.
- Code donor value:
  high for package schema and validator-first mod intake.
- Product reference value:
  high for any future `VR-apps-lab` plugin/mod/package format.
- Caveats:
  specific to Quest modding and existing modloader install paths.
- What to inspect next:
  compare QMOD with Resonite manifest schemas from Wave 130.

## `ComputerElite/QuestAppVersionSwitcher`

- GitHub:
  [ComputerElite/QuestAppVersionSwitcher](https://github.com/ComputerElite/QuestAppVersionSwitcher)
- What it is:
  a Quest app backup, downgrade, version switching, and mod-support utility.
- Interesting idea:
  version management is a utility stack: local backup metadata, APK/OBB/data
  detection, patch-state inspection, on-device ADB, web/server UI, Oculus
  GraphQL metadata, diff downgrade, and mod handling.
- Code-level notes:
  `BackupManager.cs` records backup identity, size, app data, OBBs, APK
  presence, game version, corruption state, patch status, and serialized
  metadata. `QAVSAdbInteractor.cs` can start ADB, discover devices, enable
  wireless debugging, connect back to loopback, switch TCP/IP mode, restore
  prior wireless-debugging state, and grant permissions. The repo also contains
  backup managers, download managers, diff downgrading, modding helpers,
  Oculus GraphQL API code, and web assets.
- Code donor value:
  high for version/backup metadata and on-device ADB patterns.
- Product reference value:
  very high for a Quest "stateful app manager" direction.
- Caveats:
  operationally sensitive; future reuse should design explicit consent,
  backup/restore safety, and support boundaries.
- What to inspect next:
  compare diff downgrade and metadata indexing with OculusDB.

## `ComputerElite/OculusDB`

- GitHub:
  [ComputerElite/OculusDB](https://github.com/ComputerElite/OculusDB)
- What it is:
  an Oculus app metadata database and scraping/indexing service.
- Interesting idea:
  app-version utilities need a metadata backend: store enumeration, pagination,
  locale normalization, database models, frontend serving, and scrape
  orchestration.
- Code-level notes:
  `OculusInteractor.cs` initializes a GraphQL client, forces locale, suppresses
  hard exceptions, and enumerates all apps through page cursors. The broader
  repo includes database models, frontend server, scraping master/node code,
  and QAVS-specific metadata helpers.
- Code donor value:
  medium-high for metadata indexer/service separation.
- Product reference value:
  high as the backend side of app-version utility UX.
- Caveats:
  service/API fragility and platform policy risk.
- What to inspect next:
  document support-boundary language for metadata-backed Quest tools.

## Cross-project synthesis

Reusable lessons:

- keep platform-tools bootstrap explicit and user-visible;
- avoid killing or stealing another app's ADB server unless necessary;
- model APK patching as staged operations with validation and rollback
  expectations;
- define mod packages as schema-validated artifacts, not loose ZIP folders;
- separate app metadata indexing from the user-facing version manager;
- make backup/version state durable and inspectable.

Best donor candidates:

- `QuestPatcher` for patch/sign/manifest/mod-directory workflow;
- `SideQuest` for managed ADB/platform-tools bootstrap and install shell;
- `QuestAppVersionSwitcher` for stateful backup/version metadata;
- `QuestPatcher.QMod` for a formal mod-package schema.

## Reuse implications for `VR-apps-lab`

This wave suggests a future `headset companion utility` branch:

- ADB doctor and device inventory shell;
- package/version metadata viewer;
- local backup/restore checklist;
- mod/plugin package validator;
- Quest app launcher/updater pattern reference.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were used only for code reading and are local-only.
