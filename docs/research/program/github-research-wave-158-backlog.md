# GitHub Research Wave 158 Backlog

- Date: `2026-06-05`
- Theme: `VRChat OSC telemetry, avatar scaling, device/status, and parameter-control helpers`
- Status: `Completed`

## Completed Pass

1. Search VRChat watch, avatar scale, status, device, and camera/path OSC
   helper repositories.
2. Deduplicate against VRChat camera/admin, avatar companion, and chatbox
   families.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect typed OSC senders, avatar parameter names, scale math, world-limit
   intake, compatibility shims, Unity package metadata, expression menus,
   animator/parameter assets, and instancer workflow.
5. Promote `vrcwatch.rs`, add `vrc-avi-scaler`, and deepen
   `VRLabs/Camera-System`.
6. Integrate results into registry, families, methods, current focus, indexes,
   and follow-up backlog.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `Quesys-tech/vrcwatch.rs` | Added as minimal avatar-as-watch OSC telemetry sender |
| `KutayX7/vrc-avi-scaler` | Added as avatar eye-height scaling and compatibility shim donor |
| `VRLabs/Camera-System` | Deepened as avatar-authored OSC camera path and companion executable reference |

## Useful Follow-Up Work

- Compare avatar-as-display telemetry with chatbox status surfaces and overlay
  telemetry; the same data should not require three incompatible adapters.
- Build an avatar-scaling safety checklist covering world limits, base height,
  VR/desktop quirks, smooth interpolation, and third-party prefab contracts.
- If camera tools become active, extract the Camera-System companion protocol
  and path encoding model in a dedicated reuse note.

## Not Pursued In This Wave

- No VRChat client, avatar upload, Unity editor, OSC endpoint, or companion
  executable was run.
- No found repository was run, built, installed, launched, or runtime-validated.
