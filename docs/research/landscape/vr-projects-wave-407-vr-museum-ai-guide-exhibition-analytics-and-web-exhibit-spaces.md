# Wave 407: VR Museum AI Guide, Exhibition Analytics, and Web Exhibit Spaces

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device tests.

## Theme

This wave studies VR exhibition and museum systems. The reusable value is the
system shape around exhibit metadata, visitor attention, room transitions, AI
guide context, structured exports, and web/data-driven exhibition surfaces.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `KuhakuNeko/VR-AI-Museum` | Studied | Local AI guide, gaze/room logs, RAG, analytics exports |
| `doktorfrag/museum-experience-vr` | Studied | Museum catalog and location interaction prototype |
| `christian-acuna/react-vr-museum` | Studied | Web/React museum collection shell |
| `VIRTUE-DBIS/vre-mixnhack19` | Studied | Data-driven WebVR exhibition and media backend config |

## Findings

### `KuhakuNeko/VR-AI-Museum`

- Interesting idea: offline/local AI museum guide using exhibit-aware RAG,
  gaze/room tracking, voice input/output, and structured visitor analytics for
  curatorial decisions.
- Code donor value: `GazeSense`, `RoomSense`, `PositionSense`,
  `OllamaIntegration`, `WhisperControl`, `ChatbotTTS_Powershell`,
  `ChatbotLogger`, `PersistentID`, and gaze interaction scripts.
- Product reference value: excellent reference for combining visitor-facing
  guidance with professional-facing evidence exports.
- What to inspect next: exact log schemas, RAG document store, prompt
  enrichment, session ID lifecycle, privacy defaults, and survey export.
- Caveat: local Ollama/Whisper/PowerShell TTS dependencies and non-commercial
  license require explicit adapter/provenance handling.

### `doktorfrag/museum-experience-vr`

- Interesting idea: museum experience prototype with catalog entries, picture
  and statue scripts, location detection, and UI catalog manager.
- Code donor value: `CatalogEntry`, `CatalogButtonScript`,
  `UI_CatalogManager`, `LocationDetector`, `PictureScript`, `StatueScript`,
  and `GameController`.
- Product reference value: compact baseline for exhibit catalog + location
  affordance flows.
- What to inspect next: exhibit metadata schema, catalog UI state, and how
  location detection gates content.
- Caveat: VRTK/SteamVR package surface is large; keep custom exhibit/catalog
  scripts as the useful layer.

### `christian-acuna/react-vr-museum`

- Interesting idea: React/Web museum shell around collections, art objects,
  sessions, user collections, search, and profile flows.
- Code donor value: Redux actions/reducers for art objects, collections,
  sessions, user collections, token management, and grid/card components.
- Product reference value: useful companion-app reference for browsing,
  searching, and saving exhibit material outside the headset.
- What to inspect next: API contracts, authentication, collection schema, and
  whether VR rendering still works on modern browser stacks.
- Caveat: web/client architecture is more reusable than any legacy React VR
  runtime details.

### `VIRTUE-DBIS/vre-mixnhack19`

- Interesting idea: WebVR exhibition configured around a backend/database,
  document root, SSL server, and Cineast media-query service.
- Code donor value: `mixnhack19.json`, exhibition assets, and service
  configuration boundaries.
- Product reference value: good example of data-driven exhibit space where VR
  is a client over a media/search backend instead of a closed scene.
- What to inspect next: JSON exhibit manifest, media object schema, Cineast
  query integration, and HTTPS/browser permission constraints.
- Caveat: backend dependencies should be treated as architecture reference,
  not copied blindly.

## Reusable Pattern Extraction

- Pattern candidate: `Exhibit-aware AI guide with visitor analytics export`.
- Problem solved: VR museums need to help visitors in-context while also
  producing non-invasive evidence that curators can use after the visit.
- Reusable core: exhibit manifest, room registry, gaze target IDs, dwell-time
  threshold, room transition logger, visitor session ID, chat transcript,
  prompt context enrichment, local RAG adapter, STT/TTS adapters, survey export,
  narrative journey log, CSV/JSON export, and privacy/retention controls.
- Source evidence: `VR-AI-Museum` documents gaze CSV, journey TXT, chat TXT,
  survey JSON/CSV, `GazeSense`, `RoomSense`, `PositionSense`,
  `OllamaIntegration`, `WhisperControl`, and `ChatbotLogger`; museum prototypes
  add catalog/location scripts and web collection/search shells.
- Abstraction boundary: separate exhibit data, sensing/logging, guide
  generation, voice adapters, and curator analysis exports.
- What not to copy: hard-coded artwork assumptions, non-commercial assets,
  cloud uploads without consent, Windows-only TTS as the only output path, or
  outdated WebVR runtime details.
- Method catalog action: add Method 852.

