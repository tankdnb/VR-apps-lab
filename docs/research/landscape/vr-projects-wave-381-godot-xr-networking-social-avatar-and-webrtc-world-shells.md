# Wave 381: Godot XR Networking, Social Avatar, and WebRTC World Shells

## Theme

Godot XR multiplayer/social shells: simple networked avatars, WebRTC/game
expansions, avatar framework lineage, and a larger social world project.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `goatchurchprime/Godot_XR_networking` | Studied | Minimal Godot XR networking shell with avatars and entry scripts |
| `teddybear082/Godot_XR_Networking-Plus-Game` | Studied | Expanded networking/game variant with WebRTC and game-object folders |
| `zodiepupper/barkvr` | Studied | Larger Godot VR social/world shell with WebRTC and system-level folders |
| `Godot-Dojo/Deprecated-Godot-XR-Avatar` | Studied | Avatar framework lineage with XR Tools-style interactable and hand components |

## Dedupe Notes

Prior waves covered collaboration and avatar rooms at a product level. This
wave focuses on Godot implementation shape: network shell, avatar component
lineage, WebRTC folders, and world-system boundaries.

## Code-Level Findings

### `goatchurchprime/Godot_XR_networking`

- Interesting idea: keep XR networking approachable with a small Godot project
  around `Main.gd`, avatars, plug-in glue, and an OpenXR action map.
- Code donor value: `avatars`, `Main.gd`, `Main.tscn`, `plug.gd`, `addons`,
  and `openxr_action_map.tres` show a minimal multiplayer XR shell.
- Product reference value: useful baseline for "networked utility room" tests
  where avatar presence is enough and heavy game systems are unnecessary.
- What to inspect next: authority model, transform packet schema, avatar
  instancing, reconnect behavior, and network error UI.
- Caveat: minimal demos often omit production identity, moderation, privacy,
  and transport-health surfaces.

### `teddybear082/Godot_XR_Networking-Plus-Game`

- Interesting idea: extend a small XR networking shell into a game prototype by
  adding object folders, WebRTC support, UI/fonts, and gameplay scenes.
- Code donor value: `webrtc`, `objects`, `addons`, scenes, scripts, and
  project settings show a path from room shell to interactive multiplayer lab.
- Product reference value: good comparison node for deciding when a future
  shared VR tool needs "room first" versus "game first" architecture.
- What to inspect next: WebRTC signaling, object ownership, spawn/despawn
  model, and local/offline fallback.
- Caveat: project expansion can blur reusable networking primitives with
  game-specific state.

### `zodiepupper/barkvr`

- Interesting idea: a Godot VR social world can expose system folders, WebRTC,
  Android/export setup, and a larger world/application shell.
- Code donor value: `barkvr-system`, `webrtc`, `addons`, `android`,
  `exports`, and `openxr_action_map.tres` show social-world infrastructure
  boundaries beyond a toy scene.
- Product reference value: useful for future social/remote-assistance utilities
  that need worlds, voice/network layers, and platform packaging boundaries.
- What to inspect next: room/session model, avatar identity, moderation or
  privacy surfaces, and server assumptions.
- Caveat: larger social-world projects need license, service, and credential
  review before any reuse.

### `Godot-Dojo/Deprecated-Godot-XR-Avatar`

- Interesting idea: avatar frameworks can be studied as lineage even after
  deprecation because they show component taxonomy and integration contracts.
- Code donor value: `dojo_core`, `dojo_demo`, XR Tools-like classes, pickup,
  hand, highlight, snap-zone, and interactable components show avatar and
  interaction boundaries.
- Product reference value: helps distinguish avatar embodiment modules from
  networking shells and object interaction modules.
- What to inspect next: avatar skeleton assumptions, hand physics, grab
  compatibility, and why the project was deprecated.
- Caveat: deprecated projects are reference material only; do not treat them as
  recommended implementation targets.

## Reusable Pattern Extraction

- Pattern candidate: Godot XR multiplayer social/avatar shell.
- Problem solved: shared VR utilities need a small room/session layer with
  avatars, object authority, input maps, and transport health before adding
  product-specific tools.
- Reusable core: main scene, avatar prefab/resource, action map, network
  adapter, WebRTC/signaling folder, object authority rule, room shell,
  reconnect/error state, avatar privacy label, and deprecation caveat.
- Source evidence: `Main.gd`, `Main.tscn`, `avatars`, `plug.gd`, `webrtc`,
  `objects`, `barkvr-system`, and Deprecated-Godot-XR-Avatar component
  classes for hands, interactables, highlights, snap zones, and pickups.
- Abstraction boundary: transport/session code should not own avatar asset
  policy or game-specific object rules.
- What not to copy: deprecated avatar framework as-is, service credentials,
  implicit authority rules, or multiplayer demos without privacy/error UI.
- Method catalog action: add Method 826.

## Family Placement

Creates a Godot XR networking/social/avatar family. It overlaps with broader
collaboration waves but captures Godot-specific room, avatar, and WebRTC
implementation evidence.

## Follow-Up Gaps

- Compare Godot ENet/WebRTC paths and document a transport-neutral schema.
- Extract avatar presence minimums for collaborative utility tools.
- Audit privacy/identity assumptions in larger Godot social-world projects.
