# GitHub Research Wave 180 Plan

- Date: `2026-06-06`
- Theme: `XR text-entry keyboards, input surfaces, and pointer/text bridges`
- Scope: WebView keyboards, WebXR/Three.js keyboards, Unity collider
  keyboards, canvas-texture keyboards, hand-attached text entry, A-Frame
  controller keyboards, and shell keyboard plugin samples.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Many VR utilities eventually need reliable text input: search boxes, chat,
commands, OSC/chatbox entry, settings, labels, and remote-control fields. This
wave studies keyboard/input-surface projects as reusable UI and protocol
patterns rather than as one-off demos.

## Search Families

- Unity and WebView keyboard surfaces
- WebXR/Three.js keyboard meshes
- canvas-backed keyboard textures
- Unity XR collider keyboards
- A-Frame controller-ray keyboards
- hand-attached experimental keyboards
- Linux/XR shell keyboard plugin samples

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `vuplex/unity-keyboard` | Browser-rendered keyboard UI with JS-to-Unity message bridge and generated C# HTML bundle | WebView keyboard bridge |
| `felixtrz/xrkeys` | Low-draw-call Three.js WebXR keyboard with UV key-mask picking | WebXR keyboard mesh |
| `ErikSom/VirtualKeyboard-VR-Ready` | Canvas keyboard with UV pointer input, dirty texture flag, multilingual layouts, and swipe suggestions | Canvas texture keyboard |
| `robertlalum/vr-virtual-keyboard` | Single-file A-Frame controller-ray keyboard with optional WebSocket bridge | A-Frame controller keyboard |
| `JuliusWon/XR-Keyboard-for-Unity` | Minimal Unity procedural key grid for Unity UI fields | Unity keyboard baseline |
| `pinglis/XRSimpleKeyboard` | Physical Unity XR collider keyboard with localized layouts and press-state tracking | Unity physical keyboard |
| `MalekiRe/bevy_xr_keyboard` | Experimental Bevy/OpenXR hand-attached text entry with pinch selection | Hand-attached keyboard experiment |
| `technobaboo/stardust-xr-keyboard-plugin` | Stardust XR Qt virtual-keyboard plugin emitting key events | Shell keyboard plugin sample |

## Dedupe Notes

- Earlier text-input and overlay waves covered VR keyboard product directions,
  but these specific implementation nodes were not deeply studied.
- `ultraleap/XR-Keyboard` was found during search but was already studied, so
  it was not added as a new Wave 180 node.
- Thin samples are retained only when they expose a useful boundary, such as
  shell key-event injection or a minimal procedural keyboard baseline.

## Code-Level Pass Targets

- JS/native message protocols and generated embedded HTML;
- ray-to-UV picking, key-mask meshes, and controller update contracts;
- canvas texture update/dirty flags and multilingual layout data;
- collider-based physical key press tracking and two-hand overlap handling;
- hand-attached keyboard placement and pinch-selection experiments;
- optional WebSocket text/pointer bridge behavior;
- plugin-level key event injection.

## Expected Outputs

- Wave 180 landscape synthesis.
- Registry/family placement for XR text-entry and keyboard-surface projects.
- Methods around WebView keyboards, UV/collider keyboard input, canvas dirty
  texture updates, and shell keyboard injection boundaries.
