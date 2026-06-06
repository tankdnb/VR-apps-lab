# GitHub Research Wave 254 Plan

Date: 2026-06-06

Theme: VRChat OSC chatbox media, status, and library microtools.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Earlier waves already cover many strong VRChat OSC/chatbox projects. This
wave fills residual gaps with newly found microtools and extracts the common
status-composer boundary.

## Search Families

- VRChat OSC chatbox clients.
- Music/media now-playing senders.
- Biometric/status chatbox bridges.
- Language-specific OSC helper libraries.
- Console/operator microcommands.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `lillithrosepup/Lilypad` | Modular Kotlin/Android chatbox client with OSCQuery, Spotify, lyrics, clock, and avatar presets. | Modular chatbox donor |
| `ohkaelynn/iron-heart-chatbox` | Heart-rate text-file proxy with trends, contextual messages, and tray pause. | Biometric chatbox microtool |
| `MeltyMooncakes/VRChat-OSC-Script` | TypeScript YAML line composer with MPRIS/Windows media and plugin loading. | Extensible status composer |
| `o0F-0oF/VRChat-Spotify-Chatbox` | Python Spotify window-title to chatbox sender. | Minimal media variant |
| `o0F-0oF/VRChat-Spotify-Chatbox-CS` | C# SharpOSC Spotify title sender. | Minimal C# comparison |
| `Mezque/VRC-SpotifyOSC-Py` | Spotipy now-playing/progress/volume chatbox sender. | Spotify API variant |
| `Mezque/VRC-ClockOSC-Py` | Tiny clock-to-chatbox sender. | Cadence microtool |
| `eepyfemboi/ezmusic-desktop-client` | Webview music client with Discord RPC, system stats, and VRChat chatbox. | Scope/caveat reference |
| `ActuallyAbby/VRC-JavaOSC` | Java OSC wrapper for VRChat avatar parameters and listener cache. | Language library donor |
| `Disconnect3301/DisconnectOSC` | C# console feature toggles and chatbox microcommands. | Operator microtool reference |

## Dedupe Notes

`Massivendurchfall/vrchat-osc-spotify`, `MiaBub` controller repos,
`R-VUt/OSC-SRTC`, `nekochanfood`, `Null-K`, `Taitata`, `sillyosc`,
`RiNFC`, `WillW129`, and `Auzlex` were already tracked. Empty repositories
were rejected from the studied shortlist.

## Code-Level Pass Targets

- Data source and credential boundaries.
- Message formatting and templates.
- Send cadence, dedupe, keepalive, and spam risk.
- OSC transport, OSCQuery, and language wrapper APIs.
- Local control surface: tray, console, plugin, GUI, or config.

## Expected Outputs

- Wave 254 landscape synthesis.
- Registry/family entry for residual chatbox/media/status microtools.
- Method catalog entry for bounded chatbox/status composers.
- Follow-up backlog for chatbox privacy and cadence checks.
