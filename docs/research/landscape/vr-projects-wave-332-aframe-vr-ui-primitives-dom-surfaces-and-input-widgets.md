# Wave 332 - A-Frame VR UI Primitives, DOM Surfaces, and In-Scene Input Widgets

This wave studies browser-native VR UI primitives for A-Frame/WebXR scenes:
HTML-to-plane rendering, in-scene flex-like layout, virtual keyboard input, and
camera-facing dialog popups.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to:

- A-Frame UI widgets and surface primitives;
- raycaster/controller to 2D coordinate translation;
- browser DOM, text, and keyboard interaction inside VR scenes;
- reusable overlay-panel lessons for future VR utilities.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `supereggbert/aframe-htmlembed-component` | A-Frame DOM-to-plane UI surface | Studied | Strong donor for rendering HTML into a canvas texture, mapping raycaster intersections into pixel coordinates, forwarding mouse/focus/input events, and throttling DOM mutation redraws |
| `binzume/aframe-xylayout` | A-Frame flex-like 2D UI layout and widgets | Studied | Strong donor for `xycontainer`, `xyrect`, `xyinput`, widget themes, canvas/text fallback, haptic hover hints, caret handling, copy/paste, and IME-like input paths |
| `WandererOU/aframe-keyboard` | A-Frame virtual keyboard | Studied | Useful micro-donor for separating keyboard rendering, desktop key forwarding, VR click forwarding, locale templates, and key button hover/press feedback |
| `EditVR/aframe-dialog-popup-component` | A-Frame dialog popup component | Studied | Useful product reference for configurable open/close icons, title/body/image composition, close behavior, and camera-facing popup placement |

## Code-Level Findings

### `supereggbert/aframe-htmlembed-component`

- Interesting idea: normal HTML can become a VR-facing panel by serializing the
  DOM into an SVG/canvas texture and using raycaster hit UVs as mouse events.
- Code donor value: high. `aframe-htmlembed-component.js` creates a
  `THREE.CanvasTexture`, plane mesh, raycaster hooks, and mousedown/up/move
  forwarding. `htmlcanvas.js` observes DOM mutations, rewrites hover/active/
  focus/target CSS into class hacks, serializes layout, and emits resize,
  rendered, focusable, and input-required events.
- Product reference value: high for overlay-like settings panels, browser
  documentation panels, forms, and simple control surfaces in WebXR.
- What to inspect next: keyboard/input handling around `inputrequired`, CSS
  coverage, focus cleanup, and performance under frequent DOM changes.
- Architecture pattern: DOM source + SVG/canvas renderer + texture plane +
  ray-to-pixel event bridge.
- Reusable method: HTML control panel rendered as an XR surface.
- Constraints / caveats: browser/CSS edge cases, mutation redraw cost, old
  A-Frame packaging, and focus/event cleanup issues.
- Why it matters for `VR-apps-lab`: it gives a direct WebXR equivalent of an
  overlay panel without native OpenVR/OpenXR overlay APIs.

### `binzume/aframe-xylayout`

- Interesting idea: A-Frame scenes can use a compact 2D UI system with
  container layout, widgets, text, caret, copy/paste, keyboard request events,
  and haptic hover cues.
- Code donor value: high. `xycontainer` implements row/column, wrapping,
  padding, spacing, grow/shrink, align, justify, and stretch behavior.
  `xyinput` adds value/caret state, click-to-caret placement, copy/paste, arrow
  keys, backspace, and `xykeyboard-request`. `xywidget` defines rounded rects,
  labels, theme defaults, hover color, and optional haptics.
- Product reference value: very high for WebXR settings panels, inspector
  panels, and simple data-entry surfaces.
- What to inspect next: `xywindow`, scroll widgets, resize helpers, CSS bridge,
  and accessibility/keyboard focus limitations.
- Architecture pattern: layout primitives + widget theme + event-driven input
  request + text/canvas fallback.
- Reusable method: lightweight in-scene 2D UI layout system.
- Constraints / caveats: old A-Frame assumptions, some IME table text appears
  encoding-damaged in local output, and direct package reuse needs review.

### `WandererOU/aframe-keyboard`

- Interesting idea: a VR keyboard can be a narrow component that renders keys
  from a template and routes both physical keyboard events and VR click events
  through the same validation path.
- Code donor value: medium. `a-keyboard` draws from `AFK.template`, registers
  window `keydown`, listens for VR `click`, and forwards both to the event
  utility. `keyboard-button` adds hover/mousedown opacity feedback.
- Product reference value: medium-high for text-entry utility panels.
- What to inspect next: keyboard template layout, i18n handling, custom model
  textures, and event dispatch payloads.
- Caveat: small and older; use as a product/UX reference more than as a direct
  dependency.

### `EditVR/aframe-dialog-popup-component`

- Interesting idea: a dialog can be modeled as an attachable entity that owns
  an opener icon, generated title/body/image child entities, and a close icon.
- Code donor value: medium. `index.js` exposes clear schema fields, creates
  open/close icons, generates dialog plane/title/body/image, toggles visibility,
  and repositions the popup while open.
- Product reference value: high for contextual help bubbles, onboarding
  callouts, object annotations, and VR utility hints.
- What to inspect next: `positionDialogPlane`, body/image layout constraints,
  event listener cleanup, and multiple dialog composition.
- Caveat: older A-Frame version and simple visuals, but still useful as a
  micro-utility UX reference.

## Reusable Pattern Extraction

- Pattern candidate: browser-native VR UI primitive layering.
- Problem solved: WebXR utilities need overlay-like panels, labels, dialogs,
  and text input without depending on native desktop overlay APIs.
- Reusable core: panel surface, layout container, widget theme, label/text
  renderer, ray-to-coordinate bridge, keyboard request event, virtual keyboard,
  focus/caret state, popup anchoring, and close/open lifecycle.
- Source evidence: `supereggbert/aframe-htmlembed-component`,
  `binzume/aframe-xylayout`, `WandererOU/aframe-keyboard`, and
  `EditVR/aframe-dialog-popup-component`.
- Abstraction boundary: keep surface rendering, layout, input capture,
  keyboard dispatch, popup lifecycle, and application data separate.
- What not to copy: old bundling assumptions, fragile global events, direct DOM
  mutation redraws without throttling, and monolithic UI packages that merge
  layout with business logic.
- Method catalog action: add browser-native VR UI primitive layering.

## Follow-Up Gaps

- Compare DOM-to-plane rendering with native overlay surface waves.
- Build a small WebXR utility-panel checklist from HTML surface, layout, input,
  keyboard, and dialog primitives.
- Revisit A-Frame keyboard/input projects if stronger maintained variants
  appear.
