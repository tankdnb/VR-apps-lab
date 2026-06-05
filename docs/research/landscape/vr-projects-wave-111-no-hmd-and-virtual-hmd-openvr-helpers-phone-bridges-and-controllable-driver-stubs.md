# VR Projects Wave 111: No-HMD and Virtual-HMD OpenVR Helpers, Phone Bridges, and Controllable Driver Stubs

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `no-HMD`, `virtual-HMD`, `phone-HMD`, and `controllable null-driver`
  workflows.

## Why this wave exists

Development and diagnostics tools often need a headsetless workflow: fake a
headset, expose a desktop display as an HMD, accept pose from controllers or a
tracker, stream to a phone, or drive a virtual device from scripts. These
projects are useful even when they are old or rough because they reveal the
minimum OpenVR driver pieces needed for test harnesses and development helpers.

This wave studies no-HMD and virtual-device projects as reference architecture
for future diagnostics, automated tests, and local development utilities.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by phone-HMD, fake HMD, no-HMD OpenVR, null driver, and
   virtual-device control families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `PhoneVR-Developers/PhoneVR` | Phone-as-HMD bridge with OpenVR driver, TCP pairing, projection exchange, virtual display present path, and Android client paths |
| `SDraw/driver_hmd` | Minimal desktop-display-as-HMD OpenVR driver with display component, pose update loop, and keyboard transform controls |
| `pema99/faceless` | No-HMD driver that estimates fake HMD pose from controllers or a tracker and persists calibration |
| `kajsaantonigelstrom/OpenVRsim` | Null OpenVR driver controlled from Python through ZeroMQ with scripted pose/button test cases |
| `blakebeckcoding/Pepper` | Tutorial-style fake HMD plus controllers rig driven by keyboard and mouse input |

## Deep-pass notes by project

## `PhoneVR-Developers/PhoneVR`

