# VR Projects Wave 440: Unity VR Multiplayer Baselines and Room-State Micro-Loops

Date: 2026-07-13

Theme: source-available Unity VR multiplayer baselines that show room/session
setup, networked avatar or hand glue, and small shared-object state loops.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `TomH1004/unity-vr-multiplayer-fusion-convai` | Unity VR multiplayer broad-stack baseline | Code-level pass |
| `italovisconti/VR-Local-MP` | LAN retrofit of Unity VR Multiplayer Template | Code-level pass |
| `Skaper/Multiplayer-VR-ROOM` | Photon room-state micro-loop | Code-level pass |

## Project Notes

### `TomH1004/unity-vr-multiplayer-fusion-convai`

- Interesting idea: compact Unity VR multiplayer starter combining Photon
  Fusion shared mode, Ready Player Me avatars, Final IK, XR Interaction Toolkit,
  and optional ConvAI conversation UI.
- Code donor value: useful donor for a single-scene bootstrapper that labels
  VR initialization, desktop fallback, networking startup, avatar URL defaults,
  and AI UI wiring in one place.
- Product reference value: shows how a future social/debug VR utility could
  expose room name, avatar identity, voice/text AI, and XR runtime status from a
  small operator-facing shell.
- Architecture pattern: `VRMultiplayerBootstrapper` discovers managers,
  subscribes to networking events, chooses room/avatar defaults, and keeps VR
  setup separate from connection flow.
- Reusable method: `VR multiplayer baseline and shared object state loop`.
- UX/product lesson: a multiplayer utility baseline should expose system status
  and fallback behavior instead of assuming headset/network/AI providers are
  always available.
- Caveats: broad sample with many external dependencies, low public activity,
  and no verification beyond source reading.
- Source evidence: README lists Photon Fusion, Ready Player Me, Final IK, XRI,
  and ConvAI; `VRMultiplayerBootstrapper.cs`, `VRHandController.cs`, and
  `VRConvAIUI.cs` show runtime setup, direct input polling, and conversation UI.
- Reusable core: bootstrap state machine, provider labels, room/avatar defaults,
  local XR fallback, hand input facade, and status reporting.
- What not to copy: provider credentials, hard-coded defaults, or the full
  dependency stack as a required architecture.
- Method catalog action: update multiplayer baseline method.
- What to inspect next: the network manager, avatar sync, and ConvAI character
  scripts if this family becomes a prototype branch.

### `italovisconti/VR-Local-MP`

- Interesting idea: modifies Unity's VR Multiplayer Template toward LAN play,
  replacing cloud relay assumptions with local multiplayer/discovery framing.
- Code donor value: useful donor for documenting the migration boundary between
  Netcode, Unity Transport, discovery, imported template assets, and editor
  inspection tools.
- Product reference value: strong reminder that future lab prototypes should
  support local/offline operator sessions when cloud relay is unnecessary.
- Architecture pattern: Unity Netcode/XRI template with local network intent and
  companion editor tools for finding `NetworkObject` and `NetworkBehaviour`
  invocation order.
- Reusable method: `LAN-first multiplayer utility baseline`.
- UX/product lesson: LAN room discovery and local host/client flows are better
  product defaults for many lab/debug tools than account-bound cloud relay.
- Caveats: large imported Unity template footprint and sample packages make the
  original donor boundary narrower than the repository size suggests.
- Source evidence: README states OpenXR, XRI 3.0.3, Netcode for GameObjects,
  Unity VR Multiplayer Template, and Unity Network Discovery; inspected
  `NetcodeForGameObjectsTools.cs` exposes editor-side network object discovery
  and behavior-order windows.
- Reusable core: LAN transport label, discovery/backfill checklist, Netcode
  object inventory window, and template-pruning notes.
- What not to copy: imported starter assets without provenance or generated
  input action code as original architecture.
- Method catalog action: update multiplayer baseline method with LAN/discovery
  and network-inventory guidance.
- What to inspect next: locate the exact custom discovery/transport scenes and
  separate them from Unity template imports.

### `Skaper/Multiplayer-VR-ROOM`

- Interesting idea: tiny two-chair VR room where chair occupancy is synchronized
  with Photon PUN and XRI teleport/sit anchors.
- Code donor value: strong micro-donor for shared resource state: `Chair.cs`
  listens to sit/stand events and publishes buffered RPC availability to all
  clients.
- Product reference value: good product reference for collaborative VR tools
  where small pieces of state, not full gameplay, must remain synchronized for
  late joiners.
- Architecture pattern: Photon room manager, ScriptableObject room settings,
  network player spawner, network avatar, and interaction-specific shared state
  component.
- Reusable method: `buffered shared-object occupancy loop`.
- UX/product lesson: simple shared objects should have explicit visual
  availability and late-join state, not implicit local-only state.
- Caveats: repository includes large Oculus/sample noise; the donor value is
  concentrated in the TwoChairs room scripts.
- Source evidence: README documents Photon PUN/XRI chair interaction; `Chair.cs`
  uses `[PunRPC] ChairInUse(bool)` with `AllBufferedViaServer`;
  `TeleportationSitAnchor.cs`, `RoomSettings.cs`, and `NetworkPlayerSpawner.cs`
  define the sit event, room options, and player lifecycle.
- Reusable core: room settings asset, join/create flow, network avatar local/remote
  split, interaction event bridge, and buffered shared-state RPC.
- What not to copy: full imported Oculus folders or scene-specific chair names.
- Method catalog action: update multiplayer baseline method with a
  shared-object state subpattern.
- What to inspect next: compare Photon buffered RPC, Netcode `NetworkVariable`,
  and Mirror SyncVar versions of the same occupancy loop.

## Reusable Pattern Extraction

- Pattern candidate: `VR multiplayer baseline and shared object state loop`.
- Problem solved: many VR utilities need a small shared room/session and a few
  synchronized objects, not a complete social platform.
- Reusable core: provider/transport label, room/session config, local/remote rig
  split, avatar transform sync, shared resource ownership/availability state,
  late-join replay, and diagnostics/status UI.
- Source evidence: Fusion bootstrapper in `unity-vr-multiplayer-fusion-convai`,
  LAN/Netcode framing in `VR-Local-MP`, and Photon buffered chair occupancy in
  `Multiplayer-VR-ROOM`.
- Abstraction boundary: keep the session, avatar, and shared-object loops
  reusable; do not copy provider credentials, imported template bulk, or
  scene-specific interaction art.

## Follow-Up Gaps

- Compare Netcode, Photon, Fusion, Mirror, and Normcore for the same
  micro-utility room-state pattern.
- Define a minimal shared-object checklist for VR utilities: owner, state,
  visual feedback, late join, disconnect, reset, and offline fallback.
