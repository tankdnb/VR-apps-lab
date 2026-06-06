# VR Projects Wave 252: Hands-Free OpenXR Hand Tracking Input And Wrist UI Microtools

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies small projects that turn head pose, hand tracking, finger
curl, pinch, or wrist-mounted UI into practical input surfaces. The emphasis is
not on production readiness; it is on reusable input boundaries for VR utility
tools.

## Why It Matters For `VR-apps-lab`

Many utility ideas fail at the input layer because they assume controllers,
keyboards, or desktop focus are always available. These projects show narrower
patterns: head-to-cursor mapping, chording without a keyboard, raw OpenXR hand
joint access, wrist menus, and vendor hand-tracking samples.

## Project Notes

### `SimForgeEngineering/DCS-HandsFree`

- Interesting idea:
  a tiny StereoKit/OpenXR utility maps headset orientation to the foreground
  desktop window cursor, intended for hands-free DCS VR interaction.
- Code donor value:
  `handsfree/handsfree.cs` initializes StereoKit, reads `Input.Head`
  quaternion each frame, converts it to pitch/yaw, clamps normalized commands,
  reads the active Windows foreground window rectangle, and writes
  `Cursor.Position`.
- Product reference value:
  useful proof that a bounded accessibility/cockpit helper can be a few clear
  boundaries rather than a full overlay stack.
- What to inspect next:
  add smoothing, recenter/calibration, dwell/click safety, per-app bounds, and
  explicit enable/disable controls before treating it as donor-ready.
- Reusable pattern:
  head pose -> normalized viewport command -> desktop cursor output.
- Caveats:
  hardcoded angle ranges, no click model, Windows foreground-window coupling,
  and no visible safety gate.

### `JonahSagers/VRChord`

- Interesting idea:
  an inverted ASETNIOP-style chording keyboard lets users type in VR from hand
  curls rather than a physical keyboard.
- Code donor value:
  `Assets/Scripts/KeyboardHandler.cs` maps ordered finger-curl combinations to
  characters, maintains primary and alternate chord dictionaries, uses both
  fists close together as an enable/disable latch, supports thumb-driven space
  and backspace behavior, and mirrors typed output into selected text targets.
  `CurlDetection.cs` reads Unity XR Hands finger shapes and stores full-curl
  values for each hand. `KeyIndicator.cs` and `Caret.cs` provide visual
  feedback.
- Product reference value:
  strong reference for hands-only text entry UX and feedback loops.
- What to inspect next:
  compare chord fatigue, localization, error correction, and text-target focus
  against other VR keyboard approaches.
- Reusable pattern:
  hand-shape subsystem -> finger curl vector -> chord dictionary -> text buffer
  and visual feedback.
- Caveats:
  Unity project includes large template/sample assets, chord maps are hardcoded,
  and production use would need training/error UI.

### `Haidere1/VarjoXR-CustomHandTracking-Test`

- Interesting idea:
  an Unreal/Varjo OpenXR sample combines hand keypoint reading, pinch rays,
  world-space HUD widgets, and Cesium-scale scene manipulation.
- Code donor value:
  `Source/VarjoXRGAME/HandTracking.cpp` maps `EHandKeypoint` values to hand
  bones, creates motion controllers, poseable hand meshes, tip spheres, and a
  widget component, then reads left/right hand keypoints each tick. It detects
  pinch state, updates pinch rays, drives hand mesh pose, and uses hand motion
  for orbit/scale movement. `DefaultInput.ini` registers Oculus/Valve/Varjo and
  hand pinch axes plus enhanced input contexts.
- Product reference value:
  useful vendor-specific sample for pinch-to-manipulate and hand pose mesh
  binding.
- What to inspect next:
  separate the hand tracking layer from Cesium scene navigation and verify how
  much of the sample depends on Varjo-specific assets/plugins.
- Reusable pattern:
  OpenXR hand keypoints -> pinch detection -> ray/mesh/HUD update -> scene
  manipulation.
- Caveats:
  asset-heavy Unreal project, mixed experimental code, Varjo/Quest config
  assumptions, and source evidence is stronger for hand boundary than for
  production architecture.

### `zodiepupper/godothandtrackingtests`

- Interesting idea:
  a Godot 4 testbed exposes raw OpenXR hand joints as procedural tracker nodes,
  collision layers, and wrist-mounted 3D UI.
- Code donor value:
  `main.gd` initializes the OpenXR interface, aligns physics tick rate with
  headset refresh, and enables passthrough when supported. `better_openxr_hand.gd`
  creates 26 joint trackers, queries hand joint flags/positions/rotations,
  calculates closedness signals, attaches a wrist menu to the wrist joint, and
  toggles collision layers for fingertip UI. `tracker.gd` smooths target
  positions, while `addons/Panel3D` registers a reusable 3D panel custom type.
- Product reference value:
  useful for Godot hand input, raw joint inspection, and wrist UI experiments.
- What to inspect next:
  extract the raw hand-joint debugger from bundled addons and binary vendor
  packages.
- Reusable pattern:
  OpenXR joint polling -> procedural joint nodes -> fingertip collision layers
  -> wrist menu / panel interaction.
- Caveats:
  experimental repo with bundled binaries, temporary files, passthrough
  assumptions, and debug-oriented UI.

## Reusable Pattern Extraction

- Pattern candidate:
  hands-free VR input boundary for utility microtools.
- Problem solved:
  a utility needs input without assuming tracked controllers, desktop keyboard,
  or direct app focus.
- Reusable core:
  capture source, calibration, normalized command state, debounce/latch,
  output adapter, visible feedback, and safety disable path.
- Source evidence:
  `DCS-HandsFree`, `VRChord`, `VarjoXR-CustomHandTracking-Test`, and
  `godothandtrackingtests`.
- Abstraction boundary:
  keep sensor capture and gesture interpretation separate from the output
  target: cursor, text buffer, world-space UI, or scene manipulation.
- What not to copy:
  hardcoded angle ranges, bundled template assets as method evidence,
  vendor-specific sample wiring, or controllerless input without an escape
  hatch.
- Method catalog action:
  add a new method for hands-free and hand-derived utility input.

## Family Placement

This wave extends the hand input, VR keyboard, accessibility, and XR
microhelper families. It should not replace earlier VR keyboard or WebXR hand
waves; it adds source-level examples of small input translators.

## Follow-Up Gaps

- Compare head-to-cursor, hand-chord, wrist-menu, pinch-ray, and controller
  input against one shared safety checklist.
- Extract calibration and recenter UX patterns for controllerless utilities.
- Decide whether `VR-apps-lab` should keep a standalone "hands-free input"
  backlog branch.
