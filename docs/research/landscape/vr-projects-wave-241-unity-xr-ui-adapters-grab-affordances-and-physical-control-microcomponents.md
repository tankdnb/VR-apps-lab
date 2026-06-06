# VR Projects Wave 241: Unity XR UI Adapters, Grab Affordances, and Physical Control Microcomponents

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies small Unity XR interaction building blocks: UI Toolkit ray
adapters, angular-size UI elements, grab affordance rings, physical push
buttons, hand animation gates, keypad interactions, and reveal/feedback
microcontrols.

## Why It Matters For `VR-apps-lab`

Reusable VR utility work often fails in the small controls: readable UI at
distance, pointer-to-panel mapping, clear grabbable affordance, physical button
states, keypad feedback, and hand animation that does not fight UI intent.
These projects are useful because they isolate those micro-patterns better than
large apps do.

## Project Notes

### `BernwardWeigand/UnityUIToolkitXRAdapter`

- Interesting idea:
  adapt XR controller rays into Unity UI Toolkit instead of falling back to
  world-space Canvas for every VR panel.
- Code donor value:
  `XRInteractableUIDocument.cs` creates a collider matching a rendered
  `UIDocument`, registers text fields, and activates `XRTextInput` on focus.
  `UIToolkitXRController.cs` registers a synthetic Input System device with a
  `uiToolkitLocalPosition` control, finds left/right `XRController` objects,
  raycasts into `XRInteractableUIDocument`, focuses the matching UI Toolkit
  panel, and queues pointer state. `RenderTextureResizer.cs` maps UI Toolkit
  panel output into a render texture/RawImage and updates target texture size.
  The angular-resizing classes add `AngularResizingVisualElement`,
  angular-font labels/buttons/text fields, and resize utilities based on
  camera distance and pixels-per-meter.
- Product reference value:
  strong donor for future VR settings panels that want modern UI Toolkit
  styling without losing controller ray input.
- What to inspect next:
  test the concept later in a small prototype only if a runnable UI Toolkit
  panel is intentionally added to `VR-apps-lab`.
- Architecture pattern:
  UI Toolkit render-texture surface plus collider, synthetic input device, ray
  position conversion, text focus bridge, and angular-size elements.
- Reusable method:
  separate visual UI framework from XR pointer transport by injecting a small
  synthetic Input System device.
- Caveats:
  older Unity/XRI assumptions, dominant-hand bias, and dependency on UI Toolkit
  panel internals.

### `podobaas/XRGrabInteractableRing`

- Interesting idea:
  grabbable-object affordance can be packaged as a tiny visual ring component
  instead of being rebuilt per object.
- Code donor value:
  sparse pass found README/release-level documentation rather than source. The
  documented component exposes model prefab, color, self/custom attach
  transform, show-on-selected behavior, raycast layer mask, threshold distance,
  min/max scale, animation speed/duration, and on-show/on-hide events.
- Product reference value:
  useful product/UX reference for "what can I grab?" feedback in cluttered VR
  utility scenes.
- What to inspect next:
  inspect release package source or asset contents if this becomes a concrete
  affordance donor.
- Architecture pattern:
  thresholded ray/proximity affordance with scale animation and show/hide
  events.
- Reusable method:
  treat grab affordance as an attach-point-aware, event-emitting component.
- Caveats:
  no source code in the sparse repository checkout; treat as source-light until
  release assets are inspected.

### `Priyanshu-CODERX/Unity-XR-Interaction-Toolkit-VR-Mechanisms`

- Interesting idea:
  a course-like mechanism repo is valuable as a menu of small XRI patterns:
  hands, UI proximity, push buttons, grab, teleport, snap, and selectable
  object scenes.
- Code donor value:
  `CloseToUICollision.cs` raises enter/exit events when a hand enters an
  `InteractiveUI` layer. `HandAnimator.cs` maps grip, trigger, and primary
  actions to separate finger sets and temporarily switches animation behavior
  while near UI. `HandVisibilityToggle.cs` hides/shows hand meshes on grab
  events. `XRPushButton.cs` subclasses `XRBaseInteractable`, tracks hover
  interactor movement, clamps local button travel, and invokes `OnPushed` once
  when the button reaches its push depth. Scenes cover grab, teleportation area
  and anchor, UI interaction, snap interaction, hands, and 3D buttons.
- Product reference value:
  good micro-pattern donor for physical controls, hand affordance, and starter
  interaction scenes.
- What to inspect next:
  compare `XRPushButton` against more mature poke/button components before
  copying the interaction lifecycle.
- Architecture pattern:
  standalone mechanism scenes with small scripts for one interaction behavior
  each.
- Reusable method:
  isolate physical controls as event-emitting interactables that own only
  local travel, threshold, and one-shot press state.
- Caveats:
  educational baseline, some API names are older XRI, and hand animation code
  has rough edges.

### `Youkaku-1/VRPuzzelGame`

- Interesting idea:
  puzzle-game projects can still be useful as compact physical control
  references when they expose keypad, lock, reveal, and scene-progression
  scripts.
- Code donor value:
  `Keypad.cs` stores a numeric combination, blocks extra input while displaying
  result, changes emissive panel color, plays accepted/denied/button sounds,
  and fires `UnityEvent` hooks. `KeypadButton.cs` sends value to the keypad and
  animates press/release travel. `SlidingDoor.cs` exposes open/close/toggle
  animator gates. `DecalReveal.cs` fades a URP `DecalProjector` when a
  spotlight collider enters or exits. Scenes contain XRI grab, socket,
  teleport, poke, hand, and puzzle surfaces.
- Product reference value:
  useful reference for physical keypad/door/checklist style utility controls.
- What to inspect next:
  find main game manager scripts if a deeper puzzle-flow study is needed.
- Architecture pattern:
  event-driven physical keypad with visual/audio feedback and environment
  state outputs.
- Reusable method:
  use `UnityEvent` boundaries on physical controls so puzzle/tool state can be
  swapped without rewriting the control itself.
- Caveats:
  many asset-store/template files, recovery scenes, and game-specific content;
  use only the small control scripts as donors.

## Reusable Pattern Extraction

- Pattern candidate:
  Unity XR microcomponent boundary for UI panels and physical controls.
- Problem solved:
  VR tools need many tiny reliable interactions, but each should stay reusable:
  panel pointer mapping, distance-readable UI, grabbable affordance, push
  button, keypad, hand animation, and reveal feedback.
- Reusable core:
  make each control own one job, emit events at the edge, separate rendering
  from pointer transport, keep distance/readability policies explicit, and
  avoid burying utility logic inside scene-specific prefabs.
- Source evidence:
  `UnityUIToolkitXRAdapter`, `XRGrabInteractableRing`,
  `Unity-XR-Interaction-Toolkit-VR-Mechanisms`, and `VRPuzzelGame`.
- Abstraction boundary:
  UI Toolkit adapter code should not own business logic; grab affordance should
  not own object behavior; physical controls should emit events rather than
  directly mutating unrelated systems.
- What not to copy:
  template assets, course-scene assumptions, old API surfaces without review,
  or source-light release packages as if they were audited code.
- Method catalog action:
  add a method entry for Unity XR UI adapter and physical-control
  microcomponent boundaries.

## Follow-Up Gaps

- Compare UI Toolkit XR adapter shape with MRTK and prior spatial UI waves.
- Build a control-pattern matrix across push buttons, keypads, grab rings,
  ray panels, poke panels, wrist menus, and radial menus.
- If a future prototype needs this, create a tiny `samples/unity-xr-controls`
  plan rather than importing any third-party project wholesale.
