# GitHub Research Wave 104 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on
  `VRChat shader ecosystems`, `material translators`, and
  `avatar visual-safety shaders`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for VRChat shader ecosystems, material translators,
  shader optimizers, and accessibility shader addons
- `Done` Deduplicate the results against the registry and family docs
- `Done` Freeze a bounded shortlist spanning large shader ecosystems, narrow
  translators, modular shader packs, and one visual-safety micro-utility

## Work package B: Local source acquisition

- `Done` Confirm `PoiyomiToonShader` in local cache
- `Done` Confirm `lilToon` in local cache
- `Done` Confirm `Mochies-Unity-Shaders` in local cache
- `Done` Confirm `lilToonToPoiyomiToon` in local cache
- `Done` Confirm `EpilepsyProtection` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect Poiyomi translation logic, shader variant selection, render
  preset setup, and render queue restoration
- `Done` Inspect lilToon inspector modes, multi-material editing,
  material conversion utilities, and constant-property optimizer logic
- `Done` Inspect Mochies shared include layout and specialized shader-effect
  families
- `Done` Inspect lilToonToPoiyomiToon editor menu flow, backup model, and
  explicit property mapping table
- `Done` Inspect EpilepsyProtection shader thresholding, blackout, HDR clamp,
  night mode, distance hide, and VRCFury install framing

## Work package D: Repository updates

- `Done` Add Wave 104 plan document
- `Done` Add Wave 104 backlog document
- `Done` Add Wave 104 synthesis document
- `Done` Update the project registry for shader ecosystem and material
  translator donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new shader, translator, inspector,
  and visual-safety methods
- `Done` Update documentation indexes to include Wave 104

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `PoiyomiToonShader` and `lilToon`
  if a future pass needs deeper shader-inspector UX, material-locking, or
  generated shader variant study
- `Next` Compare `LinesGuy/lilToonToPoiyomiToon` and Poiyomi's built-in
  translator if `VR-apps-lab` needs a reusable material migration prototype
- `Next` Use `EpilepsyProtection` as an accessibility seed for future
  visual-safety and comfort-filter experiments
