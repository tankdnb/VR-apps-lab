# VR Projects Wave 71: OpenVR Driver Learning Paths, Synthetic Devices, and Remote Input Ingress

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `OpenVR driver learning paths`, `synthetic devices`, and
  `remote-input ingress`.

## Why this wave exists

`VR-apps-lab` already had several driver tutorials and hardware bridges in
scope, but it still lacked a clearer picture of the
`lower-bound driver learning path`
from reusable tutorials to rough remote-ingress experiments.

This wave exists to make that family clearer:

- central OpenVR driver shells and device-class scaffolds;
- narrow controller-input emulation drivers;
- HMD-relative synthetic controller helpers;
- DIY HMDs fed by serial IMU data;
- browser-fed or file-fed synthetic VR drivers;
- tracking-override harnesses for third-party systems.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with OpenVR driver tutorial, DIY HMD, and synthetic-device
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `terminal29/Simple-OpenVR-Driver-Tutorial` | Strongest tutorial-grade central driver shell donor |
| `finallyfunctional/openvr-driver-example` | Strong donor for narrow controller scalar-component emission |
| `puresoul/Barebone` | Strong donor for HMD-relative synthetic Vive controllers over XInput |
| `r57zone/OpenVR-ArduinoHMD` | Strong donor for DIY HMD driver fed by serial IMU data and display config |
| `Somebody32x2/RemoteVVR` | Useful lower-bound donor for file-backed and browser-fed synthetic VR state |
| `codeysun/OpenVR-Tracker-Driver-Example` | Clear donor for generic tracker plus tracking-override workflow |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `cwlmyjm/openvr_treadmill` | Useful comparison node, but thinner than the shortlisted donors in this pass |

## Deep-pass notes by project

## `terminal29/Simple-OpenVR-Driver-Tutorial`

