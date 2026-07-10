# GitHub Research Wave 315 Plan - XREAL One Companions, Virtual Displays, IMU Readers, and Display-Triggered Microhelpers

## Goal

Study XREAL One and adjacent smart-glasses companions as reusable references
for IMU transport access, virtual-display lifecycle, permissioned helper
services, display-triggered automations, and cross-language driver boundaries.

## Research Questions

- How do XREAL One utilities expose IMU transport and orientation processing?
- What patterns recur across smart-glasses workspace managers, virtual-display
  identity handling, and diagnostics?
- How do Android or desktop helpers manage permissions and narrow automations?
- Which projects are strong code donors versus stack-framing/product
  references only?

## Shortlist

- `dripster82/ar_workspace_manager_for_xreal`
- `SamiMitwalli/One-Pro-IMU-Retriever-Demo`
- `rohitsangwan01/xreal_one_driver`
- `shugi12345/xreal-show-taps`
- `DeskUnreal/xreal-vio-vr`

## Required Checks

- Deduplicate against earlier smart-glasses, desktop-in-AR, and IMU-helper
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep platform-private API, permission/helper, and placeholder-stack caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 315.
- Registry/family entries for XREAL One and smart-glasses companion utilities.
- Method catalog entry for smart-glasses companion boundaries.
- Follow-up gaps for compositor deep dives, IMU comparisons, and Linux stack
  maturity.
