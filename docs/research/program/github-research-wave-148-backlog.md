# GitHub Research Wave 148 Backlog

- Date: `2026-06-05`
- Scope: A-Frame GUI, teleportation, semantic interaction, and menu component
  primitives.

## Completed in this wave

- Studied `rdub80/aframe-gui` as a declarative A-Frame widget library with
  buttons, toggles, sliders, inputs, progress bars, Troika text, hover/focus
  state, and flex-like panel layout.
- Studied `fernandojsg/aframe-teleport-controls` as a compact locomotion helper
  with parabolic and line rays, collision/hit validation, custom start/end
  events, landing normal checks, and camera-rig repositioning.
- Studied `wmurphyrd/aframe-super-hands-component` as a semantic interaction
  layer that normalizes controller, hand, mouse, and touch events into hover,
  grab, stretch, drag, drop, and click reactions.
- Studied `Minty-Crisp/AUXL` as a large A-Frame world/menu factory stack with
  object cores, layers, menu factories, scene/world tracking, inventory,
  movement, weather, and external loading modules.
- Studied `SvetimFM/aframe-webxr-ui-toolkit` as a small lifecycle-managed menu
  registry with `BaseMenu`, `MenuRegistry`, `pressable`, hand-tracking bounds,
  ray/gaze helpers, and cleanup-aware button/text input factories.

## Reuse candidates

- `aframe-gui` is the strongest donor for declarative widget schemas and simple
  layout panels.
- `aframe-teleport-controls` is the strongest small donor for ray-based
  locomotion validation.
- `aframe-super-hands-component` is the strongest donor for semantic
  interaction events across heterogeneous input devices.
- `AUXL` is the strongest product/reference donor for a broad A-Frame utility
  shell and menu factory system.
- `aframe-webxr-ui-toolkit` is the strongest small donor for menu lifecycle and
  hand-tracking pressables.

## Follow-up backlog

1. Extract a small `A-Frame utility menu kit` comparison note across
   `aframe-gui`, `AUXL`, and `aframe-webxr-ui-toolkit`.
2. Compare `super-hands` semantic events with WebXR hand/pinch patterns from
   Wave 144 and engine input services from Wave 147.
3. Prototype a no-build A-Frame settings panel pattern only if a future
   runnable browser utility needs it.
4. Track teleport ray UX against locomotion, comfort, and menu placement
   references from earlier VR menu waves.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
