# VR Projects Wave 432: Unity XRI Controller Event Emitter Microtool

Date: 2026-07-13

Theme: a tiny Unity XR Interaction Toolkit wrapper that converts controller
feature polling into simple static event streams for prototypes and teaching
projects.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `Volorf/XR-Emitter` | Unity XRI controller event microtool | Code-level pass |

## Project Note: `Volorf/XR-Emitter`

- Interesting idea: wrap Unity XRI controller feature reads into static C# events
  so scene scripts can subscribe to trigger, grip, button, and joystick state
  without holding controller references.
- Code donor value: compact `XREmitterR`/`XREmitterL` classes, explicit event list,
  demo UI subscribers, controller visual feedback scripts, and simple package-like
  distribution through `.unitypackage`.
- Product reference value: useful as a small input facade for VR utility samples,
  tutorials, and prototypes where full Input System action maps feel heavy.
- Architecture pattern: per-hand MonoBehaviour reads `XRController.inputDevice`
  each frame and publishes static events typed as `float`, `bool`, or `Vector2`.
- Reusable method: `XR controller feature-to-event facade`.
- UX/product lesson: event streams make quick prototype scripts readable, but the
  facade must explain lifetime, unsubscribe, and per-hand ownership clearly.
- Caveats: static events can leak subscribers across scene reloads, polling occurs
  every frame, left/right classes are duplicated, and the package predates newer
  action-based XRI patterns.
- Source evidence: README lists event signatures and setup; `XREmitterR.cs` calls
  `TryGetFeatureValue` for `CommonUsages.trigger`, `triggerButton`,
  `primary2DAxis`, `primaryButton`, `secondaryButton`, `grip`, and related touch
  states, then invokes static events.
- Reusable core: feature map, typed event surface, per-hand component, demo
  subscriber, unsubscribe pattern, and missing-controller warning.
- What not to copy: duplicated left/right classes, global static lifecycle without
  reset, and frame-by-frame events without change detection.
- Method catalog action: add a Unity XR input event facade method.
- What to inspect next: compare against action-based Input System events and a
  ScriptableObject event-channel version.

## Reusable Pattern Extraction

- Pattern candidate: `XR input feature event facade`.
- Problem solved: small VR prototypes need controller input signals without
  wiring full interaction graphs or action-map plumbing into every script.
- Reusable core: per-hand input provider, typed event catalog, change detection,
  lifecycle-safe subscription, and demo inspector examples.
- Source evidence: `Volorf/XR-Emitter` demonstrates the minimal wrapper and demo
  subscriptions.
- Abstraction boundary: feature polling and event naming are reusable; static
  global events and duplicated classes should be replaced in production.

## Follow-Up Gaps

- Build a neutral event facade that supports action-based XRI, OpenXR actions,
  simulator input, and headsetless tests.
- Add stale-device and subscription diagnostics for event-driven input helpers.
