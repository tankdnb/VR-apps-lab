# Wave 375: Tilia Haptics PseudoBody Hand Visuals and Collision Faders

## Theme

Feedback, embodiment, body collision, and comfort visual modules for reusable
VR utility shells.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `ExtendRealityLtd/Tilia.Output.InteractorHaptics.Unity` | Studied | Interactor-to-controller haptic routing through tracked alias and profiles |
| `ExtendRealityLtd/Tilia.Trackers.PseudoBody.Unity` | Studied | Collidable pseudo-body that follows a source while detecting divergence and grounding |
| `ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity` | Studied | Basic controller/hand visual package for spatial controller representation |
| `ExtendRealityLtd/Tilia.Visuals.CollisionFader.Unity` | Studied | Collision-triggered camera overlay/fade module with source and rule validity |

## Dedupe Notes

`ExtendRealityLtd/Tilia.Visuals.Vignette.Unity` was already studied in Wave
292, so it is not re-added. This wave studies adjacent Tilia feedback/body
modules that were not yet present in registry/families.

## Code-Level Findings

### `ExtendRealityLtd/Tilia.Output.InteractorHaptics.Unity`

- Interesting idea: route haptics from an `InteractorFacade` to the correct
  tracked controller through a tracked alias, queued interactor, profile, and
  intensity.
- Code donor value: `InteractorHapticsFacade` shows left/right interactor
  mapping, queued haptic execution, profile selection, intensity, and cancel
  flows.
- Product reference value: useful for overlay buttons, object docking,
  diagnostics alerts, pointer hover/activate feedback, and accessibility
  confirmation pulses.
- What to inspect next: configurator mapping to `UnityEngine.XR` haptic calls
  and profile storage.
- Caveat: haptics need device capability checks and non-annoying defaults.

### `ExtendRealityLtd/Tilia.Trackers.PseudoBody.Unity`

- Interesting idea: build a collidable body proxy that tracks an HMD/source but
  can detect divergence, prevent entering geometry, handle ground/air/jump
  events, and ignore selected objects.
- Code donor value: `PseudoBodyFacade` exposes source/offset, external
  position mutators, collision prevention, body radius/thickness, divergence
  thresholds, ignored objects, and grounding events.
- Product reference value: useful for locomotion helpers, safety boundaries,
  object interaction constraints, training simulations, and body-relative
  utility placement.
- What to inspect next: processor divergence resolution and interaction with
  locomotion mutators.
- Caveat: body proxies are opinionated; keep them optional and transparent.

### `ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity`

- Interesting idea: package simple hand/controller visuals separately from
  interaction logic so tools can provide presence without owning a full avatar
  stack.
- Code donor value: repo is useful as a visual asset/package boundary and
  basic representation pattern rather than as a large code donor.
- Product reference value: lightweight hand/controller visuals are valuable
  for diagnostics, onboarding scenes, simulator rigs, and menu affordances.
- What to inspect next: prefab hierarchy, material swap points, and controller
  model mapping.
- Caveat: do not treat basic hands as accessibility or avatar embodiment by
  themselves.

### `ExtendRealityLtd/Tilia.Visuals.CollisionFader.Unity`

- Interesting idea: collision feedback is split into a source-following collider
  container, camera overlay container, camera validity rules, collision
  validity rules, and fade/unfade events.
- Code donor value: `CollisionFaderFacade` is a compact module for fade-on-wall
  or fade-on-invalid-space behavior.
- Product reference value: useful for comfort, boundary warnings, camera
  clipping prevention, physical-space safety, and debugging invisible collider
  problems.
- What to inspect next: overlay material/render pipeline implementation.
- Caveat: fade feedback should explain why it happened when used in utilities.

## Reusable Pattern Extraction

- Pattern candidate: feedback and body-safety module shell.
- Problem solved: VR utility tools need feedback, haptics, body proxies, and
  safety fades without coupling every feature to controller, avatar, or camera
  internals.
- Reusable core: interactor-to-device mapper, haptic profile, feedback queue,
  cancel path, body proxy source/offset, divergence detector, collision
  validity, ignored objects, grounding events, hand visual boundary, camera
  overlay boundary, and user-facing explanation state.
- Source evidence: `InteractorHapticsFacade`, `PseudoBodyFacade`,
  `CollisionFaderFacade`, and BasicHand package/prefab boundary.
- Abstraction boundary: feature state emits feedback intent; device-specific
  haptics, body physics, and camera overlays stay behind modules.
- What not to copy: vibration-heavy defaults, hidden body correction, avatar
  assumptions, or camera fading without diagnostics.
- Method catalog action: add Method 820.

## Family Placement

This wave creates a family for haptic feedback, pseudo-body collision, hand
visuals, and collision fading. It complements comfort, locomotion, interaction,
and accessibility families.

## Why It Matters for `VR-apps-lab`

Overlay and utility tools need trustworthy feedback and safety affordances. This
wave adds reusable implementation language for haptics, body proxies, and
collision-triggered visual feedback.

## Follow-Up Gaps

- Compare collision fader and pseudo-body ideas with previously studied comfort
  and boundary tools.
- Draft feedback intensity guidelines for utility overlays.
- Investigate a minimal haptic intent schema independent of Unity/Tilia.
