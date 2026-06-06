# GitHub Research Wave 262 Backlog - VPM Package Index Generation, Flatpak, and Repository Publication Tooling

## Executed Scope

- Searched and deduplicated VPM index, repository listing, and package
  distribution candidates.
- Froze a shortlist of four projects spanning CLI generation, Flatpak
  packaging, minimal static indexes, and generated listing pages.
- Read source and documentation statically from local-only cache.
- Extracted manifest/lock, release fetch, validation, VCC URL, public listing,
  and license-boundary lessons.

## Studied Projects

- `Limitex/voyager-vpm`
- `NathMorgan/vrchat-vpm`
- `tamakiii/vrchat-vpm`
- `cuebitt/vpm`

## Backlog Findings

- Build a VPM publication checklist for future reusable packages:
  `package.json`, release assets, generated index, validation, license notes,
  VCC add link, and update cadence.
- Compare `voyager-vpm`, VRChat template-package automation, and static
  hand-authored indexes.
- Track Linux/Flatpak packaging constraints for VRChat creator CLI workflows.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes VPM package publication method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
