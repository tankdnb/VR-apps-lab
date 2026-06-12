# GitHub Research Wave 264 Plan - VR180 Spatial Video Conversion, Playback, Camera Control, and Metadata Utilities

## Goal

Study VR180 and stereo-media utilities as reusable pipeline references for
conversion, metadata handling, camera control, browser playback, and host
player projection control.

## Research Questions

- Which projects expose reusable conversion or remap boundaries?
- Which projects separate camera/lens profiles, metadata parsing, and export
  formats cleanly?
- Which playback projects provide graceful non-XR or host-player fallbacks?
- Which projects are strong donors versus camera-specific or format-specific
  references?

## Shortlist

- `34j/vr180-convert`
- `silverqsy/VR180-Silver-Bullet`
- `nallic/convert_VR180`
- `aosoft/VR180MeshProjection`
- `Vargol/VR180PhotoTools`
- `ganeshv/egarim`
- `Verdi/VR180-Web-Player`
- `steren/stereo-img`
- `kasper93/mpv360`

## Required Checks

- Deduplicate against panoramic video, media player, browser playback, and
  Quest media helper waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Update registry, families, methods, not-yet-studied, current focus, and
  indexes.

## Expected Outputs

- Landscape synthesis for Wave 264.
- Registry and family entries for VR180 spatial-video utilities.
- Method catalog entry for spatial-video pipeline decomposition.
- Follow-up gaps around calibration, metadata, playback fallback, and export
  format matrices.
