# Wave 393: Low-Vision, Nonvisual, and Haptic Accessibility Toolkits

## Theme

Accessibility beyond captions: low-vision scene assistance, magnification,
nonvisual physical activity, spatial audio, haptics, and configurable
accessibility requirements.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `XR-Access-Initiative/Vision-Accessibility-Toolkit` | Studied | FirstHand-derived visual accessibility toolkit/reference project |
| `SuHCI/MagniVR` | Studied | VR magnification/low-vision research prototype with models and UI prototype folders |
| `xability/punch-pulse` | Studied | Accessible VR boxing app for blind/low-vision users using spatial audio and haptics |

## Dedupe Notes

Prior accessibility waves covered captions and ASL. This wave focuses on visual
impairment and nonvisual action loops where audio/haptic feedback replaces
visual dependency.

## Code-Level Findings

### `XR-Access-Initiative/Vision-Accessibility-Toolkit`

- Interesting idea: adapt a full hand-interaction sample into a visual
  accessibility toolkit/reference project.
- Code donor value: `Unity-FirstHand-with-VRC 5`, sample framework scripts,
  hand interaction scenes, audio cues, and FirstHand documentation show a
  vendor-sample-derived accessibility reference.
- Product reference value: useful for evaluating how accessibility changes can
  be layered onto an existing MR/hand app.
- What to inspect next: visual accessibility components, contrast/visibility
  settings, object focus cues, and package extraction boundary.
- Caveat: large vendor sample base; extract accessibility deltas, not sample
  bulk.

### `SuHCI/MagniVR`

- Interesting idea: low-vision support can be studied as a magnification
  research prototype with room/model assets and UI prototype artifacts.
- Code donor value: `VR-Room-2`, `Models`, `UI Prototype`, and design assets
  show a research-workbench layout for magnification UX.
- Product reference value: useful for magnifier/zoom panel concepts in future
  VR utility overlays.
- What to inspect next: lens placement, zoom scale controls, focus target,
  field-of-view comfort, and user study notes.
- Caveat: research prototype shape may require manual reconstruction of
  implementation details.

### `xability/punch-pulse`

- Interesting idea: build a VR boxing game that avoids visual dependency using
  spatial audio, haptics, accessible menus, and contribution rules that preserve
  accessibility.
- Code donor value: README architecture references `BackgroundAudio`, `Menu`,
  haptic system, spatial audio/HRTF, tutorial manager, and accessibility
  contribution checklist.
- Product reference value: strong reference for nonvisual action loops and
  accessible contribution standards.
- What to inspect next: audio cue taxonomy, haptic patterns, menu navigation,
  tutorial sequencing, and fallback policies.
- Caveat: gameplay specifics should not be copied into generic accessibility
  modules.

## Reusable Pattern Extraction

- Pattern candidate: nonvisual/low-vision accessibility feedback loop.
- Problem solved: VR utilities need alternatives to sight: magnification,
  object focus, spatial audio, haptic confirmation, accessible menus, and
  contribution tests.
- Reusable core: magnifier lens, focus target, contrast/visibility preference,
  audio cue, haptic cue, accessible tutorial step, nonvisual menu navigation,
  contribution checklist, fallback mode, and comfort label.
- Source evidence: Vision Accessibility Toolkit FirstHand-derived project,
  MagniVR room/model/UI prototype folders, and Punch Pulse README plus
  tutorial/accessibility files.
- Abstraction boundary: accessibility feedback primitives should not depend on
  one game loop or one vendor scene.
- What not to copy: visual-only affordances, magnification without comfort
  limits, haptics without semantics, or contribution rules that are not tested.
- Method catalog action: add Method 838.

## Family Placement

Creates a low-vision/nonvisual accessibility family.

## Follow-Up Gaps

- Draft low-vision settings vocabulary: magnification, contrast, cue channel,
  menu scale, and comfort.
- Compare haptic cue semantics across accessibility and gameplay methods.
- Add accessibility contribution checklist to future prototypes.
