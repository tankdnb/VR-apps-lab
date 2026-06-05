# GitHub Research Wave 112 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on `WebXR` browser APIs,
  input-profile registries, emulator/devtools layers, polyfill lineage, and
  React/Three XR wrappers.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for WebXR samples, controller profiles, browser
  emulator/devtools, polyfill, and React/Three wrapper repositories
- `Done` Deduplicate surfaced repositories against registry and families
- `Done` Freeze a bounded shortlist spanning canonical samples, input-profile
  tooling, browser emulation, historical polyfill lineage, and modern
  framework wrappers

## Work package B: Local source acquisition

- `Done` Confirm `webxr-samples` in local cache
- `Done` Confirm `webxr-input-profiles` in local cache
- `Done` Confirm `immersive-web-emulator` in local cache
- `Done` Confirm `webxr-polyfill` in local cache
- `Done` Confirm `xr` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect WebXR sample app session setup, inline and immersive session
  handling, reference-space setup, input-source updates, controller rendering,
  hit-test flows, stats surfaces, and teleportation by reference-space offset
- `Done` Inspect WebXR input profile registry packages, profile validation,
  motion-controller layout selection, component mappings, gamepad polling, and
  asset tutorial rules
- `Done` Inspect Meta Quest immersive web emulator extension injection,
  runtime installation, DevUI and synthetic-environment wiring, and
  domain-scoped service-worker toggle
- `Done` Inspect Mozilla WebXR polyfill installation, display/reality
  abstraction, FlatDisplay AR path, anchor/event lineage, and deprecation
  caveats
- `Done` Inspect pmndrs/xr store, input-state model, event setup,
  teleport-target handling, emulator hooks, and React/vanilla examples

## Work package D: Repository updates

- `Done` Add Wave 112 plan document
- `Done` Add Wave 112 backlog document
- `Done` Add Wave 112 synthesis document
- `Done` Update the project registry for WebXR browser API and wrapper donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with WebXR session, profile, emulator,
  polyfill, and framework-store methods
- `Done` Update documentation indexes to include Wave 112

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare WebXR wrapper ergonomics against native OpenXR helper stacks
  when browser-first VR utilities become a prototype branch
- `Next` Revisit emulator/devtools projects when designing browser-based
  diagnostics or remote operator panels
- `Next` Keep deprecated WebXR polyfill material as architecture history only
