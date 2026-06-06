# GitHub Research Wave 203 Plan

- Date: `2026-06-06`
- Theme: `ContactGlove, Haritora, and vendor tracker bridge sidecars`
- Scope: ContactGlove OpenVR drivers/OSC packages, glove-to-keyboard input,
  Haritora BLE/serial interpreters, SlimeVR/VMC/OSC bridge variants, and
  camera/IMU fusion sidecars.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Previous tracking waves covered SlimeVR, OpenGloves, VMC, MediaPipe, and
external pose ingress. Wave 203 studies newer or more vendor-specific sidecars:
ContactGlove and Haritora bridges that translate device-specific streams into
generic VR runtime, OSC, SlimeVR, VMC, keyboard, or camera-fusion boundaries.

## Search Families

- ContactGlove OpenVR/SteamVR integration
- ContactGlove OSC/avatar setup packages
- glove and hand-pose to local input utilities
- Haritora BLE and serial protocol interpreters
- Haritora to SlimeVR bridge variants
- OSC/VMC/camera fusion tracking sidecars

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `hyblocker/freescuba` | OpenVR driver plus overlay for ContactGlove integration | Strong driver/overlay donor |
| `Diver-X/ContactGloveOSC` | Official Unity/VRChat avatar setup package for ContactGlove OSC | Avatar package/setup reference |
| `1000100Den/Glove2Kb` | VMC/OSC hand-pose to keyboard/pointer utility | Glove input micro-bridge |
| `sim1222/haritorax-slimevr-bridge` | Rust BLE Haritora to SlimeVR UDP bridge | Strong protocol bridge donor |
| `JovannMC/haritorax-interpreter` | TypeScript Haritora COM/Bluetooth interpreter library | Protocol interpreter donor |
| `JovannMC/haritora-gx-poc` | Python GX serial data probe and decoder | Thin protocol probe |
| `cytsai1008/HaritoraToSlime` | Python OSC Haritora to SlimeVR bridge | SlimeVR packet reference |
| `Fuwaaaaaa/osc_haritorax2_camera_tracking` | Full tracking middleware with camera/IMU fusion, diagnostics, REST/dashboard, and tests | Strong runtime sidecar donor |

## Dedupe Notes

- OpenGloves/LucidGloves repos were explicitly excluded as already studied.
- SlimeVR core and firmware were already studied; this pass focuses on
  Haritora/ContactGlove bridge sidecars and protocol translation boundaries.
- Thin POC repos are retained only as protocol clues or comparison nodes.

## Code-Level Pass Targets

- OpenVR driver activation, input components, skeleton/haptics, pose threading,
  named-pipe IPC, serial parsing, and overlay/driver split.
- Unity/VRChat avatar setup: automatic parameter setup, animation copying,
  expression menus, and package distribution.
- VMC/OSC hand-pose input to local keyboard/pointer mappings.
- BLE/serial Haritora characteristic maps, IMU decode, battery/button events,
  and tracker identity.
- SlimeVR UDP handshake, rotation/accel/battery packets, packet counters, and
  multi-IMU workarounds.
- Tracking middleware architecture: receiver protocols, fusion engine,
  preflight checks, camera subprocess, config, persistence, and diagnostics.

## Expected Outputs

- Wave 203 landscape synthesis.
- Registry/family placement for ContactGlove and Haritora sidecars.
- Methods around vendor tracker/glove protocol interpreters and fusion sidecar
  diagnostics.
