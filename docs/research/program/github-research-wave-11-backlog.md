# GitHub Research Wave 11 Backlog

- Date: `2026-04-18`
- Scope: next GitHub discovery wave focused on runtime adapters,
  virtual-display drivers, validation helpers, driver examples, and workflow
  micro-utilities that were not yet tracked in `VR.app`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for untracked OpenXR runtime-adapter and API-layer
  utilities
- `Done` Search GitHub for untracked engine-side OpenXR runtime selectors
- `Done` Search GitHub for untracked OpenVR driver examples and virtual
  controller samples
- `Done` Search GitHub for untracked virtual-display and display-repurposing
  drivers
- `Done` Search GitHub for screenshot, creator, and timed-capture utilities
- `Done` Search GitHub for SteamVR validation and focused config patch tools
- `Done` Deduplicate all results against the registry
- `Done` Freeze a bounded shortlist for code-level inspection
- `Done` Record secondary candidates for future waves

## Work package B: Local source acquisition

- `Done` Confirm `mbucchia/OpenXR-Vk-D3D12` in local cache
- `Done` Confirm `shiena/OpenXRRuntimeSelector` in local cache
- `Done` Confirm `1runeberg/OpenXRProvider` in local cache
- `Done` Confirm `ValveSoftware/virtual_display` in local cache
- `Done` Confirm `finallyfunctional/openvr-driver-example` in local cache
- `Done` Confirm `SecondReality/VirtualControllerDriver` in local cache
- `Done` Confirm `oneup03/VRto3D` in local cache
- `Done` Confirm `BOLL7708/SuperScreenShotterVR` in local cache
- `Done` Confirm `iigomaru/Periodic-Immersive-SteamVR-Screenshots` in local
  cache
- `Done` Confirm `Virus-vr/SteamVRAdaptiveBrightness` in local cache
- `Done` Confirm `username223/SteamVR-ActionsManifestValidator` in local cache
- `Done` Confirm `Erimelowo/Lighthouse-Scale-Fix` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect graphics interop and dispatch model in `OpenXR-Vk-D3D12`
- `Done` Inspect runtime-provider enumeration and registry handling in
  `OpenXRRuntimeSelector`
- `Done` Inspect wrapper-library plus sandbox architecture in `OpenXRProvider`
- `Done` Inspect `IVRVirtualDisplay` and remote-process transport model in
  `virtual_display`
- `Done` Inspect minimal input-emulation driver pattern in
  `openvr-driver-example`
- `Done` Inspect synthetic controller driver pattern in
  `VirtualControllerDriver`
- `Done` Inspect profile-driven stereo-display driver and workflow shaping in
  `VRto3D`
- `Done` Inspect screenshot overlay, viewfinder, and WebSocket automation flow
  in `SuperScreenShotterVR`
- `Done` Inspect ultra-minimal timed screenshot utility in
  `Periodic-Immersive-SteamVR-Screenshots`
- `Done` Inspect mirror-texture brightness analysis pipeline in
  `SteamVRAdaptiveBrightness`
- `Done` Inspect manifest validation checks and test coverage in
  `SteamVR-ActionsManifestValidator`
- `Done` Inspect focused config-patch and backup flow in
  `Lighthouse-Scale-Fix`

## Work package D: Repository updates

- `Done` Add Wave 11 plan document
- `Done` Add Wave 11 backlog document
- `Done` Add Wave 11 synthesis document
- `Done` Update project registry with newly studied repositories
- `Done` Update overlap families with the new nodes
- `Done` Update `not-yet-studied-deeply.md` with the new follow-up gaps
- `Done` Update methods catalog with Wave 11 reusable methods
- `Done` Update documentation navigation to include Wave 11

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Deep pass `OpenDisplayXR/OpenDisplayXR-VDD` if the repository gains
  real source or stronger documentation
- `Next` Deep pass `1runeberg/OpenXRProvider` beyond core/render bring-up,
  especially input profiles and extension wrappers
- `Next` Compare `ValveSoftware/virtual_display`, `oneup03/VRto3D`, and
  `OpenDisplayXR/OpenDisplayXR-VDD` as one `virtual display and repurposed
  output` family
- `Next` Compare `SteamVRAdaptiveBrightness`, `SteamVR-ActionsManifestValidator`,
  `Lighthouse-Scale-Fix`, and `steamvr-exconfig` as a `workflow
  micro-utilities` family
