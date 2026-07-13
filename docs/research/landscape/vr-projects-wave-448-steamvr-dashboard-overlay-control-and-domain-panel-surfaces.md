# Wave 448: SteamVR dashboard overlay control and domain panel surfaces

## Theme

This wave studies dashboard overlays that turn an external desktop/service state
into an in-headset control panel. The reusable value is in overlay lifecycle,
texture submission, event polling, keyboard/input routing, and domain command
schemas.

## Shortlist

| Project | Status | Family placement |
|---|---|---|
| `haolink/VRCOSCAvatarScaleOverlay` | New study | SteamVR dashboard domain panel |
| `Mon-Ouie/mpris-openvr-overlay` | Deepened existing node | OpenVR media-control dashboard |

## Project notes

### `haolink/VRCOSCAvatarScaleOverlay`

- Interesting idea:
  a SteamVR dashboard overlay that controls VRChat avatar eye height and scale
  through OSC/OSCQuery without leaving VR.
- Code donor value:
  high for Unity RenderTexture-to-OpenVR dashboard plumbing, overlay keyboard
  handling, OSC endpoint registration, avatar metadata cache, and gradual
  logarithmic scaling worker.
- Product reference value:
  strong reference for narrow domain panels where the overlay is a safe control
  cockpit over an external app.
- Architecture pattern:
  Unity UI rendered to a dashboard overlay plus OSC/OSCQuery service boundary
  plus avatar-scale domain model.
- Source evidence:
  README documents SteamVR dashboard mode, OSC requirement, direct eye-height
  setting, current height/scale display, gradual scaling, reset/stop controls,
  and VRChat OSC docs. Source includes `DashboardOverlay`, `OpenVRUtils`,
  `OscManagement`, `AvatarScaler`, `AvatarData`, and `GradualScaleWorker`.
- Reusable core:
  dashboard overlay handle, thumbnail handle, RenderTexture submission,
  overlay mouse scale, keyboard routing, auto-launch manifest, OSC endpoint
  registry, active-entity cache, min/max bounds, gradual worker, and visible
  permission/status labels.
- What not to copy:
  VRChat-specific OSC addresses or avatar-scale assumptions into generic tools.
- Method catalog action:
  contributes to `SteamVR dashboard domain panel`.
- What to inspect next:
  compare with notification, media, and timer overlays to extract a domain-panel
  command schema.

### `Mon-Ouie/mpris-openvr-overlay`

- Interesting idea:
  a tiny Rust/egui OpenVR dashboard that reads MPRIS media-player state and
  sends transport/volume/seek commands from inside SteamVR.
- Code donor value:
  high as a minimal non-Unity reference for OpenVR dashboard creation, egui
  rendering, OpenGL texture submission, and event polling.
- Product reference value:
  strong for Linux-first micro-overlays that expose a single desktop service.
- Architecture pattern:
  desktop service adapter plus immediate-mode UI plus OpenVR texture/event loop.
- Source evidence:
  README describes controlling media players from the SteamVR/OpenVR dashboard.
  Source uses `egui`, `egui_sdl2_gl`, OpenVR texture bounds, player combobox,
  volume/position sliders, transport buttons, `SetOverlayTexture`,
  `SetOverlayTextureBounds`, `PollNextOverlayEvent`, and `WaitFrameSync`.
- Reusable core:
  service list, current target selector, state snapshot, command buttons,
  sliders, icon affordances, texture submission, event-to-UI input mapping, and
  frame pacing.
- What not to copy:
  Linux MPRIS dependency when the target service is Windows/macOS-specific.
- Method catalog action:
  strengthens `SteamVR dashboard domain panel`.
- What to inspect next:
  compare Rust/egui loop to Unity RenderTexture dashboard loop from
  `VRCOSCAvatarScaleOverlay`.

## Synthesis

Dashboard overlays work best when the domain is narrow and the service boundary
is explicit. A reusable domain panel needs:

- overlay lifecycle and manifest/auto-launch state
- render target and texture submission
- event polling and keyboard/input routing
- external service adapter
- domain entity cache
- safe command bounds
- visible connection and permission state

## Follow-up backlog

- Extract a generic dashboard-domain-panel template.
- Compare Unity RenderTexture and Rust/egui rendering loops.
- Add a command safety schema for OSC/media/service control overlays.
