# GitHub Research Wave 90 Backlog

- Date: `2026-04-21`
- Scope: next GitHub discovery wave focused on
  `VRChat camera systems`, `staging and admin control`, and
  `creator-side event coverage`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for VRChat camera systems, event rigs, and admin-menu packages
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist spanning multicam rigs, synced world consoles, avatar-side OSC camera systems, and broader GM control packages

## Work package B: Local source acquisition

- `Done` Confirm `VRChatCameraWorks` in local cache
- `Done` Confirm `CameraSystem` in local cache
- `Done` Confirm `Camera-System` in local cache
- `Done` Confirm `GMMenu` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect multicam controller, output switching, and autopilot split in `VRChatCameraWorks`
- `Done` Inspect authorization, live render-texture switching, and potato mode in `CameraSystem`
- `Done` Inspect packaging and companion-bound OSC path model in `Camera-System`
- `Done` Inspect module split and watch-camera flow in `GMMenu`

## Work package D: Repository updates

- `Done` Add Wave 90 plan document
- `Done` Add Wave 90 backlog document
- `Done` Add Wave 90 synthesis document
- `Done` Update the project registry for VRChat camera and admin-control donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new creator-camera and admin-control patterns
- `Done` Update documentation indexes to include Wave 90

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `VRLabs/Camera-System` when a future pass needs deeper inspection of the companion protocol and generated OSC path data
- `Next` Revisit `GMMenu` when a future pass needs tighter mapping of permissions, ping flow, and optional audio-control branches
- `Next` Compare `VRChatCameraWorks` and `CameraSystem` more directly whenever future work needs `camera rig vs operator console` distinctions
