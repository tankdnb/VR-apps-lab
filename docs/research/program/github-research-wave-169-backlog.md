# GitHub Research Wave 169 Backlog

- Date: `2026-06-05`
- Theme: `Universal VR game mod injectors, managers, and compatibility shells`
- Status: `Completed`

## Completed Pass

1. Search Unreal, Unity, RE Engine, and game-specific VR mod tooling.
2. Deduplicate against prior overlay, mod, and runtime helper coverage.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect injector APIs, D3D hook logic, Lua/C#/ImGui surfaces, mod provider
   discovery, manifests, database schemas, Unity XR subsystem copying,
   screen-space UI redirection, safe-mode gates, version/hash checks, patch
   groups, and RPC patch attributes.
5. Separate donor-worthy compatibility methods from invasive implementation
   details that should not be copied directly.
6. Integrate results into registry, families, methods, not-yet queue, current
   focus, and indexes.

## Studied Repositories

| Project | Outcome |
|---|---|
| `praydog/UEVR` | Added as Unreal VR injector callback SDK and profile/script reference |
| `praydog/REFramework` | Added as graphics hook coexistence and mod API reference |
| `Raicuparta/rai-pal` | Added as VR mod manager manifest/provider/compatibility database donor |
| `Raicuparta/uuvr` | Added as Unity XR subsystem injection and UI redirection donor |
| `keton/chihuahua` | Added as compact DLL injection utility caveat/reference |
| `NewUnityModder/UnityVRMod` | Added as Unity VR safe-mode and backend-abstraction reference |
| `DaXcess/LCVR` | Added as game-specific VR mod startup gate and patch-group reference |
| `DaXcess/RepoXR` | Added as game-specific OpenXR compatibility shell and RPC patch reference |

## Useful Follow-Up Work

- Build a "safe companion vs invasive injector" boundary document for public
  repository positioning.
- Create a compatibility-gate checklist for future VR mod/patch utilities:
  runtime info, game version, hash, dependency preload, disable flag, patch
  groups, and user-facing warnings.
- Extract a generic mod manifest schema for non-invasive utility helpers.

## Not Pursued In This Wave

- No injector, mod manager, game, plugin, DLL, loader, Unity game, Unreal game,
  or OpenXR runtime was launched.
- No found repository was run, built, installed, imported, or tested.
