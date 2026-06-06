# GitHub Research Wave 239 Plan

Date: 2026-06-06

Theme: Game-specific VR retrofit UX, mod interaction shells, and in-game
control surfaces.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Game-specific VR retrofit mods are valuable for `VR-apps-lab` because they
must solve difficult interaction problems in hostile environments: patching
input, converting flat UI into world-space or wrist UI, adding virtual
keyboards, haptics, comfort, radial menus, calibration, focus-state switching,
and safety gates.

## Search Families

- BepInEx/Harmony VR retrofit mods.
- UEVR enhancement layers.
- In-game VR radial menus and wrist UI.
- Virtual keyboard and world-space UI patches.
- Modular VR mod shells and gesture summon systems.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `Okabintaro/SubmersedVR` | Subnautica VR modernization with SteamVR input, UI lasers, wrist HUD, quick slots, virtual keyboard, and calibration. | VR retrofit donor |
| `dortamur/satisfactory-uevr-enhancements` | Satisfactory UEVR companion with data-driven VR UI, input, wrist/radial/menu assets, and onboarding references. | UEVR product reference |
| `DSprtn/GTFO_VR_Plugin` | GTFO VR plugin with IL2CPP injections, SteamVR input, world-space UI, watch, radial menus, terminal keyboard, and haptics. | VR retrofit donor |
| `KyleTheScientist/Bark` | Gorilla Tag mod menu with gesture summon, grabbable menu, physical buttons, modules, networking, and manual test procedures. | In-game interaction shell reference |

## Dedupe Notes

Generic VR game injectors and retrofit managers have prior coverage. This wave
focuses on in-game UX shells and control surfaces inside specific mods, not on
injector distribution mechanics.

## Code-Level Pass Targets

- Patch/plugin entry points and class injection.
- SteamVR/controller input remapping.
- World-space UI, wrist UI, radial menu, and virtual keyboard patterns.
- Gesture/menu summon and physical button interaction.
- Haptics, comfort, calibration, and debug panels.
- Binary asset/data-table caveats for UEVR projects.

## Expected Outputs

- Wave 239 landscape synthesis.
- Registry/family entries for game-retrofit interaction shells.
- Method catalog entry for retrofit patch/UI/input layer boundaries.
- Follow-up backlog for a VR retrofit interaction-shell matrix.
