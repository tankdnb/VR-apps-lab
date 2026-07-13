# Wave 459: WebXR HMD display test and controller diagnostics tools

- Date: `2026-07-13`
- Scope: WebXR display-quality pattern creation, headset/controller diagnostic
  scenes, compatibility panels, and small A-Frame diagnostic helpers.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `DIDSR/WebXR-tools` | Studied | WebXR HMD image-quality test patterns |
| `inplayo-com/aframe-interactive-areas` | Studied | Declarative interaction-zone sample |
| `polats/aframe-polats-extras` | Cross-wave reference | Remote-control diagnostics and overlay |
| `bryik/aframe-controller-cursor-component` | Cross-wave reference | Controller ray/pointer diagnostics |

## Why this wave matters

The repo has many runtime/input diagnostics, but display quality and portable
test-pattern authoring are underrepresented. `DIDSR/WebXR-tools` is especially
valuable because it treats WebXR as a standards-friendly way to show identical
test scenes across heterogeneous headsets.

## Project notes

### `DIDSR/WebXR-tools`

- Interesting idea:
  FDA/OSEL regulatory science tool for creating, editing, saving, sharing, and
  displaying HMD image-quality test patterns through WebXR/A-Frame/Three.js.
- Code donor value:
  strong donor for portable test-pattern authoring: scenes/patterns are JSON
  artifacts, editable after upload, grouped into collections, and aimed at
  cross-headset reproducibility.
- Product reference value:
  suggests a future `VR-apps-lab` branch for HMD/display QA utilities:
  resolution, chromatic aberration, geometric distortion, contrast, line spread,
  color mapping, and temporal/spatiotemporal effects.
- Source evidence:
  `README.md`, `paper.md`, `Custom/*`, `TCA/index.html`,
  `TCA/movement.js`, `Compatibility/index.html`,
  `Compatibility/ControllerComponents.js`, and `Compatibility/GraphicsComponents.js`.
- Reusable core:
  pattern scene model, entity list, sliders/text inputs, JSON import/export,
  scene collections, default patterns, WebXR-compatible delivery, compatibility
  view, controller button/axis visualizer, and documentation/paper trail.
- What not to copy:
  regulatory disclaimer text, bundled third-party libraries, old jQuery UI
  structure, or medical-device claims beyond the repo's documented context.
- What to inspect next:
  JSON schema for pattern packages, custom tool entity model, controller
  compatibility components, and export/share compression path.

### `inplayo-com/aframe-interactive-areas`

- Interesting idea:
  small A-Frame scene where declarative interactive areas trigger content and
  audio around a model.
- Code donor value:
  lightweight reference for "diagnostic hotspot" or "review checkpoint" areas
  that can be overlaid onto a model/test scene.
- Product reference value:
  useful when a test scene needs explainable zones: look/click/touch an area,
  play instruction audio, and surface context.
- Source evidence:
  `README.md`, `index.html`, `assets/js/script.js`, `assets/audio/*.mp3`, and
  `assets/models/robot.glb`.
- Reusable core:
  interactive area list, zone events, audio payloads, simple model scene, and
  declarative content hooks.
- What not to copy:
  demo model/audio assets, minified CSS, or one-off scene layout.
- What to inspect next:
  event naming, hotspot data shape, and how zones are authored.

### Cross-wave references

- `polats/aframe-polats-extras` contributes remote-phone controller diagnostics
  and pair-code overlay ideas.
- `bryik/aframe-controller-cursor-component` contributes ray/intersection event
  diagnostics and hover/click state.

## Reusable pattern extraction

- Pattern candidate:
  `portable WebXR HMD test scene`.
- Problem solved:
  make headset display/input checks reproducible across devices without
  requiring Unity/Unreal builds for each headset.
- Reusable core:
  test-pattern JSON, scene/group collection, entity primitives, sliders/inputs,
  import/export/share path, compatibility panel, controller input visualizer,
  device labels, report notes, and caveat/disclaimer block.
- Abstraction boundary:
  pattern authoring owns JSON and UI controls; WebXR scene owns rendering;
  compatibility layer owns controller/device state; reporting layer owns
  reproducible notes and artifacts.
- Method catalog action:
  create a new method for portable WebXR HMD test scenes.

## Caveats

- Display-quality claims need careful wording and controlled measurement
  procedure before being used as validation.
- WebXR portability is helpful, but browser/headset differences still require
  capability labels and date-stamped device notes.
- The strongest reuse is schema/tooling, not medical/regulatory positioning.

