# VR Projects Wave 46: XR Latency Measurement, Recording Parsers, and Experiment Harnesses

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `XR latency measurement`, `recording parsers`, and
  `experiment harnesses`.

## Why this wave exists

`VR-apps-lab` already had metrics and capture helpers, but one research and
diagnostics branch was still too thin:

- motion-to-photon and tracking-latency tools;
- experiment scenes that encode movement into visual state changes;
- external microcontroller rigs for distributed or end-to-end latency tests;
- parsers and notebook analyzers for rich XR simulator recordings.

This wave exists to make
`XR latency measurement, recording parsers, and experiment harnesses`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with latency-measurement and parser queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `immersivecognition/motion-to-photon-measurement` | Strong donor for Unity-side motion-to-photon scenes that align movement and screen colors in recorded output |
| `vr-thi/VRLate` | Strong donor for a GPS-synchronized external hardware rig paired with a Unity-side brightness encoder |
| `Greendayle/VR-Motion-to-photon-latency-` | Focused product reference for low-cost, consumer-grade motion-to-photon checks through a VRChat world and slow-motion analysis |
| `HARPLab/dreyevr_recording_analyzer` | Strong donor for parser-plus-notebook analysis over rich XR simulator recordings |
| `HARPLab/DReyeVR-parser` | Strong donor for a smaller standalone parser, cache, and visualizer stack |
| `ratcave/vrlatency` | Strong donor for a scriptable Python latency-lab framework over Arduino and pyglet |

## Secondary candidates surfaced in the same wave

No secondary candidate in this wave was stronger than the frozen shortlist.

## Deep-pass notes by project

## `immersivecognition/motion-to-photon-measurement`

