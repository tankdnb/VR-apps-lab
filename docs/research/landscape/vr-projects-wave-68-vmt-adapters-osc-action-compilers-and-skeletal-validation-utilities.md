# VR Projects Wave 68: VMT Adapters, OSC Action Compilers, and Skeletal Validation Utilities

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `VirtualMotionTracker adapters`, `OSC action compilers`, and
  `skeletal validation utilities`.

## Why this wave exists

`VR-apps-lab` already had broad coverage of tracker bridges and OSC exporters,
but it still lacked a sharper answer to
`what kinds of sub-tools live around VirtualMotionTracker and adjacent OSC families`.

This wave exists to make that family clearer:

- manager-plus-driver virtual-tracker platforms;
- thin action-manifest-driven OSC exporters;
- minimal pose-bundle exporters;
- protocol adapters that feed an existing host;
- skeletal validation utilities;
- config-defined controller-to-OSC compilers.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with `VMT`, SteamVR OSC export, and skeletal validation
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `gpsnmeajp/VirtualMotionTracker` | Strongest mature donor for `manager plus driver` virtual-tracker architecture |
| `Greendayle/SteamVR_To_OSC` | Thin action-manifest-based controller-to-OSC exporter |
| `BarakChamo/OpenVR-OSC` | Lower-bound pose exporter based on compact device polling and OSC bundles |
| `faidra/VMC2VMT` | Clear protocol adapter that feeds `VMT` instead of implementing a new driver |
| `gpsnmeajp/SkeletonPoseTester` | Useful validation node for SteamVR skeletal-input paths |
| `logicmachine/OVR-VRC-OSC-Bridge` | Strong donor for config-defined action sets compiled into OSC output |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `ArT-Programming/VRtoOSC` | Overlaps heavily with thinner OSC export lessons already covered in this pass |
| `thakyuu/VirtualTrackerPositionManager` | Useful comparison node, but weaker than the shortlisted repos as a main donor |
| `rtlcopymemory/open_scale` | Adjacent signal rather than a clearer VMT or OSC-compiler donor in this wave |

## Deep-pass notes by project

## `gpsnmeajp/VirtualMotionTracker`

