# GitHub Research Wave 153 Plan

- Date: `2026-06-05`
- Theme: `Protocol-driven overlay bridges, external overlay hosts, and minimal implementation baselines`
- Scope: projects where another process, plugin, OSC source, tutorial, or small
  render loop drives an overlay instead of building a full VR application.

## Why This Wave Exists

`VR-apps-lab` already has many overlay examples, but future reusable utilities
need sharper distinctions between:

- an overlay renderer;
- an overlay host;
- a protocol bridge that sends data to a host;
- a tutorial or scratchpad that teaches the minimum lifecycle.

Wave 153 studies projects that make those boundaries visible.

## Search Families

- SteamVR/OpenVR overlay tutorials
- XSOverlay and external overlay-host protocol plugins
- OSC-to-overlay bridges
- OpenGL/ImGui overlay render loops
- C# OpenVR scratchpads
- VRChat companion overlay/OSC utilities

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `MeroFune/GOpy` | OSC avatar gesture parameters rendered as SteamVR overlay icons | OSC-to-overlay bridges |
| `beareogaming/BD-XSOverlay-notify` | BetterDiscord plugin pushes notification payloads to XSOverlay WebSocket API | External overlay host protocol bridges |
| `OrangeJuicy69/VRC-NexusChat` | Source-light but useful VRChat OSC companion product framing | VRChat OSC companion references |
| `kurohuku7/zenn-overlay-tutorial` | Tutorial-first overlay lifecycle and cleanup path | Overlay onboarding references |
| `emymin/EmyOverlay` | Small C++ OpenGL/ImGui OpenVR overlay skeleton | Minimal overlay render baselines |
| `Marlamin/VROverlayTest` | Tiny C#/OpenTK/OpenVR texture submission scratchpad | Minimal overlay render baselines |

## Dedupe Notes

- `MeroFune/GOpy`, `BD-XSOverlay-notify`, `zenn-overlay-tutorial`,
  `EmyOverlay`, and `VROverlayTest` were already present as backlog or
  not-yet-studied nodes, so this wave promotes or clarifies them.
- `OrangeJuicy69/VRC-NexusChat` is source-light and proprietary, so it is added
  only as a product reference, not a code donor.
- This wave does not duplicate earlier large overlay hosts; it focuses on
  thinner bridges and baselines.

## Code-Level Pass Targets

- OSC or WebSocket payload shape.
- Queueing, reconnect, and filtering policy.
- Overlay lifecycle and cleanup.
- Texture submission path.
- HMD-relative transform and input mapping.
- Whether a project is a real code donor or product-reference-only.

## Expected Outputs

- New Wave 153 landscape synthesis.
- Registry and family promotion for old backlog nodes.
- Methods around OSC-to-overlay icons, external overlay-host notification
  contracts, tutorial-grade overlay lifecycle, and OpenGL/ImGui overlay
  texture submission.
