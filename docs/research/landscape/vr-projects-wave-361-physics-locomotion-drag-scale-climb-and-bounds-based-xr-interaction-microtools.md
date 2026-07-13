# Wave 361: Physics Locomotion Drag Scale Climb and Bounds Based XR Interaction Microtools

## Scope

This wave studies compact locomotion and interaction projects that can donate
small reusable modules: physics body rigs, drag/rotate/scale movement, climbing,
fixed-joint grabbing, and bounds-based buttons. The goal is to extract module
boundaries rather than promote any one locomotion style.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `KavanBahrami/XRDrag` | Studied | Unreal VR drag locomotion component for moving, rotating, and scaling a pawn from controller grip input |
| `pierricklyons/real-motion-vr` | Studied | Unity physics-based player controller with locomotion sphere, hexabody/capsule rig, spring spine, crouch, jump, grab, and climb modules |
| `DuckiesGaems/EasyXR` | Studied | Lightweight Unity interaction toolkit with bounds-based buttons, cooldowns, debug/editor tooling, and physics/non-physics climbing |

## Reusable Pattern Extraction

- Pattern candidate: `physics locomotion and bounds interaction microtool
  boundary`.
- Problem solved: movement-heavy VR projects need reusable locomotion modules
  that do not entangle body physics, input state, grabbing, UI activation, and
  comfort rules.
- Reusable core: input adapter, body/rig model, movement target, head/camera
  delta, controller delta, external force channel, crouch/jump module, climb
  detector, grab joint, drag/rotate/scale component, bounds button, cooldown,
  haptic/visual feedback, input-conflict matrix, and safety labels.
- Source evidence: real-motion-vr exposes `MovementController`,
  `PhysicsRig`, `SpineController`, `CrouchController`, `JumpController`, and
  `SimpleFixedJointGrab`; EasyXR exposes `XRButton` and `XREasyGrab`; XRDrag
  frames drag/rotate/scale as an ActorComponent controlled by grip input.
- Abstraction boundary: locomotion modules should emit movement intents or
  forces; interaction widgets should emit button/grab events; comfort/safety and
  input conflict handling should sit above both.
- What not to copy: raw physics impulses without comfort labels, grip bindings
  that conflict with grabbing/shooting, Blueprint-only assumptions, or
  collider-free activation without debug visualization.
- Method catalog action: create a new physics locomotion and bounds interaction
  method.

## Project Notes

### `KavanBahrami/XRDrag`

- Interesting idea: drag locomotion is packaged as a modular Unreal component
  that moves, rotates, and scales the VR pawn from controller grip gestures.
- Code donor value: moderate as an architecture and input-mapping reference,
  especially for separating drag/rotate/scale from the pawn.
- Product reference value: strong for editor-like navigation, tabletop-scale
  worlds, and non-joystick movement concepts.
- What to inspect next: Blueprint graph details, input conflict handling, plane
  locks, and comfort safeguards around scale changes.
- Caveats: mostly Unreal assets/Blueprints; reuse the component boundary and
  conflict notes, not binary assets.

### `pierricklyons/real-motion-vr`

- Interesting idea: the player body is treated as a physics rig where a
  locomotion sphere blends real movement, controller input, external forces,
  spring spine damping, crouch, jump preload, and climbing.
- Code donor value: very high for physics-rig decomposition, movement blending,
  fixed-joint grabbing, jump/crouch modules, and IK/body scaling reference.
- Product reference value: strong for body-aware prototypes and physical object
  interaction labs.
- What to inspect next: PID tuning, sickness/comfort constraints, IK scaling,
  and object mass limits.
- Caveats: physics locomotion can be comfort-sensitive; do not copy force values
  or assume it is safe without labels and testing.

### `DuckiesGaems/EasyXR`

- Interesting idea: useful VR interactions can be tiny event-driven components:
  a bounds/cooldown button and a climb grab helper that avoids heavy Update
  loops.
- Code donor value: high for `XRButton`, `XREasyGrab`, bounds checks,
  cooldowns, debug/editor utilities, and layer-based climb detection.
- Product reference value: strong for micro-utilities and Gorilla-style
  interaction prototypes.
- What to inspect next: haptics, accessibility affordances, non-rigidbody
  fallback behavior, and conflict with XRDirectInteractor.
- Caveats: lightweight does not mean complete; add visible debug and conflict
  states before reuse.

## Product Direction

This wave supports an `XR interaction microtools` branch: small reusable modules
for drag-scale navigation, body physics, climbing, and bounds buttons can be
documented as independent building blocks for future VR utility prototypes.

