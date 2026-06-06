# GitHub Research Wave 248 Backlog

Date: 2026-06-06

Theme: VRChat OBS world metadata and browser source overlays.

## Completed In This Wave

- Studied `Natsumi-sama/VRC-OBS-Overlay` as a Blazor localhost browser-source
  overlay using Windows registry world context, OpenGraph metadata fetching,
  no-cache server responses, and CSS customization.
- Studied `philippgitpush/vrc-obs-world-overlay` as an Electron/Vue overlay
  with VRCX SQLite world lookup, auth-cookie extraction, local Express routes,
  CORS checks, settings persistence, and placement/platform UI.
- Studied `ktmage/vrc-world-credit-streaming-overlay` as a TypeScript
  log-to-SSE overlay with incremental file tailing, VRChat API contact
  handling, Zod schemas, response caching, 429 placeholder state, and card or
  topbar browser-source styles.
- Studied `Mahcks/vrc-world-teller` as a micro Node API poller that writes
  current world or world-plus-author text into `world.txt`.
- Studied `Elocin-Anagram/VRC_World_Location` as a PowerShell log tailer with
  adaptive tail size, generated text files, and a simple HTML browser source.
- Studied `nosjo/obs-vrchat-log-reader` as an OBS Lua script that reads VRChat
  logs directly and switches OBS scenes on room transition events.
- Added a reusable method entry for VRChat world metadata overlay pipelines.

## Follow-Up Queue

1. Build a source-adapter matrix comparing registry, VRCX SQLite, VRChat API,
   log tailing, and OBS-native scripts.
2. Extract a safe browser-source template with stale state, rate-limit state,
   and privacy notes.
3. Compare text-file output with SSE/browser-source output for tiny streamer
   utilities.

## Do Not Spend Time On Yet

- Do not run OBS, VRChat, Electron apps, Blazor apps, or scripts.
- Do not copy credential-based polling or auth-cookie extraction without a
  privacy/security plan.
- Do not treat brittle log-line strings as stable APIs.
