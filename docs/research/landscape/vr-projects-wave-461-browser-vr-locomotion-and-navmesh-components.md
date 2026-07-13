# Wave 461: Browser VR locomotion and nav-mesh components

- Date: `2026-07-13`
- Scope: A-Frame/WebXR locomotion systems, smooth locomotion, snap/smooth
  turning, nav-mesh constraints, gravity/fall behavior, teleport markers, and
  comfort/fade helpers.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `mrxz/aframe-locomotion` | Studied | Typed locomotion/nav-mesh package |
| `msub2/aframe-vr-character-controller` | Studied | Compact A-Frame character controller |
| `disasteroftheuniverse/SuperQuest` | Cross-wave reference | Teleporter controls and Quest A-Frame helpers |

## Why this wave matters

Earlier waves captured teleport fallback and comfort effects separately. This
wave focuses on the reusable browser-XR locomotion boundary: input adapters,
target rig movement, reference orientation, nav-mesh approval, gravity, turning,
teleport markers, comfort fades, and post-motion hooks.

## Project notes

### `mrxz/aframe-locomotion`

- Interesting idea:
  TypeScript A-Frame locomotion package with separate systems/components for
  smooth movement, smooth/snap turning, gravity, nav meshes, nav-mesh
  strategies, constrained movement, vignettes, fades, and head occlusion.
- Code donor value:
  strong donor for separating locomotion into systems: `locomotion` handles
  post-motion callbacks, `nav-mesh` approves candidate movement, and movement
  components translate axis input into target rig motion.
- Product reference value:
  shows that browser VR locomotion should expose policy knobs such as reference
  entity, speed, input mode, fall mode, forward/back/sideways permissions, and
  comfort visual helpers.
- Source evidence:
  `src/movement/locomotion.system.ts`,
  `src/movement/smooth-locomotion.component.ts`,
  `src/movement/snap-turn.component.ts`,
  `src/movement/smooth-turn.component.ts`,
  `src/nav-mesh/nav-mesh.system.ts`, `src/nav-mesh/strategy/*`, and
  `src/auxiliary/*`.
- Reusable core:
  locomotion system, post-motion callbacks, axis reader, target/reference split,
  speed/input mode, velocity contributors, nav-mesh candidate validator,
  snap/prevent/fall modes, snap/smooth turn components, vignette/fade helpers,
  and docs/reference pages.
- What not to copy:
  package assumptions without current A-Frame/WebXR compatibility testing or
  default comfort settings as universal.
- What to inspect next:
  nav-mesh scan strategy, fall-mode edge cases, comfort fade primitives, and
  how movement events are emitted.

### `msub2/aframe-vr-character-controller`

- Interesting idea:
  compact A-Frame controller primitive combining smooth locomotion, snap/smooth
  turning, hand controls, grab, and common controller components.
- Code donor value:
  useful as a minimal implementation reference: axis events are mapped to
  movement/turn vectors, head orientation controls movement direction, and snap
  turn preserves head world position.
- Product reference value:
  good teaching/reference sample for the minimum viable locomotion rig.
- Source evidence:
  `components/controller.js`, `index.html`, `README.md`, and `package.json`.
- Reusable core:
  speed/fly schema, active movement flag, left-axis locomotion, right-axis turn,
  snap degrees, unsnap zone, smooth turn speed, head-relative movement, and
  primitive mappings.
- What not to copy:
  global selectors, hard-coded controller ids, equality checks for axis max, or
  locomotion without nav/comfort gates.
- What to inspect next:
  how grab interacts with locomotion and how to modernize ids/events.

### `disasteroftheuniverse/SuperQuest`

- Interesting idea:
  Quest-focused A-Frame helper collection including teleporter controls,
  haptics, hands, lite physics, portals, rounded/shader helpers, and asset
  shortcuts.
- Code donor value:
  the teleporter system is useful as a comparison node: it registers up to two
  hands, owns a shared destination marker, toggles the other hand's UI, and
  exposes start/cancel/move/toggle event lists.
- Product reference value:
  shows how locomotion helpers often grow into a broader Quest convenience kit.
- Source evidence:
  `src/quest/superquest-teleporter-controls.js`,
  `src/quest/superquest-haptics.js`, `src/quest/superquest-hands.js`,
  `src/physics-lite/*`, and `src/extras-collection/*`.
- Reusable core:
  hand subscription, shared teleport marker, valid/invalid colors, event lists,
  player/camera selectors, tube/line styles, and two-hand UI conflict handling.
- What not to copy:
  old `CylinderBufferGeometry` naming, broad helper bundle assumptions, or
  Quest-specific convenience wrappers without feature gates.
- What to inspect next:
  teleport destination solving and haptic/hand helper boundaries.

## Reusable pattern extraction

- Pattern candidate:
  `browser XR locomotion policy layer`.
- Problem solved:
  let VR web utilities choose movement policy explicitly instead of hard-coding
  axis input, turning, gravity, collision, comfort, and teleport behavior.
- Reusable core:
  rig target, reference orientation, motion input adapter, rotation input
  adapter, nav-mesh strategy, fall policy, velocity contributors, teleport
  marker, comfort fade/vignette, post-motion hooks, and motion events.
- Abstraction boundary:
  input components own raw controller axes; locomotion system owns motion phase;
  nav-mesh owns movement approval; comfort layer owns visual mitigation.
- Method catalog action:
  create a new method for browser XR locomotion policy layers.

## Caveats

- Locomotion is comfort-sensitive; defaults should be treated as examples.
- Old A-Frame/WebVR event assumptions need modernization before reuse.
- Nav-mesh and teleport constraints should be explicit product settings.

