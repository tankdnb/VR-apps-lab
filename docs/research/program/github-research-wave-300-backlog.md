# GitHub Research Wave 300 Backlog - XR Text Entry, Keyboard Variants, Gaze, Dictation, and Query Input Surfaces

## Executed Scope

- Searched and deduplicated Unity XR keyboard packages, Magic Leap keyboard
  package code, gaze/dwell keyboard prototypes, and VR search/query text-entry
  systems.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted keyboard manager/layout/input receiver boundaries, direct
  interaction adapters, gaze/dwell selection, static text routing, physical
  keyboard generation, dictation-adjacent text routing, and query-term UI
  lessons.

## Studied Projects

- `ViRGIS-Team/VR-Keyboard`
- `magicleap/MagicLeapXRKeyboard`
- `fabio914/EyeTrackingKeyboard`
- `vitrivr/vitrivr-vr`

## Backlog Findings

- Build a text-entry matrix across controller ray, direct poke, gaze/dwell,
  physical key surfaces, dictation, command palettes, and query tokens.
- Deepen `MagicLeapXRKeyboard`, `VR-Keyboard`, and `vitrivr-vr` as strongest
  donors.
- Compare with older WebView, VRChat keyboard, A-Frame UI, and accessibility
  text waves so rendering, target routing, and input mode are not conflated.
- Consider a reuse plan for an XR text-entry kit with layout data, target
  adapters, privacy mode, dwell settings, haptics, and validation hooks.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an XR text-entry method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
