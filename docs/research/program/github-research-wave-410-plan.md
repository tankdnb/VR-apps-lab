# GitHub Research Wave 410 Plan - CloudXR Immersive Streaming Runtime And Client Adapters

- Date: `2026-07-13`
- Theme: CloudXR/WebXR/OpenXR remote-rendering clients, device profiles,
  runtime adapters, pairing, and streaming diagnostics.

## Frozen Scope

- `NVIDIA/cloudxr-lovr-sample`
- `NVIDIA/cloudxr-js-samples`
- `picoxr/OpenXR_CloudXR_Client_Demo`
- `apple/StreamingSession`

## Research Questions

- What lifecycle boundaries exist between runtime startup, stream session,
  tracking uplink, frame downlink, and diagnostics?
- How do device profiles and connection metrics shape the utility UX?
- Which pieces should be generalized versus isolated as vendor/platform code?

## Expected Outputs

- Wave landscape synthesis.
- Registry and family placement.
- Method candidate for remote rendering client lifecycle and device profile.
- Follow-up queue entry for generic streaming diagnostics schema.