- GitHub:
  [terminal29/Simple-OpenVR-Driver-Tutorial](https://github.com/terminal29/Simple-OpenVR-Driver-Tutorial)
- What it is:
  a comprehensive tutorial-grade OpenVR driver shell with a central provider,
  reusable device classes, settings helpers, and practical debugging notes.
- Why it matters:
  it is still the clearest donor in this wave for
  `tutorial-grade central OpenVR driver shell`.
- Interesting ideas:
  keep device classes explicit; centralize event collection and frame timing;
  document debugging and installation paths as part of the learning surface.
- Interesting implementation choices:
  `driver_files/src/Driver/VRDriver.cpp`
  shows the central provider pattern, device registration, settings access, and
  frame update flow across HMD, controller, tracker, and tracking-reference
  types.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  tutorial-first rather than product-first, but that is exactly what makes it
  valuable.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `learnable driver shell`
  donor.

## `finallyfunctional/openvr-driver-example`

- GitHub:
  [finallyfunctional/openvr-driver-example](https://github.com/finallyfunctional/openvr-driver-example)
- What it is:
  a narrow example driver that emits joystick and trackpad input into OpenVR,
  intended as a starting point for treadmill, shoes, or locomotion hardware.
- Why it matters:
  it is the clearest donor in this wave for
  `narrow external locomotion input -> controller component driver`.
- Interesting ideas:
  keep the sample tiny; focus only on scalar component emission; let the wiki
  and surrounding documentation carry the learning burden.
- Interesting implementation choices:
  `OpenVrDriverExample/OpenVrDriverExample/src/DeviceProvider.cpp`
  shows the minimal provider shell while
  `OpenVrDriverExample/OpenVrDriverExample/src/ControllerDriver.cpp`
  sets up joystick and trackpad components and updates them each frame.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  medium-high.
- Caveats:
  intentionally narrow, but unusually useful because it exposes only the part
  many hardware bridges actually need.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `controller-scalar input example`
  donor.

## `puresoul/Barebone`

- GitHub:
  [puresoul/Barebone](https://github.com/puresoul/Barebone)
- What it is:
  an OpenVR driver that emulates Vive-like controllers from XInput, anchoring
  them relative to the user's HMD and exposing single or dual-control modes.
- Why it matters:
  it is the clearest donor in this wave for
  `HMD-relative synthetic controller placement over gamepad input`.
- Interesting ideas:
  place synthetic controllers inside the user's field of view; support both
  single- and dual-controller operation; combine offset presets with live input
  updates instead of needing full tracked controllers.
- Interesting implementation choices:
  `BareboneOpenVRTest/driver_barebone.cpp`
  shows controller offset presets, quaternion composition, OpenVR input
  component creation, and device-role setup for the synthetic controller pair.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  rough and experimental, but much stronger as a donor than its age suggests.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs an
  `HMD-relative synthetic controller`
  donor.

## `r57zone/OpenVR-ArduinoHMD`

- GitHub:
  [r57zone/OpenVR-ArduinoHMD](https://github.com/r57zone/OpenVR-ArduinoHMD)
- What it is:
  a DIY HMD driver for SteamVR that combines extended-monitor display output
  with head tracking from an Arduino-fed IMU.
- Why it matters:
  it is the clearest donor in this wave for
  `config-driven DIY HMD over serial IMU input`.
- Interesting ideas:
  treat display geometry and optics as config; support either Euler or
  quaternion input from serial; provide centering and hotkey helpers; let a
  tiny auxiliary app manage monitor state.
- Interesting implementation choices:
  `OpenVR/samples/driver_arduinohmd/driver_arduinohmd.cpp`
  shows the serial port setup, IMU parsing, centering logic, display and lens
  settings, and the HMD driver's property model.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  setup-heavy and DIY-oriented, but very valuable as a worked `serial IMU ->
  SteamVR HMD`
  baseline.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `DIY HMD or serial-pose driver`
  donor.

## `Somebody32x2/RemoteVVR`

- GitHub:
  [Somebody32x2/RemoteVVR](https://github.com/Somebody32x2/RemoteVVR)
- What it is:
  a synthetic HMD and controller driver whose state is fed from text files,
  plus a Node.js and Socket.IO browser UI that writes those files.
- Why it matters:
  it is the clearest lower-bound donor in this wave for
  `browser-fed or file-fed synthetic VR driver`.
- Interesting ideas:
  let a crude but readable external control plane drive the driver; keep the
  browser or remote-edit layer separate from the native driver; use plain text
  as the state contract.
- Interesting implementation choices:
  `finalDriverDir/inputs/inputGUI/server.js`
  shows the browser-side state model and file-writing contract while
  `HMDDriver/driver_files/src/Driver/HMDDevice.cpp`
  shows how the driver reads position and quaternion state from files and turns
  them into `TrackedDevicePoseUpdated` calls.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  medium-high.
- Caveats:
  rough and contains hard-coded local paths, but it is still a valuable
  low-bound ingress experiment.
- What to inspect next:
  keep it visible whenever a future branch needs a
  `very simple remote-input contract into a synthetic driver`
  comparison.

## `codeysun/OpenVR-Tracker-Driver-Example`

- GitHub:
  [codeysun/OpenVR-Tracker-Driver-Example](https://github.com/codeysun/OpenVR-Tracker-Driver-Example)
- What it is:
  a generic tracker example that can be used with SteamVR tracking overrides to
  replace or test head tracking.
- Why it matters:
  it is the clearest donor in this wave for
  `tracking-override generic tracker used as a head-pose harness`.
- Interesting ideas:
  keep the driver extremely small; let SteamVR tracking overrides do the role
  mapping; use a background pose thread rather than relying on `RunFrame`.
- Interesting implementation choices:
  `driver_files/src/DeviceProvider.cpp`
  registers the single tracker device while
  `driver_files/src/TrackerDriver.cpp`
  shows continuous pose publication, keyboard 6DOF control, and tracker role
  hints.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  medium-high.
- Caveats:
  minimal by design, but unusually useful for tracking-override experiments.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `generic tracker and tracking-override harness`
  donor.

## Main takeaways from Wave 71

- `low-level OpenVR driver donors` split more cleanly into:
  - `tutorial-grade central driver shell`
  - `narrow controller-scalar input driver`
  - `HMD-relative synthetic controller helper`
  - `DIY serial-IMU HMD`
  - `browser-fed or file-fed synthetic VR driver`
  - `tracking-override generic tracker harness`
- The strongest lesson from this wave is that
  `driver learning path`
  is not one straight line. Tutorials, narrow samples, DIY hardware drivers,
  and rough remote-ingress experiments each teach different boundaries.
- Another strong lesson is that very rough repos can still be worth keeping
  when they make the `state contract into the driver` unusually explicit.

## Reusable methods clarified by this wave

- `Tutorial-grade OpenVR driver shell with central provider, reusable device classes, and debugger-friendly workflow`
- `Narrow input-emulation driver that exposes controller scalar components for external locomotion hardware`
- `DIY HMD or tracker driver fed by serial, file, or lightweight remote channels with configurable display and pose sources`
- `Tracking-override generic tracker used to replace head pose or test third-party tracking systems`

## Recommended next moves after this wave

1. Treat `Simple-OpenVR-Driver-Tutorial` as the clearest donor in this wave
   for a `learnable central driver shell`.
2. Treat `openvr-driver-example` and `Barebone` as the strongest donors here
   for `external control -> synthetic controller` patterns at different levels
   of scope.
3. Keep `OpenVR-ArduinoHMD` visible whenever `VR-apps-lab` needs a stronger
   `DIY HMD over serial IMU`
   reference.
4. Keep `RemoteVVR` and `OpenVR-Tracker-Driver-Example` visible whenever a
   future branch needs rough but explicit `remote ingress` or
   `tracking override`
   comparisons.
