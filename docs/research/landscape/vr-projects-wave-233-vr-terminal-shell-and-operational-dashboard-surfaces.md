# VR Projects Wave 233: VR Terminal, Shell, and Operational Dashboard Surfaces

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies operational XR surfaces: terminals, shell worlds, network
graphs, cockpit widgets, and local-first dashboards that render command or
data state as spatial panels.

## Why It Matters For `VR-apps-lab`

Many VR utilities need to show logs, commands, diagnostics, network state,
notes, status, or control panels. These projects show how to build such
surfaces without blindly streaming an entire desktop window.

## Project Notes

### `max-gaspers-scott/VR-Terminal`

- Interesting idea:
  stream terminal cells, not pixels, then draw them to a canvas texture inside
  VR.
- Code donor value:
  Rust backend combines Axum, Socket.IO, portable-pty, VTE parsing, watch
  channel snapshots, 40x110 default grid, cell attributes, and row revisions.
  React/A-Frame frontend draws rows to canvas, emits terminal input, supports
  command buffer overlays, special VR movement commands, and terminal texture
  placement.
- Product reference value:
  strongest terminal donor in this wave.
- What to inspect next:
  compare row-revision snapshots against log panels and remote desktop
  alternatives.
- Architecture pattern:
  PTY/VTE state model plus low-bandwidth canvas texture surface.
- Caveats:
  direct shell exposure is sensitive; local access, auth, TLS, and command
  scope need careful product boundaries.

### `coderofsalvation/xrsh`

- Interesting idea:
  a shell can be framed as an XR world, not only a text panel.
- Code donor value:
  A-Frame scene uses ISO terminal attributes, self-container behavior,
  hand/ray/gaze controls, teleport, navigation buttons, and windowing concepts.
- Product reference value:
  strong concept reference for XR-native shell/world metaphors.
- What to inspect next:
  compare shell-world affordances against focused terminal surfaces and
  dashboard panels.
- Architecture pattern:
  shell-as-world substrate with in-scene windows and controls.
- Caveats:
  large bundled/browser artifact surface and concept-heavy donor value; copy
  ideas rather than code wholesale.

### `soren42/visual-traceroute`

- Interesting idea:
  a CLI diagnostic can generate a self-contained WebXR visualization with
  progress reporting.
- Code donor value:
  network discovery feeds layout code using MST, BFS depth, radial placement,
  and force refinement. The web output path uses a child scan process,
  progress log, status polling, done/error sentinels, and result redirect.
- Product reference value:
  useful diagnostic/data visualization reference for future "doctor" tools.
- What to inspect next:
  extract progress/report patterns for OpenXR, SteamVR, and network
  diagnostics.
- Architecture pattern:
  CLI data capture to structured graph to WebXR report artifact.
- Caveats:
  raw ICMP/root scope and network probing policy must be explicit.

### `CanaanMuayad/earthshift-vr`

- Interesting idea:
  operational dashboards can feel like a movable cockpit of modular panels
  rather than a flat menu.
- Code donor value:
  `App.tsx` maps widget definitions to focus/open panel state. `GlassPanel`
  uses hover/active/drag uniforms, pointer capture, and border hit detection
  so border drag repositions while center click interacts. Zustand state
  persists widget data to localStorage.
- Product reference value:
  good UX reference for movable widget panels and dashboard cockpit framing.
- What to inspect next:
  compare border-drag/center-click separation against overlay window managers.
- Architecture pattern:
  modular cockpit with movable glass panels and persisted widget state.
- Caveats:
  wellness/dashboard product framing is specific; reuse panel mechanics, not
  the personal content model.

### `MKTHINGS/webxr-dashboard-meta-quest`

- Interesting idea:
  a Quest dashboard can be built as small local-first A-Frame CRUD panels with
  haptics and autosave.
- Code donor value:
  `main.js` handles WebXR support, enter/exit VR, controller events, haptics,
  unsupported overlay, and autosave. `ui-components.js` programmatically builds
  panels/cards/navigation. `data-models.js` gives notes, bookmarks, photos,
  folders, search, JSON import/export, and localStorage persistence.
- Product reference value:
  good micro-dashboard donor for notes/bookmarks/photos and local persistence.
- What to inspect next:
  compare local-first dashboard models against overlay note/media microtools.
- Architecture pattern:
  programmatic A-Frame dashboard with local storage models.
- Caveats:
  demo-level persistence and no multi-user/security story.

## Reusable Pattern Extraction

- Pattern candidate:
  operational XR surface from command/grid/data state.
- Problem solved:
  VR utilities need command and diagnostic surfaces, but full desktop capture is
  often too broad, insecure, or bandwidth-heavy.
- Reusable core:
  keep operational state explicit, render a bounded spatial panel, route input
  through a named command/keymap model, persist small dashboard state locally,
  expose progress/status, and document security scope.
- Source evidence:
  `VR-Terminal`, `xrsh`, `visual-traceroute`, `earthshift-vr`, and
  `webxr-dashboard-meta-quest`.
- Abstraction boundary:
  separate privileged command execution or data collection from panel
  rendering and in-headset manipulation.
- What not to copy:
  public shell exposure, root network probing without scope, giant bundled
  shell artifacts, or personal dashboard assumptions as reusable product logic.
- Method catalog action:
  add a method entry for operational XR surfaces.

## Follow-Up Gaps

- Build a terminal/log/dashboard security checklist.
- Compare character-grid, canvas texture, WebRTC remote, browser panel, and
  generated report approaches.
- Extract a diagnostic progress/report panel pattern for future runtime doctor
  tools.
