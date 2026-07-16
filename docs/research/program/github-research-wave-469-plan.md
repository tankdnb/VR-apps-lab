# GitHub Research Wave 469 Plan

- Date: `2026-07-16`
- Theme: WebXR VRM avatar optimization and companion viewer microtools.

## Frozen scope

- `WebXR-JP/avatar-optimizer`
- `chrisdubya/vrm-webxr`
- `royalkingjoey/YumeVRM`
- `ToxSam/open-source-avatars`
- existing `pixiv/three-vrm` coverage as overlap reference

## Research questions

- What belongs in a reusable browser avatar utility beyond loading a VRM file?
- How do optimization, atlas, compression, debug viewing, avatar libraries,
  VRMA animation, and asset provenance fit together?
- Which pieces should stay separate as registry, optimizer, runtime, and UI
  layers?

## Required extraction

- optimizer package boundary
- minimal VRM runtime evidence
- saved avatar and animation-library lifecycle
- provenance/licensing registry caveats

