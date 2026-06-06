# GitHub Research Wave 259 Plan - Meta Quest Device, Camera, Screenshot, Streaming, and Setup Helpers

## Goal

Study Meta Quest helper projects that handle capture, sensor streams, media
ingestion, ADB setup, registry/config patching, and research data recording.

## Research Questions

- Which Quest helper boundaries are reusable without turning this repository
  into one Quest app?
- How do projects separate device setup, capture/sensor acquisition, desktop
  processing, operator UI, and rollback?
- Which dangerous operations require explicit warnings before reuse: ADB, power
  state, registry edits, storage permissions, and identity/config patches?

## Shortlist

- `t-34400/metaquest-3d-reconstruction`
- `kodaekwan/MetaQuest_HandTracking`
- `lukasmoro/cameraaccess-metaquest`
- `CHUNx3/MetaQuestBitrateRegistryEditor`
- `t-34400/MetaQuestScreenshotLoader`
- `hiroyamochi/quest-screen-caster`
- `XargonWan/metaquest-username-changer`
- `SinanAkkoyun/OculusQuest2ADBAutoWifi`
- `Clept0/Unity_QuestPro_EyeTrackingRecorder`

## Required Checks

- Deduplicate against Meta MR samples, surface-ingress, media capture,
  research data, and Quest setup waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Update registry, families, methods, not-yet-studied, current focus, and
  indexes.

## Expected Outputs

- Landscape synthesis for Wave 259.
- Registry section and family entry for Quest companion capture/setup helpers.
- Method catalog entry for Quest device-helper boundaries.
- Follow-up gaps around capture path comparison, ADB safety, storage
  permissions, model/version detection, and sensor stream schemas.
