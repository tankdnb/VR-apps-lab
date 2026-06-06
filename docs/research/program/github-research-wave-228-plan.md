# GitHub Research Wave 228 Plan

Date: 2026-06-06

Theme: WebXR hand input, gesture templates, and fallback hand-tracking
primitives.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Recent waves already cover hand tracking in broad WebXR and controller
families, but future VR utility tools still need smaller reusable primitives:
hand-pose templates, wrist-local gesture capture, pinch/palm menu triggers,
controller fallback, and privacy/performance caveats from the WebXR hand input
spec.

## Search Families

- WebXR hand tracking examples.
- Hand-pose template and gesture-recognition libraries.
- Pinch, palm, wrist, and finger-joint UI recipes.
- MediaPipe-to-WebXR fallback experiments.
- Browser spec and explainer material for hand input.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `stewdio/handy.js` | Compact WebXR hand-pose template matcher with pose events and bounded search budget. | Hand-pose recognizer |
| `stewdio/vr-hands` | Deprecated but useful ancestor showing direct gesture-to-UX bindings. | Gesture prototype lineage |
| `physicslibrary/Threejs-VR-Hand-Input` | Tiny Quest hand input examples with pinch and palm-up recipes. | Hand-input micro-recipes |
| `vrmeup/threejs-webxr-hands-example` | Unified hand/controller pointer abstraction with damped pinch pointer. | Hand/controller input abstraction |
| `martatesar/webxr-hands-gestures-recognition` | TypeScript wrist-local gesture templates and in-headset learner flow. | Gesture template learner |
| `beemsoft/webxr-handtracking-playground` | Native WebXR plus MediaPipe fallback and physics proxy hand joints. | Fallback hand pipeline |
| `immersive-web/webxr-hand-input` | Spec/explainer reference for joint model, performance, and privacy. | API boundary reference |

## Dedupe Notes

The shortlist avoids already-studied broad WebXR hand families and focuses on
hand input primitives that can update the methods catalog. `vr-hands` is
included only as lineage because the author points users to `handy.js`.

## Code-Level Pass Targets

- Wrist-local pose capture and comparison.
- Pose events and gesture state transitions.
- Pinch, palm, and pointer gating thresholds.
- Controller fallback and unified input abstraction.
- MediaPipe/browser fallback boundaries.
- WebXR hand input performance and privacy caveats.

## Expected Outputs

- Wave 228 landscape synthesis.
- Registry/family entries for hand-pose and hand-input primitives.
- Method catalog entry for WebXR hand-pose template bridges.
- Follow-up backlog for hand gesture matrices and privacy/performance review.
