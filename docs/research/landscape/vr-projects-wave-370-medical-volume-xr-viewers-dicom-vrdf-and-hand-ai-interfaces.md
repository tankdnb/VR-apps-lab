# Wave 370: Medical Volume XR Viewers DICOM VRDF and Hand-AI Interfaces

## Scope

This wave studies XR medical volume viewers: DICOM/NRRD/NIFTI import, VRDF
resources, 3D texture generation, raymarch shaders, segmentation labels,
hand/controller menus, voice/AI assistants, backend reload events, and mobile
performance caveats.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `cassandra-stack/CASSANDRA-XR` | Studied | Mixed reality medical volume platform with REST study service, WebSocket status changes, VRDF loader, URP raymarch shaders, XR hand manipulation, brain menus, Gemini/voice assistant, and explicit Quest reload-performance caveat |
| `SitronX/FNO-Hololens2-visualisation` | Studied | HoloLens/PCVR medical volume viewer using UnityVolumeRendering, dataset folders, DICOM/NRRD/NIFTI/image sequence import, labels/segmentation sliders, hand/controller menus, async loading, progress handlers, and transform save/reset |

## Reusable Pattern Extraction

- Pattern candidate: `medical volume XR pipeline with dataset and modality boundaries`.
- Problem solved: medical volume viewers need to separate study discovery, dataset import, texture generation, shader rendering, segmentation, UI state, manipulation, and clinical/performance caveats.
- Reusable core: study manifest, modality/asset mapper, downloader/cache, volume file decoder, 3D texture/gradient/label texture generation, transfer function, raymarch shader, clipping/threshold controls, hand/controller menu, metadata panel, segmentation slider builder, progress/error reporting, transform persistence, reload debounce, and non-diagnostic caveat labels.
- Source evidence: CASSANDRA documents `StudyService`, `PusherClient`, `SessionDataController`, `VRDFLoader`, `VolumeDVR`, URP shaders, XR hand manipulation, brain menu, Porcupine/Gemini voice interface, and Android reload performance issue; FnO uses `VolumeDataControl` to load datasets/labels, detect DICOM/NRRD/NIFTI/image sequences, import asynchronously, attach textures/material keywords, create segmentation sliders, downscale, flip, and save transform state.
- Abstraction boundary: import/processing should be independent from XR UI and rendering; AI assistants should consume selected study context, not own the medical data pipeline.
- What not to copy: patient data, clinical claims, API keys, always-on voice, large synchronous reloads, hospital-specific manuals, or vendor SDK trees.
- Method catalog action: create a medical volume XR pipeline method.

## Project Notes

### `cassandra-stack/CASSANDRA-XR`

- Interesting idea: medical volume viewing is treated as a live platform with study backend, WebSocket reload signals, volumetric rendering, hand manipulation, contextual brain menus, and AI voice assistant.
- Code donor value: high for layered architecture, event flow, VRDF/resource boundary, Quest-specific shader variant, hand menu states, and performance caveat documentation.
- Product reference value: strong for future medical/scientific viewers and AI-assisted inspection surfaces.
- What to inspect next: script implementations under `Assets/Scripts`, VRDF format, reload debounce implementation, privacy/anonymization, and offline mode.
- Caveats: beta medical context; Quest reload performance and API credentials are explicit risk boundaries.

### `SitronX/FNO-Hololens2-visualisation`

- Interesting idea: a dataset folder convention (`Data`, optional `Thumbnail`, optional `Labels`) becomes the user-facing spawn/import model for medical volumes across HoloLens and PCVR.
- Code donor value: very high for async dataset import, supported format detection, segmentation label texture handling, progress/error reporting, hand/controller menu activation, and transform persistence.
- Product reference value: strong for any scientific volume viewer with segmentation and in-headset controls.
- What to inspect next: dataset save format, transfer-function editor, manual hospital workflow, and performance on standalone headsets.
- Caveats: built around UnityVolumeRendering/MRTK and hospital-specific assumptions; reuse import/UI pipeline, not medical validation.

## Product Direction

This wave supports a `scientific volume viewer` branch: future VR tools can use
a manifest-driven volume import pipeline with explicit data provenance,
segmentation controls, progress feedback, and separate AI/voice assistance.

