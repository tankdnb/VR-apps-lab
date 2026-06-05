# VR Projects Wave 135: Focused Overlay Micro-Surfaces, QR/Media/Game HUDs, and OCR-Assisted Workflow Panels

- Date: `2026-06-05`
- Goal: study focused overlay micro-surfaces and situational VR workflow
  helpers: dashboard tabs, QR scanners, media remotes, game HUDs, and OCR-
  assisted item panels.

## Why this wave exists

Focused overlays are often the best product references for `VR-apps-lab`: one
surface, one strong value, and clear runtime boundaries. This wave studies both
real OpenVR/SteamVR overlays and ordinary desktop windows designed to be
captured into VR by tools like Desktop+.

## Better workflow used in this wave

1. searched by SteamVR dashboard, OpenVR QR, VR media remote, game HUD, OCR
   overlay, and VRChat OSC overlay families;
2. deduplicated against Desktop+, OVR Toolkit, XSOverlay, VRChat OSC, media,
   and overlay-first waves;
3. froze a mixed shortlist of strong donors, micro-utilities, and weak
   candidates;
4. inspected local-only source clones;
5. separated native overlay donors from window-captured and OBS/browser
   product references;
6. extracted methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `MetroTS/AdressableOverlaySteamVR` | Early status-dashboard overlay sketch |
| `haolink/VRCOSCAvatarScaleOverlay` | Unity SteamVR dashboard overlay plus VRChat OSC control |
| `Psychpsyo/VR-QR-Overlay` | OpenVR mirror-texture QR scanner with controller overlay feedback |
| `Rycia/OVR-Deck` | Weak candidate with no reusable source in current clone |
| `ToxicOrca/VR-Music-Remote` | Crop-friendly standard window media controller for Desktop+ |
| `DavidDriessen/EchoVR-Overlay` | Browser/OBS game telemetry HUD reference |
| `etiennechabert/ez-wishlist-overlay` | Strong Rust desktop plus SteamVR overlay with OCR, persistence, and actions |

## Deep-pass notes by project

## `MetroTS/AdressableOverlaySteamVR`

