# GitHub Research Wave 8 Backlog

- Date: `2026-04-18`
- Scope: new GitHub discovery wave focused on repositories missing from the
  current `VR-apps-lab` registry.

## Status legend

- `Done`
- `Next`

## Work package A: Process hardening

- `Done` Define a better workflow than `search -> clone everything -> write later`
- `Done` Add local-only source cache model
- `Done` Add sync script for GitHub research sources
- `Done` Document the wave plan separately from the global restructuring backlog

## Work package B: GitHub search and shortlist

- `Done` Search GitHub across `SteamVR/OpenVR/OpenXR` utility keywords
- `Done` Compare search results against the current registry
- `Done` Freeze a shortlist for deep study
- `Done` Record secondary candidates for later waves

## Work package C: Local source acquisition

- `Done` Create `.research-sources/github/` local cache
- `Done` Clone `sh-akira/VROverlay`
- `Done` Clone `BenWoodford/SteamVR-Webkit`
- `Done` Clone `beniwtv/vr-streaming-overlay`
- `Done` Clone `Nyabsi/steamvr_overlay_vulkan`
- `Done` Clone `Beyley/eepyxr`
- `Done` Clone `matzman666/OpenVR-MicrophoneControl`
- `Done` Clone `simonowen/dashfix`
- `Done` Clone `sencercoltu/steamvr-undistort`
- `Done` Clone `W-Drew/SteamVR-Toggle`
- `Done` Clone `elvissteinjr/SteamVR-VoidScene`
- `Done` Clone `copperpixel/steamvrbattery`
- `Done` Verify that cloned sources remain outside git tracking

## Work package D: Code-level deep pass

- `Done` Inspect overlay lifecycle and input patterns in `VROverlay`
- `Done` Inspect browser-backed overlay architecture in `SteamVR-Webkit`
- `Done` Inspect config-driven multi-overlay flow in `vr-streaming-overlay`
- `Done` Inspect Vulkan/ImGui overlay template design in `steamvr_overlay_vulkan`
- `Done` Inspect OpenXR overlay and blend-mode strategy in `eepyxr`
- `Done` Inspect dashboard overlay + system integration in `OpenVR-MicrophoneControl`
- `Done` Inspect injection-based dashboard fix pattern in `dashfix`
- `Done` Inspect distortion-adjustment workflow in `steamvr-undistort`
- `Done` Inspect tray-toggle micro-tool pattern in `SteamVR-Toggle`
- `Done` Inspect support-scene application pattern in `SteamVR-VoidScene`
- `Done` Inspect CLI battery monitor pattern in `steamvrbattery`

## Work package E: Repository updates

- `Done` Add a new wave synthesis document
- `Done` Update project registry with newly studied and newly discovered repos
- `Done` Update overlap families with new groupings
- `Done` Update `not-yet-studied-deeply.md` with newly discovered backlog
- `Done` Update `methods` catalog with new reusable approaches
- `Done` Update discovery docs and navigation

## Work package F: Verification and publish

- `Done` Verify `.gitignore` protects local research sources
- `Done` Remove temporary local helper file from repo root
- `Done` Review git diff and status
- `Done` Commit changes
- `Done` Push to `origin/main`

## Follow-up candidates after this wave

- `Next` Deep pass `KainosSoftwareLtd/VRSceneOverlay`
- `Next` Deep pass `vrkit-platform/vrkit-platform`
- `Next` Deep pass `LunarG/OpenXR-Overlays-UE4-Plugin`
- `Next` Deep pass `elvissteinjr/SteamVR-PrimaryDesktopOverlay`
- `Next` Deep pass `DavidRisch/steamvr_utils`
