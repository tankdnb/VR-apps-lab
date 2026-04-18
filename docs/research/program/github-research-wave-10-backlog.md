# GitHub Research Wave 10 Backlog

- Date: `2026-04-18`
- Scope: next GitHub discovery wave focused on untracked repositories that add
  new runtime, bridge-driver, no-headset, capture, and SteamVR environment
  patterns to `VR.app`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for untracked OpenXR runtime implementations
- `Done` Search GitHub for untracked SteamVR/OpenVR no-headset helpers
- `Done` Search GitHub for mixed-VR controller and bridge drivers
- `Done` Search GitHub for creator-side OpenVR capture integrations
- `Done` Deduplicate all results against the registry
- `Done` Freeze a bounded shortlist for code-level inspection
- `Done` Record secondary candidates for future waves

## Work package B: Local source acquisition

- `Done` Clone `mbucchia/VirtualDesktop-OpenXR`
- `Done` Clone `BnuuySolutions/OculusKiller`
- `Done` Clone `ChristophHaag/SteamVR-OpenHMD`
- `Done` Clone `username223/SteamVRNoHeadset`
- `Done` Clone `baffler/OBS-OpenVR-Input-Plugin`
- `Done` Clone `Hotrian/OpenVRTwitchChat`
- `Done` Clone `mm0zct/Oculus_Touch_Steam_Link`
- `Done` Clone `SlimeVR/SlimeVR-OpenVR-Driver`
- `Done` Clone `n1ckfg/ViveTrackerExample`
- `Done` Clone `BnuuySolutions/SteamVRLinuxFixes`
- `Done` Clone `oleuzop/VirtualSteamVRDriver`
- `Done` Clone `craftyinsomniac/WFOVFix`
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect runtime-registration, precompositor, and live-settings refresh
  paths in `VirtualDesktop-OpenXR`
- `Done` Inspect vendor-shell replacement and process supervision flow in
  `OculusKiller`
- `Done` Inspect OpenHMD-to-SteamVR driver bridge structure in
  `SteamVR-OpenHMD`
- `Done` Inspect documented null-driver workflow in `SteamVRNoHeadset`
- `Done` Inspect mirror-texture capture pipeline in
  `OBS-OpenVR-Input-Plugin`
- `Done` Inspect Unity/Twitch IRC overlay architecture in
  `OpenVRTwitchChat`
- `Done` Inspect mixed-controller driver plumbing in
  `Oculus_Touch_Steam_Link`
- `Done` Inspect external-service bridge design in
  `SlimeVR-OpenVR-Driver`
- `Done` Inspect no-HMD tracker workflow and Unity helper script in
  `ViveTrackerExample`
- `Done` Inspect Vulkan-layer and compositor-patch model in
  `SteamVRLinuxFixes`
- `Done` Inspect configurable virtual-HMD driver design in
  `VirtualSteamVRDriver`
- `Done` Inspect guided settings patcher flow in `WFOVFix`

## Work package D: Repository updates

- `Done` Add Wave 10 plan document
- `Done` Add Wave 10 backlog document
- `Done` Add Wave 10 synthesis document
- `Done` Update project registry with newly studied repositories
- `Done` Add newly discovered follow-up candidates to the registry
- `Done` Update overlap families with the new nodes
- `Done` Update `not-yet-studied-deeply.md`
- `Done` Update methods catalog with new reusable methods
- `Done` Update research navigation to include Wave 10

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Deep pass `alexander-clarke/openvr-room-mapping`
- `Next` Compare `VirtualDesktop-OpenXR` with other runtime-switcher and doctor
  tools as a runtime-implementation reference
- `Next` Compare `SteamVRNoHeadset`, `ViveTrackerExample`, and
  `VirtualSteamVRDriver` as a dedicated headsetless-development family
- `Next` Compare `Oculus_Touch_Steam_Link`, `SteamVR-OpenHMD`, and
  `SlimeVR-OpenVR-Driver` as a mixed-runtime and bridge-driver family
