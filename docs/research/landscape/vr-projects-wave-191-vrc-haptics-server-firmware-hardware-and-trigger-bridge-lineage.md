# VR Projects Wave 191: VRC Haptics Server, Firmware, Hardware, and Trigger Bridge Lineage

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 191 studies avatar-driven haptic output systems around VRChat OSC,
firmware, hardware, and vendor/legacy bridges. The reusable value is in the
boundary from avatar parameters to haptic events, maps, device transport,
firmware commands, and physical safety caveats.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `VRC-Haptics/VRCH-Server` | Modern Rust/Tauri VRC haptics manager | Strong server/device architecture donor |
| `VRC-Haptics/VRCH-Firmware` | ESP firmware for haptic devices | Strong firmware protocol donor |
| `virtuallyaverage/VRC-Haptics-Host` | Older Python VRC haptics host | Useful readable lineage donor |
| `virtuallyaverage/VRC-Haptics-Firmware` | Superseded firmware lineage | Historical reference |
| `virtuallyaverage/VRC-Haptics-Hardware` | PCB/BOM/Gerber hardware lineage | Hardware documentation reference |
| `sync1211/HapticPatternTriggerOSC` | OSC boolean to bHaptics pattern trigger | Strong preset trigger microtool donor |
| `TahvoDev/AXHaptics` | VRCOSC module for AXIS tracker haptics | Useful tracker haptics module donor |
| `Pillazo/VRCHaptics` | Legacy VB.NET/ESP DIY haptics stack | Legacy end-to-end baseline |

## `VRC-Haptics/VRCH-Server`

- Interesting idea:
  a Rust/Tauri manager maps VRC OSC inputs into haptic nodes, interpolation,
  device maps, WiFi/BLE device managers, and UI/config state.
- Code donor value:
  very high for server boundary, state model, OSC batching, map cache,
  interpolation, device abstractions, and WiFi/BLE transport separation.
- Product reference value:
  very high for physical-output routers and avatar-driven haptic utilities.
- What to inspect next:
  UI workflow, sidecar security, map authoring UX, and device failure states.
- Source evidence:
  `src-core/src/lib.rs`, `state.rs`, `osc/server.rs`, `vrc/mod.rs`,
  `mapping/mod.rs`, `event.rs`, `haptic_node.rs`, `interp.rs`,
  `devices/mod.rs`, `devices/wifi/mod.rs`,
  `devices/wifi/connection_manager.rs`, `devices/wifi/udp/broadcast.rs`,
  `devices/wifi/config.rs`, and `example_configs/*.json`.
- Reusable pattern extraction:
  DIY haptics OSC-to-device server with interpolation and device-manager
  boundary.
- Reusable core:
  listen to VRChat OSC, batch and cache avatar/contact parameter changes, map
  parameters into haptic nodes/groups, compute intensity through interpolation,
  keep per-device config and offsets, abstract output devices behind handles,
  and send timed output through WiFi/BLE-specific managers.
- Do not copy directly:
  project-specific map schemas, experimental sidecars, elevated helper flows,
  or unfinished TODO-heavy code paths without review.
- Caveats:
  the strongest donor in this wave, but extraction should be architectural and
  safety-conscious rather than copy-paste.

## `VRC-Haptics/VRCH-Firmware`

- Interesting idea:
  ESP32/ESP8266 firmware receives OSC haptic packets and commands, persists
  config in LittleFS, advertises/discovers over multicast, and drives motors
  through LEDC or PCA9685 outputs.
- Code donor value:
  very high for firmware protocol boundaries, descriptor-based config,
  serial/OSC command parity, heartbeat, multicast discovery, PWM output, and
  no-message motor reset behavior.
- Product reference value:
  high for DIY haptic hardware bring-up and firmware-to-server contracts.
- What to inspect next:
  protocol versioning, power/thermal safety, secure provisioning, and failure
  behavior when network packets stop.
- Source evidence:
  `platformio.ini`, `src/main.cpp`, `src/wifi/osc.cpp`,
  `src/wifi/callbacks.cpp`, `src/config/config.h`,
  `src/config/config.cpp`, `src/config/config_parser.cpp`,
  `src/PWM/LEDC/ledc.cpp`, and `src/PWM/PCA/pca.cpp`.
