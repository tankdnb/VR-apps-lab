# GitHub Research Wave 177 Plan

- Date: `2026-06-05`
- Theme: `Resonite headless deployment, operations, REST/IPC, and compatibility patches`
- Scope: Resonite/Neos headless containers, Docker managers, Discord control
  surfaces, REST plugins, shared-memory scene export, and runtime compatibility
  patch layers.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

The repository already tracks social XR, Resonite creator tooling, and headless
interest. This wave narrows onto the operational side: how a headless runtime
is packaged, controlled remotely, exposed through REST/Discord/web surfaces,
and patched when runtime compatibility shifts.

## Search Families

- Resonite headless Docker images
- Resonite headless managers and consoles
- Discord control bots for headless worlds
- Resonite REST or IPC plugins
- shared-memory headless render/state export
- compatibility patchers and Harmony shims

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `voxelbonecloud/resonite-headless-docker` | Container image with Steam headless download, config/mod volumes, log paths, and git sync | Containerized headless deployment |
| `Zetaphor/resonite-headless-manager` | FastAPI/WebSocket manager around Docker attach, logs, parsed status, and system metrics | Web operations console |
| `FlippedCodes/Resonite-Headless-Discord-Bot` | Discord slash-command operations surface using Docker labels, logs, and config file edits | Discord control surface |
| `JackTheFoxOtter/resonite-rest` | In-engine REST API server and resource abstraction for headless/Resonite data | REST plugin and resource tree |
| `Nytra/ResoniteHeadlessHeadServer` | Deprecated but instructive shared-memory connector for headless visual/state output | Shared-memory scene export |
| `BlueCyro/Nimbus` | Harmony runtime compatibility layer for .NET/Resonite shifts | Runtime compatibility shim |
| `BlueCyro/Cumulo` | Mono.Cecil pre-patcher that bundles Nimbus/Harmony and modifies target assemblies | Preflight compatibility patcher |

## Dedupe Notes

- Prior Resonite waves covered creator import/export, mods, and social utility
  tooling. This wave focuses on server operations and compatibility surfaces.
- `Nytra/ResoniteHeadlessHeadServer` is deprecated, but it is included because
  its shared-memory packet queue and connector idea are architecturally useful.
- `Nimbus` and `Cumulo` are not general product references. They are
  compatibility-layer lessons with strong brittleness caveats.

## Code-Level Pass Targets

- Dockerfile, entrypoint, runtime update, mod install, config/log volume, and
  git-sync behavior;
- Docker attach, stdin/stdout command framing, rolling logs, graceful restart,
  metrics, and WebSocket fan-out;
- Discord command permission model, container label discovery, config-file
  edits, world-list parsing, and marker-delimited command output;
- REST server route/resource abstraction and lifecycle inside the engine;
- shared-memory circular buffer and packet serialization model;
- Harmony runtime patches and Mono.Cecil irreversible pre-patching model.

## Expected Outputs

- Wave 177 landscape synthesis.
- Registry/family placement for headless deployment and operations.
- Methods around containerized headless servers, remote control planes,
  compatibility patch pairs, and shared-memory state export.
