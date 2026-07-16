# Wave 465: VIVE OpenXR utility samples and accessibility surfaces

- Date: `2026-07-16`
- Scope: small vendor/sample projects that expose reusable utility patterns for
  subtitles, hand tracking, eye-scrolling, scene perception, controller state,
  haptics, and device setup labels.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `ViveDeveloperRelations/SubtitlesDemo` | Studied | Compact caption sample with SRT parsing, language files, StreamingAssets lookup, and TextMeshPro display |
| `ViveDeveloperRelations/HandTracking_OpenXR_Mobile` | Partially studied | OpenXR mobile hand-tracking project with joint scripts, XRI starter assets, and Wave/Oculus/OpenXR loader settings |
| `ViveDeveloperRelations/Eye_Scroller` | Partially studied | Eye-driven teleprompter/scrolling sample with ScriptableObject text cells and ADB-over-Wi-Fi editor helpers |
| `ViveDeveloperRelations/ScenePerceptionDemo` | Studied | VIVE scene perception sample with scene mesh/plane anchors, passthrough helpers, permission helpers, and Wave Essence packages |
| `ViveDeveloperRelations/CosmosOpenXRSampleProject` | Studied | OpenXR controller sample with action-to-button/slider/visibility/haptics and device-info display scripts |

## Project notes

### `ViveDeveloperRelations/SubtitlesDemo`

- Interesting idea: a very small caption implementation that is easy to read
  end-to-end: SRT parser, language file table, subtitle index, and display
  coroutine.
- Code donor value: medium; `SRTParser.cs`, `Subtitles.cs`, and
  `SubtitleDisplayer.cs` are simple enough to use as a micro-reference for
  caption timing.
- Product reference value: medium; useful as a minimal accessibility affordance
  to pair with stronger caption systems already tracked in Waves 297 and 392.
- Source evidence: `Assets/Scripts/SRTParser.cs`,
  `Assets/Scripts/Subtitles.cs`, `Assets/Scripts/SubtitleDisplayer.cs`,
  `Packages/manifest.json`.
- Reusable core: SRT parse states, `SubtitleBlock`, selected-language matrix,
  StreamingAssets file load, elapsed-time lookup, TextMeshPro fallback, and
  blank subtitle state.
- What not to copy: blocking file reads in runtime UI, hard-coded language enum,
  file matrix, lack of spatial/source direction cues, and no settings surface.
- What to inspect next: whether it should stay as a minimal sample or be folded
  only into the existing caption/accessibility family.

### `ViveDeveloperRelations/HandTracking_OpenXR_Mobile`

- Interesting idea: mobile OpenXR hand setup sample that places hand scripts,
  XRI starter presets, Wave/OpenXR/Oculus loader assets, and an in-game debug
  console in one project.
- Code donor value: medium; `Assets/Scripts/HandJointManager.cs`,
  `JointMovement.cs`, `ShowHands.cs`, and `Interactable.cs` are the key files to
  inspect in a future deeper pass.
- Product reference value: medium; useful for setup-matrix documentation around
  mobile OpenXR hand tracking rather than as a direct donor today.
- Source evidence: `Assets/Scripts/*`, `Assets/XR/Settings/*`,
  `Assets/XRI/Settings/*`, `Packages/manifest.json`.
- Reusable core: loader capability matrix, joint prefab mapping, hand visibility
  toggles, interactable hooks, and debug console surface.
- What not to copy: sample bulk, bundled debug console assets, old package
  versions, and vendor-specific loader assets without capability labels.
- What to inspect next: exact joint data model and interaction thresholds.

### `ViveDeveloperRelations/Eye_Scroller`

- Interesting idea: eye/teleprompter sample with content as text-cell
  ScriptableObjects and helper tooling for wireless Android deployment.
- Code donor value: low to medium; `TeleprompterCellScriptableObject.cs` is
  tiny, while `BuildAndRunOverWifi/AdbFacade.cs` exposes device-state parsing
  and Unity editor ADB reflection.
- Product reference value: medium; reminds us that eye-driven utilities need
  authorable content chunks and operator deployment helpers.
