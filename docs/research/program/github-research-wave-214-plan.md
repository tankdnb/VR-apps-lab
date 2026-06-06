# GitHub Research Wave 214 Plan

Date: 2026-06-06

Theme: VRChat/Udon menu and package surfaces for world admins, creators, and
utility prefabs.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

VRChat/Udon repositories often contain very practical menu and prefab patterns:
activation gestures, local panels, tabs, player selectors, permissions, synced
messages, teleport/admin actions, diagnostics consoles, and package ecosystem
boundaries.

Wave 214 studies menu and package surfaces to extract reusable world-utility
patterns that can inform VR tool menus outside VRChat as well.

## Search Families

- Udon menu systems and local in-world panels.
- VRChat world admin and GM tools.
- VPM/package-based creator utility ecosystems.
- Udon diagnostics, event dispatch, player lists, and runtime helpers.
- Permission, role, player-selection, teleport, and option-surface patterns.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `Varneon/UdonEssentials` | Deprecated but source-rich Udon prefab collection with event dispatcher, console, playerlist, groups, music/settings utilities. | Udon utility prefab collection |
| `Varneon/VUdon` | Package ecosystem index showing migration from monolithic prefabs to modular VPM packages. | Udon package ecosystem |
| `SylanTroh/GMMenu` | VPM roleplay/admin menu with VR/desktop activation, permissions, ping HUD, teleport/summon/undo, and watch camera modules. | VRChat world admin menu |
| `kurotori4423/KurotoriUdonMenu` | Local extensible Udon menu with trigger/M-key activation, progress animation, tabs, teleport list, and voice-range options. | Local Udon menu surface |

## Dedupe Notes

VRChat menu work has been studied in earlier waves, but this wave focuses on
source-level menu/package boundaries and world-admin utility surfaces rather
than avatar expression menus or OSC sidecars.

## Code-Level Pass Targets

- Menu activation on desktop and VR controllers.
- Tab, page, selector, and option surface lifecycle.
- UdonSharp module reference boundaries.
- Permissions, roles, and player action gates.
- Runtime logging, player lists, event dispatch, and diagnostics.
- Package/VPM ecosystem shape and deprecated-to-modular migration.

## Expected Outputs

- Wave 214 landscape synthesis.
- Registry and family placement for Udon menu/package surfaces.
- Method catalog entry for VRChat/Udon world menu package surfaces with
  prefab-state contracts.
- Follow-up backlog for comparing Udon world menus with engine-neutral VR menu
  and overlay command surfaces.
