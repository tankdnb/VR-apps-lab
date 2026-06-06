# GitHub Research Wave 234 Backlog

Date: 2026-06-06

Theme: XR/smart glasses low-level SDKs, virtual displays, and BLE HUD
templates.

## Completed In This Wave

- Studied `boomskats/woahland` as a Linux Viture head-mouse with uinput mouse
  output, IMU yaw/pitch/roll decoding, sensitivity/deadzone/smoothing,
  roll-scroll, user/system/default config, Unix socket runtime commands,
  recenter, pause/resume, reload, and CLI control.
- Studied `Wojtekb30/EasyVXR` as a minimal C wrapper around the Viture SDK with
  thread-safe latest IMU copy, Euler/quaternion decoding, start/connect,
  safe disconnect, IMU enable, 3D mode, and frequency helpers.
- Studied `darkclad/uxspace` as a two-platform XR glasses spatial desktop with
  Android VirtualDisplay/Presentation/SurfaceTexture screens, Shizuku-launched
  app screens, cursor-to-display dispatch, Windows IddCx virtual monitors,
  DDA capture, stereo composition, named-pipe driver control, and
  vendor-neutral head-tracker boundaries.
- Studied `emingenc/even_glasses` as a Python BLE micro-library with scanning
  left/right arms, write lock, reconnect attempts, heartbeat task, command
  enums, text pagination, RSVP, dashboard, brightness, silent mode, notes, and
  notification chunking.
- Studied `fabioglimb/even-toolkit` as a G2 design system and app framework
  with per-screen display/action routing, 576x288 layout constants, split and
  column pages, raw EvenHub bridge access, gesture debouncing, scroll
  suppression after text updates, keep-alive, STT modules, and web components.
- Studied `even-realities/evenhub-templates` as official starter templates for
  minimal text, ASR/mic streaming, image rendering, long-text pagination with
  pixel-accurate wrapping, event routing, double-tap shutdown, and BLE render
  debounce.
- Studied `Commute773/g2-kit-unofficial` as a pure BLE/protocol stack with
  L/R arm session prelude, `aa 21` envelope framing, CRC-16, protobuf builders,
  magic ack matching, pipelined writes, async event decoding, LC3 audio, image
  tiling, render coalescer, explicit pager, and firmware gotcha docs.
- Added a reusable method entry for constrained smart-glasses HUD runtimes and
  BLE/protocol boundaries.

## Follow-Up Queue

1. Build an XR-glasses matrix across Viture, XREAL/Nreal, Even G1/G2, Android,
   Windows, Linux, WebHID, native HID, BLE, and vendor SDKs.
2. Extract a comfort rule set for optical-glasses HUDs: paging over scrolling,
   one-deep render queues, debounce, keep-alive, text limits, and lens sync.
3. Compare spatial desktop pipelines: Android VirtualDisplay, Windows IddCx,
   DDA capture, head-mouse uinput, and browser/head-tracked display helpers.
4. Compare smart-glasses text/image/audio pipelines across EvenHub templates,
   even-toolkit, g2-kit, and even_glasses.
5. Decide if `UxSpace` or `g2-kit` deserves a dedicated reuse plan.

## Do Not Spend Time On Yet

- Do not run vendor SDKs, BLE scans, or connect to glasses.
- Do not commit proprietary SDK binaries or vendor assets.
- Do not copy reverse-engineered protocol constants into runnable prototypes
  without licensing, safety, and device-support review.
