# VR Projects Wave 208: Overlay Media Micro-Surfaces, Notes, Browser Shells, and Direct Video Overlays

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-208-plan.md`
- `docs/research/program/github-research-wave-208-backlog.md`

Research mode: static source reading only. No external repository was run, built, installed, or launched.

## Why This Wave Matters

The useful lesson in this wave is not "which media overlay should we use". The reusable lesson is the minimum plumbing required to turn a surface producer into a VR overlay: initialize OpenVR as an overlay app, create the overlay handle, choose where the overlay lives, feed it an image/texture/render target, and decide how input and lifetime are handled.

The projects are uneven, but together they define a practical lower-bound map for future overlay utilities.

## Project Findings

### `Yukiiro-Nite/notebook-vr-overlay`

- Interesting idea: a note-like VR overlay can start as a single image surface attached to a tracked device, with mouse input and event polling added before a full drawing model exists.
- Code donor value: low to medium. `src/notebook-vr-overlay.cpp` shows `VRApplication_Overlay`, `CreateOverlay`, `SetOverlayFromFile`, `SetOverlayInputMethod(Mouse)`, `SetOverlayMouseScale`, `SetOverlayTransformTrackedDeviceRelative`, and a basic mouse/quit event loop.
- Product reference value: medium as a lower-bound "VR sticky note" surface, especially because the comments expose the missing pieces: drawing, persistence, and non-hardcoded placement.
- Architecture pattern: single-process overlay bootstrap with direct OpenVR calls and no separate renderer/service layer.
- Reusable method: use a static or generated image surface as the first integration milestone before building a full interactive note editor.
- Constraints and caveats: hardcoded image path, hardcoded tracked-device index, incomplete drawing flow, and no persistence model.
- What to inspect next: whether any related forks add text editing, controller placement, save/load, or dashboard controls.
- Why it matters for `VR-apps-lab`: it keeps the note-overlay branch grounded in a minimal event/placement model instead of starting from a heavy app shell.

### `Daniel-Webster/WT-OpenVR-Overlay`

- Interesting idea: combine a Unity overlay host with a local telemetry service, typed JSON polling, render textures, dashboard thumbnails, and OpenVR mouse input routing.
- Code donor value: high for Unity overlay shell structure. `Assets/OVRLay/Scripts/Unity_Overlay.cs` centralizes overlay width, opacity, render texture source, dashboard thumbnail, texture bounds, tracked-device placement, and UI mouse interaction. `Unity_SteamVR_Handler.cs` handles OpenVR startup, `vrserver` polling, dashboard events, and tracked transforms. The `Webservice` scripts poll `http://localhost:8111/` for War Thunder state, indicators, map, objectives, and textures.
- Product reference value: medium. It is game-specific, but the structure generalizes to "local telemetry companion plus in-headset instrument panel".
- Architecture pattern: Unity scene overlay host plus local HTTP telemetry client plus typed state models.
- Reusable method: separate overlay rendering from telemetry intake so a future utility can swap the data source while keeping the same VR UI shell.
- Constraints and caveats: old Unity/OpenVR lineage, product-specific War Thunder endpoints, recursive polling patterns, and tight coupling to local service assumptions.
- What to inspect next: dashboard overlay lifecycle, mouse-to-Unity UI routing, and whether the OVRLay scripts can become a generic overlay shell reference.
- Why it matters for `VR-apps-lab`: it is a useful donor for instrument-style overlays that need telemetry, thumbnails, and dashboard behavior.

#### Reusable Pattern Extraction

- Pattern candidate: Unity telemetry overlay shell.
- Problem solved: show dynamic external telemetry in VR without embedding the data source into the overlay runtime itself.
- Reusable core: Unity render texture overlay, OpenVR lifecycle manager, typed local-service polling, dashboard thumbnail, pointer/mouse routing, and tracked-device placement.
- Source evidence: `Unity_Overlay.cs`, `Unity_SteamVR_Handler.cs`, `OVR_Overlay_Handler.cs`, and `Assets/WTOVRLay/Scripts/Webservice`.
- Abstraction boundary: keep telemetry client models separate from overlay creation and Unity UI rendering.
- What not to copy: War Thunder-specific endpoints, hardcoded local port assumptions, and old dependency versions as-is.
- Method catalog action: folded into Method 653 as one surface-producer variant.

