# VR Projects Wave 239: Game-Specific VR Retrofit UX, Mod Interaction Shells, and In-Game Control Surfaces

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies game-specific VR retrofit interaction shells: patch entry
points, SteamVR input adapters, world-space UI, wrist dashboards, radial menus,
virtual keyboards, haptics, calibration, focus-state switching, and gesture
summon systems.

## Why It Matters For `VR-apps-lab`

Game retrofit mods solve hard UX problems under constraints that normal apps
avoid. They are useful donors for overlay/control-surface design as long as
game-specific code, assets, and multiplayer assumptions are not copied
uncritically.

## Project Notes

### `Okabintaro/SubmersedVR`

- Interesting idea:
  a retrofit can modernize an existing VR mode by adding a dedicated VR input,
  UI, wrist, keyboard, and calibration layer instead of only patching camera
  rendering.
- Code donor value:
  `Settings.cs` builds an in-game options tab for movement, snap turning,
  wrist bars, haptics, laser pointer mode, hand reticle, and advanced comfort
  settings. `SteamVrGameInput.cs` patches game input into SteamVR actions and
  gates snap turns. `LaserPointer.cs` combines UI and world ray feedback.
  `VirtualKeyboard.cs` patches TMP input activation to SteamVR keyboard flows.
  `VRCameraRig.cs` owns world/UI controller rigs and pointer cameras.
  `VRHud.cs` moves HUD into world/wrist canvases. `VRQuickSlots.cs` converts
  quick slots into a controller-distance radial wheel. `OffsetCalibrationTool`
  logs transform offsets for tool/hand tuning.
- Product reference value:
  strong donor for game-to-VR interaction conversion and utility UI patterns.
- What to inspect next:
  compare wrist HUD, virtual keyboard, and quick-slot radial wheel against
  standalone overlay utilities.
- Architecture pattern:
  BepInEx/Harmony retrofit with settings, input patches, camera rig, pointer
  UI, wrist HUD, keyboard, and calibration tools.
- Caveats:
  game-specific APIs, SteamVR/OpenVR path, Linux/WiVRn caveats, and many
  assumptions tied to Subnautica UI internals.

### `dortamur/satisfactory-uevr-enhancements`

- Interesting idea:
  a UEVR companion can be a data/asset-driven VR UX layer rather than a code
  injector itself.
- Code donor value:
  repository metadata and assets show controller mappings, input actions,
  wrist UI, radial menus, haptic effects, help tips, onboarding patches,
  keyboard types, movement orientation, camera modes, build helpers, pointer
  targets, HUD widgets, and settings structs. The `.uplugin` declares an SML
  runtime module and explicitly states that UEVR itself is still required.
- Product reference value:
  strong product reference for UEVR companion UX, onboarding, and VR-specific
  control surfaces.
- What to inspect next:
  if source Blueprint exports become available, map data tables to runtime
  behavior; otherwise compare as a binary-asset product reference.
- Architecture pattern:
  UEVR enhancement layer with plugin metadata, profile coupling, data tables,
  input assets, and Blueprint UI components.
- Caveats:
  mostly binary Unreal assets; weak code donor, strong product/reference donor.

### `DSprtn/GTFO_VR_Plugin`

- Interesting idea:
  a robust retrofit shell separates plugin load, VR system ownership, input,
  player components, UI conversion, keyboard, haptics, and focus transitions.
- Code donor value:
  `GTFO_VR_Plugin.cs` gates load on SteamVR process detection, registers IL2CPP
  component types, hooks detours, and applies Harmony patches. `VRSystems.cs`
  initializes SteamVR, adds HMD/controllers/keyboard/assets, manages overlay
  focus state, toggles player camera, and clears UI render textures.
  `SteamVR_InputHandler.cs` maps game actions to SteamVR booleans/axes and
  haptics. `MovementVignette.cs` ties vignette intensity to player velocity.
  `Snapturn.cs` supports snap or smooth turn with fade. `RadialMenu.cs`,
  `WeaponRadialMenu.cs`, `Watch.cs`, `VRKeyboard.cs`, and
  `VRWorldSpaceUI.cs` show radial inventory, wrist watch, terminal/chat
  keyboard, and world-space UI conversion.
