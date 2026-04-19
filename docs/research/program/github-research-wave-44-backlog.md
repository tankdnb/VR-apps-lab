# GitHub Research Wave 44 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `playspace editors`, `chaperone and guardian tooling`, and
  `shared-space helpers`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for chaperone editors, guardian importers, and playspace manipulation tools
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans live room-space editors, desktop or file-based editors, vendor boundary importers, runtime playspace movers, and peer-space overlays

## Work package B: Local source acquisition

- `Done` Confirm `ChaperoneTweak` in local cache
- `Done` Confirm `xr-chaperone` in local cache
- `Done` Confirm `Guardian2Chaperone` in local cache
- `Done` Confirm `unity-chaperone-tweaker` in local cache
- `Done` Confirm `Playspace-Mover` in local cache
- `Done` Confirm `OpenVRSharedPlayspace` in local cache
- `Done` Confirm `RotatoExpress` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect controller hit-zones, wall editing flow, and live save or reload behavior in `ChaperoneTweak`
- `Done` Inspect desktop setup, service mode, and polygon-boundary logic in `xr-chaperone`
- `Done` Inspect Guardian-to-chaperone transfer flow in `Guardian2Chaperone`
- `Done` Inspect editor-time `.vrchap` parsing and overwrite workflow in `unity-chaperone-tweaker`
- `Done` Inspect controller-delta playspace movement and reset flow in `Playspace-Mover`
- `Done` Inspect LAN pose broadcast and overlay visualization flow in `OpenVRSharedPlayspace`
- `Done` Inspect live zero-pose rotation and restore-on-exit flow in `RotatoExpress`

## Work package D: Repository updates

- `Done` Add Wave 44 plan document
- `Done` Add Wave 44 backlog document
- `Done` Add Wave 44 synthesis document
- `Done` Update the project registry for playspace editors and boundary helpers
- `Done` Update overlap families for live playspace editing, boundary import, and shared-space helpers
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes
- `Done` Update the methods catalog with playspace-editing methods
- `Done` Update documentation indexes to include Wave 44

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare `ChaperoneTweak`, `xr-chaperone`, and `unity-chaperone-tweaker` directly as `in-headset editor`, `desktop setup plus service`, and `Unity editor over raw file`
- `Next` Treat `Guardian2Chaperone`, `Playspace-Mover`, and `RotatoExpress` as a separate `room-space transform` donor line whenever `VR-apps-lab` needs live room manipulator ideas