- Reusable pattern extraction:
  firmware-side OSC-to-motor protocol with descriptor config and discovery.
- Reusable core:
  load JSON config from flash, expose serial and OSC commands, announce device
  identity/config over multicast, parse compact haptic payloads, drive either
  direct PWM pins or PCA expanders, reset motors when data goes stale, and keep
  thermal/power constraints visible.
- Do not copy directly:
  DIY hardware pin maps, WiFi secrets handling, evolving packet formats, or
  motor-driving code without electrical safety validation.
- Caveats:
  high-value firmware reference, but hardware safety and protocol versioning
  must be explicit.

## `virtuallyaverage/VRC-Haptics-Host`

- Interesting idea:
  a readable Python predecessor maps VRChat contact receiver parameters to
  board handlers, modulation, mDNS-discovered devices, and `/h` output packets.
- Code donor value:
  high as a simple lineage donor that exposes the conceptual flow more clearly
  than the newer full manager.
- Product reference value:
  medium for early-stage haptic router prototypes.
- What to inspect next:
  exact packet compatibility with the modern firmware and migration notes.
- Source evidence:
  `Server/main.py`, `server_config.json`,
  `Connections/haptic_devices.py`, `vrc_handler.py`, `board_handler.py`, and
  `Modulation/modulator.py`.
- Reusable pattern extraction:
  simple VRC contact receiver to haptic board pipeline.
- Reusable core:
  discover boards, subscribe to VRC contact/avatar parameter addresses, keep a
  per-board output map, modulate intensity, compile compact output packets, and
  debounce sends to the device update rate.
- Do not copy directly:
  superseded protocol assumptions, manual IP config, older Python threading, or
  project-specific contact naming.
- Caveats:
  best used as a teaching lineage node rather than modern production donor.

## `virtuallyaverage/VRC-Haptics-Firmware`

- Interesting idea:
  older firmware lineage that has been superseded by `VRC-Haptics/VRCH-Firmware`.
- Code donor value:
  low-to-medium as a historical comparison point.
- Product reference value:
  low-to-medium for migration and protocol lineage.
- What to inspect next:
  compare old packet/config assumptions against the modern firmware if a
  compatibility matrix is needed.
- Source evidence:
  README and repository structure.
- Reusable pattern extraction:
  superseded firmware lineage reference.
- Do not copy directly:
  old firmware assumptions when the active repository exists.
- Caveats:
  keep as lineage, not as the preferred donor.

## `virtuallyaverage/VRC-Haptics-Hardware`

- Interesting idea:
  hardware lineage repository with PCB, Gerber, KiCad, BOM, CPL, and ordered
  JLC export artifacts for haptic PWM modules; development points to the newer
  `VRC-Haptics/VRCH-Hardware` location.
- Code donor value:
  low for software, medium for hardware documentation shape.
- Product reference value:
  medium for how DIY haptics projects document manufacturable hardware.
- What to inspect next:
  compare PCB/BOM revisions against the newer hardware repo and firmware pin
  maps.
- Source evidence:
  `README.md`, `PCB/`, `PCB/Gerbers/`, and `Ordered JLC/`.
- Reusable pattern extraction:
  hardware documentation package for DIY haptic modules.
- Do not copy directly:
  manufacturing files, board revisions, or BOM assumptions without electrical
  review.
- Caveats:
  hardware artifacts are useful as documentation references, not as ready
  product assets.

## `sync1211/HapticPatternTriggerOSC`

- Interesting idea:
  a WinForms app imports bHaptics Designer `.tact` files and maps OSC boolean
  parameters to vendor haptic pattern playback, then resets the boolean false.
- Code donor value:
  high for the preset import/map/play/reset microtool shape.
- Product reference value:
  high for simple avatar-triggered haptic effects without a full custom
  firmware stack.
- What to inspect next:
  intensity/offset support, richer value types, and safer preset management.
- Source evidence:
  `Program.cs`, `HapticsManager.cs`, `HapticPattern.cs`,
  `OSCServerHelper.cs`, `ConnectionSettings.cs`, and `PresetsForm.cs`.
- Reusable pattern extraction:
  haptic preset trigger bridge from OSC to vendor pattern player.
- Reusable core:
  import haptic pattern files, persist a mapping from OSC parameter path to
  pattern, start a local OSC receiver, play the pattern when a boolean becomes
  true, and send a false reset back to the avatar parameter.
