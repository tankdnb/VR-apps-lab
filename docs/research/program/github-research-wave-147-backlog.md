# GitHub Research Wave 147 Backlog

- Date: `2026-06-05`
- Scope: core WebXR runtime abstractions in three.js, Babylon.js, PlayCanvas,
  and Immersive Web SDK.

## Completed in this wave

- Studied `mrdoob/three.js` as a minimal renderer-level WebXR manager with
  session lifecycle, reference-space handling, controller target-ray/grip/hand
  groups, VR button flow, and teleport examples.
- Studied `BabylonJS/Babylon.js` as a feature-manager-driven WebXR stack with
  session manager observables, experience helper, feature registration,
  session-init extension, hand tracking, DOM overlay, layers, hit-test,
  teleportation, and many modular XR features.
- Studied `playcanvas/engine` as an engine service model where `XrManager`
  exposes typed subsystems for input, hands, hit-test, anchors, planes, meshes,
  DOM overlay, light estimation, views, and graphics backend bridges.
- Studied `facebook/immersive-web-sdk` as a newer Three/ECS-based immersive web
  framework with XR input manager, primary source selection, multi-pointers,
  visual adapters, action-backed locomotion, spatial UI compiler, layers, and
  runtime-first CLI/MCP-style dev tooling.

## Reuse candidates

- `three.js` is the strongest minimal reference for renderer-level session and
  controller space boundaries.
- `Babylon.js` is the strongest donor for feature manager and session manager
  architecture.
- `PlayCanvas` is a strong donor for engine service taxonomy and evented input
  abstractions.
- `Immersive Web SDK` is the strongest product/process reference for testable
  XR development, spatial UI, action-backed locomotion, and runtime control.

## Follow-up backlog

1. Extract a `WebXR utility shell architecture` note comparing manager,
   feature, input, hand, UI, and testing seams across these frameworks.
2. Compare DOM overlay, quad/cylinder layers, and canvas UI texture approaches
   against Waves 140 and 145.
3. Track hand abstractions against Wave 144: raw `XRHand`, engine hand objects,
   squeeze emulation, and multi-pointer priority.
4. Consider whether a future browser utility prototype should start from
   Three minimalism, Babylon feature managers, PlayCanvas services, or an
   IWSDK-style ECS/action layer.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
