# GitHub Research Wave 118 Backlog

- Date: `2026-06-05`
- Scope: Unreal VR interaction frameworks, MR UX plugins, comfort effects,
  OpenXR hand tracking, Vive tracker role plugins, and multiplayer XR utility
  components.

## Completed in this wave

- Studied `mordentral/VRExpansionPlugin` as the strongest Unreal donor for
  replicated VR grips, motion-controller behavior, VR movement, and OpenXR
  hand pose integration.
- Studied `1runeberg/RunebergVRPlugin` as a compact component pack for pawn,
  grab, movement, teleport, gaze, gestures, and climb patterns.
- Studied `microsoft/MixedReality-UXTools-Unreal` as an archived but valuable
  MR UX reference for near/far input, hand simulation, hand menus, pressable
  controls, sliders, bounds, manipulation, constraints, and touchables.
- Studied `sigtrapgames/VrTunnellingPro-UE4` as a comfort/vignette/tunnelling
  post-process and preset reference.
- Studied `demonixis/FSOpenXRHandTracking` as a compact OpenXR hand-tracking,
  pinch, ray, and Enhanced Input adapter.
- Studied `Rectus/UE4OpenXRViveTrackerPlugin` as an OpenXR extension plugin
  that maps Vive tracker roles into Unreal motion sources.
- Studied `V4C38/ue5-xrcore` as a modern small multiplayer interaction
  framework with hands, lasers, interactors, connectors, and replicated physics.

## Reuse candidates

- `VRExpansionPlugin` should be treated as the strongest donor for replicated
  grip/movement architecture.
- `MixedReality-UXTools-Unreal` should be used as a UX primitive reference even
  though it is archived.
- `FSOpenXRHandTracking` is useful for a focused hand tracking adapter pattern.
- `UE4OpenXRViveTrackerPlugin` is a narrow but valuable OpenXR extension
  pattern for tracker roles.
- `VrTunnellingPro-UE4` is primarily a product/comfort reference.

## Follow-up backlog

1. Compare Unreal replicated grip authority with OpenVR overlay input bridges
   and Unity networked interaction frameworks.
2. Deepen `VRExpansionPlugin` only if a future Unreal utility prototype needs
   actual controller/replication patterns.
3. Extract a cross-engine "near/far MR UI primitive" table from MRTK,
   UXTools-Unreal, Godot XR Tools, and A-Frame components.
4. Compare comfort/tunnelling plugin patterns against accessibility and
   simulator sickness mitigation tools already in the landscape.
5. Revisit OpenXR tracker role plugins if custom-device or tracker inventory
   work resumes.

## Quality notes

- No third-party project was built or launched.
- Downloaded source clones belong only in local cache and should be removed
  after the wave is committed.
- Unreal repositories are captured as donor/reference material, not as a
  supported engine target commitment.
