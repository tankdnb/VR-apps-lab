# GitHub Research Wave 156 Backlog

- Date: `2026-06-05`
- Theme: `OpenXR/VRCFT eye-face modules, calibration clients, and avatar facetracking preparation`
- Status: `Completed`

## Completed Pass

1. Search VRCFT OpenXR module, ALXR module, Quest Pro, PSVR2 calibration, and
   avatar facetracking package repositories.
2. Deduplicate against registry, VRCFaceTracking waves, PSVR2 backlog nodes,
   and avatar preparation families.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect OpenXR runtime switching, extension selection, native bridges,
   packet ingress, config files, filters, threshold editors, OSC cleanup, and
   calibration persistence.
5. Promote or clarify all four repositories.
6. Integrate results into registry, families, methods, current focus, indexes,
   and follow-up backlog.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `regzo2/VRCFaceTracking-QuestProOpenXR` | Added as archived Quest Pro OpenXR/VRCFT expression-mapping reference |
| `korejan/VRCFT-ALXR-Modules` | Added as strong local/remote ALXR VRCFT module donor |
| `PawlygonStudio/VRC-Facetracking` | Added as avatar-side facetracking authoring and threshold-editor donor |
| `tobexeon/PSVR2EyeTrackingCalibration` | Promoted from not-studied backlog to real-time PSVR2 calibration client reference |

## Useful Follow-Up Work

- Compare ALXR local/remote VRCFT extension selection with modern
  VRCFaceTracking module APIs before any direct reuse.
- Extract a facetracking authoring checklist from Pawlygon, VRCFT templates,
  and other avatar package references.
- Keep PSVR2 calibration as a UX/protocol reference until the custom toolkit
  fork dependency is separately studied.

## Not Pursued In This Wave

- No headset, VRChat, OpenXR runtime, SteamVR, or device validation.
- No Unity project opening or avatar import.
- No running, building, installing, or launching found repositories.
