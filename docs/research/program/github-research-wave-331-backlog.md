# GitHub Research Wave 331 Backlog - Overlay Surface Proxies, Dashboard Notifications, Hand Redirection, and Tracker Recording Utilities

## Executed Scope

- Searched and deduplicated overlay surface, dashboard, hand redirection, and
  tracker-recording utility projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted HWND/region/DWM proxy modes, chroma-key preview windows,
  no-focus/click-through overlay behavior, Qt Quick to OpenVR dashboard texture
  submission, socket-auth notification rooms, hand-redirection class hierarchy,
  edit-mode visualization, movement logging, tracker serial mapping, threaded
  SteamVR pose recording, and replay scaffold caveats.

## Studied Projects

- `Eldon27232/KugouLyricsMirror`
- `ZephyrVR/tempest-overlay`
- `AndreZenner/hand-redirection-toolkit`
- `Avdbergnmf/SteamVR-Utils`

## Backlog Findings

- Treat `KugouLyricsMirror` as a strong desktop-to-VR capture/proxy donor.
- Treat `tempest-overlay` as an old but useful dashboard overlay architecture
  reference.
- Treat `hand-redirection-toolkit` and `SteamVR-Utils` as reusable interaction
  and experiment-data method donors rather than end-user utilities.
- Add a method around proxy surfaces and interaction-data utilities.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog captures proxy-surface and interaction-data boundaries.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
