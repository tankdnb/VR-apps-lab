# GitHub Research Wave 233 Backlog

Date: 2026-06-06

Theme: VR terminal, shell, and operational dashboard surfaces.

## Completed In This Wave

- Studied `max-gaspers-scott/VR-Terminal` as a Rust Axum/Socketioxide/PTV/VTE
  terminal backend with watch-channel snapshots, cell attributes, row
  revisions, frontend command buffer, home-row keymap, canvas texture, and
  A-Frame terminal plane.
- Studied `coderofsalvation/xrsh` as a shell-as-XR-world reference with
  A-Frame scene, ISO-backed terminal, self-container pattern, hand/ray/gaze
  controls, windowing concept, and hosted shell product framing.
- Studied `soren42/visual-traceroute` as an operational graph pipeline with
  network discovery, structured output formats, MST/BFS/force layout, built-in
  progress server, polling status page, and WebXR/Three visualization export.
- Studied `CanaanMuayad/earthshift-vr` as a modular VR cockpit with widget
  registry, glass panels, border-drag versus center-click separation, shared
  locomotion store, and localStorage-backed dashboard state.
- Studied `MKTHINGS/webxr-dashboard-meta-quest` as a Quest/A-Frame dashboard
  with programmatic UI manager, local storage models for notes/bookmarks/photos,
  haptic feedback, unsupported-device overlay, VR enter/exit handling, and
  autosave.
- Added a reusable method entry for operational XR surfaces that render command
  or data state as spatial panels rather than arbitrary pixel streams.

## Follow-Up Queue

1. Compare terminal rendering options: character grid, canvas texture, remote
   desktop, browser iframe, and shell-world models.
2. Add a security checklist for terminals and operational dashboards: local
   access, auth, TLS, command exposure, scan scope, and secrets.
3. Compare panel input strategies: keymap overlay, ray-click, border drag,
   focus/click separation, and controller-only repositioning.
4. Extract a "diagnostic progress surface" pattern from `visual-traceroute`.
5. Decide whether a small VR command/log panel prototype should be a
   `VR-apps-lab` spike.

## Do Not Spend Time On Yet

- Do not expose a real shell, network scan, or remote control surface from this
  repository.
- Do not copy bundled shell/window assets from `xrsh` directly.
- Do not treat personal dashboard content as product requirements.
