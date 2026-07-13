# Wave 451: VR remote desktop and desktop streaming bridges

## Theme

This wave studies desktop/display streaming into VR or browser surfaces. The
reusable value is capture/encode/transport/input architecture, consent/security
boundaries, and fallback labels for remote-control precision.

## Shortlist

| Project | Status | Family placement |
|---|---|---|
| `player1537/vrdp` | New study | WebRTC/WebVR remote desktop viewer |
| `gonsp/DesktopVR` | New study | Cardboard/Leap Motion remote desktop controller |
| `nextime/bsdrX` | New study | Bigscreen remote desktop agent |
| `dolit/DRTStreamer` | New study | Browser-based low-latency desktop/application streamer |

## Project notes

### `player1537/vrdp`

- Interesting idea:
  a minimal WebRTC/WebVR remote desktop viewer that aims to place virtual
  monitors into a calming VR environment.
- Code donor value:
  moderate for the small WebRTC/WebVR proof-of-concept boundary.
- Product reference value:
  useful lower-bound for browser-first remote desktop in VR.
- Source evidence:
  README describes simple remote desktop viewing using WebRTC and WebVR, Docker
  server on port 8800, localhost behavior, and HTTPS requirement for remote
  WebRTC use.
- Reusable core:
  capture server, WebRTC session, browser headset viewer, HTTPS/localhost gate,
  virtual monitor placement, and remote-control caveat.
- What not to copy:
  old WebVR assumptions without WebXR migration.
- Method catalog action:
  creates `VR remote desktop streaming bridge`.
- What to inspect next:
  inspect signaling and display placement in more maintained WebXR equivalents.

### `gonsp/DesktopVR`

- Interesting idea:
  a Cardboard-era remote desktop controller that pairs VR viewing with Leap
  Motion/control input assumptions.
- Code donor value:
  low-to-moderate as a historical reference for remote desktop plus hand input.
- Product reference value:
  useful as a reminder that desktop-in-VR needs both display transport and input
  ergonomics.
- Reusable core:
  remote desktop screen, mobile VR viewer, hand/controller input bridge, and
  legacy-device caveat.
- What not to copy:
  Cardboard-era dependencies or Leap-only assumptions.
- Method catalog action:
  comparison node for `VR remote desktop streaming bridge`.
- What to inspect next:
  compare with modern hand/controller input injection approaches.

### `nextime/bsdrX`

- Interesting idea:
  a Bigscreen remote desktop agent with desktop/video/audio capture, LAN/cloud
  streaming modes, input decode/injection, Web UI control, room/mic handling,
  Android port notes, terminal source, screen blanking, and replay/debug hooks.
- Code donor value:
  high for architecture boundaries: capture, encode, transport, input decode,
  injectors, web control, source selection, terminal source, screenshot/vision,
  and Android MediaProjection adaptation.
- Product reference value:
  very strong for documenting desktop streaming as a multi-service utility, not
  a single "screen texture" feature.
- Source evidence:
  headers expose `agentlib`, `app`, `protocol`, `input`, `video`, `term`,
  `webui`, `screenblank`, `screenshot`, `voice`, and capture options. Android
  notes describe MediaProjection, MediaCodec, AAudio, AccessibilityService input
  fallback, JNI bridge, ring buffer, and consent/platform limitations.
- Reusable core:
  session config, capture source, encoder, RTP/WebRTC-ish transport,
  DataChannel input schema, injector backend, web control API, stream status,
  audio/mic routing, privacy screen blanking, replay capture, and platform
  permission caveats.
- What not to copy:
  reverse-engineered Bigscreen protocol details, API keys, packet captures, or
  private service assumptions.
- Method catalog action:
  creates `VR remote desktop streaming bridge`.
- What to inspect next:
  extract a provider-neutral capture/encode/input injection architecture.

### `dolit/DRTStreamer`

- Interesting idea:
  a commercial/open repo wrapper that frames real-time desktop/application/3D
  engine streaming to browser clients, with remote interaction and management
  platform concepts.
- Code donor value:
  low from public source, but useful for product vocabulary around application
  streaming, browser client, custom resolution, off-screen rendering, and
  management/routing.
- Product reference value:
  useful for cloud VR/desktop streaming feature taxonomy.
- Source evidence:
  README lists streaming desktop or applications to web pages, low-latency
  remote interaction, off-screen rendering for Unity/Unreal/WebGL, custom
  resolution, H.265, bidirectional custom messages, management platform, and
  partial screen capture.
- Reusable core:
  application descriptor, capture mode, browser endpoint, input channel,
  resolution profile, codec capability, routing/management metadata, and
  bidirectional message channel.
- What not to copy:
  proprietary latency claims or closed streaming internals.
- Method catalog action:
  comparison/product node for `VR remote desktop streaming bridge`.
- What to inspect next:
  compare with CloudXR, WebRTC, Virtual Desktop, and Bigscreen workflows.

## Synthesis

Desktop-in-VR is a system pattern:

- source selection
- capture and encode
- transport/signaling
- display placement
- input return path
- audio/mic routing
- permissions and privacy
- status and recovery

## Follow-up backlog

- Define a provider-neutral remote desktop bridge schema.
- Compare WebRTC/WebXR, Bigscreen, CloudXR, Virtual Desktop, and browser-only
  streaming paths.
- Document input precision and consent limitations as first-class fields.
