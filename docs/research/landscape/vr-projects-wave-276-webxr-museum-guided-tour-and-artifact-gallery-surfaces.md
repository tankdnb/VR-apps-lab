# Wave 276 - WebXR Museum, Guided-Tour, and Artifact-Gallery Surfaces

This wave studies WebXR and Unity museum/gallery surfaces that can inform
future VR utility content browsers, guided tours, artifact viewers, annotation
panels, and creator preview sandboxes.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- WebXR museum rooms, photo galleries, and artifact viewers;
- exhibit metadata schemas and artifact manifests;
- spatial frame grids, portal-like media surfaces, and annotations;
- desktop, AR, and VR fallback paths;
- source-light or artifact-heavy museum references that still teach product
  framing or hygiene caveats.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `artificialmuseum/sandbox` | Artifact preview sandbox | Studied with remote-engine caveat | Compact artifact manifest plus lifecycle hook model |
| `torashad99/xr-photo-museum` | Multiplayer WebXR photo museum | Studied | Photo slots, generated-world portals, annotations, voice notes, room sync |
| `TashaGandevia/GamingMuseum_WebXR` | Metadata-driven WebXR exhibit | Studied with engine caveats | Console metadata, CanvasUI panels, cursor/haptic/audio feedback |
| `rohanbk10/Museum` | Museum SPA with AR/WebXR/desktop viewers | Studied | Unified collection schema, MindAR path, WebXR anchors, cleanup discipline |
| `Shree-svg/Neural_Nexus-Virtual_3D_Museum` | Minimal atmospheric museum | Source-light reference | Simple museum product framing and atmosphere reference |
| `UMN-VR/UMN-VR-Quest-2-App` | Photogrammetry museum artifact payload | Artifact-heavy reference | Useful as a caution for APK/Library-heavy archival dumps |

## Code-Level Findings

### `artificialmuseum/sandbox`

- Interesting idea:
  a tiny artifact sandbox loads a metadata file, imports a custom scene module,
  and lets the scene alter model behavior through lifecycle hooks.
- Code donor value:
  useful manifest pattern with `name`, `slug`, `version`, asset path, skybox,
  `type`, and rotation settings, plus a `CustomScene` class that receives
  `artifact` and `mergeConfig`, captures the engine in `beforeLoadModel`, and
  updates model rotation in `tick`.
- Product reference value:
  good reference for a creator-facing "preview one artifact in a known shell"
  workflow.
- What to inspect next:
  the hosted engine contract, stable sandbox API, upload path, and how model
  errors are reported to creators.
- Reusable pattern:
  artifact manifest plus scene hook boundary.
- Caveats:
  the engine is remote-hosted, the repo is intentionally small, and the local
  server path is only a sandbox companion, not a full museum engine.

### `torashad99/xr-photo-museum`

- Interesting idea:
  a shared WebXR photo museum where framed photos can become portal-like
  generated 3D-world surfaces, with collaboration, annotations, voice notes,
  and drawing.
- Code donor value:
  strong donor for a frame-slot model, `MuseumRoom` layout, photo-frame
  texture lifecycle, parallax `PortalFrame`, Socket.IO room service, throttled
  user pose/context updates, and generation/cache polling around world assets.
- Product reference value:
  excellent reference for a social VR media browser where the important unit is
  not "open file" but "place, annotate, talk about, and expand media."
- What to inspect next:
  data ownership for uploaded photos, generated world cache policy, moderation,
  room recovery, and API-key handling.
- Reusable pattern:
  media slot registry plus portal preview plus collaboration channel.
- Caveats:
  depends on external generation services, has privacy-sensitive uploads, and
  needs stronger production treatment for auth, deletion, and cache visibility.

### `TashaGandevia/GamingMuseum_WebXR`

- Interesting idea:
  a game-console museum uses a metadata catalog and dynamic CanvasUI panels to
  turn exhibits into readable interactive stations.
- Code donor value:
  useful metadata shape for exhibit records and a donor-worthy WebXR panel
  system with canvas texture updates, images, buttons, scroll, input text,
  cursor hit handling, haptic feedback, and spatial click sounds.
