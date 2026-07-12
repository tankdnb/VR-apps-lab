# GitHub Research Wave 323 Plan - Narrow OpenXR API Layers, Cockpit Anchors, Inline Profilers, and Game Injection Toolkits

## Goal

Study narrow runtime/game-layer projects that intercept OpenXR or game render
pipelines to add locomotion, anchoring, profiling, or external processing
without turning the repository into a general app clone.

## Research Questions

- How can an OpenXR API layer modify locomotion or reference-space behavior
  while keeping calibration and safety boundaries visible?
- What is reusable in inline profiling libraries for API layers?
- How do game injection toolkits keep injected code minimal while moving heavy
  work into daemons, shared memory, and optional overlays?

## Shortlist

- `Majed6/KATOXR`
- `robogears/cockpit-anchor`
- `mledour/xrprof`
- `AndrewAltimit/game-mods`

## Required Checks

- Deduplicate against OpenXR layer, game retrofit, profiler, and video overlay
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep invasive hook/layer caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 323.
- Registry/family entries for narrow OpenXR layer and injection toolkit donors.
- Method catalog entries for OpenXR input/reference-space micro-layers and
  minimal-injection/external-processing toolkit boundaries.
