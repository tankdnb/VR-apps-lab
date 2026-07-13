# VR Projects Wave 437: VR Accessibility Visibility and Design Playground Samples

Date: 2026-07-13

Theme: accessibility-oriented Unity samples that expose VR content to more
users and isolate small interaction/design adjustments instead of presenting a
single polished application.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `hai-vr/let-me-see` | Unity Editor-to-headset accessibility visibility tool | Code-level pass |
| `GuillemD/VRDesignPlayground` | VR accessibility design playground | Code-level pass |

## Project Notes

### `hai-vr/let-me-see`

- Interesting idea: Unity editor extension that lets a non-VR game developer or
  accessibility tester view Unity scene/game content in a headset.
- Code donor value: strong donor for Editor-window UX, XR lifecycle control from
  the editor, SceneView-to-HMD camera alignment, height/rescale settings,
  OpenXR force mode, and repaint/refresh hacks.
- Product reference value: excellent reference for "make development content
  visible in VR" tools, especially for accessibility review and non-specialist
  inspection.
- Architecture pattern: editor-only package with `LetMeSeeCore`, menu/window
  hooks, EditorPrefs/SessionState settings, SceneView callbacks, and XR
  Management start/stop control.
- Reusable method: `editor-driven VR visibility harness`.
- UX/product lesson: accessibility tooling can be a bridge for observers and
  testers, not only a runtime option menu inside the final app.
- Caveats: Unity-editor specific, relies on editor hooks and XR lifecycle
  mutation, and includes refresh hacks that need careful containment.
- Source evidence: `LetMeSeeCore.cs` toggles XR loaders/subsystems, maps
  SceneView/local camera modes into the VR camera, and restores camera state;
  `LetMeSeeEditorWindow.cs` exposes height, scale, alignment, cursor, OpenXR,
  and startup settings.
- Reusable core: editor surface, XR lifecycle gate, camera-mode selector,
  user-height/rescale settings, repaint/restart repair path, and state restore.
- What not to copy: editor hacks as runtime architecture or automatic OpenXR
  installation/mutation without explicit user control.
- Method catalog action: create an accessibility visibility/playground method.
- What to inspect next: editor preview, spectator, and headset mirror tools
  designed for accessibility review.

### `GuillemD/VRDesignPlayground`

- Interesting idea: Unity playground for experimenting with design solutions to
  common VR accessibility problems.
- Code donor value: moderate donor for height adjustment, locomotion button
  gates, hand presence, offset grab, custom throw, and simple physics buttons.
- Product reference value: useful as a small collection of accessibility design
  knobs rather than a monolithic app.
- Architecture pattern: XRI-era Unity sample with small independent scripts for
  interaction variants and comfort adjustments.
- Reusable method: `accessibility design playground`.
- UX/product lesson: accessibility experiments should be isolated into visible,
  switchable design primitives so teams can compare effects quickly.
- Caveats: bachelor-thesis/sample scale, limited documentation in the inspected
  tree, and many scripts are thin wrappers around standard XRI patterns.
- Source evidence: `HeightManager.cs`, `LocomotionController.cs`,
  `XROffsetGrabInteractable.cs`, `CustomThrowSystem.cs`, `HandPresence.cs`, and
  `PhysicsButton.cs` show independent interaction/comfort components.
- Reusable core: adjustable height, locomotion activation threshold, hand
  representation, offset grabs, simple object tasks, and playground-style scene
  grouping.
- What not to copy: sample-specific scene assumptions or old input helper usage
  without modern action-map review.
- Method catalog action: merge with editor visibility into a broader
  accessibility review/playground method.
- What to inspect next: compare with A11YTK, Locomotion Accessibility Toolkit,
  and low-vision/nonvisual accessibility repos already in the archive.

## Reusable Pattern Extraction

- Pattern candidate: `accessibility visibility and design playground`.
- Problem solved: VR accessibility work needs fast inspection and small
  comparable design primitives, not only large feature checklists.
- Reusable core: observer/headset view bridge, camera alignment modes,
  accessibility settings surface, height/scale controls, locomotion/interaction
  toggles, and playground scenes for comparison.
- Source evidence: `let-me-see` exposes editor content in VR; `VRDesignPlayground`
  breaks interaction variants into small scripts.
- Abstraction boundary: accessibility review surfaces and interaction knobs are
  reusable; editor lifecycle hacks and old XRI input helpers require isolation.

## Follow-Up Gaps

- Build a cross-wave accessibility matrix covering visibility, locomotion,
  low-vision, captions, haptics, hand-pose, and impairment simulation.
- Look for tools that combine headset mirror/review surfaces with structured
  accessibility checklists.
