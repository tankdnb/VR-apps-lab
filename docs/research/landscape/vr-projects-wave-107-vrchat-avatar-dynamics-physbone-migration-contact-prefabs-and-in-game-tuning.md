# VR Projects Wave 107: VRChat Avatar Dynamics, PhysBone Migration, Contact Prefabs, and In-Game Tuning

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `VRChat avatar dynamics`, `PhysBone migration`, `contact/collision prefabs`,
  and `in-game tuning`.

## Why this wave exists

Avatar dynamics are a distinct research branch. They are not just avatar setup,
not just menu UX, and not just physics. The reusable knowledge sits where
creator-side tools, expression menus, constraints, contacts, particles, and
PhysBone behavior meet.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by PhysBone, contact, collision, prop, and tuning families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `FACS01-01/PhysBone-to-DynamicBone` | Editor migration utility with explicit lossless and lossy parameter mapping |
| `naqtn/PhysBonesTK` | In-game PhysBone tuning kit driven through expression menus and animator parameters |
| `TizzureOne/VRChat_PhysboneDetach` | Tiny editor utility that separates PhysBone components into a grouped hierarchy |
| `ThatFatKidsMom/Avatar-Prop` | Grabbable avatar prop reference using PhysBones, constraints, and contact trackers |
| `VRLabs/Collision-Detection` | Contact and particle-based world-collision prefab with small FX bool surface |

## Deep-pass notes by project

## `FACS01-01/PhysBone-to-DynamicBone`

