# GitHub Research Wave 150 Plan

- Date: `2026-06-05`
- Goal: study WebRTC remote rendering, WebXR streaming, and bidirectional
  input/control channels as reusable patterns for remote VR utility surfaces.

## Why this wave exists

Several useful VR utilities do not need to run heavy rendering inside the
headset browser or companion app. They can stream pixels from Unity or Unreal
and return headset pose, controller input, or browser events over data
channels. This wave studies that split as a reusable architecture pattern.

## Search scope

Primary search directions:

- WebXR to Unity/Unreal streaming;
- Unity Render Streaming and WebRTC primitives;
- Unreal Pixel Streaming browser clients;
- signaling, matchmaking, and deployment shells;
- bidirectional data channel protocols;
- input remoting, pose streaming, and remote controller events.

## Frozen shortlist for code-level study

- `FusedVR/VRStreaming`
- `Unity-Technologies/UnityRenderStreaming`
- `Unity-Technologies/com.unity.webrtc`
- `EpicGamesExt/PixelStreamingInfrastructure`
- `Azure/Unreal-Pixel-Streaming`

## Execution model

### Step 1: Search and deduplicate

- search by WebXR streaming, Unity Render Streaming VR, Unity WebRTC data
  channels, Unreal Pixel Streaming WebXR, and signaling/matchmaker families;
- deduplicate against existing media playback, engine export, and WebXR
  framework waves.

### Step 2: Freeze the shortlist

- include one focused WebXR-to-Unity VR streaming prototype, Unity's higher
  render-streaming layer, Unity's low-level WebRTC package, Unreal's current
  Pixel Streaming infrastructure, and Azure's deployment-oriented UE signaling
  shell.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/`;
- keep all source clones local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- video sender/receiver boundaries;
- pose, button, axis, display, and session-mode data channel messages;
- peer connection and negotiation wrappers;
- input remoting protocols;
- signaling managers and deployment shells;
- WebXR video projection and selective HMD/eye pose messages.

### Step 5: Promote findings into repository structure

Update Wave 150 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when remote rendering, WebXR streaming, and data-channel
control patterns are documented as reusable architecture references for
future `VR-apps-lab` remote utility surfaces.
