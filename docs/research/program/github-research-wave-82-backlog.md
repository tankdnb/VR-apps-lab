# GitHub Research Wave 82 Backlog

- Date: `2026-04-20`
- Scope: next GitHub discovery wave focused on
  `spatial audio SDKs`, `renderers`, and `object-optimization toolchains`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for engine spatializers, ambisonic renderers, and object-optimization plugins
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist spanning Unity spatializers, general renderers, browser ambisonics, broad C# audio frameworks, and Wwise object clustering

## Work package B: Local source acquisition

- `Done` Confirm `spatialaudio-unity` in local cache
- `Done` Confirm `libspatialaudio` in local cache
- `Done` Confirm `omnitone` in local cache
- `Done` Confirm `Cavern` in local cache
- `Done` Confirm `spatial-audio-clustering` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect native Unity DSP plugin boundaries and sample integration in `spatialaudio-unity`
- `Done` Inspect unified renderer architecture and supported render models in `libspatialaudio`
- `Done` Inspect FOA renderer routing, convolver, and rendering-mode split in `omnitone`
- `Done` Inspect listener, source, filter, and remapping architecture in `Cavern`
- `Done` Inspect cluster creation, output-object reuse, and buffer processing in `spatial-audio-clustering`

## Work package D: Repository updates

- `Done` Add Wave 82 plan document
- `Done` Add Wave 82 backlog document
- `Done` Add Wave 82 synthesis document
- `Done` Update the project registry for spatial-audio donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new spatial-audio patterns
- `Done` Update documentation indexes to include Wave 82

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `libspatialaudio` visible as a `unified renderer substrate` donor even if it deserves a deeper dedicated pass later
- `Next` Keep `Cavern` visible as a `broad audio framework with Unity-like source-listener semantics` comparison node
- `Next` Keep `spatial-audio-clustering` visible whenever `VR-apps-lab` needs an `audio object budget` optimization reference
