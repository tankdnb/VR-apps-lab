# VR Projects Wave 130: Resonite/Neos Modding, Headless, External SDK, and Social Utility Tooling

- Date: `2026-06-05`
- Goal: study Resonite/Neos ecosystem tooling as reusable patterns for social
  VR mod loaders, manifests, GUI mod managers, external data-model SDKs,
  headless deployment, companion clients, and in-world diagnostics.

## Why this wave exists

Social VR ecosystems generate rich utility patterns that are not overlays:

- mod-loader lifecycle and conflict logging;
- audited mod manifests with schemas and artifact hashes;
- GUI mod managers with cache, install, update, and unrecognized-mod logic;
- WebSocket/REPL external data-model SDKs;
- headless server packaging;
- social companion apps for contacts, sessions, inventory, messages, and hubs;
- in-world metrics panels and profiling helpers.

## Better workflow used in this wave

1. searched by Resonite, Neos, mod loader, headless, SDK, contact app, and
   metrics families;
2. deduplicated against VRChat creator/tooling and audio/media waves;
3. froze a Resonite ecosystem shortlist;
4. inspected local-only source clones;
5. separated ecosystem-management patterns from game/app-specific features;
6. extracted reusable manifest, loader, SDK, companion, and diagnostics
   methods.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `resonite-modding-group/ResoniteModLoader` | Mod loader, config, Harmony, conflict, and headless-aware loading |
| `Gawdl3y/Resolute` | Tauri/Rust/Vue GUI mod manager and manifest client |
| `resonite-modding-group/resonite-mod-manifest` | Schema-first mod manifest repository and generator scripts |
| `Yellow-Dog-Man/ResoniteLink` | WebSocket/REPL SDK for external data-model operations |
| `shadowpanther/resonite-headless` | Docker/Kubernetes packaging for Resonite headless |
| `Nutcake/ReCon` | Flutter social VR companion client |
| `esnya/ResoniteMetricsCounter` | ResoniteModLoader metrics/profiling mod with UIX panels |

## Deep-pass notes by project

## `resonite-modding-group/ResoniteModLoader`

- GitHub:
  [resonite-modding-group/ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader)
- What it is:
  a mod loader for Resonite.
- Interesting idea:
  a social VR mod loader should be a managed ecosystem surface: assembly
  discovery, single mod-class enforcement, config loading, localized metadata,
  duplicate-name checks, Harmony conflict logging, headless detection, and
  per-mod lifecycle hooks.
- Code-level notes:
  `ModLoader.cs` discovers assemblies from `rml_mods`, loads exactly one
  `ResoniteMod` class per assembly, logs SHA256, builds configuration, tracks
  loaded mods by assembly/name, calls `OnEngineInit`, detects duplicate names,
  catches reflection loader exceptions, detects headless by scanning loaded
  assemblies for `FrooxEngine.Headless`, and optionally logs Harmony patch
  conflicts. `ResoniteMod.cs` defines lifecycle, logging, config definition,
  and incompatible config handling. `ModConfiguration.cs` stores per-mod JSON
  config in `rml_config`, includes version compatibility, converters, change
  events, autosave, and debounce protection for spammy saves.
- Code donor value:
  very high for mod-loader lifecycle, config, and diagnostics patterns.
- Product reference value:
  high for ecosystem tooling governance.
- Caveats:
  game-specific API and Harmony assumptions; reuse should focus on loader
  discipline and support boundaries.
- What to inspect next:
  compare loader config and manifest conventions with QMOD from Wave 128.

## `Gawdl3y/Resolute`

