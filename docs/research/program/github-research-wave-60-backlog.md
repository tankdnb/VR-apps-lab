# GitHub Research Wave 60 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `code-first overlay scaffolds`, `projection samples`, and
  `window-to-texture baselines`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for minimal overlay scaffolds, projection-overlay samples, and window-capture overlays
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans tiny texture-submit baselines, a Linux window-capture bridge, and an explicit projection-overlay example

## Work package B: Local source acquisition

- `Done` Confirm `OpenGL-VROverlay` in local cache
- `Done` Confirm `OpenVRWindowOverlay` in local cache
- `Done` Confirm `openvr-overlay-test` in local cache
- `Done` Confirm `openvr-overlay-bunny` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect the rawdraw plus OpenGL texture-submit loop and controller attachment in `OpenGL-VROverlay`
- `Done` Inspect the `X11 -> GStreamer appsink -> GL texture -> OpenVR overlay` path in `OpenVRWindowOverlay`
- `Done` Inspect the Zig-based OpenVR C API baseline in `openvr-overlay-test`
- `Done` Inspect the frustum, eye-transform, and projection-overlay wrapper in `openvr-overlay-bunny`

## Work package D: Repository updates

- `Done` Add Wave 60 plan document
- `Done` Add Wave 60 backlog document
- `Done` Add Wave 60 synthesis document
- `Done` Update the project registry for low-level overlay baselines and projection-overlay donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes where needed
- `Done` Update the methods catalog with new overlay-baseline methods
- `Done` Update documentation indexes to include Wave 60

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `openvr-overlay-bunny` visible whenever a future branch needs honest projection-overlay math and transform notes
- `Next` Keep `OpenVRWindowOverlay` visible whenever a future branch needs a concrete `window capture -> overlay texture` donor
- `Next` Use `OpenGL-VROverlay` and `openvr-overlay-test` as lower-bound baselines when future overlay ideas risk becoming overengineered
