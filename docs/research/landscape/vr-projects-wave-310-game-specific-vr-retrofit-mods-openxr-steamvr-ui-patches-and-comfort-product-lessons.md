# Wave 310 - Game-Specific VR Retrofit Mods, OpenXR/SteamVR Bootstrap, UI Patches, and Comfort Product Lessons

This wave studies game-specific VR retrofit mods as reusable references for
runtime bootstrapping, render bridge boundaries, input remapping, motion
controller layers, world-space UI conversion, virtual keyboards, comfort
settings, compatibility gates, and user-facing setup guidance.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- OpenXR and SteamVR bootstrap inside existing games;
- D3D/OpenXR or Unity/OpenXR/SteamVR runtime integration boundaries;
- motion control and virtual gamepad remapping;
- world-space UI conversion and menu/keyboard patches;
- comfort/product lessons from source-light but influential VR mods.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `ethanporcaro/BF2VR-Alpha` | Archived invasive C++ OpenXR/D3D11 game retrofit | Studied | OpenXR instance/session/swapchain creation against an existing D3D11 device plus ViGEm virtual gamepad output |
| `DrBibop/RoR2VRMod` | Unity/BepInEx OpenXR runtime bootstrap and motion control mod | Studied | Runtime OpenXR loader setup, asset bundle hands, body-specific motion controls, wrist/watch HUD, haptics, and config gates |
| `Raicuparta/nomai-vr` | SteamVR/OWML module-oriented VR conversion | Studied | Ordered module activation, SteamVR action manifest/bindings, mode-aware input map, HUD/tools/hands, and SteamVR overlay keyboard bridge |
| `Raicuparta/two-forks-vr` | SteamVR/BepInEx Firewatch UI and locomotion retrofit | Studied | Harmony patches, screen-space canvas conversion into static/interactive world-space UI, laser pointer, body/tools, and VR settings menu |
| `LukeRoss00/gta5-real-mod` | Source-light comfort/setup product reference | Studied as product reference | Installation discipline, fixed/HMD-relative HUD, headshake recenter, gamepad/head aiming, cutscene comfort modes, and settings backup/restore guidance |

## Code-Level Findings

### `ethanporcaro/BF2VR-Alpha`

- Interesting idea:
  an invasive native VR mod can bind OpenXR directly to an existing game's
  graphics device while translating VR input into a virtual gamepad.
- Code donor value:
  medium-high conceptually. `OpenXRService.cpp` creates an OpenXR instance with
  D3D11 extension support, validates D3D11 graphics requirements, selects HMD
  system and blend mode, binds the OpenXR session to the existing D3D11 device,
  creates local reference space, view configuration, stereo swapchains, D3D11
  render-target views, and action sets. `InputService.cpp` uses ViGEm to map
  controller sticks, triggers, and buttons into a virtual X360 gamepad target.
- Product reference value:
  high for understanding invasive bridge risks and the shape of native
  render/input boundaries.
- What to inspect next:
  compositor frame submission, depth handling, injection lifecycle,
  controller action map, virtual gamepad deadzones, and GPL/process-injection
  constraints.
- Reusable pattern extraction:
  separate `game graphics device bridge`, `XR session/swapchain`, and
  `legacy input output adapter`.

### `DrBibop/RoR2VRMod`

- Interesting idea:
  a Unity game can be converted by installing an OpenXR runtime stack at
  mod-load time, then layering body-specific hand assets and control rules.
- Code donor value:
  high as a pattern source. `VRMod.cs` loads assets, config, actions,
  settings, UI, camera/cutscene/focus checks, OpenXR loader, controller
  profiles, haptics, and recenter logic. It dynamically creates
  `XRGeneralSettings`, `XRManagerSettings`, `OpenXRLoader`, selects MultiPass,
  adds controller profile features, initializes/starts subsystems, and sets
  tracking origin. `MotionControls.cs` hooks camera/body/model/inventory events,
  maps character bodies to hand prefabs and weapons, supports wrist/watch HUD
  dominance, and applies controller remaps on body changes.
- Product reference value:
  high for runtime-service split, body-aware tool mapping, and config-driven
  retrofit UX.
- What to inspect next:
  haptics boundary, action schema, ability patching, focus/cutscene states,
  multiplayer compatibility, and failure modes when OpenXR loader setup fails.
- Reusable pattern extraction:
  treat modded VR as `runtime bootstrap -> compatibility gates -> body/tool
  adapters -> input/action layer -> comfort/settings UI`.

### `Raicuparta/nomai-vr`

- Interesting idea:
  a robust VR conversion can be organized as an ordered module graph rather
  than a single monolithic patch.
