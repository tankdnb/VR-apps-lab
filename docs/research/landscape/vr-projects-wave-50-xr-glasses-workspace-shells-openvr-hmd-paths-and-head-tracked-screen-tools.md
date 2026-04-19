# VR Projects Wave 50: XR-Glasses Workspace Shells, OpenVR HMD Paths, and Head-Tracked Screen Tools

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `XR-glasses workspace shells`, `OpenVR HMD paths`, and
  `head-tracked screen tools`.

## Why this wave exists

`VR-apps-lab` already had a strong first pass on XR-glasses stacks, but the
family still needed clearer internal structure:

- workspace shells that sit above drivers, compositor hooks, and environment
  integrations;
- thin OpenVR HMD drivers that repurpose glasses IMU data into a runtime-facing
  headset path;
- sidecars that export glasses head tracking into non-XR consumers;
- screen-transformation pipelines that compete with or complement driver-backed
  display workflows.

This wave exists to make
`XR-glasses workspace shells, OpenVR HMD paths, and head-tracked screen tools`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with XR-glasses, OpenVR HMD, head-tracking, and
   spatial-screen queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `wheaney/breezy-desktop` | Strong donor for a driver-backed XR-glasses workspace shell with environment-specific branches |
| `lc700x/desktop2stereo` | Strong comparison node for transforming ordinary desktop or video content into stereoscopic screen output |
| `wheaney/OpenVR-xrealAirGlassesHMD` | Strong donor for a thin OpenVR HMD path over glasses IMU data |
| `iVideoGameBoss/PhoenixHeadTracker` | Strong donor for exporting glasses head tracking into non-XR consumers like opentrack or mouse-look |

## Secondary candidates surfaced in the same wave

No secondary candidate in this wave was stronger than the frozen shortlist.

## Deep-pass notes by project

## `wheaney/breezy-desktop`

- GitHub:
  [wheaney/breezy-desktop](https://github.com/wheaney/breezy-desktop)
- What it is:
  a Linux XR-glasses workspace shell layered over driver, compositor, and
  environment integrations.
- Why it matters:
  it is the clearest donor in the repo for
  `workspace shell layered over a special-display driver and environment hooks`.
- Interesting ideas:
  keep shell UX above the base driver; support GNOME, KDE, and a separate
  Vulkan-oriented path; treat desktop productivity and gaming mode as adjacent
  but not identical products.
- Interesting implementation choices:
  `gnome/src/extension.js` and
  `kwin/src/xrdriveripc/xrdriveripc_runner.py`
  make the `driver IPC -> compositor or environment bridge -> workspace shell`
  split explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  Linux-first integration keeps the runtime target narrow, but the shell layering
  is unusually strong.
- What to inspect next:
  keep it visible whenever a future branch needs
  `workspace-shell architecture over nonstandard displays`.

## `lc700x/desktop2stereo`

- GitHub:
  [lc700x/desktop2stereo](https://github.com/lc700x/desktop2stereo)
- What it is:
  a broad desktop or video transformation pipeline that estimates depth and
  emits stereoscopic output across several delivery modes.
- Why it matters:
  it is the clearest comparison node in the repo for
  `screen transformation pipeline instead of direct display-driver ownership`.
- Interesting ideas:
  treat ordinary screen content as convertible media; keep capture, depth,
  rendering, and output modes as distinct pipeline stages; prefer latest-frame
  processing over expensive full queue backlogs.
- Interesting implementation choices:
  `main.py`
  makes the `capture -> depth estimation -> stereo render -> multi-output`
  utility pipeline explicit.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  model assumptions and broad output surface make it a better product and
  pipeline donor than a runtime-integration donor.
- What to inspect next:
  keep it visible whenever a future branch needs
  `AI screen transformation` rather than a runtime-facing HMD path.

## `wheaney/OpenVR-xrealAirGlassesHMD`

- GitHub:
  [wheaney/OpenVR-xrealAirGlassesHMD](https://github.com/wheaney/OpenVR-xrealAirGlassesHMD)
- What it is:
  an OpenVR HMD driver that turns XREAL glasses IMU data into a thin headset
  path for the runtime.
- Why it matters:
  it is the clearest donor in the repo for
  `lightweight OpenVR HMD driver over a glasses IMU backend`.
- Interesting ideas:
  adapt a glasses sensor source into a runtime-facing headset; keep display
  component and tracked-device responsibilities explicit; correct and re-center
  IMU orientation before it reaches SteamVR.
- Interesting implementation choices:
  `driver_air_glasses.cpp` and
  `driver_air_glasses.h`
  make the `sensor callback -> orientation correction -> OpenVR HMD and display
  surfaces` split explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  it is intentionally thin, so the strongest lesson is driver adaptation rather
  than a broad desktop shell.
- What to inspect next:
  keep it visible whenever a future branch needs
  `runtime-facing special-display device plumbing`.

## `iVideoGameBoss/PhoenixHeadTracker`

- GitHub:
  [iVideoGameBoss/PhoenixHeadTracker](https://github.com/iVideoGameBoss/PhoenixHeadTracker)
- What it is:
  a Windows Forms sidecar that reads glasses tracking data and exports it to
  opentrack-style or mouse-look consumers.
- Why it matters:
  it is the clearest donor in the repo for
  `3DoF glasses head-tracking sidecar for non-XR consumers`.
- Interesting ideas:
  do not require a full VR runtime to make head tracking useful; add drift
  fighting, Kalman filtering, mappings, and scaling directly in the control
  shell; keep export modes simple and user-facing.
- Interesting implementation choices:
  `Form1.cs`
  makes the `glasses tracking input -> filter and calibration -> UDP or mouse
  export` flow explicit.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  vendor DLL dependence narrows direct reuse, but the `head tracking sidecar`
  product shape is clear.
- What to inspect next:
  keep it visible whenever a future branch needs
  `head tracking without full XR runtime ownership`.

## Main takeaways from Wave 50

- `XR-glasses workflows` are now clearer internally and no longer collapse into
  one generic `virtual display` bucket.
- The strongest split in this family is:
  - `workspace shell over driver and environment integrations`
  - `screen transformation pipeline`
  - `thin OpenVR HMD driver`
  - `non-XR head-tracking sidecar`
- The most reusable lesson is that `special-display tooling` can be built at
  several very different layers:
  - a platform shell above the driver
  - a runtime-facing device path
  - a non-XR head-tracking export tool
  - a content-transformation pipeline

## Reusable methods clarified by this wave

- `XR-glasses workspace shell layered over driver, compositor, and environment hooks`
- `2D-to-stereo screen pipeline with latest-frame capture, depth estimation, and multi-output modes`
- `Lightweight OpenVR HMD driver over a glasses IMU backend`
- `3DoF glasses head-tracking sidecar for UDP or mouse-look consumers`
