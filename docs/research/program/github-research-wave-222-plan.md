# GitHub Research Wave 222 Plan

Date: 2026-06-06

Theme: cockpit hand-clicking, calibration, observer, and passthrough
microhelpers.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Some of the most useful VR tools are narrow helpers: turn hand tracking into a
cockpit mouse, calibrate multiple tracking origins, align a HoloLens observer
with a Vive scene, or pipe a headset camera into an overlay. This wave studies
microhelpers that solve one high-value problem through bounded translation,
state machines, and diagnostics.

## Search Families

- OpenXR API-layer hand input translators.
- Tracking-origin calibration helpers.
- Mixed-device observer/alignment prototypes.
- Camera passthrough overlays and projection surfaces.
- Linux/Monado/OpenVR helper tools.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `fredemmott/HTCC` | OpenXR API layer that translates hand tracking and PointCTRL into simulator cockpit click/scroll/controller actions. | Hand-to-cockpit action translator |
| `galister/motoc` | Monado/WiVRn tracking-origin calibration CLI with sampled calibration, continuous offset, recentering, and monitor mode. | Tracking-origin calibration |
| `dag10/HoloViveObserver` | Historical Unity HoloLens/Vive shared-room observer with networked alignment and controller click calibration. | Mixed-device observer alignment |
| `yshui/index_camera_passthrough` | Linux Index camera passthrough overlay with V4L capture, Vulkan processing, OpenVR/OpenXR backend boundary, and projection modes. | Camera-to-overlay passthrough |

## Dedupe Notes

Tracking calibration and passthrough were covered in earlier families, but
this wave focuses on small purpose-built helper applications and the exact
state/translation boundaries that make them reusable.

## Code-Level Pass Targets

- API-layer interception and virtual controller action mapping.
- Per-app configuration and simulator-specific bindings.
- Calibration method state machines and saved transform data.
- Mixed-device alignment events and client/server flow.
- Camera capture, overlay visibility, projection modes, and backend traits.

## Expected Outputs

- Wave 222 landscape synthesis.
- Registry/family entries for VR microhelper tools.
- Method catalog entry for purpose-bounded input/calibration helpers.
- Follow-up backlog for helper safety and translation matrices.