- GitHub:
  [gpsnmeajp/VirtualMotionTracker](https://github.com/gpsnmeajp/VirtualMotionTracker)
- What it is:
  a mature virtual-tracker platform split across a desktop manager and a SteamVR
  driver, with OSC transport and skeletal-input support.
- Why it matters:
  it is still the clearest donor for
  `manager plus driver virtual-tracker host rather than one monolithic helper`.
- Interesting ideas:
  keep SteamVR health checks and null-driver checks in the manager; separate
  OSC transport from driver registration; maintain a large synthetic-device
  pool rather than only one-off tracker creation.
- Interesting implementation choices:
  `vmt_manager/MainWindow.xaml.cs`
  handles runtime health and setup flow,
  `vmt_manager/OSC.cs`
  owns OSC send and receive paths, and
  `vmt_driver/ServerTrackedDeviceProvider.cpp`
  shows config-driven device registration and provider-side ownership.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  broad enough that later passes should still stay narrow around the
  manager-driver boundary instead of re-reading the entire platform.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `virtual-tracker host with real lifecycle management`.

## `Greendayle/SteamVR_To_OSC`

- GitHub:
  [Greendayle/SteamVR_To_OSC](https://github.com/Greendayle/SteamVR_To_OSC)
- What it is:
  a small utility app that initializes OpenVR, loads an action manifest, maps
  action names through config, and pushes controller state to OSC.
- Why it matters:
  it is the clearest thin donor in this wave for
  `action-manifest OpenVR utility exporting input to OSC`.
- Interesting ideas:
  run as a utility app instead of a driver; let a JSON map define output naming;
  keep the update loop and OSC send path simple.
- Interesting implementation choices:
  `index_to_osc/index_to_osc.py`
  initializes OpenVR as `VRApplication_Utility`, loads a custom action
  manifest, resolves analog and digital actions, and sends mapped OSC values on
  a tight loop.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  medium.
- Caveats:
  narrow and Python-heavy, but valuable precisely because the boundary is so
  explicit.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `small controller-to-OSC exporter`
  rather than a broader platform host.

## `BarakChamo/OpenVR-OSC`

- GitHub:
  [BarakChamo/OpenVR-OSC](https://github.com/BarakChamo/OpenVR-OSC)
- What it is:
  a compact Python exporter that groups OpenVR devices by class and sends pose
  data into OSC bundles.
- Why it matters:
  it is the cleanest lower-bound donor in this wave for
  `minimal pose-bundle export from SteamVR`.
- Interesting ideas:
  classify devices into a few stable groups; send OSC bundles per tick; keep
  discovery and export in one narrow script.
- Interesting implementation choices:
  `openvr-osc.py`
  builds on `triad_openvr`, discovers devices by type, and emits OSC bundles
  instead of a heavier service shell.
- Code donor value:
  medium.
- Product reference value:
  low-medium.
- Architecture reference value:
  medium.
- Caveats:
  intentionally minimal, so the value is more architectural than product-level.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `tiny pose exporter`
  reference.

## `faidra/VMC2VMT`

- GitHub:
  [faidra/VMC2VMT](https://github.com/faidra/VMC2VMT)
- What it is:
  a Unity-side adapter that receives `VMC` performer data and forwards it into
  `VirtualMotionTracker`.
- Why it matters:
  it is the clearest donor in this wave for
  `protocol adapter feeding an existing virtual-tracker host`.
- Interesting ideas:
  avoid writing a new SteamVR driver; keep protocol translation in the engine
  layer; let `VMT` stay the tracker host and device registrar.
- Interesting implementation choices:
  `Assets/VMC2VMT/AppController.cs`
  coordinates availability state between the `VMCReceiver` and `VMTSender`,
  while
  `Assets/VMC2VMT/VMTSender.cs`
  iterates mapped bones and emits `/VMT/Room/Unity` messages directly.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  tied to Unity and performer-side workflows, but the transport-adapter lesson
  is stronger than the app shell.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `protocol adapter into an existing tracker platform`
  donor.

## `gpsnmeajp/SkeletonPoseTester`

- GitHub:
  [gpsnmeajp/SkeletonPoseTester](https://github.com/gpsnmeajp/SkeletonPoseTester)
- What it is:
  a small Unity utility used to validate SteamVR skeletal-input behavior,
  especially for custom drivers and VMT-adjacent experiments.
- Why it matters:
  it is the clearest validation reference in this wave for
  `skeletal-input test utility rather than tracker host`.
- Interesting ideas:
  keep the validation target narrow; treat hand-skeleton correctness as a
  separate problem from tracker transport; allow small utilities to exist only
  as test surfaces.
- Interesting implementation choices:
  the repo exposes very little custom code beyond the scene and utility shell,
  which itself is an important lesson about how lightweight a validation tool
  can be.
- Code donor value:
  low-medium.
- Product reference value:
  medium.
- Architecture reference value:
  low-medium.
- Caveats:
  stronger as a validation and product-reference node than as a direct code
  donor.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `skeletal-input validation`
  comparison.

## `logicmachine/OVR-VRC-OSC-Bridge`

- GitHub:
  [logicmachine/OVR-VRC-OSC-Bridge](https://github.com/logicmachine/OVR-VRC-OSC-Bridge)
- What it is:
  a controller-to-OSC bridge that defines action sets in JSON, generates an
  OpenVR action manifest, and compiles analog, binary, and rotate actions into
  OSC messages.
- Why it matters:
  it is the clearest donor in this wave for
  `config-defined action-set compiler into OSC`.
- Interesting ideas:
  keep action semantics in JSON instead of hard-coding them; support analog
  range remapping and rotate-state transitions; generate the action manifest
  from the same config source.
- Interesting implementation choices:
  `main.cpp`
  loads configuration and initializes the runtime,
  `configuration.h`
  models analog, binary, and rotate actions, and
  `input_handler.h`
  updates action sets and compiles current state into OSC messages and bundles.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  avatar-facing, but the architecture generalizes well beyond `VRChat`.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `controller-state compiler into OSC`
  donor.

## Main takeaways from Wave 68

- `VirtualMotionTracker-adjacent tooling` splits more cleanly into:
  - `manager plus driver virtual-tracker platform`
  - `thin action-manifest OSC exporter`
  - `minimal pose-bundle exporter`
  - `protocol adapter feeding an existing tracker host`
  - `skeletal validation utility`
  - `config-defined action compiler into OSC`
- The strongest lesson from this wave is that
  `OSC export`
  is not one pattern. Host platforms, utility apps, protocol adapters, and
  validation tools all sit at different points in the same family.
- Another strong lesson is that
  `do not write a new driver`
  can be a first-class architecture choice when an existing host such as `VMT`
  already solves device registration and lifecycle.

## Reusable methods clarified by this wave

- `Manager-plus-driver virtual-tracker platform with OSC ingress, runtime health checks, and synthetic-device pooling`
- `Action-manifest OpenVR utility that exports controller state to OSC through config-defined mappings`
- `Protocol adapter and validation layer around an existing virtual-tracker host`

## Recommended next moves after this wave

1. Treat `VirtualMotionTracker` as the clearest donor for
   `manager plus driver virtual-tracker host`.
2. Treat `OVR-VRC-OSC-Bridge` as the strongest donor in this wave for
   `config-defined input-to-OSC compiler`.
3. Keep `VMC2VMT` visible whenever `VR-apps-lab` needs a
   `protocol adapter into a stronger tracker platform`
   rather than another driver.
4. Keep `SkeletonPoseTester` visible whenever a future branch needs a tiny
   `skeletal-input validation utility`
   reference.
