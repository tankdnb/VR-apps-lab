# GitHub Research Wave 178 Plan

- Date: `2026-06-05`
- Theme: `Visual impairment simulation, gaze-contingent accessibility, and UI accessibility helpers`
- Scope: visual impairment simulators, gaze-contingent post-processing,
  patient-data mask generation, mobile passthrough filters, and Unity
  screen-reader-like UI accessibility systems.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Accessibility and visual simulation are strategically important for `VR-apps-lab`
because they turn XR tooling into a practical design and testing surface. This
wave studies how projects model low-vision conditions, per-eye effects, gaze
contingency, and non-visual UI feedback.

## Search Families

- visual impairment VR simulators
- gaze-contingent field-loss shaders
- low-vision mobile passthrough filters
- Unreal and Unity accessibility helpers
- screen-reader-like Unity UI systems
- patient-data-driven visual field masks

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `petejonze/OpenVisSim` | Unity per-eye visual impairment simulator with gaze-contingent masks and linkable effect fields | Unity visual impairment simulation |
| `VARID-XR/VARID-plugin-ue5` | Unreal post-process plugin for multiple eye conditions, per-eye state, gaze, and debug modes | Unreal accessibility/impairment plugin |
| `rulyox/VisualImpairmentVR` | Small Cardboard/mobile passthrough impairment shader example | Mobile passthrough filter reference |
| `ojwalch/LowVisionVR` | Android dual-eye camera preview and RenderScript low-vision filters | Native mobile low-vision filter |
| `lukasmaxim/Glaucoma-VR` | Patient-data-to-mask pipeline with Varjo gaze/context/focus camera integration | Patient-data gaze-contingent mask |
| `mikrima/UnityAccessibilityPlugin` | Unity UI accessibility manager with TTS/audio queue, navigation order, hints, and touch exploration | Screen-reader-like UI accessibility |

## Dedupe Notes

- Earlier accessibility waves covered captions, subtitles, and STT/OCR
  surfaces. This wave focuses on vision simulation and navigable UI feedback.
- `OpenVisSim` is deprecated in favor of VARID, but its Unity source still
  exposes reusable per-eye/gaze-contingent implementation details.
- `Glaucoma-VR` includes vendor/sample assets and weak documentation; only its
  own scripts are treated as source evidence.

## Code-Level Pass Targets

- per-eye post-effect linking and effect parameter synchronization;
- gaze-contingent masks, blur pyramids, and field-loss rendering;
- Unreal Blueprint APIs, RDG compute shader passes, and debug modes;
- mobile camera preview, dual-eye display, crop/warp/edge filters, and native
  kernels;
- patient visual-field CSV loading, mask texture generation, Varjo gaze and
  context/focus camera use;
- Unity UI accessibility containers, hints, ordering, TTS/audio queue, touch
  exploration, and virtual keyboard behavior.

## Expected Outputs

- Wave 178 landscape synthesis.
- Registry/family placement for visual impairment and UI accessibility helpers.
- Methods around gaze-contingent impairment shaders, mobile passthrough
  filters, and screen-reader-like Unity UI navigation.
