# Wave 404: VR Physics Interaction, Grab Joints, and Hand Templates

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device tests.

## Theme

This wave studies physics-first VR interaction packages and templates. The
reusable value is not simply object grabbing; it is the boundary between a
tracked controller, a physical hand/body, attach points, object velocity,
collision feedback, and release/throw semantics.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `TomorrowTodayLabs/NewtonVR` | Studied | Unity physics interaction toolkit |
| `JScott/ViveGrip` | Studied | ConfigurableJoint-based grab abstraction |
| `JLPM22/VRPhysicsInteractionUnity` | Studied with caveats | Quest physics interaction course project |
| `jtnicholl/godot4-vr-physics-template` | Studied | Godot 4 physical hand template |

## Findings

### `TomorrowTodayLabs/NewtonVR`

- Interesting idea: a mass/physics-oriented Unity interaction framework where
  held objects are driven by rigidbody velocity and attach-point relationships
  rather than direct transform parenting.
- Code donor value: `NVRInteractableItem`, `NVRAttachJoint`,
  `NVRAttachPoint`, `NVRHand`, `NVRPhysicalController`, `NVRLever`,
  `NVRSlider`, `NVRButton`, and SDK integration wrappers.
- Product reference value: strong baseline for future grab/lever/switch
  utilities that need believable physical response and two-hand averaging.
- What to inspect next: exact drop thresholds, external velocity injection,
  two-hand attach semantics, and how SDK adapters map controller state.
- Caveat: old Unity/SteamVR/Oculus assumptions need adapter isolation before
  reuse.

### `JScott/ViveGrip`

- Interesting idea: a focused abstraction over Unity `ConfigurableJoint` for
  highlighting, grabbing, levers, dials, guns, and weighted objects.
- Code donor value: useful as a smaller comparison point for joint-based grab
  constraints and example-driven affordance design.
- Product reference value: good reminder that a physics toolkit can be a
  coherent small package with inspectable example scenes instead of a full
  framework.
- What to inspect next: joint parameter presets, highlight pipeline, and
  object affordance component taxonomy.
- Caveat: legacy Vive/SteamVR framing should be treated as runtime-specific
  shell, not reusable core.

### `JLPM22/VRPhysicsInteractionUnity`

- Interesting idea: a compact Oculus Quest project around nearby-object
  highlighting, lateral trigger grab, and physics object handling.
- Code donor value: modest; useful mostly for comparing simple highlight/grab
  UX against richer packages.
- Product reference value: confirms the value of making candidate objects
  visually obvious before grab activation.
- What to inspect next: hand selection radius, feedback timing, and whether
  collision/grab state is cleanly separated from Oculus packages.
- Caveat: large vendor/sample surface; do not copy project structure directly.

### `jtnicholl/godot4-vr-physics-template`

- Interesting idea: Godot 4 template where VR hands are `RigidBody3D` nodes,
  controller anchors can be blocked by walls, and grabbing/release is kept in
  compact GDScript components.
- Code donor value: `vr_hand.gd`, `vr_controller.gd`, `pickup.gd`,
  `grabbable.gd`, `hand_anchor.gd`, and teleporter/player scripts.
- Product reference value: strong engine-neutral lesson: hand collision should
  be a first-class physical affordance, not only a controller pose visual.
- What to inspect next: joint setup, glove deformation states, teleport
  interaction with physical hands, and impulse calculation for throwing.
- Caveat: template is intentionally small; reuse as method grammar, not as a
  complete app.

## Reusable Pattern Extraction

- Pattern candidate: `Physics-based hand interaction envelope`.
- Problem solved: VR tools need grabs that feel physical while still allowing
  controller tracking, collision, attach points, throwing, and simple object
  affordances to coexist.
- Reusable core: tracked controller anchor, physical hand/body proxy, candidate
  hover/highlight state, attach point, attach/drop distance thresholds,
  velocity matching, angular velocity matching, collision material handling,
  release impulse, two-hand averaging, and fallback SDK adapter.
- Source evidence: `NVRInteractableItem` computes target hand/item values and
  drives rigidbody velocity; `NVRAttachJoint` pulls attach points and detaches
  beyond `DropDistance`; Godot `vr_hand.gd` updates a `RigidBody3D` hand inside
  `_integrate_forces`; `pickup.gd` freezes/reparents held objects and applies
  release impulse.
- Abstraction boundary: keep input adapters, physical hand proxy, object
  affordance, and release/throw policy separate.
- What not to copy: old vendor SDK bindings, hard-coded controller mappings,
  sample-scene object names, or transform-only grab shortcuts that erase
  collision semantics.
- Method catalog action: add Method 849.

