# VR Projects Wave 14: Tracker Ingress, OSC Egress, and Role-Binding Utilities

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `tracker-ingress drivers`, `OSC/input export`, `SteamVR role reuse`, and
  `direct-to-consumer bridge utilities`.

## Why this wave exists

The repository already had strong coverage of:

- virtual tracker drivers and OSC-driven tracking platforms;
- vision-based tracking sidecars and camera-driven body tracking;
- classic OpenVR/OpenXR overlays, diagnostics, and runtime helpers;
- custom-device plumbing and no-HMD workflow research.

What was still missing was a denser layer of:

- `generic bridge drivers` that expose an ingress endpoint for external
  programs instead of baking the whole tracking stack into the driver;
- `thin outward exporters` that take OpenVR device state and publish it over
  OSC or other lightweight protocols;
- `engine-side role reuse` where an app pulls OpenVR poses directly and maps
  them to SteamVR tracker bindings without needing a full headset workflow;
- `direct consumer bridges` where vendor or SteamVR state goes straight to
  VRChat-style OSC without creating a new driver first.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with focused family-level queries;
2. deduplicate against the registry;
3. freeze a shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, overlap, and variant decisions;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `ju1ce/Simple-OpenVR-Bridge-Driver` | Strong named-pipe ingress donor for external programs that need to create or update SteamVR trackers without writing a full driver stack |
| `3NekoSystem/OpenVR-Tracker-Websocket-Driver` | Lighter JSON/WebSocket fork in the same tracker-ingress family |
| `v0xie/OpenVR-Tracker-Websocket-Driver` | Richer local web-service fork that pushes the same family toward browser and HTTPS helpers |
| `BarakChamo/OpenVR-OSC` | Minimal pose-to-OSC exporter worth understanding as a thin outbound bridge |
| `choyai/SteamVRTrackerUtility` | Tiny but useful role/serial helper in no-HMD and deterministic binding workflows |
| `biosmanager/unity-openvr-tracking` | Engine-side OpenVR adapter that reuses SteamVR tracker-role bindings inside Unity |
| `JLChnToZ/axis-vrc-osc-bridge` | Standalone vendor-tracker-to-VRChat OSC bridge that bypasses SteamVR driver installation |
| `I5UCC/VRCThumbParamsOSC` | Mature SteamVR and tracker-state export tool with configuration UX and OSCQuery support |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `TheNexusAvenger/Enigma` | Interesting consumer-side tracker-role export into Roblox, but it sits outside the repo's current core utility families and deserves a later dedicated comparison pass |
| `ThatGuyThimo/leapmotion-osc` | Useful OSC hand/finger export signal, but it fits better as a follow-up to Wave 13 hand-tracking research than as part of this wave's tracker-ingress core |

## Deep-pass notes by project

## `ju1ce/Simple-OpenVR-Bridge-Driver`

