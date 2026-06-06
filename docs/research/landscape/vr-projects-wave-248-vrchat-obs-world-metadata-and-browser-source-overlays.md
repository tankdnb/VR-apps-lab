# VR Projects Wave 248: VRChat OBS World Metadata and Browser Source Overlays

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies small VRChat-to-OBS overlays that expose the current world,
author, instance, thumbnail, or transition state to a stream. The projects are
mostly micro-utilities, but they show several reusable ingress patterns:
Windows registry polling, VRCX SQLite reads, VRChat log tailing, authenticated
VRChat API polling, Server-Sent Events, OBS browser sources, plain text file
outputs, and OBS-native Lua scripts.

## Why It Matters For `VR-apps-lab`

Streamer-facing VR utilities often sit outside the headset but still depend on
VR runtime or social-app state. These projects show how a thin utility can
turn local VRChat state into a stable overlay surface without becoming a full
companion platform.

## Project Notes

### `Natsumi-sama/VRC-OBS-Overlay`

- Interesting idea:
  a local Blazor server app can poll VRChat's Windows registry location
  context and expose a CSS-customizable browser source on localhost.
- Code donor value:
  `PollRegistry.cs` reads `HKCU\SOFTWARE\VRChat\VRChat` and parses
  `LocationContext_World_h2703649242`. `Program.cs` runs a background update
  loop, disables browser caching, and pushes `WorldInfoData` into a Razor UI.
  `WorldInfo.cs` fetches the VRChat world page and extracts OpenGraph metadata
  with `HtmlAgilityPack`.
- Product reference value:
  useful micro-overlay reference for "download, run, add browser source"
  streamer UX.
- What to inspect next:
  compare registry polling with VRCX database reads and log tailing under
  VRChat updates.
- Architecture pattern:
  registry location context -> metadata fetch -> server-side UI state ->
  OBS browser source.
- Reusable method:
  keep the local overlay server, world-state reader, metadata fetcher, and CSS
  theme as separate pieces.
- Caveats:
  Windows-only registry dependency, page scraping rather than official API
  authentication, and no visible cross-platform fallback.

### `philippgitpush/vrc-obs-world-overlay`

- Interesting idea:
  VRCX can be used as a local state oracle for OBS overlays by reading its
  SQLite database and cached VRChat auth cookie.
- Code donor value:
  `src/electron/vrchat.js` reads `VRCX.sqlite3`, queries
  `gamelog_location`, decodes stored cookie data, fetches world details, and
  updates app store state. `src/electron/main.js` hosts an Express server on a
  fixed local port, blocks non-local CORS origins, exposes settings JSON, and
  serves overlay/config/dashboard routes. The Vue overlay separates placement,
  platform badges, appearance settings, and stream-ready layout.
- Product reference value:
  strong reference for a streamer overlay with an actual config UI and
  polished browser-source presentation.
- What to inspect next:
  compare VRCX dependency tradeoffs against direct log parsing for privacy and
  reliability.
- Architecture pattern:
  Electron config app + local Express server + VRCX SQLite/auth extraction +
  Vue overlay route.
- Reusable method:
  when a trusted local companion already has VRChat state, treat it as a
  source adapter rather than reimplementing all account/session handling.
- Caveats:
  depends on VRCX being installed and running, reads auth-cookie material, and
  is Windows-focused.

### `ktmage/vrc-world-credit-streaming-overlay`

- Interesting idea:
  a small TypeScript server can tail VRChat logs, fetch world metadata through
  the official API shape, and push typed events to a browser-source client.
- Code donor value:
  `src/server/log-watcher.ts` finds the newest VRChat log, tracks file offset,
  handles line leftovers, extracts world IDs, and emits only real changes.
  `src/server/vrchat-api.ts` validates world IDs and API responses with Zod,
  requires a contact user-agent, caches responses, and enters a visible
  rate-limit placeholder on HTTP 429. `src/server/sse.ts` broadcasts events to
  clients, while `src/client/main.ts` renders card or topbar styles based on a
  query parameter.
- Product reference value:
  very good reference for a minimal but careful log-to-browser-source overlay.
- What to inspect next:
  use it as a baseline for a typed VRChat log watcher and SSE overlay
  template.
- Architecture pattern:
  latest-log watcher -> validated world ID -> VRChat API cache -> SSE ->
  style-selectable browser source.
