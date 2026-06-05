# VR Projects Wave 106: VRCFaceTracking Core, Modules, Templates, and Blendshape Preparation

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `VRCFaceTracking`, `tracking modules`, `cross-platform face-tracking shells`,
  and `blendshape preparation`.

## Why this wave exists

The repository had tracker bridges and OSC tools, but face tracking needed a
separate pipeline view. The useful architecture is:

`provider module -> unified expression state -> OSC or VRChat output -> avatar authoring requirements`.

This wave captures both runtime and authoring-side pieces of that pipeline.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by VRCFaceTracking, module, provider, and blendshape families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `benaclejames/VRCFaceTracking` | Core face-tracking bridge with module SDK, unified expression state, OSC output, UI, and sandboxing |
| `dfgHiatus/VRCFaceTracking.Avalonia` | Cross-platform shell that mirrors the VRCFaceTracking app model |
| `dfgHiatus/VRCFT-Babble` | Project Babble module mapping local OSC mouth data into unified expressions |
| `regzo2/VRCFaceTracking-MeowFace` | MeowFace module mapping UDP JSON phone data into unified eyes and expressions |
| `Adjerry91/VRCFaceTracking-blender-plugin` | Blender-side shape-key preparation tool for VRC face-tracking labels |

## Deep-pass notes by project

## `benaclejames/VRCFaceTracking`

