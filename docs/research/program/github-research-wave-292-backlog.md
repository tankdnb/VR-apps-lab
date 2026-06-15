# GitHub Research Wave 292 Backlog - VR Comfort Tunnelling, Cybersickness Scoring, and Comfort Profile Utilities

## Executed Scope

- Searched and deduplicated VR comfort, vignette, tunnelling, cybersickness,
  profile, and foveated-rendering control projects.
- Froze a six-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted post-process tunnelling modes, facade/configurator boundaries,
  comfort-score hysteresis, JSON comfort profile schema, URP VRS/gaze marker
  controls, and source-light exclusion notes.

## Studied Projects

- `sigtrapgames/VrTunnellingPro-Unity`
- `ExtendRealityLtd/Tilia.Visuals.Vignette.Unity`
- `BryanRalston/vr-comfort-framework`
- `Skyfall1235/VR-Player-Comfort-Profile-SDK`
- `KRASAV4EK/BP_Foveated-Rendering-In-PC-VR`
- `melisgokalp/Cybersickness`

## Backlog Findings

- Build a comfort utility matrix across tunnelling modes, vignette intensity,
  motion inputs, score/state models, user profiles, and foveation controls.
- Compare Wave 292 with earlier locomotion/comfort waves so comfort methods do
  not fragment across multiple family names.
- Deepen `VrTunnellingPro-Unity`, `Tilia.Visuals.Vignette.Unity`, and
  `VR-Player-Comfort-Profile-SDK` as the strongest reusable donors.
- Consider a future reuse plan for a comfort settings panel with profile import,
  vignette preview, intervention status, and safe defaults.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a comfort intervention/profile method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
