# GitHub Research Wave 284 Plan - VRCFaceTracking Face/Eye Tracking Modules, Templates, and Receiver Bridges

## Goal

Study VRCFaceTracking-adjacent face and eye tracking projects as reusable
references for module lifecycles, hardware ingress, expression mapping, avatar
preparation, receiver bridges, and DIY camera/ONNX face input.

## Research Questions

- How do modules separate hardware transport from VRCFT unified output?
- Which expression, smoothing, validity, and partial-support boundaries are
  reusable?
- How do avatar tools prepare parameters and animations safely?
- Which receiver/OSC/LiveLink patterns are useful for diagnostics and bridges?

## Shortlist

- `VRCFaceTracking/docs`
- `guygodin/VirtualDesktop.VRCFaceTracking`
- `Adjerry91/VRCFaceTracking-Templates`
- `hazre/VRCFTReceiver`
- `regzo2/BinaryParameterTool`
- `200Tigersbloxed/VRCFTOmniceptModule`
- `lonelyicer/VRCFTPicoModule`
- `ghostiam/VRCFTTobiiAdvanced`
- `kusomaigo/VRCFaceTracking-LiveLink`
- `xverse-engine/XVRFaceTracking`

## Required Checks

- Deduplicate against prior VRCFT, OpenXR face-tracking, DIY eye/mouth, and
  avatar-preparation waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep privacy, packet-version, port, licensing, and avatar-budget caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 284.
- Registry/family entries for VRCFT face/eye modules and receiver bridges.
- Method catalog entry for face/eye tracking module boundaries.
- Follow-up matrix around hardware modules, expression schemas, avatar
  parameters, OSC/LiveLink bridges, and DIY camera input.
