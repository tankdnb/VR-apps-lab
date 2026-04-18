# Discovery Sources

- Date: `2026-04-18`
- Goal: define a repeatable way to find new repositories related to VR
  utilities and tools.

## Primary discovery channels

### 1. GitHub topic and keyword search

Most useful keywords:

- `openvr`
- `openxr`
- `steamvr`
- `vr overlay`
- `openxr layer`
- `passthrough`
- `lighthouse`
- `vr tracker`
- `osc`
- `motion compensation`
- `vr battery`
- `vr captions`
- `vr dashboard`
- `xr utility`

Useful combined searches:

- `openxr overlay`
- `steamvr utility`
- `openvr driver tracker`
- `steamvr websocket`
- `openxr runtime switcher`
- `steamvr battery overlay`
- `vrchat osc steamvr`
- `passthrough openxr layer`

Helpful command-line path:

- `gh search repos "steamvr overlay" --limit 20`
- `gh search repos "openxr layer" --limit 20`
- `gh search repos "steamvr utility" --limit 20`
- `gh search repos "openvr driver tracker" --limit 20`

### 2. Family expansion from known repos

For every already tracked project, look for:

- forks with meaningful commits;
- "similar repositories" in GitHub UI;
- issue threads linking competitor tools;
- projects mentioned in README comparisons;
- projects listed in release notes or migration notes.

This is especially effective for:

- runtime switchers
- lighthouse managers
- tracker drivers
- battery tools
- passthrough tools
- desktop overlay suites

### 3. Ecosystem-specific search streams

#### SteamVR / OpenVR stream

Look for:

- overlays
- drivers
- utilities
- trackers
- dashboard tools

#### OpenXR stream

Look for:

- API layers
- runtime tools
- diagnostics
- motion compensation
- passthrough experiments
- overlay utilities

#### VRChat / OSC stream

Look for:

- OSC bridges
- automation tools
- tracking export/import
- integration hubs

#### Creator and workflow stream

Look for:

- metrics tools
- session capture
- Blender/OpenXR workflows
- kneeboards
- reference panels

### 4. Vendor-specific exploration

Search by vendor and utility keywords:

- `PSVR2 utility`
- `PICO OpenXR`
- `Vive tracker utility`
- `WMR passthrough`
- `Quest OpenXR tool`
- `Varjo OpenXR layer`

This is where vendor-enhancement layers and device-specific tools usually
appear.

## Discovery quality filter

A newly found repository is relevant to `VR-apps-lab` if it contributes at least one
of the following:

- a reusable implementation method;
- a useful product reference;
- a clean architecture pattern;
- an unusual but important device/control/integration path.

## What not to prioritize

Usually lower priority:

- generic VR games with no utility features;
- abandoned repos with no clear technical lesson;
- forks that do not materially differ from the upstream;
- showcase repos with no code and no clear architecture value.