- Reusable method:
  make log parsing incremental, make API shape explicit, and make rate-limit
  failure a visible overlay state.
- Caveats:
  requires a valid API contact, assumes current VRChat log wording, and should
  avoid storing unnecessary account material.

### `Mahcks/vrc-world-teller`

- Interesting idea:
  a tiny Node script can poll the VRChat API and write the current world to a
  text file for OBS text sources.
- Code donor value:
  `index.js` logs in with the `vrchat` package, polls the current user, fetches
  world details, and writes `world.txt` with optional author text.
- Product reference value:
  useful proof that the smallest possible surface can still have stream value.
- What to inspect next:
  replace credential polling with a safer local-state adapter before reuse.
- Architecture pattern:
  VRChat API auth -> current user poll -> world fetch -> plain text file.
- Reusable method:
  support text-file output as a lowest-friction OBS integration path.
- Caveats:
  stores VRChat credentials/API key in environment, polls continuously, and has
  no rate-limit or 2FA story in inspected files.

### `Elocin-Anagram/VRC_World_Location`

- Interesting idea:
  a PowerShell script can tail VRChat logs and write both world and system
  status text files that a browser-source HTML page polls.
- Code donor value:
  `VRC_Locator.PS1` locates the newest `output_log_*.txt`, chooses tail length
  based on log size, searches multiple world-entry patterns, writes current
  world/instance text, and appends performance status. `OBSbrowserSource.html`
  fetches the generated files once per second and renders the last line.
- Product reference value:
  useful Windows micro-utility reference for non-developer streamers.
- What to inspect next:
  extract only the adaptive log-tail and plain-file browser-source pattern.
- Architecture pattern:
  PowerShell log tail -> text files -> local HTML browser source polling.
- Reusable method:
  adaptive tail windows help avoid rescanning very large VRChat logs.
- Caveats:
  execution-policy changes are risky, path assumptions are Windows-specific,
  and polling local files from browser sources needs OBS-specific context.

### `nosjo/obs-vrchat-log-reader`

- Interesting idea:
  an OBS Lua script can read VRChat logs directly and switch OBS scenes when
  room-transition events are detected.
- Code donor value:
  `obs-vrchat-log-reader.lua` runs inside OBS, locates the latest log file,
  tracks file changes, scans only new lines after first run, watches
  `OnLeftRoom`, `Finished entering world`, and destination lines, and invokes
  OBS frontend scene-switch APIs from script settings.
- Product reference value:
  strong micro-reference for avoiding a separate app when OBS itself can host
  the automation.
- What to inspect next:
  compare OBS-native scripts against external WebSocket controllers for
  reliability, permissions, and portability.
- Architecture pattern:
  OBS script settings -> VRChat log tail -> event classifiers -> OBS scene
  operations.
- Reusable method:
  if the output is only OBS behavior, consider embedding the bridge as an OBS
  script rather than a companion daemon.
- Caveats:
  Lua script depends on OBS scripting APIs and log wording, and bundled curl
  submodule handling was not inspected beyond source layout.

## Reusable Pattern Extraction

- Pattern candidate:
  VRChat world metadata to OBS overlay pipeline.
- Problem solved:
  stream overlays need timely VRChat state without forcing the streamer to
  manually update text, thumbnails, scenes, or world credits.
- Reusable core:
  state source adapter, deduplicated current-world detector, metadata fetch or
  cache, output adapter, browser-source or OBS-native render surface, visible
  stale/error state, and privacy/rate-limit caveats.
- Source evidence:
  `VRC-OBS-Overlay`, `vrc-obs-world-overlay`,
  `vrc-world-credit-streaming-overlay`, `vrc-world-teller`,
  `VRC_World_Location`, and `obs-vrchat-log-reader`.
- Abstraction boundary:
  separate state ingress from metadata lookup, and metadata lookup from the
  stream-facing surface.
- What not to copy:
  credential storage without a security model, auth-cookie scraping without
  user consent, brittle log strings as the only parser, or scripts that change
  execution policy as a normal install step.
- Method catalog action:
  add a method entry for VRChat world metadata overlay pipelines.

## Follow-Up Gaps

- Build a comparison matrix across registry, VRCX SQLite, VRChat API, and log
  tailing.
- Extract a safe OBS browser-source template for local world metadata.
- Decide whether OBS-native scripts deserve a separate "no companion app"
  family inside stream utilities.
