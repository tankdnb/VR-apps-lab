# VR Projects Wave 51: Biometric Bridges, Neurofeedback OSC, and Accessory-Control Platforms

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `biometric bridges`, `neurofeedback OSC paths`, and
  `avatar-facing accessory-control platforms`.

## Why this wave exists

`VR-apps-lab` already had wearable-haptics notes and some avatar-driven
automation tools, but an adjacent `biometric and accessory-control` branch was
still not structured clearly enough:

- thin wearable bridges that turn heart-rate or device data into avatar
  parameters or chatbox output;
- richer desktop shells that combine multiple input transports, logs, charts,
  and side outputs;
- plugin or embedded platforms that translate avatar-facing `OSC` into
  accessory behavior with configuration and safety surfaces;
- biosignal systems that flatten more complex parameter trees into a format
  VRChat or avatar tools can actually consume.

This wave exists to make
`biometric bridges, neurofeedback OSC, and accessory-control platforms`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with Pulsoid, heart-rate, brainflow, accessory-control, and
   `OSCQuery` queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `Honzackcz/PulsoidToOSC` | Strong donor for a thin biometric bridge with `OSCQuery` auto-config, chatbox templating, and multi-client fan-out |
| `nullstalgia/iron-heart` | Strong donor for a richer biometric companion platform with logs, charts, and multiple input or output modes |
| `vard88508/vrc-osc-miband-hrm` | Strong donor for a very small browser-plus-node wearable bridge |
| `DASPRiD/vrc-osc-manager` | Strong donor for a plugin-oriented avatar-facing accessory manager with persisted settings and `OSCQuery` services |
| `nullstalgia/OpenShock-ESP-Legacy` | Strong donor for embedded accessory-control firmware with OSC, web config, and safety surfaces |
| `ChilloutCharles/BrainFlowsIntoVRChat` | Strong donor for flattening richer biosignal trees into VRChat-friendly OSC paths |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `samyk/myo-osc` | Historical wearable-input comparison node, but weaker than the frozen shortlist for current biometric, plugin-host, and biosignal lessons |

## Deep-pass notes by project

## `Honzackcz/PulsoidToOSC`

