# GitHub Research Wave 9 Backlog

- Date: `2026-04-18`
- Scope: next GitHub discovery wave focused on untracked repositories that add
  new runtime, overlay, dashboard, or tracking-development patterns to
  `VR-apps-lab`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for untracked `OpenXR runtime` tools
- `Done` Search GitHub for untracked `OpenVR/SteamVR overlay` implementations
- `Done` Search GitHub for dashboard micro-utilities tied to VRChat, audio, and
  OSC
- `Done` Search GitHub for pairing and tracking-development helpers
- `Done` Deduplicate all results against the registry
- `Done` Freeze a bounded shortlist for code-level inspection
- `Done` Record secondary candidates for future waves

## Work package B: Local source acquisition

- `Done` Clone `KhronosGroup/OpenXR-Inventory`
- `Done` Clone `rpavlik/xr-picker`
- `Done` Clone `ValveSoftware/OpenXR-Canonical-Pose-Tool`
- `Done` Clone `elliotttate/OpenXR-Simulator`
- `Done` Clone `Hotrian/HeadlessOverlayToolkit`
- `Done` Clone `rrkpp/SpotifyOverlay`
- `Done` Clone `cnlohr/openvr_overlay_model`
- `Done` Clone `JoeLudwig/overlay_experiments`
- `Done` Clone `rrazgriz/VRCMicOverlay`
- `Done` Clone `I5UCC/VRCTextboxSTT`
- `Done` Clone `I5UCC/SteaMeeter`
- `Done` Clone `ugokutennp/watchman-pairing-assistant`
- `Done` Clone `TriadSemi/triad_openvr`
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect data-driven runtime capability matrix design in
  `OpenXR-Inventory`
- `Done` Inspect cross-platform runtime-picker core/gui split in `xr-picker`
- `Done` Inspect config-driven pose validation flow in
  `OpenXR-Canonical-Pose-Tool`
- `Done` Inspect headsetless runtime simulation path in `OpenXR-Simulator`
- `Done` Inspect Unity headless/background overlay-host approach in
  `HeadlessOverlayToolkit`
- `Done` Inspect Qt dashboard overlay rendering in `SpotifyOverlay`
- `Done` Inspect stereo-per-eye overlay trick in `openvr_overlay_model`
- `Done` Inspect Awesomium-backed web overlay experiments in
  `overlay_experiments`
- `Done` Inspect tight-loop C# mic-status overlay pattern in `VRCMicOverlay`
- `Done` Inspect Python STT + overlay + OSC multi-output architecture in
  `VRCTextboxSTT`
- `Done` Inspect Unity dashboard + OSCQuery + external-app control in
  `SteaMeeter`
- `Done` Inspect GUI wrapper around `lighthouse_console` in
  `watchman-pairing-assistant`
- `Done` Inspect Python wrapper and serial-stable device naming in
  `triad_openvr`

## Work package D: Repository updates

- `Done` Add Wave 9 plan document
- `Done` Add Wave 9 backlog document
- `Done` Add Wave 9 synthesis document
- `Done` Update project registry with newly studied repositories
- `Done` Add newly discovered secondary candidates to the registry
- `Done` Update overlap families with the new nodes
- `Done` Update `not-yet-studied-deeply.md`
- `Done` Update methods catalog with new reusable methods
- `Done` Update research navigation to include Wave 9

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and diff
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Deep pass `Ybalrid/OpenXR-Runtime-Manager`
- `Next` Deep pass `clear-xr/clearxr-server`
- `Next` Deep pass `pembem22/etvr-openxr-layer`
- `Next` Deep pass `Martin-Oehler/SteamVR-WebApps`
- `Next` Deep pass `I5UCC/ParameterSaveStates`
- `Next` Deep pass `hai-vr/h-view`
- `Next` Deep pass `biosmanager/unity-openvr-tracking`
- `Next` Deep pass `MuffinTastic/openvr-device-positions`
