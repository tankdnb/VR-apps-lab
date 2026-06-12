# GitHub Research Wave 284 Backlog - VRCFaceTracking Face/Eye Tracking Modules, Templates, and Receiver Bridges

## Executed Scope

- Searched and deduplicated VRCFaceTracking modules, avatar templates, receiver
  bridges, and DIY face-input tools.
- Froze a ten-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted memory-mapped Virtual Desktop ingress, UDP PICO packets, Tobii and
  BrokenEye fallback, Omnicept Glia subscription, LiveLink ARKit UDP mapping,
  OSC FT/v2 receiver streams, avatar parameter tools, templates, and
  camera/ONNX/OSC mouth tracking.

## Studied Projects

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

## Backlog Findings

- Build a face/eye tracking matrix across VRCFT modules, Virtual Desktop,
  PICO, Tobii/BrokenEye, Omnicept, LiveLink, templates, binary parameters, OSC
  receivers, DIY camera input, smoothing, and privacy.
- Deepen `VRCFTPicoModule`, `VirtualDesktop.VRCFaceTracking`, and
  `VRCFTTobiiAdvanced` as the strongest module donors.
- Deepen avatar-side preparation tools around parameter cost, binary
  compression, templates, generated layers, rollback, and package release
  hygiene.
- Treat `xverse-engine/XVRFaceTracking` as a prototype reference until model
  provenance, normalization, and firmware/security boundaries are clearer.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a face/eye tracking module boundary method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
