# VR Projects Wave 70: Mixed-VR Controller Bridges, Hand Emulation, and External-Tracker Interop

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `mixed-VR controller bridges`, `hand emulation`, and
  `external-tracker interop`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of tracker bridges and several custom
driver paths, but it still lacked a clearer picture of
`how foreign controller and hand-input stacks get translated back into SteamVR`.

This wave exists to make that family clearer:

- mixed-runtime controller bridges that reuse official controller profiles;
- OpenHMD-based hardware mapping and controller-role assignment;
- named-pipe IPC drivers that spawn synthetic controllers and trackers;
- hand-tracking-to-controller emulation with declarative gesture mapping;
- PSVR-specific OpenHMD variants;
- thinner public repos whose product direction is stronger than their current
  code surface.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with mixed-VR bridge, hand-emulation, and synthetic
   controller-driver queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `mm0zct/Oculus_Touch_Steam_Link` | Strong mixed-runtime controller bridge donor |
| `ChristophHaag/SteamVR-OpenHMD` | Strong donor for OpenHMD-based controller and HMD mapping into SteamVR |
| `kodowiec/Yet-Another-OpenVR-IPC-Driver` | Strong donor for external-command synthetic controller and tracker lifecycle |
| `bdub1011/Quest-Link-Hand-Tracking` | Useful hand-emulation comparison node with declarative gesture config |
| `mSparks43/PSVR-SteamVR-openHMD` | Useful PSVR-specific OpenHMD variant and comparison donor |
| `krazysh01/VirtualDesktop-OpenVR-Trackers` | Honest thin public snapshot for a promising external-tracker bridge direction |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `Notnips/Meta-V66-Fixer` | Useful ecosystem signal, but weaker than the shortlisted repos for controller-bridge architecture lessons |

## Deep-pass notes by project

## `mm0zct/Oculus_Touch_Steam_Link`

