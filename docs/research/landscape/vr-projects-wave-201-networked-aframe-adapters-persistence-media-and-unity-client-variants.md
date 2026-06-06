# VR Projects Wave 201: Networked-AFrame Adapters, Persistence, Media, and Unity-Client Variants

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 201 studies Networked-AFrame's surrounding ecosystem: signaling adapters,
SFU/media transports, room entry UX, persistence helpers, synced media state,
spatial audio streams, and a Unity client that mirrors NAF entity concepts. The
reuse value is the adapter contract and the shared-room semantics around
ownership, persistence, media, and reconnect behavior.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `networked-aframe/naf-firebase-adapter` | Firebase signaling and guaranteed transport adapter | Adapter donor |
| `mozilla/naf-janus-adapter` | Janus SFU adapter with media and reconnect behavior | Strong adapter donor |
| `networked-aframe/naf-valid-avatars` | NAF social room shell | Room UX donor |
| `ttravaglini/networked-aframe-unity-client` | Unity client for NAF/EasyRTC concepts | Cross-runtime donor |
| `chenzlabs/networked-aframe-synced-video-example` | Synced video micro-component | Shared media donor |
| `martintribo/naf-persist` | PouchDB entity persistence | Persistence donor |
| `martintribo/naf-entity-saver` | Leave-time entity ownership hack | Ownership caveat reference |
| `AudioGroupCologne/networked-resonance-audio` | NAF media stream to spatial audio | Spatial audio bridge donor |

## `networked-aframe/naf-firebase-adapter`

- Interesting idea:
  Firebase Realtime Database handles room/user presence and guaranteed messages
  while WebRTC peer data channels handle normal traffic.
- Code donor value:
  high for pluggable adapter shape, reliable/unreliable split,
  `onDisconnect().remove()` presence cleanup, peer connection tie-breakers, and
  encoded guaranteed messages.
- Product reference value:
  medium-to-high for backend-swappable WebXR rooms.
- What to inspect next:
  Firebase security rules, stale-room cleanup, modern WebRTC changes, bandwidth
  costs, and audio/video limitations.
- Source evidence:
  `src/index.js`.
- Reusable pattern extraction:
  shared-room adapter with reliable backend channel and peer data channel.
- Reusable core:
  let the adapter own signaling and presence, create peers only after room join,
  pick offerer deterministically, send normal data over peer channels, and keep
  guaranteed/control messages on a reliable backend path.
- Do not copy directly:
  outdated Firebase defaults, no-audio/no-video warning as a product promise,
  or credentials without rules.
- Caveats:
  old but still useful as adapter-contract evidence.

## `mozilla/naf-janus-adapter`

- Interesting idea:
  a Janus SFU adapter gives NAF rooms media streams, reliable and unreliable
  transports, join tokens, block/kick controls, reconnect jitter, and frozen
  update handling.
- Code donor value:
  very high for robust room transport and media stream boundaries.
- Product reference value:
  high for scaling WebXR rooms beyond simple P2P.
- What to inspect next:
  Janus server deployment, minijanus compatibility, reconnection edge cases,
  moderation/auth model, and archival/staleness risk.
- Source evidence:
  `src/index.js`.
- Reusable pattern extraction:
  media-capable room adapter with reconnect and moderation primitives.
- Reusable core:
  keep SFU session state inside the adapter, expose reliable/unreliable
  transports, provide `getMediaStream` and `setMediaStream`, freeze local
  updates during reconnect, apply jittered reconnect attempts, and keep
  block/kick state separate from entity sync.
- Do not copy directly:
  stale Janus protocol assumptions, server deployment shortcuts, or moderation
  without UI.
- Caveats:
  strongest adapter donor in this wave, but operationally heavier.

## `networked-aframe/naf-valid-avatars`

- Interesting idea:
  a full NAF room shell wraps networking with avatar selection, username entry,
  mic and screen/camera share controls, users/chat panels, and presence state.
- Code donor value:
  high for room-entry UX, CDN avatar validation, presence store, Janus media
  buttons, and UI/networking separation.
- Product reference value:
  high for social WebXR onboarding.
- What to inspect next:
  CDN/avatar trust, privacy prompts for media sharing, mobile UI, and adapter
  feature detection.
- Source evidence:
  `src/ui.tsx`, `src/components.js`, and `src/presence.ts`.
- Reusable pattern extraction:
  room entry gate plus presence/avatar shell.
- Reusable core:
  delay connection until scene and user choice are ready, validate avatar list,
  keep username/avatar info in networked player metadata, maintain a presence
  store from network events, and expose media/share controls only when the
  adapter supports them.
- Do not copy directly:
  hardcoded avatar CDN, Janus-specific buttons without feature guards, or
  browser media permission assumptions.
- Caveats:
  strongest UX donor for shared WebXR rooms.

## `ttravaglini/networked-aframe-unity-client`

- Interesting idea:
  a Unity runtime client speaks NAF/EasyRTC-style Socket.IO room messages and
  ports the `networked` entity concept into C#.
- Code donor value:
  high for cross-runtime protocol mapping, EasyRTC auth/join DTOs,
  network-id/template/owner fields, component schema parsing, and interpolation
  from remote state.
- Product reference value:
  high for browser-to-engine shared-room interoperability.
- What to inspect next:
  ownership transfer, reconnect, thread model, schema extensibility,
  timestamp ordering, and modern NAF compatibility.
- Source evidence:
  `Runtime/WsEasyRTCAdapter.cs` and `Runtime/NetworkedEntity.cs`.
- Reusable pattern extraction:
  cross-runtime room client that mirrors browser entity semantics.
