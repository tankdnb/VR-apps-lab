# GitHub Research Wave 153 Backlog

- Date: `2026-06-05`
- Theme: `Protocol-driven overlay bridges, external overlay hosts, and minimal implementation baselines`
- Status: `Completed`

## Completed Pass

1. Search for thin overlay bridges, host-protocol plugins, and minimal OpenVR
   examples.
2. Deduplicate against existing overlay, OSC, and VRChat companion families.
3. Sync source into local-only cache for static reading.
4. Inspect protocol payloads, overlay lifecycle, rendering loops, configuration,
   and caveats.
5. Promote previously queued projects where the code-level pass was sufficient.
6. Integrate results into registry, families, methods, current focus, indexes,
   and follow-up backlog.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `MeroFune/GOpy` | Promoted as OSC gesture-parameter to HMD-relative overlay icon bridge |
| `beareogaming/BD-XSOverlay-notify` | Promoted as external overlay-host WebSocket notification contract example |
| `OrangeJuicy69/VRC-NexusChat` | Added as source-light VRChat OSC companion product reference |
| `kurohuku7/zenn-overlay-tutorial` | Promoted as tutorial-grade OpenVR overlay lifecycle reference |
| `emymin/EmyOverlay` | Promoted as C++ OpenGL/ImGui overlay skeleton |
| `Marlamin/VROverlayTest` | Promoted as C# OpenTK/OpenVR texture submission scratchpad |

## Useful Follow-Up Work

- Draft a small protocol matrix for `plugin -> overlay host` messages across
  XSOverlay, OSC, WebSocket, and local companion surfaces.
- Compare C#/OpenTK, C++/OpenGL/ImGui, Unity, and browser-backed overlay
  baselines as onboarding paths.
- Keep `VRC-NexusChat` as product-reference-only unless public source appears
  or licensing changes.

## Not Pursued In This Wave

- No runtime testing of OpenVR, SteamVR, XSOverlay, BetterDiscord, or VRChat.
- No package installs or local launches.
- No attempt to validate binary releases.
