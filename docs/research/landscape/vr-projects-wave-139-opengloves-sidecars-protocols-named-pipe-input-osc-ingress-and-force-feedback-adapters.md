# VR Projects Wave 139: OpenGloves Sidecars, Protocols, Named-Pipe Input, OSC Ingress, and Force-Feedback Adapters

- Date: `2026-06-05`
- Goal: study the OpenGloves ecosystem as reusable hand-device integration
  references: sidecars, protocols, transport helpers, OSC ingress, serial
  encoding, and force-feedback adapters.

## Why this wave exists

DIY and custom hand hardware does not enter VR as one neat application. It
usually needs firmware encodings, host helpers, calibration UI, runtime driver
interfaces, test harnesses, language bindings, and game-specific adapters.
OpenGloves is valuable because the ecosystem exposes many of those seams.

## Better workflow used in this wave

1. searched by OpenGloves, LucidGloves, named pipe, OSC, serial, and force
   feedback adapter families;
2. deduplicated against prior haptics, hardware, driver, virtual-controller,
   and OSC bridge waves;
3. froze a shortlist across UI, protocol, helper libraries, test harnesses,
   OSC ingress, and force-feedback examples;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `LucidVR/opengloves-ui` | Tauri/Svelte calibration and control sidecar for local driver API |
| `LucidVR/opengloves-protocol` | Protobuf contracts for driver/server input/output and force feedback |
| `PerlinWarp/pygloves` | Python named-pipe tester and 3D hand visualization harness |
| `senseshift/opengloves-lib` | C++ input/output data model and alpha serial encoding helpers |
| `Rin-Wilson/CS-OpenGloves-Named-Pipe-Input-Library` | C# v2 named-pipe input helper |
| `Python1320/opengloves-osc` | OSC-to-named-pipe input bridge |
| `LucidVR/opengloves-force-feedback-unity-demo` | Unity/SteamVR force-feedback curl sender |
| `LucidVR/opengloves-hl-alyx-integration` | Game-log/file-watcher force-feedback sidecar |

## Deep-pass notes by project

## `LucidVR/opengloves-ui`

