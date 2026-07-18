# Wave 477: WebXR Spatial Audio Listening And Audio-Reactive Surfaces

- Date: `2026-07-18`
- Scope: browser XR audio placement, spatial listening scenes, audio-reactive
  references, and story-state audio surfaces.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `kimuracoki/webxr-audio-ar` | Studied | WebXR AR hit-test surface with DOM overlay and placeable media plane |
| `CtrlZ-Music/webxr-audio-vr` | Source-light reference | README-level multichannel spatial audio and audio-reactive shader concept |
| `dome-vr/dome-vr.github.io` | Studied | Scene-config audio actors, user-gesture audio unlock, global/positional audio factories |
| `GunnLogan/webxr-audio-experience_SoundStorytelling` | Studied | A-Frame audio story graph with proximity/tap nodes and branch progression |
| `shift/webxr-audio-visualizer` | Existing comparison | Prior covered browser audio visualizer line |
| `Alex-DG/vite-three-webxr-audio-visualizer` | Existing comparison | Prior covered audio-reactive WebXR reference |

## Project Notes

### `kimuracoki/webxr-audio-ar`

- Interesting idea:
  Use a browser AR placement flow for media surfaces: reticle, hit-test, DOM
  overlay, and controller select place a visual object into the room.
- Code donor value:
  The useful code is the WebXR AR setup, not audio playback: Three renderer XR
  mode, `immersive-ar`, `domOverlay`, required `hit-test`, viewer hit-test
  source, ring reticle, and select-to-place mesh.
- Product reference value:
  Good reference for placing an audio control or album-art surface in MR before
  connecting actual playback.
- Source evidence:
  `src/components/HelloAR.tsx`, `OverRay.tsx`, and media assets.
- Reusable core:
  AR support gate, DOM overlay root, hit-test source lifecycle, reticle matrix,
  controller select, placed mesh visibility, and texture-backed plane.
- What not to copy:
  Do not treat this as a complete audio app; the audio asset is present but the
  inspected path does not wire a real audio flow.
- What to inspect next:
  Pair this placement shell with a real WebAudio/positional source controller.

### `CtrlZ-Music/webxr-audio-vr`

- Interesting idea:
  Present multichannel audio as visible spatial objects with analyser-driven
  visual response and GUI controls.
- Code donor value:
  No source donor value was confirmed because the clone contained only
  README/LICENSE in this pass.
- Product reference value:
  Useful product sketch for 8.1 speaker layout, point-source spheres,
  subwoofer, analyser, GUI tuning, and audio-reactive materials.
- Source evidence:
  README-level description only.
- Reusable core:
  Treat as a concept card for spatial source inventory and analyser-driven
  feedback, not as code.
- What not to copy:
  Do not promote it as an implementation method until source files are
  available and inspected.
- What to inspect next:
  Search for active forks or deployments that contain the missing source.

### `dome-vr/dome-vr.github.io`

- Interesting idea:
  Treat audio as a scene actor declared in config and unlocked through a
  user-visible `startAudio` control.
- Code donor value:
  Useful references include `initializeAudio`, `GlobalAudio`, `Pointaudio`,
  config-state actor creation, `THREE.AudioListener` attached to camera,
  `THREE.AudioLoader`, and cached cycling buffers.
- Product reference value:
  Strong reference for narrative/dome/planetarium tools where scene state owns
  audio sources and the UI must explain why audio needs user activation.
- Source evidence:
  `narrative-sh.js`, `scenes/audio/initializeAudio.js`, `audio-vrcloud4.js`,
  `enable-button.js`, `dist/app/models/stage/actors/audio/pointAudio.js`,
  `globalAudio.js`, and `globalaudio-cycle-cache.js`.
- Reusable core:
  audio actor descriptor, URL/volume/playbackRate/loop fields, audio listener
  on camera, enable button, positional audio attached to named actor, global
  audio factory, cache/cycle buffer, and per-frame `delta` update.
- What not to copy:
  The repository includes generated/vendor/cache-like content and local
  cert/key artifacts; copy only the scene-config audio actor idea.
- What to inspect next:
  Extract a clean audio actor schema with provenance and user-gesture state.

### `GunnLogan/webxr-audio-experience_SoundStorytelling`

- Interesting idea:
  Model listening as a spatial story graph: users move or tap to trigger audio
  nodes, then the graph reveals the next choices.
- Code donor value:
  A-Frame components define intro unlock, current-audio singleton state,
  proximity/tap trigger policy, one-active-audio rule, branch graph, spawned
  direction nodes, and debug finish action.
- Product reference value:
  Good reference for guided audio tours, accessibility listening paths, and
  spatial story authoring.
- Source evidence:
  `scripts/start.js`, `audio.js`, `proximity.js`, and `path-manager.js`.
- Reusable core:
  audio-context unlock, platform fallback, node id, `assets/audio/{id}.wav`
  convention, proximity radius, tap-only mobile fallback, sound-ended event,
  authoritative `PATH_GRAPH`, branch spawning, and one-active-audio invariant.
- What not to copy:
  Global state names, unbounded WAV assets, and iOS fake passthrough as if it
  were true WebXR AR.
- What to inspect next:
  Define a compact audio story node schema and source provenance rules.

## Reusable Pattern Extraction

- Pattern candidate:
  `WebXR spatial audio surface with source placement analyser and
  listening-story state`.
- Problem solved:
  Audio VR tools need source placement, user-gesture unlock, visible playback
  state, optional analyser feedback, and story/proximity logic.
- Reusable core:
  media source descriptor, listener attachment, global/positional source
  factory, user activation gate, source inventory, analyser output, visual
  source marker, proximity/tap trigger, one-active-audio rule, graph transition,
  and provenance/performance labels.
- Source evidence:
  `kimuracoki/webxr-audio-ar`, `dome-vr/dome-vr.github.io`,
  `GunnLogan/webxr-audio-experience_SoundStorytelling`, and source-light
  `CtrlZ-Music/webxr-audio-vr`.
- Abstraction boundary:
  Separate media ownership from spatial presentation: the scene can place,
  label, and trigger sources without owning a fragile asset library.
- What not to copy:
  Bundled generated content, local certs, missing-source claims, or hidden audio
  autoplay attempts.
- Method catalog action:
  Add `Method 922`.

## Why This Matters For `VR-apps-lab`

Spatial audio utilities are not just players. They are stateful surfaces that
combine source placement, listener context, unlock UX, source provenance,
audio-reactive feedback, and story/listening flow.
