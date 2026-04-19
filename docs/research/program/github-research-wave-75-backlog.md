# GitHub Research Wave 75 Backlog

- Date: `2026-04-20`
- Scope: next GitHub discovery wave focused on
  `OpenXR micro-layers`, `view shaping`, `streamout`,
  `debugging capture`, and `frame-time intervention`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for OpenXR micro-layers, per-app patch layers, and stream-out or debug-capture layers
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans recenter override, FOV cropping, stream-out, RenderDoc capture integration, and staged frame intervention

## Work package B: Local source acquisition

- `Done` Confirm `OpenXR-RecenterOverride` in local cache
- `Done` Confirm `OpenXR-Layer-crop-fov` in local cache
- `Done` Confirm `openxr_streamout_layer` in local cache
- `Done` Confirm `openxr-renderdoc-layer` in local cache
- `Done` Confirm `Smoothing-OpenXR-Layer` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect application-name config bootstrapping and view override flow in `OpenXR-RecenterOverride`
- `Done` Inspect per-app settings initialization and FOV crop logic in `OpenXR-Layer-crop-fov`
- `Done` Inspect stream-out transport hooks and swapchain interception in `openxr_streamout_layer`
- `Done` Inspect RenderDoc lifecycle integration in `openxr-renderdoc-layer`
- `Done` Inspect multi-stage frame-processing architecture in `Smoothing-OpenXR-Layer`

## Work package D: Repository updates

- `Done` Add Wave 75 plan document
- `Done` Add Wave 75 backlog document
- `Done` Add Wave 75 synthesis document
- `Done` Update the project registry for OpenXR micro-layer donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new per-app layer and frame-lifecycle integration patterns
- `Done` Update documentation indexes to include Wave 75

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `OpenXR-RecenterOverride` and `OpenXR-Layer-crop-fov` visible whenever a future branch needs a stronger `per-app operator-facing layer` donor
- `Next` Keep `openxr_streamout_layer` and `openxr-renderdoc-layer` visible whenever `VR-apps-lab` needs a `tool or transport integration layer`
- `Next` Keep `Smoothing-OpenXR-Layer` visible as a `heavier staged intervention layer` comparison, especially where future passes need deeper Vulkan and compute-pipeline inspection
