# GitHub Research Wave 207 Plan

- Date: `2026-06-06`
- Theme: `React/Three XR runtime, spatial UI, and interaction lab surfaces`
- Scope: React Three XR runtime/store architecture, spatial UI layout/input,
  WebXR interaction playground shells, teleport/measurement microtools, AR GLB
  viewer starter, and hand-tracked product UI reference.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier WebXR waves identified `pmndrs/xr` and browser-native XR utilities as
important but not fully deepened in the current documentation style. Wave 207
revisits React/Three XR as a runtime and UI substrate: session/input state,
pointer events, teleport, spatial UI, lab shells, and small starter utilities.

## Search Families

- React Three XR runtime wrappers
- spatial UI layout/input substrates
- WebXR interaction playgrounds and lab shells
- React/WebXR teleport and measurement microtools
- AR GLB viewer starters
- hand-tracked overlay/product UI references

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `pmndrs/xr` | Modern React/Three XR store, input state, pointer, teleport, hand/controller, layer, and feature substrate | Strong runtime donor, deepening pass |
| `pmndrs/uikit` | 3D UI layout/render/input substrate with Yoga, pointer events, text input, scroll, clipping, and kits | Strong spatial UI donor |
| `kewanglab/webxr-playground` | Interaction lab shell for selection, placement, locomotion, manipulation, live tuning, HUD, and session logs | Strong product/reference donor |
| `WawasCode/DefaultReactXR` | Minimal React Three XR + Vite + UIKit starter | Thin starter reference |
| `randykeller11/xrTeleport` | Basic React Three XR teleport and snap-rotation logic | Locomotion micro-reference |
| `alxxtexxr/react-three-xr-measurement` | AR hit-test measurement microtool | AR measurement micro-reference |
| `BOLTEVM/BoltXR` | Spatial wallet with WebXR scene, hand-tracked overlay, IWER emulation flag, and 3D panels | Hand/product UI reference with caveats |
| `aazutaku/glb-ar-viewer` | Next.js GLB AR viewer with WebXR/dom-overlay and iOS launcher fallback | AR model viewer reference |

## Dedupe Notes

- `pmndrs/xr` was already partially studied, so this is an intentional
  deepening pass, not a duplicate new entry.
- Starter repos are retained only as micro-reference nodes.
- Product-specific crypto or commerce logic in `BoltXR` is out of scope; only
  XR UI/input/emulation boundaries are studied.

## Code-Level Pass Targets

- XR store state, session lifecycle, `WebXRManager` binding, input-source
  synchronization, layers, frame hooks, emulator injection, and React boundary.
- Pointer event model, teleport target filters, ray model, and visibility sync.
- Spatial UI flex/Yoga layout, panel clipping, pointer order, scroll behavior,
  text selection, and hidden DOM input bridge.
- Interaction lab registry, XR root, origin control, HUD, live tuning,
  session logger, and manipulation techniques.
- Small starter/microtool patterns for enter XR buttons, teleport, snap turn,
  AR measurement, model viewer controls, and hand landmark gestures.

## Expected Outputs

- Wave 207 landscape synthesis.
- Registry/family placement for React/Three XR runtime and spatial UI surfaces.
- Methods around XR store/runtime substrate, spatial UI layout/input substrate,
  and interaction lab shell.
