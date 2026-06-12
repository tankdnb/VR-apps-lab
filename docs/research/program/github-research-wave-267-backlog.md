# GitHub Research Wave 267 Backlog - Source-Light OpenVR/SteamVR Overlay, Tweak, and HUD Variants

## Executed Scope

- Searched and deduplicated source-light OpenVR/SteamVR overlay, game HUD,
  Unity overlay, and Quest MR image-overlay candidates.
- Froze a shortlist of five projects with mixed README-only, vendor-heavy,
  minimal native, and Quest-specific reference value.
- Read source and documentation statically from local-only cache.
- Extracted source-evidence, artifact hygiene, OpenVR texture submission,
  controller-relative placement, and MR heatmap panel lessons.

## Studied Projects

- `bwmcadams/vorpal`
- `UpsilonScorpi/VRP-Overlay`
- `LapisGit/OVRTweaks`
- `JasonPKnoll/vr_overlay`
- `pouya-codes/VR_overlay`

## Backlog Findings

- Add a source-light overlay matrix comparing README-only, vendor-heavy,
  minimal native, and MR image-panel cases.
- Deepen `JasonPKnoll/vr_overlay` as a minimal OpenVR overlay baseline if a
  native overlay sample is needed.
- Keep `OVRTweaks` partial until custom overlay/tweak code is separated from
  bundled SteamVR content.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes source-light overlay intake method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