- GitHub:
  [FACS01-01/PhysBone-to-DynamicBone](https://github.com/FACS01-01/PhysBone-to-DynamicBone)
- What it is:
  a Unity editor utility that converts VRChat PhysBones and PhysBone colliders
  back into Dynamic Bone components.
- Interesting idea:
  migration tools should label which fields are lossless, which are lossy, and
  where approximation is unavoidable.
- Code-level notes:
  `PhysBonesToDynBones.cs`
  exposes an editor window, optionally duplicates the selected object, scans
  child `VRCPhysBone` and `VRCPhysBoneCollider` components, converts colliders
  first, converts bones, maps lossless fields such as elasticity, inert, and
  radius, approximates freeze axis, gravity, damping, and stiffness, handles
  gravity falloff through derived gravity/force values, and adds helper
  GameObjects for collider rotations when needed.
- Code donor value:
  high for explicit component migration and approximation logic.
- Product reference value:
  high for honest lossy/lossless framing.
- Caveats:
  it depends on both VRChat PhysBone and Dynamic Bone packages being present,
  and restoration cannot be fully one-to-one.
- What to inspect next:
  compare with forward DynamicBone-to-PhysBone migration tools and avatar
  optimizer passes.

## `naqtn/PhysBonesTK`

- GitHub:
  [naqtn/PhysBonesTK](https://github.com/naqtn/PhysBonesTK)
- What it is:
  an in-game tuning kit for VRChat Avatar Dynamics PhysBones.
- Interesting idea:
  let creators tune PhysBone behavior inside VRChat via expression menus, then
  translate those percentage values back into authoring-time settings.
- Code-level notes:
  the package includes body-bone and accessory-item prefab variants,
  expression menus for movement parameters, interaction parameters, and
  move/scale controls, parameter assets, controller assets, and sample scenes.
  The readme documents mappings from menu percentages to actual PhysBone
  values, special cases such as narrow gravity and max-angle ranges, and a
  `PBTK_Command` state model.
  A key technical trick is reactivating the target GameObject because PhysBone
  properties do not reflect all changes live until the object or component is
  reloaded.
- Code donor value:
  high for menu-driven tuning architecture and parameter mapping.
- Product reference value:
  very high for in-VR creator calibration UX.
- Caveats:
  hierarchy names are essential because animations depend on paths, and some
  features do not sync to late joiners.
- What to inspect next:
  compare menu parameter budgets and reload tricks against other avatar tuning
  prefabs.

## `TizzureOne/VRChat_PhysboneDetach`

- GitHub:
  [TizzureOne/VRChat_PhysboneDetach](https://github.com/TizzureOne/VRChat_PhysboneDetach)
- What it is:
  a tiny Unity editor context-menu utility that moves PhysBone and collider
  components into a new empty object group.
- Interesting idea:
  sometimes the valuable tool is not a converter, but a hierarchy surgery
  helper that makes outfit toggles and component disabling easier.
- Code-level notes:
  `CheckAndMoveVRCPhysBones.cs`
  adds a GameObject context menu, creates a `PB_Group_...` child under the
  selected object, scans all child transforms, copies `VRCPhysBone` and
  `VRCPhysBoneCollider` components into same-named containers, destroys the
  original components, records collider references by object name, and
  reconnects copied bones to copied colliders after the transfer.
- Code donor value:
  medium-high for focused component grouping and remap logic.
- Product reference value:
  high for MA/VRCFury outfit-toggle preparation and resource-saving workflow.
- Caveats:
  the collider remap is name-based, so duplicate names or renamed paths can
  become fragile.
- What to inspect next:
  compare with safer GUID/path-based remapping and undo-aware editor tooling.

## `ThatFatKidsMom/Avatar-Prop`

- GitHub:
  [ThatFatKidsMom/Avatar-Prop](https://github.com/ThatFatKidsMom/Avatar-Prop)
- What it is:
  an avatar prop prefab that remote players can grab, rotate, and drop in the
  world.
- Interesting idea:
  avatar-side interaction can use contact trackers, PhysBones, constraints,
  and IK references to create world-like manipulation without a full world
  system.
- Code-level notes:
  the repo ships Modular Avatar and VRCFury prefab variants, controller assets,
  expression parameters, menus, many animation clips, and contact-tracker
  parameter surfaces such as ring, middle, and hand axis/proximity values.
  The README explains that a PhysBone plus constraints control prop position,
  while contact trackers on the remote player's ring and middle finger inform
  orientation.
- Code donor value:
  medium because much of the logic is prefab and animator asset data.
- Product reference value:
  very high for grabbable avatar prop interaction design.
- Caveats:
  it relies on FinalIK or a stub, Modular Avatar or VRCFury, and hand contact
  assumptions on the remote user.
- What to inspect next:
  compare with VRLabs Contact Tracker lineage and other grabbable prop
  prefabs.

## `VRLabs/Collision-Detection`

- GitHub:
  [VRLabs/Collision-Detection](https://github.com/VRLabs/Collision-Detection)
- What it is:
  a VRChat avatar prefab that detects world collision through contacts and a
  particle-system trick.
- Interesting idea:
  a collision detector can be packaged as a tiny state surface: one contact
  sender, one contact receiver, one particle system, one FX layer, and a few
  bools.
- Code-level notes:
  the README explains that a particle dies on collision, causing contact
  state changes that drive a boolean. The FX controller exposes
  `CollisionDetection/IsColliding`, `CollisionDetection/AlwaysReset`, and
  `CollisionDetection/Reset`.
  `Collision-Detection Instancer.cs`
  conditionally integrates with VRLabs Instancer by reflection and excludes
  source-only files from instantiated packages.
- Code donor value:
  medium-high for prefab packaging, bool surface, and instancer hook.
- Product reference value:
  high for a minimal contact/collision utility.
- Caveats:
  Quest builds require removing unsupported components and shaders, and the
  main behavior lives in prefab/controller assets rather than ordinary code.
- What to inspect next:
  compare against contact tracker and collision-trigger variants.

## Main takeaways from Wave 107

- Avatar dynamics tools split into editor migration, in-game tuning, component
  surgery, grabbable interaction, and contact/collision state surfaces.
- PhysBone utilities are strongest when they make approximation, hierarchy
  naming, parameter budgets, and late-joiner behavior explicit.
- Prefab-heavy repositories can be high-value product references even when
  code visibility is thinner.
- Contact-driven avatar interaction is a reusable VR control pattern because
  it turns physical behavior into small animator parameters and menu surfaces.

## Reusable methods clarified by this wave

- `PhysBone-to-DynamicBone migration converter with explicit lossy and lossless mapping`
- `Expression-menu PhysBone tuner with reload commands and accessory world-constraint controls`
- `Detached PhysBone component grouping for outfit toggles and component budget management`
- `Contact-driven avatar prop using trackers, constraints, PhysBones, and FX parameters`
- `Particle/contact collision prefab with small animator bool surface`

## Recommended next moves after this wave

1. Keep `PhysBonesTK` visible as the strongest in-game avatar dynamics tuning
   reference.
2. Keep `PhysBone-to-DynamicBone` visible as a migration utility with honest
   lossiness documentation.
3. Compare `Avatar-Prop`, `Collision-Detection`, and future contact-tracker
   repos whenever avatar physical interaction becomes a focus.
4. Use `VRChat_PhysboneDetach` as a reminder that tiny hierarchy-surgery tools
   can be valuable creator utilities.
