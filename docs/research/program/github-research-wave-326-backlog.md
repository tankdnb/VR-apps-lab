# GitHub Research Wave 326 Backlog - KAT Walk Linux Locomotion Overlay and OpenXR Layer Split

## Executed Scope

- Searched and deduplicated locomotion/control overlay projects.
- Froze `BBPSBB/katwalk-linux` as the strong donor and
  `Kiichiuwu/WTVFSVR-war-thunder-virtual-flight-stick-for-vr` as an empty
  source-light candidate.
- Read source and documentation statically from local-only cache.
- Extracted USB frame parsing, device detection, locomotion model, body-relative
  stick fusion, shared-memory buses, daemon/web tuner, pure-Pillow HUD renderer,
  OpenXR layer HUD submission, laser/click event return path, persistent
  `hud.conf`, and Proton/container caveats.

## Studied Projects

- `BBPSBB/katwalk-linux`
- `Kiichiuwu/WTVFSVR-war-thunder-virtual-flight-stick-for-vr`

## Backlog Findings

- Compare `katwalk-linux` with `Majed6/KATOXR` as two KAT/OpenXR approaches:
  one API-layer locomotion remapper, one daemon plus OpenXR HUD/layer stack.
- Deepen the shared-memory HUD contract if future `VR-apps-lab` prototypes need
  an OpenXR overlay-like panel without SteamVR overlays.
- Re-check `WTVFSVR` only if it gains source code.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include strong and source-light candidates.
- Method catalog captures daemon plus OpenXR HUD/layer split.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
