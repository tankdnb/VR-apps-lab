# Wave 455: VR point-cloud annotation and cleaning tools

- Date: `2026-07-13`
- Scope: point-cloud annotation, labeling, cleaning, and hybrid desktop/VR
  workflows.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `velaboratory/DataFoldvr-Virtual-Reality-Point-Cloud-Annotation` | Studied | Hybrid VR/desktop point-cloud annotation |
| `SherryJYC/VR-3D-Annotation-Tool` | Studied | VR semantic scene labeling |
| `Azzinoth/VR-PointCloud-Editor` | Studied | Native/Focal Engine point-cloud cleaning |
| `Azzinoth/VR-PointCloud-Editor` upstream lineage | Compared | Rewrite of earlier Unity point-cloud editor family |

## Why this wave matters

The repo already tracks point-cloud and scientific annotation tools, but this
wave deepens the reusable method around dense data: import/export, point
painting, counting, semantic labels, hybrid desktop/headset modes, compute or
native rendering, and deletion/cleanup performance.

## Project notes

### `velaboratory/DataFoldvr-Virtual-Reality-Point-Cloud-Annotation`

- Interesting idea:
  hybrid immersive headset and 2D desktop point-cloud annotation system using
  the same rendering pipeline, with `.pcd` import/export, point painting,
  counting tasks, and compute-shader performance framing.
- Code donor value:
  strong reference for file browser prefabs, point-cloud file type prefab,
  menu tablet, color/layer controls, count markers, progress/timer UI, OpenXR
  settings, and hybrid interaction modes.
- Product reference value:
  shows a practical pattern: keep VR and desktop modes over one data/rendering
  substrate so users can choose precision, comfort, and throughput.
- Source evidence:
  `README.md`, `Assets/Prefabs/FileTypes/PointCloudPrefab.prefab`,
  `Assets/Prefabs/FileBrowser.prefab`, `Assets/Prefabs/MenuTablet.prefab`,
  `Assets/MenuTablet/*`, `Assets/Materials/Point Cloud_*`, and OpenXR settings
  under `Assets/XR`.
- Reusable core:
  point-cloud file descriptor, shared renderer, brush/paint mode, count marker,
  label layer, file browser, timer/progress, VR/desktop control adapter, and
  export path.
- What not to copy:
  study-specific assets, old preview XRI package assumptions, or raw dataset
  paths.
- What to inspect next:
  compute shader layout, `.pcd` read/write code, brush radius semantics, and
  layer/export data model.

### `SherryJYC/VR-3D-Annotation-Tool`

- Interesting idea:
  VR semantic labeling tool for 3D indoor scenes with two modes: immersive
  walking mode and seated/static mode for object labeling.
- Code donor value:
  useful as a UX and workflow reference for mode switching, scene model
  preparation, labels, dataset-specific resources, user study material, and
  SteamVR-era interaction assumptions.
- Product reference value:
  shows the importance of comfort modes in annotation tools: not every labeling
  task should force full-body navigation.
- Source evidence:
  `README.md`, `unity/Assets/*`, `python/*`, `user_study/*`, and setup notes
  for 2D3Ds dataset resources.
- Reusable core:
  dataset preparation checklist, dynamic/static labeling modes, semantic class
  labels, room model resource paths, tutorial material, and user-study metrics.
- What not to copy:
  dataset download links, bundled SteamVR/imported assets, old Unity/OpenVR
  setup, or hard-coded room paths.
- What to inspect next:
  label export format, mode-specific input scripts, class palette, and user
  study analysis notebooks.

### `Azzinoth/VR-PointCloud-Editor`

- Interesting idea:
  proof-of-concept native rewrite of a Unity point-cloud editor on Focal Engine
  focused on rendering performance, memory efficiency, large datasets, and
  deletion/cleaning operations.
- Code donor value:
  useful as architecture reference for a native renderer/editor split,
  third-party file dialog integration, CMake/submodule build shape, and
  performance-driven point-cloud utility framing.
- Product reference value:
  demonstrates that dense point-cloud utilities may need to leave Unity when
  dataset scale, memory, and frame-time stability dominate.
- Source evidence:
  `README.md`, `main.cpp`, `CMakeLists.txt`, `SubSystems/*`,
  `ThirdParty/ImFileDialog/*`, and version/submodule files.
- Reusable core:
  native app shell, point-cloud renderer, file dialog, selection/deletion tool,
  dataset benchmark labels, memory/frame-time metrics, and missing-feature
  roadmap.
- What not to copy:
  proof-of-concept claims without local validation, submodule code wholesale,
  or hardware-specific benchmark assumptions.
- What to inspect next:
  data structure for point selection/deletion, rendering backend, file formats,
  and how automated outlier detection will be reintroduced.

## Reusable pattern extraction

- Pattern candidate:
  `hybrid point-cloud annotation workspace`.
- Problem solved:
  make dense 3D datasets editable and labelable through both immersive and
  desktop workflows without duplicating the underlying data model.
- Reusable core:
  file import/export, point-cloud renderer, brush/select/delete tool, label
  layer, class palette, count marker, desktop/VR input adapters, progress/timer
  UI, dataset provenance, and performance metrics.
- Abstraction boundary:
  data model owns points/labels; renderer owns dense draw path; interaction
  layer owns brush/ray/desktop adapters; export layer owns annotation artifacts.
- Method catalog action:
  create a new method for hybrid point-cloud annotation.

## Caveats

- Several repos include large assets, old Unity versions, SteamVR/OpenVR
  dependencies, or research-study data assumptions.
- Strong donor value is in data model and workflow, not wholesale import.
- Performance claims need local validation before becoming implementation
  requirements.

