# VR Projects Wave 114: Meta Quest MR Camera, Depth, Spatial Anchor, Presence, and Motifs Samples

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for Meta Quest sample
  repositories that demonstrate passthrough camera access, depth occlusion,
  spatial anchors, shared rooms, full MR app composition, and recurring MR
  product motifs.

## Why this wave exists

Mixed-reality utility tools need practical patterns for permission gates,
camera textures, camera-to-world math, environment depth, occlusion tuning,
anchor-backed markers, shared spaces, and colocated workflows.

This wave studies Quest MR samples as references for future MR diagnostics,
anchored overlays, physical-room utility markers, and shared helper tools.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by Quest camera, depth, shared-anchor, Discover, and MR motif
   sample families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `oculus-samples/Unity-PassthroughCameraApiSamples` | Quest camera feed, camera-to-world mapping, brightness estimation, object detection, and anchor-backed markers |
| `oculus-samples/Unity-DepthAPI` | Environment depth package and samples for occlusion, cutout, depth bias, and depth masking |
| `oculus-samples/Unity-SharedSpatialAnchors` | Shared spatial-anchor creation, saving, sharing, loading, binding, and alignment patterns |
| `oculus-samples/Unity-Discover` | Full MR app/sample composition using Meta XR SDK, Scene API, Interaction SDK, passthrough, anchors, and networking |
| `oculus-samples/Unity-MRMotifs` | Reusable MR motif library for passthrough transitions, shared activities, instant placement, depth effects, and colocated experiences |

## Deep-pass notes by project

## `oculus-samples/Unity-PassthroughCameraApiSamples`

