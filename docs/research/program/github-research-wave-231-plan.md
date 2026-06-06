# GitHub Research Wave 231 Plan

Date: 2026-06-06

Theme: WebXR prototyping runtime micro-frameworks, AI-assisted XR primitives,
and experimental interaction demos.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

After studying focused hand input and creative surfaces, the repo needs a
framework-level comparison: what small runtime wrappers and SDKs make WebXR
experiments fast, testable, or AI-assisted, and which ones are only thin
starter references.

## Search Families

- WebXR SDKs and rapid prototyping libraries.
- Desktop simulator plus headset deployment frameworks.
- Declarative React/Babylon or Three wrappers.
- One-file depth/hand interaction demos.
- AR product UI examples with hand tracking.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `google/xrblocks` | Broad AI + XR SDK with script core, gestures, depth, simulator, UI blocks, sound, world, and agents. | WebXR SDK/platform donor |
| `w3reality/threelet` | Compact Three.js/WebXR wrapper with render loop, XR buttons, input events, and controller helper. | Thin runtime wrapper |
| `simonedevit/reactylon` | Declarative React/Babylon framework with reconciler, generated components, XR default experience, and CLI ecosystem. | Declarative XR framework |
| `vishnu7560834213/threexr` | Rough Three/Vite/WebXR starter with controller/capsule/physics/player helpers and scaffold package. | Thin starter/caveat |
| `ARDings/EverythingController` | Single-file XR Blocks depth-sensing body-as-controller demo with spatial UI and occlusion toggles. | Depth interaction microdemo |
| `dmvrg/webxr-ar-demos` | AR glasses/WebXR demos with hand pinch, product UI panels, exploded views, and direct manipulation. | AR UI product demo set |

## Dedupe Notes

`google/model-viewer`, `pmndrs/xr`, `pmndrs/uikit`, `marlon360/webxr-handtracking`,
and other broad WebXR projects were already tracked, so this shortlist focuses
on not-yet-tracked SDKs, runtime wrappers, and demo patterns.

## Code-Level Pass Targets

- SDK export surface and module boundaries.
- Script lifecycle, dependency injection, and options.
- Gesture/depth/simulator/UI primitives.
- Declarative scene management and disposal.
- Controller input helper shape and starter maturity.
- Depth-sensing collision and product UI gesture patterns.

## Expected Outputs

- Wave 231 landscape synthesis.
- Registry/family entries for WebXR runtime primitives.
- Method catalog entry for WebXR prototyping runtime stacks.
- Follow-up backlog for SDK maturity and interaction primitive matrices.
