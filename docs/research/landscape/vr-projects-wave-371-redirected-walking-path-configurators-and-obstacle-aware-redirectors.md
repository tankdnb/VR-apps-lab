# Wave 371: Redirected Walking Path Configurators and Obstacle-Aware Redirectors

## Scope

This wave studies redirected-walking variants that were not treated as new core
RDW toolkits: editor-side curved path configuration, obstacle-bypass
redirectors, virtual/real waypoint logic, and fork-lineage lessons around
OpenRDW/OpenRDW2.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `klngbhn/RDW_CurvedPathConfigurator` | Studied | Unity editor tool for curve-based redirected-walking path layouts with joint points, curves, intersections, path creation, gain, tracking-space side length, safety distance, walking radius, and ScriptableObject persistence |
| `omegafantasy/Bypassing-Obstacles` | Studied as OpenRDW2 variant | Obstacle-aware RDW strategy with `Bypassing_Redirector`, waypoint/VE path logic, curvature/rotation/translation gain reasoning, obstacle potential fields, and OpenRDW2 lineage caveats |

## Reusable Pattern Extraction

- Pattern candidate: `redirected walking path authoring and obstacle policy layer`.
- Problem solved: RDW research often hides path layouts and redirector policies inside scenes; reusable tools need an authoring layer for tracking-space, virtual paths, gain assumptions, and obstacle constraints.
- Reusable core: physical-space profile, joint/curve/intersection model, virtual path list, safety distance, walking radius, gain fields, editor visualization toggles, path asset persistence, redirector policy registry, waypoint progress, obstacle polygons, gain clamp policy, reset integration, experiment metadata, and lineage/provenance notes.
- Source evidence: RDW_CurvedPathConfigurator exposes `PathGeneratorWindow` with `RedirectionDataStructure`, `EditorPrefs`, `Assets/Resources/data.asset`, joint/curve creation, tracking side length, safety distance, walking-zone radius, virtual path options, and scene repaint controls; Bypassing-Obstacles is based on OpenRDW2 and adds obstacle/waypoint redirectors such as `Bypassing_Redirector`, `ThomasAPF_Redirector`, and `ZigZagRedirector` with real/virtual target comparison and gain injection calculations.
- Abstraction boundary: path authoring, redirector policy, movement manager, resetter, and experiment logger should remain replaceable; fork-lineage projects should be documented as variants unless they add a new policy.
- What not to copy: whole OpenRDW2 vendor tree, old Photon/RockVR assets, hardcoded physical-room assumptions, research claims without experiment context, or gain settings without comfort/safety thresholds.
- Method catalog action: create a redirected-walking path authoring method.

## Project Notes

### `klngbhn/RDW_CurvedPathConfigurator`

- Interesting idea: RDW curve and virtual path design happens in a Unity editor window before runtime, with explicit safety distance and path visibility toggles.
- Code donor value: high for editor UI shape, path data asset, curve/path creation flow, tracking-space input, and gain parameterization.
- Product reference value: useful for authoring comfort experiments or room-fit locomotion helpers.
- What to inspect next: `RedirectionDataStructure`, scene gizmo drawing, export/import, and runtime consumption by an RDW controller.
- Caveats: small editor tool; needs integration with modern XR rigs and comfort validation before product use.

### `omegafantasy/Bypassing-Obstacles`

- Interesting idea: an OpenRDW2-derived project focuses on reaching specified locations while bypassing obstacles via curvature-gain and waypoint policies.
- Code donor value: moderate-high for redirector policy variants, obstacle contribution, virtual/real waypoint comparison, and gain clamp reasoning.
- Product reference value: useful for comparing RDW policies in cluttered physical spaces.
- What to inspect next: exact `Bypassing_Redirector` implementation, experiment scene setup, metric output, and how obstacles are authored.
- Caveats: fork-lineage project with large vendored assets; document as a policy variant rather than a new base toolkit.

## Product Direction

This wave supports an `RDW authoring and policy lab` branch: future locomotion
utilities can separate path layout, physical-space constraints, redirector
strategy, reset policy, and experiment logging for safer comparison.

