# GitHub Research Wave 324 Backlog - VRChat Parameter State Dashboards and Local Web Control Mirrors

## Executed Scope

- Revisited `I5UCC/ParameterSaveStates` as a previously queued deepening
  candidate.
- Read README, SteamVR manifest, Unity dashboard controller, profile service,
  OSC service, and local Web UI service.
- Extracted dashboard overlay, OSCQuery discovery, per-avatar profile folders,
  typed OSC replay, apply filters, auto-sync settings, local HTTP API, SSE
  update channel, export/import archive, tray/web fallback, and SteamVR
  manifest registration.

## Studied Projects

- `I5UCC/ParameterSaveStates`

## Backlog Findings

- Compare profile save/apply semantics against other avatar-state and
  control-surface tools.
- Revisit this donor when designing a generic `VR utility state manager`
  because the dashboard plus browser mirror boundary is strong.
- Capture privacy and destructive-action safeguards if adopting profile import,
  delete, override, or auto-sync behavior.

## Completion Criteria

- Wave landscape document exists.
- Registry and families upgrade the project status.
- Method catalog captures state-profile dashboard reuse.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
