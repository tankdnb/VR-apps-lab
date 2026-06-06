# VR Projects Wave 200: VRCOSC Module Packs, Add-On Modules, and Plugin-Distribution Boundaries

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 200 studies the VRCOSC ecosystem around the host application: official
modules, third-party module packs, sensor modules, service bridges, compatibility
shims, and non-Twitch live-event adapters. The reusable value is not just
"modules exist"; it is how a VR utility host can expose a stable SDK boundary,
let many narrow utilities plug in, and still retain safety, configuration, and
reset semantics.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `VolcanicArts/VRCOSC-Modules` | Official VRCOSC module suite | Strong module SDK donor |
| `CrookedToe/CrookedToe-s-Modules` | OSCLeash and audio-reaction VRCOSC modules | Strong third-party module-pack donor |
| `Yeusepe/Yeusepes-Modules` | Large external-service module pack | Service-heavy product reference |
| `FuviiPeshu/FuviiOSC` | SteamVR/VRChat body-device module pack | Device-to-avatar donor |
| `WentTheFox/VRCOSC-BluetoothHeartrate` | BLE heart-rate module | Sensor module donor |
| `RichiCoder1/VrcOscLeash` | Avatar-config-driven leash compatibility module | Compatibility donor |
| `03milo/File-Reading-Module` | Local file to chatbox micro-module | Micro-ingress reference |
| `TZFC/VRCOSC-Bilibili` | Bilibili live events to chatbox/parameters | Non-Twitch event bridge donor |

## `VolcanicArts/VRCOSC-Modules`

- Interesting idea:
  the official module suite turns VRCOSC into a typed host for many utility
  domains: Twitch EventSub, media status/control, voice commands, parameter
  sync, PiShock actions, OpenVR gesture extraction, hardware stats, date/time,
  KAT, Pulsoid, Hyperate, process control, and more.
- Code donor value:
  very high for SDK usage, setting groups, persistent module state, runtime
  views, typed module nodes, delayed parameter sends, avatar-change handling,
  and service-to-parameter boundaries.
- Product reference value:
  very high for "core host + official module pack" distribution strategy.
- What to inspect next:
  module permission model, versioning, secrets handling, module discovery,
  physical-output safety requirements, and host-level failure isolation.
- Source evidence:
  `Twitch/TwitchModule.cs`, `ParameterSync/ParameterSyncModule.cs`,
  `PiShock/PiShockModule.cs`, `OpenVR/GestureExtensionsModule.cs`,
  `VoiceCommands/VoiceCommandsModule.cs`, and `Media/MediaModule.cs`.
- Reusable pattern extraction:
  module host plus official module pack.
- Reusable core:
  expose a stable module lifecycle, typed settings, persistent state, runtime
  status views, declarative avatar parameters, typed event nodes, and host-owned
  send/reset helpers so modules can focus on one source or action domain.
- Do not copy directly:
  physical-output behavior, service credentials, Windows/OpenVR-specific
  assumptions, or large parameter surfaces without user-visible permissions.
- Caveats:
  license split and service-specific dependencies matter if any code is reused.

## `CrookedToe/CrookedToe-s-Modules`

- Interesting idea:
  a third-party pack demonstrates how narrow user-facing modules can extend the
  host: `OSCLeash` maps avatar parameters into movement/look/run controls while
  `OSCAudioReaction` publishes audio bands, volumes, spikes, and device-driven
  parameters.
- Code donor value:
  high for wildcard parameter handlers, cached settings, stop/reset behavior,
  OpenVR chaperone/standing-zero movement manipulation, audio device management,
  frequency-band outputs, AGC, and spike habituation.
- Product reference value:
  high for module-pack UX where each module ships with avatar prefab and docs.
- What to inspect next:
  movement safety, vertical/rotation bounds, OpenVR permission assumptions,
  audio-device reconnect behavior, and avatar prefab compatibility.
- Source evidence:
  `Modules/OSCLeash/OSCLeashModule.cs`,
  `Modules/OSCAudioReaction/OSCAudioReactionModule.cs`,
  `AudioProcessor.cs`, and `AudioDeviceManager.cs`.
- Reusable pattern extraction:
  third-party VRCOSC module pack with per-module avatar prefab contract.
- Reusable core:
  group related modules, expose explicit parameter contracts, cache settings,
  reset driven outputs on stop, and document the avatar-side prefab paths.
