# GitHub Research Wave 161 Plan

- Date: `2026-06-05`
- Theme: `OSCQuery VRChat discovery libraries and client primitives`
- Scope: minimal service advertisers, OSCQuery libraries, mDNS sidecars,
  Python/Rust/C# client primitives, and multi-OSC-app coexistence patterns.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Many prior VRChat OSC waves studied full applications. Wave 161 studies the
smaller reusable layer underneath them: how a utility advertises OSC endpoints,
discovers VRChat services, fetches avatar parameters, handles localhost/LAN
limitations, and lets multiple OSC tools coexist without hardcoding one port.

## Search Families

- VRChat OSCQuery libraries
- mDNS and zeroconf service advertisers
- OSC app discovery helpers
- avatar parameter query clients
- multi-OSC-application proxy utilities
- Rust, C#, and Python OSCQuery primitives

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `galister/VrcAdvert` | Minimal OSCQuery advertiser for existing OSC apps | OSCQuery service-advertisement micro-utilities |
| `minetake01/vrchat_osc` | Rust crate for OSC send/receive, OSCQuery discovery, and parameter fetch | Rust VRChat OSC/OSCQuery client primitives |
| `Natsumi-sama/OscQueryLibrary` | C# library for VRChat parameter discovery and auto-negotiation | C# OSCQuery parameter libraries |
| `Raphiiko/oyasumivr_oscquery` | Limited Rust OSCQuery implementation with a dotnet mDNS sidecar | Sidecar-backed OSCQuery discovery |
| `theepicsnail/vrchat_oscquery` | Python asyncio/threaded OSCQuery helper and proxy setup | Python OSCQuery helper/proxy primitives |

## Dedupe Notes

- `vrchat-community/vrc-oscquery-lib` was already studied in Wave 49 and
  remains canonical comparison context.
- Large VRChat OSC apps such as `VRCOSC`, `TTS-Voice-Wizard`, `advosc`, and
  `XOSC` were not duplicated; this pass focuses on plumbing libraries and
  micro-helpers.

## Code-Level Pass Targets

- service name sanitization and endpoint advertisement;
- OSC and OSCQuery mDNS service registration;
- HTTP `/?HOST_INFO` and root node response shapes;
- avatar parameter fetching and update events;
- sidecar lifecycle and process-watching patterns;
- localhost, LAN, VPN, multicast, and Quest limitations;
- examples that show foreground/background and async/threaded usage.

## Expected Outputs

- New Wave 161 landscape synthesis.
- Registry/family updates for OSCQuery plumbing rather than app-level OSC
  utilities.
- Methods around minimal advertisers, typed OSCQuery clients, sidecar-backed
  discovery, and multi-app proxy helpers.
