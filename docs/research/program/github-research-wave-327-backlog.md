# GitHub Research Wave 327 Backlog - Window Mirror Managers, Capture/Remix Surfaces, and Stream-Safe Overlay Pipelines

## Executed Scope

- Searched and deduplicated mirror, capture, and overlay-remix projects.
- Froze a two-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted DWM thumbnail mirroring, persistent WinForms mirror surface,
  target-file handoff, virtual-display detection, debounced teardown, process
  re-pointing, PID-file watchdog fallback, Apollo `apps.json` tile wiring,
  cover-art/tile manager, owned-session close markers, health/repair GUI, and
  channelized recording/remix product framing.

## Studied Projects

- `aguirretim/apollo-mirror-manager`
- `PhotonIO/RemixPlayer`

## Backlog Findings

- Reuse `apollo-mirror-manager` as a desktop/window mirror architecture donor
  for any future VR reference-window or streamed-surface utility.
- Treat `RemixPlayer` as product framing only until source appears beyond the
  README.
- Compare persistent mirror workers with existing virtual display and
  desktop-in-VR tools.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog captures stream-safe mirror worker boundaries.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
