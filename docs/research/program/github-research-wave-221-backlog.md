# GitHub Research Wave 221 Backlog

Date: 2026-06-06

Theme: vendor OpenXR extension stacks, feature wrappers, and sample matrices.

## Completed In This Wave

- Studied `microsoft/OpenXR-MixedReality` as a C++ sample matrix for HoloLens
  and WMR features, including session/event/frame basics, hand tracking, eye
  gaze, scene markers/QR, controller models, secondary views, and spatial
  anchors.
- Studied `microsoft/Microsoft-OpenXR-Unreal` as a modular Unreal plugin that
  registers optional feature modules for spatial anchors, hand mesh, secondary
  views, QR tracking, PV camera, speech, spatial mapping, scene understanding,
  remoting, and window attachment.
- Studied `meta-quest/Meta-OpenXR-SDK` as a Quest native SDK/sample matrix
  covering social presence, colocation, compositor layers, haptics, hands,
  passthrough, depth/occlusion, scene, anchors, virtual keyboard, and SpaceWarp.
- Studied `mikeskydev/unity-openxr-extensions` as a small Unity OpenXR
  extension wrapper set with generic `FeatureBase<T>`, FB passthrough, META
  boundary visibility, FB/META body tracking, function pointer hooks, lifecycle
  handles, and Android manifest edits.
- Added a reusable method entry for vendor OpenXR extension wrappers.

## Follow-Up Queue

1. Build an OpenXR extension-wrapper matrix: extension string, feature check,
   lifecycle handles, function loading, build gate, UX surface, and caveats.
2. Compare Microsoft QR tracking and Meta scene/anchor samples as alternate
   scene-understanding entry points.
3. Compare Unity `OpenXRFeature` wrappers with Unreal modular feature
   registration to clarify engine-specific boundaries.
4. Extract a minimal "extension helper" skeleton for future `VR-apps-lab`
   prototypes without vendor SDK coupling.
5. Track which Meta preview APIs have moved into Khronos or stable SDK
   releases before using them in product-facing docs.

## Do Not Spend Time On Yet

- Do not install vendor SDKs or run sample apps.
- Do not claim extension availability without runtime checks.
- Do not copy license-restricted SDK sample code into this repository.
