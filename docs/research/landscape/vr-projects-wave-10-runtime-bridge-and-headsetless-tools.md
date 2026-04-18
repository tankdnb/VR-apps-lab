# VR Projects Wave 10: Runtime Bridges, Headsetless Workflows, and SteamVR Hygiene

- Date: `2026-04-18`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet in `VR.app`, focusing on runtime implementations, vendor-shell
  redirectors, headsetless workflows, mixed-runtime bridges, and SteamVR
  environment helpers.

## Why this wave exists

The repository already had strong coverage of:

- large utility suites;
- OpenXR runtime switchers;
- classic overlay hosts;
- tracker bridges and accessibility overlays.

What was still missing was a stronger layer of:

- `runtime implementation references`, not only runtime switchers;
- `vendor-shell replacement` and process-supervision tools;
- `headsetless/no-HMD development` workflows;
- `mixed tracking and controller bridge drivers`;
- `capture bridges` from SteamVR into creator workflows;
- `runtime hygiene` tools that patch one painful behavior really well.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with focused queries;
2. deduplicate against the registry;
3. freeze a shortlist;
4. sync only that shortlist into `.research-sources/github/`;
5. inspect code and structure;
6. promote the findings into the catalog, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `mbucchia/VirtualDesktop-OpenXR` | Full OpenXR runtime implementation and registration reference |
| `BnuuySolutions/OculusKiller` | Vendor-shell replacement and SteamVR auto-redirect helper |
| `ChristophHaag/SteamVR-OpenHMD` | OpenHMD bridge into SteamVR/OpenVR |
| `username223/SteamVRNoHeadset` | Minimal but useful null-driver and no-HMD workflow reference |
| `baffler/OBS-OpenVR-Input-Plugin` | SteamVR mirror texture capture into OBS |
| `Hotrian/OpenVRTwitchChat` | Twitch-specific overlay micro-product with threaded service layer |
| `mm0zct/Oculus_Touch_Steam_Link` | Mixed-VR controller and sensor bridge driver |
| `SlimeVR/SlimeVR-OpenVR-Driver` | Modern tracker bridge driver with external service transport |
| `n1ckfg/ViveTrackerExample` | Tracker-without-HMD workflow and minimal Unity helper |
| `BnuuySolutions/SteamVRLinuxFixes` | Vulkan layer and compositor patch utility for Linux SteamVR |
| `oleuzop/VirtualSteamVRDriver` | Configurable virtual HMD for development without real hardware |
| `craftyinsomniac/WFOVFix` | Guided SteamVR config patcher for narrow headset issues |

## Deep-pass notes by project

## `mbucchia/VirtualDesktop-OpenXR`

