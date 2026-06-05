# GitHub Research Wave 169 Plan

- Date: `2026-06-05`
- Theme: `Universal VR game mod injectors, managers, and compatibility shells`
- Scope: Unreal and Unity VR injectors, mod managers, game-specific VR mods,
  graphics hook coexistence, startup gates, patch groups, and compatibility
  metadata.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

VR utility work often needs to understand the boundary between safe companion
tools and invasive game modification. Wave 169 studies that boundary explicitly:
SDK surfaces, injection callbacks, graphics hooks, compatibility manifests,
startup checks, safe modes, and patch grouping patterns that can inform future
diagnostics and tooling without normalizing unsafe copying.

## Search Families

- Universal Unreal VR injectors
- RE Engine and graphics hook mod frameworks
- VR mod managers and compatibility databases
- Unity XR subsystem injection and UI redirection
- game-specific VR mods with safety gates

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `praydog/UEVR` | Large Unreal VR injector with C API, OpenXR/render callbacks, Lua customization, and profile ecosystem | Unreal VR injector SDK reference |
| `praydog/REFramework` | RE Engine mod framework with D3D hooks, Lua/C#/ImGui plugin APIs, and hook coexistence logic | Graphics hook/mod API reference |
| `Raicuparta/rai-pal` | Tauri/Rust manager for game providers, VR mods, manifests, installs, and compatibility state | VR mod manager donor |
| `Raicuparta/uuvr` | Universal Unity VR injection bundle with XR subsystem copying and screen-space UI redirection | Unity VR injector donor |
| `keton/chihuahua` | Small UEVR profile/helper utility using classic DLL injection primitives | Minimal injection utility caveat |
| `NewUnityModder/UnityVRMod` | BepInEx/UniverseLib Unity VR framework with backend selection and safe-mode startup | Unity VR safe-mode reference |
| `DaXcess/LCVR` | Lethal Company VR mod with config disable, version/hash checks, dependency preload, and patch groups | Game-specific VR mod safety shell |
| `DaXcess/RepoXR` | R.E.P.O. VR mod with OpenXR runtime info, game version checks, patch groups, and RPC patching | Game-specific VR mod compatibility shell |

## Dedupe Notes

- This wave does not treat game injectors as recommended product targets; they
  are studied to extract compatibility, diagnostics, manifest, and safety
  patterns.
- UEVR-related helper repos were deduplicated against earlier overlay and mod
  references; `chihuahua` is retained only because it is a compact injection
  boundary example.
- Game-specific mods are retained for startup/compatibility design, not for
  gameplay feature copying.

## Code-Level Pass Targets

- plugin API callback surfaces and OpenXR/render/input handles;
- graphics hook initialization, unhook/restore, present/resize callbacks, and
  coexistence guards;
- mod manifest schemas, game provider discovery, dependency/install actions,
  and compatibility databases;
- Unity XR subsystem copying, loader settings patching, stale plugin cleanup,
  and UI capture/mirror redirection;
- safe-mode toggles, game version/hash checks, runtime dependency preload,
  universal vs VR-only patch groups, and RPC patch registration.

## Expected Outputs

- New Wave 169 landscape synthesis.
- Registry/family placement for VR injectors, mod managers, and compatibility
  shells.
- Methods around callback SDKs, graphics hook coexistence, mod manager
  manifests, Unity XR subsystem injection, safe-mode startup, compatibility
  gates, and attribute-driven RPC patching.
