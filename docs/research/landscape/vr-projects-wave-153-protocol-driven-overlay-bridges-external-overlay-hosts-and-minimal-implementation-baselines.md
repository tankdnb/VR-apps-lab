# VR Projects Wave 153: Protocol-Driven Overlay Bridges, External Overlay Hosts, and Minimal Implementation Baselines

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 153 studies projects that keep overlay work small by separating the
producer from the surface. Some send OSC avatar state into a SteamVR overlay,
some send WebSocket notification envelopes into XSOverlay, and others teach the
minimum OpenVR lifecycle or texture submission path.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `MeroFune/GOpy` | OSC-to-overlay bridges | Strong concept donor, medium code donor |
| `beareogaming/BD-XSOverlay-notify` | External overlay-host protocol plugins | Strong protocol donor, host-specific |
| `OrangeJuicy69/VRC-NexusChat` | VRChat OSC companion references | Source-light product reference |
| `kurohuku7/zenn-overlay-tutorial` | Overlay onboarding and lifecycle references | Documentation donor |
| `emymin/EmyOverlay` | Minimal C++ overlay render baselines | Medium code donor |
| `Marlamin/VROverlayTest` | Minimal C# OpenVR texture baselines | Medium-low code donor |

## `MeroFune/GOpy`

- Interesting idea:
  read VRChat Avatar 3.0 gesture parameters over OSC and show left/right hand
  gesture icons as SteamVR overlays.
- Code donor value:
  medium. The implementation is compact enough to study end-to-end.
- Product reference value:
  medium. It shows how a companion utility can make hidden avatar state visible
  in-headset.
- What to inspect next:
  compare OSC parameter mapping with broader VRChat companion and avatar-facing
  overlay families.
- Architecture pattern:
  Python app initializes OpenVR as an overlay app, starts an AsyncIO OSC UDP
  server, maps `/avatar/parameters/Gesture*` messages to left/right gesture
  IDs, creates HMD-relative overlay icons, updates image/color/alpha, and fades
  icons after inactivity.
- Reusable method:
  OSC parameter to HMD-relative overlay icon bridge with disable filters and
  configurable icon placement.
- Caveats:
  depends on pyopenvr packaging, assumes simple integer gesture parameters, and
  is most useful as a bridge pattern rather than a complete product shell.

## `beareogaming/BD-XSOverlay-notify`

- Interesting idea:
  use an existing overlay host as the render target by sending Discord
  notifications to XSOverlay through its WebSocket API.
- Code donor value:
  medium-high for protocol handling, queueing, filtering, and reconnect policy.
- Product reference value:
  high. It demonstrates a useful split: app/plugin owns event filtering while
  XSOverlay owns VR presentation.
- What to inspect next:
  compare the XSOverlay notification envelope with other local overlay-host
  protocols before designing a generic notification sidecar.
- Architecture pattern:
  BetterDiscord plugin hooks message events, filters DMs/mentions/guilds,
  sanitizes message content, resolves avatar icons, reconnects to the overlay
  host with exponential backoff and jitter, and sends JSON notification
  commands over WebSocket.
- Reusable method:
  external-app to overlay-host notification contract with queue/drop policy and
  host availability handling.
- Caveats:
  BetterDiscord-specific, host-specific, and the plugin metadata is not strong
  enough to recommend the repo as a product dependency.

## `OrangeJuicy69/VRC-NexusChat`

- Interesting idea:
  a consolidated VRChat OSC companion that plans chatbox messages, local time,
  Spotify/HUD settings, weather, and AFK status from a desktop app.
- Code donor value:
  low. The public repository is source-light and proprietary.
- Product reference value:
  medium. The planned feature grouping is a useful example of VRChat companion
  product framing.
- What to inspect next:
  revisit only if public source appears or licensing changes.
- Architecture pattern:
  product-level only: Electron/React/TypeScript desktop app sending OSC UDP to
  VRChat, reportedly targeting port `9000`.