- GitHub:
  [Gawdl3y/Resolute](https://github.com/Gawdl3y/Resolute)
- What it is:
  a Tauri/Rust/Vue Resonite mod manager.
- Interesting idea:
  a mod manager should model manifest retrieval, cache staleness, installed
  state, unrecognized artifacts, download/update/delete operations, and
  UI-facing version status as first-class concepts.
- Code-level notes:
  `manifest.rs` downloads the canonical manifest, optionally caches it,
  checks staleness, falls back to stale cache on download failure, parses
  typed manifest data, and supports custom remote/cache configuration.
  `manager/mod.rs` retrieves all mods, marks installed versions from a
  database, matches unrecognized installed artifacts to known mods by filename,
  adds unrecognized versions where needed, downloads installs, updates by
  removing obsolete artifacts, and stores installed state.
- Code donor value:
  high for manifest-backed manager architecture.
- Product reference value:
  high for desktop companion UX around a mod ecosystem.
- Caveats:
  dependency on one manifest community and app-specific artifact locations.
- What to inspect next:
  extract a generic "manifest manager" model for plugin-like VR utilities.

## `resonite-modding-group/resonite-mod-manifest`

- GitHub:
  [resonite-modding-group/resonite-mod-manifest](https://github.com/resonite-modding-group/resonite-mod-manifest)
- What it is:
  a community mod manifest repository with JSON schemas and generators.
- Interesting idea:
  a mod ecosystem can be curated through author folders, per-mod info files,
  schema validation, artifact hashes, dependency/conflict metadata, platform
  labels, categories, tags, and generated aggregate manifest output.
- Code-level notes:
  `schemas/mod-schema.json` requires `name`, `id`, `description`, `category`,
  and `versions`; enumerates categories and platforms; supports tags, flags,
  source/website URLs, dependencies, conflicts, artifacts, install locations,
  and required SHA256 hashes. `generate_manifest.py` gathers author metadata,
  links additional authors, uses mod IDs as manifest keys, drops empty author
  groups, and writes a versioned aggregate `manifest.json`.
- Code donor value:
  very high for schema-first registry design.
- Product reference value:
  high for public ecosystem governance.
- Caveats:
  schema design is tightly tied to Resonite mod artifacts.
- What to inspect next:
  compare with QMOD and future `VR-apps-lab` reusable package metadata.

## `Yellow-Dog-Man/ResoniteLink`

- GitHub:
  [Yellow-Dog-Man/ResoniteLink](https://github.com/Yellow-Dog-Man/ResoniteLink)
- What it is:
  a C# SDK/REPL for controlling and inspecting Resonite sessions through a
  WebSocket data-model interface.
- Interesting idea:
  social VR worlds can expose an external automation surface with typed
  commands, responses, reflection queries, binary payload follow-ups, and a
  REPL for safe exploration.
- Code-level notes:
  `LinkInterface.cs` manages a WebSocket client, pending responses by message
  ID, JSON serialization that allows named floating-point literals and deep
  object graphs, text response routing, optional binary payload sending, and
  API methods for session data, slots, components, asset imports, reflection,
  method calls, and batched data-model operations. `REPL_Controller.cs`
  selects slots/components, lists children/components, adds/removes slots and
  components, prints prompts, and allocates unique REPL-prefixed IDs to avoid
  session collisions.
- Code donor value:
  very high for external SDK and command/response protocol anatomy.
- Product reference value:
  high for social VR automation and diagnostics.
- Caveats:
  requires a compatible in-world/server side and careful security boundaries.
- What to inspect next:
  use it as a reference for any future external control bridge.

## `shadowpanther/resonite-headless`

- GitHub:
  [shadowpanther/resonite-headless](https://github.com/shadowpanther/resonite-headless)
- What it is:
  Docker and Kubernetes packaging for a Resonite headless server.
- Interesting idea:
  social VR utilities often need deployable headless infrastructure with
  persistent config/log volumes, SteamCMD setup, locale setup, app install
  scripts, and Kubernetes examples.
- Code-level notes:
  `Dockerfile` creates a Steam user, installs SteamCMD dependencies, sets
  Resonite app IDs and beta/login environment variables, defines config/log
  volumes, copies setup/start scripts, and uses SIGINT as stop signal. The repo
  also includes `docker-compose` and Kubernetes sample YAML plus default
  config.
- Code donor value:
  medium for headless deployment packaging.
- Product reference value:
  high for operator/deployment story.
- Caveats:
  not a code API donor; mainly operations reference.
- What to inspect next:
  compare with headless/robot/teleoperation deployment waves.

## `Nutcake/ReCon`

- GitHub:
  [Nutcake/ReCon](https://github.com/Nutcake/ReCon)
- What it is:
  a Flutter Resonite companion app for social, session, inventory, messaging,
  and profile workflows.
- Interesting idea:
  a social VR companion app can provide useful utility value outside the
  headset through authenticated API clients, cached login, SignalR-like hub
  events, contacts, sessions, inventory, messages, and media attachments.
- Code-level notes:
  `api_client.dart` handles login, TOTP challenge, encrypted secure storage,
  cached token/password login, session extension, authorization headers, common
  HTTP verbs, response-code UX, and logout events. `hub_manager.dart` manages
  WebSocket negotiation packets, reconnect timeouts, invocation handlers,
  completion/stream events, ping/close handling, and request/response
  invocation IDs.
- Code donor value:
  high for social companion auth, API, and live-event patterns.
- Product reference value:
  high for headset-adjacent social utility UX.
- Caveats:
  service-specific API assumptions and sensitive credential handling.
- What to inspect next:
  compare with VRChat companion apps and OSC/data hub waves.

## `esnya/ResoniteMetricsCounter`

- GitHub:
  [esnya/ResoniteMetricsCounter](https://github.com/esnya/ResoniteMetricsCounter)
- What it is:
  a ResoniteModLoader mod for collecting and displaying world metrics.
- Interesting idea:
  creator diagnostics can live inside the social VR world: profile runtime
  elements, group by stage/object root, blacklist or ignore hierarchy, write
  JSON trace files, and render UIX hierarchy/detail pages.
- Code-level notes:
  `MetricsCounter.cs` tracks engine version, elapsed time, frame count,
  blacklist, per-element and per-object-root storage, focused-world filtering,
  local/removed element filtering, ignored hierarchy pruning, ProtoFlux group
  handling, world-stage categorization, JSON serialization with world element
  converters, and blacklist/hierarchy updates. The repo also includes patches,
  UIX pages, metrics panels, and metric column definitions.
- Code donor value:
  high for in-world diagnostics and metrics persistence.
- Product reference value:
  high for creator-facing performance tools.
- Caveats:
  Resonite-specific engine types.
- What to inspect next:
  compare with VRChat creator diagnostics and WebXR diagnostic waves.

## Cross-project synthesis

Reusable lessons:

- mod ecosystems need loader, manifest, manager, and config boundaries;
- manifests should record artifact hashes, install locations, conflicts, and
  dependencies;
- managers need cache staleness, stale fallback, installed-state reconciliation,
  and unrecognized artifact handling;
- external SDKs should use IDs, pending response maps, validation, and batch
  operations;
- headless deployments should keep config/logs persistent and setup explicit;
- social companion apps need reconnecting live-event hubs and credential
  hygiene;
- in-world diagnostics should support ignore/blacklist filters and exportable
  traces.

Best donor candidates:

- `ResoniteModLoader` for loader/config/conflict lifecycle;
- `resonite-mod-manifest` and `Resolute` for manifest-backed mod management;
- `ResoniteLink` for external data-model SDK/REPL design;
- `ResoniteMetricsCounter` for in-world diagnostics.

## Reuse implications for `VR-apps-lab`

This wave suggests a `social VR ecosystem tooling` branch:

- schema-first plugin/utility registry;
- manifest-backed companion manager;
- external control/inspection SDK patterns;
- headless deployment checklist;
- creator diagnostics and in-world metrics panels.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were used only for code reading and are local-only.