- Do not copy directly:
  unbounded movement automation, hidden OpenVR chaperone changes, or audio
  capture assumptions without clear user controls.
- Caveats:
  strong donor, but movement-control modules require a safety review.

## `Yeusepe/Yeusepes-Modules`

- Interesting idea:
  a large add-on pack shows a service-heavy module ecosystem: Spotify control
  and metadata, Discord status, Shazam-style detection, QR/Spotify codes,
  Steam Input, VRChat API helpers, and reusable screen/UI helpers.
- Code donor value:
  medium-to-high for module packaging, external-service adapters, credential
  screens, Spotify playback/session state, QR/code generation, and broad
  avatar-parameter surfaces.
- Product reference value:
  high for showing how a module pack can become an "external services into
  avatar state" bundle.
- What to inspect next:
  credential storage, service token refresh, private/protobuf API boundaries,
  native DLL/Puppeteer dependencies, and module failure isolation.
- Source evidence:
  `SPOTIOSC/SpotiOSC.cs`, `OSCQR/OSCQR.cs`, and the module directories under
  `YeusepesModules/`.
- Reusable pattern extraction:
  service-rich module bundle.
- Reusable core:
  keep each service as a separate module, share UI/screen helpers, isolate
  credentials per service, publish a clear avatar parameter schema, and let the
  host carry common lifecycle/settings behavior.
- Do not copy directly:
  private API assumptions, broad credential prompts, native dependency bundles,
  or huge parameter sets without pruning.
- Caveats:
  useful product/reference donor; any code reuse needs careful license and
  dependency review.

## `FuviiPeshu/FuviiOSC`

- Interesting idea:
  a body-device module pack maps SteamVR and avatar state into haptics, paw or
  controller tracking, avatar changes, and audio-meter behaviors.
- Code donor value:
  high for haptic trigger modes, SteamVR tracker-role maps, raw curl/button
  parameter publishing, token-based haptic cancellation, timeout behavior, and
  external device reset on stop.
- Product reference value:
  high for SteamVR-device-to-avatar module boundaries.
- What to inspect next:
  haptic safety caps, tracker role setup UX, OpenVR lifecycle ownership,
  external OSC device trust, and commented/generated camera companion code.
- Source evidence:
  `Haptickle/Haptickle.cs`, `PawTracking/PawTracking.cs`, and the commented
  camera companion paths.
- Reusable pattern extraction:
  body-device module that maps tracker/controller state to avatar parameters.
- Reusable core:
  register explicit role/device parameters, provide trigger modes such as
  constant/proximity/velocity/on-change, cancel stale haptic tasks, and reset
  external devices when the module stops.
- Do not copy directly:
  physical output behavior, implicit tracker-role assumptions, or generated
  parameter sprawl.
- Caveats:
  valuable as architecture donor; safety and consent boundaries are central.

## `WentTheFox/VRCOSC-BluetoothHeartrate`

- Interesting idea:
  a VRCOSC module listens to Windows BLE heart-rate advertisements, persists the
  selected device, exposes runtime status, and can rebroadcast values through a
  local WebSocket side channel.
- Code donor value:
  high for BLE scan/reconnect state, device selection persistence,
  advertisement parsing, runtime view status, and optional side-channel output.
- Product reference value:
  medium-to-high for sensor-module packaging.
- What to inspect next:
  GATT versus advertisement behavior, BLE privacy, reconnect backoff,
  WebSocket bind/auth, and multi-sensor support.
- Source evidence:
  `BluetoothHeartrateModule/BluetoothHeartrateModule.cs`.
- Reusable pattern extraction:
  wearable sensor to avatar module plus optional local rebroadcast.
- Reusable core:
  scan for candidate sensors, let the user pin one source, persist selection,
  expose connection state, publish normalized avatar parameters, and optionally
  rebroadcast to a local trusted consumer.
- Do not copy directly:
  Windows-only BLE assumptions or unauthenticated network rebroadcast as a
  default.
- Caveats:
  strong compact donor for sensor modules.

## `RichiCoder1/VrcOscLeash`

- Interesting idea:
  an OSCLeash compatibility module discovers configured parameters from avatar
  config, supports wildcard names and legacy paths, then produces movement,
  look, run, and control outputs.
- Code donor value:
  high for avatar-config-driven discovery, wildcard route compatibility,
  legacy path support, movement state model, and safe reset on stop.
- Product reference value:
  high for compatibility layers that help avatar prefabs survive parameter name
  variants.
