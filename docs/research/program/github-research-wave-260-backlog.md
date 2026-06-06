# GitHub Research Wave 260 Backlog - VRChat API Client, Mobile Companion, and Pipeline Surfaces

## Executed Scope

- Searched and deduplicated VRChat API client, companion, and service-wrapper
  repositories.
- Froze a shortlist of six projects with API, auth, pipeline, and companion
  relevance.
- Read source and documentation statically from local-only cache.
- Extracted auth/TFA/cookie, pipeline WebSocket, generated-client, desktop-log,
  notification, and privacy lessons.

## Studied Projects

- `LinaTsukusu/vrchat-client`
- `ccamgr/vrcp`
- `binn/VRChat.API.Client`
- `calmery/vrchat`
- `Ox0017/vrc`
- `VRCMG/vrcapi-client`

## Backlog Findings

- Build a VRChat API companion checklist covering credentials, TFA, cookies,
  user-agent, rate limits, pipeline events, local logs, and privacy language.
- Compare REST polling, pipeline WebSocket events, VRCX SQLite/logs, and
  generated API clients as separate data adapters.
- Revisit `ccamgr/vrcp` if a mobile/desktop companion surface becomes an
  active prototype direction.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes VRChat API companion boundary method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
