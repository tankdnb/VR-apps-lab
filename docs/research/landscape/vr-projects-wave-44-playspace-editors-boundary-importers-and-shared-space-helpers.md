# VR Projects Wave 44: Playspace Editors, Boundary Importers, and Shared-Space Helpers

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `playspace editors`, `chaperone and guardian tooling`, and
  `shared-space helpers`.

## Why this wave exists

`VR-apps-lab` already had calibration, motion-compensation, and tracker-space
research, but one closely related room-space branch was still too diffuse:

- tools that author or edit room boundaries directly;
- utilities that import vendor boundary data into SteamVR;
- runtime-side playspace movers and zero-pose manipulators;
- peer-space helpers that make a shared physical space visible inside VR.

This wave exists to make
`playspace editing, boundary import, and shared-space helpers`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with chaperone, guardian, and playspace-tool queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `Xavr0k/ChaperoneTweak` | Strong donor for an in-headset chaperone editor that directly manipulates walls and playspace geometry |
| `FrostyCoolSlug/xr-chaperone` | Strong donor for a desktop setup wizard paired with a headless runtime-side boundary service |
| `Sgeo/Guardian2Chaperone` | Focused donor for importing Oculus Guardian geometry into SteamVR chaperone state |
| `hai-vr/unity-chaperone-tweaker` | Focused donor for Unity-editor workflows over raw `.vrchap` files |
| `Rafacasari/Playspace-Mover` | Strong donor for controller-driven runtime playspace offsets in an existing VR app |
| `mdovgialo/OpenVRSharedPlayspace` | Narrow but valuable donor for LAN peer visualization in a shared physical space |
| `LIV/RotatoExpress` | Strong donor for live playspace rotation with safe restore and zero-pose management |

## Secondary candidates surfaced in the same wave

No secondary candidate in this wave was stronger than the frozen shortlist.

## Deep-pass notes by project

## `Xavr0k/ChaperoneTweak`

