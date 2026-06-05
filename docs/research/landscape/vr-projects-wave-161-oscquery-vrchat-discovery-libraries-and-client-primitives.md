# VR Projects Wave 161: OSCQuery VRChat Discovery Libraries and Client Primitives

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 161 studies the plumbing layer under VRChat OSC utilities: OSCQuery
advertisement, mDNS discovery, avatar parameter fetching, localhost/LAN caveats,
and helper libraries that let multiple OSC apps coexist.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `galister/VrcAdvert` | OSCQuery service-advertisement micro-utilities | Strong minimal reference |
| `minetake01/vrchat_osc` | Rust VRChat OSC/OSCQuery client primitives | Strong crate-level donor |
| `Natsumi-sama/OscQueryLibrary` | C# OSCQuery parameter libraries | Strong C# donor |
| `Raphiiko/oyasumivr_oscquery` | Sidecar-backed OSCQuery discovery | Strong sidecar pattern reference |
| `theepicsnail/vrchat_oscquery` | Python OSCQuery helper/proxy primitives | Strong minimal Python donor |

## `galister/VrcAdvert`

- Interesting idea:
  make any existing OSC app discoverable to VRChat by running a tiny standalone
  advertiser instead of rewriting the app for OSCQuery.
- Code donor value:
  medium-high. The C# CLI is compact and readable.
- Product reference value:
  high for a one-job micro-utility.
- What to inspect next:
  compare endpoint vocabulary with `vrc-oscquery-lib`, `oyasumivr_oscquery`,
  and full OSC apps that advertise custom endpoints.
- Architecture pattern:
  command-line arguments define service name, HTTP port, OSC port, and optional
  tracking endpoint advertisement. It builds a `VRC.OSCQuery` service, starts
  HTTP, advertises OSC and OSCQuery, adds `/avatar/parameters`, optionally adds
  `/tracking/vrsystem/...` endpoints, logs newly discovered services once, and
  stays alive.
- Reusable method:
  standalone OSCQuery advertiser for legacy OSC apps.
- Caveats:
  intentionally minimal, no OSC packet handling, and depends on the official
  VRChat OSCQuery library.

## `minetake01/vrchat_osc`

- Interesting idea:
  package VRChat OSC send/receive, OSCQuery discovery, service registration,
  direct-address fallback, and avatar parameter fetch into one async Rust API.
- Code donor value:
  high. It exposes useful seams for mDNS, OSCQuery HTTP, service handles,
  direct addressing, cleanup, and explicit network caveats.
- Product reference value:
  medium-high for library ergonomics and documentation of localhost/LAN/VPN
  behavior.
- What to inspect next:
  compare direct-address escape hatches and advertised-IP selection with Python
  and C# libraries.
- Architecture pattern:
  Tokio-based client initializes mDNS on a chosen advertised IP, follows
  `_osc._udp.local` and `_oscjson._tcp.local`, caches services, lets callers
  register local OSC/OSCQuery services with root nodes, sends to services by
  name pattern, fetches parameters by service pattern or direct address, and
  keeps registered handles for shutdown/unregister.
- Reusable method:
  async VRChat OSC/OSCQuery client with direct-address fallback and service
  lifecycle handles.
- Caveats:
  multicast/VPN limitations are real, VRChat localhost behavior constrains
  some modes, and Rust async runtime adoption is a product choice.

## `Natsumi-sama/OscQueryLibrary`

- Interesting idea:
  expose VRChat's OSCQuery parameter list as an evented C# library so an app
  can react to avatar parameters without reading local avatar JSON files.
- Code donor value:
  high for C# apps.
- Product reference value:
  high for Quest/LAN-oriented auto-negotiation and parameter update UX.
- What to inspect next:
  compare `ParameterUpdate` event semantics with full VRChat OSC companion apps
  and how they recover after avatar changes.
- Architecture pattern:
  `OscQueryServer` chooses available TCP/UDP ports, starts a local HTTP server,
  advertises `_oscjson._tcp` and `_osc._udp`, ignores its own services, watches
  mDNS answers for `VRChat-Client-*`, fetches root JSON, recursively extracts
  `/avatar/parameters`, captures avatar ID from `/avatar/change`, and emits
  async parameter update events.