- What to inspect next:
  consent UX, NSFW framing, movement bounds, parameter conflict handling, and
  migration from legacy paths.
- Source evidence:
  `VrcLeashModule.cs` and `Leash.cs`.
- Reusable pattern extraction:
  avatar-parameter compatibility shim.
- Reusable core:
  read avatar-side configuration, resolve current and legacy parameter names,
  support wildcard handlers, compute outputs from normalized input, and cleanly
  return movement parameters to neutral values when disabled.
- Do not copy directly:
  leash/NSFW framing, hidden movement automation, or implicit consent model.
- Caveats:
  technically strong compatibility donor with product-framing caveats.

## `03milo/File-Reading-Module`

- Interesting idea:
  a tiny VRCOSC module reads a local text file and exposes its contents as a
  chatbox variable/event.
- Code donor value:
  low-to-medium, but useful as a minimal file-ingress micro-pattern.
- Product reference value:
  medium for simple local state bridges.
- What to inspect next:
  real file watcher support, truncation/cropping, path allowlists, privacy
  warnings, and stale file handling.
- Source evidence:
  `File readerModule.cs`.
- Reusable pattern extraction:
  local file to chatbox variable micro-module.
- Reusable core:
  let the user select a local file, read content at a bounded cadence, expose it
  through a named chatbox variable or event, and document privacy limits.
- Do not copy directly:
  reading arbitrary paths, whole-file reads on hot paths, or no length policy.
- Caveats:
  narrow but valuable as micro-utility proof.

## `TZFC/VRCOSC-Bilibili`

- Interesting idea:
  a Python bridge maps Bilibili live-room events into queued chatbox messages,
  avatar parameters, animation triggers, accumulators, and decay behavior.
- Code donor value:
  high for async producer/consumer split, event fanout, queue backpressure,
  accumulator parameters, parameter decay, and event dispatch levels.
- Product reference value:
  high for non-Twitch audience-event bridges.
- What to inspect next:
  credential/cookie handling, live API stability, encoding/i18n, queue bounds,
  moderation filters, and config validation.
- Source evidence:
  `main.py`, `app/osc_queue.py`, `app/chatbox_consumer.py`,
  `app/animation_consumer.py`, `app/parameter_decay_consumer.py`, and
  `app/bili_event_dispatch.py`.
- Reusable pattern extraction:
  event-source to avatar parameter queue with decay.
- Reusable core:
  normalize source events, dispatch them into typed queues, separate chatbox
  output from OSC/animation output, support event accumulation, decay counters
  over time, and keep source-specific API code outside the output consumers.
- Do not copy directly:
  service credentials, browser-cookie assumptions, unbounded queueing, or
  source-specific event names as a generic contract.
- Caveats:
  strong method donor, but needs i18n and credential review.

## Cross-Project Lessons

- VRCOSC's strongest ecosystem lesson is host/module separation: the host owns
  lifecycle, settings, persistence, logging, and send helpers while modules own
  one source or action boundary.
- Module packs should be judged by their trust surfaces: credentials, physical
  output, local file access, OpenVR movement, BLE devices, and external APIs are
  not equivalent risks.
- Compatibility modules are valuable when avatar prefabs have fragmented
  parameter names or legacy routes.
- Non-Twitch event bridges need the same queue, moderation, backpressure, and
  decay logic as Twitch tools.
- Micro modules are useful when their contract is tiny and honest.

## Reuse Recommendations

1. Use `VRCOSC-Modules` as the strongest module SDK and official-pack donor.
2. Use `CrookedToe-s-Modules`, `FuviiOSC`, and `VrcOscLeash` for
   compatibility, movement reset, audio, and device-to-avatar patterns.
3. Use `VRCOSC-BluetoothHeartrate` as a compact wearable sensor module donor.
4. Use `VRCOSC-Bilibili` for event queue, accumulator, and parameter-decay
   architecture.
5. Treat `Yeusepes-Modules` as a service-rich reference that needs pruning
   before reuse.

## Follow-Up Gaps

- Build a VRCOSC module trust matrix across credentials, local paths, physical
  output, OpenVR movement, BLE devices, and live APIs.
- Extract a minimal module-pack compatibility checklist for avatar prefabs and
  parameter names.
- Compare event-source modules across Twitch, Bilibili, Discord, Spotify, and
  local files for queue/backpressure behavior.
- Decide what a safe third-party module distribution story should require in
  `VR-apps-lab`.