- GitHub:
  [mm0zct/Oculus_Touch_Steam_Link](https://github.com/mm0zct/Oculus_Touch_Steam_Link)
- What it is:
  a mixed-VR bridge that keeps Oculus Touch devices and sensors alive while
  exposing them through a SteamVR driver for use with another HMD stack.
- Why it matters:
  it is the clearest donor in this wave for
  `foreign runtime controller bridge that still reuses native controller profiles and render models`.
- Interesting ideas:
  package helper executables next to the driver; let controllers present either
  as proper Oculus controllers or tracker-like objects; keep calibration and
  universe alignment as an explicit external workflow.
- Interesting implementation choices:
  `CustomHMD/OculusTouchLink.cpp`
  owns the provider shell and LibOVR-facing setup while
  `CustomHMD/TouchControllerDriver.h`
  shows role-specific controller properties, skeleton component creation, and
  the optional `be_objects` path that re-registers hands as tracker-like
  devices.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  packaging is rough and setup-heavy, but the mixed-runtime bridge pattern is
  unusually explicit.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `foreign controller runtime bridged back into SteamVR`
  donor.

## `ChristophHaag/SteamVR-OpenHMD`

- GitHub:
  [ChristophHaag/SteamVR-OpenHMD](https://github.com/ChristophHaag/SteamVR-OpenHMD)
- What it is:
  an OpenVR driver that maps OpenHMD devices into SteamVR and selectively
  assigns HMD, tracker, and controller roles.
- Why it matters:
  it is the clearest donor in this wave for
  `OpenHMD device mapping into SteamVR with role-aware controller setup`.
- Interesting ideas:
  make device selection explicit through config; reuse official Oculus
  controller profiles when possible; let vendor override and controller flags
  shape runtime behavior.
- Interesting implementation choices:
  `driver_openhmd.cpp`
  shows OpenHMD device discovery, property assignment, and controller setup,
  including vendor-specific profile selection and controller-hand role hints.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  older and Linux-oriented, but still one of the cleanest mixed-runtime bridge
  donors.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs an
  `OpenHMD-backed SteamVR bridge`
  donor.

## `kodowiec/Yet-Another-OpenVR-IPC-Driver`

- GitHub:
  [kodowiec/Yet-Another-OpenVR-IPC-Driver](https://github.com/kodowiec/Yet-Another-OpenVR-IPC-Driver)
- What it is:
  a named-pipe or socket driven OpenVR bridge driver that can spawn synthetic
  trackers and controllers and update their state from external commands.
- Why it matters:
  it is the clearest donor in this wave for
  `external-command synthetic controller and tracker host`.
- Interesting ideas:
  treat device lifecycle as commands; separate examples from the driver itself;
  support fixed-pose mode, full controller-state updates, and timing helpers.
- Interesting implementation choices:
  `driver/driver_files/src/Driver/VRDriver.cpp`
  exposes command parsing for `addcontroller`, `addtracker`, `setpose`,
  `updatepose`, `cbutton`, `caxis`, and timing sync while
  `driver/driver_files/src/Driver/ControllerDevice.cpp`
  shows how controller state and pose updates are translated into real OpenVR
  input components.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  pragmatic and bridge-oriented rather than polished, but unusually reusable.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `command-driven synthetic device bridge`
  donor.

## `bdub1011/Quest-Link-Hand-Tracking`

- GitHub:
  [bdub1011/Quest-Link-Hand-Tracking](https://github.com/bdub1011/Quest-Link-Hand-Tracking)
- What it is:
  a hand-tracking-to-controller-emulation project for Quest Link, with a
  public snapshot that currently exposes more configuration intent than
  implementation depth.
- Why it matters:
  it is still a useful donor for
  `gesture-configurable hand-to-controller mapping`,
  even though the public code surface is thin.
- Interesting ideas:
  keep gesture semantics declarative; define controller outputs in a config
  file; treat finger bends and arm swing as separate signals that can map onto
  trigger, grip, buttons, or joystick directions.
- Interesting implementation choices:
  `gesture_config/default_config.json`
  makes the mapping strategy explicit, while the public
  `driver_questhands/src/main.cpp`
  snapshot is currently too thin to promote as a fuller driver donor.
- Code donor value:
  low-medium.
- Product reference value:
  medium-high.
- Architecture reference value:
  low-medium.
- Caveats:
  public source remains thin and placeholder-heavy, so it should stay only
  partially promoted.
- What to inspect next:
  revisit only if the public repo grows a stronger actual driver surface.

## `mSparks43/PSVR-SteamVR-openHMD`

- GitHub:
  [mSparks43/PSVR-SteamVR-openHMD](https://github.com/mSparks43/PSVR-SteamVR-openHMD)
- What it is:
  a PSVR-specific OpenHMD bridge variant that extends the broader
  `SteamVR-OpenHMD` line with PSVR-related changes and adjacent helper code.
- Why it matters:
  it is a useful donor in this wave for
  `hardware-specific variant over a broader OpenHMD bridge`.
- Interesting ideas:
  keep the main OpenHMD bridge recognizable; add hardware-specific input and
  helper surfaces only where needed; let the fork remain close enough to the
  upstream bridge that the comparison stays readable.
- Interesting implementation choices:
  `driver_openhmd.cpp`
  keeps much of the upstream structure while the repo adds files such as
  `aitrack_udp.cpp`
  and
  `joystick.cpp`
  that show the variant's extra helper ambitions.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  medium-high.
- Caveats:
  still a variant line, but valuable enough now to promote beyond a purely
  shallow note.
- What to inspect next:
  keep it visible whenever a future branch needs a
  `hardware-specific OpenHMD bridge variant`
  comparison.

## `krazysh01/VirtualDesktop-OpenVR-Trackers`

- GitHub:
  [krazysh01/VirtualDesktop-OpenVR-Trackers](https://github.com/krazysh01/VirtualDesktop-OpenVR-Trackers)
- What it is:
  a tracker-bridge project whose product direction suggests stronger
  Virtual Desktop integration than the current public code snapshot actually
  shows.
- Why it matters:
  it is an honest comparison node for
  `promising product direction with a still-thin public driver surface`.
- Interesting ideas:
  repurpose a familiar tutorial-style driver scaffold for an external
  ecosystem's tracker flow; keep multiple device classes available even if the
  public bridge logic stays modest.
- Interesting implementation choices:
  the current public repo mainly shows a generic driver skeleton in
  `driver_files/src/Driver/*`
  without a stronger visible external-ingress layer.
- Code donor value:
  medium.
- Product reference value:
  medium.
- Architecture reference value:
  low-medium.
- Caveats:
  the repo still looks thinner than its product promise, so it should remain
  only partially promoted.
- What to inspect next:
  revisit only if the public repo grows clearer ingress, tracker-role mapping,
  or Virtual Desktop-specific state flow.

## Main takeaways from Wave 70

- `mixed-VR controller interop` splits more cleanly into:
  - `foreign runtime bridge reusing native controller profiles`
  - `OpenHMD-based device mapper`
  - `command-driven synthetic controller and tracker host`
  - `gesture-configurable hand emulator`
  - `hardware-specific OpenHMD variant`
  - `thin public bridge snapshot with stronger product direction than code surface`
- The strongest lesson from this wave is that
  `controller bridge`
  work is as much about property, profile, and render-model reuse as it is
  about pose transport.
- Another strong lesson is that some repos are valuable precisely because they
  show how much product framing can outpace the public code surface. That
  honesty matters for `VR-apps-lab`.

## Reusable methods clarified by this wave

- `Mixed-VR bridge that reuses official controller profiles and render models while sourcing pose or input from another runtime`
- `External-command synthetic-device driver with named-pipe or socket command grammar, state updates, and fixed-pose fallback`
- `Declarative hand-gesture mapping into SteamVR controller semantics through per-action config`

## Recommended next moves after this wave

1. Treat `Yet-Another-OpenVR-IPC-Driver` as the clearest donor in this wave
   for a `command-driven synthetic controller and tracker host`.
2. Treat `Oculus_Touch_Steam_Link` and `SteamVR-OpenHMD` as the strongest
   donors here for `foreign runtime bridged back into SteamVR`.
3. Keep `Quest-Link-Hand-Tracking` visible as a
   `gesture-configurable hand emulator`
   reference, but only with honest caution about the thin public source.
4. Keep `VirtualDesktop-OpenVR-Trackers` visible as a product-direction node
   while its public code remains comparatively sparse.