- Do not copy directly:
  boolean-only limitation, no authentication, Windows-only UI assumptions, or
  vendor SDK coupling as the only backend.
- Caveats:
  strong focused micro-utility donor.

## `TahvoDev/AXHaptics`

- Interesting idea:
  a VRCOSC module maps VRChat haptic/contact parameters and bHaptics-compatible
  names to AXIS tracker vibration nodes through UDP commands.
- Code donor value:
  high for parameter compatibility mapping, tracker-node output, and module
  integration with VRCOSC.
- Product reference value:
  medium for alternate hardware compatibility modules.
- What to inspect next:
  current AXIS/AXSlime replacement state, protocol changes, and maintained
  module migration path.
- Source evidence:
  `AXHapticsModule.cs`, `AxisCommander.cs`, and `AxisUdpSocket.cs`.
- Reusable pattern extraction:
  tracker/controller haptics module for VRCOSC/AXIS-style runtimes.
- Reusable core:
  register avatar haptic parameters, map touch/proximity and bHaptics-style
  paths to hardware nodes, scale proximity into intensity, command node
  vibration over the hardware protocol, and track active node state from device
  output packets.
- Do not copy directly:
  deprecated AXIS protocol assumptions or binary packet details without modern
  compatibility checks.
- Caveats:
  useful compatibility concept, but deprecated.

## `Pillazo/VRCHaptics`

- Interesting idea:
  legacy end-to-end DIY haptics stack with VRChat OSC contact receivers, a
  VB.NET desktop host, device editor/provisioning, multicast packets, hardware
  docs, and ESP firmware.
- Code donor value:
  medium as a legacy baseline for understanding how older DIY haptic stacks
  solved discovery, provisioning, and intensity packets.
- Product reference value:
  medium for historical comparison and BOM/hardware communication.
- What to inspect next:
  which concepts survived into the modern VRC-Haptics rewrite and which should
  be retired.
- Source evidence:
  `Form1.vb`, `DeviceWifi.vb`, `DeviceEditor.vb`, hardware/BOM docs, and
  `VRCHaptics.ino`.
- Reusable pattern extraction:
  legacy DIY haptics stack with provisioning and multicast intensity packet.
- Reusable core:
  read VRChat OSC avatar/contact parameters, maintain per-device node outputs,
  provision WiFi/device names over serial, multicast compact intensity packets,
  and run firmware that maps timed byte outputs to motor pins.
- Do not copy directly:
  manual OSC parsing, magic multicast constants, bundled binaries, old
  MelonLoader-era assumptions, or unsafe hardware behavior.
- Caveats:
  valuable as lineage and warning label, not as a modern preferred donor.

## Cross-Project Lessons

- Haptics tools need a device-neutral event schema before binding to WiFi,
  BLE, bHaptics, AXIS, or custom ESP firmware.
- Avatar parameters and contact receivers are only the ingress; the reusable
  system starts when they become normalized haptic events.
- Firmware and hardware documentation should be studied together: packet
  schemas, pin maps, motor limits, power, and thermal behavior are coupled.
- Boolean trigger bridges are a useful lightweight alternative to full custom
  hardware when vendor pattern players exist.
- Superseded lineage repos are still useful for understanding why the modern
  server split exists.

## Reuse Recommendations

1. Use `VRCH-Server` as the main architecture reference for avatar OSC ->
   haptic map -> interpolation -> device manager.
2. Use `VRCH-Firmware` as the firmware-side protocol and config donor.
3. Use `VRC-Haptics-Host` and `VRCHaptics` as lineage and teaching contrasts.
4. Use `HapticPatternTriggerOSC` for the focused preset-trigger microtool
   pattern.
5. Use `AXHaptics` as a compatibility-mapping reference for alternate tracker
   haptic hardware.

## Follow-Up Gaps

- Build a haptic event schema matrix across contact receivers, avatar
  parameters, bHaptics presets, tracker nodes, firmware packets, and hardware
  maps.
- Compare modern `VRCH-Hardware` against the older hardware repo.
- Extract safety requirements for DIY motor output: stale reset, max duty,
  thermal state, provisioning, and power limits.
- Decide whether `VR-apps-lab` should keep a haptics reuse plan around
  device-neutral event routing.
