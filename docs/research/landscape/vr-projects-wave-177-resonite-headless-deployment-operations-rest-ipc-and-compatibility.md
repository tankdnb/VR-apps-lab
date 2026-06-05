# VR Projects Wave 177: Resonite Headless Deployment, Operations, REST/IPC, and Compatibility

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 177 studies operational Resonite headless tooling: container images,
remote consoles, Discord command surfaces, REST resources, shared-memory state
export, and compatibility patch layers.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `voxelbonecloud/resonite-headless-docker` | Containerized Resonite headless deployment | Strong deployment pattern donor |
| `Zetaphor/resonite-headless-manager` | Web operations console over Docker attach | Strong control-plane donor |
| `FlippedCodes/Resonite-Headless-Discord-Bot` | Discord operations bot for Docker headless | Strong product/workflow donor |
| `JackTheFoxOtter/resonite-rest` | In-engine REST API resource tree | Strong API surface donor |
| `Nytra/ResoniteHeadlessHeadServer` | Shared-memory headless scene/state export | Experimental architecture donor |
| `BlueCyro/Nimbus` | Runtime Harmony compatibility shim | Compatibility caution/donor |
| `BlueCyro/Cumulo` | Mono.Cecil compatibility pre-patcher | Compatibility caution/donor |

## `voxelbonecloud/resonite-headless-docker`

- Interesting idea:
  package a Resonite headless server as a reproducible container with Steam
  download/update, config/log/RML volumes, optional mod auto-install, and
  optional git synchronization.
- Code donor value:
  high for image/update/launch split, volume layout, log retention, mod
  staging, and config sync.
- Product reference value:
  high for headless VR/social server operations where repeatable deployment is
  a product feature.
- What to inspect next:
  compare with generic headless server patterns for secrets, rollback, and safe
  config mutation.
- Source evidence:
  `Dockerfile`, `update-resonite.sh`, and `launch-resonite.sh`.
- Reusable pattern extraction:
  containerized headless runtime with explicit update and launch phases.
- Reusable core:
  install runtime dependencies in the image, expose config/log/mod volumes,
  download or update the server through `steamcmd`, install mod loader assets,
  symlink mod/config folders, keep launch arguments explicit, prune stale logs,
  and make optional git sync a visible operator choice.
- Do not copy directly:
  credential handling or destructive cache/data cleanup defaults without
  documented operator consent.
- Caveats:
  Steam credentials and config sync policies need careful security notes.

## `Zetaphor/resonite-headless-manager`

- Interesting idea:
  wrap a headless Docker container in a FastAPI/WebSocket operations console
  that can send commands, stream logs, parse status/world/user data, and show
  host metrics.
- Code donor value:
  high for Docker attach command framing, rolling log buffer, WebSocket fan-out,
  restart handling, and output parsing.
- Product reference value:
  high for a browser operations surface that makes headless server state
  visible to non-terminal users.
- What to inspect next:
  compare command parsing and auth model against Discord and REST control
  surfaces.
- Source evidence:
  `server.py` and `docker_manager.py`.
- Reusable pattern extraction:
  web control plane over a containerized headless CLI.
- Reusable core:
  maintain active WebSocket clients, attach to container stdout/stdin, strip
  ANSI output, keep a rolling log buffer, send commands with timeouts, parse
  worlds/status/users/bans into structured data, and expose restart/kill
  fallback behavior.
- Do not copy directly:
  local-network security assumptions or brittle string parsing without
  operator-visible failures.
- Caveats:
  the control surface is powerful; auth, Docker socket exposure, and command
  timeouts are part of the design.

## `FlippedCodes/Resonite-Headless-Discord-Bot`

- Interesting idea:
  use Discord slash commands as a low-friction operations UI for Docker-hosted
  headless worlds, with container labels, mounted config discovery, world-list
  messages, and marker-delimited command output.
- Code donor value:
  high for Docker label discovery, slash command UX, config-file editing, and
  command-output capture through Docker attach/logs.
- Product reference value:
  high for social/community server operators who already live in Discord.
- What to inspect next:
  compare marker-delimited command capture with web-console and REST patterns.
- Source evidence:
  `docker.ts`, `resoniteCli.ts`, `resoniteConfigFile.ts`,
  `config/session.ts`, and `discordGetResoniteWorldList.ts`.
- Reusable pattern extraction:
  Discord operations surface over container labels and mounted configs.
- Reusable core:
  discover target containers from labels, check role/channel permissions, parse
  a world catalog from Discord messages, edit `startWorlds` config entries,
  attach to Docker stdin/stdout, wrap commands with markers, and summarize
  output back to Discord.
- Do not copy directly:
  unaudited Docker socket exposure or known command-stream race workarounds.
- Caveats:
  README/code comments indicate fragile command streams; marker failures should
  be first-class errors.

## `JackTheFoxOtter/resonite-rest`

