# Not Yet Studied Deeply

- Date: `2026-04-11`
- Goal: keep a prioritized list of repositories that either:
  - are not yet represented in `VR.app`;
  - are only lightly covered;
  - or belong to a high-value overlap family that deserves a deeper code-level
    pass.

## How to use this file

For each project, track four things:

- `interesting idea`
- `code donor value`
- `product reference value`
- `what to inspect next`

This keeps the backlog aligned with the existing wave documents and makes it
easier to decide whether the next pass should focus on architecture, UX, or
implementation details.

## Priority batch A

These are the strongest next candidates.

| Project | Current status in `VR.app` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `BnuuySolutions/PSVR2Toolkit` | Partially studied | Vendor-enhancement layer over an official headset stack | Medium | High | IPC layout, developer API surface, driver patch boundaries |
| `MuffinTastic/steamvr-exconfig` | Partially studied | Pre-launch SteamVR config utility with narrow focus | Medium | High | SteamVR settings model, disabled overlay/driver flow, restart assumptions |
| `John-Dean/OpenVR-Tracker-Websocket-Driver` | Partially studied | WebSocket-native tracker spawning and pose exchange | High | High | Message protocol, tracker lifecycle, read/write API, driver/service split |
| `surplex-io/OpenVR-Driver` | Partially studied | Alternative evolution of websocket tracker driver architecture | High | Medium | Delta versus upstream, protocol changes, maintainability improvements |
| `gpsnmeajp/VirtualMotionTracker` | Partially studied | External pose and skeletal input into virtual SteamVR trackers | High | High | Driver-manager boundary, OSC transport, skeletal input path |
| `LucidVR/opengloves-driver` | Partially studied | Hand-specific custom device integration with multiple transports | High | Medium | Serial/named-pipe/Bluetooth transport handling, device abstraction |
| `RedHawk989/EyeTrackVR-OpenVR-Calibration-Overlay` | Partially studied | Overlay-first calibration UX for eye tracking | Medium | High | 9-point flow, calibration state machine, input/feedback UX |
| `DaniXmir/GlassVr` | Partially studied | Bridge non-VR glasses hardware into SteamVR via emulation | High | High | Headset/controller/tracker emulation boundaries, hand-tracking path |
| `krazysh01/VirtualDesktop-OpenVR-Trackers` | Partially studied | Turn body-state data from another ecosystem into trackers | High | Medium | Data format, tracker role mapping, assumptions about upstream source |
| `terminal29/Simple-OpenVR-Driver-Tutorial` | Partially studied | Clean learning path for driver architecture | High | Low | Minimal driver bootstrap, lifecycle, where real projects diverge |
| `jangxx/openvr-battery-monitoring` | Not studied deeply | Battery-specific overlay/monitor pattern | Medium | Medium | Notification model, sampling strategy, whether it logs or only displays |
| `BarakChamo/OpenVR-OSC` | Not studied deeply | OSC bridge family comparison node | Medium | Medium | Event model, pose/input scope, VRChat/general automation fit |
| `PlutoVR/OpenXR-OverlayLayer-1` | Not studied deeply | Another OpenXR overlay-layer experiment | High | Medium | Overlay-layer architecture, host/client split, runtime assumptions |

## Priority batch B: comparison variants and forks

These are worth keeping visible, but they should usually be studied after the
main upstream or main family representative is understood.

| Project | Why it matters | What to inspect next |
|---|---|---|
| `3NekoSystem/OpenVR-Tracker-Websocket-Driver` | Fork/variant in tracker-driver family | Compare protocol and maintenance differences from the main WebSocket driver line |
| `v0xie/OpenVR-Tracker-Websocket-Driver` | Fork/variant in tracker-driver family | Determine whether it adds meaningful tracker or control features |
| `mutr/openvr_battery_monitor` | Battery-monitor family comparison node | Check whether it focuses on overlay, tray, or logging behavior |
| `TrueOpenVR/SteamVR-TrueOpenVR` | Custom driver/device learning path | Identify whether it is a teaching repo, compatibility shim, or device emulator |

## Family-level gaps that now deserve deeper passes

These are larger than a single repo and should guide the next research wave.

### 1. `Vendor enhancement tooling`

- Main entry: `PSVR2Toolkit`
- Why it matters:
  shows how to augment an official VR stack without fully replacing it.

### 2. `WebSocket-native tracker drivers`

- Main entries:
  `OpenVR-Tracker-Websocket-Driver`, `OpenVR-Driver`
- Why it matters:
  strongest path toward a future `Tracker Bridge Service`.

### 3. `Virtual tracker / OSC platform`

- Main entries:
  `VirtualMotionTracker`, `SteamVR_To_OSC`, `OpenVR2OSC`, `OpenVR-OSC`
- Why it matters:
  turns many scattered utility ideas into one coherent architecture category.

### 4. `Accessibility overlay family`

- Main entries:
  `OpenVRCaptions`, `live-captions-vr`, notification overlays
- Why it matters:
  already proven as a repeatable utility class, not a one-off experiment.

### 5. `Low-level driver learning path`

- Main entries:
  `Simple-OpenVR-Driver-Tutorial`, `opengloves-driver`, `GlassVr`,
  `OpenVR-ArduinoHMD`
- Why it matters:
  the repository has enough device-side references now to justify a dedicated
  learning track.

## Recommended next move

If `VR.app` continues this research, the next most valuable deep-pass order is:

1. `WebSocket tracker drivers`
2. `VirtualMotionTracker and OSC bridge family`
3. `PSVR2Toolkit / vendor enhancement path`
4. `Accessibility overlays`
5. `Low-level driver tutorial and custom-device plumbing`
