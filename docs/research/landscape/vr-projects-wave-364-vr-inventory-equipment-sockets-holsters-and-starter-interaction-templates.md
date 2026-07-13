# Wave 364: VR Inventory Equipment Sockets Holsters and Starter Interaction Templates

## Scope

This wave studies compact Unity VR inventory and starter interaction projects.
The reusable value is a body-relative equipment layer: sockets that follow the
HMD, inventory slot data, item quantity UI, controller data, hand visibility,
and baseline teleport/character support.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `Isabela-Tellez/InventarioArmasVR` | Studied | XRI inventory/weapon project with `Inventory`, `SlotInventory`, item UI buttons, collectables, controller manager, and XR template sample overlap |
| `Fist-Full-of-Shrimp/FFOS-VR-Tutorial-Resources` | Studied | Tutorial resource pack with `BodySocketInventory`, controller input display, flashlight, FPS display, and small weapon/fire examples |
| `Fist-Full-of-Shrimp/FFOS-Unity-VR-Template` | Partially studied | Starter VR template with HMD-driven character-controller height, hand visibility on select, and teleportation ray toggling |

## Reusable Pattern Extraction

- Pattern candidate: `body-anchored equipment socket and inventory slot shell`.
- Problem solved: VR utility tools often need quick access to tools or panels
  without opening a flat menu or losing body-relative spatial consistency.
- Reusable core: HMD pose reader, body root follow transform, socket list,
  per-socket height ratios, item ScriptableObject, slot quantity, UI icon/count
  renderer, collectable intake, hand visibility policy, controller data monitor,
  and teleport/character baseline.
- Source evidence: FFOS `BodySocketInventory` updates socket height from HMD
  local height and rotates the inventory root with the HMD yaw; InventarioArmasVR
  uses `Inventory` ScriptableObjects, `SlotInventory`, `Item`, and
  `ButtonInventory`; FFOS template includes hand visibility and teleport support.
- Abstraction boundary: body sockets should own spatial placement; inventory
  data should own item state; UI should only render icon/count/status.
- What not to copy: sample art, duplicated XRI starter assets, old package
  assumptions, or weapons as the only equipment metaphor.
- Method catalog action: create a new body-socket inventory method.

## Project Notes

### `Isabela-Tellez/InventarioArmasVR`

- Interesting idea: a small XRI project packages inventory as data assets and
  UI slot renderers around collectable/weapon interactions.
- Code donor value: high for `Inventory`, `SlotInventory`, `Item`,
  `ButtonInventory`, collectable flow, and XRI starter integration boundaries.
- Product reference value: useful for equipment panels, tool belts, and
  reusable item trays.
- What to inspect next: persistence, duplicate item merge, socket-to-slot
  mapping, and weapon activation safety.
- Caveats: includes large copied XRI samples; reuse the thin custom layer.

### `Fist-Full-of-Shrimp/FFOS-VR-Tutorial-Resources`

- Interesting idea: `BodySocketInventory` keeps sockets body-relative by
  following HMD X/Z and yaw while assigning socket heights from HMD height
  ratios.
- Code donor value: high for a minimal body socket utility, controller data
  display, flashlight toggle, FPS display, and fire event examples.
- Product reference value: strong for micro-utilities and tutorial-friendly
  body equipment.
- What to inspect next: seated mode, handedness, collision affordances, and
  socket persistence.
- Caveats: tutorial snippets; add formal state and comfort rules before reuse.

### `Fist-Full-of-Shrimp/FFOS-Unity-VR-Template`

- Interesting idea: a starter template exposes practical baseline concerns:
  HMD-driven character height, hand model visibility on selection, and
  teleportation ray enable/disable.
- Code donor value: moderate as a bootstrap reference.
- Product reference value: useful for explaining minimum VR interaction
  scaffolding around equipment systems.
- What to inspect next: package versions, hand/controller abstraction, and
  whether the template still maps cleanly to modern XRI.
- Caveats: starter template, not a complete inventory product.

## Product Direction

This wave supports an `equipment socket utility layer` branch: future VR tools
can expose body-relative slots for diagnostic panels, capture tools, settings,
or interaction helpers without turning every action into a floating menu.