- Caveats:
  do not treat as a code donor in the current public form.

## `kurohuku7/zenn-overlay-tutorial`

- Interesting idea:
  a tutorial-first path for creating Unity/OpenVR overlay applications.
- Code donor value:
  low-medium. The value is teaching order, lifecycle, and error handling rather
  than a reusable library.
- Product reference value:
  medium. Good onboarding material matters for a public pattern library.
- What to inspect next:
  use as a checklist when writing a minimal overlay onboarding guide for
  `VR-apps-lab`.
- Architecture pattern:
  tutorial explains overlay key/name, `CreateOverlay`, overlay handle
  invalidation, `EVROverlayError` handling, `DestroyOverlay` cleanup before
  OpenVR shutdown, and SteamVR Overlay Viewer inspection.
- Caveats:
  tutorial/reference only.

## `emymin/EmyOverlay`

- Interesting idea:
  a small C++ OpenGL/OpenVR/ImGui overlay skeleton that submits an offscreen
  framebuffer texture to SteamVR.
- Code donor value:
  medium. It clearly exposes the render-to-texture and controller-ray input
  path.
- Product reference value:
  medium-low. More useful as a technical baseline than a product.
- What to inspect next:
  compare with C#, Unity, and browser-backed overlay starters to pick the
  simplest future implementation path.
- Architecture pattern:
  an `OpenGLOverlay` owns a framebuffer, renders ImGui into it, submits the GL
  texture via `SetTexture`, and an overlay manager maps controller rays and
  trigger state into overlay mouse coordinates.
- Reusable method:
  offscreen OpenGL/ImGui overlay texture plus controller-ray mouse emulation.
- Caveats:
  early skeleton with hardcoded controller indices and limited input maturity.

## `Marlamin/VROverlayTest`

- Interesting idea:
  a tiny C#/OpenTK/OpenVR scratchpad shows the minimum GL context and texture
  submission path.
- Code donor value:
  medium-low. Useful as a minimal baseline, not as a polished abstraction.
- Product reference value:
  low-medium.
- What to inspect next:
  compare exact texture upload and overlay transform handling against stronger
  managed-language overlay starters.
- Architecture pattern:
  invisible OpenTK `GameWindow` creates a GL context, OpenVR initializes as an
  overlay app, a non-dashboard overlay is created, mouse input is enabled, an
  image is loaded into an OpenGL texture, and a `Texture_t` is submitted.
- Reusable method:
  smallest C# GL texture submission baseline for OpenVR overlays.
- Caveats:
  hardcoded tracked device index, older wrappers, and missing sample image in
  the public snapshot.

## Cross-Project Lessons

- Overlay utilities do not always need to own rendering and event production.
  A plugin can produce events, a host can render, and a protocol can keep them
  decoupled.
- A good minimal overlay baseline should show lifecycle, cleanup, texture
  submission, transform placement, visibility handling, and input mapping.
- Source-light companion apps can still clarify product directions, but they
  should not be promoted as code donors.
- OSC and WebSocket bridge utilities should document payload shape and failure
  policy as first-class reusable knowledge.

## Reusable Methods Extracted

- OSC parameter to HMD-relative overlay icon bridge.
- External overlay-host notification WebSocket envelope with queue/backoff/drop
  behavior.
- Tutorial-grade OpenVR overlay lifecycle checklist.
- Offscreen OpenGL/ImGui texture overlay plus controller-ray mouse emulation.
- Minimal C# OpenVR GL texture submission baseline.

## Follow-Up Backlog

- Produce an overlay-host protocol matrix across XSOverlay, OSC, WebSocket,
  browser panels, and native OpenVR texture submission.
- Separate future overlay docs into `renderer`, `host`, `bridge`, and
  `tutorial baseline` categories.
- Keep `VRC-NexusChat` in the source-light lane unless public implementation
  detail appears.
