# GitHub Research Wave 109 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on `SlimeVR server`, `tracker
  firmware`, `Joy-Con`, `Mocopi`, `HaritoraX`, and `calibration ecosystem`
  patterns.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for SlimeVR server, firmware, Joy-Con, Mocopi, and
  HaritoraX adapter repositories
- `Done` Deduplicate surfaced repositories against registry and families
- `Done` Freeze a bounded shortlist spanning server hub, firmware protocol,
  consumer-controller adapter, BLE tracker adapter, and guided desktop adapter

## Work package B: Local source acquisition

- `Done` Confirm `SlimeVR-Server` in local cache
- `Done` Confirm `SlimeVR-Tracker-ESP` in local cache
- `Done` Confirm `slimevr-wrangler` in local cache
- `Done` Confirm `moslime` in local cache
- `Done` Confirm `SlimeTora` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect SlimeVR Server desktop entry, bridge provider, named-pipe and
  Unix-socket bridge setup, OSC/VMC/BVH/protocol packages, WebSocket API hook,
  and VR-mode GUI surface
- `Done` Inspect SlimeVR Tracker ESP firmware setup loop, packet structures,
  UDP bundling, diagnostics packet vocabulary, battery monitor, calibration,
  and feature flags
- `Done` Inspect slimevr-wrangler Joy-Con protocol crate, Deku packet
  serialization, Joy-Con communication thread, handshake, rotation,
  acceleration, reset action, and status cards
- `Done` Inspect moslime BLE notification handler, Mocopi packet counters,
  SlimeVR autodiscovery, quaternion conversion, rotation/accel/battery packets,
  and reconnect loop
- `Done` Inspect SlimeTora Electron main process, COM and dongle detection,
  Haritora interpreter, tracker-emulation integration, button mapping, battery
  smoothing, visualization, and debug events

## Work package D: Repository updates

- `Done` Add Wave 109 plan document
- `Done` Add Wave 109 backlog document
- `Done` Add Wave 109 synthesis document
- `Done` Update the project registry for SlimeVR server, firmware, and adapter
  donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with tracker hub, firmware protocol, and
  consumer-device adapter methods
- `Done` Update documentation indexes to include Wave 109

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare SlimeVR Server with other tracker hubs and virtual tracker
  hosts whenever calibration UX becomes the next product focus
- `Next` Revisit SlimeVR Tracker ESP if firmware-side diagnostics or battery
  telemetry becomes a prototype target
- `Next` Compare SlimeTora, moslime, and slimevr-wrangler as three adapter UX
  styles: guided desktop shell, BLE bridge, and consumer-controller wrapper
