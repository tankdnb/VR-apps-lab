# Wave 449: Spatial audio SDK packages and acoustic simulation boundaries

## Theme

This wave studies spatial audio packages as reusable VR utility components. The
important pattern is not "add 3D sound" in general, but packaging listener,
source, room, material, occlusion, reverb, HRTF, and engine-adapter boundaries.

## Shortlist

| Project | Status | Family placement |
|---|---|---|
| `resonance-audio/resonance-audio-unity-sdk` | New study | Unity spatial audio SDK package |
| `ValveSoftware/steam-audio` | New study | Cross-engine acoustic simulation SDK |

## Project notes

### `resonance-audio/resonance-audio-unity-sdk`

- Interesting idea:
  a Unity package that exposes spatialization, room effects, occlusion,
  ambisonics, reverb baking, material maps, and near-field controls as editor
  components.
- Code donor value:
  high for Unity component/API shape: listener, source, room, reverb probe,
  acoustic mesh, material map, build processor, and editor inspectors.
- Product reference value:
  strong for VR-apps-lab audio modules that need understandable scene-level
  knobs rather than hidden DSP configuration.
- Architecture pattern:
  Unity components plus custom inspectors plus demo scenes plus build-time
  migration/compatibility checks.
- Source evidence:
  README documents high-quality spatial audio for mobile/desktop Unity. Release
  notes mention 3D spatialization, room effects, material maps, reverb baking,
  near-field gain, occlusion intensity, and migration from Google VR Audio.
  Source includes listener/source editors, build processor, demo scenes, and
  reverb baking examples.
- Reusable core:
  listener profile, source directivity/near-field/occlusion, room material map,
  reverb probe, acoustic mesh, ambisonic recording/import, editor visualization,
  build compatibility check, and clipping/performance caveats.
- What not to copy:
  outdated Unity version assumptions or legacy Google VR migration paths as
  current platform guidance.
- Method catalog action:
  creates `Spatial audio scene component package`.
- What to inspect next:
  compare Resonance Audio's Unity-first component shape against Steam Audio's
  cross-engine adapter model.

### `ValveSoftware/steam-audio`

- Interesting idea:
  a full spatial audio SDK with core DSP/acoustic simulation, Unity integration,
  FMOD/Wwise adapters, HRTF handling, occlusion, reflections, reverb, and
  benchmark/test infrastructure.
- Code donor value:
  high for architecture boundaries rather than direct code copy: core SDK,
  engine wrappers, audio-engine plugin adapters, simulation settings, source
  registration, and HRTF/resource lifecycle.
- Product reference value:
  strong reference for documenting audio feature matrices and provider adapters.
- Architecture pattern:
  core library plus Unity package plus FMOD and Wwise plugins plus tests and
  benchmarks.
- Source evidence:
  `core/README.md` frames the SDK; source exposes `phonon` APIs, HRTF creation,
  geometry/reflection simulation, FMOD plugin descriptions, Wwise source
  adapters, Unity `SteamAudioSource`, and simulation settings.
- Reusable core:
  provider capability record, context/lifetime, HRTF resource, source registry,
  geometry/material scene, occlusion/reflection/reverb toggles, audio-engine
  adapter, editor/package boundary, and license caveat.
- What not to copy:
  SDK internals, licensed Wwise/FMOD portions, binary build assumptions, or
  heavy DSP code into lightweight VR utility prototypes.
- Method catalog action:
  creates `Spatial audio scene component package`.
- What to inspect next:
  derive a provider-neutral spatial audio capability matrix.

## Synthesis

Spatial audio is reusable when it is treated as an inspectable scene component
system:

- listener state
- source state
- room/material model
- occlusion/reflection/reverb
- HRTF and ambisonics
- provider adapter
- editor visualization
- build/runtime caveats

## Follow-up backlog

- Add a spatial audio provider capability matrix.
- Compare Unity, FMOD, Wwise, WebXR/WebAudio, and native OpenXR audio routes.
- Document near-field/clipping and performance caveats for VR utilities.
