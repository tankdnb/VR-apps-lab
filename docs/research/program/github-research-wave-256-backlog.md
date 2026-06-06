# GitHub Research Wave 256 Backlog - VMC Protocol Transport, OpenXR Motion, and Bridge Adapters

## Executed Scope

- Recovered repository context from foundation, quickstart, registry, families,
  methods, current-focus, and documentation playbook files.
- Searched and deduplicated VMC/OpenXR bridge candidates.
- Froze a shortlist around OpenXR-to-VMC motion, VMC transport, and operator
  hub patterns.
- Read source and documentation statically from local-only cache.
- Extracted project-level findings and a reusable method candidate.

## Studied Projects

- `LukasLichten/simple-xr2vmc`
- `sotanmochi/VMCTransportBridge`
- `sotanmochi/VMCTransportHub`
- `vivi90/python-vmc`

## Backlog Findings

- Compare VMC envelopes with OSC tracker, VRM, OSCQuery, and WebSocket bridge
  schemas.
- Find maintained scripting-language VMC wrappers and record whether they are
  send-only, receive-only, or full relay implementations.
- Add a future transform-calibration matrix for pose bridges.
- Treat `vivi90/python-vmc` as source-light until the active Codeberg source is
  inspected.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include the studied projects.
- Method catalog includes the new motion protocol bridge method.
- Follow-up gaps are captured in `not-yet-studied-deeply.md`.
- Local-only cache is cleaned before commit.