- Product reference value:
  good reference for "museum as structured knowledge UI" rather than a static
  asset scene.
- What to inspect next:
  how exhibit object interactions map into panel state, how assets are bundled,
  and which generated/runtime files should be excluded in a cleaner fork.
- Reusable pattern:
  exhibit metadata catalog plus spatial canvas panel.
- Caveats:
  engine-specific Wonderland project, large/generated dependency footprint, and
  many assets that should be treated as product reference rather than code to
  copy.

### `rohanbk10/Museum`

- Interesting idea:
  a museum SPA keeps the collection schema central and exposes the same object
  through desktop 3D, MindAR marker tracking, and WebXR hit-test placement.
- Code donor value:
  strong donor for normalized collection records, annotations, router cleanup
  lifecycle, MindAR start/stop handling, WebXR anchor placement, touch
  transform gestures, CSS2D annotation pins, and dispose/cleanup patterns.
- Product reference value:
  strong reference for a public museum viewer that degrades across desktop,
  AR, and immersive paths without losing the content model.
- What to inspect next:
  target-image authoring, asset provenance, offline packaging, and whether the
  schema can generalize to non-museum VR utility catalogs.
- Reusable pattern:
  collection schema as the durable product boundary, with multiple viewer
  adapters around it.
- Caveats:
  hardcoded collection content and target assets, mobile WebXR compatibility
  limits, and marker/plane behavior that still needs device validation.

### `Shree-svg/Neural_Nexus-Virtual_3D_Museum`

- Interesting idea:
  a compact atmospheric virtual museum shell emphasizes mood, navigation, and
  simple exhibit viewing over technical depth.
- Code donor value:
  low. The useful lesson is product framing and scene atmosphere, not reusable
  architecture.
- Product reference value:
  useful as a minimal "museum shell" reference for onboarding or ideation.
- What to inspect next:
  whether any later branch adds modular content loading, accessibility, or
  input handling.
- Reusable pattern:
  source-light atmospheric gallery baseline.
- Caveats:
  thin code surface and limited evidence for durable reuse.

### `UMN-VR/UMN-VR-Quest-2-App`

- Interesting idea:
  an archived photogrammetry museum proof-of-concept keeps Quest app artifacts
  and Unity/WebXR project payloads after a canceled project.
- Code donor value:
  low to cautionary. The useful lesson is how not to publish a reusable lab:
  APKs, package caches, and generated Unity state obscure the source boundary.
- Product reference value:
  useful as a photogrammetry museum intent and archival caution.
- What to inspect next:
  whether a source-clean branch exists and which photogrammetry capture/viewer
  decisions were actually custom.
- Reusable pattern:
  archival artifact triage.
- Caveats:
  huge artifact-heavy tree, checked-in APK/build/cache material, and limited
  original source signal in the inspected branch.

## Reusable Pattern Extraction

- Pattern candidate:
  museum/gallery content surface pipeline.
- Problem solved:
  make spatial content browsable, annotatable, previewable, and reusable across
  desktop, AR, and VR contexts.
- Reusable core:
  content schema, artifact manifest, frame or exhibit slot, viewer adapter,
  annotation model, collaboration or room state, cleanup lifecycle, and asset
  provenance.
- Source evidence:
  `artificialmuseum/sandbox`, `torashad99/xr-photo-museum`,
  `TashaGandevia/GamingMuseum_WebXR`, and `rohanbk10/Museum`.
- Abstraction boundary:
  keep content metadata separate from engine scene code, network room state,
  generated media services, and device-specific AR/WebXR viewers.
- What not to copy:
  remote-engine lock-in without fallback, unchecked upload/cache flows, large
  generated dependency payloads, APK archives, or hardcoded museum content as a
  general schema.
- Method catalog action:
  add a museum/gallery artifact surface method.

## Follow-Up Gaps

- Build a matrix across artifact manifests, exhibit schemas, frame slots,
  annotation pins, generated-world portals, AR anchors, and cleanup rules.
- Deepen `xr-photo-museum` for collaborative media-room UX.
- Deepen `rohanbk10/Museum` for schema-first multi-viewer structure.
- Treat `UMN-VR/UMN-VR-Quest-2-App` as a repository-hygiene caution node.
