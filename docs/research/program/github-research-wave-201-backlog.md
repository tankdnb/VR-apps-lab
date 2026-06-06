# GitHub Research Wave 201 Backlog

- Date: `2026-06-06`
- Theme: `Networked-AFrame adapters, persistence, media, and Unity-client variants`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for Networked-AFrame adapters, media examples,
  persistence helpers, avatar validation shells, and Unity-client variants.
- `Done` Dedupe against prior WebXR room, Networked-AFrame, A-Frame component,
  and multiplayer waves.
- `Done` Freeze a shortlist that covers adapter, persistence, media, and
  cross-runtime room lessons.

## Source Sync

- `Done` Confirm `naf-firebase-adapter` in local-only cache.
- `Done` Confirm `naf-janus-adapter` in local-only cache.
- `Done` Confirm `naf-valid-avatars` in local-only cache.
- `Done` Confirm `networked-aframe-unity-client` in local-only cache.
- `Done` Confirm `networked-aframe-synced-video-example` in local-only cache.
- `Done` Confirm `naf-persist` in local-only cache.
- `Done` Confirm `naf-entity-saver` in local-only cache.
- `Done` Confirm `networked-resonance-audio` in local-only cache.

## Code Reading

- `Done` Inspect Firebase room/user lifecycle, `onDisconnect`, WebRTC peer
  setup, timestamp tie-breaker, and guaranteed Firebase messages in
  `naf-firebase-adapter`.
- `Done` Inspect Janus WebSocket session, reliable/unreliable transports,
  media streams, reconnect jitter, frozen updates, block/kick, and join-token
  behavior in `naf-janus-adapter`.
- `Done` Inspect avatar picker, entry gate, mic/screen/camera share controls,
  presence store, users panel, and chat UI in `naf-valid-avatars`.
- `Done` Inspect Socket.IO EasyRTC auth/join protocol, `NetworkedEntity`
  ownership/schema parsing, interpolation, and Unity component mapping in
  `networked-aframe-unity-client`.
- `Done` Inspect networked singleton video state, owner-gated ticks, pause/time
  sync, and time-slop correction in `networked-aframe-synced-video-example`.
- `Done` Inspect PouchDB entity serialization, DOM/id/NAF-id options, remote
  fetch toggles, local preference, and update cadence in `naf-persist`.
- `Done` Inspect leave-time preservation by stripping `networked-remote`,
  reattaching local `networked`, and scene append behavior in
  `naf-entity-saver`.
- `Done` Inspect media stream owner lookup, adapter `getMediaStream`, Three
  PositionalAudio, Resonance Audio binding, and browser workaround in
  `networked-resonance-audio`.

## Integration

- `Done` Create Wave 201 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for adapter contracts and shared-room
  persistence/ownership.
- `Next` Build a Networked-AFrame adapter matrix covering reliable transport,
  media streams, reconnect, persistence, ownership transfer, and cross-runtime
  clients.
