# GitHub Research Wave 144 Backlog

- Date: `2026-06-05`
- Scope: WebXR hand tracking, pinch interactions, fingertip rays, A-Frame hand
  UI, and hand-pose WebSocket export.

## Completed in this wave

- Studied `marlon360/webxr-handtracking` as a compact WebXR hand-tracking
  playground with joint meshes, A-Frame components, pinch gesture events,
  fingertip raycasting, hand physics hooks, and drawing examples.
- Studied `TakashiYoshinaga/webxr-hand-tracking-sample` as a minimal
  pinch-to-place sample where the right hand creates objects and the left hand
  clears the scene.
- Studied `rick98033/webxr-hand-tracking-websocket` as a Babylon.js bridge that
  extracts selected hand joints and streams them as rate-limited JSON over
  WebSocket.
- Studied `danielklinkhammer/webxr-quest2` as a single-file Quest/A-Frame AR
  hand interaction reference with pinch midpoint grabbing, hover/active colors,
  passthrough-friendly transparent background, and fallback ray controls.

## Reuse candidates

- `marlon360/webxr-handtracking` is the strongest donor for low-level
  `XRHand` pose extraction, A-Frame hand components, pinch hysteresis, and
  fingertip raycasting.
- `rick98033/webxr-hand-tracking-websocket` is the strongest donor for turning
  browser hand tracking into a reusable external data product.
- `danielklinkhammer/webxr-quest2` is a good micro-product reference for
  passthrough hand object manipulation.
- `TakashiYoshinaga/webxr-hand-tracking-sample` is useful as the smallest
  possible event-driven pinch drawing example.

## Follow-up backlog

1. Compare WebXR hand-pose JSON with OSC/VMC/SlimeVR tracker payloads from
   previous bridge waves.
2. Extract a small `hand gesture vocabulary` note covering pinch start, pinch
   release, fingertip ray, squeeze emulation, and hover feedback.
3. Consider a browser-backed diagnostic prototype that streams hand joint
   availability and latency to a local service.
4. Revisit A-Frame hand UI patterns from Wave 117 and link the strongest
   components into the same family group.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
