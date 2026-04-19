# VR Projects Wave 32: Social Overlays, Communication Sidecars, and VRChat Companion Surfaces

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `social overlays`, `communication sidecars`, and
  `VRChat-facing companion surfaces`.

## Why this wave exists

Many repositories in `VR-apps-lab` already cover notifications, dashboards,
and accessibility tools, but they do not yet give enough weight to another
important utility branch:

- VR surfaces for ongoing chat or voice presence;
- sidecars that convert `desktop social services` into `OSC`, `WebSocket`, or
  overlay outputs;
- companion utilities that are closer to communication workflows than to
  ordinary system dashboards.

This wave exists to make `social and communication tooling for VR` a clearer
family inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with Discord overlay, Twitch OSC chat, VRChat proximity, and
   local speech-sidecar queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `designeerlabs/discord-vr` | Strong donor for a browser-automation sidecar that turns a social service into a prefab-driven OpenVR overlay |
| `kittynXR/VRCattoChatto` | Strong donor for a desktop-native chat companion with dual `OSC` and Twitch outputs |
| `Wolf-G88/vrchat-proximity-app` | Valuable hybrid donor for a `computer-vision engine + OSC core + optional overlay control surface` |
| `Sharrnah/whispering` | Best broad comparison donor for a local speech platform whose VR value comes from `OSC` and `WebSocket` fan-out rather than a single overlay |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `MeroFune/GOpy` | Still useful as a comparison node for desktop-to-VR integration helpers, but it did not add enough new communication-surface detail to displace the stronger mainline donors in this wave |

## Deep-pass notes by project

## `designeerlabs/discord-vr`

- GitHub:
  [designeerlabs/discord-vr](https://github.com/designeerlabs/discord-vr)
- What it is:
  a Unity-based OpenVR companion app that overlays Discord voice state inside
  VR.
- Why it matters:
  it is the clearest donor in the repo for
  `browser-automation sidecar feeding a prefab-driven social overlay`.
- Interesting ideas:
  let a desktop automation layer own the social-service scraping while the VR
  surface stays focused on presence and controls; expose attachment, alignment,
  opacity, and scale as user-facing overlay settings instead of hardcoding a
  single pose.
- Interesting implementation choices:
  `Assets/Scripts/ServerManager.cs`,
  `Assets/Scripts/DiscordUserManager.cs`, and
  `Assets/Scripts/UIManager.cs` make the server-refresh loop, user lifecycle,
  and attachment UX very visible.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  browser automation adds maintenance risk, but the split between
  `service scraping` and `overlay presentation` is still a valuable pattern.
- What to inspect next:
  keep it as the best communication-overlay reference whenever a future tool
  needs to turn a non-XR social service into a VR-facing presence surface.

## `kittynXR/VRCattoChatto`

- GitHub:
  [kittynXR/VRCattoChatto](https://github.com/kittynXR/VRCattoChatto)
- What it is:
  a UWP chat companion that bridges Twitch chat and `OSC` in a desktop-native
  surface meant to behave like a lightweight VR-adjacent utility.
- Why it matters:
  it is the strongest donor in the repo for
  `native chat companion with dual-output social and OSC sinks`.
- Interesting ideas:
  keep the app small; let Twitch and OSC be independently toggled outputs;
  persist auth and broadcaster identity locally; expose typing state and
  character-count UX instead of treating chat as a raw message box.
- Interesting implementation choices:
  `MainPage.xaml.cs` makes the `UWP UI -> Twitch client -> OSC sender`
  relationship explicit, including localhost `OSC` defaults and local-settings
  persistence.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium.
- Caveats:
  tied to a niche Windows app model, but the
  `native companion surface + dual output targets` lesson generalizes well.
- What to inspect next:
  keep it as a product reference whenever a future tool needs a tiny desktop
  companion that can talk both to a social platform and to VR-side consumers.

## `Wolf-G88/vrchat-proximity-app`

- GitHub:
  [Wolf-G88/vrchat-proximity-app](https://github.com/Wolf-G88/vrchat-proximity-app)
- What it is:
  a hybrid proximity and interaction sidecar for VRChat built around an engine,
  `OSC` integration, and an optional SteamVR overlay surface.
- Why it matters:
  it is the clearest donor in the repo for
  `computer-vision or proximity engine with OSC core and overlay controls as an optional layer`.
- Interesting ideas:
  keep the real logic in the proximity engine; use `OSC` as the main VRChat
  transport; treat the SteamVR overlay as a control or visibility surface
  rather than the whole product.
- Interesting implementation choices:
  `src/integration/steamvr_overlay.py` and
  `src/integration/vrchat_osc.py` expose the split between overlay lifecycle,
  avatar-parameter intake, and the underlying proximity engine.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  larger than a micro-utility and still shaped by the original VRChat use case.
- What to inspect next:
  compare it directly with future `overlay-optional sidecars` where the real
  value lives in the service layer and the in-VR UI is intentionally thin.

## `Sharrnah/whispering`

- GitHub:
  [Sharrnah/whispering](https://github.com/Sharrnah/whispering)
- What it is:
  a large local speech, translation, and assistant platform with `OSC` and
  `WebSocket` outputs that can feed VR workflows among many other consumers.
- Why it matters:
  it is the strongest comparison donor in the repo for
  `broad local speech platform whose VR value comes from multi-consumer fan-out`.
- Interesting ideas:
  keep the speech stack local; fan results out through `OSC`, `WebSocket`,
  text, playback, and plugin layers; allow VR integrations to be consumers of a
  broader speech platform instead of making VR the whole product.
- Interesting implementation choices:
  `VRC_OSCServer.py` and `websocket.py` make the async OSC listener, avatar
  parameter intake, websocket broker, and output distribution boundaries easy
  to inspect.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  broad enough that the current pass should be treated as `Partially studied`
  rather than as a closed exhaustive read.
- What to inspect next:
  narrow the next pass to plugin ownership, overlay-facing surfaces, and which
  slices matter most for future VR utility work.

## Main takeaways from Wave 32

- `Communication utilities in VR` are now a distinct family, not just a side
  effect of accessibility overlays or notification tools.
- The strongest split in this family is:
  - `voice-presence overlay`
  - `desktop-native chat companion`
  - `service-heavy social sidecar with optional overlay`
  - `broad speech platform with VR-facing outputs`
- The most reusable lesson is often `transport fan-out and UX framing`, not the
  original chat platform:
  - `OSC`
  - `WebSocket`
  - browser automation
  - dual-output companion surfaces
  - optional overlay controls on top of a larger service.

## Reusable methods clarified by this wave

- `Browser-automation sidecar that turns a social service into a VR overlay surface`
- `Native chat companion with dual social-service and OSC outputs`
- `Service-heavy communication utility where the overlay is only one consumer`

## Recommended next moves after this wave

1. Treat `discord-vr` as the best focused donor for
   `social overlay with attach and alignment UX`.
2. Keep `VRCattoChatto` as a product reference for a tiny desktop companion
   that talks both to social services and to VR-side `OSC` consumers.
3. Use `vrchat-proximity-app` whenever a future tool needs a
   `service-first sidecar with optional overlay controls`.
4. Keep `whispering` visible as a broader platform donor whose next pass should
   narrow the relevant VR slices instead of trying to absorb the whole app at
   once.
