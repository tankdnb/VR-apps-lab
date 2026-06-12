# GitHub Research Wave 281 Plan - XR Hand Input, Bare-Hand Manipulation, and Hand-Pose Transport Experiments

## Goal

Study XR hand-input projects as reusable references for subsystem boundaries,
gesture detection, smoothing, passthrough object manipulation, Unreal LiveLink
hand skeletons, and packetized hand-pose transport.

## Research Questions

- How do projects convert raw hand tracking into stable gestures and object
  manipulation?
- Which boundaries exist between runtime hand data, avatar output, and network
  transport?
- Where are smoothing, hysteresis, tracking-loss, floor-origin, and confidence
  gates implemented?
- Which repos are direct donors versus sample/vendor aggregations?

## Shortlist

- `Mystfit/NectoXRTemplate`
- `Clyfr/BURG-v2`
- `reubenlavin08/spindle-whorl-ar`
- `Zer0pa/ZPE-XR`

## Required Checks

- Deduplicate against prior OpenXR hand, wrist UI, Leap, VMC, and tracker waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep vendor payload, cultural-data, build-side-effect, and benchmark caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 281.
- Registry/family entries for hand input and pose transport experiments.
- Method catalog entry for hand input and pose transport boundaries.
- Follow-up matrix around XR Hands, OpenXR LiveLink, filters, pinch/poke
  gestures, passthrough manipulation, and packet replay.