- Reusable method:
  C# OSCQuery parameter discovery service with evented avatar parameter cache.
- Caveats:
  VRChat-specific model assumptions, C# ecosystem dependency, and discovery
  behavior still depends on local network conditions.

## `Raphiiko/oyasumivr_oscquery`

- Interesting idea:
  deliberately implement only the OSCQuery subset needed for VRChat and push
  mDNS complexity into a bundled dotnet sidecar.
- Code donor value:
  high for sidecar lifecycle and limited-scope protocol design.
- Product reference value:
  high for apps that want OSCQuery support without taking a full mDNS stack into
  their main language/runtime.
- What to inspect next:
  compare sidecar process watching, stdout address updates, and advertise
  refresh behavior against native Rust and C# approaches.
- Architecture pattern:
  Rust client/server modules initialize with a sidecar executable path, expose
  simple getters for VRChat OSC/OSCQuery address, create an HTTP OSCQuery
  server, register OSC methods, update advertised OSC ports, and ask the
  sidecar to advertise or discover services. The C# sidecar uses
  `VRC.OSCQuery`, watches the parent process, discovers only `VRChat-Client-*`,
  and advertises OSC/OSCQuery service profiles.
- Reusable method:
  sidecar-backed OSCQuery discovery and advertisement for apps whose main
  runtime should stay protocol-light.
- Caveats:
  shipping an extra executable increases packaging burden, current
  implementation is intentionally limited, and it does not send or receive OSC
  packets itself.

## `theepicsnail/vrchat_oscquery`

- Interesting idea:
  reduce VRChat OSCQuery to the two HTTP responses VRChat actually needs and
  provide both asyncio and threaded helper shapes.
- Code donor value:
  high for minimal Python utilities.
- Product reference value:
  high for explaining why multiple OSC apps otherwise fight over port `9001`
  and how a proxy config can advertise several app ports.
- What to inspect next:
  compare its minimal root/HOST_INFO response with official OSCQuery schema
  expectations and future VRChat behavior risk.
- Architecture pattern:
  helper code chooses unused OSC/HTTP ports, creates zeroconf
  `_oscjson._tcp.local` service info, serves `/` and `/?HOST_INFO`, returns
  avatar/tracking root paths plus OSC port, starts either aiohttp plus
  `AsyncIOOSCUDPServer` or `HTTPServer` plus `ThreadingOSCUDPServer`, and ships
  a proxy script that reads JSON app-name-to-port mappings and advertises each.
- Reusable method:
  minimal Python OSCQuery helper and multi-app proxy for VRChat OSC utilities.
- Caveats:
  intentionally VRChat-specific shortcut, questions remain around non-localhost
  hosting, and future OSCQuery requirements could outgrow the minimal response.

## Cross-Project Lessons

- OSCQuery is not just "discovery"; it is app coexistence, endpoint vocabulary,
  avatar parameter introspection, and status recovery.
- A useful OSC utility should choose whether it owns OSC packet handling,
  OSCQuery advertisement, or both.
- Direct-address fallbacks are still needed because mDNS/multicast behavior
  changes across localhost, LAN, VPN, Quest, and nonstandard networks.
- Sidecars are viable when mDNS libraries are awkward in the host runtime, but
  lifecycle and packaging must be explicit.

## Reusable Methods Extracted

- Standalone OSCQuery advertiser for legacy OSC apps.
- Async Rust VRChat OSC/OSCQuery client with direct-address fallback.
- C# OSCQuery parameter discovery and update-event service.
- Sidecar-backed mDNS discovery/advertisement for protocol-light apps.
- Minimal Python OSCQuery root/HOST_INFO helper and multi-app proxy.

## Follow-Up Backlog

- Build an OSCQuery plumbing matrix across official C#, Rust, Python, sidecar,
  and full-app approaches.
- Define a reusable VRChat OSC sidecar discovery checklist.
- Keep network-scope caveats visible whenever a future OSC bridge claims
  Quest/LAN/VPN support.
