# GitHub Research Wave 214 Backlog

Date: 2026-06-06

Theme: VRChat/Udon menu and package surfaces.

## Completed In This Wave

- Deepened `Varneon/UdonEssentials` as a deprecated but source-rich Udon prefab
  collection with event dispatcher, in-world console, playerlist, groups, music,
  and settings utilities.
- Deepened `Varneon/VUdon` as a modular Udon package ecosystem index and
  migration target for smaller utility packages.
- Deepened `SylanTroh/GMMenu` as a roleplay/admin menu with VR/desktop
  activation, permissions, synced pings, teleport/undo/summon, watch camera,
  and HUD modules.
- Studied `kurotori4423/KurotoriUdonMenu` as a local extensible Udon menu with
  trigger/M-key activation, progress animation, tab generation, player
  teleporter, and voice-range controls.
- Added a reusable method entry for Udon world menu package surfaces and
  prefab-state contracts.

## Follow-Up Queue

1. Compare Udon local menus, GM/admin menus, Quick Menu-style packages, and
   generic radial VR menus.
2. Extract a reusable menu lifecycle checklist: activation, placement,
   permission check, page/tab selection, player selection, action dispatch, and
   close animation.
3. Use `GMMenu` as the strongest donor for permission-gated world-operator
   surfaces.
4. Use `KurotoriUdonMenu` as the minimal donor for local tabbed menus and
   option applyers.
5. Use `VUdon` as a package-ecosystem reference when deciding whether a future
   utility should be a prefab, package, or full application.

## Do Not Spend Time On Yet

- Do not run Unity, VRChat, or VCC package imports.
- Do not copy world-admin actions without explicit permission and safety gates.
- Do not treat deprecated UdonEssentials APIs as the preferred implementation
  path when VUdon packages supersede them.
