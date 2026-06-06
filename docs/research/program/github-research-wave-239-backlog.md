# GitHub Research Wave 239 Backlog

Date: 2026-06-06

Theme: Game-specific VR retrofit UX, mod interaction shells, and in-game
control surfaces.

## Completed In This Wave

- Studied `Okabintaro/SubmersedVR` as a Subnautica VR retrofit with settings
  tabs, SteamVR input patches, snap-turn gating, controller/UI laser pointers,
  virtual keyboard patches for TMP fields and beacon labels, camera-rig
  ownership, wrist HUD, quick-slot radial wheel, offset calibration logging,
  main-menu camera stealing, and debug panel.
- Studied `dortamur/satisfactory-uevr-enhancements` as a UEVR companion
  product reference with plugin metadata, SML dependency, binary Blueprint
  assets for controller mappings, wrist UI, radial menus, haptics, help tips,
  onboarding patches, keyboard actions, and UEVR profile coupling.
- Studied `DSprtn/GTFO_VR_Plugin` as an IL2CPP/BepInEx retrofit donor with
  SteamVR process gate, class injection list, Harmony patches, VRSystems focus
  handling, SteamVR input mapping, movement vignette, snap-turn fade,
  world-space UI conversion, watch/radial inventory surfaces, terminal
  keyboard, haptics integrations, and render/UI detours.
- Studied `KyleTheScientist/Bark` as a Gorilla Tag mod interaction shell with
  BepInEx/Utilla lifecycle, modded-lobby gating, gesture-based menu summon,
  grabbable thrown menu, physical collision buttons, settings page, module
  discovery, hand/pointer interactors, gesture tracking, networked module
  status, and manual testing procedures.
- Added a reusable method entry for game-retrofit VR interaction shells with
  patch, UI, input, comfort, and haptic layers.

## Follow-Up Queue

1. Compare VR retrofit UI surfaces across SubmersedVR, GTFO VR, UEVR
   enhancements, Bark, and prior universal injector families.
2. Extract a general `patch entry -> VR systems -> input adapter -> UI
   conversion -> comfort/haptics/debug` architecture template.
3. Compare radial/wrist/keyboard patterns across game mods and standalone VR
   utilities.
4. Document what not to reuse from game-specific mods: game constants,
   binary-only assets, cheat-like modules, and unsupported patch assumptions.

## Do Not Spend Time On Yet

- Do not run or install game mods, UEVR profiles, BepInEx plugins, or SteamVR.
- Do not copy game assets, binary Blueprints, controller binding files, or
  mod-specific safety assumptions.
- Do not treat game-mod mechanics as acceptable product behavior without
  consent, ToS, and multiplayer safety review.
