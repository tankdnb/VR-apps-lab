# GitHub Research Wave 128 Plan

- Date: `2026-06-05`
- Goal: study Quest app-management, sideloading, patching, version switching,
  launcher, and store-metadata tooling.

## Why this wave exists

Quest utility work often lives in companion apps rather than overlays. The
useful patterns are ADB lifecycle, package/version metadata, patch/sign flows,
backup safety, mod package schemas, and headset-local launcher UX.

## Search scope

Primary search directions:

- Quest sideloading and companion app shells;
- Android/Quest app launchers and wrappers;
- Quest mod package schemas;
- APK patching/signing workflows;
- app backup, downgrade, and version switching;
- Oculus/Meta app metadata indexing.

## Frozen shortlist for code-level study

- `SideQuestVR/SideQuest`
- `SideQuestVR/SideQuestAppLauncher`
- `Lauriethefish/QuestPatcher`
- `Lauriethefish/QuestPatcher.QMod`
- `ComputerElite/QuestAppVersionSwitcher`
- `ComputerElite/OculusDB`

## Execution model

### Step 1: Search and deduplicate

- search by Quest sideloading, patching, launcher, downgrade, and metadata
  families;
- deduplicate against earlier Quest, Android, overlay, and media waves.

### Step 2: Freeze the shortlist

- include one mature sideloading shell, one on-device launcher, one APK
  patcher, one mod package schema, one version switcher, and one metadata
  backend.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- ADB startup, selection, permissions, and failure handling;
- install and package metadata flow;
- APK patching, manifest editing, and signing;
- mod package schema and install directories;
- backup/version metadata;
- launcher/updater UI surfaces.

### Step 5: Promote findings into repository structure

Update Wave 128 landscape, registry, families, methods, backlog, current
focus, and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after integration.

## Definition of done

This wave is complete when Quest companion utility patterns are documented and
placed in the canonical research system.
