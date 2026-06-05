# GitHub Research Wave 116 Backlog

- Date: `2026-06-05`
- Scope: Godot XR toolkits, templates, backend plugins, vendor-extension
  packaging, and legacy mobile VR bridges.

## Completed in this wave

- Studied `GodotVR/godot-xr-tools` as a modular scene-pack toolkit for hands,
  pointers, locomotion, interactables, desktop support, effects, staging, and
  settings.
- Studied `GodotVR/godot-xr-template` as a publishable Godot XR baseline with
  action map, XR Tools wiring, OpenXR Vendors dependency, and export presets.
- Studied `GodotVR/godot_openxr_for_godot_3.x` as a legacy OpenXR backend with
  runtime/session/action/extension boundaries.
- Studied `GodotVR/godot_openxr_vendors` as a vendor-specific OpenXR extension
  and export-plugin packaging reference.
- Studied `GodotVR/godot_openvr` as a SteamVR/OpenVR backend with action
  manifests, skeletons, play-area, render-model, and battery helpers.
- Studied `GodotVR/godot_oculus_mobile` as a deprecated Oculus Mobile bridge
  useful for migration and API-shaping lessons only.

## Reuse candidates

- `godot-xr-tools` should be treated as the strongest donor for Godot-side
  utility interaction scaffolding.
- `godot-xr-template` should be reused conceptually as the "starter wiring"
  pattern: action map plus template scenes plus export/device feature flags.
- `godot_openxr_vendors` should be reused as a pattern for optional vendor
  feature wrappers and export-time enablement.
- `godot_openvr` should be used as a reference for SteamVR device metadata and
  action-manifest bridging.

## Follow-up backlog

1. Compare `godot-xr-tools` locomotion, pointer, pickup, gaze, and hand modules
   against Unity MRTK/XRI and WebXR hand-component patterns.
2. Deepen `godot_openxr_vendors` by extracting a device-feature matrix for
   passthrough, anchors, environment depth, body/face/hand extensions, and
   export plugin toggles.
3. Compare Godot action maps with OpenXR sample action sets from earlier waves.
4. If a Godot prototype starts, make a small local spike around action-map
   layout and XR Tools scene composition; do not import third-party source into
   git.
5. Keep `godot_oculus_mobile` as deprecated reference only unless a migration
   note is needed.

## Quality notes

- No third-party project was built or launched.
- Downloaded source clones belong only in local cache and should be removed
  after the wave is committed.
- The value of this wave is architecture and method extraction, not validating
  runtime support for any specific headset.
