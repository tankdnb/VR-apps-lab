# VR Projects Wave 234: XR/Smart Glasses Low-Level SDKs, Virtual Displays, and BLE HUD Templates

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies low-level XR and smart-glasses implementation patterns:
Viture IMU wrappers and spatial desktop stacks, Even Realities BLE command
libraries, G2 protocol runtimes, and constrained HUD templates.

## Why It Matters For `VR-apps-lab`

XR glasses occupy the space between VR overlays and mobile HUDs. Their most
reusable lessons are usually not 3D scenes, but device boundaries: IMU
decoding, recentering, display surfaces, BLE write cadence, text/paging
constraints, and comfort workarounds.

## Project Notes

### `boomskats/woahland`

- Interesting idea:
  an XR glasses IMU can become a practical desktop input device when mapped to
  a virtual mouse with smoothing, deadzone, roll-scroll, recenter, and runtime
  control.
- Code donor value:
  `head_mouse_wayland.c` decodes Euler/quaternion data, maps yaw/pitch to
  uinput REL_X/REL_Y, applies deadzone/smoothing/sensitivity/inversion,
  handles roll-to-scroll, and keeps subpixel accumulators. `config.c` provides
  user/system/default config fallback. `socket_server.c` and
  `viture-mouse-ctl.c` expose toggle, recenter, pause, resume, reload, status,
  and sensitivity commands over a Unix socket.
- Product reference value:
  strong Linux head-mouse helper reference.
- What to inspect next:
  compare with XREAL head-tracked desktop and virtual display helpers.
- Architecture pattern:
  IMU-to-OS-input bridge with runtime control socket.
- Caveats:
  depends on Viture SDK, Linux input permissions, and device-specific IMU
  semantics.

### `Wojtekb30/EasyVXR`

- Interesting idea:
  a tiny wrapper can make a proprietary glasses SDK safer to consume by
  centralizing connect/disconnect, IMU toggles, data copying, and frequency
  helpers.
- Code donor value:
  `easyvxr.c` registers callbacks, decodes Euler and quaternion floats, stores
  latest IMU data behind a pthread mutex, returns copied structs, supports
  IMU state, 3D mode, frequency, and safe disconnect with IMU disable.
- Product reference value:
  useful minimal boundary for vendor SDK experiments.
- What to inspect next:
  compare wrapper shape against `woahland`, `UxSpace`, and other glasses SDK
  adapters.
- Architecture pattern:
  thin thread-safe vendor SDK facade.
- Caveats:
  Linux-only Viture SDK dependency, root/USB requirements, and unofficial
  support status.

### `darkclad/uxspace`

- Interesting idea:
  the same spatial desktop vocabulary can span Android and Windows if tracking,
  screen, view, driver, and app wiring are separated.
- Code donor value:
  Android architecture separates tracking/viture/spatial/app layers, draws
  UiScreen and AppScreen as VirtualDisplay/SurfaceTexture quads, dispatches
  cursor input into presentations or launched app displays, and gates FREE mode
  on head tracking. Windows architecture mirrors tracking/spatial/app/driver,
  uses IddCx virtual monitors, DDA capture, D3D11 stereo composition,
  ScreenLayout strategies, named-pipe driver control, and vendor-neutral
  HeadTracker boundaries.
- Product reference value:
  strongest XR glasses spatial desktop donor in this wave.
- What to inspect next:
  consider a dedicated reuse plan if virtual display/spatial workspace becomes
  active scope.
- Architecture pattern:
  cross-platform spatial desktop with display-to-texture and tracker provider
  boundaries.
- Caveats:
  proprietary Viture SDK is excluded, Windows driver signing is nontrivial,
  Shizuku/bootstrap is Android-specific, and scope is large.

### `emingenc/even_glasses`

- Interesting idea:
  a Python BLE micro-library can expose smart-glasses text, RSVP, dashboard,
  brightness, silent mode, notes, and notification flows quickly.
- Code donor value:
  `bluetooth_manager.py` scans left/right glasses, starts notifications,
  guards writes with an asyncio lock, sends heartbeat, and attempts reconnect.
  `commands.py` formats lines, pages text, sends RSVP groups, builds
  dashboard/brightness/silent/notification commands, and handles chunks.
  `models.py` names command enums and packet shapes.
- Product reference value:
  good quick command-map reference for G1-style BLE HUD control.
- What to inspect next:
  compare its paging and command model against EvenHub and `g2-kit`.
- Architecture pattern:
  Python BLE command facade for dual-lens smart glasses.
