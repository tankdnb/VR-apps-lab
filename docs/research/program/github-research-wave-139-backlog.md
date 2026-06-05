# GitHub Research Wave 139 Backlog

- Date: `2026-06-05`
- Scope: OpenGloves sidecars, protocol schemas, named-pipe input, OSC bridges,
  serial/alpha encoding helpers, Unity force feedback, and game adapters.

## Completed in this wave

- Studied `LucidVR/opengloves-ui` as a Tauri/Svelte sidecar that calls a local
  driver HTTP API on port `52060` and organizes configuration, reset, pose
  calibration, servo calibration, functions, and settings routes.
- Studied `LucidVR/opengloves-protocol` as a protobuf contract split for
  driver input, server output, device info, streamed input, and force-feedback
  curl messages.
- Studied `PerlinWarp/pygloves` as a Python named-pipe test/visualization
  harness with packed finger/joystick/button structs, sliders, buttons, and
  SteamVR-hand plotting.
- Studied `senseshift/opengloves-lib` as a C++ helper library that models
  hand/device input, finger curls/splay, joystick/buttons, output haptics, and
  alpha serial encode/decode functions.
- Studied `Rin-Wilson/CS-OpenGloves-Named-Pipe-Input-Library` as a C# named
  pipe helper for v2 glove input structs and left/right pipe paths.
- Studied `Python1320/opengloves-osc` as a compact OSC receiver that maps OSC
  joystick/button addresses into the C# named-pipe input helper.
- Studied `LucidVR/opengloves-force-feedback-unity-demo` as a Unity/SteamVR
  demo that injects FFB clients into interactables, estimates finger curl from
  skeleton poses, and writes curl force feedback to named pipes.
- Studied `LucidVR/opengloves-hl-alyx-integration` as a Tauri plus C# sidecar
  that watches game output for `[OpenGlovesParse]` lines, parses per-hand curl
  values, and writes force feedback to the OpenGloves driver.

## Reuse candidates

- `opengloves-ui` plus `opengloves-protocol` define the strongest sidecar and
  protocol boundary references.
- `opengloves-lib`, `pygloves`, and the C# named-pipe helper define reusable
  language/transport adapters.
- `opengloves-osc` is the clearest tiny OSC ingress reference.
- The Unity FFB demo and Half-Life: Alyx integration are useful game-to-haptics
  adapter references.

## Follow-up backlog

1. Extract an OpenGloves transport matrix covering HTTP, protobuf, named pipe,
   OSC, serial alpha, and force-feedback curl pipes.
2. Compare OpenGloves named-pipe ingress with virtual controller, VMT, SlimeVR,
   and VRChat OSC bridge patterns.
3. Queue a safety/caveat note for versioned pipe paths and struct layout drift.
4. Consider a reuse-plan only if hand-device input or force-feedback adapters
   become an active prototype branch.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
