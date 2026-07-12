# Wave 326 - KAT Walk Linux Locomotion Overlay and OpenXR Layer Split

This wave studies a fresh Linux KAT Walk utility that combines hardware sensor
decode, locomotion fusion, a wrist HUD, and an OpenXR implicit layer.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- treadmill and virtual-control helpers with overlay or OpenXR runtime paths;
- Linux daemon plus shared-memory plus OpenXR layer architectures;
- in-VR tuning HUDs for hardware locomotion;
- honest handling of empty/source-light candidates.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `BBPSBB/katwalk-linux` | Linux treadmill daemon, OpenXR layer, and in-VR HUD | Studied | Strong donor for USB sensor decode, locomotion fusion, body-relative stick output, shared-memory buses, OpenXR HUD composition, laser/click return path, and web/HUD tuning |
| `Kiichiuwu/WTVFSVR-war-thunder-virtual-flight-stick-for-vr` | Virtual flight-stick overlay placeholder | Empty/source-light | Repo cloned as empty; keep only as product-intent marker unless source appears |

## Code-Level Findings

### `BBPSBB/katwalk-linux`

- Interesting idea:
  a treadmill utility can avoid a SteamVR driver by splitting hardware decode
  into a Python daemon and using an OpenXR implicit layer for both thumbstick
  injection and an in-game wrist HUD.
- Code donor value:
  very high. `katwalk/daemon.py` reads the receiver, runs parser/locomotion
  fusion, serves a web tuner, records captures, and writes stick state.
  `katwalk/core/parser.py` documents byte offsets for body, foot, status,
  armband, and seat frames. `katwalk/core/locomotion.py` converts grounded foot
  slip into speed, direction, sprint/cruise state, cadence readout, and
  per-direction sensitivities. `katwalk/core/fusion.py` converts body heading
  and HMD yaw into head-relative stick vectors. `katwalk/overlay.py` keeps the
  HUD renderer pure Pillow and VR-API-free. `katwalk/overlay_xr.py` writes
  RGBA HUD frames to shared memory, reads laser/click events back, persists
  HUD placement in `hud.conf`, and calls daemon control endpoints. The
  `openxr-driver` layer reads shared memory, injects locomotion, uploads HUD
  frames, appends a quad, ray-casts controller aim, and returns hits/clicks.
- Product reference value:
  very high for hardware adapters, runtime helpers, overlay HUDs, and
  Linux/OpenXR-first utility architecture.
- What to inspect next:
  OpenXR layer lifecycle, multi-runtime compatibility, shared-memory schema
  versioning, input action coexistence, permissions around `/tmp/katwalk`, and
  the exact hook/interaction-profile handling in `layer.cpp`.
- Architecture pattern:
  `hardware daemon + core parser/fusion + shared-memory bus + pure HUD brain +
  OpenXR layer-owned display/input`.
- Reusable method:
  hardware sensor daemon with OpenXR HUD/layer split.
- UX pattern:
  wrist HUD with debug/sensor/setup tabs, recenter feedback, drag-to-place,
  face/distance gating, cursor-dot interaction, and live tuning sliders.
- Constraints / caveats:
  the repo states N=1 hardware validation and rough pre-alpha status; reuse
  should carry capability gates, per-device diagnostics, and schema versioning.
- Why it matters for `VR-apps-lab`:
  it is one of the clearest donors for an OpenXR overlay-like utility that does
  not depend on SteamVR overlays.

### `Kiichiuwu/WTVFSVR-war-thunder-virtual-flight-stick-for-vr`

- Interesting idea:
  a virtual flight stick with VR overlay is a relevant product direction for
  cockpit/control utilities.
- Code donor value:
  none at this pass; the repository cloned as empty.
- Product reference value:
  low until source appears.
- What to inspect next:
  re-check only if code, releases, or docs are added.
- Caveat:
  do not promote as donor without source evidence.

## Reusable Pattern Extraction

- Pattern candidate:
  hardware sensor daemon plus OpenXR HUD/layer split.
- Problem solved:
  hardware utilities need to ingest device data, tune algorithms, show status
  in VR, and inject runtime input without putting all logic inside the game
  process or depending on SteamVR overlays.
- Reusable core:
  hardware reader, parser, locomotion/control model, head/body fusion,
  daemon HTTP/control plane, shared-memory transport, pure renderer, OpenXR
  layer display/input bridge, placement config, and diagnostics/capture tools.
- Source evidence:
  `BBPSBB/katwalk-linux`.
- Abstraction boundary:
  keep hardware IO and tuning in the daemon, keep HUD drawing VR-API-free, and
  keep the OpenXR layer focused on runtime injection, composition, poses, and
  click transport.
- What not to copy:
  unversioned shared-memory contracts, N=1 hardware assumptions as general
  behavior, `/tmp` transport without sandbox notes, or hidden input injection
  without operator visibility.
- Method catalog action:
  add a new method for hardware daemon plus OpenXR HUD/layer utilities.

## Follow-Up Gaps

- Compare `katwalk-linux` and `Majed6/KATOXR` as two KAT/OpenXR donor patterns.
- Deepen OpenXR layer lifecycle and shared-memory schema if future prototypes
  use this approach.
- Re-check `WTVFSVR` only if it stops being an empty repo.