- GitHub:
  [LucidVR/opengloves-ui](https://github.com/LucidVR/opengloves-ui)
- What it is:
  a Tauri/Svelte/Tailwind desktop sidecar for OpenGloves configuration and
  calibration.
- Interesting idea:
  keep the calibration/control UI separate from the runtime driver and talk to
  a local driver API through a narrow HTTP boundary.
- Code-level notes:
  `http.ts` wraps Tauri HTTP requests to `http://localhost:` using
  `server.json`'s `driver_http_port` of `52060`. The app structure separates
  routes for configuration, functions, settings, reset, pose calibration, and
  servo calibration. `src-tauri/src/main.rs` is a minimal Tauri shell, keeping
  most sidecar behavior in the frontend and HTTP boundary.
- Code donor value:
  high for local driver sidecar boundaries and calibration UI organization.
- Product reference value:
  high for hardware setup/config companion UX.
- Caveats:
  UI-side pass only; driver-side HTTP endpoint implementation lives elsewhere.
- What to inspect next:
  pair with the driver repository if a full calibration sidecar blueprint is
  needed.

## `LucidVR/opengloves-protocol`

- GitHub:
  [LucidVR/opengloves-protocol](https://github.com/LucidVR/opengloves-protocol)
- What it is:
  a protobuf contract repository for OpenGloves communication.
- Interesting idea:
  split device/runtime communication into small typed services instead of
  letting every helper reinvent structs.
- Code-level notes:
  `driver_input.proto` exposes tracking reference discovery with hand and
  OpenVR id. `server_output.proto` exposes device info and streamed device
  input service shells. `server_input.proto` defines force-feedback curl input
  with thumb, index, middle, ring, and pinky curls and a success output.
- Code donor value:
  high for schema-first driver/device communication boundaries.
- Product reference value:
  medium-high for versionable protocol design.
- Caveats:
  schemas are compact; implementation details live in surrounding projects.
- What to inspect next:
  compare proto contracts with named-pipe and serial encodings for version
  drift.

## `PerlinWarp/pygloves`

- GitHub:
  [PerlinWarp/pygloves](https://github.com/PerlinWarp/pygloves)
- What it is:
  Python utilities for testing OpenGloves input through named pipes.
- Interesting idea:
  a desktop visualization/test harness can generate synthetic finger, joystick,
  and button inputs before hardware is ready.
- Code-level notes:
  `serial_utils/ipc.py` packs five finger floats, two joystick floats, and
  eight booleans, then writes to left/right named pipes. `opengloves_tester.py`
  creates Matplotlib sliders/buttons, sends pipe updates, and visualizes a
  SteamVR-like hand by interpolating open/fist poses from `bone.py`.
- Code donor value:
  high for test harness and synthetic input generation.
- Product reference value:
  medium-high for hardware bring-up diagnostics.
- Caveats:
  observed pipe path uses an older `vrapplication/input/{right,left}` style,
  while other helpers use v2 paths.
- What to inspect next:
  verify struct and pipe path compatibility against the current driver before
  reuse.

## `senseshift/opengloves-lib`

- GitHub:
  [senseshift/opengloves-lib](https://github.com/senseshift/opengloves-lib)
- What it is:
  a C++ OpenGloves data model and encoding helper library.
- Interesting idea:
  model hand input and output as typed structs/unions, then provide reusable
  alpha serial encode/decode functions.
- Code-level notes:
  `opengloves.hpp` defines hand/device types, finger curls, per-joint curls,
  splay, joystick, buttons, analog buttons, input info, output force feedback,
  and haptics. `alpha.hpp` maps finger/button/analog/info keys, scales analog
  values, encodes input info/peripheral state, and encodes force feedback and
  haptics strings.
- Code donor value:
  high for language-neutral data model and serial encoding references.
- Product reference value:
  medium for firmware/host integration.
- Caveats:
  transport helpers still need version/driver compatibility checks.
- What to inspect next:
  compare with Arduino examples and current driver parsing.

## `Rin-Wilson/CS-OpenGloves-Named-Pipe-Input-Library`

- GitHub:
  [Rin-Wilson/CS-OpenGloves-Named-Pipe-Input-Library](https://github.com/Rin-Wilson/CS-OpenGloves-Named-Pipe-Input-Library)
- What it is:
  a small C# helper for sending OpenGloves input through named pipes.
- Interesting idea:
  make custom app/device integration approachable by wrapping the binary pipe
  struct in a small managed-language helper.
- Code-level notes:
  `GloveInputLink.cs` defines an `InputData` struct with 20 flexion values,
  five splay values, joystick axes, button booleans, and trigger value. It
  connects to `vrapplication\input\glove\v2\{hand}`, marshals the struct to a
  byte array, and writes it to a `NamedPipeClientStream`.
- Code donor value:
  high for C# app-side OpenGloves input adapters.
- Product reference value:
  medium-high for managed custom-device sidecars.
- Caveats:
  binary struct layout and pipe path are version-sensitive.
- What to inspect next:
  create a pipe-version compatibility table before any prototype use.

## `Python1320/opengloves-osc`

- GitHub:
  [Python1320/opengloves-osc](https://github.com/Python1320/opengloves-osc)
- What it is:
  a compact C# OSC receiver that writes OpenGloves input through the named-pipe
  helper.
- Interesting idea:
  OSC can be a very thin ingress layer for external tools to drive virtual
  glove input.
- Code-level notes:
  `Program.cs` creates a left-hand `GloveInputLink`, opens an OSC receiver on
  port `9007`, maps addresses such as `/input/Horizontal`, `/input/Vertical`,
  `/button/trigger`, `/button/a`, `/button/b`, `/button/joy`,
  `/button/grab`, and `/button/menu`, updates one `InputData` object, and
  writes it after each message.
- Code donor value:
  medium-high for OSC-to-driver ingress.
- Product reference value:
  medium for quick external-control bridges.
- Caveats:
  one-hand/minimal prototype and no visible reconnect/config surface.
- What to inspect next:
  compare with VRChat OSC, VMC, SlimeVR, and bHaptics bridge patterns.

## `LucidVR/opengloves-force-feedback-unity-demo`

- GitHub:
  [LucidVR/opengloves-force-feedback-unity-demo](https://github.com/LucidVR/opengloves-force-feedback-unity-demo)
- What it is:
  a Unity/SteamVR force-feedback demo for OpenGloves.
- Interesting idea:
  estimate force-feedback curl values from existing SteamVR skeleton poses and
  inject a client into all interactable objects.
- Code-level notes:
  `FFBManager.cs` creates left/right providers, optionally injects `FFBClient`
  into all `Interactable` objects, estimates finger curl from open/fist
  skeleton reference poses, converts values to `0-1000` short curl values, and
  writes them to `vrapplication/ffb/curl/{right,left}` named pipes.
  `FFBClient.cs` listens for hand hover begin/end and sets or relaxes force
  feedback.
- Code donor value:
  high for app-side force-feedback adapter mechanics.
- Product reference value:
  medium-high for interactive haptics/constraint demos.
- Caveats:
  rough demo code and SteamVR/Unity specific.
- What to inspect next:
  compare with bHaptics and game-telemetry-to-haptics adapters.

## `LucidVR/opengloves-hl-alyx-integration`

- GitHub:
  [LucidVR/opengloves-hl-alyx-integration](https://github.com/LucidVR/opengloves-hl-alyx-integration)
- What it is:
  a Tauri/Svelte UI plus C# sidecar for Half-Life: Alyx force-feedback
  integration.
- Interesting idea:
  a game integration can avoid direct runtime hooks by watching a file/log
  stream for tagged lines and forwarding parsed values to the driver.
- Code-level notes:
  the sidecar reads JSON from stdin with a path and hand inversion flag, opens
  left/right `vrapplication/ffb/curl/{hand}` pipes, tails a shared file with
  `FileShare.ReadWrite`, looks for `[OpenGlovesParse]` lines with `{Right}` or
  `{Left}`, parses five short curl values from parentheses, and sends them to
  named pipes. The Svelte UI wraps the sidecar with a simple Tauri shell and
  toast/form UI.
- Code donor value:
  high for game-event-to-hardware sidecar architecture.
- Product reference value:
  high for force-feedback adapters where direct integration is risky.
- Caveats:
  game-specific and depends on an external script/mod output format.
- What to inspect next:
  compare file-watcher sidecars with local API polling and OSC event bridges.

## Cross-project extraction

- OpenGloves is a protocol family, not one repository:
  the useful pieces span UI, protobuf contracts, serial encoding, named pipes,
  OSC ingress, Python/C#/C++ helpers, Unity demos, and game sidecars.
- Transport boundaries need version notes:
  old and v2 pipe paths appear across helpers, and binary struct layout matters.
- Calibration UI belongs outside the driver:
  `opengloves-ui` reinforces the sidecar pattern for hardware setup and
  calibration.
- Haptics can be event adapters:
  Unity hover events and Half-Life: Alyx parse lines both become five-finger
  curl force-feedback payloads.

## Reusable methods extracted

- Driver-side hand-input protocol split with UI calibration, protobuf, named
  pipe, and OSC ingress.
- Alpha/serial/finger encoding helper library for DIY glove firmware and host
  tests.
- Game event to force-feedback adapter with sidecar/mod bridge.

## Caveats for future use

- Do not mix pipe versions without checking current driver expectations.
- Binary struct layout, endianness, marshaling, and bool sizes are compatibility
  risks.
- Game-specific haptic adapters require support-boundary notes because they may
  depend on mods, logs, or fragile external signals.

## Next gaps

- Build an OpenGloves transport/version matrix.
- Compare OpenGloves with bHaptics, SlimeVR, VMT, VMC, and VRChat OSC bridges.
- Queue a focused reuse plan only if hand-device input or force-feedback
  adapters become an active prototype track.
