# VR Projects Wave 408 - Spatial UI Widgets Layouts And Input-Neutral Panels

- Date: `2026-07-13`
- Scope: VR UI libraries and samples that treat panels, widgets, pointer rays,
  controller contacts, or hand input as reusable spatial interaction substrate.
- Rule: source/documentation reading only; no builds, installs, launches, or
  device tests were performed.

## Shortlist

- `artflow-vr/vr-ui`
- `csiro-scientific-computing/vr-ui`
- `MT-ZD/Godot-3D-VR-UI`
- `Squareys/magnum-vr-ui`

## Why This Wave Matters

These projects reinforce a useful design rule for future `VR-apps-lab`
utilities: make the UI panel model independent from the input source. A good
overlay or in-world utility should not care whether activation comes from a
ray, hand collider, physical press, Leap pointer, or synthetic mouse event. The
panel should expose layout, state, hit testing, and command events; the input
adapter should be swappable.

## Project Notes

### `artflow-vr/vr-ui`

- Interesting idea: Three.js UI framework with `Element`, `GridLayout`,
  horizontal/vertical layouts, view classes, and `THREE.Object3D` input objects.
- Architecture pattern: scene-graph UI widgets arranged by layout classes rather
  than DOM/CSS, with a `VRUI` facade exporting layouts and view primitives.
- Code donor value: useful lightweight reference for grid/linear spatial layout,
  padding/alignment, element refresh, and object-based input registration.
- Product reference value: shows how small 3D UI widgets can become a menu
  grammar for WebXR panels without tying the panel to one controller model.
- Source evidence: `src/vr-ui.js`, `src/layouts/grid-layout.js`,
  `src/layouts/linear-layout.js`, `src/views/*`, and README examples around
  `VRUI.addInput()` and `gui.refresh()`.
- Reusable core: layout-driven widget tree with a small input registration
  boundary.
- What not to copy: the repository is discontinued and has TODOs around
  animation, show/hide, and layout bugs; treat it as a pattern donor, not a
  production dependency.
- What to inspect next: whether its widget model can be represented as a common
  neutral schema for WebXR, Godot, Unity, and native OpenXR utility panels.

### `csiro-scientific-computing/vr-ui`

- Interesting idea: Unity VR UI elements split into `InteractionSurface` and
  `InteractionVolume` models, with controller-specific adapters behind the UI.
- Architecture pattern: colliders and kinematic rigidbodies define interactive
  affordances; state objects carry colors, haptics, and begin/continuous/end
  UnityEvents.
- Code donor value: strong state machine reference for hover, activation,
  release, haptic feedback, sliders, radial dials, and button-like surfaces.
- Product reference value: good UX reference for physical-feeling controls that
  do not require flat laser-only menu interaction.
- Source evidence: `VRUI_InteractionSurface.cs`,
  `VRUI_InteractionVolume.cs`, `VRUI_Controller.cs`,
  `InteractionSurfaces/VRUI_Button.cs`, `VRUI_RadialDial.cs`, and
  `VRUI_Slider.cs`.
- Reusable core: interaction surfaces as stateful contact zones with explicit
  feedback payloads and threshold rules.
- What not to copy: old SteamVR/HTC Vive dependency and Unity-era assumptions;
  reuse the interaction-state grammar, not the exact SDK binding.
- What to inspect next: extract a generic `surface press`, `volume drag`, and
  `dial/slider` method that can be paired with modern OpenXR input.

### `MT-ZD/Godot-3D-VR-UI`

- Interesting idea: Godot `SubViewport` rendered onto a 3D quad, with controller
  ray hits translated into synthetic mouse motion and click events.
- Architecture pattern: `UI3D` owns `SubViewport`, `MeshInstance3D`, `Area3D`,
  and collision geometry; `Hand` owns `XRController3D`, `RayCast3D`, and the
  input bridge.
- Code donor value: compact reference for turning ordinary UI into a spatial
  panel while preserving engine-native UI event handling.
- Product reference value: useful for VR utility settings panels, diagnostics
  pages, and browser-like surfaces where existing 2D UI should not be rewritten.
- Source evidence: `UI3D.cs`, `Player/Hand.cs`, `3DUI.tscn`, and `main.tscn`.
- Reusable core: viewport-to-texture panel with raycast-to-2D coordinate
  conversion and synthetic input injection.
- What not to copy: keep the bridge explicit; do not hide coordinate
  conversion or input focus state inside scene magic.
- What to inspect next: combine with Wave 409 WebView findings for browser or
  inspector panels in Godot/OpenXR tools.

### `Squareys/magnum-vr-ui`

- Interesting idea: C++ Magnum UI gallery adapted for Oculus and Leap Motion.
- Architecture pattern: native C++ UI widgets and modal/input/button styles
  integrated with VR pose/input instead of an engine UI canvas.
- Code donor value: small native reference for bringing widget libraries into a
  VR render loop and mapping hand/pointer input into controls.
- Product reference value: validates that native C++ VR utilities can still use
  structured UI components instead of ad hoc immediate-mode overlays.
- Source evidence: `src/VrGallery.cpp` includes Magnum `Ui::Button`,
  `Ui::Input`, `Ui::Label`, `Ui::Modal`, `Ui::Plane`, Oculus integration, and
  Leap Motion integration.
- Reusable core: native widget plane plus hand/controller pointer adapter.
- What not to copy: legacy Oculus/Leap/Windows-specific dependency envelope.
- What to inspect next: compare native widget-plane patterns with OpenXR sample
  overlays and desktop overlay shells.

## Extracted Method Candidate

`Input-neutral spatial UI panel grammar`: define a panel as layout, widget
state, hit regions, command events, and feedback payloads; bind input through
separate adapters for ray, hand collider, physical press, synthetic mouse, or
native pointer.

## Follow-Up

- Create a small reusable method entry for input-neutral spatial panels.
- Revisit older Waves 29, 30, 52, 91, 186, and 223 for overlap with menus,
  hand/palm UI, and creator workbench panels.
