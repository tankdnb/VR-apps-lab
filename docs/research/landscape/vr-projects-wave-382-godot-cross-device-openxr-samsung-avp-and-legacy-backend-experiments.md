# Wave 382: Godot Cross-Device OpenXR, Samsung XR, AVP, and Legacy Backend Experiments

## Theme

Godot platform experiments around Samsung XR, Apple Vision Pro-style engine
patches, and the legacy Godot 3 OpenXR backend as a migration comparison node.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `Jax-Danger/Godot-Samsung-XR` | Studied | Small Godot OpenXR/Samsung XR project with player/level/action-map structure |
| `ibrews/godot-avp-cascade` | Studied | Apple Vision Pro-oriented Godot engine patch/test-project/tooling experiment |
| `GodotVR/godot_openxr_for_godot_3.x` | Deepened | Legacy Godot 3 OpenXR backend lineage with native session/action/sample code |

## Dedupe Notes

`GodotVR/godot_openxr_for_godot_3.x` was already partially covered. This wave
uses it as a comparison/deepening node for platform backends, not as a new
registry duplicate. The Samsung and AVP projects add cross-device experiment
coverage.

## Code-Level Findings

### `Jax-Danger/Godot-Samsung-XR`

- Interesting idea: keep a platform experiment small: level folder, player
  folder, scripts, OpenXR action map, export preset, and a packaged artifact.
- Code donor value: `Level`, `Player`, `scripts`, `openxr_action_map.tres`,
  `export_presets.cfg`, and `project.godot` show a compact device-targeted
  experiment shape.
- Product reference value: useful for future device probes where the goal is
  to isolate platform behavior without dragging in a full toolkit stack.
- What to inspect next: Samsung-specific setup, controller mapping, export
  preset choices, and artifact provenance.
- Caveat: checked-in packaged artifacts should not become a pattern for this
  repository; document provenance and keep source-first.

### `ibrews/godot-avp-cascade`

- Interesting idea: treat Apple Vision Pro support as a cascade of engine
  patches, tools, docs, captures, and a test project.
- Code donor value: `engine-patches`, `test-project`, `tools`, `docs`,
  `captures`, and output folders show a reproducible experiment envelope around
  a platform port.
- Product reference value: strong reference for documenting invasive platform
  experiments where patch provenance and test scenes matter as much as code.
- What to inspect next: patch order, build assumptions, headset/simulator
  boundary, and what the test project validates.
- Caveat: engine patches are high-risk donor material; copy the documentation
  and experiment envelope, not patch hunks blindly.

### `GodotVR/godot_openxr_for_godot_3.x`

- Interesting idea: older OpenXR backend projects expose the native seams:
  action sets, bindings, spaces, sessions, and mobile sample integration.
- Code donor value: `src`, `android`, `android_samples`, `demo`, `scripts`,
  and Oculus sample code show how action/session/space plumbing was separated.
- Product reference value: useful migration/reference node when reasoning
  about Godot 3 versus Godot 4 OpenXR assumptions.
- What to inspect next: action-map translation, Android lifecycle, session
  state handling, and migration caveats to modern Godot OpenXR.
- Caveat: legacy backend code should not be treated as current best practice.

## Reusable Pattern Extraction

- Pattern candidate: Godot cross-device OpenXR platform experiment wrapper.
- Problem solved: platform-specific XR experiments need source, patches,
  action maps, test scenes, provenance, and caveat labels in one envelope.
- Reusable core: device probe scene, player rig, action map, export preset,
  engine patch folder, test project, tool script, capture evidence, backend
  comparison note, artifact provenance, and migration warning.
- Source evidence: Samsung XR `Level/Player/scripts/openxr_action_map.tres`,
  AVP `engine-patches/test-project/tools/docs/captures`, and Godot 3 OpenXR
  `src/android/android_samples/demo/scripts` layout.
- Abstraction boundary: platform probe code should not become a general utility
  layer until runtime capability checks and migration notes are explicit.
- What not to copy: packaged APKs as source evidence, engine patches without
  provenance, or legacy backend assumptions as modern Godot guidance.
- Method catalog action: add Method 827.

## Family Placement

Creates a Godot cross-device OpenXR experiment family. It connects platform
probe projects to the broader vendor-capability and headsetless/runtime
families.

## Follow-Up Gaps

- Draft a platform-experiment provenance checklist for Godot XR projects.
- Compare Samsung XR and AVP action/input assumptions with modern Godot XR
  plugin docs.
- Keep `godot_openxr_for_godot_3.x` marked as legacy/deepening only.
