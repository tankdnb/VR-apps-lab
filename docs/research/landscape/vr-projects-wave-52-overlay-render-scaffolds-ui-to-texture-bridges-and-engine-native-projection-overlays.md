# VR Projects Wave 52: Overlay Render Scaffolds, UI-to-Texture Bridges, and Engine-Native Projection Overlays

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `overlay render scaffolds`, `UI-to-texture bridges`, and
  `engine-native projection-overlay extensions`.

## Why this wave exists

`VR-apps-lab` already had overlay hosts and finished utility products, but one
construction branch still needed cleaner donor coverage:

- tiny overlay samples that expose the shortest texture-submission path;
- `ImGui` or immediate-mode UI overlays that translate `OpenVR` events back
  into UI input;
- engine-native extensions that let a normal 3D scene render as a
  projection-overlay app;
- helper libraries that remove repeated `OpenVR overlay` boilerplate.

This wave exists to make
`overlay render scaffolds, UI-to-texture bridges, and engine-native projection overlays`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with `OpenVR overlay`, `ImGui overlay`, `Godot overlay`, and
   Unity-helper queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `foxt/csharp-openvr-overlay-imgui` | Strong donor for a C# overlay host that forwards `OpenVR` input into Dear ImGui and also carries a desktop-duplication experiment |
| `hiinaspace/godot-openvr-overlay` | Strong donor for a Godot-native projection-overlay extension with tracker poses, actions, and stereo submission |
| `ondorela/OpenVROverlay_imgui` | Focused donor for a small D3D11 plus ImGui dashboard overlay sample |
| `thomasmo/SampleVRO` | Strong donor for a Win32 plus D3D11 overlay sample with explicit mouse and controller forwarding |
| `ovrlay/LibOverlay` | Tiny but useful donor for a Unity helper that wraps handle lifecycle, tracked-device attachment, and texture submission |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `Marlamin/VROverlayTest` | Another thin D3D11 scratchpad, but the frozen shortlist already covered clearer event-forwarding and engine-extension lessons |
| `ephemeral-laboratories/ComposeVR` | Intriguing `Compose -> overlay` prototype, but still too cursed and thin to outrank the stronger scaffold donors in this wave |

## Deep-pass notes by project

## `foxt/csharp-openvr-overlay-imgui`