- Reusable core:
  model the same room, peer, owner, creator, network id, and schema fields in
  the non-browser client; parse component payloads into engine components; and
  interpolate toward server/owner state without taking ownership accidentally.
- Do not copy directly:
  incomplete TODO ownership behavior, EasyRTC-only assumptions, or Unity thread
  shortcuts.
- Caveats:
  valuable interoperability donor, not a drop-in maintained client.

## `chenzlabs/networked-aframe-synced-video-example`

- Interesting idea:
  a singleton networked component syncs video `paused` and `currentTime` state
  with an owner-gated tick and a time-slop threshold.
- Code donor value:
  high as a compact synced-media state pattern.
- Product reference value:
  medium-to-high for shared media rooms.
- What to inspect next:
  buffering, drift correction, owner transfer, network jitter, and playhead
  authority when multiple users interact.
- Source evidence:
  `public/video-transport.js`.
- Reusable pattern extraction:
  owner-gated shared media state component.
- Reusable core:
  represent only the minimum shared state, let the owner publish state on tick,
  let remote clients adjust only when drift exceeds a tolerance, and keep the
  networked entity separate from the media element.
- Do not copy directly:
  crude time sync as final media architecture or no buffering model.
- Caveats:
  small but very clear micro-pattern.

## `martintribo/naf-persist`

- Interesting idea:
  a PouchDB-backed system serializes A-Frame entities and can identify them by
  DOM id or NAF id while choosing local/remote conflict preference.
- Code donor value:
  high for entity serialization, persistence cadence, `useNafId`,
  `preferLocalOverRemote`, and scene rehydration.
- Product reference value:
  high for local-first shared scene persistence.
- What to inspect next:
  conflicts, ownership, schema filtering, remote database trust, and component
  allowlists.
- Source evidence:
  `src/naf-persist-system.js` and `src/naf-persist-component.js`.
- Reusable pattern extraction:
  shared-room entity persistence layer.
- Reusable core:
  serialize a bounded set of entity attributes/components, store by stable id,
  decide whether local or remote data wins, optionally wait for NAF ids, and
  rehydrate missing entities into the scene.
- Do not copy directly:
  broad component serialization, unresolved ownership conflicts, or untrusted
  remote DB writes.
- Caveats:
  strong persistence donor with clear conflict caveats.

## `martintribo/naf-entity-saver`

- Interesting idea:
  a concise ownership-handoff hack preserves remote networked entities when a
  user leaves by removing `networked-remote`, adding local `networked`, and
  appending the entity back to the scene.
- Code donor value:
  medium as a warning and teaching example for leave-time ownership semantics.
- Product reference value:
  medium for persistence edge cases.
- What to inspect next:
  NAF internals it monkeypatches, ownership race conditions, duplicate ids, and
  conflict resolution.
- Source evidence:
  `src/networkentitiessaver.js`.
- Reusable pattern extraction:
  leave-time entity preservation boundary.
- Reusable core:
  identify entities that should outlive their owner, detach remote ownership
  markers, reattach a local network component, and make the handoff explicit.
- Do not copy directly:
  monkeypatching NAF internals or preserving every remote entity blindly.
- Caveats:
  useful as a caveat/reference more than a mature donor.

## `AudioGroupCologne/networked-resonance-audio`

- Interesting idea:
  a NAF component resolves the network owner, asks the adapter for that media
  stream, and attaches it to Three/Resonance positional audio.
- Code donor value:
  high for adapter media stream to spatial audio bridge.
- Product reference value:
  high for voice/audio-rich WebXR rooms.
- What to inspect next:
  browser media quirks, spatial audio parameter defaults, adapter capability
  checks, muting/privacy controls, and stream lifecycle.
- Source evidence:
  `networked-resonance-audio.js`.
- Reusable pattern extraction:
  remote media stream to spatial audio component.
- Reusable core:
  find the networked owner, request the named media stream from the adapter,
  create a positional audio node, bind panner/resonance parameters, and handle
  browser quirks separately from networking code.
- Do not copy directly:
  browser-specific workarounds as universal behavior or media playback without
  permission/state UI.
- Caveats:
  strongest media-stream bridge donor in the wave.

## Cross-Project Lessons

- A shared-room substrate needs an explicit adapter contract: signaling,
  reliable messages, unreliable pose/state updates, media streams, reconnect,
  and moderation are different concerns.
- Persistence and ownership are inseparable; saving scene state without
  ownership semantics creates duplicates or stale entities.
- Media state is cheaper to sync than media data; sync play/pause/time while
  streams flow through the adapter's media layer.
- Cross-runtime clients need to mirror the same entity/owner/schema language,
  not just open the same socket.
- Social room UX begins before connection: avatar choice, username, media
  consent, presence, and chat are part of the utility surface.

## Reuse Recommendations

1. Use `naf-janus-adapter` as the strongest robust adapter donor.
2. Use `naf-firebase-adapter` for the clean reliable/unreliable split pattern.
3. Use `naf-valid-avatars` for room entry, presence, avatar, and media UX.
4. Use `networked-aframe-unity-client` as a cross-runtime schema reference.
5. Use `naf-persist`, `naf-entity-saver`, and `synced-video-example` to design
   persistence and owner-gated shared media.
6. Use `networked-resonance-audio` as the compact media-to-spatial-audio bridge.

## Follow-Up Gaps

- Build a Networked-AFrame adapter matrix across signaling, reliable data,
  media streams, reconnect, moderation, and deployment cost.
- Extract a persistence/ownership checklist for shared WebXR scenes.
- Compare WebXR room media patterns: sync state, stream transport, spatial
  audio, and screen/camera sharing.
- Decide whether `VR-apps-lab` should keep a generic shared-room adapter
  contract independent of A-Frame.
