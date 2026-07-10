# GitHub Research Wave 315 Backlog - XREAL One Companions, Virtual Displays, IMU Readers, and Display-Triggered Microhelpers

## Executed Scope

- Searched and deduplicated XREAL One and related smart-glasses companion
  utilities.
- Froze a five-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted IMU transport framing, complementary-filter and sanity-guard
  baselines, stable virtual-display identity strategies, diagnostics/churn
  telemetry, helper-service boundaries, Shizuku-based Android micro-automation,
  and Linux stack/patch evidence.

## Studied Projects

- `dripster82/ar_workspace_manager_for_xreal`
- `SamiMitwalli/One-Pro-IMU-Retriever-Demo`
- `rohitsangwan01/xreal_one_driver`
- `shugi12345/xreal-show-taps`
- `DeskUnreal/xreal-vio-vr`

## Backlog Findings

- Deepen `ar_workspace_manager_for_xreal` capture/compositor/helper subsystems.
- Compare the One/One Pro IMU readers directly across protocol, coordinates,
  drift handling, and reconnect policy.
- Revisit `xreal-vio-vr` only when the bridge/runtime code matures beyond the
  current skeleton and patch evidence.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a smart-glasses companion method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
