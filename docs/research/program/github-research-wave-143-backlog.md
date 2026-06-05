# GitHub Research Wave 143 Backlog

- Date: `2026-06-05`
- Scope: WebAR marker/image tracking, A-Frame AR helpers, model-viewer AR
  placement, and lightweight scene-understanding utilities.

## Completed in this wave

- Studied `hiukim/mind-ar-js` as an image/face target tracking stack with
  compiler flows, controllers, A-Frame systems, target found/lost events, face
  anchors, occluders, and camera setup.
- Studied `AR-js-org/AR.js` as a marker/NFT/location WebAR stack with Three.js
  and A-Frame components, marker events, camera sources, GPS entities, and
  smoothing/location examples.
- Studied `akbartus/Simple-AR` as a minimal WebAR starter for A-Frame, Three.js,
  and Babylon-style scenes with camera start and target distance event framing.
- Studied `chenzlabs/aframe-ar` as an A-Frame AR helper layer for WebXR AR,
  cameras, raycasters, images, anchors, and plane event flows.
- Studied `google/model-viewer` as a production web component for 3D model
  viewing, AR mode selection, Quick Look/Scene Viewer/WebXR fallback, hotspots,
  annotations, and AR UI slots.
- Studied `tentone/enva-xr` as an environment-aware WebXR AR renderer with
  session feature negotiation for hit-test, anchors, planes, light estimation,
  depth sensing, depth textures, and debug depth canvases.

## Reuse candidates

- `mind-ar-js` and `AR.js` are strongest for marker/image/location tracking
  lineage.
- `model-viewer` is strongest for production AR launch, fallback, and hotspot
  UX.
- `aframe-ar` is a useful component wrapper for A-Frame AR concepts.
- `enva-xr` is strongest for environment-aware WebXR AR renderer structure.
- `Simple-AR` is a small starter/reference rather than a deep donor.

## Follow-up backlog

1. Build a browser AR placement matrix: marker, image target, face target,
   location, hit-test, anchors, planes, light, and depth.
2. Compare `model-viewer` fallback launch logic with Quest MR and WebXR
   showcase session feature gating.
3. Extract a lightweight `AR placement utility shell` only if MR helper work
   becomes active.
4. Keep caveats explicit: many WebAR APIs are browser/device/version sensitive.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
