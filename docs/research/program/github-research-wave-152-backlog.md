# GitHub Research Wave 152 Backlog

- Date: `2026-06-05`
- Theme: `Glanceable telemetry, simulator panels, and situational VR micro-overlays`
- Status: `Completed`

## Completed Pass

1. Search for narrow VR overlay, simulator panel, hardware telemetry, and
   in-host chat utility projects.
2. Deduplicate against the existing registry and family notes.
3. Freeze a bounded shortlist instead of expanding into generic desktop HUDs.
4. Sync shortlisted sources into local-only cache for reading only.
5. Inspect README files, structure, entry points, polling loops, window/overlay
   update paths, configuration, and UX framing.
6. Extract reusable methods and caveats.
7. Integrate results into registry, families, methods, current focus, landscape
   docs, and navigation indexes.
8. Clean local study cache after integration.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `Nexz/turncountervr` | Promoted from not-yet-studied to cable-awareness micro-overlay reference |
| `Denwa/vive-wireless-info-overlay` | Clarified as source-light wireless-temperature product reference |
| `yydsok520/gpu-vram-monitor` | Added as hardware telemetry and control-loop overlay donor |
| `JMmayranpaa/RacingManager` | Added as simulator shared-memory telemetry and topmost-widget donor |
| `ironsled/vr-twitch-chat-ui` | Added as VR-aware in-host chat panel and readability-profile donor |

## Useful Follow-Up Work

- Compare `turncountervr` with prior cable/comfort and metrics overlays to
  design a generic pose-derived comfort signal layer.
- Convert the `gpu-vram-monitor` pattern into a VR-safe telemetry source that
  separates hardware polling from presentation.
- Compare simulator telemetry ingestion across `RacingManager`, earlier racing
  overlays, and motion-cueing sidecars.
- Extract a general `VR readability profile` checklist for chat, captions,
  kneeboards, and simulator panels.

## Not Pursued In This Wave

- No builds, installs, launches, or device checks.
- No attempt to validate any binary release.
- No broad desktop overlay sweep; the wave stayed limited to VR-relevant
  micro-surfaces and telemetry patterns.
