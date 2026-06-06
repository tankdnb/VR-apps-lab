# GitHub Research Wave 230 Plan

Date: 2026-06-06

Theme: Scriptable WebXR modeling, viewer, editor, and creative display
surfaces.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

VR utilities often need a work surface rather than a game scene: live code,
CAD export, model inspection, controller manipulation, menu controls, and
audio-reactive or passthrough display modes. This wave studies projects that
make those surfaces explicit.

## Search Families

- Browser CAD/modeling and WebXR editor workbenches.
- Host-app-to-WebXR export bridges.
- VR code editor and desktop keyboard companion flows.
- Audio-reactive WebXR surfaces with in-headset menus.
- Passthrough/depth-aware creative display surfaces.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `vipenzo/ridley` | CAD-as-code environment with live editor, turtle geometry, WebXR/voice/sync ambitions, and partial Windows checkout caveat. | Scriptable CAD workbench |
| `id3vi5er/fusion360_webxr_viewer` | Fusion 360 add-in that exports OBJ/MTL and serves a local HTTPS WebXR viewer. | Host-app export bridge |
| `felipereigosa/kairon` | VR code editor that keeps keyboard/mouse input on desktop while the editor and generated world live in VR. | In-headset coding surface |
| `phobi82/webxr_butterchurn` | Modular WebXR audio visualizer with menu, depth/passthrough, lighting, movement, runtime, and desktop mirror. | Creative XR display shell |

## Dedupe Notes

Earlier waves already cover generic browser editors, media players, and
overlays. This wave focuses on projects where the reusable value is a
work-surface shell: live code, host export, input split, menu texture, or
passthrough visualizer.

## Code-Level Pass Targets

- Live scripting and runtime evaluation boundaries.
- Host application export plus local WebXR serving.
- Desktop companion input to in-headset editor surface.
- In-headset menu state, sliders, sections, and mirrored desktop preview.
- Depth/passthrough and audio-reactive rendering module boundaries.
- Checkout/build caveats and safety/comfort warnings.

## Expected Outputs

- Wave 230 landscape synthesis.
- Registry/family entries for creative and scriptable WebXR surfaces.
- Method catalog entry for scriptable display/workbench shells.
- Follow-up backlog for editor, menu, host-export, and visualizer matrices.
