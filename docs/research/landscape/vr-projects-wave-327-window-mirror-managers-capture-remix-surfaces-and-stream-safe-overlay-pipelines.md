# Wave 327 - Window Mirror Managers, Capture/Remix Surfaces, and Stream-Safe Overlay Pipelines

This wave studies overlay-adjacent surface management outside the headset:
mirroring a live game window onto a streamable virtual display, and a
source-light capture/remix product concept.

No external project was run, installed, or launched.

## Scope

The wave was bounded to:

- window mirroring and virtual-display worker patterns;
- launch/close ownership around streamed game sessions;
- watchdog and health/repair surfaces for long-lived helpers;
- source-light capture/remix concepts involving VR, overlays, and metrics.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `aguirretim/apollo-mirror-manager` | Stream-safe DWM window mirror manager | Studied | Strong donor for persistent DWM thumbnail mirror worker, virtual-display detection, target handoff files, debounced teardown, watchdog/PID fallback, Apollo tile wiring, ownership markers, and repair GUI |
| `PhotonIO/RemixPlayer` | Source-light capture/remix channel concept | Source-light product reference | README-only concept for recording audio, video, VR, overlays, replay files, graphics captures, FPS, and performance metrics as remixable channels |

## Code-Level Findings

### `aguirretim/apollo-mirror-manager`

- Interesting idea:
  a stream helper can mirror only a game window onto Apollo's virtual display
  while leaving the real desktop and physical monitor untouched.
- Code donor value:
  very high for Windows surface utilities. `mirror-watcher.ps1` runs in the
  interactive session, creates one persistent borderless WinForms surface,
  uses DWM thumbnail registration/update/unregister calls, reads
  `mirror-target.txt`, finds a virtual display and target process HWND,
  re-points the thumbnail when handles change, and debounces teardown with
  `GraceTicks`. `launch-app.ps1` writes target process names, avoids relaunching
  already-running apps, and drops ownership markers only for Apollo-launched
  sessions. `close-app.ps1` closes only owned sessions. `watchdog-mirror.ps1`
  uses command-line matching plus a PID-file fallback. `mirror-manager.ps1`
  provides health checks, startup shortcut repair, scheduled watchdog repair,
  Apollo service restart, Steam library scanning, process-name guessing, tile
  add/remove, cover-art download, and `apps.json` backups.
- Product reference value:
  very high for desktop-in-VR, reference-window, stream-safe overlay, and
  virtual-display utility concepts.
- What to inspect next:
  DWM thumbnail limitations, DPI/multi-monitor behavior, input forwarding,
  security around Apollo config writes, and whether this can inform VR
  dashboard/window-reference tools.
- Architecture pattern:
  `interactive-session mirror worker + target handoff file + launch/close
  ownership scripts + watchdog + manager GUI`.
- Reusable method:
  stream-safe mirror worker with ownership markers and health repair.
- UX pattern:
  health tab with repair action, add Steam game tab, add other app tab,
  manage tiles tab, and clear explanation of close-on-quit ownership.
- Constraints / caveats:
  PowerShell/WinForms/DWM is Windows-specific; exclusive fullscreen is not
  mirrorable; antivirus and elevated/non-elevated boundaries are operational
  concerns.
- Why it matters for `VR-apps-lab`:
  it is a strong donor for any future reference-window or overlay-surface tool
  that needs a robust desktop mirror worker instead of a naive capture loop.

### `PhotonIO/RemixPlayer`

- Interesting idea:
  capture can be framed as multiple remixable channels: audio, video, VR,
  overlays, replay files, graphics-call captures, FPS, and performance
  metrics.
- Code donor value:
  low at this pass; the repo contains only README/license material.
- Product reference value:
  medium as product framing for channelized session recording and viewer-side
  remix.
- What to inspect next:
  source, schema, player prototype, synchronization model, and how VR/overlay
  channels are timestamped.
- Caveat:
  keep as source-light concept only until implementation appears.

## Reusable Pattern Extraction

- Pattern candidate:
  stream-safe window mirror worker with launch ownership and repair loop.
- Problem solved:
  a useful streamed or referenced surface often needs to mirror a live window
  without moving the real window, hijacking the desktop, or killing apps the
  user started manually.
- Reusable core:
  persistent mirror surface, DWM or runtime-specific mirror backend, virtual
  display detection, target handoff, process/window resolver, debounced
  teardown, ownership marker, close policy, watchdog, health UI, config backup,
  and tile/source manager.
- Source evidence:
  `aguirretim/apollo-mirror-manager`, with `PhotonIO/RemixPlayer` as
  source-light channelized-capture framing.
- Abstraction boundary:
  keep mirror worker, launch ownership, sink/tile registration, watchdog, and
  manager UI separate.
- What not to copy:
  exclusive-fullscreen assumptions, force-closing user-owned sessions,
  duplicate watcher processes, or app-config edits without backups.
- Method catalog action:
  add a stream-safe mirror worker method.

## Follow-Up Gaps

- Compare DWM mirror workers with desktop-in-VR and virtual-display projects.
- Treat capture/remix channels as a future session-recording research thread.
- Explore whether ownership-marker close policy is useful for VR launchers and
  runtime helpers.
