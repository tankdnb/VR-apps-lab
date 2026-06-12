# GitHub Research Wave 278 Backlog - Camera-to-VRM Avatar Retargeting and Virtual-Camera Output

## Executed Scope

- Searched and deduplicated camera-to-avatar, VRM retargeting, and virtual
  camera output projects.
- Froze a three-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted camera/output adapter boundaries, MediaPipe/VRM retargeting,
  score gates, low-pass filters, body/hand/face splits, blendshapes, gaze
  handling, reset behavior, and fork-line caveats.

## Studied Projects

- `Kariaro/VRigUnity`
- `creativeIKEP/HolisticMotionCapture`
- `zacharyguan/VRigUnity`

## Backlog Findings

- Build a camera-to-avatar matrix across capture source, inference boundary,
  confidence scores, smoothing, bone maps, hand/face maps, output adapters, and
  privacy policy.
- Deepen `creativeIKEP/HolisticMotionCapture` as the cleanest retargeting
  pipeline donor.
- Inspect the `VRigUnity` fork line only after isolating meaningful source
  deltas.
- Compare these projects with earlier VMC and camera-inference-to-tracker
  findings.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a camera-to-avatar retargeting method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