- Interesting idea:
  embed a small REST server inside Resonite with route registration, JSON
  responses, ACL auto-add behavior, and resource managers for contact, user,
  and cloud-variable data.
- Code donor value:
  high for resource-tree modeling and engine-component lifecycle.
- Product reference value:
  medium-high for local automation, diagnostics, and external dashboards.
- What to inspect next:
  compare REST resources against headless CLI command surfaces and decide which
  operations deserve structured APIs.
- Source evidence:
  `ApiFramework/ApiServer.cs`, `ResoniteApi.cs`, `ApiResource.cs`, and
  `CloudVariableResourceManager.cs`.
- Reusable pattern extraction:
  in-engine REST component with typed resource managers.
- Reusable core:
  start/stop an `HttpListener` from an engine component, register route
  handlers in a dictionary, serialize structured JSON responses/errors, expose
  resource paths with typed children, and restart the server on port/host
  changes.
- Do not copy directly:
  public host/port defaults or ACL auto-add behavior without a security model.
- Caveats:
  early-development surface; some operations are TODO-heavy.

## `Nytra/ResoniteHeadlessHeadServer`

- Interesting idea:
  export headless scene/render state through shared-memory circular buffers and
  packet queues, allowing an external process to observe a headless runtime.
- Code donor value:
  medium-high for the shared-memory packet queue and connector abstraction.
- Product reference value:
  medium as an experimental direction for headless preview/streaming.
- What to inspect next:
  compare with capture, replay, and remote-rendering waves before promoting
  this into a prototype backlog.
- Source evidence:
  `ExecutionHook.cs`, `Thundagun.cs`, `WorldConnector.cs`, and
  `TextureConnector.cs`.
- Reusable pattern extraction:
  shared-memory headless state exporter.
- Reusable core:
  hook early engine execution, create sync/main/return buffers, wait for a
  client, queue high and normal priority packets, serialize packet IDs and
  payloads, and let connectors publish world/material/texture updates.
- Do not copy directly:
  version-fragile connector internals or deprecated runtime assumptions.
- Caveats:
  project is deprecated and experimental; preserve as architecture reference.

## `BlueCyro/Nimbus`

- Interesting idea:
  patch runtime compatibility gaps with targeted Harmony patches that replace
  removed/changed .NET behaviors and legacy type-name assumptions.
- Code donor value:
  medium for patch organization and compatibility intent.
- Product reference value:
  medium as a cautionary example of runtime compatibility support.
- What to inspect next:
  document when runtime shims are acceptable versus when a public utility
  should refuse unsupported versions.
- Source evidence:
  `Nimbus.cs` and `Nimbus.Helper_Patches.cs`.
- Reusable pattern extraction:
  runtime compatibility shim through explicit Harmony patches.
- Reusable core:
  patch known incompatible methods, preserve legacy type lookup expectations,
  replace unavailable thread behavior with safer modern equivalents, and keep
  helper patches isolated by concern.
- Do not copy directly:
  broad runtime monkey-patching into stable tools.
- Caveats:
  brittle by nature; useful mainly when paired with strict version targeting.

## `BlueCyro/Cumulo`

- Interesting idea:
  run an explicit preflight patcher over target assemblies, bundle runtime
  helper libraries, and warn that the process is irreversible.
- Code donor value:
  medium-high for patcher UX, Mono.Cecil resolver setup, and method-patch
  attribute model.
- Product reference value:
  medium as a compatibility maintenance story, not as a general user utility.
- What to inspect next:
  decide whether `VR-apps-lab` needs a "patcher risk taxonomy" for future
  invasive utilities.
- Source evidence:
  `Program.cs` and `MethodPatchAttribute.cs`.
- Reusable pattern extraction:
  irreversible pre-patcher plus runtime shim distribution.
- Reusable core:
  require an explicit target path, warn before modifying files, resolve target
  assemblies safely, scan for method-patch attributes, apply transforms, copy
  support libraries, and allow a no-shim option for advanced operators.
- Do not copy directly:
  destructive assembly patching without backup, rollback, and version checks.
- Caveats:
  highly version-specific; treat as risk pattern more than donor code.

## Extracted Methods

- Containerized headless server:
  image, update, launch, config, logs, mods, and sync must be separate concerns.
- Remote headless operations surface:
  web, Discord, REST, and CLI attach surfaces all need auth, timeout, and
  command-output models.
- Shared-memory headless state exporter:
  headless rendering/scene state can be serialized as packets, but version
  coupling is a major risk.
- Compatibility patch pair:
  destructive pre-patchers and runtime Harmony shims should be documented as a
  deliberate compatibility strategy with rollback caveats.

## Why This Matters For `VR-apps-lab`

This wave adds a stronger operations branch. Future VR utility tooling is not
only overlays and trackers; it also includes servers, admin surfaces, remote
control, structured APIs, and honest support boundaries around runtime changes.
