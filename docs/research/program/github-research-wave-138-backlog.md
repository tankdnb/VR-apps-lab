# GitHub Research Wave 138 Backlog

- Date: `2026-06-05`
- Scope: networked/social XR frameworks, room clients, spatial web clients,
  multi-user state substrates, and collaboration infrastructure.

## Completed in this wave

- Studied `UCL-VR/ubiq` as a research-friendly Unity/browser/Node networking
  substrate with room server, room client, network scene, peer connections,
  avatars, voice, shared blobs, sync models, and component statistics.
- Studied `mozilla/hubs` as a mature WebXR social room client with Phoenix
  room channel, presence, permissions, media/object actions, recording/raise
  hand/typing events, and bitECS networked components.
- Studied `janusvr/janusweb` as a historical spatial-web client with generated
  viewer frames, declarative room snippets, chat, room hash subscriptions, and
  binary WebSocket room connection lifecycle.
- Studied `vrsys/vrsys-core` as a Unity framework composition reference with
  Netcode/XRI/Meta Avatar/user-spawner prefabs and collocation settings, but
  weaker source-level extraction in the current pass.

## Reuse candidates

- `ubiq` is the strongest research-lab networking donor.
- `hubs` is the strongest WebXR room/permissions/media reference.
- `janusweb` is a useful spatial-web embedding and declarative-world reference.
- `vrsys-core` is a Unity package/prefab composition reference but needs a
  targeted script/package pass before deeper reuse.

## Follow-up backlog

1. Extract a room/presence/permission checklist for collaborative VR utilities.
2. Compare Ubiq network scenes with Hubs ECS networked components.
3. Compare declarative room/viewer embedding in JanusWeb with browser shell and
   WebXR media/viewer waves.
4. Revisit `vrsys-core` only if Unity Netcode/XRI/Meta Avatar composition
   becomes an active branch.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