- Source evidence: `Assets/Data/TeleprompterCellScriptableObject.cs`,
  `Assets/Data/*.asset`, `Assets/BuildAndRunOverWifi/AdbFacade.cs`,
  `Packages/manifest.json`.
- Reusable core: text-cell asset model, scrollable cell prefab pattern, ADB
  device-state parsing, one-device-connected gate, and build/deploy helper UI.
- What not to copy: local file package paths in `manifest.json`, reflection
  against Unity internals without fallback, and vendor beta package paths.
- What to inspect next: actual gaze-scroll controller scripts and settings
  surface.

### `ViveDeveloperRelations/ScenePerceptionDemo`

- Interesting idea: vendor scene-perception sample that turns scanned planes,
  mesh anchors, passthrough state, permissions, and anchor prefabs into visible
  demo scenes.
- Code donor value: medium; `ScenePerceptionManager.cs`, demo scripts,
  `GeneratedPlane*`, `GeneratedSceneMesh*`, `SceneMeshPermissionHelper.cs`, and
  `PassThroughHelper.cs` are useful structure references.
- Product reference value: high for MR utility setup; it shows what a
  capability-gated environment-understanding sample needs to expose.
- Source evidence: `Assets/Wave/Essence/ScenePerception/.../Scripts`,
  demo scenes, generated mesh shaders, `Packages/manifest.json`.
- Reusable core: scene-perception manager, permission helper, generated mesh
  facade, generated plane container, spatial anchor helper, passthrough helper,
  and translucent/wireframe debug materials.
- What not to copy: vendor package internals, bundled samples, private/local
  package paths, and assumptions about Wave runtime support.
- What to inspect next: neutral schema for plane/mesh/anchor state and
  permission failure UX.

### `ViveDeveloperRelations/CosmosOpenXRSampleProject`

- Interesting idea: compact OpenXR controller/sample project that maps input
  actions to visible UI, haptics, sliders, button state, visibility, tracking
  mode, and device information labels.
- Code donor value: medium; `DisplayDeviceInfoFromActionISX.cs`,
  `ActionToHaptics.cs`, `ActionToButtonISX.cs`, `ActionToSliderISX.cs`,
  `ActionAssetEnabler.cs`, and `TrackingModeOrigin.cs` form a useful
  input-diagnostic surface.
- Product reference value: high for controller diagnostics and onboarding.
- Source evidence: `Assets/Samples/OpenXR Plugin/1.2.8/Controller/Scripts`,
  OpenXR settings assets, packaged controller tgz, `Packages/manifest.json`.
- Reusable core: action asset enablement, action-to-UI adapters,
  action-to-rumble, device name/id/usages display, no-device hiding, and
  tracking-mode labels.
- What not to copy: package archive blobs, old sample package version, and
  controller assumptions without modern OpenXR profile labels.
- What to inspect next: compare with existing runtime/input operator methods.

## Reusable pattern extraction

- Pattern candidate: `Vendor capability sample cockpit`.
- Problem solved: vendor XR features are hard to adopt when settings,
  permissions, input actions, sample scenes, and device labels are scattered.
- Reusable core: package/version matrix, scoped registry note, loader settings,
  sample scene inventory, action-to-display adapters, permission helpers,
  feature-manager object, visible no-device/no-permission state, and caveats.
- Source evidence: VIVE `Packages/manifest.json` files,
  `SubtitlesDemo/Assets/Scripts`, `CosmosOpenXRSampleProject/.../Controller/Scripts`,
  `ScenePerceptionDemo/.../ScenePerception`, and hand/eye sample scripts.
- Abstraction boundary: keep vendor package setup and sample assets separate
  from reusable utility UI/state patterns.
- What not to copy: vendor sample bulk, private package paths, binary archives,
  old package versions, and claims without device/runtime labels.
- Method catalog action: add `Method 910`.

## Why this matters for VR-apps-lab

The repo already tracks major runtime/operator tools. This wave adds the
smaller but practical layer: how vendor samples expose capability state in a way
that can become a future diagnostics or setup cockpit.

