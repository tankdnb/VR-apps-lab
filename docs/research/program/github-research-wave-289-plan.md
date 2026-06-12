# GitHub Research Wave 289 Plan - WebXR Spatial UI Primitives, Mesh Text Layout, and Fullstack UI Shells

## Goal

Study WebXR UI projects as reusable references for canvas-backed panels,
mesh-native text/layout, A-Frame wrappers, controller raycast selection, and
socket-backed WebXR UI shells.

## Research Questions

- When is a canvas texture panel better than mesh-native text/layout?
- How do WebXR projects map controller rays or pointer events into spatial UI
  hover/select states?
- How are layout updates deferred or throttled for XR performance?
- How can in-headset UI actions cross into a server or companion process?

## Shortlist

- `NikLever/CanvasUI`
- `felixmariotto/three-mesh-ui`
- `Retchut/aframe-mesh-ui-components`
- `shiveshjadon/webxr-fullstack-boilerplate`

## Required Checks

- Deduplicate against prior A-Frame GUI/WebXR UI waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep boilerplate, version, font asset, hardcoded socket, and lifecycle caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 289.
- Registry/family entries for WebXR spatial UI primitives.
- Method catalog entry for WebXR spatial UI primitive boundaries.
- Follow-up gaps around canvas panels, mesh layout, declarative wrappers, and
  network-backed in-headset controls.
