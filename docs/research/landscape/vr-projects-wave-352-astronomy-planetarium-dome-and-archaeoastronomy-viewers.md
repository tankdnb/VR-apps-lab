# Wave 352: Astronomy Planetarium Dome and Archaeoastronomy Viewers

## Scope

This wave studies VR and Unity projects that present scientific sky, dome, and
planetarium content. The reusable lesson is that astronomy viewers should split
time/location state, celestial data providers, projection surfaces, and
interaction/UI into separate parts.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `arcAstroVR/arcAstroVR` | Studied | Archaeoastronomy viewer with Stellarium HTTP bridge, local skybox file watching, GIS/location conversion, dataset selection, line/marker editing, and domemaster rendering |
| `mymess/Planetarium` | Studied | Unity planetarium with local astronomy calculation scripts, star/sky models, AASharp algorithms, and date/location/settings editor tooling |
| `imclab/VR-Planetarium` | Studied | Legacy Leap Motion planetarium with arm HUD, joyball hand interaction, constellation labels, video manager, and toggle/data-binding scripts |
| `At-Bristol/DEV0006-DataDomeUnityToolkit` | Studied | Dome projection toolkit with world/projection camera split, fisheye shader, cubemap capture, operator hotkeys, settings persistence, and FPS feedback |

## Reusable Pattern Extraction

- Pattern candidate: `scientific dome and planetarium viewer boundary`.
- Problem solved: scientific sky/dome viewers need accurate time/location and
  projection behavior without hardwiring every scene to one renderer or data
  provider.
- Reusable core: astronomy provider, date/time/location state, dataset/artifact
  loader, external provider bridge, local skybox cache, projection-surface
  adapter, constellation/video toggles, hand/arm HUD, marker/line editing, and
  capability labels for VR, dome, fisheye, and live-sky modes.
- Source evidence: `arcAstroVR` uses `aAV_StelController` for Stellarium HTTP
  calls and `aAV_StreamingSkybox` for file-watched six-sided skybox updates;
  `mymess/Planetarium` keeps sky/star models and astronomy algorithms locally;
  `VR-Planetarium` exposes hand/arm HUD and joyball interaction scripts; Data
  Dome separates `DomeController` and `DomeProjection`.
- Abstraction boundary: sky/science state should not depend on a specific
  camera projection; projection adapters should own cubemap/fisheye/dome output.
- What not to copy: old Unity/Leap assumptions, fixed local Stellarium paths,
  one-off shader settings without capability labels, or external app
  dependencies without health/fallback UI.
- Method catalog action: create a new scientific dome/planetarium viewer method.

## Project Notes

### `arcAstroVR/arcAstroVR`

- Interesting idea: an archaeological scene is combined with a controllable
  Stellarium sky through local HTTP APIs and watched skybox files.
- Code donor value: high for provider bridge, file-watched skybox loading, GIS
  coordinate conversion, marker/line editing, and domemaster output.
- Product reference value: strong for scientific site viewers and research
  exhibits.
- What to inspect next: dataset schema, GIS transform assumptions, skybox
  failure handling, and marker persistence.
- Caveats: depends on Stellarium setup and local file paths.

### `mymess/Planetarium`

- Interesting idea: a Unity project can keep astronomy calculations local with
  star/sky models plus date and location editor tooling.
- Code donor value: high for local astronomy algorithm boundaries and settings
  editors.
- Product reference value: useful for offline planetarium tools.
- What to inspect next: star catalog loading, performance limits, and how
  settings propagate into rendering.
- Caveats: verify licenses and algorithm provenance before reuse.

### `imclab/VR-Planetarium`

- Interesting idea: hand-centric planetarium UX uses an arm HUD, joyball input,
  constellation labels, and video toggles.
- Code donor value: moderate for interaction motifs rather than modern runtime
  code.
- Product reference value: useful as a legacy UX reference for science demos.
- What to inspect next: hand interaction state, video/label binding, and how
  arm HUD panels avoid occluding sky content.
- Caveats: legacy Unity and Leap Motion dependencies.

### `At-Bristol/DEV0006-DataDomeUnityToolkit`

- Interesting idea: a reusable prefab splits world capture and final fisheye
  projection while exposing operator controls and settings persistence.
- Code donor value: high for dome camera/projection boundary and operator
  hotkeys.
- Product reference value: strong for dome-output support in scientific tools.
- What to inspect next: shader quality, UI overlay ordering, and modern Unity
  render-pipeline compatibility.
- Caveats: old Unity APIs and per-frame cubemap cost.

## Product Direction

This wave supports a `scientific projection surface` branch for VR-apps-lab:
domain viewers should be able to target headset VR, domes, fisheye capture, or
external sky providers through explicit adapters.

