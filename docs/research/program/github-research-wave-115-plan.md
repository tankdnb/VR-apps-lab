# GitHub Research Wave 115 Plan

- Date: `2026-06-05`
- Goal: run a focused GitHub research wave for Linux spatial desktops,
  Stardust workspace clients, virtual monitors, launchers, workspace grouping,
  and desktop-to-XR helper bridges.

## Why this wave exists

Several earlier waves studied overlays, desktop windows in VR, WayVR, and
Linux capture utilities. This wave returns to Linux spatial desktop work from
a different angle: full workspace shells, Stardust client micro-utilities,
virtual monitor surfaces, panel input injection, app launchers, workspace
cells, and compositor/DBus companion bridges.

This wave studies Linux spatial desktop projects as references for future
desktop-in-VR utilities, panel/window overlays, workspace grouping, and
surface-input models.

## Search scope

Primary search directions for this wave:

- Linux VR desktop and spatial workspace shells;
- Stardust XR panel, virtual monitor, launcher, and workspace clients;
- desktop window mirroring through compositor metadata;
- panel input injection and physical resize/close affordances;
- workspace grouping and external compositor launch patterns.

## Frozen shortlist for code-level study

- `SimulaVR/Simula`
- `StardustXR/flatland`
- `StardustXR/kiara`
- `StardustXR/protostar`
- `StardustXR/magnetar`
- `yshui/picom-xrdesktop-companion`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for Linux VR desktop, Stardust client, flatland, spatial
  launcher, workspace, xrdesktop, and picom companion families;
- compare surfaced repositories against registry and family docs;
- avoid duplicating earlier Stardust server and WayVR coverage by focusing on
  client/workspace/surface projects.

### Step 2: Freeze the shortlist

- include one full Linux VR desktop, four Stardust client/workspace projects,
  and one compositor/DBus desktop-to-XR companion.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- display/panel/window surface representation;
- input injection, pointer, touch, resize, and close affordances;
- compositor, Wayland, X11, DBus, and launcher boundaries;
- workspace/group/cell semantics;
- OpenXR/OpenVR/xrdesktop/Stardust integration layer;
- caveats around maturity, platform, and direct reuse.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 115 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- Stardust client coverage is not confused with the already studied server;
- full shells, panel bridges, launchers, workspace grouping, and compositor
  helpers are separated clearly;
- Linux/X11/Wayland/SteamVR constraints remain visible;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 115 synthesis document exists with code-level findings;
4. registry and families represent Linux spatial desktop donors clearly;
5. new methods capture desktop shells, panel bridges, launchers, workspace
   cells, and compositor companions;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
