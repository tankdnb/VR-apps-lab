# GitHub Research Wave 171 Backlog

- Date: `2026-06-05`
- Theme: `XR behavior recording, physiological replay, olfactory display, and sparse-camera mocap`
- Status: `Completed`

## Completed Pass

1. Search XR instrumentation, record/replay, physiological timeline, hardware
   output, and sparse-camera mocap repositories.
2. Deduplicate against experiment frameworks, haptics/physical-output bridges,
   motion-capture protocols, and camera utility coverage.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect PLUME docs workflow, XREcho recording/replay managers, tracked object
   and event CSV flows, analysis UI scripts, Nebula serial/Android bridge and
   diffuser behavior, experiment CSV logging, Kineo pipeline stage abstractions,
   online camera flow, triangulation, bundle adjustment, and BVH/USD exports.
5. Separate documentation/product references from source donors and mark
   research-license caveats.
6. Integrate results into registry, families, methods, not-yet queue, current
   focus, and indexes.

## Studied Repositories

| Project | Outcome |
|---|---|
| `liris-xr/PLUME` | Added as docs-first XR recorder/viewer/timeline/physiological-signal product reference |
| `liris-xr/XREcho` | Added as Unity XR recording, replay, event, trajectory, gaze, and heatmap source donor |
| `liris-xr/Nebula-Core` | Added as multisensory olfactory display bridge and experiment logging donor |
| `liris-xr/kineo` | Added as sparse-camera mocap pipeline and BVH/USD export helper reference |

## Useful Follow-Up Work

- Build an XR instrumentation matrix across PLUME, XREcho, Unity experiment
  frameworks, and prior data-capture waves.
- Extract a timeline/event-marker UX pattern for future diagnostics and
  replayable VR utilities.
- Compare physical-output bridges across haptics, scent/olfactory devices,
  serial devices, and OSC/network bridges.
- Evaluate which Kineo-style exports matter most for VR-apps-lab: BVH, USD,
  Rerun, Unity import, or Unreal import.

## Not Pursued In This Wave

- No PLUME recorder/viewer, XREcho Unity project, Nebula device, serial port,
  Android plugin, Kineo pipeline, camera feed, mocap model, or demo was
  launched.
- No found repository was run, built, installed, imported, or tested.
