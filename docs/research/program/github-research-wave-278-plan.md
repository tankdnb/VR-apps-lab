# GitHub Research Wave 278 Plan - Camera-to-VRM Avatar Retargeting and Virtual-Camera Output

## Goal

Study camera-driven avatar retargeting projects as reusable references for
monocular capture, landmark confidence, smoothing, bone/blendshape mapping, and
virtual-camera or rendered-output adapters.

## Research Questions

- How do projects separate camera capture, inference, retargeting, avatar
  output, and virtual-camera publishing?
- Which confidence thresholds, smoothing filters, and reset behaviors appear?
- How do VRM face/eye/body maps differ from generic avatar or tracker output?
- Which forks are meaningful variants versus duplicate lineage?

## Shortlist

- `Kariaro/VRigUnity`
- `creativeIKEP/HolisticMotionCapture`
- `zacharyguan/VRigUnity`

## Required Checks

- Deduplicate against prior camera-inference, avatar/tracker bridge, VMC, and
  virtual-output waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Treat virtual camera installers as side-effectful and never execute them.
- Extract mandatory fields and reusable pattern bridge fields.

## Expected Outputs

- Landscape synthesis for Wave 278.
- Registry/family entries for camera-to-avatar retargeting and virtual output.
- Method catalog entry for camera-to-avatar retargeting pipelines.
- Follow-up matrix around landmarks, score gates, filters, bone maps,
  blendshapes, gaze, reset, and output adapters.
