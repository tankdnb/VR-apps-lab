# GitHub Research Wave 205 Backlog

- Date: `2026-06-06`
- Theme: `A-Frame UI, locomotion, environment, and physics micro-components`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for A-Frame teleport, keyboard, physics, environment,
  daylight, environment-map, and React bridge components.
- `Done` Dedupe against earlier A-Frame GUI, networked-scene, hand UI, and
  broad WebXR component waves.
- `Done` Freeze a shortlist of compact components with reusable scene or input
  contracts.

## Source Sync

- `Done` Confirm `aframe-cursor-teleport` in local-only cache.
- `Done` Confirm `aframe-super-keyboard` in local-only cache.
- `Done` Confirm `aframe-environment-component` in local-only cache.
- `Done` Confirm `aframe-physics-system` in local-only cache.
- `Done` Confirm `aframe-react` in local-only cache.
- `Done` Confirm `aframe-blink` in local-only cache.
- `Done` Confirm `aframe-daylight-system` in local-only cache.
- `Done` Confirm `aframe-environment-map-component` in local-only cache.

## Code Reading

- `Done` Inspect cursor-camera raycasting, default ground-plane fallback,
  ignore/collision entity filtering, transition easing, and target marker in
  `aframe-cursor-teleport`.
- `Done` Inspect raycaster UV selection, keyboard atlas, filters, max length,
  hand/raycaster integration, and value events in `aframe-super-keyboard`.
- `Done` Inspect environment schema, preset generation, sky/fog/light/ground
  setup, terrain/dressing generation, and seeded scene context in
  `aframe-environment-component`.
- `Done` Inspect local/worker/network/ammo drivers, fixed timestep, CANNON body
  creation, worker snapshots, and entity/body sync in `aframe-physics-system`.
- `Done` Inspect React entity prop diffing, event attach/detach, primitive
  mapping, and attribute removal in `aframe-react`.
- `Done` Inspect parabolic teleport root, rotation controls, hit/miss colors,
  incremental draw, thumbstick support, and `teleported` events in
  `aframe-blink`.
- `Done` Inspect sky/fog/sun-position computation in `aframe-daylight-system`.
- `Done` Inspect CubeCamera environment capture, visibility toggling, PMREM
  generation, and envMap assignment in `aframe-environment-map-component`.

## Integration

- `Done` Create Wave 205 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for A-Frame component primitives and physics
  driver boundaries.
- `Next` Build an A-Frame component matrix across schema, input source,
  event outputs, lifecycle, assets, and maintenance risk.
