# VR Projects Wave 180: XR Text-Entry Keyboards, Input Surfaces, and Pointer Bridges

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 180 studies XR text-entry surfaces: browser-rendered keyboards, WebXR
mesh keyboards, Unity physical keys, canvas-to-texture keyboards, hand-attached
experiments, A-Frame controller-ray keyboards, and virtual-keyboard plugin
boundaries.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `vuplex/unity-keyboard` | WebView keyboard bridge for Unity | Strong WebView/native-message donor |
| `felixtrz/xrkeys` | Three.js WebXR mesh keyboard | Strong ray/UV keyboard donor |
| `ErikSom/VirtualKeyboard-VR-Ready` | Canvas texture keyboard with suggestions | Strong texture/UV/suggestion donor |
| `robertlalum/vr-virtual-keyboard` | A-Frame controller keyboard and WebSocket bridge | Compact micro-utility donor |
| `JuliusWon/XR-Keyboard-for-Unity` | Minimal Unity UI keyboard | Thin procedural-grid baseline |
| `pinglis/XRSimpleKeyboard` | Unity physical collider keyboard | Strong physical key interaction donor |
| `MalekiRe/bevy_xr_keyboard` | Bevy/OpenXR hand-attached text entry | Experimental hand/pinch reference |
| `technobaboo/stardust-xr-keyboard-plugin` | Stardust XR Qt keyboard plugin sample | Thin shell key-event donor |

## `vuplex/unity-keyboard`

- Interesting idea:
  render a polished React/TypeScript keyboard inside a Vuplex 3D WebView and
  communicate typed input back to Unity through a small message protocol.
- Code donor value:
  high for WebView keyboard embedding, generated HTML/C# bundling, multilingual
  layout state, and JS-to-native message flow.
- Product reference value:
  high for VR forms, commands, overlay search, remote-control panels, and
  tools that already have a browser surface.
- What to inspect next:
  compare with native Unity physical keyboards and decide when WebView input is
  worth the dependency.
- Source evidence:
  `src/components/Keyboard/index.tsx`, `src/utils/sendKeyboardInput.ts`, and
  `scripts/generateCSharp.js`.
- Reusable pattern extraction:
  browser-rendered XR keyboard bridge.
- Reusable core:
  keep keyboard UI in a browser layer, define typed messages such as
  initialization, language, visibility, voice state, and input received, then
  generate a native-side bundle that can be loaded as HTML by the host app.
- Do not copy directly:
  Vuplex-specific assumptions or old JavaScript dependency versions.
- Caveats:
  this is a strong bridge pattern, not a standalone headset-native keyboard.

## `felixtrz/xrkeys`

- Interesting idea:
  use a compact GLB keyboard model and raycast-to-UV key masks so a WebXR app
  can get text input with only a few draw calls.
- Code donor value:
  high for the `XRKeys` update contract, controller target-ray picking,
  UV-to-key mapping, key-state coloring, and enter/shift/number handling.
- Product reference value:
  high for WebXR tools that need a drop-in spatial keyboard without loading
  fonts or many DOM elements.
- What to inspect next:
  compare its fixed key-mask model with canvas-rendered and collider-driven
  keyboards.
- Source evidence:
  `src/index.ts`.
- Reusable pattern extraction:
  raycast-to-UV mesh keyboard.
- Reusable core:
  expose a keyboard group with `update(targetRaySpace, pressed)`, raycast into
  a model, map UV coordinates through key masks, track press edges, dispatch
  key events, and keep layout toggles inside the component.
- Do not copy directly:
  fixed mesh/key mapping without a layout-authoring story.
- Caveats:
  Three.js-specific and visually/model dependent.

## `ErikSom/VirtualKeyboard-VR-Ready`

- Interesting idea:
  treat the keyboard as a canvas texture driven by UV pointer input, with
  multilingual layouts, texture dirty flags, swipe input, and suggestions.
- Code donor value:
  high for texture invalidation, UV-to-canvas mapping, layout switching,
  collision zones, swipe handling, and suggestion state.
- Product reference value:
  high for engine-neutral keyboard surfaces that can be painted onto a plane or
  embedded in a custom XR panel.
- What to inspect next:
  compare texture upload costs and UI clarity against mesh-key and WebView
  keyboard approaches.
- Source evidence:
  `src/index.js` plus `layout.js`, `collision.js`, `swipe.js`, `state.js`,
  `drawing.js`, and `events.js`.
- Reusable pattern extraction:
  canvas texture keyboard with explicit dirty state.
- Reusable core:
  map pointer UVs into canvas pixels, update keyboard state and suggestions,
  mark the texture dirty only when redraw is needed, expose layout/language
  controls, and let the host poll or observe the dirty flag.
- Do not copy directly:
  one project's word lists or rendering defaults without localization review.
- Caveats:
  strong as an input-surface pattern, but needs host-side texture integration.

## `robertlalum/vr-virtual-keyboard`

- Interesting idea:
  implement a small A-Frame keyboard where controller raycasters click keys and
  optional WebSocket messages forward text, keys, and pointer actions.
- Code donor value:
  medium for a compact ray-keyboard baseline and remote pointer/text bridge.
- Product reference value:
  medium-high for tiny browser-native VR utilities, remote-control panels, and
  proof-of-value text surfaces.
- What to inspect next:
  separate the reusable WebSocket protocol from the one-file demo structure.
- Source evidence:
  `index.html`.
- Reusable pattern extraction:
  controller-ray keyboard plus remote bridge.
