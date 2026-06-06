# GitHub Research Wave 241 Backlog

Date: 2026-06-06

Theme: Unity XR UI adapters, grab affordances, and physical control
microcomponents.

## Completed In This Wave

- Studied `BernwardWeigand/UnityUIToolkitXRAdapter` as a strong UI adapter
  donor with `XRInteractableUIDocument`, collider-backed UI Toolkit panels,
  `UIToolkitXRController` synthetic Input System state, ray position mapping,
  `RenderTextureResizer`, text-field focus bridge, and angular-size UI
  elements.
- Studied `podobaas/XRGrabInteractableRing` as a source-light grab affordance
  reference documenting prefab, color, attach transform, show-on-selected,
  raycast layer, distance threshold, scale bounds, animation timing, and
  show/hide events.
- Studied `Priyanshu-CODERX/Unity-XR-Interaction-Toolkit-VR-Mechanisms` as a
  microcomponent donor with UI proximity events, hand animation action mapping,
  hand visibility on grab, `XRPushButton`, and mechanism scenes for grab,
  teleportation, UI, snap, hands, and physical buttons.
- Studied `Youkaku-1/VRPuzzelGame` as a physical-control reference with keypad
  input, accepted/denied feedback, emissive screen state, button press
  animation, door events, and decal reveal triggers.
- Added a reusable method entry for Unity XR UI adapter and physical-control
  microcomponent boundaries.

## Follow-Up Queue

1. Compare Unity UI Toolkit XR adapter patterns with MRTK, uGUI, and spatial
   UI packages already in the repository.
2. Build a control-pattern matrix for push buttons, keypads, grab affordances,
   ray panels, poke panels, wrist menus, and radial menus.
3. If a prototype needs these, design a clean local sample instead of importing
   third-party project assets.

## Do Not Spend Time On Yet

- Do not import Unity assets or run Unity projects.
- Do not treat `XRGrabInteractableRing` as source-audited until release package
  contents are inspected.
- Do not copy educational or game-scene template code without adapting APIs and
  ownership boundaries.
