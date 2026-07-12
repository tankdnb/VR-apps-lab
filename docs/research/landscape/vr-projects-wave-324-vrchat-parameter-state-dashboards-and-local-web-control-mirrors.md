# Wave 324 - VRChat Parameter State Dashboards and Local Web Control Mirrors

This wave deepens a previously tracked `Not studied deeply` project into a
full source-level study of avatar parameter state management and mirrored local
control surfaces.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- SteamVR dashboard apps that manage VRChat avatar parameters;
- per-avatar profile persistence and typed OSC replay;
- local browser/web-app mirrors for in-headset dashboard actions;
- projects already queued for deeper study rather than new random links.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `I5UCC/ParameterSaveStates` | VRChat parameter-state dashboard and local web mirror | Studied | Strong donor for per-avatar profile persistence, OSCQuery discovery, dashboard overlay controls, local HTTP API, SSE refresh, export/import, and SteamVR manifest startup |

## Code-Level Findings

### `I5UCC/ParameterSaveStates`

- Interesting idea:
  VRChat avatar parameters can be treated as named, per-avatar state profiles
  that are saved from live OSCQuery metadata and later replayed from an
  in-headset dashboard or a local web UI.
- Code donor value:
  high. `ParameterSaveStates_Director.cs` owns dashboard lifecycle, SteamVR
  manifest registration, keyboard flow, profile paging, tray/web actions, and
  SteamVR-present versus browser fallback behavior. `ProfileService.cs` owns
  profile folders, ordered profile files, apply filters, avatar-specific
  exclusions, copy-from-avatar, import/export, and typed OSC replay.
  `OscService.cs` discovers VRChat through OSCQuery, watches `/avatar/change`,
  caches `/avatar/parameters/...` values by OSC type, and exposes typed
  `SendFloat`, `SendInt`, and `SendBool` sends. `WebUiService.cs` exposes a
  local `HttpListener` API, status/profile routes, archive export/import,
  theme settings, apply filters, avatar auto-sync settings, and SSE-style
  update events.
- Product reference value:
  high for dashboard utilities, avatar workflow tools, profile managers,
  local companion UIs, and any VR utility that should work both inside the
  headset and from a desktop/browser.
- What to inspect next:
  local storage layout, import safety, profile diff UX, destructive action
  confirmations, and how the Web UI handles long-running state changes.
- Architecture pattern:
  `SteamVR dashboard overlay + Unity director + OSC service + profile service
  + local Web UI service`.
- Reusable method:
  avatar/runtime state profiles with a mirrored web-control API.
- UX pattern:
  keep the same core actions available from dashboard, tray/browser, and local
  web app; use the dashboard for headset convenience and the browser for bulk
  or fallback management.
- Constraints / caveats:
  VRChat-specific OSCQuery and avatar metadata assumptions should be isolated;
  import/delete/override/auto-sync actions need strong safeguards if reused.
- Why it matters for `VR-apps-lab`:
  it is a concrete donor for future VR utility dashboards that need persistent
  profiles, local control mirrors, and runtime-aware fallback surfaces.

## Reusable Pattern Extraction

- Pattern candidate:
  dashboard state manager with local web-control mirror.
- Problem solved:
  in-headset utilities often need quick controls in VR and fuller management
  from a desktop browser without duplicating business logic.
- Reusable core:
  runtime discovery, current-object identity, typed state snapshot, named
  profile persistence, apply filters, dashboard action surface, local HTTP API,
  browser fallback, export/import, and update events.
- Source evidence:
  `I5UCC/ParameterSaveStates`.
- Abstraction boundary:
  keep runtime/OSC discovery, profile storage, dashboard UI, and browser API
  separate.
- What not to copy:
  VRChat-specific paths as generic runtime state, destructive profile actions
  without confirmation, or a web API that can mutate state without local trust
  assumptions.
- Method catalog action:
  add a new method for avatar/runtime state dashboards with local web mirrors.

## Follow-Up Gaps

- Compare profile semantics with other VRChat avatar/state tools.
- Add a future reuse plan if `VR-apps-lab` prototypes a generic state/profile
  manager.
- Revisit profile import/export and auto-sync UX as safety-sensitive behavior.