- Caveats:
  GPL-3.0, device-specific protocol assumptions, and simpler error/backpressure
  policy than `g2-kit`.

### `fabioglimb/even-toolkit`

- Interesting idea:
  constrained smart-glasses apps need a design system plus per-screen
  display/action routing, not just packet send helpers.
- Code donor value:
  README defines per-screen display/action modules. `bridge.ts` manages text,
  column, split, chart/image, raw bridge, and page modes. `layout.ts` records
  the 576x288 constraints and tile slots. `glass-screen-router.ts` composes
  display/action handlers. `gestures.ts` debounces taps and suppresses spurious
  scrolls after text updates. `keep-alive.ts` uses audio and navigator locks.
- Product reference value:
  strong G2 app framework and UX guideline donor.
- What to inspect next:
  compare its router/layout/gesture model with official templates and
  `g2-kit`.
- Architecture pattern:
  smart-glasses app framework with screen router, layout constants, and render
  cadence guards.
- Caveats:
  EvenHub/G2 ecosystem coupling and framework-level dependency commitment.

### `even-realities/evenhub-templates`

- Interesting idea:
  official starter templates document the minimum viable patterns for G2 text,
  ASR, images, and long-form reading.
- Code donor value:
  `minimal` shows startup page creation and event routing caveats.
  `asr` shows audio control, PCM events, STT stub boundary, text update debounce,
  double-tap shutdown, and cleanup. `text-heavy` uses pixel-accurate
  measurement for pagination. `image` documents grayscale/image preprocessing
  tradeoffs and SDK conversion.
- Product reference value:
  best onboarding reference for G2 template structure and constraints.
- What to inspect next:
  compare official SDK assumptions against reverse-engineered `g2-kit`.
- Architecture pattern:
  constrained HUD starter templates with explicit event and shutdown paths.
- Caveats:
  template scope, simulator/EvenHub dependency, and no full app-state system.

### `Commute773/g2-kit-unofficial`

- Interesting idea:
  a reverse-engineered smart-glasses stack is most reusable when it separates
  pure BLE transport from UI-level paging, images, heartbeat, and coalescing.
- Code donor value:
  `ble/envelope.ts` implements `aa 21` framing, shared transport seq per
  fragment, CRC-16, sid/flag parsing, and ack field peeking. `session.ts`
  manages both arms, prelude, magic ack matching, pipelined writes, event
  subscriptions, raw frame hooks, render channel, and close. `ui/pager.ts`
  replaces scrolling with explicit page rows because lens desync is physically
  uncomfortable. `ui/render-coalescer.ts` serializes renders and keeps only
  the newest queued state.
- Product reference value:
  strongest low-level protocol donor in this wave.
- What to inspect next:
  compare BLE transport contracts with EvenHub SDK and G1 libraries.
- Architecture pattern:
  protocol layer plus UI cadence layer with firmware/comfort gotchas.
- Caveats:
  reverse-engineered, pre-1.0 API, hardware-specific, and direct protocol reuse
  needs licensing/support review.

## Reusable Pattern Extraction

- Pattern candidate:
  constrained smart-glasses HUD runtime boundary.
- Problem solved:
  optical smart glasses have small displays, slow or fragile BLE channels,
  lens sync issues, and vendor-specific SDK/protocol boundaries.
- Reusable core:
  separate device transport, session/prelude, command envelope, ack/backpressure,
  render coalescing, text/image/audio layout constraints, paging, gesture
  debounce, keep-alive, and app screen routing.
- Source evidence:
  `woahland`, `EasyVXR`, `uxspace`, `even_glasses`, `even-toolkit`,
  `evenhub-templates`, and `g2-kit-unofficial`.
- Abstraction boundary:
  keep vendor SDK/protocol code behind a device adapter; keep app state and HUD
  screen routing above the transport.
- What not to copy:
  proprietary SDK binaries, reverse-engineered constants without review,
  hardcoded BLE UUIDs as universal truth, concurrent render writes, animated
  scrolling that can desync lenses, and platform-specific driver assumptions.
- Method catalog action:
  add a method entry for smart-glasses HUD runtime and BLE/protocol boundaries.

## Follow-Up Gaps

- Build an XR/smart-glasses protocol and display matrix.
- Compare spatial desktop implementations across Android VirtualDisplay,
  Windows IddCx/DDA, Linux uinput head-mouse, and browser display helpers.
- Capture comfort-specific HUD rules: page instead of scroll, coalesce renders,
  debounce gestures, show exit path, and document device constraints.
