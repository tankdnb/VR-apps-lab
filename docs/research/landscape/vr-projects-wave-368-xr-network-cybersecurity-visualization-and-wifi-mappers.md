# Wave 368: XR Network Cybersecurity Visualization and Wi-Fi Mappers

## Scope

This wave studies XR projects that turn network state into spatial objects:
cybersecurity graph visualizers, Wi-Fi signal/security mappers, collaborative
inspection surfaces, filters, probes, and passthrough/anchor-based map markers.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `danieljharris/PARSEC` | Studied | Collaborative VR cybersecurity network visualizer with node/edge graphs, service drill-down, wand probes, presenter state, Photon Fusion networking, filtering, and perspective scaling |
| `Orgzales/Unity-XR-NetworkMapper-Project` | Studied | Quest/Unity AR wireless mapper using Android Wi-Fi APIs, SSID/BSSID/RSSI/security metadata, signal pillars, hidden-network scan notes, passthrough markers, and scan-database HUD concepts |

## Reusable Pattern Extraction

- Pattern candidate: `spatial network security map and probe shell`.
- Problem solved: network/security state is hard to inspect as flat tables; XR can place nodes, links, signal markers, filters, and detail panels around an operator.
- Reusable core: network data adapter, node/service schema, edge schema, signal/security classification, spatial marker factory, filter registry, presenter/authority state, probe tool, drill-down panel, scan history, anchor/origin binding, stale-state cleanup, and privacy/security caveats.
- Source evidence: PARSEC exposes `ConnectionGroup`, `NodeList`, `NodeSpecs`, menu filter classes, `NetworkWand`, `Presenter`, networked player/rig scripts, and scale/move gestures; OX-r TRAIL documents Android Wi-Fi manager calls for SSID/BSSID/RSSI/link speed/frequency/security capability checks, scan result loops, signal-color pillars, hidden SSID handling, scan database, and anchored map behavior.
- Abstraction boundary: network collection should be separate from spatial layout and XR interaction; security scoring should be a replaceable policy, not hardcoded into prefabs.
- What not to copy: credentials, live network assumptions, vendor package trees, demo-only random scan modes as real diagnostics, or security claims without permission and false-positive labels.
- Method catalog action: create a spatial network security map method.

## Project Notes

### `danieljharris/PARSEC`

- Interesting idea: cybersecurity networks are represented as interactable objects with links, service inspection, collaborative presenter control, and wand-based probing.
- Code donor value: high for graph-to-scene boundaries, node/edge components, filter application, presenter authority, menu switching, probe tools, and perspective scaling.
- Product reference value: strong for immersive diagnostics, training, incident-room collaboration, and data graph inspection.
- What to inspect next: data import format, multiuser authority edge cases, security taxonomy maturity, and export/report flow.
- Caveats: dependency-heavy Unity project with VRTK, Meta/Photon assets, and sample content; reuse architecture, not vendored packages or final UX.

### `Orgzales/Unity-XR-NetworkMapper-Project`

- Interesting idea: a Quest headset can become a spatial Wi-Fi survey tool, dropping signal/security pillars at scan positions and summarizing SSID/BSSID history in XR HUDs.
- Code donor value: moderate for AndroidJavaObject Wi-Fi access, scan result parsing, signal/security thresholds, spatial marker lifecycle, and scan history concepts.
- Product reference value: strong micro-utility reference for physical-space diagnostics and network education.
- What to inspect next: actual custom scripts beyond README snippets, permission UX, Android version limits, anchor persistence, and export format.
- Caveats: source tree includes large vendor assets; README has spelling/noise and research-project maturity caveats; Wi-Fi scan APIs are platform-sensitive.

## Product Direction

This wave supports a `spatial diagnostics map` branch: future VR utilities can
visualize networks, device inventories, weak signals, alerts, and service
relationships as filterable spatial objects with drill-down panels and explicit
data-source trust boundaries.

