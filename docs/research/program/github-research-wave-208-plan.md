# GitHub Research Wave 208 Plan

Date: 2026-06-06

Theme: overlay media micro-surfaces, note surfaces, browser shells, and direct video-to-overlay texture paths.

Research mode: static source reading only. No external repository was run, built, installed, or launched.

## Why This Wave Exists

Recent search passes keep rediscovering large overlay frameworks that are already in the registry. Wave 208 instead deepens smaller or partially studied overlay projects that show the lower bound of useful VR surfaces: a notebook image overlay, a telemetry overlay shell, a CEF windowless bootstrap, and a direct libmpv-to-OpenVR proof of concept.

The goal is to extract reusable surface plumbing rather than evaluate any project as a complete product.

## Search Families

- OpenVR overlay windows and dashboard surfaces.
- Media or browser surfaces rendered into VR overlays.
- Small utility overlays with one narrow user value.
- Source-light or prototype repos that still reveal useful boundary decisions.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `Yukiiro-Nite/notebook-vr-overlay` | Minimal OpenVR overlay bootstrap with image surface, mouse input scale, tracked-device transform, and event loop. | OpenVR overlay micro-surface |
| `Daniel-Webster/WT-OpenVR-Overlay` | Unity/OVRLay telemetry overlay that combines render textures, dashboard overlays, tracked-device transforms, mouse input, and local JSON/image polling. | Unity telemetry overlay shell |
| `Wulkop/VolumeVR` | Source-light CEF/windowless bootstrap for a browser-like overlay product line. | Browser runtime bootstrap reference |
| `iigomaru/MPVR` | Direct libmpv/OpenGL/OpenVR overlay texture loop for video playback in VR. | Direct media-to-overlay prototype |

## Dedupe Notes

These projects are not treated as brand-new discoveries. They were chosen from the partially studied and not-yet-deepened backlog because broad GitHub search results mostly pointed back to already indexed overlay families. The wave records a deeper code-level pass and updates method-level reuse guidance rather than duplicating earlier registry entries.

## Code-Level Pass Targets

- OpenVR initialization and overlay creation.
- Surface producer model: static image, Unity render texture, CEF windowless browser, libmpv/OpenGL frame.
- Input/event handling and mouse scale.
- Tracked-device or dashboard placement.
- Configuration, persistence, and hardcoded-path caveats.
- Evidence for a reusable overlay media surface method.

## Expected Outputs

- Wave 208 landscape synthesis.
- Registry entries marked as deepened in Wave 208.
- Family placement for overlay media micro-surfaces.
- Method catalog update for direct media/browser surface to OpenVR overlay texture loops.
- Follow-up backlog for interactive media controls and modernized overlay-shell comparisons.