- GitHub:
  [foxt/csharp-openvr-overlay-imgui](https://github.com/foxt/csharp-openvr-overlay-imgui)
- What it is:
  a C# multi-project overlay playground centered on Dear ImGui, with an
  `OverlayApp`, a desktop duplication path, and optional helpers like keyboard
  auto-show.
- Why it matters:
  it is one of the clearest donors in the repo for
  `C# overlay host with ImGui input forwarding and debug-window parity`.
- Interesting ideas:
  keep a fake windowed view for debugging while the same app can render into
  `OpenVR`; treat keyboard visibility as part of overlay UX; keep desktop
  duplication as an adjacent experiment instead of mixing it into the core
  overlay loop.
- Interesting implementation choices:
  `DearOVRlay/OverlayApp.cs`
  makes the `overlay lifecycle -> render callback -> event forwarding` path
  explicit, while
  `DesktopDuplicationOverlay/DesktopDuplicationOverlay.cs`
  shows a separate DXGI desktop-duplication path.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  still a playground-style repo, but the split between host, input bridge, and
  optional desktop capture is already very reusable.
- What to inspect next:
  keep it visible whenever a future branch needs
  `C# OpenVR host + ImGui + OpenVR event translation`.

## `hiinaspace/godot-openvr-overlay`

- GitHub:
  [hiinaspace/godot-openvr-overlay](https://github.com/hiinaspace/godot-openvr-overlay)
- What it is:
  a Godot 4 extension that exposes an `OpenVR Overlay` XR interface so a normal
  Godot scene can render as a projective overlay on top of another VR app.
- Why it matters:
  it is the clearest donor in the repo for
  `engine-native projection-overlay extension over an existing scene graph`.
- Interesting ideas:
  expose playspace origin, controller poses, and actions through the engine's
  XR interface; submit rendered scene content as projection overlays instead of
  owning the main scene application; keep the addon self-contained and enable
  it like a normal Godot plugin.
- Interesting implementation choices:
  `src/xr_interface_openvr_overlay.cpp`
  makes the `tracker update -> input action sampling -> eye submission ->
  projection-overlay configuration` flow explicit, including the right-eye blit
  workaround for Godot's array textures.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  tightly tied to `Godot 4` and `SteamVR/OpenVR`, but that specialization is
  also what makes it valuable as a donor.
- What to inspect next:
  keep it visible whenever a future branch needs
  `scene-native overlay rendering` instead of browser or desktop mirroring.

## `ondorela/OpenVROverlay_imgui`

- GitHub:
  [ondorela/OpenVROverlay_imgui](https://github.com/ondorela/OpenVROverlay_imgui)
- What it is:
  a focused sample that renders Dear ImGui through a Win32 plus Direct3D 11
  path and submits the resulting backbuffer as an `OpenVR` dashboard overlay.
- Why it matters:
  it is a compact donor for
  `D3D11 backbuffer -> overlay texture -> ImGui event bridge`.
- Interesting ideas:
  keep the overlay sample almost entirely in one file; translate overlay mouse
  events back into ImGui's Win32 input path; use a normal D3D11 swapchain-like
  flow and only treat `OpenVR` as a final submit target.
- Interesting implementation choices:
  `OpenVROverlay_imgui/OpenVROverlay_imgui.cpp`
  makes the `device init -> ImGui init -> overlay event translation -> texture
  submit` flow explicit.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  medium-high.
- Caveats:
  the repo vendors a lot of upstream ImGui material, so the real donor value is
  concentrated in the small custom overlay glue rather than the whole tree.
- What to inspect next:
  keep it visible whenever a future branch needs the thinnest possible
  `ImGui dashboard sample` on `D3D11`.

## `thomasmo/SampleVRO`

- GitHub:
  [thomasmo/SampleVRO](https://github.com/thomasmo/SampleVRO)
- What it is:
  a Win32 plus Direct3D 11 sample that uses an ordinary application texture as
  an `OpenVR` overlay source while forwarding controller input as mouse events.
- Why it matters:
  it is one of the clearest donors in the repo for
  `window app -> shared texture -> overlay surface -> forwarded input`.
- Interesting ideas:
  explicitly separate the main app window, draw process, and `OpenVR` process;
  forward keyboard and controller interaction back into the drawing app; keep a
  disk-write debug path for the texture being submitted.
- Interesting implementation choices:
  `SampleVRO/SampleVRO.cpp`
  exposes the `main window -> draw window -> OpenVR window` split and the
  mouse-event forwarding path very clearly.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  older Windows-specific sample style, but still unusually explicit about the
  boundaries that many higher-level repos hide.
- What to inspect next:
  keep it visible whenever a future branch needs
  `Win32 or D3D11 overlay interop` rather than a full engine wrapper.

## `ovrlay/LibOverlay`

- GitHub:
  [ovrlay/LibOverlay](https://github.com/ovrlay/LibOverlay)
- What it is:
  a tiny Unity-oriented helper library that wraps overlay handle creation,
  texture updates, tracked-device attachment, and transform syncing.
- Why it matters:
  it is a compact donor for
  `thin Unity helper over raw OpenVR overlay calls`.
- Interesting ideas:
  reduce the common overlay lifecycle into one class; let a Unity `Transform`
  or tracked device drive the overlay pose; keep the entry path small enough to
  copy into future experiments.
- Interesting implementation choices:
  `Overlay.cs`
  makes the `overlay handle -> tracked-device attachment -> texture refresh ->
  transform update` path explicit.
- Code donor value:
  medium-high.
- Product reference value:
  low-medium.
- Architecture reference value:
  medium.
- Caveats:
  intentionally tiny and older, so it is strongest as a helper pattern, not a
  whole product reference.
- What to inspect next:
  keep it visible whenever a future branch needs
  `minimal Unity overlay wrapper` instead of a richer host.

## Main takeaways from Wave 52

- `Overlay construction` is clearer when split into:
  - `tiny sample with explicit texture path`
  - `UI-to-texture bridge with event forwarding`
  - `engine-native projection-overlay extension`
  - `thin helper library over raw OpenVR calls`
- The strongest donor in this wave is not a finished product but the
  `construction boundary` itself:
  - where the texture comes from
  - where `OpenVR` events get translated
  - where engine abstractions end and overlay APIs begin

## Reusable methods clarified by this wave

- `Engine-native projection-overlay extension over an existing scene graph`
- `Offscreen UI stack bridged into an overlay texture with OpenVR event forwarding`

## Recommended next moves after this wave

1. Keep `godot-openvr-overlay` visible whenever `VR-apps-lab` needs
   `projection overlays from engine-native scenes`.
2. Treat `csharp-openvr-overlay-imgui`, `OpenVROverlay_imgui`, and `SampleVRO`
   as the main thin donors for `window/UI -> texture -> overlay` glue.
3. Keep `LibOverlay` as the smallest Unity-side helper reference, not as a
   product benchmark.
