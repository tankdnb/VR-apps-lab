# VR Projects Wave 169: Universal VR Game Mod Injectors, Managers, and Compatibility Shells

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 169 studies the invasive edge of VR tooling: universal game injectors,
mod-manager manifests, Unity XR subsystem injection, compatibility gates, safe
modes, game-version checks, graphics-hook coexistence, and patch grouping.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `praydog/UEVR` | Unreal VR injector SDK reference | Strong API/profile reference; invasive caveat |
| `praydog/REFramework` | Graphics hook/mod API reference | Strong hook coexistence reference; invasive caveat |
| `Raicuparta/rai-pal` | VR mod manager donor | Strong manifest/provider/database donor |
| `Raicuparta/uuvr` | Unity VR injector donor | Strong subsystem/UI redirection reference; invasive caveat |
| `keton/chihuahua` | Minimal injection utility caveat | Small boundary reference only |
| `NewUnityModder/UnityVRMod` | Unity VR safe-mode reference | Useful safe startup/backend donor |
| `DaXcess/LCVR` | Game-specific VR mod safety shell | Useful startup gate and patch-group reference |
| `DaXcess/RepoXR` | Game-specific OpenXR compatibility shell | Useful runtime info/RPC patch reference |

## `praydog/UEVR`

- Interesting idea:
  expose a universal Unreal VR injector as a callback-rich SDK surface with
  render, OpenXR, input, engine tick, Slate draw, stereo view, viewport, native
  function hook, custom event, and Lua customization entry points.
- Code donor value:
  high for API shape, callback taxonomy, profile/script extension boundaries,
  and render/runtime handle exposure patterns.
- Product reference value:
  high for understanding compatibility and customization expectations around
  VR retrofit tooling.
- What to inspect next:
  separate safe external companion patterns from process-injection internals
  before reusing any concept in public utilities.
- Source evidence:
  `include/uevr/API.h`, `lua-api/Main.cpp`, `src/`, `renderlib/`, and examples.
- Reusable pattern extraction:
  VR injector callback SDK with engine/render/input/script hooks.
- Reusable core:
  expose a stable API version, identify renderer/runtime IDs, provide handles
  only through explicit accessor structures, and organize callbacks by lifecycle
  stage rather than by ad-hoc mod code.
- Do not copy directly:
  injection, hooking, or game-specific bypass logic.
- Caveats:
  process injection is high-risk, compatibility-heavy, and not the same safety
  profile as companion VR utilities.

## `praydog/REFramework`

- Interesting idea:
  combine graphics hooks, Lua/C#/ImGui plugin APIs, method hooks, and
  coexistence logic for other graphics overlays/mods.
- Code donor value:
  high for graphics-hook lifecycle and coexistence patterns, especially
  temporary unhook/restore around device creation and guarded present/resize
  callbacks.
- Product reference value:
  medium-high for modding framework architecture and diagnostics surfaces.
- What to inspect next:
  compare hook coexistence handling against overlay injectors and capture tools
  to build a public "do not fight other hooks" checklist.
- Source evidence:
  `src/D3D11Hook.cpp`, `include/reframework/API.h`, and `csharp-api/`.
- Reusable pattern extraction:
  graphics-hook coexistence pattern with temporary unhook/restore around D3D
  device creation.
- Reusable core:
  make hook install/remove idempotent, avoid recursive self-hooks during device
  creation, expose clear plugin callbacks, and treat other overlays as expected
  neighbors rather than exceptional cases.
- Do not copy directly:
  method hook or process injection internals.
- Caveats:
  heavily tied to RE Engine and native Windows graphics hooking.

## `Raicuparta/rai-pal`

- Interesting idea:
  use a manager/database layer to discover games from providers, model mod
  compatibility, install actions, dependencies, Wine overrides, environment
  variables, and outdated state through structured manifests.
- Code donor value:
  high for manifest schema, provider abstraction, local database tables, Steam
  discovery, install/extract/write actions, and compatibility flags.
- Product reference value:
  high for future utility managers that need repeatable install/compatibility
  metadata without hardcoding every app.
- What to inspect next:
  extract a generic VR utility manifest schema for non-invasive helpers.
- Source evidence:
  `backend/core/src/game_providers/steam/steam_provider.rs`,
  `backend/core/src/mods/game_mod.rs`, and
  `backend/core/src/local_database/mod_database.rs`.
- Reusable pattern extraction:
  VR mod manager manifest schema with provider discovery and compatibility
  database.
- Reusable core:
  separate game discovery from mod metadata, keep install actions declarative,
  record compatibility/outdated state in a local database, and use provider IDs
  plus executable-path hashes for stable installed-game identity.
- Do not copy directly:
  mod-specific manifests without checking licenses and safety implications.
- Caveats:
  broader than VR and intentionally manager-like; donor value is metadata flow.

## `Raicuparta/uuvr`

- Interesting idea:
  patch Unity games by replacing/copying XR subsystem plugin bundles, updating
  enabled VR device settings, and redirecting screen-space UI into VR-visible
  render targets.
- Code donor value:
  high for Unity XR subsystem injection, stale plugin cleanup, global settings
  patching, screen-space canvas capture, and mirror texture redirection.
- Product reference value:
  high for understanding Unity VR retrofit architecture and UI capture
  pitfalls.
- What to inspect next:
  map which UI redirection techniques can be reused safely in owned Unity
  prototypes without game patching.