- GitHub:
  [mbucchia/VirtualDesktop-OpenXR](https://github.com/mbucchia/VirtualDesktop-OpenXR)
- What it is:
  a full Windows OpenXR runtime implementation for Virtual Desktop.
- Why it matters:
  most public `runtime tools` are only switchers or inspectors. This project
  shows the structure of a real runtime with registration, extension tables,
  session handling, and submission-time graphics processing.
- Interesting ideas:
  registry-based runtime installation; live settings refresh through registry
  watchers; headless-session support; runtime-owned upscaling and sharpening in
  a precompositor path.
- Interesting implementation choices:
  native runtime class exposes a broad OpenXR surface; backend support spans
  D3D11, D3D12, Vulkan, and OpenGL; precompositor code saves/restores graphics
  state while applying GPU-side processing before submission.
- Code donor value:
  very high for runtime-intelligence and diagnostics research.
- Product reference value:
  high for future `OpenXR Doctor` thinking.
- Architecture reference value:
  very high.
- Caveats:
  this is much larger and more runtime-centric than a typical utility project.
- What to inspect next:
  runtime install/uninstall lifecycle, extension negotiation paths, and how its
  settings/watcher model could translate into doctor-style tooling.

## `BnuuySolutions/OculusKiller`

- GitHub:
  [BnuuySolutions/OculusKiller](https://github.com/BnuuySolutions/OculusKiller)
- What it is:
  a desktop replacement executable that hijacks Oculus Dash launch flow and
  redirects the user into SteamVR.
- Why it matters:
  this is a clear public example of `vendor shell replacement` as a utility
  category.
- Interesting ideas:
  use the original executable name to replace a vendor shell; discover SteamVR
  through `openvrpaths.vrpath`; supervise both Oculus- and SteamVR-side
  processes; clean up runaway runtime behavior on exit.
- Interesting implementation choices:
  intentionally small C# desktop executable; process polling for `vrmonitor`
  and `OculusClient`; explicit process cleanup around `OVRServer*`.
- Code donor value:
  medium-high for runtime redirection and process supervision.
- Product reference value:
  high for narrow but powerful environment helpers.
- Architecture reference value:
  high.
- Caveats:
  strongly tied to one vendor ecosystem and one workflow.
- What to inspect next:
  error handling, fallback paths, and how its process-supervision model compares
  with other runtime hygiene helpers.

## `ChristophHaag/SteamVR-OpenHMD`

- GitHub:
  [ChristophHaag/SteamVR-OpenHMD](https://github.com/ChristophHaag/SteamVR-OpenHMD)
- What it is:
  a SteamVR/OpenVR driver that wraps OpenHMD-supported hardware into SteamVR.
- Why it matters:
  it shows a very practical path for turning an open hardware/runtime stack
  into a SteamVR-compatible bridge.
- Interesting ideas:
  lightweight file-based device-role selection; one driver used as a hardware
  compatibility bridge instead of a new end-user product.
- Interesting implementation choices:
  Valve-sample-style driver bootstrap; OpenHMD-backed device access; plain text
  config for role selection such as HMD display, HMD tracker, and controller
  slots.
- Code donor value:
  high for custom hardware and compatibility-driver research.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  controller render-model support and polish are limited.
- What to inspect next:
  device role assignment, Linux-first assumptions, and whether similar config
  ideas could simplify other bridge drivers.

## `username223/SteamVRNoHeadset`

- GitHub:
  [username223/SteamVRNoHeadset](https://github.com/username223/SteamVRNoHeadset)
- What it is:
  a tiny repository documenting how to run SteamVR without a real headset.
- Why it matters:
  even without much code, it is a strong `operational recipe` and a useful
  product/reference node for headsetless workflows.
- Interesting ideas:
  null-driver enablement; `requireHmd=false`; `activateMultipleDrivers=true`;
  persistence through user-side `steamvr.vrsettings`.
- Interesting implementation choices:
  concise and task-focused documentation instead of a heavyweight utility.
- Code donor value:
  low.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium for workflow design.
- Caveats:
  mostly documentation, not reusable source code.
- What to inspect next:
  whether `VR.app` should keep a dedicated headsetless-workflow playbook and
  compare this with richer virtual-driver approaches.

## `baffler/OBS-OpenVR-Input-Plugin`

- GitHub:
  [baffler/OBS-OpenVR-Input-Plugin](https://github.com/baffler/OBS-OpenVR-Input-Plugin)
- What it is:
  an OBS input plugin that captures SteamVR mirror imagery directly from
  OpenVR.
- Why it matters:
  it adds an excellent `creator-side capture bridge` pattern to the repository.
- Interesting ideas:
  OpenVR initialized as a background app; mirror texture acquired from the
  compositor; shared D3D11 resource handed to an external desktop tool;
  optional per-eye cropping.
- Interesting implementation choices:
  OBS module architecture; D3D11 texture sharing via shared handles; explicit
  lifecycle around compositor access and quit events.
- Code donor value:
  high for capture and streaming tooling.
- Product reference value:
  high for creator workflows.
- Architecture reference value:
  high.
- Caveats:
  tied to Windows, OBS, and D3D11.
- What to inspect next:
  texture sharing edge cases, performance implications, and whether the same
  approach can support other desktop capture workflows.

## `Hotrian/OpenVRTwitchChat`

- GitHub:
  [Hotrian/OpenVRTwitchChat](https://github.com/Hotrian/OpenVRTwitchChat)
- What it is:
  a Unity/OpenVR Twitch chat overlay built on a custom HOTK-style overlay
  layer.
- Why it matters:
  it is a good example of a focused overlay product with a real network service
  behind it.
- Interesting ideas:
  threaded Twitch IRC transport; chat-specific overlay UI; profile persistence;
  emote/material recycling; attachment to HMD, world, or controllers.
- Interesting implementation choices:
  custom tracked-device manager; change-driven overlay updates; background TCP
  queues for IRC; legacy-save migration support.
- Code donor value:
  medium-high for service-backed overlay utilities.
- Product reference value:
  high for chat, status, or communication overlays.
- Architecture reference value:
  high.
- Caveats:
  tied to older Unity and older SteamVR assumptions.
- What to inspect next:
  overlay-state persistence, input handling, and how its overlay/service split
  compares with newer lightweight overlays.

## `mm0zct/Oculus_Touch_Steam_Link`

- GitHub:
  [mm0zct/Oculus_Touch_Steam_Link](https://github.com/mm0zct/Oculus_Touch_Steam_Link)
- What it is:
  a SteamVR driver that lets Oculus Touch devices act as SteamVR controllers,
  trackers, and sensors even with non-Oculus HMD setups.
- Why it matters:
  this is one of the clearest public references for `mixed-VR hardware bridge`
  design.
- Interesting ideas:
  one hardware kit emitted as several SteamVR device classes; optional
  controller-versus-tracker modes; helper process keeps Oculus runtime alive;
  device properties and skeleton paths adapt to the detected Oculus hardware.
- Interesting implementation choices:
  multiple device-driver classes under one provider; custom haptics and input
  component setup; render-model selection tied to vendor hardware type; sensor
  devices exposed as tracking references.
- Code donor value:
  very high for hardware bridge and mixed-tracking research.
- Product reference value:
  high.
- Architecture reference value:
  very high.
- Caveats:
  fairly specialized and tightly tied to Oculus runtime behavior.
- What to inspect next:
  communication paths between driver and helper, tracker-emulation mode, and
  world-transform handling.

## `SlimeVR/SlimeVR-OpenVR-Driver`

- GitHub:
  [SlimeVR/SlimeVR-OpenVR-Driver](https://github.com/SlimeVR/SlimeVR-OpenVR-Driver)
- What it is:
  a modern C++ OpenVR driver that bridges external SlimeVR services into
  SteamVR trackers.
- Why it matters:
  it is one of the strongest current references for `driver + external bridge
  service` architecture.
- Interesting ideas:
  named-pipe bridge; reconnect loop; version handshake; tracker role updates;
  HMD state mirrored into the bridge; universe/chaperone-aware transforms.
- Interesting implementation choices:
  `libuv`-style asynchronous bridge; protobuf transport; singleton driver
  factory; background pose-request thread; dynamic tracker property updates.
- Code donor value:
  very high.
- Product reference value:
  high for tracker-bridge ecosystems.
- Architecture reference value:
  very high.
- Caveats:
  more infrastructure-heavy than smaller driver examples.
- What to inspect next:
  bridge protocol details, reconnection behavior, and how its role/state model
  compares with WebSocket-based tracker drivers.

## `n1ckfg/ViveTrackerExample`

- GitHub:
  [n1ckfg/ViveTrackerExample](https://github.com/n1ckfg/ViveTrackerExample)
- What it is:
  a small guide and sample script for using Vive Tracker data without a real
  headset.
- Why it matters:
  it reinforces the `headsetless tracker workflow` family from a very practical
  angle.
- Interesting ideas:
  null-driver setup recipe; tracker-only development path; simple chase-target
  smoothing helper in Unity.
- Interesting implementation choices:
  tiny Unity helper script that lerps toward tracked pose state.
- Code donor value:
  low-medium.
- Product reference value:
  medium.
- Architecture reference value:
  medium.
- Caveats:
  mostly a setup recipe, not a full utility.
- What to inspect next:
  how it compares with richer virtual-driver approaches and whether its Unity
  helper pattern deserves a small snippet collection in `VR.app`.

## `BnuuySolutions/SteamVRLinuxFixes`

- GitHub:
  [BnuuySolutions/SteamVRLinuxFixes](https://github.com/BnuuySolutions/SteamVRLinuxFixes)
- What it is:
  a Vulkan layer and patch utility that fixes narrow compositor/runtime issues
  in SteamVR on Linux.
- Why it matters:
  it is a strong example of a `runtime hygiene` tool that surgically fixes one
  painful platform path instead of becoming a huge general-purpose suite.
- Interesting ideas:
  layer-based extension augmentation; loader-chain manipulation; optional
  function hooking into `vrcompositor`; environment-variable disable switch.
- Interesting implementation choices:
  Vulkan layer manifest; dispatch tables; symbol lookup into compositor;
  `funchook`-based binary patching.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high for narrow environment helpers.
- Architecture reference value:
  high.
- Caveats:
  Linux-only and technically invasive.
- What to inspect next:
  loader-chain mutation details, safety fallbacks, and whether similar
  environment-fix utilities belong in a distinct `runtime hygiene` subfamily.

## `oleuzop/VirtualSteamVRDriver`

- GitHub:
  [oleuzop/VirtualSteamVRDriver](https://github.com/oleuzop/VirtualSteamVRDriver)
- What it is:
  a virtual SteamVR HMD driver intended for development without a physical
  headset.
- Why it matters:
  it expands the `headsetless development` family from a config recipe into a
  real virtual device implementation.
- Interesting ideas:
  multiple emulated headset profiles; quality-tier-based render targets;
  keyboard and mouse control of the virtual HMD; sample-based simplehmd
  extension.
- Interesting implementation choices:
  device-provider based on Valve samples; config-driven headset targeting;
  preset render resolutions for Quest, WMR, Pimax, and other device classes.
- Code donor value:
  high for virtual-device and test-harness work.
- Product reference value:
  medium-high for developer tooling.
- Architecture reference value:
  high.
- Caveats:
  development-oriented rather than user-facing.
- What to inspect next:
  profile model, event handling, and how it can be compared against
  `OpenXR-Simulator` and null-driver workflows.

## `craftyinsomniac/WFOVFix`

- GitHub:
  [craftyinsomniac/WFOVFix](https://github.com/craftyinsomniac/WFOVFix)
- What it is:
  a tiny desktop utility that patches SteamVR settings for wide-FOV headsets.
- Why it matters:
  it is a great example of a very narrow `desktop-side fix tool` with obvious
  user value.
- Interesting ideas:
  discover SteamVR config through `vrPathReg.exe`; patch only the relevant JSON
  values; prompt the user before making changes; handle read-only settings.
- Interesting implementation choices:
  registry lookup of Steam install; vendor helper invocation instead of
  hard-coding config paths; focused JSON mutation around render-target and
  supersampling keys.
- Code donor value:
  medium.
- Product reference value:
  high for config-patcher micro-tools.
- Architecture reference value:
  medium-high.
- Caveats:
  extremely narrow in scope.
- What to inspect next:
  whether `VR.app` should keep a sub-collection of config patchers and
  environment fixers as a distinct product family.

## Cross-cutting patterns extracted in this wave

## 1. `Full runtime implementation is its own research source`

Wave 10 confirms that `runtime tools` should not be studied only through
switchers and explorers. A full runtime like `VirtualDesktop-OpenXR` exposes:

- registration flow;
- extension negotiation;
- session and graphics binding surfaces;
- settings lifecycle;
- precompositor processing opportunities.

## 2. `Vendor shell replacement is a legitimate utility category`

`OculusKiller` shows that some VR utilities deliver value by changing launch
and supervision behavior around an existing vendor stack rather than by drawing
something in-headset.

## 3. `Headsetless workflows form a real family, not scattered tips`

`SteamVRNoHeadset`, `ViveTrackerExample`, and `VirtualSteamVRDriver` together
show a clear family:

- null-driver recipes;
- tracker-only setups;
- virtual HMD drivers;
- desktop dev harnesses without physical headsets.

## 4. `Mixed-VR hardware bridges are one of the strongest donor categories`

`SteamVR-OpenHMD`, `Oculus_Touch_Steam_Link`, and
`SlimeVR-OpenVR-Driver` all reinforce the idea that `external system -> bridge
driver -> SteamVR devices` is one of the richest design spaces in the entire
repository.

## 5. `Capture bridges matter as much as overlays`

`OBS-OpenVR-Input-Plugin` highlights a useful category that is easy to miss if
the repository looks only at in-headset tools:

- mirror-surface capture;
- creator-side workflow bridges;
- external desktop apps consuming SteamVR outputs.

## 6. `Runtime hygiene tools deserve their own lane`

`SteamVRLinuxFixes`, `WFOVFix`, and `OculusKiller` are not overlay products,
but they solve painful real-world VR problems with focused engineering.

## Most useful additions to `VR.app` from this wave

- stronger support for `headsetless development` as a first-class research
  direction;
- better coverage of `runtime hygiene` and `vendor-shell redirect` tools;
- better `mixed-VR bridge driver` examples;
- stronger representation of `creator-side capture bridges`;
- clearer understanding of `full runtime implementations` as donors for future
  doctor and diagnostics tooling.

## Follow-up candidates from the same search wave

## `alexander-clarke/openvr-room-mapping`

- GitHub:
  [alexander-clarke/openvr-room-mapping](https://github.com/alexander-clarke/openvr-room-mapping)
- Current status in `VR.app`:
  `Not studied deeply`
- Why it matters:
  it may add a useful room-scan or spatial-mapping angle to the
  passthrough/reality/reconstruction branch.
- What to inspect next:
  mapping method, output model, and whether it belongs closer to calibration,
  passthrough, or environment-capture families.

## Recommended next move after Wave 10

The next high-value deep-pass order now looks like:

1. compare `headsetless and no-HMD` workflows as a dedicated family;
2. compare `mixed-VR controller and tracker bridge` drivers;
3. compare `runtime hygiene` tools as a narrow desktop-helper family;
4. deep pass `alexander-clarke/openvr-room-mapping`;
5. connect runtime-implementation references back into the `OpenXR Doctor`
   concept.
