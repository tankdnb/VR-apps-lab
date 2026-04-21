# GitHub Research Wave 88 Backlog

- Date: `2026-04-21`
- Scope: next GitHub discovery wave focused on
  `VRChat world-authoring toolkits`, `Udon optimization helpers`, and
  `prefab ecosystem baselines`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for VRChat world-creation toolkits, prefab suites, and Udon optimization helpers
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist spanning editor enforcement, compiler optimization, legacy prefab suites, and ecosystem umbrella repos

## Work package B: Local source acquisition

- `Done` Confirm `VRWorldToolkit` in local cache
- `Done` Confirm `UdonSharpOptimizer` in local cache
- `Done` Confirm `UdonEssentials` in local cache
- `Done` Confirm `VUdon` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect build callbacks, sync-mode automation, and editor helper split in `VRWorldToolkit`
- `Done` Inspect Harmony-based compiler patching and optimization-pass structure in `UdonSharpOptimizer`
- `Done` Inspect prefab-suite composition and delegated-event pattern in `UdonEssentials`
- `Done` Inspect package constellation and ecosystem role in `VUdon`

## Work package D: Repository updates

- `Done` Add Wave 88 plan document
- `Done` Add Wave 88 backlog document
- `Done` Add Wave 88 synthesis document
- `Done` Update the project registry for VRChat creator-side authoring donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new world-authoring and optimization patterns
- `Done` Update documentation indexes to include Wave 88

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `VUdon` through individual package repos such as `QuickMenu`, `Menus`, and `PlayerTracker`
- `Next` Keep `UdonEssentials` visible as a historical precursor when comparing prefab-suite evolution
- `Next` Compare `VRWorldToolkit` and `UdonSharpOptimizer` whenever future work needs stronger `editor guardrail plus compiler post-pass` references