- GitHub:
  [benaclejames/VRCFaceTracking](https://github.com/benaclejames/VRCFaceTracking)
- What it is:
  a bridge between face or eye tracking hardware modules and VRChat's OSC
  surface.
- Interesting idea:
  normalize device-specific tracking into one unified expression model before
  sending avatar parameters.
- Code-level notes:
  `ExtTrackingModule.cs`
  defines the module lifecycle with support flags, status, metadata, logger,
  `Initialize`, `Update`, and `Teardown`.
  `ParameterSenderService.cs`
  runs a background loop, updates `UnifiedTracking`, batches queued OSC
  messages, clears stale parameters when relevance changes, and sends bundles
  through `OscSendService`.
  `VrcftSandboxServer.cs`
  hosts UDP-based sandboxed module communication with handshake handling,
  connected client tracking, partial-packet reconstruction, and packet event
  dispatch.
- Code donor value:
  very high for module lifecycle, unified data model, OSC output, and
  sandboxed provider isolation.
- Product reference value:
  very high because it exposes module registry, debug pages, parameter pages,
  output logs, settings, and avatar setup framing.
- Caveats:
  the core is large. This wave focused on lifecycle, parameter sending, and
  sandbox boundaries rather than exhausting all UI and registry internals.
- What to inspect next:
  module installer, OSCQuery config parsing, mutators, parameter relevance,
  and sandbox packet family.

## `dfgHiatus/VRCFaceTracking.Avalonia`

- GitHub:
  [dfgHiatus/VRCFaceTracking.Avalonia](https://github.com/dfgHiatus/VRCFaceTracking.Avalonia)
- What it is:
  a cross-platform Avalonia version of VRCFaceTracking for Windows, macOS, and
  Linux.
- Interesting idea:
  keep the face-tracking shell portable while preserving the module registry,
  settings, output, mutator, and diagnostic page model.
- Code-level notes:
  the README documents a compatibility table for module support across
  Windows, macOS, and Linux.
  `ModuleDataService.cs`
  fetches module metadata from `registry.vrcft.io`, caches remote modules,
  records ratings and downloads, scans installed module folders, and migrates
  legacy DLLs into `module.json` folders.
  `DropOverlay.axaml.cs`
  exposes a small reusable overlay control for drag/drop surfaces.
  The repo also includes platform publish scripts and Android shell structure.
- Code donor value:
  high for cross-platform shell design, module metadata services, and legacy
  module migration.
- Product reference value:
  very high for portability and compatibility-matrix framing.
- Caveats:
  module compatibility is constrained by how modules are compiled, so the
  shell is portable before the ecosystem is fully portable.
- What to inspect next:
  app activation flow, module registry UI, Android target maturity, and
  platform-specific packaging.

## `dfgHiatus/VRCFT-Babble`

- GitHub:
  [dfgHiatus/VRCFT-Babble](https://github.com/dfgHiatus/VRCFT-Babble)
- What it is:
  a VRCFaceTracking module for Project Babble mouth tracking.
- Interesting idea:
  a provider module can stay small when the host owns lifecycle and unified
  expression output.
- Code-level notes:
  `BabbleVRC.cs`
  implements `ExtTrackingModule`, declares expression support, loads module
  metadata and static image assets, creates a `BabbleOSC` receiver, writes
  mapped weights into `UnifiedTracking.Data.Shapes`, and tears down the
  receiver.
  `BabbleOSC.cs`
  binds local UDP/OSC input, parses OSC messages, and scales multi-target
  addresses such as mouth funnel or mouth left/right before storing weights.
  `BabbleExpressions.cs`
  provides the address-to-`UnifiedExpressions` mapping table.
- Code donor value:
  high for a compact local OSC provider module.
- Product reference value:
  high for the clean `external tracker app -> VRCFT module -> avatar` flow.
- Caveats:
  the module is intentionally thin and relies on Project Babble and the VRCFT
  host for most user-facing behavior.
- What to inspect next:
  compare the mapping table and scaling rules against other mouth-tracking
  providers.

## `regzo2/VRCFaceTracking-MeowFace`

- GitHub:
  [regzo2/VRCFaceTracking-MeowFace](https://github.com/regzo2/VRCFaceTracking-MeowFace)
- What it is:
  a VRCFaceTracking module for MeowFace Android phone tracking.
- Interesting idea:
  phone-app tracking can be bridged through simple UDP JSON when the module
  normalizes coordinates and shape names into VRCFT's unified model.
- Code-level notes:
  `MeowFaceExtTrackingInterface.cs`
  opens UDP port `12345`, discovers a local IPv4 address for user setup,
  waits for initial JSON data, maps eye gaze and openness into
  `UnifiedEyeData`, maps MeowFace blendshapes into `UnifiedExpressions`, and
  simulates some shapes from related inputs.
  `MeowJsonConverter.cs`
  converts named JSON shape entries into an enum-indexed array so later update
  logic can stay fast and explicit.
- Code donor value:
  high for UDP JSON provider modules and shape normalization.
- Product reference value:
  high for phone-assisted face tracking setup and troubleshooting.
- Caveats:
  tracking quality and network setup depend on the external phone app and
  local network conditions.
- What to inspect next:
  compare timeout/reconnect behavior and per-shape mapping against other
  mobile providers.

## `Adjerry91/VRCFaceTracking-blender-plugin`

- GitHub:
  [Adjerry91/VRCFaceTracking-blender-plugin](https://github.com/Adjerry91/VRCFaceTracking-blender-plugin)
- What it is:
  a Blender plugin that creates or maps shape keys for VRC face tracking.
- Interesting idea:
  face tracking is not only a runtime bridge problem. Avatar authoring needs a
  preparation tool that can create a predictable shape-key vocabulary.
- Code-level notes:
  `VRCFacetracking.py`
  defines a fixed `VRCFT_Labels` list, exposes a Blender panel, lets creators
  select existing shape keys for each label, checks for duplicate shape keys,
  creates separator markers, adds missing VRCFT shape keys, or creates new
  shape keys from selected source shapes.
- Code donor value:
  medium-high for DCC-side shape-key preparation workflow.
- Product reference value:
  high because it closes the gap between runtime tracking and avatar assets.
- Caveats:
  the code is a compact Blender addon and not a full validation suite.
- What to inspect next:
  compare against modern Perfect Sync or ARKit shape-key authoring helpers.

## Main takeaways from Wave 106

- Face tracking is a pipeline family, not just a hardware-support list.
- The key reusable split is `provider module`, `normalized expression state`,
  `transport/output`, and `avatar authoring preparation`.
- VRCFaceTracking is a strong architecture donor because it owns lifecycle,
  unified expressions, OSC output, module metadata, UI, and sandboxing.
- Small provider modules are valuable because they show how much code is
  needed once the host provides the right abstractions.
- DCC authoring tools belong in the same family because runtime tracking is
  useless without compatible avatar shapes.

## Reusable methods clarified by this wave

- `Sandboxed face-tracking module host with unified expression state and OSC bundle output`
- `Cross-platform module registry shell with compatibility matrix and legacy module migration`
- `Provider module that maps local OSC, UDP, or JSON streams into unified expressions`
- `DCC shape-key preparation panel for standard face-tracking labels`

## Recommended next moves after this wave

1. Keep `VRCFaceTracking` visible as the strongest face-tracking bridge donor.
2. Keep `VRCFaceTracking.Avalonia` visible as the strongest cross-platform
   shell and compatibility-matrix reference.
3. Compare `VRCFT-Babble` and `VRCFaceTracking-MeowFace` whenever future work
   needs provider-module templates.
4. Keep `VRCFaceTracking-blender-plugin` visible as an authoring-side bridge
   between avatar assets and runtime face-tracking output.
