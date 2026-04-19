# VR Projects Wave 62: Desktop-Adjacent Companion Overlays, Phone Bridges, and Media or Text Control Surfaces

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `desktop-adjacent companion overlays`, `phone bridges`, and
  `media or text control surfaces`.

## Why this wave exists

The overlay corpus in `VR-apps-lab` already had media shells, creator panels,
and communication surfaces, but another nearby product line still needed a
clearer donor map:

- overlays that proxy an external device or desktop workflow;
- small stateful surfaces that depend on local bridges or external metadata;
- narrow operator tools that send text or other tiny payloads into VR.

This wave exists to make
`desktop-adjacent companion overlays, phone bridges, and media or text control surfaces`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with phone-bridge, volume-overlay, desktop-proxy, and
   text-surface queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `happysmash27/OVR_SLDO` | Extremely small donor for a Linux root-window desktop overlay path |
| `Desuuuu/OVRPhoneBridge` | Strong donor for an encrypted phone companion overlay with notifications, SMS, keyboard, and Qt UI |
| `adks3489/ViveOverlayPaster` | Focused donor for a desktop operator tool that turns pasted text into an overlay |
| `Wulkop/VolumeVR` | Useful but partial donor for a `CEF`-based volume or media shell whose public repo exposes runtime bootstrapping more clearly than full overlay behavior |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `emymin/EmyOverlay` | Public donor surface still too thin to justify promotion beyond a follow-up node |

## Deep-pass notes by project

## `happysmash27/OVR_SLDO`

- GitHub:
  [happysmash27/OVR_SLDO](https://github.com/happysmash27/OVR_SLDO)
- What it is:
  a small Linux desktop overlay experiment built around `X11`, shared-memory
  framebuffers, and the root window as the captured source.
- Why it matters:
  it is a lower-bound donor for
  `desktop proxy surface on Linux without a heavyweight runtime shell`.
- Interesting ideas:
  keep the desktop source simple by using the root window first; expose the
  framebuffer mechanics and timing measurements directly; keep the repo small
  enough that the capture path itself remains readable.
- Interesting implementation choices:
  `desktopview.c`
  shows the shared-memory framebuffer setup, root-window capture via `xcb_shm`,
  multiple sub-buffers, and timing instrumentation instead of hiding the
  desktop-capture cost.
- Code donor value:
  medium.
- Product reference value:
  low-medium.
- Architecture reference value:
  medium.
- Caveats:
  clearly unfinished and focused on capture bring-up more than a polished VR
  UI.
- What to inspect next:
  keep it visible whenever a future Linux overlay branch needs a very small
  desktop-capture lower bound.

## `Desuuuu/OVRPhoneBridge`

- GitHub:
  [Desuuuu/OVRPhoneBridge](https://github.com/Desuuuu/OVRPhoneBridge)
- What it is:
  a `Qt`-based SteamVR phone companion overlay that mirrors notifications,
  exposes SMS workflows, and communicates with the phone through encrypted TCP.
- Why it matters:
  it is the clearest donor in the repo for
  `secure phone-companion bridge feeding a stateful overlay shell`.
- Interesting ideas:
  use encryption as a default boundary; keep phone capability negotiation
  explicit; pair the overlay with tabs, notifications, and keyboard support
  rather than treating the phone as a one-way feed.
- Interesting implementation choices:
  `src/client.cpp`
  exposes the encrypted handshake and message flow,
  `src/bridge.cpp`
  defines the JSON message contract for notifications and SMS, and
  `src/openvr/overlay_controller.cpp`
  handles OpenGL setup, overlay events, notifications, and SteamVR keyboard
  integration inside the overlay shell.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  phone-specific and heavier than a micro-overlay, but very strong for the
  `companion overlay plus external device` family.
- What to inspect next:
  treat it as a main donor whenever a future branch needs
  `secure external-device companion overlay`.

## `adks3489/ViveOverlayPaster`

- GitHub:
  [adks3489/ViveOverlayPaster](https://github.com/adks3489/ViveOverlayPaster)
- What it is:
  a Windows Forms helper that lets the operator type or paste text on desktop,
  turns that text into a bitmap, and sends the result into a small HMD-relative
  SteamVR overlay.
- Why it matters:
  it is a focused donor for
  `desktop operator pushes small text or notification surface into VR`.
- Interesting ideas:
  keep the interaction desktop-first; generate the overlay image on demand;
  store placement and style in local config instead of building a larger host.
- Interesting implementation choices:
  `ViveOverlayPaster/Form1.cs`
  creates the overlay, reads style and transform from app config, rasterizes the
  message into a bitmap, uploads it into an OpenGL texture, and pushes that
  texture into `OpenVR`.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  small and old-school in implementation style, but exactly because of that it
  clarifies a useful micro-tool product shape.
- What to inspect next:
  keep it visible whenever a future branch needs a tiny
  `desktop authoring surface -> transient overlay` donor.

## `Wulkop/VolumeVR`

- GitHub:
  [Wulkop/VolumeVR](https://github.com/Wulkop/VolumeVR)
- What it is:
  a `CEF`-backed volume-control shell whose public repo mostly exposes the
  browser-runtime boot path rather than the full overlay logic.
- Why it matters:
  even in this incomplete state it helps mark a narrower branch between
  `browser-backed overlay runtime` and `focused media or volume control shell`.
- Interesting ideas:
  use browser technology for a small control surface rather than a whole
  runtime platform; keep the `CEF` child-process bootstrap explicit.
- Interesting implementation choices:
  `src/gui/Gui.cpp`
  and
  `src/gui/internal/WebApp.cpp`
  show the `CEF` initialization pattern and child-process split, even though
  the broader overlay surface is not exposed clearly enough in the current
  public snapshot.
- Code donor value:
  medium.
- Product reference value:
  medium.
- Architecture reference value:
  medium.
- Caveats:
  only partially surfaced in the current repo and better treated as a partial
  node than a promoted main donor.
- What to inspect next:
  revisit only if a future pass needs the exact `browser shell over narrow
  device/media control` comparison.

## Main takeaways from Wave 62

- `Companion overlays` split more cleanly into:
  - `Linux desktop proxy surface`
  - `secure phone companion overlay`
  - `desktop-authored text micro-tool`
  - `browser-based media or volume shell`
- The strongest lesson from this wave is that
  `desktop-adjacent overlay`
  is a meaningful product family of its own. These tools are not full overlay
  runtimes and not just tiny HUD widgets; they are stateful companions for an
  external workflow.
- Another strong lesson is that even very small operator tools can matter when
  they show a clear `author on desktop, surface in VR` pattern.

## Reusable methods clarified by this wave

- `Secure companion bridge that feeds a tabbed overlay shell over encrypted local networking`
- `Desktop-authored text or image micro-overlay generated on demand from local UI state`

## Recommended next moves after this wave

1. Treat `OVRPhoneBridge` as the main donor for
   `secure companion overlay over an external device`.
2. Keep `ViveOverlayPaster` visible whenever `VR-apps-lab` needs a tiny
   `operator pushes content into VR` reference.
3. Keep `OVR_SLDO` visible as a Linux lower-bound desktop-proxy node.
4. Keep `VolumeVR` as a partial comparison node rather than over-promoting the
   current public donor surface.