- GitHub:
  [MetroTS/AdressableOverlaySteamVR](https://github.com/MetroTS/AdressableOverlaySteamVR)
- What it is:
  an early WinForms/OpenVR status-dashboard project sketch.
- Interesting idea:
  unify common SteamVR helper surfaces such as controller battery, HMD status,
  FPS, playtime, and search into one configurable utility instead of spawning
  many tiny programs.
- Code-level notes:
  `ovrinit.cs` initializes OpenVR as `VRApplication_Overlay` and checks
  `OpenVR.Overlay`. `Program.cs` initializes VR, runs a WinForms `AOVR` form,
  then shuts down OpenVR. `AOVR.Designer.cs` defines a compact UI with HMD and
  controller images, battery labels, playtime, FPS, and a search button.
- Code donor value:
  low-medium; useful as a sketch but runtime overlay submission is incomplete.
- Product reference value:
  medium for status-dashboard grouping.
- Caveats:
  early/incomplete implementation.
- What to inspect next:
  compare with mature dashboard overlays before using as a donor.

## `haolink/VRCOSCAvatarScaleOverlay`

- GitHub:
  [haolink/VRCOSCAvatarScaleOverlay](https://github.com/haolink/VRCOSCAvatarScaleOverlay)
- What it is:
  a Unity SteamVR dashboard overlay for scaling a VRChat avatar through OSC.
- Interesting idea:
  use a normal Unity UI as the authoring surface, render it to a SteamVR
  dashboard overlay, and bridge user actions into VRChat OSC parameters.
- Code-level notes:
  `DashboardOverlay.cs` creates a SteamVR dashboard overlay and thumbnail,
  renders a `RenderTexture`, flips texture bounds, sets metric size, maps
  overlay mouse scale, sets mouse input, raycasts Unity UI with
  `GraphicRaycaster`, forwards hover/click events through `ExecuteEvents`,
  handles `VREvent_KeyboardClosed`, and copies OpenVR keyboard text back into
  Unity input fields. `OpenVRUtils.cs` wraps autolaunch manifest registration,
  overlay texture submission, keyboard show/copy-buffer behavior, and cached
  app registration. `OscManagement.cs` registers OSCQuery endpoints, listens on
  UDP, raises avatar/eye-height/scale events on Unity's main thread, and sends
  float values to VRChat. `AvatarScaler.cs` tracks current avatar, default
  height, eye-height limits, scaling allowed state, and sends
  `/avatar/parameters/EyeHeightAsMeters`. `GradualScaleWorker.cs` interpolates
  height logarithmically at 30 Hz with min/max gates and main-thread callbacks.
- Code donor value:
  very high for Unity dashboard overlay, event forwarding, keyboard handling,
  autolaunch, and OSC integration.
- Product reference value:
  high for in-dashboard VRChat utility panels.
- Caveats:
  Windows/SteamVR/Unity focused; README notes Monado/WiVrN are not supported.
- What to inspect next:
  extract a Unity dashboard overlay skeleton with render texture, mouse, and
  keyboard paths.

## `Psychpsyo/VR-QR-Overlay`

- GitHub:
  [Psychpsyo/VR-QR-Overlay](https://github.com/Psychpsyo/VR-QR-Overlay)
- What it is:
  a C++ SteamVR overlay that scans QR codes in VR by reading what the user is
  looking at.
- Interesting idea:
  situational recognition can use the compositor mirror texture as input, then
  show a tiny controller-relative result overlay with haptic confirmation.
- Code-level notes:
  `Main.cpp` initializes OpenGL/SDL, OpenVR, textures, VR input, and `quirc`,
  then loops while running. `detectQR()` calls `VRCompositor()->GetMirrorTextureGL`
  for the left eye, reads pixels with `glGetTextureImage`, downsamples to
  grayscale, runs `quirc`, and stores decoded payload. `qrFound()` positions an
  overlay relative to the right controller, shows an image result, and triggers
  haptics through OpenVR input. `InitFunctions.cpp` creates the overlay, sets
  width, applies controller-relative transform, initializes SDL/GLEW, resolves
  action handles, and sizes the QR buffer from HMD mirror texture dimensions.
- Code donor value:
  high for mirror-texture capture plus recognition plus overlay feedback.
- Product reference value:
  high for situational micro-tools.
- Caveats:
  old/rough code, temporary file path in overlay display, and limited UI polish.
- What to inspect next:
  compare with OCR capture patterns in `ez-wishlist-overlay`.

## `Rycia/OVR-Deck`

- GitHub:
  [Rycia/OVR-Deck](https://github.com/Rycia/OVR-Deck)
- What it is:
  a weak candidate in the current clone.
- Interesting idea:
  no reusable idea extracted from current source.
- Code-level notes:
  local clone contained only README/license metadata in this pass.
- Code donor value:
  none in the current clone.
- Product reference value:
  none in the current clone.
- Caveats:
  keep rejected unless source appears later.
- What to inspect next:
  revisit only if future contents become available.

## `ToxicOrca/VR-Music-Remote`

- GitHub:
  [ToxicOrca/VR-Music-Remote](https://github.com/ToxicOrca/VR-Music-Remote)
- What it is:
  a lightweight Windows media-controller window designed to be captured into VR
  through Desktop+.
- Interesting idea:
  not every VR overlay needs native OpenVR APIs; a normal, crop-friendly,
  always-on-top window can be an excellent VR HUD surface.
- Code-level notes:
  `vr_music_remote.py` uses Tkinter with a normal selectable window,
  topmost flag, hidden cursor, album art, large buttons, and a slow marquee
  tuned for VR readability. It reads now-playing metadata and thumbnail through
  Windows Global Media Session, updates the UI from an asyncio worker thread,
  and sends global media/volume key events through Win32 `keybd_event`.
- Code donor value:
  medium for window-captured HUD UX and async media-session plumbing.
- Product reference value:
  high for small utility surfaces meant to be placed by Desktop+ or similar.
- Caveats:
  Windows-only and not a native SteamVR overlay.
- What to inspect next:
  compare with native overlay music controls if media-control work becomes
  active.

## `DavidDriessen/EchoVR-Overlay`

- GitHub:
  [DavidDriessen/EchoVR-Overlay](https://github.com/DavidDriessen/EchoVR-Overlay)
- What it is:
  a browser/OBS overlay for Echo VR telemetry.
- Interesting idea:
  game telemetry HUDs can be simple browser surfaces that poll a local game API
  and show/hide components by game state.
- Code-level notes:
  `overlayServer.js` proxies `/session` from `127.0.0.1:6721` and local dev
  assets through Express. `App.vue` polls session data, stores game state,
  toggles HUD/stats/goal visibility on state transitions, and renders header,
  players, team stats, score event, minimap, and player-state components.
  `MiniMap.vue` maps 3D coordinates into 2D CSS positions over full/inner map
  assets and supports corner placement.
- Code donor value:
  medium for local API polling and HUD state management.
- Product reference value:
  high for telemetry overlays and streaming/operator panels.
- Caveats:
  OBS/browser overlay, not in-headset overlay by default.
- What to inspect next:
  reuse as a game-state HUD reference if simulator/telemetry panels become
  active.

## `etiennechabert/ez-wishlist-overlay`

- GitHub:
  [etiennechabert/ez-wishlist-overlay](https://github.com/etiennechabert/ez-wishlist-overlay)
- What it is:
  a Rust desktop plus SteamVR overlay for Contractors Showdown: ExfilZone
  item/wishlist tracking, OCR-assisted progress reading, and VR overlay
  interaction.
- Interesting idea:
  combine a full desktop planning app, a glanceable in-headset overlay, VR
  controller clicks, OCR feedback, domain data, settings, persistence, and
  anti-cheat-safe mirror-texture capture without touching the game process.
- Code-level notes:
  `runtime.rs` owns the VR worker thread, status states, capture queue,
  auto-capture flag, box-scan mode, and OCR feedback channel. `overlay.rs`
  initializes OpenVR as an overlay app, creates the wishlist overlay and a
  second head-locked OCR feedback overlay, sets widths/alpha/visibility,
  anchors the wishlist in world space, reads HMD pitch, enables interaction
  through `openvr_sys`, loads action bindings, and handles raw RGBA submission.
  `input.rs` converts overlay texcoords to pixels, hit-tests cached cell rects,
  debounces item clicks, cycles counts, and emits haptic outcomes. `render.rs`
  CPU-rasterizes the wishlist grid with icons, progress chips, pinned accents,
  hover highlights, and hit rectangles. `capture.rs` reads SteamVR compositor
  mirror textures through D3D11/openvr_sys, avoids stale-frame capture with a
  freshness poll, and returns in-memory images for OCR. `ocr_render.rs`
  rasterizes a head-locked OCR feedback card. `ocr/pipeline.rs` runs
  image-to-words, panel detection, strict upgrade matching, digit template
  matching, and safe partial updates. `box_scan.rs` merges scroll captures by
  row uniqueness. `settings.rs` and `persist.rs` model durable user settings,
  state, overrides, atomic writes, corrupt-file backup, and debug-directory
  cleanup.
- Code donor value:
  very high for SteamVR overlay architecture, OCR pipeline, action input,
  persistence, settings, and domain workflow.
- Product reference value:
  very high for focused workflow overlays and anti-cheat-safe design framing.
- Caveats:
  large domain-specific app; reuse should happen by extracting patterns, not by
  copying the whole application.
- What to inspect next:
  create a reuse-plan if OCR-assisted checklist/workflow panels become active.

## Cross-project synthesis

Reusable lessons:

- A small overlay should declare its host model: native SteamVR overlay,
  dashboard overlay, browser/OBS overlay, or standard window captured by an
  overlay host.
- Unity dashboard overlays need explicit render-texture, mouse scale, event
  forwarding, keyboard, and autolaunch handling.
- Mirror textures can power situational recognition tools such as QR or OCR.
- A normal topmost desktop window is sometimes the simplest reusable overlay
  surface when Desktop+ handles placement/cropping.
- Game telemetry HUDs need state-driven visibility more than complex graphics.
- OCR-assisted workflow overlays need persistence, feedback cards, debug
  artifacts, and a clear anti-cheat/support boundary.

Best donor candidates:

- `ez-wishlist-overlay` for overlay/OCR/persistence/domain workflow.
- `VRCOSCAvatarScaleOverlay` for Unity dashboard overlay plus OSC.
- `VR-QR-Overlay` for mirror-texture recognition micro-tooling.
- `VR-Music-Remote` for crop-friendly window-captured HUDs.
- `EchoVR-Overlay` for browser/telemetry HUD state management.

## Reuse implications for `VR-apps-lab`

This wave suggests a `focused overlay micro-surfaces` branch:

- native SteamVR overlay + OCR workflow panel;
- Unity dashboard overlay skeleton;
- mirror-texture recognition helper;
- crop-friendly standard-window utility template;
- browser telemetry HUD template;
- overlay-host decision checklist.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were used only for code reading and are local-only.