- Reusable core:
  create key planes from a layout array, attach click handlers, update an
  in-world text buffer, map controller intersections to normalized pointer
  coordinates, and optionally send key/text/pointer messages over WebSocket.
- Do not copy directly:
  CDN/demo structure or rough pointer mapping.
- Caveats:
  useful as a micro-utility reference, not a polished keyboard framework.

## `JuliusWon/XR-Keyboard-for-Unity`

- Interesting idea:
  generate a simple Unity key grid and append key values into a `TMP_InputField`
  using per-key button scripts.
- Code donor value:
  low-medium for procedural key placement and minimal Unity UI wiring.
- Product reference value:
  medium as a bare baseline for "how little code can create a VR keyboard".
- What to inspect next:
  compare with `XRSimpleKeyboard` before reusing any interaction code.
- Source evidence:
  `VRKeyboard/Assets/Key.cs` and
  `VRKeyboard/Assets/KeyCentralController.cs`.
- Reusable pattern extraction:
  minimal procedural Unity keyboard grid.
- Reusable core:
  define a key layout, instantiate key prefabs with labels, route per-key click
  events to a central input field, and keep the keyboard as ordinary Unity UI.
- Do not copy directly:
  the hardcoded delete behavior and generated Unity cache/artifact structure.
- Caveats:
  thin donor; useful mainly as a baseline comparison.

## `pinglis/XRSimpleKeyboard`

- Interesting idea:
  make a keyboard feel physical by using trigger-collider presses, per-key
  press depth, material changes, localized labels, and UnityEvents.
- Code donor value:
  high for physical key press state, multi-collider overlap tracking, layout
  width rows, key-width prefabs, and key events.
- Product reference value:
  high for controller/direct-touch VR menus where "pressing a key" should be
  tangible rather than a ray click.
- What to inspect next:
  combine its press model with better text-editing and accessibility behaviors.
- Source evidence:
  `Keyboard.cs`, `KeyBehaviour.cs`, `LayoutManager.cs`, `EnGbLayout.cs`, and
  `UIController.cs`.
- Reusable pattern extraction:
  physical collider keyboard with stable key press lifecycle.
- Reusable core:
  instantiate rows from layout data, choose prefabs by key width, set labels
  from locale maps, track all pressing colliders in a set, move the key mesh by
  press depth, change materials, and emit `OnKeyDown`/`OnKeyUp` events.
- Do not copy directly:
  generated Unity project folders or single-locale assumptions.
- Caveats:
  interaction donor is stronger than its editing model.

## `MalekiRe/bevy_xr_keyboard`

- Interesting idea:
  attach text entry to the user's hands: a keyboard billboard on one palm,
  output on the other, and pinch gestures to select characters.
- Code donor value:
  medium for Bevy/OpenXR hand attachment, pinch thresholding, and minimal
  hand-first text entry.
- Product reference value:
  medium for experimental wrist/palm UI concepts where a full keyboard is too
  large.
- What to inspect next:
  compare with hand-menu and wrist-dashboard patterns from earlier waves.
- Source evidence:
  `src/lib.rs` and `src/main.rs`.
- Reusable pattern extraction:
  palm-attached pinch-select text entry.
- Reusable core:
  parent text surfaces to tracked palm joints, use fingertip distances as a
  pinch trigger, cycle or select characters from hand motion, and keep output
  visible on the opposite hand.
- Do not copy directly:
  debug-only character cycling or experimental Bevy/OpenXR assumptions.
- Caveats:
  no README and not a complete keyboard; valuable as hand-UI sketch.

## `technobaboo/stardust-xr-keyboard-plugin`

- Interesting idea:
  implement a minimal Stardust XR virtual keyboard plugin that emits Qt key
  press/release events on a timer.
- Code donor value:
  low-medium for plugin boundary and host key-event injection shape.
- Product reference value:
  medium for Linux/XR shell integrations where keyboard output should be a
  shell service rather than app-local UI.
- What to inspect next:
  compare with fuller Stardust XR input and compositor utilities.
- Source evidence:
  `keyboardplugin.cpp` and `samplekeyboard.cpp`.
- Reusable pattern extraction:
  shell keyboard plugin emitting synthetic key events.
- Reusable core:
  expose a keyboard plugin instance, map UI actions to `QKeyEvent` press
  events, and schedule a short delayed release through a timer.
- Do not copy directly:
  the sample-only hardcoded `Shift+F` output.
- Caveats:
  historically useful boundary sample, not a production keyboard.

## Cross-Project Lessons

- XR keyboard implementation is less about key labels and more about the input
  boundary: WebView message bridge, UV mesh, canvas texture, collider key,
  hand-pinch, WebSocket, or shell key event.
- Canvas and WebView approaches centralize text UI complexity, while mesh and
  collider approaches better match direct spatial interaction.
- Good future VR utility keyboards need explicit focus, destination, language,
  editing state, privacy, and accessibility behavior.

## Methods Added Or Reinforced

- WebView/browser-rendered XR keyboard bridge.
- Raycast/UV and physical-collider keyboard input.
- Canvas texture keyboard with dirty-state updates.
- Shell keyboard plugin key-event injection.

## Follow-Up Gaps

- Build a keyboard comparison matrix across WebView, mesh, canvas, collider,
  hand-attached, A-Frame, and shell-key approaches.
- Decide whether future `VR-apps-lab` prototypes need one shared input-surface
  abstraction for text entry.
- Revisit already-studied `ultraleap/XR-Keyboard` as an overlap comparison,
  not as a duplicate registry entry.
