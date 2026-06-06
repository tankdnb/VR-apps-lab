# Wave 256 - VMC Protocol Transport, OpenXR Motion, and Bridge Adapters

This wave studies small VMC/OpenXR bridge projects as reusable references for
moving avatar or tracker pose data across runtime, OSC, and network transport
boundaries.

## Scope

The wave was bounded to projects that can teach one of these patterns:

- OpenXR pose sampling without a full visible app shell.
- VMC protocol forwarding with explicit client identity.
- Operator UI for selecting transport, destination, and message-monitor state.
- Lightweight VMC library or wrapper references that may need a follow-up
  source check elsewhere.

No external project was run, built, installed, or launched. Source was read
statically from the local study cache.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `LukasLichten/simple-xr2vmc` | VMC transport and OpenXR motion bridge | Studied | Minimal headless OpenXR pose poller intended to feed VMC |
| `sotanmochi/VMCTransportBridge` | VMC protocol transport layer | Studied | Strong donor for local VMC message model to network transport and re-emission |
| `sotanmochi/VMCTransportHub` | VMC operator surface | Studied | Product reference for a desktop transport hub, monitor, and destination UI |
| `vivi90/python-vmc` | VMC wrapper follow-up | Source-light | GitHub pointer to moved Python VMC work, useful only as a follow-up node |

## Code-Level Findings

### `LukasLichten/simple-xr2vmc`

- Interesting idea:
  use OpenXR headless session setup and action-space polling as a tiny
  runtime-side motion capture source.
- Code donor value:
  medium donor for OpenXR loader entry, extension gates, headless session
  creation, action-set binding, event polling, predicted-time pose reads, and
  graceful Ctrl+C session exit.
- Product reference value:
  useful as a smallest-possible `OpenXR pose source -> external protocol`
  experiment, not as a finished VMC bridge.
- What to inspect next:
  whether a current fork or successor re-enabled VMC send output, added tracker
  bindings, or added calibration/transform mapping.
- Architecture pattern:
  `OpenXR instance -> headless session -> action set -> located spaces ->
  external sender`.
- Reusable method:
  keep pose acquisition independent from protocol publishing so VMC, OSC,
  WebSocket, or logging outputs can be swapped.
- Caveats:
  VMC send code is commented out, controller paths are minimal, headless and
  Vive tracker extensions are required, and no calibration/identity layer is
  present.

### `sotanmochi/VMCTransportBridge`

- Interesting idea:
  extend local VMC messages over gRPC or Photon by wrapping typed VMC payloads
  with a network client id.
- Code donor value:
  strong donor for `Publisher` and `Subscriber` split, typed VMC message
  handling, MessagePack wrapping, transport interface boundaries, and
  destination-side re-emission.
- Product reference value:
  proves that VMC can be treated as a local protocol with a separate
  identity-preserving transport layer.
- What to inspect next:
  security/auth model, latency behavior, reconnect behavior, and how projects
  consume `/VMC/Ext/.../Transported` messages in practice.
- Architecture pattern:
  `local VMC message -> typed object -> transport envelope -> remote unwrap ->
  normal VMC or transported VMC output`.
- Reusable method:
  use an explicit envelope around local motion messages whenever data crosses
  machines, so identity and routing are not hidden in UDP source addresses.
- Caveats:
  Unity/gRPC dependency weight is high, trust boundaries are not foregrounded,
  and source contains small polish issues such as naming typos.

### `sotanmochi/VMCTransportHub`

- Interesting idea:
  wrap VMC transport configuration in a desktop operator surface with
  transport type, connection status, destination address, client-id filters,
  and message monitor views.
- Code donor value:
  medium donor for WPF/Blazor settings surfaces, connection start/stop flow,
  appsettings-based configuration, and subscriber message-monitor UI.
- Product reference value:
  strong reference for how a non-technical user might operate a VMC relay
  instead of editing scripts.
- What to inspect next:
  whether the UI can be decomposed into a generic `protocol bridge operator`
  shell for VMC, OSC, OSCQuery, WebSocket, and tracker feeds.
- Architecture pattern:
  `transport adapter -> publisher/subscriber services -> UI state -> monitor
  table/log`.
- Reusable method:
  bridge utilities need an operator plane, not only a protocol library.
- Caveats:
  Windows/WPF-specific, server setup is nontrivial, and authentication is not a
  visible first-class feature.

### `vivi90/python-vmc`

- Interesting idea:
  a Python wrapper for VMC is useful for fast research scripts and bridge
  prototypes.
- Code donor value:
  low from GitHub, because the repository is source-light and points to a moved
  Codeberg location.
- Product reference value:
  useful as evidence that scripting-language VMC wrappers are worth tracking.
- What to inspect next:
  fetch the Codeberg source or find maintained Python VMC alternatives before
  treating this as a donor.
- Caveats:
  do not count this as studied implementation evidence until the active source
  is inspected.

## Reusable Pattern Extraction

- Pattern candidate:
  identity-preserving motion protocol bridge.
- Problem solved:
  local pose protocols such as VMC are easy to emit on one machine but harder
  to route, monitor, and distinguish across machines or avatars.
- Reusable core:
  pose source, local protocol parser, typed message model, client identity,
  transport envelope, destination routing, monitor UI, reconnect/error state,
  and calibration/transform layer.
- Source evidence:
  `simple-xr2vmc` shows a minimal OpenXR pose-source boundary;
  `VMCTransportBridge` shows a transport envelope and subscriber/publisher
  split; `VMCTransportHub` shows an operator surface for the bridge.
- Abstraction boundary:
  pose acquisition must not know whether output is local UDP VMC, transported
  VMC, OSC, WebSocket, or a debug log.
- What not to copy:
  incomplete send code, unchecked trust boundaries, fixed device assumptions,
  and transport implementations without explicit reconnect and permission
  states.
- Method catalog action:
  create a new method for VMC/motion protocol bridge boundaries.

## Family Placement

This wave creates a new family around VMC transport and identity-preserving
motion bridges. It overlaps with tracker bridge, OSC bridge, and OpenXR
headless-helper families, but its center of gravity is the protocol boundary:
local motion messages become network-addressable, observable, and routable.

## Backlog Impact

- Compare VMC, VRM, OSC tracker, and OSCQuery approaches as pose transport
  surfaces.
- Find maintained Python/Rust/C# VMC senders with active examples.
- Add a future bridge matrix covering auth, client identity, transform
  calibration, latency, and monitor UI.
