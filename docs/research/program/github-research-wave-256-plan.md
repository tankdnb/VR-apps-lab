# GitHub Research Wave 256 Plan - VMC Protocol Transport, OpenXR Motion, and Bridge Adapters

## Goal

Study a bounded set of VMC/OpenXR motion bridge projects and extract reusable
protocol transport, pose-source, and operator-surface patterns.

## Research Questions

- How do small projects acquire pose data from OpenXR without becoming a full
  application shell?
- How does VMC data move from local OSC-style messages into network transport?
- Where should bridge utilities place client identity, routing, monitoring,
  calibration, and reconnect behavior?

## Shortlist

- `LukasLichten/simple-xr2vmc`
- `sotanmochi/VMCTransportBridge`
- `sotanmochi/VMCTransportHub`
- `vivi90/python-vmc`

## Required Checks

- Deduplicate against registry, families, and recent wave documents.
- Clone only into local-only study cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Update registry, families, not-yet-studied queue, methods catalog, and
  indexes.
- Clean local-only source cache after the batch if no longer needed.

## Expected Outputs

- Landscape synthesis for Wave 256.
- Registry section for Wave 256.
- New VMC/motion bridge family entry.
- New or updated method catalog entry for identity-preserving motion protocol
  bridges.
- Follow-up gaps for VMC transport auth, transform calibration, and active
  Python/Rust/C# implementations.
