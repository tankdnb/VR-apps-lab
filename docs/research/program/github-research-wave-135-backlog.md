# GitHub Research Wave 135 Backlog

- Date: `2026-06-05`
- Scope: focused overlay micro-surfaces, dashboard overlays, QR/media/game HUD
  helpers, VRChat OSC overlay tools, and OCR-assisted workflow panels.

## Completed in this wave

- Studied `MetroTS/AdressableOverlaySteamVR` as an early WinForms/OpenVR
  overlay-status sketch with HMD/controller battery, playtime, FPS, and search
  product framing, but limited runtime implementation.
- Studied `haolink/VRCOSCAvatarScaleOverlay` as a Unity SteamVR dashboard
  overlay that renders Unity UI to a dashboard tab, forwards overlay mouse and
  keyboard events, and sends VRChat avatar-scale OSC values.
- Studied `Psychpsyo/VR-QR-Overlay` as a C++ OpenVR QR scanner that reads the
  left-eye compositor mirror texture, downsamples pixels for `quirc`, and shows
  a controller-relative result overlay with haptic feedback.
- Rejected/deprioritized `Rycia/OVR-Deck` because the current clone contains
  no reusable source beyond README/license metadata.
- Studied `ToxicOrca/VR-Music-Remote` as a crop-friendly normal window for
  Desktop+ with Windows media-session metadata, album art, media keys, and
  slow marquee text tuned for VR readability.
- Studied `DavidDriessen/EchoVR-Overlay` as a browser/OBS game telemetry HUD
  with local API polling, state-driven HUD visibility, scoreboard, players,
  stats, score events, and minimap mapping.
- Studied `etiennechabert/ez-wishlist-overlay` as a strong Rust desktop plus
  SteamVR overlay donor with OpenVR overlay session, action bindings, world
  anchoring, OCR feedback card, mirror-texture capture, OCR pipeline, settings,
  persistence, and domain-specific item workflow.

## Reuse candidates

- `ez-wishlist-overlay` is the strongest donor for overlay + OCR + persistence
  + domain data architecture.
- `VRCOSCAvatarScaleOverlay` is the strongest Unity dashboard overlay donor.
- `VR-QR-Overlay` is the clearest mirror-texture to situational overlay micro-
  utility reference.
- `VR-Music-Remote` is a strong product reference for crop-friendly standard
  windows captured into VR overlays.
- `EchoVR-Overlay` is a useful browser-HUD/game-telemetry reference.

## Follow-up backlog

1. Extract an overlay micro-surface checklist: runtime ownership, render path,
   input path, host/capture mode, persistence, and feedback.
2. Compare SteamVR dashboard overlays with window-captured Desktop+ helper
   surfaces.
3. Promote `ez-wishlist-overlay` into a focused reuse-plan if OCR-assisted
   workflow panels become an active branch.
4. Revisit QR and game-HUD overlays only if situational recognition or telemetry
   panels become active.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