- GitHub:
  [Honzackcz/PulsoidToOSC](https://github.com/Honzackcz/PulsoidToOSC)
- What it is:
  a WPF utility that pulls Pulsoid heart-rate data and fans it out through
  avatar parameters, chatbox messages, and `OSCQuery`-aware discovery.
- Why it matters:
  it is the clearest donor in the repo for
  `thin biometric bridge with OSCQuery auto-config and chatbox templating`.
- Interesting ideas:
  auto-discover local or LAN VRChat clients; send both avatar parameters and
  templated chatbox messages; keep the UI friendly enough for in-VR monitoring
  through ordinary overlay tools.
- Interesting implementation choices:
  `VRCOSC.cs`
  makes the `biometric input -> discovered sender set -> avatar or chatbox OSC`
  flow explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  Pulsoid-specific acquisition narrows the input side, but the bridge and
  discovery model generalize well.
- What to inspect next:
  keep it visible whenever a future branch needs
  `heart-rate bridge with chatbox and parameter fan-out`.

## `nullstalgia/iron-heart`

- GitHub:
  [nullstalgia/iron-heart](https://github.com/nullstalgia/iron-heart)
- What it is:
  a Rust TUI companion that accepts BLE or WebSocket biometrics and can output
  `OSC`, logs, charts, CSV, OBS text, and related side effects.
- Why it matters:
  it is the clearest donor in the repo for
  `rich biometric sidecar platform with multiple inputs, outputs, and operator
  surfaces`.
- Interesting ideas:
  keep monitoring, logging, charts, and output targets in one coherent shell;
  support dummy mode and autostart paths; treat operator visibility as part of
  the product rather than only a background bridge.
- Interesting implementation choices:
  `src/app.rs`
  makes the `input source -> app state -> charts, logs, and output sinks`
  split explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the shell is broader than a single-avatar bridge, but that breadth is also
  its main donor value.
- What to inspect next:
  keep it visible whenever a future branch needs
  `biometric companion shell` rather than a thin relay.

## `vard88508/vrc-osc-miband-hrm`

- GitHub:
  [vard88508/vrc-osc-miband-hrm](https://github.com/vard88508/vrc-osc-miband-hrm)
- What it is:
  a minimal browser-plus-node bridge that reads Mi Band heart-rate data and
  forwards it to VRChat through `OSC`.
- Why it matters:
  it is the clearest donor in the repo for
  `minimal wearable bridge split between WebBluetooth acquisition and local OSC
  forwarding`.
- Interesting ideas:
  let a browser handle device acquisition; keep the local bridge tiny; send
  several different parameter encodings and optional chatbox messages from one
  narrow tool.
- Interesting implementation choices:
  `app.js`
  makes the `WebBluetooth wearable input -> Node bridge -> parameter or chatbox
  OSC` path explicit.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  intentionally narrow scope means the strongest lesson is `small useful
  wearable bridge`, not a broad platform story.
- What to inspect next:
  keep it visible whenever a future branch needs
  `browser plus local bridge` architecture instead of a native desktop shell.

## `DASPRiD/vrc-osc-manager`

- GitHub:
  [DASPRiD/vrc-osc-manager](https://github.com/DASPRiD/vrc-osc-manager)
- What it is:
  a Rust tray application with plugin registration, persisted config, logs, and
  avatar-facing accessory plugins such as PiShock integration.
- Why it matters:
  it is the clearest donor in the repo for
  `plugin-oriented avatar-facing accessory manager with OSCQuery services`.
- Interesting ideas:
  give accessory bridges a plugin system instead of hardcoding one device;
  persist settings and logs in a durable host shell; let each plugin register
  parameters and its own config callbacks.
- Interesting implementation choices:
  `src/main.rs`,
  `src/plugins/mod.rs`, and
  `src/plugins/pishock.rs`
  make the `tray host -> plugin registry -> per-plugin settings and OSC
  behaviors` split explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the strongest lesson is host structure and plugin ownership, not only the
  specific PiShock target.
- What to inspect next:
  keep it visible whenever a future branch needs
  `one accessory host with many plugins`.

## `nullstalgia/OpenShock-ESP-Legacy`

- GitHub:
  [nullstalgia/OpenShock-ESP-Legacy](https://github.com/nullstalgia/OpenShock-ESP-Legacy)
- What it is:
  an ESP32 firmware stack that exposes accessory-control behavior through OSC,
  Wi-Fi onboarding, local config storage, and web configuration surfaces.
- Why it matters:
  it is the clearest donor in the repo for
  `embedded accessory-control firmware with OSC, browser config, and safety
  stop surfaces`.
- Interesting ideas:
  keep onboarding and configuration inside the device; pair `OSC` control with
  an explicit emergency-stop path; manage config and devices as first-class
  firmware concerns rather than pushing everything to a desktop app.
- Interesting implementation choices:
  `src/main.cpp`
  and the repo's `osc`, `web`, and `devices` support layers
  make the `Wi-Fi and config -> OSC control -> queued device actions and safety`
  split explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  embedded-firmware scope narrows immediate reuse, but the accessory-control
  architecture is unusually valuable.
- What to inspect next:
  keep it visible whenever a future branch needs
  `embedded controller with safety surfaces`.

## `ChilloutCharles/BrainFlowsIntoVRChat`

- GitHub:
  [ChilloutCharles/BrainFlowsIntoVRChat](https://github.com/ChilloutCharles/BrainFlowsIntoVRChat)
- What it is:
  a biosignal pipeline that turns BrainFlow-compatible measurements into a
  nested parameter tree and then flattens that tree into VRChat `OSC` paths.
- Why it matters:
  it is the clearest donor in the repo for
  `hierarchical biosignal schema flattened into VRChat-friendly OSC paths`.
- Interesting ideas:
  keep biometrics and signal logic separate from reporting; model parameters as
  a tree instead of a flat bag; flatten only at the reporter boundary so richer
  internal structure is preserved.
- Interesting implementation choices:
  `logic/base_logic.py`,
  `logic/biometrics.py`, and
  `reporters/osc_reporter.py`
  make the `signal logic -> nested parameter tree -> flattened OSC output`
  path explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  research and biosignal assumptions narrow the end-user product surface, but
  the schema design is unusually reusable.
- What to inspect next:
  keep it visible whenever a future branch needs
  `richer measurement trees over flat avatar parameters`.

## Main takeaways from Wave 51

- `Biometric and accessory-control tooling` is now a distinct family, not only a
  side note inside haptics or generic OSC automation.
- The strongest split in this family is:
  - `thin biometric bridge`
  - `rich biometric companion shell`
  - `minimal browser plus local wearable bridge`
  - `plugin-oriented accessory host`
  - `embedded accessory-control firmware`
  - `biosignal schema and reporter pipeline`
- The most reusable lesson is that `avatar-facing signals` can anchor far more
  than haptics:
  - wearable state bridges
  - operator-facing biometrics shells
  - plugin accessory platforms
  - embedded safety-aware controllers
  - neurofeedback or biosignal exporters

## Reusable methods clarified by this wave

- `Thin biometric bridge with OSCQuery auto-config, multi-client fan-out, and chatbox templating`
- `Rich biometric sidecar platform with multiple inputs, charts, logs, and output sinks`
- `Minimal browser-plus-local bridge for wearable telemetry into avatar-facing OSC`
- `Plugin-oriented avatar-facing accessory manager with persisted settings and OSCQuery services`
- `Embedded accessory-control firmware with OSC, browser config, and emergency-stop surfaces`
- `Hierarchical biosignal schema flattened into VRChat-friendly OSC paths`
