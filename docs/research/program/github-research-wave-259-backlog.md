# GitHub Research Wave 259 Backlog - Meta Quest Device, Camera, Screenshot, Streaming, and Setup Helpers

## Executed Scope

- Searched and deduplicated Quest helper candidates around capture, sensor
  telemetry, camera workarounds, registry/config patching, screenshot loading,
  screen casting, ADB Wi-Fi setup, and eye tracking.
- Froze a shortlist of nine projects with reusable device-helper boundaries.
- Read source and documentation statically from local-only cache.
- Extracted reusable capture, transport, model-detection, permission, rollback,
  and privacy lessons.

## Studied Projects

- `t-34400/metaquest-3d-reconstruction`
- `kodaekwan/MetaQuest_HandTracking`
- `lukasmoro/cameraaccess-metaquest`
- `CHUNx3/MetaQuestBitrateRegistryEditor`
- `t-34400/MetaQuestScreenshotLoader`
- `hiroyamochi/quest-screen-caster`
- `XargonWan/metaquest-username-changer`
- `SinanAkkoyun/OculusQuest2ADBAutoWifi`
- `Clept0/Unity_QuestPro_EyeTrackingRecorder`

## Backlog Findings

- Build a Quest capture path matrix: Reality Capture, screenshot loader,
  screenrecord, scrcpy, OBS virtual camera, passthrough workaround, and Unity
  plugin media ingestion.
- Add a Quest setup-helper safety checklist covering ADB, registry edits,
  identity patches, power/proximity commands, and storage permissions.
- Track Quest hand, eye, depth, screenshot, and camera streams as separate
  sensor/capture schemas.
- Revisit Android scoped-storage and Quest OS version compatibility before
  promoting screenshot or username patch patterns as reusable implementation
  donors.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes Quest device-helper method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
