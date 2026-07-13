# Wave 392: Caption, Voice, and Descriptive Accessibility Surfaces

## Theme

Accessible XR communication surfaces: captions, subtitles, voice-gesture
activation, TTS/voice SDK boundaries, and descriptive menus for partially
sighted users.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `XR-Access-Initiative/chirp-captions` | Deepened | Caption package with runtime manager, renderers, safe area, and source-direction cues |
| `XR-Access-Initiative/voicesdk-samples-whisperer-captions` | Studied | Voice SDK sample with gesture-triggered voice interaction, prompts, TTS, and object commands |
| `JustinMorera/VR-Accessibility-SDK` | Studied | Small accessibility package with partial-vision descriptive object menus |

## Dedupe Notes

`chirp-captions` was already covered in Wave 297. It is used here as a
deepening/reference node to connect caption rendering with voice-driven
accessible interaction and descriptive text menus.

## Code-Level Findings

### `XR-Access-Initiative/chirp-captions`

- Interesting idea: captions should be treated as a runtime service with
  multiple renderers, timing, head-locked safe-area placement, and directional
  cues toward sound sources.
- Code donor value: `Runtime`, package metadata, and `Documentation~` show a
  package-shaped caption system rather than one scene-specific subtitle script.
- Product reference value: useful baseline for accessibility overlays, training
  apps, and assistive HUDs where captions are persistent infrastructure.
- What to inspect next: renderer switching, off-screen source arrows, caption
  source adapters, and user preferences.
- Caveat: already studied; avoid duplicating registry notes beyond the
  accessibility-method synthesis.

### `XR-Access-Initiative/voicesdk-samples-whisperer-captions`

- Interesting idea: combine hand gesture, gaze/object selection, voice command,
  narrative prompts, TTS, and visual feedback into an accessible interaction
  loop.
- Code donor value: `Assets/Whisperer`, `SpeakGestureWatcher.cs`, Voice SDK,
  TTS runtime/cache code, loader scene, and project README show a voice
  activation and response pipeline.
- Product reference value: useful for assistive command surfaces where users
  need multimodal confirmation that the system is listening and responding.
- What to inspect next: Wit.ai credential boundaries, recording-state reset,
  voice cache, object command grammar, and offline fallback.
- Caveat: cloud voice providers require consent, credential hygiene, and
  privacy labels.

### `JustinMorera/VR-Accessibility-SDK`

- Interesting idea: a partial-vision tool can let users target an object and
  request descriptive text menus.
- Code donor value: package layout, `Assets`, prefab/tool setup instructions,
  and Input System command assignment show a compact accessibility SDK shape.
- Product reference value: useful for object-description overlays and
  inspectable scene annotations.
- What to inspect next: target selection model, description data source,
  menu readability, and nonvisual fallback.
- Caveat: source is small; treat it as product pattern and package shape rather
  than a mature donor.

## Reusable Pattern Extraction

- Pattern candidate: accessible caption/voice/descriptive surface.
- Problem solved: accessible XR needs caption timing, listening state,
  descriptive object metadata, voice/TTS feedback, and user preference controls
  as shared services.
- Reusable core: caption source, timed caption, renderer selector, safe-area
  placement, sound-source cue, speak gesture, listening indicator, command
  grammar, TTS/cache adapter, object description, readable menu, and privacy
  label.
- Source evidence: `chirp-captions` `Runtime/Documentation~`,
  Whisperer `Assets/Whisperer` and Voice/TTS scripts, and
  `VR-Accessibility-SDK` package/prefab setup.
- Abstraction boundary: accessibility services should not own gameplay logic,
  cloud credentials, or object-description content.
- What not to copy: provider credentials, one-size-fits-all caption placement,
  voice recording without consent, or text descriptions without nonvisual
  fallback.
- Method catalog action: add Method 837.

## Family Placement

Creates an accessibility communication surface family, connected to previous
caption/subtitle and voice-command waves.

## Follow-Up Gaps

- Define a shared caption/source/preference schema.
- Compare speak-gesture activation with existing voice-command methods.
- Add object description metadata to future scene-annotation tools.
