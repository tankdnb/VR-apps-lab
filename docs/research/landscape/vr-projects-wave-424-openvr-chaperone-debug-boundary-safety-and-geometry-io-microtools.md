# VR Projects Wave 424 - OpenVR Chaperone Debug Boundary Safety And Geometry IO Microtools

- Date: `2026-07-13`
- Theme: OpenVR chaperone geometry, boundary debugging, and safety-warning microtools.

## Shortlist

| Project | Study status | Why it matters |
|---|---|---|
| `zodsoft/openvr_chaperone_io` | Studied | Small C++ parser/writer surface for chaperone universe files and geometry persistence |
| `Dawars/processing_openvr_debug` | Studied | Processing/OpenVR debug visualizer for play area, soft bounds, tracked device poses, and chaperone change events |
| `systemofapwne/VRGuard` | Studied | Python/pyopenvr proximity monitor that warns when controllers approach or leave the play area |

## Cross-Project Synthesis

This wave treats chaperone data as an operator-facing safety and diagnostics
surface rather than as invisible runtime state. The shared lesson is that
boundary tools need three separable layers:

- geometry import/export or runtime read;
- event-aware visualization and refresh;
- user-facing warnings with explicit thresholds and recovery behavior.

The projects are small, but the family is valuable for future `VR-apps-lab`
room-safety helpers, chaperone doctors, calibration previews, and runtime
boundary dashboards.

## Project Notes

### `zodsoft/openvr_chaperone_io`

- Interesting idea:
  expose chaperone universes as parseable and writable data instead of treating
  SteamVR room setup as opaque local state.
- Code donor value:
  `include/chaperone_io.h` provides a compact API around `parseFile()` and
  `writeToFile()` for vectors of `ChaperoneUniverse` records.
- Product reference value:
  useful foundation for backup, preview, diff, migration, and rollback tools
  around chaperone geometry.
- Source evidence:
  `include/chaperone_io.h` declares `parseFile(const std::string&)` and
  `writeToFile(file, universes)`; source tree includes parser/writer and
  vendored JsonCpp files.
- Reusable core:
  parse normalized chaperone records, validate universe data, show a preview,
  write only after backup, and keep geometry edits reversible.
- What not to copy:
  direct room-boundary mutation without backup, preview, version labeling, or
  user confirmation.
- What to inspect next:
  parser error handling, universe field coverage, and whether modern SteamVR
  chaperone JSON has changed.

### `Dawars/processing_openvr_debug`

- Interesting idea:
  visualize OpenVR play area, soft bounds, and tracked devices in a simple
  debug sketch that reacts to chaperone change events.
- Code donor value:
  `Status.java` initializes OpenVR, gets `IVRChaperone` and `IVRCompositor`,
  reads play-area size/rect, draws device poses, and refreshes on chaperone
  events.
- Product reference value:
  strong reference for a lightweight "room doctor" view that lets users see
  what the runtime thinks their tracked space looks like.
- Source evidence:
  `Status.java` calls `GetPlayAreaSize`, `GetPlayAreaRect`, and
  `GetDeviceToAbsoluteTrackingPose`; it handles
  `VREvent_ChaperoneDataHasChanged`,
  `VREvent_ChaperoneUniverseHasChanged`,
  `VREvent_ChaperoneTempDataHasChanged`, and
  `VREvent_ChaperoneSettingsHaveChanged`.
- Reusable core:
  runtime adapter, chaperone cache, event refresh, top-down map renderer,
  tracked-device markers, and property panels.
- What not to copy:
  debug UI assumptions as a finished product, or polling-only refresh that
  ignores runtime events.
- What to inspect next:
  device property coverage, coordinate conventions, and how to label stale or
  missing chaperone data.

### `systemofapwne/VRGuard`

- Interesting idea:
  turn chaperone bounds into an audible safety monitor for controller proximity
  and out-of-bounds events.
- Code donor value:
  `vrguard.py` uses `VRApplication_Utility`, `VRChaperone().getPlayAreaRect()`,
  controller pose polling, height filtering, distance-to-bounds checks, and
  `pygame.mixer` warning loops.
- Product reference value:
  useful microtool reference for safety cue routing and simple runtime-only
  diagnostics.
- Source evidence:
  `vrguard.py` updates bounds every 10 seconds, filters controllers from
  `k_unMaxTrackedDeviceCount`, reads controller poses in
  `TrackingUniverseStanding`, uses `m_minHeight=0.6` and `m_minDist=0.4`, plays
  `g_Over` when out of bounds, and ramps `g_Near` volume near the boundary.
- Reusable core:
  play-area adapter, device pose poller, height/role filters, distance
  threshold, cooldown/volume policy, and warning output router.
- What not to copy:
  rectangle-only safety assumptions, fixed thresholds, audio-only warnings, or
  warning loops without calibration and mute controls.
- What to inspect next:
  seated/standing modes, controller role filtering, non-rectangular bounds,
  and haptic/visual warning alternatives.

## Reusable Pattern Extraction

- Pattern candidate:
  `Chaperone boundary safety monitor`.
- Problem solved:
  users and developers need to inspect, preserve, and react to tracked-space
  boundaries without opening full runtime setup tools.
- Reusable core:
  chaperone geometry reader, backup/writer path, event-aware debug map,
  controller pose monitor, threshold policy, warning router, and stale-state
  labels.
- Source evidence:
  `zodsoft/openvr_chaperone_io`, `Dawars/processing_openvr_debug`, and
  `systemofapwne/VRGuard`.
- Abstraction boundary:
  keep geometry IO, live runtime polling, warning policy, and UI presentation
  as separate modules.
- What not to copy:
  blind config writes, hard-coded thresholds, rectangle-only assumptions, or
  warning outputs without user control.
- Method catalog action:
  add new method for chaperone boundary safety/debug microtools.

## Follow-Up Gaps

- Compare OpenVR chaperone geometry with OpenXR bounds/guardian equivalents.
- Design a reversible chaperone backup/preview/diff flow.
- Define safety cue channels: audio, haptic, overlay, desktop, and logs.