- GitHub:
  [immersivecognition/motion-to-photon-measurement](https://github.com/immersivecognition/motion-to-photon-measurement)
- What it is:
  a Unity project that measures VR controller motion-to-photon latency through
  several experiment scenes and tracked output files.
- Why it matters:
  it is the clearest donor in the repo for
  `video-aligned motion-to-photon experiment harness with screen-coded visual
  markers`.
- Interesting ideas:
  use the HMD screen as a time-alignment surface; track movement and screen
  color together; keep discrete, continuous, and combined modes in separate
  scenes over one experiment framework.
- Interesting implementation choices:
  `ExperimentGenerator.cs` and
  `ColorTracker.cs`
  make the `session -> repeated trials -> position plus color logging` flow
  explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  the strongest value is research tooling rather than end-user product shape.
- What to inspect next:
  keep it visible whenever a future branch needs
  `engine-side visual coding for later video alignment`.

## `vr-thi/VRLate`

- GitHub:
  [vr-thi/VRLate](https://github.com/vr-thi/VRLate)
- What it is:
  a distributed VR latency rig built from a Teensy microcontroller, GPS
  timepulse synchronization, photosensors, and a Unity-side brightness encoder.
- Why it matters:
  it is the clearest donor in the repo for
  `external hardware latency rig synchronized with engine-side brightness
  encoding`.
- Interesting ideas:
  pair a real measurement rig with the engine instead of relying only on engine
  timestamps; encode tracked rotation as display brightness; support
  next-minute synchronized starts for multi-station measurements.
- Interesting implementation choices:
  `Unity/Assets/Script/VRLate.cs`
  uses `OnPreRender` to turn tracked rotation into brightness output while the
  serial measurement process runs asynchronously.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  hardware complexity is high, but that is also the main differentiator.
- What to inspect next:
  keep it visible whenever a future branch needs
  `serious external validation of XR latency claims`.

## `Greendayle/VR-Motion-to-photon-latency-`

- GitHub:
  [Greendayle/VR-Motion-to-photon-latency-](https://github.com/Greendayle/VR-Motion-to-photon-latency-)
- What it is:
  a practical VRChat-world methodology for measuring motion-to-photon latency
  with smartphone slow-motion video.
- Why it matters:
  it is a strong product reference for
  `consumer-grade motion-to-photon checks without a dedicated lab`.
- Interesting ideas:
  calibrate a movement threshold from resting controller noise; flip the scene's
  visible state when movement crosses that threshold; use ordinary slow-motion
  video and spreadsheets to estimate delay.
- Interesting implementation choices:
  `code/udon.cs`
  makes the `calibrate threshold -> detect movement -> swap material and surface
  state` path explicit.
- Code donor value:
  medium.
- Product reference value:
  high.
- Architecture reference value:
  medium.
- Caveats:
  much thinner than the lab rigs above, so its strongest value is methodology
  and accessibility.
- What to inspect next:
  keep it visible whenever a future branch needs
  `good-enough latency measurement without dedicated hardware`.

## `HARPLab/dreyevr_recording_analyzer`

- GitHub:
  [HARPLab/dreyevr_recording_analyzer](https://github.com/HARPLab/dreyevr_recording_analyzer)
- What it is:
  a notebook-centered analysis stack for DReyeVR recordings, backed by a parser
  package and utilities.
- Why it matters:
  it is the clearest donor in the repo for
  `parser plus notebook analyzer over rich XR simulator recordings`.
- Interesting ideas:
  keep parsing reusable but layer domain-specific notebooks on top; convert logs
  into cached numpy-backed structures; treat custom actors and simulator actors
  as first-class parse targets.
- Interesting implementation choices:
  `dreyevr_parser/parser.py`
  makes the `parse raw recorder lines -> cache data -> feed analysis notebooks`
  flow explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  the strongest donor surface is the parser and analysis structure, not a user
  product shell.
- What to inspect next:
  keep it visible whenever a future branch needs
  `research replay analytics` rather than only runtime telemetry.

## `HARPLab/DReyeVR-parser`

- GitHub:
  [HARPLab/DReyeVR-parser](https://github.com/HARPLab/DReyeVR-parser)
- What it is:
  a smaller standalone parser and visualizer for DReyeVR recording files.
- Why it matters:
  it is the clearest donor in the repo for
  `thin standalone parser package with cacheable XR recording extraction`.
- Interesting ideas:
  keep the parser separate from the heavier notebooks; add cheap caching; expose
  a small visualizer and example flow.
- Interesting implementation choices:
  `src/parser.py`
  makes the `read recorder file -> normalize groups -> cache parsed arrays`
  path explicit.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  medium-high.
- Caveats:
  narrower than the analyzer repo, but that narrowness is useful.
- What to inspect next:
  compare it with `dreyevr_recording_analyzer` whenever a future branch needs to
  decide between `thin parser package` and `parser plus notebooks`.

## `ratcave/vrlatency`

- GitHub:
  [ratcave/vrlatency](https://github.com/ratcave/vrlatency)
- What it is:
  a Python framework for display, tracking, and total-latency experiments using
  pyglet windows, stimuli, and an Arduino integration layer.
- Why it matters:
  it is the clearest donor in the repo for
  `general XR latency lab packaged as experiment classes`.
- Interesting ideas:
  treat latency experiments as reusable classes; keep the stimulus object
  separate from the experiment orchestration; unify display, tracking, and total
  latency under one framework.
- Interesting implementation choices:
  `vrlatency/experiment.py`
  defines a reusable `BaseExperiment` plus specialized experiment subclasses
  over a shared Arduino and stimulus model.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  not VR-specific in every detail, but still highly relevant for XR measurement
  workflows.
- What to inspect next:
  keep it visible whenever a future branch needs a
  `scriptable latency-lab foundation`.

## Main takeaways from Wave 46

- `Latency measurement` is now a distinct family, not just a metrics side note.
- The strongest split in this family is:
  - `Unity motion-to-photon scene with coded visual markers`
  - `external hardware rig plus engine-side brightness encoding`
  - `consumer-grade world-based latency methodology`
  - `parser plus notebook analyzer for rich simulator recordings`
  - `thin standalone parser package`
  - `general scriptable latency lab framework`
- The most reusable lesson is that XR measurement tooling works best when it
  separates `signal encoding`, `external capture`, `structured parsing`, and
  `analysis packaging` instead of flattening everything into a generic metrics
  bucket.
