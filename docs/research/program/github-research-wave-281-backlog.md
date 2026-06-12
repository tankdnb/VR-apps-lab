# GitHub Research Wave 281 Backlog - XR Hand Input, Bare-Hand Manipulation, and Hand-Pose Transport Experiments

## Executed Scope

- Searched and deduplicated XR hand-input, bare-hand manipulation, OpenXR hand,
  and hand-pose transport projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted Unreal OpenXR-to-LiveLink skeleton mapping, Unity XR Hands
  filtering/gesture helpers, Quest passthrough pinch-grab object manipulation,
  and packetized hand-pose codec/replay boundaries.

## Studied Projects

- `Mystfit/NectoXRTemplate`
- `Clyfr/BURG-v2`
- `reubenlavin08/spindle-whorl-ar`
- `Zer0pa/ZPE-XR`

## Backlog Findings

- Build an XR hand input matrix across XRHandSubsystem, OpenXR LiveLink,
  pinch/poke detectors, One Euro filters, passthrough manipulation, and packet
  replay.
- Deepen `reubenlavin08/spindle-whorl-ar` as the strongest passthrough
  bare-hand manipulation donor.
- Deepen `Zer0pa/ZPE-XR` for hand-pose transport and replay schema ideas.
- Compare XR Hands, Leap, OpenXR keypoints, LiveLink, and VMC-style hand
  transport formats.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a hand input and pose transport method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