- Source evidence:
  `Uuvr.Patcher/UuvrPatcher.cs`, `Uuvr/Patches.cs`,
  `Uuvr/VrUi/PatchModes/CanvasRedirectPatchMode.cs`, and
  `Uuvr/VrUi/PatchModes/ScreenMirrorPatchMode.cs`.
- Reusable pattern extraction:
  Unity XR subsystem injection bundle with safe plugin replacement and global
  settings patch; screen-space UI redirection into VR.
- Reusable core:
  treat XR loader/plugin files as a coherent bundle, remove stale loaders before
  copying, patch global XR settings intentionally, and redirect legacy
  screen-space UI through capture cameras or mirror render textures.
- Do not copy directly:
  patching another app's files or bypassing ownership boundaries.
- Caveats:
  invasive and experimental; valuable mainly as architecture/reference material.

## `keton/chihuahua`

- Interesting idea:
  provide a compact UEVR helper/profile utility that demonstrates the classic
  Windows DLL injection sequence with explicit process and export calls.
- Code donor value:
  low-medium as a minimal boundary/caveat example for injection tooling.
- Product reference value:
  medium for operator-facing error flow and small helper packaging.
- What to inspect next:
  use only as a cautionary reference when documenting why public utilities
  should prefer external companion APIs where possible.
- Source evidence:
  `Injector.cs`, `Chihuahua.cs`, and helper files.
- Reusable pattern extraction:
  minimal DLL injection utility boundary and operator error messages.
- Reusable core:
  if a tool crosses process boundaries, surface explicit process discovery,
  allocation/write/thread-call steps and failures rather than hiding them.
- Do not copy directly:
  `OpenProcess`, `VirtualAllocEx`, `WriteProcessMemory`, `CreateRemoteThread`,
  or remote export invocation into VR-apps-lab tools without a deliberate,
  reviewed reason.
- Caveats:
  Windows-only, invasive, and mostly useful as a safety boundary example.

## `NewUnityModder/UnityVRMod`

- Interesting idea:
  build a Unity VR mod framework around BepInEx/UniverseLib with backend
  selection, safe mode, delayed VR initialization, scene-change invalidation,
  and teardown/reinit levels.
- Code donor value:
  medium-high for safe-mode startup, backend abstraction, scene-change safety,
  and feature gating.
- Product reference value:
  high for user-protective VR retrofit UX.
- What to inspect next:
  compare safe-mode flow with game-specific mods to derive a generic startup
  checklist.
- Source evidence:
  `src/VRModCore.cs`, `src/Features/VRVisualization/VrVisualizationManager.cs`,
  and OpenVR/OpenXR native bridge structure.
- Reusable pattern extraction:
  Unity VR mod safe-mode gate with backend selection and scene-change
  reinitialization.
- Reusable core:
  start in safe mode, delay VR initialization until explicitly allowed, select
  backend through build/runtime flags, invalidate camera/backend state on scene
  changes, and provide teardown/reinitialize levels.
- Do not copy directly:
  game injection framework code.
- Caveats:
  early WIP and intentionally mod-oriented.

## `DaXcess/LCVR`

- Interesting idea:
  wrap a game-specific VR mod with config disable, command-line disable,
  ask-on-startup dialog, game assembly hash verification, dependency preload,
  asset bundle loading, and universal vs VR-only patch groups.
- Code donor value:
  medium-high for compatibility gate and patch organization.
- Product reference value:
  high for how VR mods should communicate risk and compatibility to users.
- What to inspect next:
  compare with `RepoXR` to extract a shared compatibility gate template.
- Source evidence:
  `Source/Plugin.cs` and `Source/Patches/HarmonyPatcher.cs`.
- Reusable pattern extraction:
  game-specific VR mod startup gates with hash/version checks and patch groups.
- Reusable core:
  allow a hard disable flag, ask before enabling VR, verify supported game
  assembly state, preload runtime dependencies, and separate universal patches
  from VR-only patches.
- Do not copy directly:
  game-specific bypass tokens, offsets, or gameplay patches.
- Caveats:
  valuable as a safety shell, not as a general utility implementation.

## `DaXcess/RepoXR`

- Interesting idea:
  combine game version checks, OpenXR runtime info logging, patch groups, asset
  loading, and attribute-driven RPC patch registration inside a game-specific
  VR mod.
- Code donor value:
  medium-high for runtime diagnostics, compatibility warnings, and RPC patch
  registration.
- Product reference value:
  high for clear user-facing compatibility failure messages.
- What to inspect next:
  use runtime info logging and patch failure messaging as a model for future VR
  compatibility doctors.
- Source evidence:
  `Source/Plugin.cs` and `Source/Patches/HarmonyPatcher.cs`.
- Reusable pattern extraction:
  attribute-driven VR network RPC patch registration plus OpenXR compatibility
  logging.
- Reusable core:
  log OpenXR runtime metadata early, gate unsupported game versions, group
  patches by scope, register special network/RPC patches through attributes, and
  show a visible warning when critical patches fail.
- Do not copy directly:
  game-specific Harmony patches.
- Caveats:
  game-specific and invasive, but the diagnostics posture is reusable.

## Cross-Project Lessons

- VR retrofit projects repeatedly need explicit safety gates: disable flags,
  version checks, runtime logging, dependency preload, and clear failure
  messages.
- Manifest/database managers are safer donors than injectors because they
  encode compatibility knowledge without necessarily crossing process
  boundaries.
- UI redirection and mirror capture are broadly reusable concepts, but direct
  game patching is not.
- Future public tooling should document the boundary between companion,
  diagnostic, manager, and injector patterns instead of mixing them together.
