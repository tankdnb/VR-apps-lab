# VR Projects Wave 158: VRChat OSC Telemetry, Avatar Scaling, Device/Status, and Parameter-Control Helpers

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 158 studies small VRChat OSC utilities where the avatar is part of the
display or control path: watch parameters, avatar eye-height scaling, world
limit handling, third-party scaling compatibility, and camera path authoring
through avatar-side sensors plus companion executable logic.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Quesys-tech/vrcwatch.rs` | Avatar-as-display telemetry | Minimal focused donor |
| `KutayX7/vrc-avi-scaler` | Avatar scale control helpers | Strong micro-utility donor |
| `VRLabs/Camera-System` | Avatar-authored camera/path systems | Strong product reference, partial code donor |

## `Quesys-tech/vrcwatch.rs`

- Interesting idea:
  drive an avatar wristwatch by sending normalized time and moonphase values as
  OSC parameters once per second.
- Code donor value:
  medium. The implementation is tiny but very clean.
- Product reference value:
  high as an example of avatar-as-display utility value.
- What to inspect next:
  compare with broader status/chatbox/overlay telemetry tools to decide when
  avatar parameters are the right presentation layer.
- Architecture pattern:
  Rust CLI parses destination IP/port, optional demo/debug flags, computes
  second/minute/hour fractions and moon phase, sleeps until the next second
  boundary, validates OSC addresses, encodes float messages with `rosc`, and
  sends `/avatar/parameters/DateTimeSecondFA`, `DateTimeMinuteFA`,
  `DateTimeHourFA`, and `MoonphaseF`.
- Reusable method:
  avatar-as-display telemetry sender with normalized parameter values and
  strict OSC address validation.
- Caveats:
  narrow target avatar contract, no discovery layer, and README warns it is not
  stable.

## `KutayX7/vrc-avi-scaler`

- Interesting idea:
  control VRChat avatar size externally through eye-height OSC while listening
  to VRChat/world state and adapting to existing avatar scaling systems.
- Code donor value:
  high for small OSC control-loop design.
- Product reference value:
  high. It solves one narrow avatar utility problem with useful safety and
  compatibility framing.
- What to inspect next:
  build a scale-control checklist around world limits, base eye height,
  interpolation, quantization, and third-party prefabs.
- Architecture pattern:
  Python CLI starts an OSC receiver and sender, tracks avatar changes,
  `eyeheightmin`, `eyeheightmax`, `eyeheightscalingallowed`, current
  `eyeheight`, `ScaleFactor`, `TrackingType`, and `VRMode`, and exposes
  commands for min/max/base/smooth/fps/frequency/autosave/manual values.
  Smooth scaling computes geometric step factors over a duration, schedules
  timer-based eye-height writes, and applies desktop-mode quantization
  mitigation. Compatibility handlers translate Jackal, Mag, and custom KtySize
  parameters into target eye heights or scale factors.
- Reusable method:
  world-aware avatar scale controller with OSC state intake, smooth
  interpolation, and third-party scaling prefab adapters.
- Caveats:
  Python terminal UX, global state, manual FPS assumptions, and several
  compatibility paths are necessarily fragile because they mirror external
  prefab conventions.

## `VRLabs/Camera-System`

- Interesting idea:
  use an avatar package plus external OSC companion to record camera path
  points in-world and play a moving camera along that path.
- Code donor value:
  medium. Much of the public donor value is Unity assets and package structure;
  the companion executable source is not directly visible in this pass.
- Product reference value:
  high. It is a strong example of avatar-authored tooling that crosses avatar
  constraints, contacts, menus, and a sidecar.
- What to inspect next:
  inspect the companion protocol/path encoding if source becomes available or
  if a camera-path utility becomes active.
- Architecture pattern:
  VPM package provides prefab, FX controller, expression parameters, expression
  menus, materials, visualizers, point menus, settings, and an instancer menu
  item. README describes avatar contacts/constraints/physbones capturing point
  and setting data, an external Windows x86_64 companion receiving that data
  via OSCQuery/OSC, and the companion sending the sampled path back so the
  avatar camera follows it. Settings include point selection, gestures,
  visualization, preview, duration, time-per-point, B-spline, wait time, loop,
  circle mode, and closed loop.
- Reusable method:
  avatar-authored companion protocol where in-world avatar interactions capture
  path/control data and a sidecar returns playback commands.
- Caveats:
  Windows companion only, Quest incompatible, no editor testing due to
  OSCQuery, and companion internals need a deeper dedicated pass before code
  reuse.

## Cross-Project Lessons

- Avatar parameters can be the UI, not only data plumbing.
- Narrow parameter senders benefit from strict names, normalized ranges, and
  simple timing.
- External control of avatar scale should listen to the environment before
  writing values.
- Avatar-authored systems can use contacts/constraints/menus as data capture
  tools, but sidecar protocols must be documented clearly.

## Reusable Methods Extracted

- Avatar-as-display telemetry through normalized OSC floats.
- World-aware avatar scale control with smooth interpolation.
- Third-party avatar-scaling compatibility shim.
- Avatar-authored camera/path companion protocol.

## Follow-Up Backlog

- Create a matrix comparing avatar parameters, chatbox, overlays, and desktop
  panels as presentation surfaces for small telemetry.
- Extract an avatar scaling safety checklist before any scale utility work.
- Keep Camera-System as a high-value product reference and protocol follow-up.
