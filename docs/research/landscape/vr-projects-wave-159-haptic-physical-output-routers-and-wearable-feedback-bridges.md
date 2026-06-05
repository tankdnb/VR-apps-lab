# VR Projects Wave 159: Haptic, Physical-Output Routers, and Wearable Feedback Bridges

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 159 studies physical-output and haptics bridges as reusable architectures:
avatar contact events, OSCQuery discovery, Bluetooth/firmware contracts, muscle
maps, sensation lifecycles, audio/collider/velocity effects, process-level game
rumble capture, visualizers, and device selection.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `kikookraft/HapticPatPat` | DIY avatar-contact haptics | Strong simple bridge reference |
| `sync1211/owoskin-vrc` | Wearable haptics and avatar-driven feedback | Strong effect-engine donor |
| `intiface/intiface-game-haptics-router` | Generic game haptics routers | Strong architecture reference with safety caveats |

## `kikookraft/HapticPatPat`

- Interesting idea:
  replace Wi-Fi latency in an avatar head-pat strap with a Bluetooth ESP32
  bridge while keeping VRChat contact OSC as the event source.
- Code donor value:
  medium-high. The Python/firmware contract is small and readable.
- Product reference value:
  high. It shows a concrete DIY physical-output loop with status UI and test
  controls.
- What to inspect next:
  compare the contact vocabulary and intensity decay against OWO, bHaptics,
  and OpenShock bridges.
- Architecture pattern:
  PyQt UI exposes hardware and VRChat connection status, intensity slider, and
  left/right test buttons. Server thread discovers VRChat OSCQuery service or
  falls back to port `9001`, listens for `/avatar/parameters/pat_left` and
  `pat_right`, estimates intensity from contact value delta over time, decays
  strengths every 100 ms, and sends compact Bluetooth RFCOMM strings like
  `v 0f 0f` to an ESP32. Firmware parses `v` intensity packets, responds to
  `k` keepalive packets, and drives left/right motors with PWM.
- Reusable method:
  avatar contact OSC to low-latency Bluetooth microcontroller haptics bridge.
- Caveats:
  DIY hardware and pairing burden, blocking OSC server, thread-heavy Python,
  fixed parameter names, and firmware pin assumptions.

## `sync1211/owoskin-vrc`

- Interesting idea:
  build a full VRChat-to-OWO Skin integration around effect modules instead of
  only mirroring raw contact values.
- Code donor value:
  high. The OSCQuery, receiver, effect, sensation, settings, UI, and Unity
  payload layers are valuable as architecture reference.
- Product reference value:
  high. It demonstrates a haptics utility with live settings, presets, status,
  audio reactivity, world integration, and avatar package assets.
- What to inspect next:
  compare its muscle/event vocabulary with bHaptics OSC and generic haptics
  routers before defining any device-neutral haptics schema.
- Architecture pattern:
  C# core can advertise OSCQuery endpoints, wait for VRChat services, and add
  or remove callbacks under `/avatar/parameters/`. Collider effect registers
  muscle-name callbacks, tracks active collision data in a concurrent map,
  computes intensity from proximity or proximity delta, applies decay, updates
  or stops looped sensations, and maps named muscles through OWO helper APIs.
  OWO helper manages connection, calculation timer, named sensation play/update
  stop lifecycles, and UI events. Additional settings/effects cover audio
  spectrum mapping, velocity, inertia, world integration, presets, CLI/UI, and
  Unity avatar payloads.
- Reusable method:
  wearable haptics effect engine with OSCQuery endpoint advertisement, muscle
  maps, named sensations, decay, and modular effect settings.
- Caveats:
  OWO SDK dependency, GPL license, large codebase, device-specific muscle
  model, and any reuse should first define a device-neutral event schema.

## `intiface/intiface-game-haptics-router`

- Interesting idea:
  capture game controller rumble remotely and route it to user-selected
  external devices through Intiface Central.
- Code donor value:
  high for router architecture, not for direct VRChat integration.
- Product reference value:
  medium-high. It has strong UX around device selection, process attach,
  visualizer, multiplier, baseline, and troubleshooting.
- What to inspect next:
  keep as a generic haptics-router reference and compare only non-invasive
  pieces unless a safe event source is available.
- Architecture pattern:
  WPF app connects to Intiface Central via Buttplug WebSocket, scans devices,
  lets users mark active devices and controller mappings, lists user processes,
  injects EasyHook payloads into a selected process, hooks XInput/UWP rumble
  calls, deduplicates vibration packets, forwards XML-serialized IPC messages
  back to the router, scales left/right motor values with multiplier/baseline,
  updates charts, and calls `VibrateAsync` or `RotateAsync` on selected
  devices.
- Reusable method:
  generic game haptics router with event capture, IPC envelope, visualizer,
  scaling/baseline controls, and device-neutral output selection.
- Caveats:
  process injection, anti-cheat incompatibility, Windows-centric design,
  adult-device ecosystem context, and unsuitable as a direct pattern for
  platforms where invasive hooks are unsafe.

## Cross-Project Lessons

- Haptic bridges need two schemas: event vocabulary and device-output
  vocabulary.
- OSCQuery improves discovery, but fixed fallback ports and status UI still
  matter.
- Physical output should include intensity decay, keepalive, test controls, and
  visible connection state.
- Device-specific APIs can be hidden behind named sensations or generic output
  selection, but the abstraction must be explicit.

## Reusable Methods Extracted

- Avatar contact OSC to Bluetooth microcontroller haptics bridge.
- OSCQuery-advertised wearable haptics effect engine.
- Muscle-map and named-sensation lifecycle manager.
- Game rumble to generic device haptics router with visualizer and scaling
  controls.

## Follow-Up Backlog

- Build a haptics bridge matrix across OWO, bHaptics, OpenShock, Intiface, and
  DIY ESP32 projects.
- Define a device-neutral haptic event vocabulary before any prototype.
- Treat process-injection haptics as research-only unless safer input sources
  are available.
