# GitHub Research Wave 241 Plan

Date: 2026-06-06

Theme: Unity XR UI adapters, grab affordances, and physical control
microcomponents.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Large VR utilities are made of many small interactions. This wave looks for
small Unity XR components that can be reused conceptually: readable UI Toolkit
panels, controller ray-to-panel mapping, text focus bridges, grab indicators,
physical buttons, keypads, hand animation gates, and reveal feedback.

## Search Families

- Unity UI Toolkit XR adapters.
- XRI grab affordance components.
- Physical push button and keypad microcontrols.
- Hand animation and UI proximity helpers.
- Puzzle/game interaction components with reusable control boundaries.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `BernwardWeigand/UnityUIToolkitXRAdapter` | UI Toolkit to XRI bridge with synthetic input device, collider-backed panels, render texture resizing, text focus, and angular-size elements. | Strong UI adapter donor |
| `podobaas/XRGrabInteractableRing` | Tiny grab affordance package with distance threshold, attach transform, scale animation, and events. | Source-light affordance reference |
| `Priyanshu-CODERX/Unity-XR-Interaction-Toolkit-VR-Mechanisms` | XRI mechanism samples for hands, UI proximity, physical push button, grab, teleport, and snap scenes. | Microcomponent donor |
| `Youkaku-1/VRPuzzelGame` | Puzzle control scripts for keypad, button travel, door events, and decal reveal feedback. | Physical control reference |

## Dedupe Notes

Prior waves cover large UI systems, menus, and VRChat/Udon prefabs. This wave
is intentionally smaller and focuses on reusable Unity/XRI control components.

## Code-Level Pass Targets

- UI Toolkit render texture and collider/pointer mapping.
- Synthetic Input System controller state.
- Angular size and font-resizing UI components.
- Grab affordance show/hide and attach-point properties.
- Physical button hover/push lifecycle.
- Keypad event outputs, sound/visual feedback, and door/reveal hooks.

## Expected Outputs

- Wave 241 landscape synthesis.
- Registry/family entries for Unity XR microcomponents.
- Method catalog entry for UI adapter and physical control boundaries.
- Follow-up backlog for a small control-pattern matrix.
