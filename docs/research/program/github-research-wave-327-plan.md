# GitHub Research Wave 327 Plan - Window Mirror Managers, Capture/Remix Surfaces, and Stream-Safe Overlay Pipelines

## Goal

Study projects that treat VR/overlay-adjacent content as a managed surface:
window mirroring to a virtual display, stream-safe launch/close ownership, and
source-light capture/remix channel concepts.

## Research Questions

- What can VR overlay tools learn from DWM thumbnail mirroring and persistent
  virtual-display workers?
- How should launch ownership, watchdogs, process targets, and stream teardown
  be separated from the mirroring surface?
- Which capture/remix concepts are worth retaining even when a repo is
  README-only?

## Shortlist

- `aguirretim/apollo-mirror-manager`
- `PhotonIO/RemixPlayer`

## Required Checks

- Deduplicate against desktop-in-VR, virtual display, stereo viewer, and media
  capture waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, install, or launch any
  found project.
- Mark source-light candidates honestly.

## Expected Outputs

- Landscape synthesis for Wave 327.
- Registry/family entries for DWM mirror managers and capture/remix concepts.
- Method catalog entry for stream-safe mirror workers with ownership markers
  and watchdog repair.
