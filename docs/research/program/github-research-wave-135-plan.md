# GitHub Research Wave 135 Plan

- Date: `2026-06-05`
- Goal: study focused overlay micro-surfaces and situational in-headset
  workflow helpers: dashboard overlays, QR scanners, media control windows,
  game HUDs, and OCR-assisted wishlist panels.

## Why this wave exists

Small overlays often teach better product lessons than huge shells. This wave
collects compact utilities where the value is one strong surface: a dashboard
tab, a QR result card, a crop-friendly media controller, a game telemetry HUD,
or an OCR-backed VR checklist.

## Search scope

Primary search directions:

- SteamVR dashboard overlays;
- OpenVR QR overlays;
- VR media remote windows;
- OBS/browser game overlays;
- OCR-assisted VR workflow panels;
- VRChat OSC overlay micro-tools.

## Frozen shortlist for code-level study

- `MetroTS/AdressableOverlaySteamVR`
- `haolink/VRCOSCAvatarScaleOverlay`
- `Psychpsyo/VR-QR-Overlay`
- `Rycia/OVR-Deck`
- `ToxicOrca/VR-Music-Remote`
- `DavidDriessen/EchoVR-Overlay`
- `etiennechabert/ez-wishlist-overlay`

## Execution model

### Step 1: Search and deduplicate

- search by focused overlay and micro-surface families;
- deduplicate against Desktop+, OVR Toolkit, XSOverlay, VRChat OSC, and media
  overlay waves.

### Step 2: Freeze the shortlist

- include native OpenVR/OpenVR-like overlays, Unity dashboard overlays,
  standard-window helpers intended for Desktop+, OBS/browser HUDs, and one
  strong OCR-assisted overlay donor.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- dashboard overlay creation and render-texture submission;
- overlay event/mouse/keyboard forwarding;
- QR capture from mirror textures;
- window-captured media control UX;
- API polling/game-state HUD flow;
- OCR, persistence, action bindings, overlay rendering, and feedback cards.

### Step 5: Promote findings into repository structure

Update Wave 135 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when focused overlay micro-surface patterns are documented
with donor/reference value, caveats, family placement, and reusable methods.
