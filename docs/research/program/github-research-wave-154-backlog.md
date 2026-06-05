# GitHub Research Wave 154 Backlog

- Date: `2026-06-05`
- Theme: `Virtual displays, spatial-display OpenXR runtimes, and desktop fallback surfaces`
- Status: `Completed`

## Completed Pass

1. Search virtual-display, spatial-display, stereo-viewer, desktop fallback, and
   historical display workflow projects.
2. Deduplicate against prior desktop-in-VR, virtual display, XR-glasses, and
   OpenXR runtime families.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect display state machines, runtime boundaries, source parsing, launcher
   UX, and fallback action/tracker injection.
5. Clarify fork/source-light/inaccessible nodes.
6. Integrate results into registry, families, methods, current focus, indexes,
   and follow-up backlog.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `VirtualDrivers/Linux-Virtual-Display-Driver` | Added as Linux xrandr/EDID virtual-display workflow donor |
| `dfattal/openxr-3d-display` | Added as canonical DisplayXR spatial-display OpenXR runtime donor |
| `maximum-game-22/openxr-3d-display` | Clarified as fork/variant comparison node |
| `newilia/SbsImageViewer` | Added as OpenXR stereo image viewer and launcher reference |
| `r57zone/VR-Display` | Added as historical DIY display concept reference |
| `tejasXR/Virtual-Desktop-VR` | Added as old Unity/SteamVR desktop POC with low donor value |
| `Malcolmnixon/GodotXRDesktop` | Added as Godot no-HMD synthetic tracker/action fallback donor |

## Useful Follow-Up Work

- Create a virtual display workflow matrix covering Windows VDD, Linux xrandr,
  spatial-display runtimes, desktop capture, and no-HMD fake XR.
- Compare DisplayXR app classes with prior headsetless and special-display
  projects.
- Extract a small no-HMD/fake-XR design note from `GodotXRDesktop`,
  `AutoHandSimulator`, earlier virtual HMD projects, and WebXR emulator work.

## Not Pursued In This Wave

- No xrandr, EDID, GPU, OpenXR runtime, Unity, Godot, or viewer execution.
- No install/build/run attempts.
- No validation of binary releases or external display hardware.
