# Wave 380: Godot Quest Interaction Toolkits, Saber Game, and Hand Rigging Pipeline

## Theme

Godot-based Quest/OpenXR interaction building blocks: an Oculus Quest toolkit,
a complete saber-style interaction game, and a Blender-to-Godot hand rigging
pipeline.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `NeoSpark314/godot_oculus_quest_toolkit` | Studied | Godot Quest toolkit with reusable scenes, utilities, demos, and action-map conventions |
| `arpruss/OpenSaberPlus` | Studied | Full Godot VR rhythm/saber project using toolkit-style interaction assets and game flow |
| `ClonedPuppy/Blender_OpenXR_Hand_Rigging` | Studied | Small hand asset/rigging pipeline project with Blender assets and Godot OpenXR scenes |

## Dedupe Notes

`GodotVR/godot-xr-tools` and related Godot XR toolkit projects were already in
the registry. This wave studies a Quest-focused toolkit lineage, a concrete
game composition, and a hand asset pipeline as complementary donor/reference
nodes rather than as replacements for `godot-xr-tools`.

## Code-Level Findings

### `NeoSpark314/godot_oculus_quest_toolkit`

- Interesting idea: package Quest-oriented VR utilities as Godot scenes,
  demos, and helper utilities instead of only as engine plug-in code.
- Code donor value: `OQ_Toolkit`, `addons`, `demo_games`, `demo_scenes`,
  `utilities`, and `GameMain.gd` show a reusable toolkit/demo split with a
  project-level entry shell.
- Product reference value: useful as a reference for organizing `VR-apps-lab`
  Godot samples around reusable interaction modules plus small demonstrators.
- What to inspect next: scene contracts, grab/teleport/action-map assumptions,
  and how toolkit assets differ from later `godot-xr-tools` conventions.
- Caveat: older Quest-specific assumptions should be treated as lineage and
  product framing, not as current platform guidance.

### `arpruss/OpenSaberPlus`

- Interesting idea: a complete saber game can act as an integration testbed
  for action maps, controller pose, hit timing, scoring, audio, and toolkit
  composition.
- Code donor value: `game`, `OQ_Toolkit`, `addons`, `openxr_action_map.tres`,
  and Android/export folders show how toolkit code becomes a packaged VR
  experience.
- Product reference value: good reference for rhythm/skill loops where VR
  utilities need explicit timing windows, hit feedback, and controller motion
  interpretation.
- What to inspect next: beatmap/song ingestion, saber collision timing,
  scoring windows, and comfort/reset behavior.
- Caveat: game-specific scoring should not be copied into generic utility
  modules; extract the input/timing patterns only.

### `ClonedPuppy/Blender_OpenXR_Hand_Rigging`

- Interesting idea: keep hand rigging and OpenXR hand visualization as a small
  asset-pipeline project rather than hiding it inside a full app.
- Code donor value: `blender`, `assets`, `scenes`, `scripts`, and
  `openxr_action_map.tres` show a narrow bridge from authored hand assets into
  a Godot XR test scene.
- Product reference value: useful for future hand-menu or controllerless UI
  experiments that need repeatable hand mesh/skeleton setup.
- What to inspect next: bone naming, import settings, retargeting assumptions,
  and whether controller fallback is documented.
- Caveat: asset pipeline value depends on matching runtime hand skeletons and
  current Godot import behavior.

## Reusable Pattern Extraction

- Pattern candidate: Godot Quest interaction toolkit plus hand asset pipeline.
- Problem solved: small VR tools need reusable interaction assets, action maps,
  demo scenes, and hand visuals without becoming one monolithic game.
- Reusable core: toolkit folder, demo scene, entry shell, OpenXR action map,
  hand rig asset, import scene, controller/hand fallback note, timing/hit
  detector, and project-level export boundary.
- Source evidence: `OQ_Toolkit`, `demo_scenes`, `GameMain.gd`,
  `openxr_action_map.tres`, OpenSaberPlus `game` and Android/export folders,
  and the Blender hand-rigging `blender/assets/scenes/scripts` split.
- Abstraction boundary: toolkit assets and action maps should stay separate
  from game rules, score loops, or headset-specific export settings.
- What not to copy: older Quest-only assumptions, rhythm-game scoring logic as
  generic interaction code, or hand rigs without skeleton/import provenance.
- Method catalog action: add Method 825.

## Family Placement

Creates a Godot Quest interaction and hand-pipeline family. It overlaps with
Godot XR toolkit coverage but adds older Quest lineage, game-composition, and
asset-pipeline lessons.

## Follow-Up Gaps

- Compare OQ Toolkit conventions with modern `godot-xr-tools`.
- Extract a tiny Godot hand asset provenance checklist.
- Inspect OpenSaberPlus timing/scoring flow as a reusable skill-loop reference.
