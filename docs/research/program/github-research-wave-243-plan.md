# GitHub Research Wave 243 Plan

Date: 2026-06-06

Theme: Spatial measuring, modeling, collaboration, and MR workbench surfaces.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

After many overlay/runtime waves, the repository benefits from a workbench
cluster: tools that measure the world, create editable spatial objects,
project them back into AR/MR, manipulate meshes with hands, coordinate shared
objects, and log planning decisions.

## Search Families

- WebXR/WebAR measurement and modeling.
- MR mesh deformation and hand-driven editing.
- Scenario planning panels and solution placement.
- Collaborative Unity Netcode object manipulation.
- Social gallery/workbench product references.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `rtkCode/Sizer` | Browser AR measure -> model -> project loop with WebXR hit-test, A-Frame editing, AR.js marker projection, and local history. | Strong browser workbench donor |
| `byte-banditt/Meshelanjelo` | Meta Quest MR mesh sculpting with OVRHand pinch input and job-based push/pull deformer. | Strong MR mesh donor |
| `B22DigitalTwins2022/ar-resilience-planner-v2` | MR planning app with additive scenes, persistent menu/panels, solution grouping, simulation update, and logs. | Planning workbench donor |
| `adityanooka/Unity-Dive-VR` | Collaborative VR with Unity Netcode, multi-hand lift gate, ownership/server boundaries, and underwater shared-object tasks. | Collaboration reference |
| `Hempp/street-art-gallery` | Source-light social VR gallery reference for hotspots, guided tours, avatars, emotes, voice, nametags, and comfort. | Product/reference only |

## Dedupe Notes

Prior waves cover CAD, WebXR drawing, browser creative surfaces, shared rooms,
and training workbenches. This wave connects those ideas through a compact
state loop: measure/model/manipulate/project/collaborate/log.

## Code-Level Pass Targets

- WebXR hit-test point capture and measurement state.
- A-Frame object modeling, transform persistence, and AR marker projection.
- Hand pinch to deformer parameter bridge.
- Burst/job mesh deformation boundaries.
- MR planning panels, solution grouping, simulation updates, and logs.
- Network authority and collaborative object manipulation.

## Expected Outputs

- Wave 243 landscape synthesis.
- Registry/family entries for spatial workbench surfaces.
- Method catalog entry for spatial workbench state loops.
- Follow-up backlog for undo/history and collaborative ownership matrices.
