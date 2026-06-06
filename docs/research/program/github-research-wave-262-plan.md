# GitHub Research Wave 262 Plan - VPM Package Index Generation, Flatpak, and Repository Publication Tooling

## Goal

Study VRChat Package Manager repository tooling around generated indexes,
validation, public listings, and Linux/package distribution.

## Research Questions

- What makes a VPM repository maintainable and safe to add through VCC/ALCOM?
- How do projects fetch release manifests, lock package state, generate
  indexes, validate URLs, and publish listing pages?
- Which packaging and license caveats matter for VRChat creator CLI workflows?

## Shortlist

- `Limitex/voyager-vpm`
- `NathMorgan/vrchat-vpm`
- `tamakiii/vrchat-vpm`
- `cuebitt/vpm`

## Required Checks

- Deduplicate against creator package/composition, VRCOSC module-pack, and
  VPM/package-template waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Update registry, families, methods, not-yet-studied, current focus, and
  indexes.

## Expected Outputs

- Landscape synthesis for Wave 262.
- Registry section and family entry for VPM package publication tooling.
- Method catalog entry for VPM package repository pipelines.
- Follow-up gaps around package validation, public listing UX, license notes,
  and Linux CLI packaging.
