# GitHub Research Wave 155 Backlog

- Date: `2026-06-05`
- Theme: `Hand tracking, simulated XR hands, and reusable hand/control primitives`
- Status: `Completed`

## Completed Pass

1. Search hand tracking, simulated hands, gesture pose, and Unity XR toolkit
   primitive projects.
2. Deduplicate against WebXR hand input and existing Unity toolkit families.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect OpenXR extension boundaries, hand mesh/joint handling, simulated
   pose providers, keyboard/mouse mappings, data gathering, value interactables,
   socket highlighting, and menu/setup helpers.
5. Promote new projects and deepen the existing `ExPresS-XR` note.
6. Integrate results into registry, families, methods, current focus, indexes,
   and follow-up backlog.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `joemarshall/openxrhands` | Added as Unity OpenXR hand joint and hand mesh extension bridge donor |
| `MThogersen/AutoHandSimulator` | Added as no-HMD AutoHand/editor hand simulation donor |
| `InfernoDigital/RoboHands-UnityXR` | Added as source-light gesture pose package reference |
| `eisclimber/ExPresS-XR` | Deepened as scientific XR toolkit primitive, data gathering, socket, and menu reference |

## Useful Follow-Up Work

- Create a no-HMD hand/control testing matrix across `AutoHandSimulator`,
  `GodotXRDesktop`, WebXR emulator work, and virtual driver families.
- Compare `openxrhands` with modern Unity/OpenXR package support before any
  direct extension-level reuse.
- Extract a Unity toolkit primitive catalog from `ExPresS-XR`, MRTK, VRTK, and
  VR Builder if a Unity prototype becomes active.

## Not Pursued In This Wave

- No Unity project opening, package import, build, play-mode, headset, or
  device validation.
- No package download from external demo links.
- No runtime validation of hand tracking extensions.
