# GitHub Research Wave 52 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `overlay render scaffolds`, `UI-to-texture bridges`, and
  `engine-native projection-overlay extensions`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for overlay templates, ImGui overlays, engine-native projection-overlay extensions, and thin Unity helper libraries
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans C#, C++, Unity, and Godot overlay-construction paths

## Work package B: Local source acquisition

- `Done` Confirm `csharp-openvr-overlay-imgui` in local cache
- `Done` Confirm `godot-openvr-overlay` in local cache
- `Done` Confirm `OpenVROverlay_imgui` in local cache
- `Done` Confirm `SampleVRO` in local cache
- `Done` Confirm `LibOverlay` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect overlay host, input context, and desktop-duplication slices in `csharp-openvr-overlay-imgui`
- `Done` Inspect XR interface, tracker paths, and projection-overlay submission in `godot-openvr-overlay`
- `Done` Inspect D3D11, ImGui, and overlay-event forwarding in `OpenVROverlay_imgui`
- `Done` Inspect process split, D3D11 texture flow, and forwarded mouse input in `SampleVRO`
- `Done` Inspect handle lifecycle, tracked-device attachment, and texture updates in `LibOverlay`

## Work package D: Repository updates

- `Done` Add Wave 52 plan document
- `Done` Add Wave 52 backlog document
- `Done` Add Wave 52 synthesis document
- `Done` Update the project registry for overlay scaffolds and engine-native overlay references
- `Done` Update overlay-related overlap families
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes
- `Done` Update the methods catalog with overlay scaffold and projection-overlay methods
- `Done` Update documentation indexes to include Wave 52

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `Marlamin/VROverlayTest` only if a future pass needs an even thinner D3D11 overlay scratchpad than `SampleVRO`
- `Next` Revisit `ephemeral-laboratories/ComposeVR` only if `VR-apps-lab` needs a stronger `Compose-style UI into OpenVR` comparison node
- `Next` Keep `godot-openvr-overlay` visible whenever a future branch needs `engine-native projection overlays` instead of browser or desktop texture bridges
