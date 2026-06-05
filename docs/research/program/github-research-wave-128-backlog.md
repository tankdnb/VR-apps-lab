# GitHub Research Wave 128 Backlog

- Date: `2026-06-05`
- Scope: Quest app sideloading, modding, version management, launcher, and
  metadata tooling.

## Completed in this wave

- Studied `SideQuestVR/SideQuest` as a managed ADB/platform-tools and install
  workflow shell.
- Studied `SideQuestVR/SideQuestAppLauncher` as a headset-local launcher and
  updater UI reference.
- Studied `Lauriethefish/QuestPatcher` as an APK patching, manifest editing,
  signing, mod-directory, and ADB hygiene donor.
- Studied `Lauriethefish/QuestPatcher.QMod` as a formal Quest mod package
  schema reference.
- Studied `ComputerElite/QuestAppVersionSwitcher` as backup, downgrade,
  on-device ADB, diff/version, and app-state management reference.
- Studied `ComputerElite/OculusDB` as a metadata backend for app/version
  utility workflows.

## Reuse candidates

- `QuestPatcher` is the strongest donor for patch/sign and mod-directory
  workflows.
- `SideQuest` is the strongest donor for managed platform-tools bootstrap and
  install shell anatomy.
- `QuestAppVersionSwitcher` is the strongest donor for durable backup/version
  metadata.
- `QuestPatcher.QMod` is the strongest donor for schema-first mod packages.

## Follow-up backlog

1. Build a Quest companion utility checklist around ADB, package metadata,
   backup, install, and permissions.
2. Compare QMOD with other VR mod manifest/package schemas.
3. Extract a safe "APK patch workflow" support-boundary note before any future
   runnable prototype.
4. Revisit Oculus metadata only if a public, policy-safe metadata viewer is
   needed.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
