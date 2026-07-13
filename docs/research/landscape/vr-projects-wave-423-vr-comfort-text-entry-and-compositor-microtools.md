# VR Projects Wave 423 - VR Comfort Text Entry And Compositor Microtools

- Date: `2026-07-13`
- Theme: VR locomotion comfort, text entry, and compositor-scale microtools.

## Shortlist

| Project | Study status | Why it matters |
|---|---|---|
| `MoonMotionProject/MoonMotion` | Studied | SteamVR-era Unity locomotion toolkit with ready VR player, locomotion modules, camera smoothing, dynamic colliders, and interaction helpers |
| `rjth/Punchkeyboard` | Studied | Unity VR keyboard with autocomplete, next-word prediction, custom dictionaries, physical key mesh, and corpus generation scripts |
| `elvissteinjr/SteamVR-ForceCompositorScale` | Studied | Tiny OpenVR config patcher that registers as an overlay app and forces compositor supersample scale after SteamVR launch |

## Cross-Project Synthesis

This wave collects microtools that improve everyday comfort and usability:
locomotion presets, fast text entry, and sharper compositor overlays. The common
lesson is to keep the utility value narrow, visible, and reversible.

Reusable pattern:

- one clear user pain per microtool;
- bounded settings or assets;
- startup/registration story when the tool must run with SteamVR;
- operator-facing caveats for comfort, compatibility, and config mutation.

## Project Notes

### `MoonMotionProject/MoonMotion`

- Interesting idea:
  bundle common locomotion and VR boilerplate into a ready Unity player so a
  project can start from comfort options rather than raw camera-rig setup.
- Code donor value:
  repository organization documents a toolkit plugin, locomotion prefabs,
  utilities, testing scenes, SteamVR Interaction System base, camera smoothing,
  dynamic colliders, and project settings.
- Product reference value:
  useful reference for packaging locomotion as selectable modules with docs and
  starter scenes.
- Source evidence:
  README describes ready-to-use VR Player, Moon Motion locomotions, object
  interactivity, smooth monitor camera override, dynamic player colliders,
  project template, plugin, prefabs, utilities, and example scenes.
- Reusable core:
  locomotion module catalog, player prefab, comfort docs, dynamic collider
  strategy, and testing scene.
- What not to copy:
  outdated Unity/SteamVR version assumptions, unreleased Lunity dependency, or
  all locomotion choices without modern comfort labels.
- What to inspect next:
  older stable commit, locomotion prefab boundaries, collider scripts, and
  compatibility with current XR input.

### `rjth/Punchkeyboard`

- Interesting idea:
  speed up VR text entry using a physical VR keyboard enhanced with autocomplete
  and next-word prediction, including support for custom dictionaries.
- Code donor value:
  `Assets/Scripts/Word Prediction` includes n-gram generation, Levenshtein
  matching, autocomplete picking, text-field behavior, and dictionary assets;
  `Assets/Scripts/Keyboard` includes key behavior and sound feedback.
- Product reference value:
  strong text-entry UX reference for overlay tools, search panels, chat
  companions, and headset setup flows.
- Source evidence:
  README describes Unity/C# VR keyboard, Reddit-corpus prediction, custom
  dictionaries, and demos; source tree includes ready corpora, raw corpora,
  keyboard mesh/assets, controller scripts, and prediction scripts.
- Reusable core:
  keyboard mesh, key events, audio feedback, prediction dictionary, n-gram
  model, edit-distance correction, and personalized corpus generation.
- What not to copy:
  bundled corpora without provenance review, English-only prediction defaults,
  or keyboard-only text entry without voice/hand fallback.
- What to inspect next:
  prediction latency, dictionary format, privacy of personalized dictionaries,
  and integration with overlay focus rules.

### `elvissteinjr/SteamVR-ForceCompositorScale`

- Interesting idea:
  fix blurry SteamVR dashboard/overlay rendering by patching compositor
  supersample settings and registering as an overlay application for startup.
- Code donor value:
  README describes a minimal OpenVR-linked config mutation utility with custom
  `supersampleScaleCompositor`, overlay app registration, and restart caveats.
- Product reference value:
  excellent example of a narrow SteamVR microtool that patches one annoying
  runtime behavior and makes its limitations explicit.
- Source evidence:
  README documents GPU speed settings reset, custom compositor scale, SteamVR
  overlay application registration, restart requirement, cap behavior, and JSON
  backup warning.
- Reusable core:
  settings read/patch, overlay-app registration, startup behavior, explicit
  user warning, and rollback/backup need.
- What not to copy:
  silent SteamVR settings mutation, JSON edits without dry-run/backup, or
  runtime-specific patching without version checks.
- What to inspect next:
  `main.cpp` settings keys, manifest registration flow, backup/restore design,
  and interaction with current SteamVR compositor behavior.

## Reusable Pattern Extraction

- Pattern candidate:
  `Comfort text and compositor microtool`.
- Problem solved:
  small VR pain points can block daily use even when the main app works:
  movement comfort, text entry, and overlay clarity all need focused helpers.
- Reusable core:
  bounded user pain, small command/config surface, compatibility labels,
  dry-run/backup when mutating runtime config, and clear fallback path.
- Abstraction boundary:
  keep microtool logic separate from full app frameworks; expose settings and
  effects plainly so users understand what changed.
- Method catalog action:
  add new method for focused comfort/text/compositor microtools.

## Follow-Up Gaps

- Compare locomotion comfort labels across older and modern Unity frameworks.
- Design text-entry abstraction that can host keyboard, prediction, voice, and
  paste/desktop companion flows.
- Require dry-run, backup, and restore for future SteamVR config patch tools.
