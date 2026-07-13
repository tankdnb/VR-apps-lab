# Wave 365: VR AR Wayfinding Waypoint Arrows QR Recentering and Route Cues

## Scope

This wave studies lightweight navigation helpers: an arrow that always faces a
target, an AR indoor navigation shell with target data, NavMesh paths, dropdown
selection, QR recentering, floor switching, and path visibility.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `bhartinderjoshi/Waypoint_Arrow` | Studied | One-script waypoint arrow using `Quaternion.LookRotation` toward a target transform |
| `nlalert/AR-Indoor-Navigation` | Studied | AR navigation shell with JSON target catalog, generated target facades, dropdown selection, NavMesh path lines, QR recentering, and floor-aware anchors |

## Reusable Pattern Extraction

- Pattern candidate: `target catalog route cue and recentering boundary`.
- Problem solved: route guidance needs targets, cues, path visualization, and
  origin repair to be separate from the visual scene content.
- Reusable core: target data model, generated target facade, target selector,
  current destination, route/path calculator, line/arrow cue renderer, vertical
  offset control, QR/marker recenter adapter, scan state, floor/context switch,
  and visibility toggle.
- Source evidence: Waypoint_Arrow rotates a cue toward a target transform;
  AR-Indoor-Navigation uses `Target`, `TargetWrapper`, `TargetHandler`,
  `NavigationController`, and `QRCodeRecenter` to link JSON targets, NavMesh
  routes, and AR origin reset.
- Abstraction boundary: target metadata should not depend on cue visuals;
  recentering should repair the origin without owning route rendering.
- What not to copy: per-frame heavy route calculation without throttling,
  always-on camera scanning, hardcoded floor arrays, or routes without stale
  destination states.
- Method catalog action: create a navigation cue/recenter method.

## Project Notes

### `bhartinderjoshi/Waypoint_Arrow`

- Interesting idea: a waypoint arrow can be expressed as a minimal cue that
  turns toward a target transform every frame.
- Code donor value: low but clear for a minimal direction indicator.
- Product reference value: useful as the thinnest possible route cue.
- What to inspect next: distance labels, offscreen/behind-user states,
  smoothing, and accessibility alternatives.
- Caveats: single script; not enough for full navigation without target and
  route state.

### `nlalert/AR-Indoor-Navigation`

- Interesting idea: target data is loaded from JSON into generated facades,
  selected via dropdown, rendered as a NavMesh line, and repaired through QR
  recentering.
- Code donor value: high for target catalog, route renderer, QR scan/recenter,
  floor switching, and route visibility controls.
- Product reference value: strong for indoor guidance and calibration helpers.
- What to inspect next: route throttling, multi-floor transitions, permission
  UX, QR scan failure, and destination freshness.
- Caveats: AR-oriented; adapt camera/QR permissions carefully for headset use.

## Product Direction

This wave supports a `navigation helper surface` branch: future VR utilities can
share target catalogs, route cues, recenter markers, and floor/context switching
instead of hardcoding arrows or path lines per scene.

