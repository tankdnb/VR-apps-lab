# GitHub Research Wave 177 Backlog

- Date: `2026-06-05`
- Theme: `Resonite headless deployment, operations, REST/IPC, and compatibility patches`
- Status: executed as static source-reading pass
- Build/run status: not run, not built, not installed, not launched

## Completed Intake

- Shortlisted Resonite headless deployment, manager, REST/IPC, and patching
  projects.
- Deduplicated against existing Resonite/Neos and social XR families.
- Read Docker, FastAPI, Discord bot, REST plugin, shared-memory connector, and
  patcher entry points.
- Integrated operational and compatibility patterns into the canonical docs.

## Follow-Up Work

- Build a matrix comparing web console, Discord bot, REST plugin, and
  in-process IPC control surfaces.
- Extract a safe `headless-server-ops` checklist:
  config files, logs, mod install, restart semantics, auth, Docker socket
  exposure, and command echo parsing.
- Keep `Nimbus`/`Cumulo` as compatibility cautions, not as general-purpose
  patterns to copy blindly.
- Decide whether shared-memory headless scene export deserves a future
  dedicated wave across Resonite, Unity, OBS, and streaming helpers.

## Reuse Candidates

- Image/update/launch split and config/mod volume layout from
  `resonite-headless-docker`.
- FastAPI/WebSocket console shape and Docker attach command channel from
  `resonite-headless-manager`.
- Discord command surface and Docker-label discovery from
  `Resonite-Headless-Discord-Bot`.
- Route/resource tree abstraction from `resonite-rest`.
- Circular-buffer packet queue from `ResoniteHeadlessHeadServer`.
- Pre-patcher plus runtime shim split from `Cumulo` and `Nimbus`.

## Caveats To Preserve

- Docker socket and network-exposed manager surfaces are sensitive.
- Headless command-output parsing is fragile and should expose timeouts and
  marker failures.
- Compatibility patchers can be destructive, version-specific, and hard to
  support publicly.
