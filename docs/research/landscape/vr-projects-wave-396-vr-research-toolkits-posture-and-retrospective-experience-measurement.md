# Wave 396: VR Research Toolkits, Posture, and Retrospective Experience Measurement

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device
  tests.

## Theme

This wave studies VR research scaffolds that turn immersive experiences into
repeatable studies: package-based experiment toolboxes, posture/balance
measurement, and retrospective emotion/presence annotation.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `MPIB/arc-vr` | Studied | VR experiment toolbox substrate |
| `immersivecognition/posture-assessment-vr` | Studied | Posture and balance measurement |
| `revealcentre/retrosketch` | Studied | Retrospective experience annotation |

## Findings

### `MPIB/arc-vr`

- Interesting idea: package VR study infrastructure as independent Unity
  packages around core, motion, UI, avatar, physics, and networking.
- Code donor value: `Packages/com.avr.*`, `AVR_DevConsole`,
  `AVR_Settings`, `AVR_Logger`, controller modules, UI rays, and package
  dependency boundaries.
- Product reference value: shows how a research lab can ship reusable VR
  primitives without each study rebuilding locomotion, UI, settings, logging,
  and network setup.
- What to inspect next: package manifests, logger data-source shape,
  controller wizard hooks, and whether core package seams can inspire a
  `VR-apps-lab` research scaffold.
- Caveat: GPLv3 and HTC Vive/Unity 2020 assumptions make it a conceptual
  donor more than a copy-directly donor.

### `immersivecognition/posture-assessment-vr`

- Interesting idea: use HMD tracking as a clinical/research balance signal
  across normal, no-vision, and oscillating-room conditions.
- Code donor value: `ExperimentManager`, `ExperimenterControls`, UXF
  session/block/trial lifecycle, participant-list CSV updates, raw head-motion
  output, and R processing recipe.
- Product reference value: strong example of a minimal operator UI plus
  participant session model for embodied measurement.
- What to inspect next: `psat-vr.json`, trial output schemas, head path-length
  processing, and operator safety prompts.
- Caveat: clinical interpretation needs validation labels; the useful donor is
  the measurement pipeline, not a medical claim.

### `revealcentre/retrosketch`

- Interesting idea: replay immersive footage and let participants annotate
  continuous emotion/presence curves and keypoints after the experience.
- Code donor value: timeline playback, keypoint/line/eraser modes, annotation
  dialog, validation before export, video import, and screenshot/export flow.
- Product reference value: turns subjective experience into synchronized
  quantitative and qualitative data without interrupting the original VR
  session.
- What to inspect next: UI state model, export artifact schema, validation
  rules, and whether this belongs as a desktop companion for future study
  tools.
- Caveat: AGPL-3.0 and generated/library-heavy Unity content limit direct
  reuse.

## Reusable Pattern Extraction

- Pattern candidate: `VR research session and retrospective annotation loop`.
- Problem solved: researchers need repeatable trials, operator controls,
  participant metadata, raw motion logs, and post-session subjective annotation.
- Reusable core: package modules, study settings, session/block/trial lifecycle,
  participant row, operator UI, measurement condition, raw motion stream,
  timeline replay, keypoint annotation, export artifact, and analysis script.
- Source evidence: ARC-VR packages and logger/settings tools, posture
  assessment UXF scripts and README processing example, and RetroSketch
  replay/annotation workflow.
- Abstraction boundary: keep study runtime, participant metadata, and analysis
  exports separate from one-off scene content.
- What not to copy: clinical claims, GPL/AGPL code, heavy vendor packages, or
  raw participant data handling without consent/retention metadata.
- Method catalog action: add Method 841.