- Code donor value:
  high. `NomaiVR.cs` initializes saves/assets, starts SteamVR, and then
  activates ordered modules for forced settings, controller input, visual
  fixes, camera masks, player body, tools, hands, ship tools, laser pointer,
  HUD, input prompts, virtual keyboard, menus, visibility fixes, and
  compatibility checks. `InputMap.cs` maps game `InputCommandType` values to
  SteamVR actions through mode-specific maps for default, tools, ship tools,
  and flashlight behavior. `VirtualKeyboard.cs` patches Unity `InputField`
  activation/deactivation, opens the SteamVR overlay keyboard, and writes text
  back when the keyboard closes.
- Product reference value:
  very high for mod architecture, mode-aware action maps, and headset-native
  keyboard/input prompt replacement.
- What to inspect next:
  module dependency order, action manifest generation, input prompt patching,
  HUD layout, compatibility flags, and save/config migration.
- Reusable pattern extraction:
  define retrofit systems as ordered, optional modules with explicit input,
  HUD, tool, menu, and compatibility responsibilities.

### `Raicuparta/two-forks-vr`

- Interesting idea:
  many flat game UIs can be reused in VR if canvases are automatically sorted
  into interactive world-space surfaces or static attached panels.
- Code donor value:
  high. `TwoForksVrMod.cs` sets config, Harmony patches, assets, and SteamVR.
  `CanvasToWorldSpacePatches.cs` patches `UIBehaviour.Awake` and
  `CanvasScaler.OnEnable`, assigns UI layers, ignores UnityExplorer canvases,
  disables black-bar/camera canvases, and converts screen-space overlay
  canvases into `InteractiveUi` or `StaticUi` attached surfaces depending on
  raycaster availability.
- Product reference value:
  high for desktop/game UI migration, laser-pointer menus, and retrofit
  compatibility rules.
- What to inspect next:
  attached UI scaling rules, static vs interactive target transforms, laser
  pointer UX, ignore/disable lists, settings menu, locomotion comfort, and
  patch conflicts.
- Reusable pattern extraction:
  convert UI by classifying surfaces first, not by rewriting every menu.

### `LukeRoss00/gta5-real-mod`

- Interesting idea:
  product discipline matters as much as code in VR retrofits: setup guidance,
  comfort modes, recentering, HUD behavior, and compatibility warnings reduce
  support burden.
- Code donor value:
  low as source code, high as product reference. The README documents clean
  install expectations, game settings, settings backup/restore batch files,
  square window/base-resolution guidance, VR audio device setup, fixed
  semi-transparent HUD about three feet in front, smaller/headlocked HUD while
  aiming, headshake recenter with stillness guard, alternative vehicle
  alignment shortcut, gamepad/head-driven aiming, virtual 2D cutscene mode,
  dynamic stereo, advanced hotkeys, and a detailed taxonomy of FOV/stereo/
  yaw/pitch/roll/position/HUD/crosshair/dominant-eye fixes.
- Product reference value:
  very high for user-facing release notes, comfort option taxonomy, and
  support-safe setup instructions.
- What to inspect next:
  exact option matrix from public docs, community troubleshooting history, and
  how these comfort modes map to non-game VR utilities.
- Reusable pattern extraction:
  every advanced VR retrofit should ship a clear setup/comfort/compatibility
  layer, even when the underlying code is complex.

## Reusable Pattern Extraction

- Pattern candidate:
  game-specific VR retrofit boundary across runtime bootstrap, render bridge,
  input remapping, world-space UI, comfort modes, and compatibility gates.
- Problem solved:
  VR retrofit mods usually intertwine runtime setup, graphics interception,
  control translation, UI migration, comfort behavior, and game-specific
  patches. Reuse needs a disciplined boundary that separates what is general
  from what is game-specific.
- Reusable core:
  runtime bootstrap, graphics/session bridge, action map, legacy input output
  adapter, body/tool mapping, UI surface classifier, virtual keyboard,
  recenter/comfort modes, compatibility gates, and user-facing setup guide.
- Source evidence:
  `ethanporcaro/BF2VR-Alpha`, `DrBibop/RoR2VRMod`,
  `Raicuparta/nomai-vr`, `Raicuparta/two-forks-vr`, and
  `LukeRoss00/gta5-real-mod`.
- Abstraction boundary:
  keep runtime/session startup, graphics bridge, action/input remapping,
  game-patch modules, UI conversion, comfort UX, and compatibility reporting
  separate.
- What not to copy:
  process injection, game-specific hooks, GPL constraints, unbounded Harmony
  patches, unsupported binary mod distribution patterns, or comfort modes
  without clear user controls.
- Method catalog action:
  add a game-specific VR retrofit method.

## Follow-Up Gaps

- Build a retrofit matrix covering runtime, render bridge, input output,
  UI conversion, keyboard strategy, recentering, comfort modes, and support
  warnings.
- Compare world-space canvas conversion with earlier overlay/menu/control
  waves.
- Deepen virtual keyboard, input prompt, wrist/watch HUD, and laser-pointer UI
  patterns.
- Treat source-light comfort docs as product references, not code donors.
