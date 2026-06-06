# GitHub Research Wave 205 Plan

- Date: `2026-06-06`
- Theme: `A-Frame UI, locomotion, environment, and physics micro-components`
- Scope: small A-Frame components for cursor teleport, keyboards, teleport
  rotation, environment presets, daylight, environment maps, physics, and
  React-to-A-Frame attribute bridging.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier A-Frame waves covered inspectors, GUI, networked scenes, hand UI, and
broader WebXR component ecosystems. Wave 205 focuses on reusable component
primitives: narrow packages that solve one UX or runtime problem through a
schema, event hooks, and scene-bound lifecycle.

## Search Families

- A-Frame locomotion micro-components
- A-Frame keyboard/text-entry surfaces
- A-Frame environment and daylight generators
- A-Frame physics systems and worker drivers
- React-to-A-Frame scene bridges
- A-Frame environment-map helpers

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `c-frame/aframe-cursor-teleport` | Desktop/mobile cursor teleport fallback for A-Frame scenes | Locomotion micro-component |
| `supermedium/aframe-super-keyboard` | Texture-atlas keyboard with raycaster UV key selection | Text-entry component donor |
| `supermedium/aframe-environment-component` | Declarative environment and preset generator | Scene context component |
| `n5ro/aframe-physics-system` | Driver-backed physics system with local, worker, network, and ammo modes | Runtime substrate donor |
| `supermedium/aframe-react` | React wrapper that diffs props into A-Frame entity attributes and events | Framework bridge reference |
| `topstar-ai/aframe-blink` | Teleport controls with rotation, trajectory feedback, and target events | Locomotion UX donor |
| `EX3D/aframe-daylight-system` | Time/location driven sky, fog, and sun-position component | Environment micro-reference |
| `msfeldstein/aframe-environment-map-component` | Environment-only CubeCamera capture and PMREM application | Rendering helper reference |

## Dedupe Notes

- Already tracked A-Frame GUI, teleport controls, networking, hand UI, and
  official examples were excluded.
- Thin repos were retained only when they show a reusable component contract or
  one strong UX behavior.
- `aframe-react` is included as a framework-boundary reference, not as a modern
  React recommendation.

## Code-Level Pass Targets

- Component schema design, event outputs, and lifecycle hooks.
- Raycaster-to-target or raycaster-to-UV input flow.
- Teleport gating, target indicators, slope/normal handling, and rotation.
- Environment preset generation and scene context defaults.
- Physics system driver boundary, worker interpolation, and entity/body sync.
- Attribute/event diffing between React and A-Frame.

## Expected Outputs

- Wave 205 landscape synthesis.
- Registry/family placement for A-Frame component primitives.
- Methods around declarative component contracts, scene physics driver
  boundaries, and ray/UV keyboard or teleport UI.
