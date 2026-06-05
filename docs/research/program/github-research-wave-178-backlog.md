# GitHub Research Wave 178 Backlog

- Date: `2026-06-05`
- Theme: `Visual impairment simulation, gaze-contingent accessibility, and UI accessibility helpers`
- Status: executed as static source-reading pass
- Build/run status: not run, not built, not installed, not launched

## Completed Intake

- Shortlisted Unity, Unreal, Android, Varjo, and UI accessibility projects.
- Deduplicated against caption/STT/OCR accessibility waves and media/passthrough
  families.
- Read shader, post-process, mobile camera, patient-data, gaze, and UI
  accessibility entry points.
- Integrated the results into landscape, registry, families, methods, and
  follow-up queues.

## Follow-Up Work

- Produce a comparison matrix across `OpenVisSim`, `VARID`, `Glaucoma-VR`,
  `VisualImpairmentVR`, and `LowVisionVR`:
  condition coverage, gaze support, per-eye support, engine, shader model, and
  caveats.
- Prototype only a conceptual `accessibility-ui-contract` note:
  focus order, spoken labels, hints, containers, virtual keyboard, and spatial
  menu adaptation.
- Keep medical/simulation disclaimers explicit if these ideas become product
  references.

## Reuse Candidates

- `[Linkable]` per-eye setting sync from `OpenVisSim`.
- Gaze-contingent blur/mask approach from `OpenVisSim`, `VARID`, and
  `Glaucoma-VR`.
- Blueprint-facing condition setters and debug views from `VARID`.
- Dual-eye mobile camera filter layout from `LowVisionVR`.
- Simple camera-to-shader passthrough staging from `VisualImpairmentVR`.
- Unity UI accessibility manager/container/audio queue from
  `UnityAccessibilityPlugin`.

## Caveats To Preserve

- Visual impairment simulation can be uncomfortable and should not be presented
  as medical validation.
- Some source is deprecated, old-Unity, old-Android, or vendor-specific.
- GPL and example-asset licenses need review before any reuse beyond notes.