- GitHub:
  [PhoneVR-Developers/PhoneVR](https://github.com/PhoneVR-Developers/PhoneVR)
- What it is:
  an open-source phone-as-HMD project for SteamVR, with a legacy PhoneVR
  server path and an ALVR/Cardboard-oriented mobile path.
- Interesting idea:
  a phone-HMD bridge splits the problem into pairing, projection exchange,
  pose ingress, video streamout, and user-facing latency diagnostics.
- Code-level notes:
  `code/windows/PhoneVR/PhoneVR/driver.cpp`
  implements an OpenVR HMD with `ITrackedDeviceServerDriver`,
  `IVRDisplayComponent`, and `IVRVirtualDisplay`. The driver handles TCP
  pairing, receives render dimensions, projection rects, and IPD, sets device
  properties, starts streamer and pose receive paths, throttles `Present` to
  configured FPS, and updates SteamVR through provider callbacks.
  `code/common/src/PVRSocketUtils.cpp`
  defines framed TCP messages with a `pvr` prefix, message type, size, and
  payload. The Android side includes ALVR/Cardboard pose and rendering paths
  plus debug overlays for FPS and latency.
- Code donor value:
  high for phone-HMD pairing, projection negotiation, and pose/video split.
- Product reference value:
  medium-high as architecture history for phone-based headset workflows.
- Caveats:
  the legacy PhoneVR server is old and latency-sensitive; treat it as a
  reference, not a modern replacement for ALVR-class streaming.
- What to inspect next:
  compare only if a future pass needs phone-HMD or ALVR bridge history.

## `SDraw/driver_hmd`

- GitHub:
  [SDraw/driver_hmd](https://github.com/SDraw/driver_hmd)
- What it is:
  a SteamVR driver that exposes a desktop display as an HMD with keyboard
  transform controls.
- Interesting idea:
  the minimum fake-HMD display path is a valid tracked device plus a display
  component that SteamVR can address as an HMD surface.
- Code-level notes:
  `driver_hmd/CHmdDevice.cpp`
  implements `ITrackedDeviceServerDriver` and `IVRDisplayComponent`, sets
  HMD class properties, model/render model names, display frequency, icons,
  desktop display flags, render target size, one-eye viewport assumptions, raw
  projection, identity distortion, pose validity, and a `RunFrame` pose update.
  It also accepts `DebugRequest("transform ...")` style input to change pose
  transforms and persists resolution/FPS/transform config.
- Code donor value:
  medium-high for a minimal OpenVR HMD display component.
- Product reference value:
  medium for headsetless display experiments and OpenVR driver learning.
- Caveats:
  old Visual Studio project and simple display semantics; useful as a driver
  anatomy reference rather than a modern product.
- What to inspect next:
  compare with null drivers and no-HMD helper projects before building any
  fake display prototype.

## `pema99/faceless`

- GitHub:
  [pema99/faceless](https://github.com/pema99/faceless)
- What it is:
  an OpenVR driver for using controllers without a physical HMD.
- Interesting idea:
  fake head pose can be inferred from controllers or a tracker, then calibrated
  with simple keybinds and persisted as settings.
- Code-level notes:
  `driver_faceless/driver_faceless.cpp`
  implements HMD server driver, display component, and virtual display
  interfaces. It reads settings for serial, model, render size, display
  frequency, FOV, and tracker usage. `GetPose` enumerates tracked devices,
  collects controller and generic-tracker poses, uses a tracker when present,
  or averages controllers with height offset otherwise. `RunFrame` handles
  calibration keybinds, save/reset config, and SteamVR pose updates.
- Code donor value:
  high for HMD-less pose inference and calibration persistence.
- Product reference value:
  high for controller-only development and no-HMD workflows.
- Caveats:
  proof-of-concept quality; controller-only head estimation is inherently
  approximate.
- What to inspect next:
  compare with OpenVRsim and Pepper as controlled pose sources.

## `kajsaantonigelstrom/OpenVRsim`

- GitHub:
  [kajsaantonigelstrom/OpenVRsim](https://github.com/kajsaantonigelstrom/OpenVRsim)
- What it is:
  a null OpenVR driver with HMD/controllers controllable from Python through
  ZeroMQ, intended for development without a headset.
- Interesting idea:
  a virtual-device driver becomes much more useful when an external script can
  drive poses, buttons, test cases, and optional eye data.
- Code-level notes:
  `driver/virtualdevice/src/virtualdevice.cpp`
  implements a sample HMD device, display component, proximity input to avoid
  standby, settings loading, and pose updates through a `PositionManager`.
  `driver/virtualdevice/src/zeromqthread.cpp`
  binds a ZeroMQ REP socket, receives command strings, dispatches them to a
  callback, and replies.
  `python/controller.py`
  holds HMD, left, right, and eye pose state, opens ZMQ sockets, sends commands
  for position, rotation, buttons, and tests, and can generate/load CSV test
  cases for scripted pose sequences.
- Code donor value:
  very high for external/scripted virtual-device control harnesses.
- Product reference value:
  high for headsetless automated testing and repeatable VR interaction scripts.
- Caveats:
  old tooling and Windows/SteamVR driver-copy assumptions; treat as a harness
  architecture donor.
- What to inspect next:
  compare with capture/replay and orchestration references when VR regression
  testing becomes active.

## `blakebeckcoding/Pepper`

- GitHub:
  [blakebeckcoding/Pepper](https://github.com/blakebeckcoding/Pepper)
- What it is:
  a tutorial-style fake VR driver that presents an HMD and controllers to
  SteamVR and drives them with keyboard and mouse input.
- Interesting idea:
  a learning driver can explain the minimal rig: provider factory, fake HMD,
  fake controllers, input thread, pose update loop, and controller components.
- Code-level notes:
  `src/FakeVRProvider.h`
  registers a fake HMD and left/right fake controllers, starts an input thread,
  and updates devices per frame.
  `src/FakeHMD.h`
  sets HMD display properties and uses shared input state for pose updates.
  `src/FakeController.h`
  creates scalar and boolean component handles for trigger, grip, thumbstick,
  A/B/system buttons, controller role, and pose. `src/InputSystem.h`
  updates head pose and controller inputs from mouse deltas and keyboard state.
- Code donor value:
  medium-high for educational fake-device anatomy.
- Product reference value:
  medium for local development and driver onboarding.
- Caveats:
  the source appears rough and should be treated as tutorial/reference material
  rather than a drop-in compile target.
- What to inspect next:
  compare with official OpenVR sample drivers and simpler no-HMD stubs.

## Main takeaways from Wave 111

- Headsetless workflows split into phone bridges, desktop-display HMDs,
  controller/tracker fake-HMD pose, socket-controlled drivers, and keyboard
  fake rigs.
- The reusable boundary is usually the OpenVR provider, HMD display component,
  pose/control ingress, and external command model.
- Older driver projects remain useful when framed as anatomy references and
  test-harness patterns, not as promised modern tools.
- Socket-controlled virtual devices are especially valuable for future
  automated diagnostics and repeatable VR test scenarios.

## Reusable methods clarified by this wave

- `Phone-as-HMD bridge with pairing, projection exchange, pose ingress, and video streamout`
- `Desktop display or null display OpenVR HMD component`
- `External/scripted virtual-device control harness over a socket`
- `Keyboard-and-mouse fake HMD plus controller rig for SteamVR development`

## Recommended next moves after this wave

1. Keep OpenVRsim visible as the strongest virtual-device test harness
   reference.
2. Keep faceless visible as the cleanest no-HMD pose inference reference.
3. Keep PhoneVR as phone-HMD architecture history, not as a default modern
   product direction.
4. Use Pepper and driver_hmd as driver anatomy references when documenting
   minimum viable OpenVR fake-device patterns.