- GitHub:
  [ju1ce/Simple-OpenVR-Bridge-Driver](https://github.com/ju1ce/Simple-OpenVR-Bridge-Driver)
- What it is:
  a fork of the `Simple-OpenVR-Driver-Tutorial` that turns the sample into a
  `named-pipe bridge driver` for external programs, with additional
  hip-locomotion experimentation.
- Why it matters:
  it is one of the clearest public references for `external program -> SteamVR
  driver ingress` using an intentionally lightweight command transport rather
  than a monolithic sensor-specific driver.
- Interesting ideas:
  let any language talk to the driver through `ApriltagPipeIn`; expose commands
  for `addtracker`, `updatepose`, `getdevicepose`, `synctime`, and `settings`;
  keep example clients in both C++ and C#; support direct HMD/controller pose
  readback so a sidecar can align itself to live VR state.
- Interesting implementation choices:
  `VRDriver.cpp` starts `ipcServer.init("ApriltagPipeIn")` and a dedicated
  `PipeThread`; `TrackerDevice.cpp` stores time-stamped pose history and does
  smoothing plus simple prediction instead of blindly applying the latest
  sample; example code uses `synctime` and `getdevicepose` to align external
  updates to driver timing.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  the command protocol is string-based and sample-derived rather than strongly
  typed; product framing is still developer-oriented; the main branch remains a
  bridge skeleton, not a polished end-user tool.
- What to inspect next:
  compare it directly against the John-Dean WebSocket line as one
  `named pipe vs WebSocket ingress` design study, and inspect the
  `hip-locomotion` branch separately.

## `3NekoSystem/OpenVR-Tracker-Websocket-Driver`

- GitHub:
  [3NekoSystem/OpenVR-Tracker-Websocket-Driver](https://github.com/3NekoSystem/OpenVR-Tracker-Websocket-Driver)
- What it is:
  a simplified `WebSocket` fork of the tracker-driver family that accepts JSON
  tracker updates on `ws://127.0.0.1:8082`.
- Why it matters:
  it shows the lighter end of the `browser-friendly tracker ingress` space,
  where the main value is easy JSON transport rather than a larger local
  service shell.
- Interesting ideas:
  treat the tracker `id` as the lifecycle key; auto-create trackers when a new
  `id` appears; accept either one JSON object or an array of updates; reply
  with current `vr_trackers` plus an `echo` field.
- Interesting implementation choices:
  the whole transport and driver glue lives mostly in one `VRDriver.cpp`;
  `Boost.Beast` handles the WebSocket server; `nlohmann/json` parses incoming
  arrays and objects; the driver keeps a simple shared `echo` channel and JSON
  response surface alongside tracker updates.
- Code donor value:
  medium.
- Product reference value:
  medium.
- Architecture reference value:
  medium.
- Caveats:
  it is still fundamentally a fork in a family already represented by a
  stronger mainline; its implementation is monolithic; it mostly simplifies the
  broader WebSocket line instead of opening a new architecture branch.
- What to inspect next:
  revisit only if this lighter `8082` JSON-first branch becomes the
  better-maintained family baseline.

## `v0xie/OpenVR-Tracker-Websocket-Driver`

- GitHub:
  [v0xie/OpenVR-Tracker-Websocket-Driver](https://github.com/v0xie/OpenVR-Tracker-Websocket-Driver)
- What it is:
  a richer WebSocket-driver variant that mirrors the `John-Dean` line and adds
  a bundled local web page plus multiple `HTTPS` side channels.
- Why it matters:
  it demonstrates the far end of treating a driver as a `local web service`,
  not just a tracker sink.
- Interesting ideas:
  combine `ws://127.0.0.1:12100` tracker ingress with an HTTP page on `12101`;
  echo back current tracked-device state; surface local IP addresses; expose
  extra HTTPS endpoints that can move data through self-signed local channels.
- Interesting implementation choices:
  a very large `VRDriver.cpp` owns WebSocket, HTTP, HTTPS, SSL certificate
  setup, local IP discovery, and message staging; the repo ships web assets in
  `resources/webserver`; multiple threaded listener functions handle different
  side-channel responsibilities.
- Code donor value:
  low-medium.
- Product reference value:
  medium.
- Architecture reference value:
  medium.
- Caveats:
  this is effectively a `variant-only` branch rather than a fresh core donor;
  most of the complexity is concentrated in one file; the extra HTTPS surfaces
  add operational overhead without clearly proving a reusable mainstream
  pattern.
- What to inspect next:
  revisit only if these extra browser and HTTPS surfaces become a clearly
  reused local-service workflow in later repos.

## `BarakChamo/OpenVR-OSC`

- GitHub:
  [BarakChamo/OpenVR-OSC](https://github.com/BarakChamo/OpenVR-OSC)
- What it is:
  a compact Python utility that exports `OpenVR` device poses to `OSC`.
- Why it matters:
  it is one of the smallest public references in the repo for `OpenVR pose ->
  OSC egress`, which makes it a good donor for thin bridge tools.
- Interesting ideas:
  use one OSC bundle per poll tick; keep per-device OSC addresses like
  `/tracker/0`; let users filter tracked device classes from the CLI; make the
  whole bridge understandable in a single source file.
- Interesting implementation choices:
  `openvr-osc.py` builds on `triad_openvr` device discovery, `pythonosc`
  bundle/message builders, and a live console table for the current pose feed.
- Code donor value:
  medium.
- Product reference value:
  medium.
- Architecture reference value:
  low-medium.
- Caveats:
  the current implementation still ignores the advertised `--freq` and
  `--mode` flags: it hardcodes `interval = 1/250` and always calls
  `get_pose_euler()` in the send loop.
- What to inspect next:
  whether a cleaner maintained fork exists, how to add stable unique device IDs,
  and whether quaternion output ever became real in a successor.

## `choyai/SteamVRTrackerUtility`

- GitHub:
  [choyai/SteamVRTrackerUtility](https://github.com/choyai/SteamVRTrackerUtility)
- What it is:
  a tiny Unity/OpenVR snippet for reading a device serial from a tracked-device
  index.
- Why it matters:
  although small, it captures a very practical point: `serial-based identity`
  is what makes no-HMD binding and role reuse flows deterministic.
- Interesting ideas:
  keep tracker identity anchored to SteamVR serial numbers instead of unstable
  runtime indices.
- Interesting implementation choices:
  `GetDeviceIDTest.cs` calls
  `OpenVR.System.GetStringTrackedDeviceProperty(...Prop_SerialNumber_String...)`
  and exposes the result as a reusable helper.
- Code donor value:
  low.
- Product reference value:
  low-medium.
- Architecture reference value:
  low.
- Caveats:
  this is not a full utility app; it is a narrow snippet and should be treated
  as a micro-reference, not a full product donor.
- What to inspect next:
  pair it with fuller tracker-role editors or no-HMD workflows when the repo
  later deepens `engine-side role reuse`.

## `biosmanager/unity-openvr-tracking`

- GitHub:
  [biosmanager/unity-openvr-tracking](https://github.com/biosmanager/unity-openvr-tracking)
- What it is:
  a Unity package that reads OpenVR poses directly, without requiring an HMD to
  be present in the usual end-user sense, and maps devices to scene objects by
  custom bindings or SteamVR tracker roles.
- Why it matters:
  it is the clearest public reference in the repo so far for
  `engine-side OpenVR tracking with SteamVR role reuse`.
- Interesting ideas:
  support `requireHmd=false` workflows; keep custom bindings and
  SteamVR-tracker-role bindings side by side; add optional pose prediction and
  render-model handling; avoid dependency on the full SteamVR Unity plugin.
- Interesting implementation choices:
  `OVRT_Manager` initializes OpenVR as `VRApplication_Other`, temporarily
  starts the runtime if needed, parses `openvrpaths.vrpath`, then reads
  `steamvr.vrsettings`; `UpdatePoses()` dispatches `NewBoundPose` for both
  custom serial bindings and SteamVR role bindings; `OVRT_BoundTrackedObject`
  applies those poses straight to scene transforms.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  it is Unity-specific and OpenVR-specific; it still assumes external tracker
  role assignment or manual config editing; the repo references a separate
  tracker-role utility that is not bundled here.
- What to inspect next:
  compare it with no-HMD workflow helpers and identify whether there is a
  comparable OpenXR-side engine adapter pattern.

## `JLChnToZ/axis-vrc-osc-bridge`

- GitHub:
  [JLChnToZ/axis-vrc-osc-bridge](https://github.com/JLChnToZ/axis-vrc-osc-bridge)
- What it is:
  a standalone Unity utility that reads `AXIS` body-tracker data and sends it
  directly to `VRChat OSC`, without depending on the SteamVR driver route.
- Why it matters:
  it is a strong product reference for `vendor tracker -> direct consumer app`
  bridges, especially for Quest or remote-network workflows.
- Interesting ideas:
  bypass SteamVR entirely; support another computer or Quest client over the
  network; let users toggle channels, scale body width/height, manually sync
  head orientation, and calibrate trackers from one utility shell.
- Interesting implementation choices:
  `AxisVRChatOscBridge.cs` maps humanoid bones to `/tracking/trackers/*`
  addresses; `UIController.cs` wraps connect/disconnect, countdown-based
  calibration, and tracker-channel toggles; `PersistentUIUtils.cs` stores
  control values in `PlayerPrefs`.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  it is still a `proof of concept`; it is AXIS-specific and VRChat-specific;
  donor value is strongest in transport and UI behavior, not in a reusable
  generic body-tracking stack.
- What to inspect next:
  compare it against other vendor-direct bridges and decide which parts could
  become a generic `direct-to-OSC bridge shell`.

## `I5UCC/VRCThumbParamsOSC`

- GitHub:
  [I5UCC/VRCThumbParamsOSC](https://github.com/I5UCC/VRCThumbParamsOSC)
- What it is:
  a configurable desktop utility that exports `SteamVR` controller actions,
  tracker states, and `XInput` signals to `VRChat avatar parameters` over OSC.
- Why it matters:
  it is the strongest public reference in this wave for
  `SteamVR input/tracker state -> direct OSC consumer`, with enough settings
  UX to feel like a real reusable product pattern.
- Interesting ideas:
  unify SteamVR controller input, tracker-role state, and XInput in one app;
  allow per-parameter send modes like `send on change`, `send on positive`, or
  `always`; support floating/toggle semantics and binary packing for float
  parameters; auto-register with SteamVR startup on first launch.
- Interesting implementation choices:
  `ovr.py` initializes OpenVR as a utility app, loads the action manifest, and
  registers the SteamVR app manifest; `osc.py` starts an OSC server and
  `OSCQuery` service, waits for VRChat, and resends parameters on avatar
  changes; `config.json` defines a large declarative parameter map; the
  repository also ships a WPF `Thumbparams_Configurator`.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the parameter model is deeply VRChat-centric; the config surface is large and
  domain-specific; the strongest reusable value is the architecture and UX
  model, not a direct copy of the full parameter list.
- What to inspect next:
  compare it with `axis-vrc-osc-bridge` and `OpenVR-OSC` to decide what a more
  generic `SteamVR-to-OSC export host` inside `VR-apps-lab` would look like.

## Cross-project takeaways

- This family now clearly splits into four sub-branches:
  `driver ingress`, `pose/input OSC export`, `engine-side role reuse`, and
  `direct consumer bridges`.
- `Simple-OpenVR-Bridge-Driver` is the clearest donor for
  `external program -> SteamVR tracker ingress`; the WebSocket forks are best
  understood as family variants around the same core idea, not as equal
  top-level donors.
- `unity-openvr-tracking` and `VRCThumbParamsOSC` are the best product and
  architecture references in this wave because they each turn a narrow idea
  into a reusable host shell.
- `axis-vrc-osc-bridge` shows that not every tracking utility needs to end in a
  SteamVR driver; for some ecosystems the cleaner path is
  `vendor data -> OSC consumer`.
- `OpenVR-OSC` remains useful precisely because it is thin, but the code-level
  pass shows why small utilities still need honest notes: the CLI promises are
  ahead of the real implementation.