- Product reference value:
  very strong game-retrofit interaction shell donor.
- What to inspect next:
  compare against SubmersedVR to extract a game-independent retrofit layering
  template.
- Architecture pattern:
  IL2CPP/BepInEx plugin with injected VR systems, input adapter, world-space
  UI, radial/wrist surfaces, comfort, and haptics.
- Caveats:
  tightly coupled to GTFO internals, SteamVR, IL2CPP, and external haptics
  integrations.

### `KyleTheScientist/Bark`

- Interesting idea:
  a mod menu can be a physical VR object with gesture summon, grabbable menu
  body, collision buttons, module pages, and networked module state.
- Code donor value:
  `Plugin.cs` gates setup by modded lobby state, loads an asset bundle, creates
  gesture tracker/network handler/menu controller, and applies Harmony patches.
  `MenuController.cs` builds module pages, supports gesture or input-based
  summon, docks the menu to the player, and allows the menu to be thrown away.
  `ButtonController.cs` uses collision observers, blockers, haptic pulse, and
  visual pressed state. `GestureTracker.cs` tracks controller input and body
  vectors, detects chest-beat and hand gestures, and exposes hand interactors.
  `BarkModule.cs` provides enable/disable/config/network status boundaries.
  `NetworkPropertyHandler.cs` batches Photon custom property updates. Manual
  testing procedures list behavioral checks per module.
- Product reference value:
  strong interaction-shell reference for in-world menus and module gating.
- What to inspect next:
  compare gesture summon and physical button blocking with accessibility and
  safety requirements for non-game utilities.
- Architecture pattern:
  BepInEx/Utilla mod shell with gesture input, grabbable menu, physical
  buttons, module lifecycle, network state, and manual test checklist.
- Caveats:
  Gorilla Tag mod context, multiplayer/ToS sensitivity, cheat-like module
  behaviors, and asset-bundle dependence.

## Reusable Pattern Extraction

- Pattern candidate:
  game-retrofit VR interaction shell with patch, UI, input, comfort, and
  haptic layers.
- Problem solved:
  non-VR or weak-VR applications need interaction conversion without rewriting
  the whole product: input remap, camera ownership, world-space UI, wrist/radial
  controls, keyboard, haptics, comfort, calibration, and debug tooling.
- Reusable core:
  isolate plugin/patch entry, runtime readiness gate, VR systems owner, input
  adapter, UI conversion, wrist/radial/menu surfaces, keyboard/text input,
  haptics, comfort policy, calibration/logging, focus-state handling, and
  debug/diagnostics.
- Source evidence:
  `SubmersedVR`, `satisfactory-uevr-enhancements`, `GTFO_VR_Plugin`, and
  `Bark`.
- Abstraction boundary:
  keep patch hooks separate from interaction logic; keep game action mapping
  behind an adapter; keep UI surface widgets separate from game-specific
  object discovery; keep haptics/comfort optional and configurable.
- What not to copy:
  game assets, binary Blueprints, hardcoded game internals, unsupported
  multiplayer behavior, cheat-like modules, controller binding files as
  universal defaults, or runtime-injection assumptions as normal app design.
- Method catalog action:
  add a method entry for game-retrofit interaction shell boundaries.

## Follow-Up Gaps

- Compare retrofit layering across SubmersedVR, GTFO VR, UEVR enhancements,
  Bark, and prior universal injector/manager families.
- Extract a reusable radial/wrist/keyboard/control-surface matrix from these
  mods and standalone overlay utilities.
- Write a safety/ethics checklist for game-mod-derived UX patterns before any
  pattern is reused in public utilities.
