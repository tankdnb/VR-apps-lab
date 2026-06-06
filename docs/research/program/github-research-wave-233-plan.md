# GitHub Research Wave 233 Plan

Date: 2026-06-06

Theme: VR terminal, shell, and operational dashboard surfaces.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

`VR-apps-lab` has many overlay and dashboard references, but fewer examples of
operational text/state surfaces: terminals, shell worlds, network maps,
cockpit widgets, and local-first dashboards. This wave studies how command or
data state becomes an XR surface without pixel-streaming an entire desktop.

## Search Families

- VR terminal and shell surfaces.
- Command grid or text-grid streaming.
- XR operational dashboards.
- Network/data visualization in WebXR.
- Local-first dashboard panels and widget cockpit shells.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `max-gaspers-scott/VR-Terminal` | Character-grid terminal over Socket.IO, PTY/VTE backend, and canvas texture plane. | VR terminal donor |
| `coderofsalvation/xrsh` | Shell-as-XR-world concept using A-Frame, ISO terminal, windows, and in-world navigation. | Shell/world product reference |
| `soren42/visual-traceroute` | CLI network scan to WebXR/Three graph with progress server and self-contained outputs. | Operational data visualization |
| `CanaanMuayad/earthshift-vr` | Modular VR cockpit with draggable glass panels, widgets, locomotion, and persistent state. | Widget cockpit surface |
| `MKTHINGS/webxr-dashboard-meta-quest` | A-Frame local-first dashboard with notes, bookmarks, photos, haptics, persistence, and auto-save. | Lightweight VR dashboard |

## Dedupe Notes

Desktop-in-VR, remote desktop, overlay browser, and WebXR data visualization
projects are already tracked. This shortlist focuses on terminal/grid/data
surfaces that keep operational state explicit instead of streaming arbitrary
pixels.

## Code-Level Pass Targets

- PTY/VTE, terminal grid, row revision, and canvas texture flows.
- Shell world and in-world navigation concept boundaries.
- CLI scan to WebXR graph export and progress reporting.
- Panel movement, widget routing, and persistent state.
- Local storage, CRUD models, haptics, and autosave in VR dashboards.

## Expected Outputs

- Wave 233 landscape synthesis.
- Registry/family entries for operational XR surfaces.
- Method catalog entry for command/grid/data state as spatial panels.
- Follow-up backlog for terminal/dashboard security and input models.
