# VR Projects Wave 155: Hand Tracking, Simulated XR Hands, and Reusable Hand/Control Primitives

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 155 studies hand/control primitives from the implementation side:
extension-level hand tracking in Unity OpenXR, no-HMD hand/body simulation for
editor work, source-light gesture pose packaging, and broader scientific XR
toolkit components that combine input, data capture, sockets, menus, and guided
setup.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `joemarshall/openxrhands` | Native/engine hand tracking bridges | Strong extension-boundary donor |
| `MThogersen/AutoHandSimulator` | No-HMD hand simulation | Strong editor-workflow donor |
| `InfernoDigital/RoboHands-UnityXR` | Gesture-pose package references | Source-light product reference |
| `eisclimber/ExPresS-XR` | Unity XR toolkit primitives | Strong toolkit-pattern donor |

## `joemarshall/openxrhands`

- Interesting idea:
  expose `XR_EXT_hand_tracking` and Oculus `XR_FB_hand_tracking_mesh` to Unity
  through a custom OpenXR feature before high-level package support is enough.
- Code donor value:
  high for understanding extension-level Unity/OpenXR boundaries.
- Product reference value:
  medium. It is more useful as implementation research than as a finished
  product.
- What to inspect next:
  compare with modern Unity OpenXR hand tracking support before reusing any
  extension-level code.
- Architecture pattern:
  Unity `OpenXRFeature` declares required extensions, hooks
  `xrGetInstanceProcAddr`, wraps `xrWaitFrame` to keep predicted display time,
  creates hand trackers on session begin, P/Invokes `xrLocateHandJointsEXT` and
  `xrGetHandMeshFB`, pins arrays, converts OpenXR coordinates to Unity, builds
  a skinned hand mesh, and updates bones from located joints.
- Reusable method:
  OpenXR extension bridge for hand joints and skinned hand meshes.
- Caveats:
  experimental/old, Oculus mesh-extension-specific, and manual memory pinning
  requires care.

## `MThogersen/AutoHandSimulator`

- Interesting idea:
  simulate AutoHand player, head, and hand controls with keyboard/mouse so
  interaction work can continue without wearing a headset.
- Code donor value:
  high for editor/debug workflow design.
- Product reference value:
  high. It turns no-HMD development from a workaround into a deliberate utility
  mode.
- What to inspect next:
  compare with `GodotXRDesktop`, WebXR emulator patterns, and virtual-HMD
  drivers to build a cross-engine no-HMD testing guide.
- Architecture pattern:
  Unity editor component detects Mock HMD/no-real-HMD state, finds
  `TrackedPoseDriver`s for head and hands, replaces them with simulated pose
  drivers, optionally disables interfering AutoHand links, maps keyboard/mouse
  modes to body/head/left/right/both-hand movement, and triggers grab/release
  actions plus reset behavior.
- Reusable method:
  no-HMD interaction simulator by replacing pose providers and mapping desktop
  input to hand/body controls.
- Caveats:
  AutoHand-specific, legacy-input-biased, and intended for editor/debug use.

## `InfernoDigital/RoboHands-UnityXR`

- Interesting idea:
  package Unity XR hand presence and multi-pose hand gestures with a clear
  inventory of common poses.
- Code donor value:
  low. The visible repository is source-light and points to external package
  downloads/demos.
- Product reference value:
  medium. The pose inventory and onboarding framing are useful.
- What to inspect next:
  revisit only if package source becomes public or local source is available.
- Architecture pattern:
  product-level only: hand presence, animation controller, prefabs, and poses
  such as idle, fist, grip, pinch, point, finger gun, thumbs, and open.
- Caveats:
  old Unity/XR package assumptions and missing source keep it out of the code
  donor lane.

## `eisclimber/ExPresS-XR`

- Interesting idea:
  a broad Unity OpenXR toolkit for experiments, presentations, and science that
  combines configurable rigs, input modes, interaction primitives, data export,
  menus, setup dialogs, and exhibition helpers.
- Code donor value:
  high, especially for toolkit organization and reusable primitives.
- Product reference value:
  high. It shows how a research/experiment toolkit can be packaged as reusable
  setup flows rather than one monolithic scene.
- What to inspect next:
  isolate menu/keyboard/data-gathering/accessibility modules only if a Unity
  utility prototype becomes active.
- Architecture pattern:
  modular Unity toolkit with data-gathering components, value-range
  interactables, socket highlighting, virtual hands, near/far/grab/poke
  interaction modes, movement presets, HUDs, localization, quizzes, room
  creation, setup dialogs, and editor menu factories.
- Reusable method:
  scientific XR toolkit pattern with configurable rig, data export, generic
  value-range interactables, socket highlighters, and editor-created setup
  surfaces.
- Caveats:
  large toolkit; reuse should happen by extracting specific primitives and
  comparing them with MRTK, VRTK, and VR Builder rather than copying the whole
  ecosystem.

## Cross-Project Lessons

- Hand input has at least three reusable layers: runtime extension data,
  engine pose/action injection, and product-level gesture/pose vocabulary.
- No-HMD hand simulators are a productivity feature, not just a test shortcut.
- Extension-level bridges are valuable documentation even when modern engine
  packages later replace them.
- Research/experiment toolkits should expose data capture and setup flows as
  first-class primitives, not hidden scene glue.

## Reusable Methods Extracted

- OpenXR hand extension bridge for joints and skinned hand meshes.
- No-HMD interaction simulator through pose-provider replacement.
- Gesture-pose inventory as product packaging reference.
- Scientific XR toolkit pattern with data gathering, value interactables,
  sockets, and editor menu factories.

## Follow-Up Backlog

- Build a no-HMD hand/control matrix across Unity, Godot, WebXR, and virtual
  driver approaches.
- Compare old extension-level hand bridges with current Unity OpenXR support
  before direct reuse.
- Keep source-light hand-pose packages as product references until real source
  is available.
