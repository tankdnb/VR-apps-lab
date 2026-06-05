# GitHub Research Wave 152 Plan

- Date: `2026-06-05`
- Theme: `Glanceable telemetry, simulator panels, and situational VR micro-overlays`
- Scope: focused VR or VR-adjacent utility surfaces that show one narrow piece
  of state: cable rotation, adapter temperature, GPU/VRAM telemetry, simulator
  telemetry, or in-game chat.

## Why This Wave Exists

Recent waves strengthened broad media, WebXR, analytics, streaming, and social
framework branches. Wave 152 intentionally returns to smaller utility surfaces:
the kind of narrow overlays that make VR work safer, more comfortable, or less
context-switch-heavy without becoming a full desktop shell.

## Search Families

- OpenVR micro-overlays
- simulator telemetry panels
- Twitch/chat panels inside VR hosts
- hardware status and thermal overlays
- topmost utility windows that can be captured into VR
- focused situational HUDs

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Nexz/turncountervr` | Cable-rotation comfort overlay with a very small state model | Situational VR micro-overlays |
| `Denwa/vive-wireless-info-overlay` | Source-light but clear wireless-adapter temperature overlay product reference | Device-status micro-overlays |
| `yydsok520/gpu-vram-monitor` | Hardware sensor overlay with fan and power-limit control | Hardware telemetry utility surfaces |
| `JMmayranpaa/RacingManager` | iRacing shared-memory telemetry plus desktop overlay windows and app launcher | Simulator telemetry panels |
| `ironsled/vr-twitch-chat-ui` | MSFS VR-aware in-game Twitch chat panel with readability profiles | In-host communication panels |

## Dedupe Notes

- `Nexz/turncountervr` and `Denwa/vive-wireless-info-overlay` were already in
  the backlog as not-yet-studied nodes, so this wave promotes them instead of
  duplicating them.
- The GPU and simulator projects are not native SteamVR/OpenXR overlays, but
  their sensor, telemetry, and topmost-window models are useful when paired with
  existing captured-window or desktop-in-VR families.
- `ironsled/vr-twitch-chat-ui` overlaps with prior audience-chat waves, but its
  MSFS custom-panel host and VR readability profile make it distinct enough for
  a dedicated utility-pattern note.

## Code-Level Pass Targets

- Entry points and polling loops.
- Overlay/window lifecycle and update cadence.
- Sensor or simulator data ingress.
- VR-specific readability and placement assumptions.
- Configuration, persistence, and safety behavior.
- Caveats that make a project only a product reference rather than a code donor.

## Expected Outputs

- New Wave 152 landscape synthesis.
- Registry updates for the studied shortlist.
- Family update for glanceable telemetry and situational micro-overlays.
- Methods for pose-derived comfort overlays, hardware telemetry overlays,
  simulator shared-memory panels, and VR-aware chat panels.
- Follow-up cleanup in `not-yet-studied-deeply.md` where old candidates were
  promoted or downgraded to source-light references.
