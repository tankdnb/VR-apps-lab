# VR Projects Wave 89: VRChat World Runtime Infrastructure, Voice, Networking, and Player-State Helpers

- Date: `2026-04-21`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `VRChat world runtime infrastructure`, `voice and networking helpers`, and
  `per-player state systems`.

## Why this wave exists

`VR-apps-lab` already had good creator-facing media and VRChat-side control
coverage, but it still lacked a cleaner answer to:

`what the strongest reusable world-runtime donors look like when the main value is voice-state control, message transport, moving-platform locomotion, and stable per-player object anchoring`.

This wave exists to make that branch clearer.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with VRChat world-runtime, audio control, and Udon-networking
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `Guribo/UdonVoiceUtils` | Strong donor for package-shaped voice-state control with zones, occlusion, privacy, and runtime configuration models |
| `Xytabich/UNet` | Strong donor for reliable binary transport and sequencing over Udon sync primitives |
| `Superbstingray/UdonPlayerPlatformHook` | Strong narrow donor for moving-platform locomotion correction inside VRChat worlds |
| `CyanLaser/CyanPlayerObjectPool` | Strong donor for assigning stable per-player objects with recovery logic and compiler-agnostic integration |

## Deep-pass notes by project

## `Guribo/UdonVoiceUtils`

- GitHub:
  [Guribo/UdonVoiceUtils](https://github.com/Guribo/UdonVoiceUtils)
- What it is:
  a VCC-friendly package of scripts and prefabs for changing VRChat player
  audio in real time through microphones, audio zones, occlusion, reverb,
  privacy channels, and runtime configuration models.
- Why it matters:
  it is the clearest donor in this wave for
  `world-side voice control modeled as a reusable system instead of one-off triggers`.
- Interesting ideas:
  treat voice behavior as a composable override system; separate local
  configuration, synced master defaults, and per-player override lists; allow
  world creators to build rooms, doors, backstage areas, and mic zones without
  writing a new audio system from scratch.
- Interesting implementation choices:
  `Runtime/Core/PlayerAudioController.cs`
  acts as the central controller with override pools, ignored players,
  configuration models, and per-frame player updates; `PlayerAudioOverride.cs`
  models priority, occlusion, directionality, reverb, avatar audio, and
  privacy channels as one override object rather than as many disconnected
  scripts.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the package is broad enough that a future pass could still go deeper into
  specific feature-prefab lines.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `world voice-state controller with priority and zone composition`
  donor.

## `Xytabich/UNet`

- GitHub:
  [Xytabich/UNet](https://github.com/Xytabich/UNet)
- What it is:
  a simple but explicit Udon networking layer that provides reliable binary
  transfer, strict sequencing, target routing, and helper serialization types.
- Why it matters:
  it is the clearest donor in this wave for
  `transport abstraction built on top of manual-sync Udon data surfaces`.
- Interesting ideas:
  model networking as `Connection`, `Socket`, `NetworkManager`, and
  `NetworkInterface` rather than hiding everything in one sync behaviour; use
  a synced byte array as the delivery surface while still exposing sequence and
  target semantics to users of the transport.
- Interesting implementation choices:
  `UNet/Connection.cs`
  packages data for manual sync through `OnPreSerialization` and
  `OnDeserialization`; `UNet/NetworkInterface.cs`
  exposes a focused public API for events, message sizing, cancellation, and
  send targets while leaving packet assembly and delivery tracking in the
  manager and socket layers.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  the underlying speed limits and packet constraints are still shaped by Udon
  sync realities, so it is a transport donor more than a high-performance
  network stack.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `binary message bus over creator-world sync primitives`
  donor.

## `Superbstingray/UdonPlayerPlatformHook`

- GitHub:
  [Superbstingray/UdonPlayerPlatformHook](https://github.com/Superbstingray/UdonPlayerPlatformHook)
- What it is:
  a drag-and-drop prefab that makes local players follow moving colliders as if
  they were parented to them, including rotation and momentum handling.
- Why it matters:
  it is the clearest narrow donor in this wave for
  `moving-platform correction as a focused world-runtime utility`.
- Interesting ideas:
  keep the solution prefab-shaped and scene-root simple; detect valid platforms
  by spherecasts; pause relocation logic while menus are open; preserve
  velocity when unhooking so jumping off a moving platform still feels right.
- Interesting implementation choices:
  `UdonPlatformHook.cs`
  uses a moving `hook` transform plus a box-collider override, repeated
  spherecasts, player teleporting to offset positions, menu-open heuristics,
  and optional velocity inheritance to smooth the gap between world movement
  and the VRChat player controller.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  it is intentionally narrow and somewhat brute-force, but that smallness is
  also why it is reusable.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `moving-platform or moving-reference-frame helper`
  donor.

## `CyanLaser/CyanPlayerObjectPool`

- GitHub:
  [CyanLaser/CyanPlayerObjectPool](https://github.com/CyanLaser/CyanPlayerObjectPool)
- What it is:
  a VRChat system that assigns a unique pooled object to every player and keeps
  the assignment stable through joins, leaves, and master changes.
- Why it matters:
  it is the clearest donor in this wave for
  `per-player object anchoring as reusable infrastructure`.
- Interesting ideas:
  keep per-player world state outside the player object itself by assigning a
  stable pooled object; support UdonGraph, UdonSharp, and CyanTrigger through a
  common event contract; include editor helpers that make prefab authorship
  easier, not just runtime logic.
- Interesting implementation choices:
  the README documents a synced int-array assignment model with master-crash
  verification and deterministic ordering; `Runtime/CyanPoolSetupHelper.cs`
  auto-spawns or resizes pooled objects in the editor so prefab authors do not
  hand-manage pool counts.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the core runtime is partly mediated through prefabs and Udon assets, so the
  README and setup helper are unusually important for understanding the design.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `stable per-user world object assignment`
  donor.

## Main takeaways from Wave 89

- `VRChat world runtime infrastructure`
  now splits more cleanly into:
  - voice-state controllers;
  - byte-level transport layers;
  - locomotion correction helpers;
  - per-player object assignment infrastructure.
- The strongest lesson from this wave is that
  `world-runtime donors`
  become much more reusable when they expose ownership, update cadence, and
  per-player state explicitly.
- Another strong lesson is that
  `narrow infrastructure helpers`
  can be just as valuable as broad packages when they solve one stubborn world
  runtime problem cleanly.

## Reusable methods clarified by this wave

- `World voice controller with composable player override lists, privacy channels, and occlusion models`
- `Reliable byte-array message bus over manual-sync Udon connections`
- `Moving-platform hook that keeps local players aligned to moving colliders with menu-aware pause and velocity inheritance`
- `Per-player pooled object assignment with master verification and compiler-agnostic integration contract`

## Recommended next moves after this wave

1. Keep `UdonVoiceUtils` visible as one of the strongest
   `world voice-state system`
   donors in the creator-world branch.
2. Treat `UNet` as a strong
   `lower-layer message transport`
   donor rather than as a full application product.
3. Use `UdonPlayerPlatformHook` as a focused lower-bound reference whenever a
   world-runtime problem is really about moving frames of reference.
4. Keep `CyanPlayerObjectPool` visible as reusable per-player infrastructure,
   especially when future work touches scoreboards, player anchors, or
   stateful world gadgets.
