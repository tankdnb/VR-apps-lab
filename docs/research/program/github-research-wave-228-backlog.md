# GitHub Research Wave 228 Backlog

Date: 2026-06-06

Theme: WebXR hand input, gesture templates, and fallback hand-tracking
primitives.

## Completed In This Wave

- Studied `stewdio/handy.js` as a compact pose-template matcher over WebXR
  hand joints, with wrist-relative pose snapshots, sorted search results, a
  small per-hand search budget, and `pose began` / `pose ended` events.
- Studied `stewdio/vr-hands` as a deprecated but useful lineage prototype
  where fist, horns, and finger-gun gestures directly trigger scene behavior.
- Studied `physicslibrary/Threejs-VR-Hand-Input` as a minimal hand-input recipe
  set for Quest-style joints, pinch distances, palm-up menu visibility, and old
  Three/Oculus model caveats.
- Studied `vrmeup/threejs-webxr-hands-example` as a hand/controller
  unification layer with WebXR required hand tracking, mechanical controller
  fallback, damped pointer rays, and pinch plus palm-facing gates.
- Studied `martatesar/webxr-hands-gestures-recognition` as a wrist-local JSON
  gesture template recognizer and learner that uses the opposite hand pinch as
  a save/confirmation gesture.
- Studied `beemsoft/webxr-handtracking-playground` as a native WebXR plus
  MediaPipe fallback playground with hand landmark meshes, open/stop-hand
  heuristics, Ammo/Cannon proxy joints, and physics interaction.
- Studied `immersive-web/webxr-hand-input` as the canonical hand input
  explainer for 25 joint spaces, `fillPoses`/`fillJointRadii` performance, and
  privacy/security caveats.
- Added a reusable method entry for WebXR hand-pose template and gesture-event
  bridges.

## Follow-Up Queue

1. Build a hand-input matrix comparing wrist-local templates, live joint
   thresholds, palm orientation, pinch gating, temporal gestures, and fallback
   sources.
2. Compare `handy.js`, `webxr-hands-gestures-recognition`, `vrmeup`, and
   `XR Blocks` gesture abstractions after Wave 231.
3. Extract a neutral `hand command event` schema for future overlay/menu tools:
   hand, pose, confidence, started/updated/ended, source, and privacy policy.
4. Revisit privacy and sampling guidance from the spec before any hand-data
   recording prototype is promoted.
5. Compare MediaPipe fallback quality across browser-only and headset-native
   hand sources.

## Do Not Spend Time On Yet

- Do not run browser demos or headset hand-tracking sessions.
- Do not copy old Three/Oculus helper code directly.
- Do not promote pose templates without source evidence and threshold caveats.
