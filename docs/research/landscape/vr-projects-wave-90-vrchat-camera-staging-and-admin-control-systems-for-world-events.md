# VR Projects Wave 90: VRChat Camera, Staging, and Admin-Control Systems for World Events

- Date: `2026-04-21`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `VRChat camera systems`, `staging and admin control`, and
  `creator-side event coverage`.

## Why this wave exists

`VR-apps-lab` already had strong generic overlay and media-surface coverage,
but it still lacked a cleaner answer to:

`what the strongest creator-side camera and admin-control donors look like when the main value is multicam staging, permission-gated control consoles, watch cameras, and avatar-side OSC camera paths`.

This wave exists to make that branch clearer.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with VRChat camera-system, event-camera, and GM-menu queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `laserimouto/VRChatCameraWorks` | Strong donor for prefab-first multicam staging with autopilot, transitions, and fisheye variants |
| `rhaamo/CameraSystem` | Strong donor for a permission-gated world camera console with live output, handhelds, and synced operator controls |
| `VRLabs/Camera-System` | Strong product reference for an avatar-side OSC camera-path system that turns avatar contacts and constraints into a camera-control channel |
| `SylanTroh/GMMenu` | Strong donor for a modular admin package where camera viewing is one operator surface among teleport, permissions, voice, and HUD systems |

## Deep-pass notes by project

## `laserimouto/VRChatCameraWorks`

- GitHub:
  [laserimouto/VRChatCameraWorks](https://github.com/laserimouto/VRChatCameraWorks)
- What it is:
  a prefab set for VRChat world creators that provides third-person cameras,
  multicam output, autopilot transitions, fade blends, and fisheye rigs.
- Why it matters:
  it is the clearest donor in this wave for
  `camera rig as prefab library with small script controllers`.
- Interesting ideas:
  keep the main authoring surface in prefabs and scene setup, then use tiny
  UdonSharp controllers to switch live output and camera order; treat fisheye
  as a branch of the same staging system instead of a separate whole product.
- Interesting implementation choices:
  `Multicam/Scripts/CinemachineMulticamController.cs`
  toggles output and active cameras with minimal state; `CameraAutopilot.cs`
  is a thin event driver that advances or randomizes the active camera by
  calling Udon custom events instead of owning the whole system itself.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  the repo explicitly notes that networking is not implemented, so its
  strongest role is creator staging, not shared operator control.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `prefab-first creator camera rig`
  donor.

## `rhaamo/CameraSystem`

- GitHub:
  [rhaamo/CameraSystem](https://github.com/rhaamo/CameraSystem)
- What it is:
  a VRChat world camera system with a full console, multiple fixed and handheld
  cameras, synced live-output switching, and authorization hooks for operator
  control.
- Why it matters:
  it is the clearest donor in this wave for
  `permission-gated world camera console`.
- Interesting ideas:
  keep operator control behind explicit authorization methods; support a
  low-cost `potato mode` that only keeps the active camera alive; treat
  handheld cameras, live output, FOV control, and follow targets as one world
  operations surface.
- Interesting implementation choices:
  `CameraSystem_Console.cs`
  uses synced camera index, synced FOV and follow-user data, render textures,
  UI feedback colors, and an authorization gate before live camera changes;
  the system explicitly separates `authorize/deauthorize` and
  `potato/noLongerAPotato` as creator-facing operations.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the repo itself is candid about rough edges and real-world test gaps.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `world-side event camera console`
  donor.

## `VRLabs/Camera-System`

- GitHub:
  [VRLabs/Camera-System](https://github.com/VRLabs/Camera-System)
- What it is:
  an avatar-side camera system that captures path points and settings through
  contacts, constraints, and physbones, then uses an external OSC companion to
  drive a desktop camera path.
- Why it matters:
  it is the clearest reference in this wave for
  `avatar-driven camera path authoring with an off-avatar companion`.
- Interesting ideas:
  use the avatar itself as the authoring surface for path placement; send the
  captured data out to a companion program and return the finished path back to
  the avatar for playback; model creator interaction through expression menu
  plus desktop-side companion rather than through one world console.
- Interesting implementation choices:
  the README and hierarchy surface the data-encoding split more clearly than
  source code does: constraints, contact receivers, physbones, and menu
  parameters create the in-avatar transport, while the external `CameraSystem`
  companion executable owns playback orchestration; `Instancer/Camera-System Instancer.cs`
  shows the package is also shaped for reuse through VRLabs tooling.
- Code donor value:
  medium.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the crucial companion logic lives outside the directly inspectable avatar
  assets, so this repo is only partially studied in this pass.
- What to inspect next:
  revisit when a future pass needs deeper mapping of the companion protocol and
  OSC data contract.

## `SylanTroh/GMMenu`

- GitHub:
  [SylanTroh/GMMenu](https://github.com/SylanTroh/GMMenu)
- What it is:
  a modular Udon menu package for VRChat roleplay or event moderation with ping
  handling, teleports, watch camera, permissions, voice modes, and HUDs.
- Why it matters:
  it is the clearest donor in this wave for
  `broad admin surface where camera viewing is only one module inside a larger control package`.
- Interesting ideas:
  split the admin package into many cooperating modules; make watch-camera
  thumbnails and live watch views part of the same GM workflow as permissions,
  teleports, and messages; keep optional audio-control branches additive
  instead of forcing one huge dependency chain.
- Interesting implementation choices:
  `Runtime/GMMenu.cs`
  acts as a module aggregator for toggle, message, voice, teleporter,
  permissions, mover, watch camera, and player selection systems; `WatchCamera.cs`
  renders thumbnails and follow views through separate cameras, updates player
  lists only when needed, and gates thumbnail updates behind permission levels.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the package is broad enough that this pass only mapped the main module split
  and the watch-camera line, not every operational path in depth.
- What to inspect next:
  revisit when a future pass needs a tighter read of ping flow, permissions,
  and optional audio-control integration.

## Main takeaways from Wave 90

- `VRChat creator camera systems`
  now split more cleanly into:
  - prefab-first multicam rigs;
  - world-side operator consoles;
  - avatar-driven OSC camera paths;
  - broader admin menus with watch-camera modules.
- The strongest lesson from this wave is that
  `creator camera donors`
  are most reusable when camera control is kept as one explicit subsystem among
  permissions, output routing, or external companion flows.
- Another strong lesson is that
  `camera tooling in VRChat`
  is often half world system and half operator workflow, so product framing
  matters almost as much as raw camera code.

## Reusable methods clarified by this wave

- `Prefab-first multicam creator rig with desktop output switching, autopilot, and optional fisheye or transition branches`
- `Permission-gated world camera console with synchronized live feed, handheld camera control, and low-cost standby mode`
- `Avatar-side OSC camera path system that uses avatar mechanics as a data-entry layer for an external companion`
- `Modular admin package where watch camera, permissions, teleports, and voice controls stay as separate cooperating systems`

## Recommended next moves after this wave

1. Keep `VRChatCameraWorks` visible as a strong
   `prefab rig and staging`
   donor.
2. Treat `CameraSystem` as a stronger
   `world operator console`
   donor than a mere camera prefab pack.
3. Keep `VRLabs/Camera-System` visible as a high-value product reference even
   though the companion-bound architecture remains only partially studied.
4. Revisit `GMMenu` when a future pass needs to map the full relationship
   between moderation, watch camera, and optional audio-control modules.
