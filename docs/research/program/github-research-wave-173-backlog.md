# GitHub Research Wave 173 Backlog

- Date: `2026-06-05`
- Theme: `OpenXR API-layer adaptation, hand transform offsets, and graphics compatibility`
- Status: `Completed`

## Completed Pass

1. Search OpenXR API-layer adaptation, hand tracking, eye/face tracking, and
   graphics compatibility families.
2. Deduplicate against earlier OpenXR layer, foveation, passthrough, and
   template coverage.
3. Freeze a shortlist of four API-layer projects with distinct reuse lessons.
4. Sync shortlisted sources into local-only cache for static reading.
5. Inspect loader negotiation, extension filtering, OSC socket read threads,
   expression mapping, hand-joint transform offsets, Rust wrapper/session/
   swapchain interceptors, generated C dispatch, and manifest scaffolding.
6. Promote `openxr_oscclient` from follow-up queue into studied status.
7. Integrate results into registry, families, methods, current focus,
   not-yet, and indexes.

## Studied Repositories

| Project | Outcome |
|---|---|
| `LordOfDragons/openxr_oscclient` | Added as OSC eye/face tracking to OpenXR extension adapter donor |
| `CraigMason/OpenXR-Hand-Transform-Offset-Layer` | Added as runtime-side hand-joint transform correction micro-layer |
| `Sorenon/sorenon_openxr_layer` | Added as Rust OpenXR graphics compatibility layer and wrapper-registry donor |
| `maluoi/openxr-layer-template` | Added as compact C11/CMake generated-dispatch API-layer template |

## Useful Follow-Up Work

- Build an OpenXR micro-layer starter matrix across C++, C, Rust, generated
  dispatch, and template-derived layers.
- Compare runtime-side correction targets: eye/face expressions, hand joints,
  view/projection chains, graphics bindings, and input remapping.
- Extract an install/disable/safety checklist for experimental API layers.
- Map which adaptation layers should be prototypes versus documentation-only
  references because of runtime risk.

## Not Pursued In This Wave

- No OpenXR runtime, API layer, OSC sender, hand tracker, graphics session, or
  layer template was launched.
- No found repository was run, built, installed, imported, or tested.
