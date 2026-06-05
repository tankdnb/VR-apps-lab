# GitHub Research Wave 154 Plan

- Date: `2026-06-05`
- Theme: `Virtual displays, spatial-display OpenXR runtimes, and desktop fallback surfaces`
- Scope: projects that make screens, stereo images, or XR apps usable through
  virtual displays, spatial displays, 3D image viewers, historical display
  hardware concepts, or no-HMD desktop fallbacks.

## Why This Wave Exists

`VR-apps-lab` has a strong overlay and desktop-in-VR branch, but virtual display
research was split across old backlog items and related families. Wave 154
revisits this from the other side: not only "put a desktop in VR", but "make a
display target exist", "make a non-headset spatial display act like OpenXR",
and "make an XR app testable without a headset".

## Search Families

- Linux virtual display managers
- OpenXR runtimes for spatial displays or 3D monitors
- stereo image viewers
- DIY/repurposed display concepts
- Unity desktop-in-VR historical POCs
- Godot XR desktop fallback addons

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `VirtualDrivers/Linux-Virtual-Display-Driver` | Practical Linux virtual display GUI with xrandr, modelines, EDID, NVIDIA setup, and persistence | Virtual display workflow tools |
| `dfattal/openxr-3d-display` | Canonical DisplayXR runtime for spatial displays and 3D monitors | Spatial-display OpenXR runtimes |
| `maximum-game-22/openxr-3d-display` | Existing fork/backlog node now clarified as variant of canonical DisplayXR | Fork/variant comparison |
| `newilia/SbsImageViewer` | OpenXR stereo image viewer with SBS/separate-file handling and launcher | Stereo media utility surfaces |
| `r57zone/VR-Display` | Historical DIY HDMI display/headset concept | Historical display hardware references |
| `tejasXR/Virtual-Desktop-VR` | Old Unity/SteamVR desktop POC, useful mostly as historical reference | Desktop-in-VR historical POCs |
| `Malcolmnixon/GodotXRDesktop` | Godot addon that injects synthetic XR trackers/actions for no-HMD desktop driving | No-HMD engine fallback surfaces |

## Dedupe Notes

- `maximum-game-22/openxr-3d-display` was already in the backlog; this wave
  treats it as a fork/variant only after identifying `dfattal/openxr-3d-display`
  as the canonical upstream.
- `OpenDisplayXR/OpenDisplayXR-VDD` remains inaccessible in normal GitHub
  remote operations and is not promoted.
- `tejasXR/Virtual-Desktop-VR` is added only as a historical/source-light
  product reference, not a strong donor.

## Code-Level Pass Targets

- Virtual display state machine and persistence.
- Modeline, EDID, xrandr, and GPU-specific setup flow.
- OpenXR runtime separation of concerns for non-HMD displays.
- Stereo media source parsing and launcher UX.
- Synthetic tracker/action injection for desktop fallback.
- Source-light or historical caveats.

## Expected Outputs

- New Wave 154 landscape synthesis.
- Registry and family updates for virtual display and spatial-display runtime
  branches.
- Methods around xrandr virtual displays, DisplayXR-style compositor/display
  processor boundaries, stereo image utility surfaces, and no-HMD synthetic XR
  trackers.
