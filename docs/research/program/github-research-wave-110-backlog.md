# GitHub Research Wave 110 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on `bHaptics SDKs`, `OSC
  bridges`, `lightweight relay wrappers`, and `telemetry-to-haptic adapters`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for bHaptics native SDK, tact-js, tact-python,
  bHaptics OSC, and haptics relay repositories
- `Done` Deduplicate surfaced repositories against registry and families
- `Done` Freeze a bounded shortlist spanning official SDK surface, browser
  control, Python control, avatar OSC bridge, and generic relay wrapper

## Work package B: Local source acquisition

- `Done` Confirm `haptic-library` in local cache
- `Done` Confirm `tact-js` in local cache
- `Done` Confirm `tact-python` in local cache
- `Done` Confirm `bHapticsOSC` in local cache
- `Done` Confirm `bHapticsRelay` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect haptic-library C ABI, HapticLibrary exports, WebSocket Player
  client, feedback registration, submit variants, dot/path conversion, status,
  and turn-off calls
- `Done` Inspect tact-js TypeScript SDK facade, wasm bridge, event/dot/path
  calls, connected-device queries, haptic mappings, and playing-state helpers
- `Done` Inspect tact-python command example, async registry/init flow, event,
  dot, path, glove, ping, device info, and Player status calls
- `Done` Inspect bHapticsOSC config loading, file watcher, reflection-based OSC
  address binding, VRChat avatar parameter mapping, avatar-change reset, and
  per-device motor buffers
- `Done` Inspect bHapticsRelay WPF app, SDK2 wrapper surface, log-tail mode,
  WebSocket mode, command parser, offline fallback mappings, and status UI

## Work package D: Repository updates

- `Done` Add Wave 110 plan document
- `Done` Add Wave 110 backlog document
- `Done` Add Wave 110 synthesis document
- `Done` Update the project registry for bHaptics SDK, OSC bridge, and relay
  donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with SDK facade, avatar OSC haptics, and
  generic relay methods
- `Done` Update documentation indexes to include Wave 110

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare bHapticsRelay with telemetry overlays, racing telemetry, and
  motion-cue sidecars if a future pass studies event-to-output adapters
- `Next` Compare bHapticsOSC with avatar OSC routers and port fan-out tools
  whenever avatar parameter contention becomes important
- `Next` Use tact-js as a possible reference for browser-native haptic control
  panels without a heavyweight desktop shell
