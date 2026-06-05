# VR Projects Wave 113: Unity XR Interaction Workflow Toolkits, Scientific Rigs, Training Graphs, and Tilia Composition

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for Unity XR projects that
  package reusable interaction primitives, scientific/exhibition workflows,
  training graphs, and prefab-composed toolkit ecosystems.

## Why this wave exists

Unity toolkit repositories reveal how VR interaction systems become reusable:
not only through code, but through package splits, editor drawers, component
contracts, rig presets, scene-object references, event hooks, and prefab
composition.

This wave studies Unity XR toolkits as references for future utility menus,
calibration wizards, onboarding flows, scientific data capture, and reusable
interaction modules.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by modern MRTK, scientific XR toolkit, VR training workflow,
   and VRTK/Tilia families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `MixedRealityToolkit/MixedRealityToolkit-Unity` | Current-generation MRTK line with modular packages, stateful interactables, pressables, object manipulation, solvers, menus, and accessibility direction |
| `eisclimber/ExPresS-XR` | Scientific and exhibition XR toolkit with rig presets, data gathering, quizzes, menus, sockets, and interaction primitives |
| `MindPort-GmbH/VR-Builder` | VR workflow editor where steps, behaviors, conditions, and scene-object properties form no-code training processes |
| `ExtendRealityLtd/VRTK` | VRTK v4/Tilia example ecosystem built from prefab composition, rules, pointers, actions, interactables, and snap zones |

## Deep-pass notes by project

## `MixedRealityToolkit/MixedRealityToolkit-Unity`

