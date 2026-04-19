# VR Projects Wave 34: Tracked-Device Geometry, CAD, and Auxiliary Tracker Tooling

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `tracked-device geometry`, `CAD-to-tracker workflows`, and
  `auxiliary tracker tooling`.

## Why this wave exists

Many repositories in `VR-apps-lab` already cover tracker bridges, OSC export,
and role mapping, but they do not yet map another valuable branch clearly
enough:

- how tracked-device geometry and sensor layout become usable engineering data;
- how CAD or authoring tools can emit tracker definitions;
- how derived or synthetic tracker devices can be registered around very narrow
  roles like hips or DIY IMU stacks.

This wave exists to make `tracked-device design and auxiliary tracker tooling`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with Lighthouse reverse engineering, tracker JSON generation,
   derived-tracker, and IMU full-body queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `fughilli/ViveTrackedDevice` | Strongest reverse-engineering donor for the physical and geometric internals of a SteamVR-tracked device |
| `TriadSemi/Fusion360_SteamVR_Json` | Best authoring-tool donor for a `CAD -> SteamVR tracking JSON` workflow |
| `aughip/augmented-hip` | Strong donor for a derived waist tracker computed from existing tracked nodes |
| `m9cd0n9ld/IMU-VR-Full-Body-Tracker` | Best full-stack donor for a DIY tracker ecosystem split across hardware, desktop tooling, and a SteamVR driver |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `ebadier/ViveTrackers` | Useful Unity-side hardware-consumer comparison node, but weaker as a primary tracked-device design donor than the mainline repositories in this wave |

## Deep-pass notes by project

## `fughilli/ViveTrackedDevice`

- GitHub:
  [fughilli/ViveTrackedDevice](https://github.com/fughilli/ViveTrackedDevice)
- What it is:
  a documentation-heavy reverse-engineering project for a SteamVR-compatible
  tracked device, including diagrams, a paper, and submodule-backed code.
- Why it matters:
  it is the strongest donor in the repo for
  `documentation-first tracked-device reverse engineering`.
- Interesting ideas:
  treat physical tracked-device knowledge as a reusable engineering asset; keep
  diagrams, capture tooling, and solver code adjacent to the write-up; preserve
  the signal path from Lighthouse hardware to higher-level geometry and timing
  understanding.
- Interesting implementation choices:
  the root repo exposes diagrams, a paper, and submodules for
  `ViveTrackerSolver`, `ViveFPGACapture`, and `ViveVisualizer`, which makes the
  reverse-engineering split visible even when the submodule code is not present
  in a shallow source pass.
- Code donor value:
  medium.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  this pass should stay `Partially studied`, because the important code sits
  behind submodules and the repo is more of a hardware-design knowledge donor
  than a ready-to-lift implementation base.
- What to inspect next:
  keep it visible for a future `hardware-design and Lighthouse internals` pass
  if deeper device geometry work becomes central.

## `TriadSemi/Fusion360_SteamVR_Json`

- GitHub:
  [TriadSemi/Fusion360_SteamVR_Json](https://github.com/TriadSemi/Fusion360_SteamVR_Json)
- What it is:
  a Fusion360 add-in that turns CAD construction geometry into SteamVR tracking
  JSON.
- Why it matters:
  it is the strongest donor in the repo for
  `CAD-authored tracking geometry exported into SteamVR sensor definitions`.
- Interesting ideas:
  move tracker-definition work upstream into CAD; use construction axes and
  points as authoring primitives; generate tracking JSON automatically instead
  of hand-editing large sensor tables.
- Interesting implementation choices:
  `Fusion360_SteamVR_Json.py` shows how Fusion360 construction geometry is
  scanned and converted into `channelMap`, `modelNormals`, and `modelPoints`.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium-high.
- Caveats:
  narrow authoring-tool scope, but that narrowness is exactly what makes it a
  good donor.
- What to inspect next:
  keep it as the main reference whenever a future custom-device path needs a
  `physical design -> tracking definition` workflow.

## `aughip/augmented-hip`

- GitHub:
  [aughip/augmented-hip](https://github.com/aughip/augmented-hip)
- What it is:
  an OpenVR driver that estimates a hip tracker from other tracked body nodes
  and registers the result as a SteamVR waist tracker.
- Why it matters:
  it is the clearest donor in the repo for
  `derived role-specific virtual tracker`.
- Interesting ideas:
  use existing head and foot data to estimate a missing role; register the
  result as a proper tracked device with believable metadata; pair solver logic
  with driver registration instead of treating the synthetic pose as only an
  app-local value.
- Interesting implementation choices:
  `AugmentedHip/drivermain.cpp` and
  `AugmentedHip/AugmentedHipDevice.cpp` make the `OpenVR device provider ->
  virtual waist device` flow explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  highly specific to one derived tracker role, but the pattern generalizes well
  to other synthetic role paths.
- What to inspect next:
  keep it as the clearest reference whenever a future tool needs
  `missing-role reconstruction` rather than raw new-sensor ingestion.

## `m9cd0n9ld/IMU-VR-Full-Body-Tracker`

- GitHub:
  [m9cd0n9ld/IMU-VR-Full-Body-Tracker](https://github.com/m9cd0n9ld/IMU-VR-Full-Body-Tracker)
- What it is:
  a DIY full-body tracking stack spanning ESP32 firmware, a desktop control
  application, and an OpenVR driver.
- Why it matters:
  it is the strongest donor in the repo for
  `full-stack DIY tracker ecosystem with hardware, desktop configurator, and driver`.
- Interesting ideas:
  keep hardware, network transport, calibration, role selection, and driver
  registration visible as one system; use a desktop companion for WiFi, role,
  and calibration instead of hiding all complexity inside the driver.
- Interesting implementation choices:
  `desktop_server/main.py` and the driver project under
  `steamvr_openvr_driver/driver_imuFBT/` make the
  `desktop configurator + UDP bridge + driver` split easy to inspect.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  hardware-specific and broader than a micro-utility, but the full-stack split
  is exactly why it matters.
- What to inspect next:
  keep it as the strongest donor whenever a future path needs a complete
  `DIY tracker ecosystem` rather than a thin bridge only.

## Main takeaways from Wave 34

- `Tracked-device design and auxiliary tracker tooling` are now a distinct
  research branch, not just a side note under generic tracker bridges.
- The strongest split in this family is:
  - `documentation-first reverse engineering`
  - `CAD authoring and JSON generation`
  - `derived role-specific tracker`
  - `full-stack DIY tracker ecosystem`
- The most reusable lesson is often where `physical design` enters the software
  pipeline:
  - diagrams and capture artifacts
  - CAD construction geometry
  - role-specific synthetic device registration
  - desktop-side configuration for DIY hardware.

## Reusable methods clarified by this wave

- `CAD-to-SteamVR tracking JSON generation from physical design geometry`
- `Derived virtual tracker from existing tracked nodes with role-specific device registration`
- `DIY tracker ecosystem split across firmware, desktop control app, and driver`

## Recommended next moves after this wave

1. Keep `ViveTrackedDevice` visible as a reverse-engineering knowledge donor,
   but treat it honestly as `Partially studied` until a deeper submodule-aware
   pass happens.
2. Use `Fusion360_SteamVR_Json` as the main reference for
   `physical authoring -> tracker definition` workflows.
3. Use `augmented-hip` whenever a future design needs a
   `derived tracker that should look like a real SteamVR role device`.
4. Keep `IMU-VR-Full-Body-Tracker` as the best full-stack donor for
   `DIY tracker ecosystem` architecture.
