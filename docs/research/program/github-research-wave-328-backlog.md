# GitHub Research Wave 328 Backlog - VRChat Communication, Translation, Media, and Notification OSC Companions

## Executed Scope

- Searched and deduplicated VRChat OSC chatbox, translation, media-status, and
  notification companion projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted modular recognition/translation/output routing, peer-versus-self
  subtitle separation, Spotify process/media polling, system metric fallback,
  Windows notification ingestion, and avatar bracelet parameter output.

## Studied Projects

- `PaciStardust/HOSCY`
- `kapitalismho/PuriPuly-heart`
- `VespeiProjects/SpotifyOSC`
- `shadorki/vrc-osc-discord-band`

## Backlog Findings

- Treat `HOSCY` and `PuriPuly-heart` as the strong architecture donors.
- Treat `SpotifyOSC` and `vrc-osc-discord-band` as narrow product references
  for media/status and notification-to-avatar microtools.
- Add channel-separated communication companion as a reusable method.
- Compare subtitle-overlay output versus VRChat chatbox output in a future
  accessibility/text-surface pass.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog captures channel separation, provider boundaries, and privacy
  caveats.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