- GitHub:
  [MixedRealityToolkit/MixedRealityToolkit-Unity](https://github.com/MixedRealityToolkit/MixedRealityToolkit-Unity)
- What it is:
  the current-generation Mixed Reality Toolkit for Unity, built around OpenXR,
  XR Interaction Toolkit, Unity Input System, and modular packages.
- Interesting idea:
  MR UX can be packaged as a clean state-machine layer where interaction state
  is separated from visuals, while spatial manipulation and solver behavior
  live in reusable packages.
- Code-level notes:
  `StatefulInteractable.cs` extends interactables with toggle modes,
  thresholds, trigger-on-release, dwell, gaze, and voice-selection behavior.
  `PressableButton.cs` keeps press logic visual-free, with push planes,
  smoothing, roll-off rejection, front-push enforcement, and proximity hover.
  `ObjectManipulator.cs` provides near/ray/gaze/generic manipulation modes,
  move/rotate/scale flags, multi-hand behavior, constraints, and rigidbody
  choices. `SolverHandler.cs` centralizes head, hand, joint, or custom target
  tracking and updates solver lists.
- Code donor value:
  very high for interaction state machines, pressable logic, manipulation, and
  solver orchestration.
- Product reference value:
  very high for utility menus, hand menus, near menus, slates, dialogs, and
  spatial UI.
- Caveats:
  large framework; best reused as architecture and UX reference unless a Unity
  prototype intentionally depends on MRTK packages.
- What to inspect next:
  accessibility helpers, data binding, keyboard, and menu-specific package
  internals.

## `eisclimber/ExPresS-XR`

- GitHub:
  [eisclimber/ExPresS-XR](https://github.com/eisclimber/ExPresS-XR)
- What it is:
  a Unity toolkit for experimentation and presentation with OpenXR.
- Interesting idea:
  a research/exhibition VR toolkit should bundle rig configuration, movement
  presets, interaction primitives, data capture, tutorials, quizzes, HUDs, and
  localization rather than only low-level input.
- Code-level notes:
  `ExPresSXRRig.cs` centralizes input method, movement presets, interaction
  options, head-gaze reticle/select timing, XR origin, and overlay camera
  references. `DataGatherer.cs` exports CSV, local files, HTTP submissions,
  playthrough-separated files, timestamps, and escaped columns.
  `ButtonQuiz.cs` couples configurable questions, answers, feedback objects,
  videos, text, and event-driven data export. `ValueRangeInteractable.cs`
  provides a reusable value descriptor/visualizer base for sliders, levers,
  joysticks, and snap/reset events.
- Code donor value:
  high for research data capture, rig presets, reusable interactables, and
  exhibition flows.
- Product reference value:
  high for training, onboarding, experiments, museum demos, and tutorial rooms.
- Caveats:
  Unity toolkit scope is broad; direct reuse should be selective.
- What to inspect next:
  compare wrist/hand menus and tutorial dialog flows against MRTK3.

## `MindPort-GmbH/VR-Builder`

- GitHub:
  [MindPort-GmbH/VR-Builder](https://github.com/MindPort-GmbH/VR-Builder)
- What it is:
  a Unity workflow editor for VR training processes built from steps,
  behaviors, conditions, and scene-object properties.
- Interesting idea:
  training logic can be represented as a process graph where editor drawers
  guide creators through scene references, auto-configuration, validation, and
  fixable warnings.
- Code-level notes:
  `StepDrawer.cs` presents step UI around behaviors, transitions, and unlocked
  objects. `ProcessSceneReferenceDrawer.cs` handles drag/drop scene references,
  warns about missing configuration, and offers fix buttons that add required
  process scene objects or properties. `LinearControlsCondition.cs` and
  `MomentaryControlsCondition.cs` show data-contract conditions with min/max,
  release requirements, all/any logic, initialize, and fast-forward behavior.
- Code donor value:
  medium-high for process-graph editor, condition model, and scene-reference
  validation patterns.
- Product reference value:
  high for training flows, guided setup, calibration wizards, and no-code
  procedural experiences.
- Caveats:
  this was a partial sparse pass; some core runtime internals were not present
  in the local source snapshot.
- What to inspect next:
  perform a full runtime-core pass if workflow graphs become an active
  prototype direction.

## `ExtendRealityLtd/VRTK`

- GitHub:
  [ExtendRealityLtd/VRTK](https://github.com/ExtendRealityLtd/VRTK)
- What it is:
  a VRTK v4 example repository built around Tilia, Zinnia, Unity XR
  Management, Input System, and OpenXR.
- Interesting idea:
  a large amount of XR interaction can be assembled from prefab-composed
  actions, rules, interactables, snap zones, pointers, haptics, locomotors,
  and trackers rather than hand-written monoliths.
- Code-level notes:
  `Packages/manifest.json` pulls many `io.extendreality.tilia.*` packages for
  camera rigs, pointers, actions, interactables, snap zones, spatial buttons,
  locomotors, haptics, trackers, and visuals. `OptionsMenu.cs` shows
  action-driven control-station toggle and placement. `BowController.cs`
  composes `InteractableFacade`, `SnapZoneFacade`, and `InteractorFacade`.
  Scene and prefab wiring reveal heavy use of rule aggregators, pointer
  visibility, teleporter events, grab actions, and snap/interaction swaps.
- Code donor value:
  medium as direct code, high as prefab-composition reference.
- Product reference value:
  high for composable Unity XR scene architecture.
- Caveats:
  many lessons live in prefab/package wiring rather than compact source files.
- What to inspect next:
  compare with MRTK3 for code-centric versus prefab-centric toolkit design.

## Main takeaways from Wave 113

- Unity XR toolkits are often strongest at packaging interaction systems for
  creators, not just exposing low-level input.
- MRTK3 is the strongest modern donor for stateful MR UX primitives.
- ExPresS-XR is valuable for scientific/exhibition data capture and rig
  presets.
- VR Builder captures a process-graph model that maps well to training and
  guided calibration.
- VRTK/Tilia is best treated as a prefab-composition architecture reference.

## Reusable methods clarified by this wave

- `OpenXR/XRI modular MR toolkit package split with UX, input, and spatial manipulation layers`
- `Scientific XR rig toolkit with configurable movement, data capture, quizzes, and exhibition helpers`
- `No-code VR training workflow process graph with steps, behaviors, conditions, and scene-object properties`
- `Prefab-composed Tilia/VRTK interaction scene with rules, actions, pointers, teleport, and grab swaps`

## Recommended next moves after this wave

1. Use MRTK3 as the primary modern Unity spatial-UI donor.
2. Use ExPresS-XR when research, training, quiz, or exhibition workflows need
   data capture.
3. Revisit VR Builder runtime core only if no-code workflow graphs become
   product scope.
4. Treat VRTK/Tilia as a composition and prefab architecture reference.
