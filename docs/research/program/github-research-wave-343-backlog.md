# GitHub Research Wave 343 Backlog - Physics Hands, Two-Hand Interaction, and Hand Data Capture Baselines

## Executed Scope

- Searched and deduplicated physics hand, two-hand interaction, XR Hands package,
  and WebXR hand prototype projects.
- Froze a four-project shortlist spanning Oculus/Unity physics hands, XRI
  two-hand hackweek interactions, Unity XR Hands package, and WebXR/Three.js hand
  prototypes.
- Read source and documentation statically from local-only cache with LFS
  smudge disabled.
- Extracted force/joint hand following, input-to-bone manipulators, touch/grab
  adapters, dynamic attach points, bow/string/pull measurement, package-level
  hand subsystem APIs, gesture samples, hand capture recording/playback, and
  browser hand input managers.

## Studied Projects

- `oxters168/VRPhysicsHands`
- `emilyslouie/xri-two-hands`
- `needle-mirror/com.unity.xr.hands`
- `sketchpunklabs/xrhand`

## Backlog Findings

- Keep physical hand following separate from semantic gestures and object grab
  rules.
- Model two-hand objects as attachment/constraint systems with explicit primary
  and secondary hand roles.
- Treat hand recording/playback as a core diagnostics utility, not only as a
  gesture authoring feature.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include studied projects.
- Method catalog captures hand interaction/capture decomposition.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
