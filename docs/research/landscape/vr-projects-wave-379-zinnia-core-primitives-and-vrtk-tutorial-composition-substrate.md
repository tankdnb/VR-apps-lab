# Wave 379: Zinnia Core Primitives and VRTK Tutorial Composition Substrate

## Theme

Core composition primitives and tutorial-project structure underneath Tilia:
rules, actions, transformers, processors, event proxies, casts, and example
scene organization.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `ExtendRealityLtd/Zinnia.Unity` | Studied | Core rule/action/process/transform/cast primitives used by many Tilia packages |
| `ExtendRealityLtd/VRTK.Tutorials.YouTube` | Studied | Example project structure demonstrating Tilia package composition in scenes |

## Dedupe Notes

Previous waves studied Tilia packages as standalone utility modules. This wave
studies their composition substrate so future docs can distinguish package
patterns from lower-level reusable primitives.

## Code-Level Findings

### `ExtendRealityLtd/Zinnia.Unity`

- Interesting idea: expose Unity-friendly primitives for process scheduling,
  rules, observable lists, actions, data transformation, casts, and event
  proxies.
- Code donor value: `MomentProcessor` shows explicit Unity-loop timing
  (`FixedUpdate`, `Update`, `LateUpdate`, `PreCull`, `PreRender`,
  `BeforeRender`); `RuleContainer` wraps `IRule` for inspector use;
  `Vector2ToAngle` shows data conversion as a transformer component.
- Product reference value: useful for building lightweight reusable VR utility
  primitives without forcing each feature to own scheduling, validation,
  conversion, and event plumbing.
- What to inspect next: action base classes, observable list behavior, cast
  result schemas, and event proxy emitters.
- Caveat: Zinnia is broad; copy the primitives taxonomy, not the entire stack.

### `ExtendRealityLtd/VRTK.Tutorials.YouTube`

- Interesting idea: keep tutorial/demo scenes as a composition layer that shows
  how camera rigs, input, interactables, buttons, locomotion, and package
  importer pieces fit together.
- Code donor value: project folder structure (`GlobalResources`, `Samples`,
  `Scenes`, `VRTK.Tilia.Package.Importer`, `XR`) is a reference for separating
  package samples from project-specific scenes.
- Product reference value: useful for documenting future `VR-apps-lab` examples
  as study scenes rather than one monolithic app.
- What to inspect next: scene naming, package importer manifest, and OpenXR
  tutorial setup flow.
- Caveat: tutorial projects are reference composition, not reusable library
  code by themselves.

## Reusable Pattern Extraction

- Pattern candidate: Unity component primitive substrate.
- Problem solved: reusable VR utilities need common scheduling, validation,
  transformation, action, cast, collection, and event-proxy concepts.
- Reusable core: process moment, process list, rule container, observable list,
  transformer, converter, action source, cast source, event proxy, testable
  primitive, sample scene, package importer, and composition docs.
- Source evidence: `MomentProcessor`, `RuleContainer`, `Vector2ToAngle`, broad
  Zinnia runtime/test layout, and VRTK Tutorials project folders.
- Abstraction boundary: low-level primitives stay engine/toolkit-neutral where
  possible; Tilia packages and tutorial scenes compose them.
- What not to copy: whole framework dependency, tutorial scene assumptions, or
  primitive graphs without naming and debug conventions.
- Method catalog action: add Method 824.

## Family Placement

Creates a family for Zinnia/VRTK composition substrate. It is a cross-cutting
support family for Tilia-derived package waves.

## Follow-Up Gaps

- Audit which Zinnia primitives map cleanly to existing `VR-apps-lab` methods.
- Draft a tiny local vocabulary for process/rule/transform/action/event modules.
- Decide when future waves should study packages vs substrate.
