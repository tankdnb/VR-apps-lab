# GitHub Research Wave 186 Plan

- Date: `2026-06-06`
- Theme: `VR menu, radial control, avatar-menu editing, and OSC command surfaces`
- Scope: Unity radial menu samples, physically animated radial menus, Unreal
  radial menu assets, wrist-rotation menu demos, Quest launcher menus, VRChat
  expression-menu editor utilities, and desktop OSC command tools.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

VR utility tools need good command surfaces. This wave studies menu interaction
patterns across in-headset radial menus, editor-side menu tooling, Android app
launching from VR, and desktop companions that bypass limited in-VR radial
menus through OSC.

## Search Families

- Unity radial menus and physical radial menu variants
- wrist-rotation menu selection
- Unreal/XR radial menu assets
- Quest home/app-launcher menus
- VRChat expression-menu editor utilities
- desktop companion tools for in-game command macros

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `VRwithAndrew/VR-RadialMenu` | Source-light Unity radial menu series template | Thin radial menu baseline |
| `Gustorvo/RadialMenuVR` | Physically animated radial menu using numeric springs and evented items | Strong radial menu donor |
| `ryangadz/RadialMenu` | Unreal XR radial menu plugin, mostly binary assets | Unreal radial menu reference |
| `GabrielDiDomenico/RadialMenu` | Wrist-rotation radial menu demo with XRI samples | Wrist menu / source-light demo |
| `kblood/Quest-VR-Menu` | Quest VR app launcher metaphor using physical cubes and Android intents | VR launcher/menu reference |
| `CascadianVR/VRC-Menu-Translator` | Unity Editor traversal and translation of VRChat expression menus | Editor-side menu utility |
| `Tazaur/VrCScalingTool` | Windows OSC command surface for avatar scale slots/hotkeys | Desktop OSC command companion |

## Dedupe Notes

- Earlier waves already studied `Oyshoboy/RadialMenuVR` and
  `yusufalibrahim1994/UnityXR-Physicalized-Radial-Menu`, so those were not
  repeated.
- `Gustorvo/RadialMenuVR` is distinct because its reusable value is numeric
  spring animation, evented item management, attachments, and dynamic menus.
- Thin radial/menu repos are retained only when they add product contrast or a
  different platform boundary.

## Code-Level Pass Targets

- radial menu item placement, hover, selection, events, and animation;
- numeric spring versus animation curve behavior;
- wrist/control rotation selection and XRI interaction conflicts;
- Android app enumeration and launch intents from Unity;
- VRChat expression menu traversal and editor mutation;
- OSC command surfaces with saved slots, hotkeys, OSCQuery, and SteamVR launch
  registration.

## Expected Outputs

- Wave 186 landscape synthesis.
- Registry/family placement for menu and command-surface projects.
- Methods around numeric-spring radial menus, VR app-launcher surfaces,
  expression-menu traversal, and desktop OSC slot command companions.
