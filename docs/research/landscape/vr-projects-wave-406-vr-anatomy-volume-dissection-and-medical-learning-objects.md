# Wave 406: VR Anatomy, Volume Dissection, and Medical Learning Objects

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device tests.

## Theme

This wave studies anatomy and medical-learning object projects. The reusable
value is how anatomical material becomes explorable: labels, dissection,
snapping puzzles, volume rendering, slice/rotate controls, and MRTK-style data
and UI shells.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `chrislarkee/VR-Neuroanatomy` | Studied | Brain label/dissection learning object |
| `asemahassan/3DPuzzleVR` | Studied | Anatomy puzzle/snapping interaction |
| `malyalar/vr-volume-renderer` | Studied | Medical volume rendering learning object |
| `auroey/mr-IMVA-unity` | Studied with caveats | MRTK data/UX shell reference |

## Findings

### `chrislarkee/VR-Neuroanatomy`

- Interesting idea: brain learning object using labelled/parcellated MRI data
  and virtual dissection rather than only static model viewing.
- Code donor value: `brainMaster`, `brainPart2`, `toggleBrains`,
  `toggleLabels`, `sliceManager`, laser/pointer scripts, and menu scripts.
- Product reference value: useful pattern for domain models with parts,
  labels, visibility toggles, and learner-controlled decomposition.
- What to inspect next: label data structure, part hierarchy, slice controls,
  and menu/laser affordance maturity.
- Caveat: legacy scripts and old interaction paths should be normalized before
  reuse.

### `asemahassan/3DPuzzleVR`

- Interesting idea: anatomy education as a 3D puzzle with wand control,
  distance checks, snapping, physics/no-gravity variants, and walls/triggers.
- Code donor value: `GameController`, `ModelController`, `Snapping`,
  `EuclideanDistance`, `InteractableItem`, `WandController`, and UI laser
  pointer modules.
- Product reference value: strong object-placement lesson for teaching spatial
  anatomy through correction, not only inspection.
- What to inspect next: scoring/error feedback, snap tolerance, object
  metadata, and how menu choices reset/advance tasks.
- Caveat: VRTK/SteamVR package surface is large; custom anatomy scripts are
  the useful boundary.

### `malyalar/vr-volume-renderer`

- Interesting idea: volume-rendered VR learning objects from medical imaging,
  with slice/explore interaction for viewing deep anatomy.
- Code donor value: `VolumeRendering`, `VolumeRenderingController`, and simple
  scene rotation scripts.
- Product reference value: confirms that volume datasets need explicit
  transfer/slice controls and learner-safe manipulation, not only model import.
- What to inspect next: data import path, transfer function controls, slice
  plane UI, mobile/Cardboard constraints, and clinical caveat wording.
- Caveat: GoogleVR/legacy mobile assumptions should be separated from the
  volume-object method.

### `auroey/mr-IMVA-unity`

- Interesting idea: MRTK package/template surface with data binding, item
  placers, dialogs, sliders, pressable buttons, and layered UI examples.
- Code donor value: `DataControllerGOBase`, `DataCollectionItemPlacerGOBase`,
  `PressableButton`, `Slider`, dialog components, and example UI scripts.
- Product reference value: useful as UX/data shell reference for medical
  learning objects that need filters, layer sliders, dialogs, and data-bound
  controls.
- What to inspect next: actual IMVA domain layer, data controller schemas, and
  how layered visualizations are bound to UI.
- Caveat: much of the repository is MRTK substrate rather than anatomy-specific
  implementation; treat it as shell reference only.

## Reusable Pattern Extraction

- Pattern candidate: `Anatomy learning object with inspect, isolate, slice, and solve modes`.
- Problem solved: medical/anatomy VR tools need to expose complex 3D material
  as teachable state transitions, not just as imported meshes.
- Reusable core: anatomical part registry, label metadata, part visibility,
  slice/volume controls, grab/rotate controls, snap target/tolerance, learner
  task state, data-bound sliders/dialogs, reset flow, and clinical caveat label.
- Source evidence: `VR-Neuroanatomy` has brain part, label, slice, and menu
  scripts; `3DPuzzleVR` has snapping, distance, wand, physics/no-gravity object
  paths; `vr-volume-renderer` includes volume rendering controllers; MRTK data
  and UI scripts show reusable shell components for filters/layers/dialogs.
- Abstraction boundary: separate domain anatomy data, interaction mode, visual
  transform/slice state, and learning/scoring state.
- What not to copy: clinical claims, patient-data assumptions, old SDK bundles,
  unlicensed medical assets, or MRTK package bulk when only a UI pattern is
  needed.
- Method catalog action: add Method 851.

