# GitHub Research Wave 117 Backlog

- Date: `2026-06-05`
- Scope: A-Frame/WebXR component ecosystems, inspectors, networked scenes,
  locomotion, in-VR diagnostics, and hand UI helpers.

## Completed in this wave

- Studied `aframevr/aframe` as the canonical declarative WebXR
  entity-component runtime.
- Studied `aframevr/aframe-inspector` as an embeddable visual scene graph and
  component editing devtool.
- Studied `c-frame/aframe-extras` as a locomotion, input-control, navmesh,
  primitive, and misc helper pack.
- Studied `networked-aframe/networked-aframe` as a schema-driven multi-user
  scene synchronization layer with adapter boundaries.
- Studied `supermedium/superframe` as a broad component-pack reference with
  in-VR log, haptics, state, layout, and input normalization components.
- Studied `gftruj/aframe-hand-tracking-controls-extras` as a hand-joint helper
  and pinch locomotion component set.

## Reuse candidates

- `aframe` is the base reference for declarative WebXR components and systems.
- `aframe-inspector` is a strong donor for in-browser scene inspection and
  component editing UI.
- `networked-aframe` is a useful donor for schema-driven sync and pluggable
  transport adapters.
- `superframe` is a pattern-library reference for small browser XR
  micro-components.
- `aframe-hand-tracking-controls-extras` is a focused donor for hand-joint
  helpers and pinch-based UI/locomotion affordances.

## Follow-up backlog

1. Compare A-Frame inspector workflows with Unity/Unreal editor-side XR
   devtools and with browser DevTools style overlays.
2. Extract a reusable browser utility template from A-Frame core plus
   `superframe` log/input components.
3. Compare `networked-aframe` adapter abstraction with WebSocket/OSC bridge
   patterns already cataloged in native overlay waves.
4. Deepen hand-tracking extras against WebXR hand input samples and Godot/Unreal
   hand frameworks.
5. Add future candidates such as `AdaRoseCannon/handy-work` or other WebXR hand
   utility libraries if a follow-up hand UI wave is needed.

## Quality notes

- No third-party project was built or launched.
- Downloaded source clones belong only in local cache and should be removed
  after the wave is committed.
- The wave intentionally focuses on reusable browser utility composition, not
  on shipping a WebXR app.
