# GitHub Research Wave 158 Plan

- Date: `2026-06-05`
- Theme: `VRChat OSC telemetry, avatar scaling, device/status, and parameter-control helpers`
- Scope: avatar-as-display telemetry, avatar scale controllers, and
  avatar-authored camera/path control systems.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Recent VRChat companion waves produced many broad OSC routers and text tools.
Wave 158 studies narrower avatar-control utilities where the avatar itself is
the display or control surface: clock hands driven by OSC floats, eye-height
scaling commands, world-limit state, compatibility shims, and camera path
authoring through avatar contacts, menus, and parameters.

## Search Families

- VRChat avatar parameter telemetry
- watch/device/status OSC senders
- avatar scale and eye-height controllers
- OSC server/client helpers
- avatar-authored camera path systems
- companion protocol and parameter-control utilities

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Quesys-tech/vrcwatch.rs` | Minimal Rust time/moonphase-to-avatar-parameters sender | Avatar-as-display telemetry |
| `KutayX7/vrc-avi-scaler` | Python OSC avatar scale controller with world-limit intake and scaling-system compatibility shims | Avatar scale control helpers |
| `VRLabs/Camera-System` | Previously partial avatar/companion camera path system; deepened for OSC/path-authoring architecture | Avatar-authored camera/path systems |

## Dedupe Notes

- `VRLabs/Camera-System` was already covered as a Wave 90 product reference;
  this pass deepens the avatar/companion contract instead of re-adding it as a
  new repository.
- ADVOSC and XOSC overlap this family but are documented in Wave 157 because
  their primary reusable value in this pass is chatbox composition.

## Code-Level Pass Targets

- OSC address validation and minimal typed senders;
- time/moonphase normalization for avatar parameters;
- server-side intake of VRChat eye-height/world-limit state;
- smooth scaling step calculation and quantization mitigation;
- compatibility adapters for third-party avatar scaling systems;
- avatar-side camera path data capture through constraints, contacts,
  physbones, menus, and companion executable.

## Expected Outputs

- New Wave 158 landscape synthesis.
- Registry/family updates for avatar telemetry, scale control, and camera/path
  systems.
- Methods around avatar-as-display telemetry, world-aware scale control, and
  avatar-authored companion protocols.