### `Wulkop/VolumeVR`

- Interesting idea: a volume/audio utility overlay can be backed by a CEF windowless browser runtime, even before the repository exposes complete overlay submission code.
- Code donor value: low. The visible source mostly shows CEF bootstrap in `src/gui/Gui.cpp` and `internal/WebApp.cpp`: subprocess path, no sandbox, windowless rendering enabled, remote debugging port, and manual `CefDoMessageLoopWork`.
- Product reference value: low to medium. The product framing points toward browser-backed utility overlays, but the available source is too thin for strong reuse.
- Architecture pattern: native process wraps an embedded browser runtime as a potential UI surface producer.
- Reusable method: treat CEF/browser as a replaceable surface source, not as the overlay architecture itself.
- Constraints and caveats: source-light, no clear OpenVR texture submission path found in the inspected files, and remote debugging/no-sandbox choices need explicit review.
- What to inspect next: overlay submission, input routing, audio-device control, and whether a missing branch contains the actual VR integration.
- Why it matters for `VR-apps-lab`: it is a cautionary reference for browser-shell overlays, not a finished donor.

### `iigomaru/MPVR`

- Interesting idea: render `libmpv` video frames into an OpenGL texture and submit that texture directly to an OpenVR overlay.
- Code donor value: medium. `MPVR.c` shows the whole lower-bound pipeline: hidden rawdraw OpenGL window, `mpv_render_context_create`, `VR_InitInternal(VRApplication_Overlay)`, `CreateOverlay`, `ShowOverlay`, controller-relative transform, `mpv_render_context_render`, `glCopyTexImage2D`, and `SetOverlayTexture`.
- Product reference value: medium as a proof that a media player does not require a heavyweight game-engine shell to appear in VR.
- Architecture pattern: single native loop combining media decode/render, OpenGL texture capture, and OpenVR overlay submission.
- Reusable method: use a native media engine as a surface producer, then submit the rendered GPU texture to an OpenVR overlay.
- Constraints and caveats: rough proof of concept, bundled binaries, limited controls, no modern UI shell, simple sleep-driven loop, and unclear cleanup/lifetime behavior.
- What to inspect next: better media controls, audio focus, dashboard controls, texture update pacing, and whether the direct texture path can be isolated from the sample app.
- Why it matters for `VR-apps-lab`: it is a compact donor for direct media-to-overlay texture architecture.

#### Reusable Pattern Extraction

- Pattern candidate: direct media-engine to OpenVR overlay texture loop.
- Problem solved: display video in VR without routing through a full desktop capture stack or game engine.
- Reusable core: media engine render context, GPU texture target, OpenVR overlay handle, placement transform, and texture submission loop.
- Source evidence: `MPVR.c` calls into `libmpv`, OpenGL, and OpenVR in one readable loop.
- Abstraction boundary: separate media decoding/rendering from overlay placement and input controls in any future implementation.
- What not to copy: bundled binaries, hardcoded playback path, sleep-driven timing, and missing controller/dashboard UX.
- Method catalog action: create Method 653.

## Cross-Project Lessons

- The overlay surface producer can be very small: static image, Unity render texture, browser surface, or native video texture.
- A serious reusable overlay shell needs input, placement, lifecycle, and persistence as first-class concerns, not afterthoughts.
- Browser and media engines should be treated as surface producers behind a boundary, not as the whole architecture.
- The strongest reusable line from this wave is not one project, but the shared surface-to-overlay method.

## Method Catalog Actions

- Added Method 653: direct media/browser surface to OpenVR overlay texture loop.

## Follow-Up Gaps

- Compare direct media texture submission against desktop capture and virtual display approaches.
- Find modern OpenXR or OpenVR media overlay utilities with clean control panels and settings persistence.
- Build a surface-producer matrix across media engines, browser engines, Unity render textures, and static/generated images.
