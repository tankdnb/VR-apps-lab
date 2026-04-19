# VR Projects Wave 35: Expressive Tracking and Avatar-Facing Input Bridges

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `expressive tracking`, `face and eye input`, and
  `avatar-facing input bridges`.

## Why this wave exists

Many repositories in `VR-apps-lab` already cover body tracking, hand bridges,
and vendor-enhancement layers, but they do not yet map another valuable branch
clearly enough:

- face and eye-tracking platforms built for social or avatar-facing use;
- remappers that bridge incompatible provider or skeleton models;
- driver or API-layer paths that turn vendor-specific expressive data into more
  generally consumable inputs.

This wave exists to make `expressive tracking and avatar-facing bridge design`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with face tracking, eye tracking, hand remapping, and
   avatar-bridge queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `Project-Babble/Baballonia` | Strongest cross-platform donor for a broad expressive-tracking platform with overlay-assisted calibration and modular capture sources |
| `jcorvinus/HandshakeVR` | Best donor for remapping incompatible hand providers into a single interaction model |
| `moshimeow/mercury_steamvr_driver` | Useful driver donor for a `tracking subprocess -> SteamVR hand-device registration` pipeline |
| `BattleAxeVR/PSVR2_OpenXR_Eye_Tracking` | Strong donor for a vendor-specific gaze source adapted into standard OpenXR layer surfaces |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `takana-v/quest_steamvr_fbt_tool` | Useful avatar-facing export node, but weaker as a primary donor than the more explicit bridge and layer designs in this wave |

## Deep-pass notes by project

## `Project-Babble/Baballonia`

- GitHub:
  [Project-Babble/Baballonia](https://github.com/Project-Babble/Baballonia)
- What it is:
  a cross-platform face and eye-tracking platform with multiple capture inputs,
  overlay-assisted calibration, and downstream consumers like VRChat and other
  social VR targets.
- Why it matters:
  it is the strongest donor in the repo for
  `modular expressive-tracking platform with overlay-assisted calibration`.
- Interesting ideas:
  separate capture modules from output targets; keep calibration and trainer
  flows in a dedicated overlay boundary; treat the platform as a configurable
  host rather than one fixed face-tracking pipeline.
- Interesting implementation choices:
  `src/Baballonia.Desktop/Program.cs` and
  `src/Baballonia.Desktop/Calibration/OverlayCalibrationService.cs` make the
  single-instance app structure, overlay startup, local socket boundary, and
  calibration lifecycle easy to inspect.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  broad platform scope, but the expressive-tracking slice is already clear
  enough to count as `Already studied`.
- What to inspect next:
  keep it as the main donor whenever a future `VR-apps-lab` branch needs a
  `capture-module host + overlay-assisted trainer` structure.

## `jcorvinus/HandshakeVR`

- GitHub:
  [jcorvinus/HandshakeVR](https://github.com/jcorvinus/HandshakeVR)
- What it is:
  a Unity compatibility layer that remaps different hand or controller providers
  into a common interaction model.
- Why it matters:
  it is the clearest donor in the repo for
  `cross-provider hand-input remapping`.
- Interesting ideas:
  switch providers at runtime based on controller validity; use an abstract
  hand-input provider model; keep the surrounding interaction stack stable while
  the underlying hand source changes.
- Interesting implementation choices:
  `Assets/HandshakeVR/Scripts/ProviderSwitcher.cs` and
  `Assets/HandshakeVR/Scripts/HandInputProvider.cs` make the provider-switch and
  hand-data abstraction boundaries explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  rooted in an older Unity stack, but the provider-remapping lesson remains
  reusable.
- What to inspect next:
  keep it visible whenever a future tool needs a `hand data compatibility
  layer` rather than a new tracker backend.

## `moshimeow/mercury_steamvr_driver`

- GitHub:
  [moshimeow/mercury_steamvr_driver](https://github.com/moshimeow/mercury_steamvr_driver)
- What it is:
  a SteamVR driver that launches a subprocess for hand-tracking data and
  registers left and right hand devices in SteamVR.
- Why it matters:
  it is the strongest donor in the repo for
  `expressive hand driver with tracking subprocess ownership`.
- Interesting ideas:
  let a subprocess own camera or tracking concerns; keep the SteamVR driver
  focused on connection, device registration, and role exposure; build a narrow
  hand-device surface rather than a full general tracker stack.
- Interesting implementation choices:
  `src/steamvr_driver/device_provider.cpp` makes the
  `driver startup -> subprocess -> socket intake -> left/right device
  registration` boundary explicit.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  unmaintained and explicitly risky for general users, but still a clean donor
  for the `driver + subprocess` pattern.
- What to inspect next:
  keep it as a comparison node whenever a future hand-tracking driver path
  needs to decide how much should live in-process versus out-of-process.

## `BattleAxeVR/PSVR2_OpenXR_Eye_Tracking`

- GitHub:
  [BattleAxeVR/PSVR2_OpenXR_Eye_Tracking](https://github.com/BattleAxeVR/PSVR2_OpenXR_Eye_Tracking)
- What it is:
  an OpenXR API layer that adapts PSVR2 eye-tracking data into standard gaze
  surfaces for PC and SteamVR workflows.
- Why it matters:
  it is the strongest donor in the repo for
  `vendor-specific gaze IPC translated into a standard OpenXR layer surface`.
- Interesting ideas:
  only activate the layer when the relevant extensions are requested; split the
  vendor-specific eye-data path from the standard OpenXR-facing contract; use a
  named-pipe bridge so the gaze source can be external to the layer itself.
- Interesting implementation choices:
  `openxr-api-layer/layer.cpp` and
  `openxr-api-layer/psvr2_eye_tracking.cpp` make the extension gating, layer
  bypass behavior, and named-pipe gaze ingestion explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  vendor-specific, but that specificity is exactly what makes it a good donor
  for `custom gaze source -> standard OpenXR interface` work.
- What to inspect next:
  compare it later with `OpenXR-Eye-Trackers` and `etvr-openxr-layer` whenever
  a future branch needs a clearer gaze-layer comparison matrix.

## Main takeaways from Wave 35

- `Expressive tracking and avatar-facing bridges` are now a distinct family,
  not only a side branch of generic body-tracking work.
- The strongest split in this family is:
  - `broad expressive-tracking host platform`
  - `provider-remapping compatibility layer`
  - `SteamVR driver with tracking subprocess`
  - `vendor-specific gaze source adapted through an OpenXR API layer`
- The most reusable lesson is often the `adaptation boundary`:
  - overlay-assisted calibration
  - capture-module abstraction
  - provider switching
  - subprocess ownership
  - extension-gated layer activation
  - named-pipe or other local IPC into a standard XR surface.

## Reusable methods clarified by this wave

- `Overlay-assisted calibration over modular expressive-tracking capture sources`
- `Cross-provider hand-input remapping into a common interaction model`
- `Vendor-specific gaze IPC translated into an OpenXR API layer`

## Recommended next moves after this wave

1. Treat `Baballonia` as the main donor for
   `capture-module host + overlay-assisted calibration` design.
2. Keep `HandshakeVR` as the clearest donor for
   `provider-remapping compatibility layers`.
3. Use `mercury_steamvr_driver` whenever a future path needs to reason about
   `driver ownership versus subprocess ownership` for hand-tracking data.
4. Keep `PSVR2_OpenXR_Eye_Tracking` as the clearest vendor-specific donor for
   `custom gaze source -> standard OpenXR gaze surface`.
