# GitHub Research Wave 120 Backlog

- Date: `2026-06-05`
- Scope: ALVR/WiVRn ecosystem sidecars, platform clients, runtime bridge
  variants, tracking adapters, USB forwarding, and timing viewers.

## Completed in this wave

- Studied `alvr-org/alvr-visionos` as a visionOS-specific ALVR client with
  SwiftUI entry windows, CompositorServices layer configuration, RealityKit and
  Metal render paths, VideoToolbox decoding, event watchdogs, world tracking,
  performance overlay, and eye-broadcast extension.
- Studied `alvr-org/Monado-ALVR` as an ALVR-oriented Monado fork/reference
  around remote-driver configuration, OpenXR runtime manifests, IPC/swapchain
  docs, tracing, metrics, and driver-writing material.
- Studied `alvr-org/VRCFT-ALVR` as a VRCFaceTracking module that receives ALVR
  UDP payloads and maps eye, Meta/Facebook, Pico, and HTC face-tracking
  parameter sets into unified eye/expression data.
- Studied `AtlasTheProto/ADBForwarder` as a small wired-streaming helper that
  downloads/locates ADB, starts the ADB server, monitors Quest/Go devices, and
  forwards the TCP ports expected by ALVR.
- Studied `Kierek/WiVRnTimings` as a small Kotlin/Compose timing preset viewer
  that parses CSV timing frames/parts into a quick visual inspection surface.

## Reuse candidates

- `alvr-visionos` is the strongest donor for platform-specific headset client
  lifecycle: entry UI, renderer selection, decoder setup, world tracking,
  performance overlay, and watchdog-backed ALVR event loop.
- `VRCFT-ALVR` is the strongest donor for prefix-dispatched tracking payload
  parsing and vendor-expression remapping into a unified face-tracking model.
- `ADBForwarder` is a good micro-utility reference for one-button setup repair:
  discover tool, start service, monitor device, apply port forwards, and print
  human-readable status.
- `WiVRnTimings` is thin but useful as a reminder that timing/debug data can be
  made inspectable with a small parser/viewer rather than a full diagnostic
  suite.

## Follow-up backlog

1. Compare platform-client boundaries across `ALVR`, `alvr-visionos`, Android
   clients, and future Vision Pro/Quest sidecars.
2. Extract a generic `streaming ecosystem companion` blueprint: setup helper,
   telemetry viewer, tracking adapter, and runtime bridge.
3. Revisit `Monado-ALVR` only if a future OpenXR runtime-fork comparison pass
   needs ALVR-specific diffs rather than Monado documentation patterns.
4. Compare `VRCFT-ALVR` with VRCFaceTracking modules from Wave 106 when a
   face-tracking adapter prototype becomes active.
5. Keep ADB-forwarding helpers as micro-utility references, not as an
   invitation to add platform-tool binaries into this repository.

## Quality notes

- No third-party project was built, launched, installed, or run.
- `alvr-org/ALVR` and `WiVRn/WiVRn` were intentionally not duplicated as new
  studied projects.
- Downloaded source clones belong only in local cache and should be removed
  after the wave is committed.
