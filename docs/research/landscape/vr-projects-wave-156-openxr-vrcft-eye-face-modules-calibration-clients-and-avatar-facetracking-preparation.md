# VR Projects Wave 156: OpenXR/VRCFT Eye-Face Modules, Calibration Clients, and Avatar Facetracking Preparation

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 156 studies how face and eye data reaches VRChat avatars from the
implementation side: OpenXR modules, local versus remote tracking ingress,
extension choice, filtering, sensitivity, avatar preparation, and calibration.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `regzo2/VRCFaceTracking-QuestProOpenXR` | VRCFT OpenXR module variants | Concept donor with archival caveats |
| `korejan/VRCFT-ALXR-Modules` | VRCFT local/remote ingress modules | Strong architecture donor |
| `PawlygonStudio/VRC-Facetracking` | Avatar facetracking preparation | Strong creator-workflow donor |
| `tobexeon/PSVR2EyeTrackingCalibration` | Eye-tracking calibration clients | Focused calibration UX/protocol reference |

## `regzo2/VRCFaceTracking-QuestProOpenXR`

- Interesting idea:
  bridge Quest Pro Link/Air Link face and eye data into VRCFaceTracking through
  a Meta OpenXR bridge while temporarily switching the active OpenXR runtime.
- Code donor value:
  medium. The expression mapping and runtime-switch/restore flow are useful,
  but the project is archived and marked broken upstream.
- Product reference value:
  medium. It shows the user value of direct vendor tracking modules, but not a
  safe current dependency.
- What to inspect next:
  compare only the expression-mapping and runtime-restore strategy against
  newer VRCFT module APIs and maintained Quest/ALXR modules.
- Architecture pattern:
  VRCFT `ExtTrackingModule` loads native bridge DLLs from `ModuleLibs`, sets
  the active OpenXR runtime to Oculus, initializes OpenXR session/face/eye
  trackers through P/Invoke, polls face/eye data, maps vendor expression enums
  into `UnifiedTracking.Data.Shapes`, computes eye openness and gaze pitch/yaw,
  then destroys trackers and restores the previous runtime during teardown.
- Reusable method:
  vendor OpenXR face/eye expression normalizer with explicit runtime restore.
- Caveats:
  archived, binary bridge dependency, Windows/Oculus Link bias, and runtime
  switching is risky unless restore behavior is treated as a first-class
  safety requirement.

## `korejan/VRCFT-ALXR-Modules`

- Interesting idea:
  provide two VRCFT modules over the same conceptual tracking contract: a local
  PC OpenXR module and a remote ALXR packet receiver.
- Code donor value:
  high. It has one of the clearest local/remote tracking-module splits in this
  batch.
- Product reference value:
  high. It shows how to make tracking ingress configurable without hiding
  runtime, extension, filter, and sensitivity tradeoffs.
- What to inspect next:
  isolate its config and packet contracts if `VR-apps-lab` later documents a
  generic `tracking ingress module` pattern.
- Architecture pattern:
  local module loads native ALXR libraries, creates or loads JSON config,
  selects graphics/headless/session behavior, chooses eye and face tracking
  extensions, processes frames, applies One Euro filters, and maps packets to
  VRCFT unified shapes. Remote module uses TCP to read exact facial/eye packet
  structs from an ALXR client, resets filters on reconnect, and shares mapping
  helpers with the local module.
- Reusable method:
  dual local/remote tracking ingress module with extension selection, filters,
  hot-reloaded sensitivity profiles, and shared data normalizers.
- Caveats:
  native ALXR boundary, ALXR-specific packet format, runtime-specific extension
  behavior, and careful reconnect/error handling requirements.

## `PawlygonStudio/VRC-Facetracking`

- Interesting idea:
  treat facetracking support as an avatar authoring package, not only a runtime
  module: prefabs, controllers, Unified Expression/ARKit paths, threshold
  editor, and OSC config cleanup.
- Code donor value:
  high for creator workflow and Unity editor tooling.
- Product reference value:
  high. It shows how a complex avatar setup can become a guided package rather
  than scattered manual steps.
- What to inspect next:
  compare the threshold editor and OSC cleanup with other avatar packaging
  tools before creating any avatar-preparation checklist.
- Architecture pattern:
  Unity package defines facetracking prefabs and controller assets; editor
  tooling locates controller blend tree motions, exposes thresholds for
  Unified Expressions or ARKit, imports/exports JSON settings, warns about low
  thresholds, and removes stale local VRChat OSC avatar configs after upload
  while guarding path components.
- Reusable method:
  avatar-side facetracking package with editable expression thresholds and
  upload-time OSC config hygiene.
- Caveats:
  Unity/VRChat-specific, asset-heavy, and useful as creator workflow donor more
  than as runtime tracking code.

## `tobexeon/PSVR2EyeTrackingCalibration`

- Interesting idea:
  calibrate PSVR2 eye gaze in real time without restarting SteamVR by driving a
  small OpenXR calibration scene and notifying a custom toolkit fork through
  localhost IPC.
- Code donor value:
  medium. The calibration loop is compact and useful, but tied to a custom
  PSVR2Toolkit fork.
- Product reference value:
  high for calibration UX. It gives a clear nine-point red-dot flow with simple
  trigger confirmation and persistent offsets.
- What to inspect next:
  separate the calibration UI/data model from the custom fork before any reuse.
- Architecture pattern:
  Microsoft OpenXR sample-derived scene creates eye gaze and trigger actions,
  starts calibration through localhost IPC command `14`, shows intro text,
  places nine head-locked points at asymmetric up/down/side/corner positions,
  records target and gaze direction on trigger, averages X/Y direction deltas,
  writes `PSVR2Calibration.txt` in Documents, and sends stop command `15`.
- Reusable method:
  real-time gaze calibration client with head-locked target points, trigger
  sampling, averaged offset persistence, and runtime-side apply notification.
- Caveats:
  custom toolkit dependency, Windows IPC path, simple average offset model, and
  no broader validation of calibration quality in this pass.

## Cross-Project Lessons

- Face/eye tracking utilities split naturally into runtime module, transport,
  expression normalizer, avatar authoring, and calibration layers.
- Runtime switching must be designed with explicit restore and failure paths.
- Remote tracking ingress benefits from keeping packet receive, filtering, and
  expression mapping as separable modules.
- Avatar-side packages can carry a large part of the UX burden: thresholds,
  prefabs, upload cleanup, and clear shape vocabularies.

## Reusable Methods Extracted

- Vendor OpenXR expression normalizer with runtime restore.
- Dual local/remote VRCFT tracking ingress module.
- Avatar facetracking package with threshold editor and OSC config cleanup.
- Real-time eye-gaze calibration client with persistent offsets.

## Follow-Up Backlog

- Compare maintained VRCFT module APIs before reusing any archived Quest Pro
  module patterns.
- Build a facetracking setup checklist across runtime modules, avatar packages,
  and calibration tools.
- Keep PSVR2 calibration as a UX reference until the custom toolkit fork is
  separately studied.