- GitHub:
  [oculus-samples/Unity-PassthroughCameraApiSamples](https://github.com/oculus-samples/Unity-PassthroughCameraApiSamples)
- What it is:
  a set of Quest samples for accessing passthrough camera data through MRUK
  `PassthroughCameraAccess`.
- Interesting idea:
  camera feed utilities become much more useful when camera texture, precise
  timestamps, intrinsics/extrinsics, head pose, camera pose, permission state,
  ML detections, and spatial-anchor-backed markers are handled together.
- Code-level notes:
  `CameraToWorldManager.cs` waits for camera access, scales the camera canvas,
  maps viewport corners through `ViewportPointToRay`, stores snapshot head
  pose, updates head/camera markers, and supports recenter/debug offsets.
  `DetectionManager.cs` creates and tracks detected-object markers with
  `OVRSpatialAnchor`, localization waits, save/restore retries, and cleanup.
  `BrightnessEstimationManager.cs`, `SentisInferenceRunManager.cs`, and
  `RequestPermissionsOnce.cs` show brightness, object detection, camera-pose
  reliability, non-max suppression, and permission request patterns.
- Code donor value:
  very high for camera-to-world, permission, detection marker, and spatial
  anchor marker flows.
- Product reference value:
  high for MR diagnostics, physical-object helper overlays, and camera-aware
  utilities.
- Caveats:
  Quest-specific; depends on supported headset, OS, Unity, MRUK, passthrough,
  and permission requirements.
- What to inspect next:
  combine with depth and anchor samples before any camera-aware MR prototype.

## `oculus-samples/Unity-DepthAPI`

- GitHub:
  [oculus-samples/Unity-DepthAPI](https://github.com/oculus-samples/Unity-DepthAPI)
- What it is:
  Meta's Unity sample and package material for real-time Quest environment
  depth and occlusion.
- Interesting idea:
  depth-aware utility UI needs explicit controls for occlusion, depth bias,
  hand removal, cutout, and render pipeline differences rather than a single
  opaque "depth on" switch.
- Code-level notes:
  the package exposes environment-depth integration with BiRP and URP sample
  branches. `OcclusionDepthBias.cs` collects renderer materials and adjusts
  `_EnvironmentDepthBias`. Sample scripts include occlusion toggles, hand
  removal, poster placement, scene-mesh depth masks, UI camera following, and
  wall-view controls. Shader variants demonstrate environment-depth occlusion
  and UI cutout paths.
- Code donor value:
  high for depth/occlusion toggles, bias tuning, and pipeline-split structure.
- Product reference value:
  high for MR overlays that must respect or deliberately ignore real-world
  geometry.
- Caveats:
  Quest and render-pipeline specific; any reuse should keep hardware and
  graphics requirements visible.
- What to inspect next:
  compare occlusion/bias UX against future MR overlay comfort controls.

## `oculus-samples/Unity-SharedSpatialAnchors`

- GitHub:
  [oculus-samples/Unity-SharedSpatialAnchors](https://github.com/oculus-samples/Unity-SharedSpatialAnchors)
- What it is:
  a Quest sample for spatial anchor sharing, colocation, and alignment.
- Interesting idea:
  shared MR spaces need a repeatable sequence: create anchor, save it, share or
  publish identity, load unbound anchors, bind them, instantiate content, and
  align the world origin.
- Code-level notes:
  `SharedAnchorLoader.cs` loads saved or cloud-shared unbound anchors, binds
  them with `UnboundAnchor.BindTo`, instantiates anchor prefabs, and tracks
  source. `Alignment.cs` explains origin realignment using inverse anchor
  matrices and `MRUK.Instance.SetCustomWorldLockAnchor`. `ColoDiscoMan.cs`
  advertises and discovers colocation sessions, handles group UUIDs, known
  anchors, anchor sharing, group loading, and binding. Photon helpers publish
  anchor UUIDs and alignment poses through room properties.
- Code donor value:
  high for spatial-anchor lifecycle and alignment patterns.
- Product reference value:
  very high for colocated utilities and shared room markers.
- Caveats:
  networking and platform services matter; the sample is not a generic
  cross-platform anchor abstraction.
- What to inspect next:
  compare with MR Motifs space sharing and Discover full-app composition.

## `oculus-samples/Unity-Discover`

- GitHub:
  [oculus-samples/Unity-Discover](https://github.com/oculus-samples/Unity-Discover)
- What it is:
  a full Meta Quest MR sample app using Scene API, Interaction SDK,
  passthrough, spatial anchors, shared spatial anchors, Photon Fusion, and Meta
  utilities.
- Interesting idea:
  a full MR sample is valuable less as a compact donor and more as evidence of
  how camera, interaction, anchors, scene data, networking, setup, and content
  are composed into one product.
- Code-level notes:
  the strongest pass value was in the documentation and project structure:
  configuration, overview, and project-structure docs describe SDK setup,
  feature composition, and sample app organization. The repository is too broad
  to treat as a small code donor in this pass.
- Code donor value:
  medium because the project is broad and sample-app oriented.
- Product reference value:
  high for end-to-end MR app composition.
- Caveats:
  not a micro-utility; use to understand composition, not to copy wholesale.
- What to inspect next:
  revisit only when designing a full Quest MR helper app skeleton.

## `oculus-samples/Unity-MRMotifs`

- GitHub:
  [oculus-samples/Unity-MRMotifs](https://github.com/oculus-samples/Unity-MRMotifs)
- What it is:
  a library of reusable mixed-reality motifs, described as blueprints for
  recurring MR mechanics.
- Interesting idea:
  product-level MR design benefits from motif documents and sample scenes that
  isolate recurring mechanics such as passthrough transitions, shared
  activities, instant placement, depth effects, and colocated experiences.
- Code-level notes:
  `PassthroughFader.cs`, `PassthroughDissolver.cs`, `PassthroughSlider.cs`, and
  `PerlinNoiseTexture.cs` show selective or underlay passthrough transitions,
  shader-based fades, layer handling, and UI controls. `SpaceSharingManager.cs`
  uses colocation advertisement/discovery, group UUIDs, MRUK room sharing,
  networked room UUID/floor-pose data, and `LoadSceneFromSharedRooms`.
  Additional shared-activity scripts cover avatars, movie controls, chess,
  group presence, invites, and spawn management.
- Code donor value:
  high for specific motifs and transition/share mechanics.
- Product reference value:
  very high for MR product design and reusable feature blueprints.
- Caveats:
  motif samples should be translated into product needs rather than copied as
  full app structure.
- What to inspect next:
  use as a checklist when designing MR interactions around physical rooms.

## Main takeaways from Wave 114

- Quest MR utilities need explicit camera, depth, anchor, permission, and
  platform-requirement handling.
- Passthrough camera samples are strong donors for camera-to-world and marker
  workflows.
- Depth API samples clarify occlusion and bias controls that MR overlays need.
- Shared anchors are a lifecycle and alignment problem, not one API call.
- MR Motifs is a valuable product-pattern library for recurring MR mechanics.

## Reusable methods clarified by this wave

- `Passthrough camera-to-world sample stack with permission, ray, detection, and anchor marker managers`
- `Depth API occlusion stack with BiRP/URP branches, cutout, hand removal, and environment depth toggles`
- `Shared spatial-anchor sequence: create, save, share, publish, load, bind, and align`
- `Meta MR feature motifs and full-app composition for passthrough transitions, shared activities, instant placement, and space sharing`

## Recommended next moves after this wave

1. Use the camera, depth, and shared-anchor samples together when designing MR
   diagnostics.
2. Keep Quest requirements explicit in every future reuse note.
3. Use MR Motifs as the product-pattern checklist for Quest MR utilities.
4. Treat Discover as full-app composition reference rather than compact code
   donor.