- GitHub:
  [Xavr0k/ChaperoneTweak](https://github.com/Xavr0k/ChaperoneTweak)
- What it is:
  a Unity and OpenVR in-headset editor for SteamVR chaperone walls and
  playspace geometry.
- Why it matters:
  it is the clearest donor in the repo for
  `live in-headset chaperone editing over the working copy`.
- Interesting ideas:
  treat walls and playspace as directly grabbable geometry; use controller
  laser hit-zones to multiplex edit actions; keep wall split, delete, height,
  edge, and pivot operations in one headset-first editor.
- Interesting implementation choices:
  `ChaperoneElements.cs`,
  `ControllerInput.cs`, and
  `LaserPointer.cs`
  make the `laser target -> edit mode -> OpenVR chaperone working copy` flow
  explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  it is tightly tied to older Unity and SteamVR plugin assumptions, but the
  authoring model is still reusable.
- What to inspect next:
  keep it visible whenever a future branch needs an
  `in-headset room-boundary editor` rather than a desktop-only setup flow.

## `FrostyCoolSlug/xr-chaperone`

- GitHub:
  [FrostyCoolSlug/xr-chaperone](https://github.com/FrostyCoolSlug/xr-chaperone)
- What it is:
  an OpenXR room-boundary tool with a monitor-side setup UI and a headless
  service mode for later runtime use.
- Why it matters:
  it is the clearest donor in the repo for
  `desktop setup wizard plus runtime-side boundary service`.
- Interesting ideas:
  separate setup-time room authoring from runtime boundary rendering; keep the
  service reusable after setup; compute boundary visibility from signed distance
  to a polygon instead of only drawing a static fence.
- Interesting implementation choices:
  `src/main.rs` and
  `src/boundary.rs`
  make the `config load -> setup or service mode -> polygon distance and fade`
  flow explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  Monado and Linux assumptions narrow direct reuse, but the split is strong.
- What to inspect next:
  keep it visible whenever a future branch needs a
  `room setup on desktop, service in headset` product shape.

## `Sgeo/Guardian2Chaperone`

- GitHub:
  [Sgeo/Guardian2Chaperone](https://github.com/Sgeo/Guardian2Chaperone)
- What it is:
  a focused utility that reads Oculus Guardian data and writes it into SteamVR
  chaperone state.
- Why it matters:
  it is the clearest donor in the repo for
  `vendor boundary import into another runtime's room model`.
- Interesting ideas:
  use one ecosystem's room setup as the authoring surface for another; derive
  standing origin and play area from imported points; hide SteamVR's default
  collision bounds after import when appropriate.
- Interesting implementation choices:
  `main.cpp`
  makes the `read Guardian -> compute origin and bounds -> write live
  chaperone config` path explicit.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  historically specific and partly obsolete, but still valuable as an import
  pattern donor.
- What to inspect next:
  keep it visible whenever a future branch needs
  `boundary transfer between runtimes`.

## `hai-vr/unity-chaperone-tweaker`

- GitHub:
  [hai-vr/unity-chaperone-tweaker](https://github.com/hai-vr/unity-chaperone-tweaker)
- What it is:
  a Unity Editor tool for loading, visualizing, editing, and overwriting
  `chaperone_info.vrchap` universes.
- Why it matters:
  it is the clearest donor in the repo for
  `editor-time tooling over raw chaperone files`.
- Interesting ideas:
  move file editing into a familiar scene-editor workflow; select universes
  explicitly; represent boundary vertices as simple scene objects; overwrite the
  raw asset only after manual adjustment.
- Interesting implementation choices:
  `ChaperoneTweakerEditor.cs`
  loads universes, spawns editable points, and rewrites wall JSON after
  manipulation.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium-high.
- Caveats:
  it is primarily an authoring donor, not a runtime tool.
- What to inspect next:
  keep it visible whenever a future branch needs
  `Unity-editor-first room-boundary tooling`.

## `Rafacasari/Playspace-Mover`

- GitHub:
  [Rafacasari/Playspace-Mover](https://github.com/Rafacasari/Playspace-Mover)
- What it is:
  a MelonLoader mod that repositions Oculus tracking space through controller
  motion in VRChat.
- Why it matters:
  it is the clearest donor in the repo for
  `runtime local playspace offset manipulation via controller deltas`.
- Interesting ideas:
  do not own the whole runtime; patch an existing VR app and move only the local
  tracking space; make the interaction simple enough to live behind a held
  button and a double-click reset.
- Interesting implementation choices:
  `Main.cs`
  waits for the VRChat UI and camera rig, then applies controller-delta changes
  to `trackingSpace.localPosition`.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium-high.
- Caveats:
  app-specific assumptions narrow direct reuse, but the local offset method is
  strong.
- What to inspect next:
  keep it visible whenever a future branch needs a
  `thin runtime patch that manipulates only local room offsets`.

## `mdovgialo/OpenVRSharedPlayspace`

- GitHub:
  [mdovgialo/OpenVRSharedPlayspace](https://github.com/mdovgialo/OpenVRSharedPlayspace)
- What it is:
  a narrow Python utility that broadcasts local headset pose over LAN and
  visualizes remote peers as OpenVR overlays in a shared room.
- Why it matters:
  it is the clearest donor in the repo for
  `shared physical space awareness over lightweight LAN broadcast`.
- Interesting ideas:
  use a small UDP broadcast protocol instead of a heavy session stack; bind peer
  identity to host and user names; render peer presence as overlays with
  distance-based alpha.
- Interesting implementation choices:
  `openvr_shared_playspace/__init__.py`
  makes the `poll local pose -> broadcast -> receive peer pose -> update overlay
  transform and fade` flow explicit.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium-high.
- Caveats:
  narrow scope and lightweight presentation, but that narrowness is also the
  strength.
- What to inspect next:
  keep it visible whenever a future branch needs
  `peer visibility in a shared room without a full networking stack`.

## `LIV/RotatoExpress`

- GitHub:
  [LIV/RotatoExpress](https://github.com/LIV/RotatoExpress)
- What it is:
  a small OpenVR utility app that rotates or offsets playspace transforms live
  for mixed-reality capture workflows.
- Why it matters:
  it is the clearest donor in the repo for
  `live playspace transform manipulation with safe restore`.
- Interesting ideas:
  cache launch-time room transforms; expose live rotation and offsets; commit
  changes on the fly; restore the original room state on exit.
- Interesting implementation choices:
  `src/App.cpp`
  uses OpenVR as a utility app and writes standing or seated zero-pose changes
  back through `VRChaperoneSetup()->CommitWorkingCopy`.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  aimed at capture workflows, but the transform-management pattern generalizes.
- What to inspect next:
  keep it visible whenever a future branch needs
  `temporary room transform overrides with explicit restore semantics`.

## Main takeaways from Wave 44

- `Room-space tooling` is now a distinct family, not just a side note inside
  calibration and motion compensation.
- The strongest split in this family is:
  - `in-headset live chaperone editor`
  - `desktop setup plus runtime boundary service`
  - `vendor boundary import tool`
  - `Unity editor over raw chaperone files`
  - `runtime local playspace mover`
  - `LAN shared-space peer overlay`
  - `live zero-pose rotator with restore`
- The most reusable lesson is that room-space tools work best when they
  separate `boundary authoring`, `transform manipulation`, and
  `shared-space awareness` instead of collapsing all of them into a generic
  `recenter` bucket.
