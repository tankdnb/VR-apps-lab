# GitHub Research Wave 260 Plan - VRChat API Client, Mobile Companion, and Pipeline Surfaces

## Goal

Study VRChat API client libraries and companion app surfaces that expose typed
VRChat service data for utilities.

## Research Questions

- How do projects separate credentials, TFA, cookies, REST clients, pipeline
  events, local logs, and user-facing state?
- Which API wrappers are reusable as service boundaries rather than as
  product UIs?
- What privacy, rate-limit, and credential-storage caveats must be named before
  reuse?

## Shortlist

- `LinaTsukusu/vrchat-client`
- `ccamgr/vrcp`
- `binn/VRChat.API.Client`
- `calmery/vrchat`
- `Ox0017/vrc`
- `VRCMG/vrcapi-client`

## Required Checks

- Deduplicate against VRCX, VRChat OBS metadata, notification, chatbox, and
  OSC companion waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Update registry, families, methods, not-yet-studied, current focus, and
  indexes.

## Expected Outputs

- Landscape synthesis for Wave 260.
- Registry section and family entry for VRChat API client and companion data
  surfaces.
- Method catalog entry for VRChat API companion boundaries.
- Follow-up gaps around auth/TFA, pipeline events, privacy, local logs, and
  rate limits.
