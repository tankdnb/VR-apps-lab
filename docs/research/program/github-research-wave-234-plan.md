# GitHub Research Wave 234 Plan

Date: 2026-06-06

Theme: XR/smart glasses low-level SDKs, virtual displays, and BLE HUD
templates.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The repository has growing XR-glasses coverage, but still needs a clearer
comparison between low-level IMU/head-mouse wrappers, spatial desktop stacks,
and constrained HUD/BLE app templates for optical smart glasses.

## Search Families

- XR glasses IMU and head-mouse helpers.
- Vendor SDK wrappers.
- Spatial desktop and virtual display stacks.
- BLE protocol libraries for dual-arm smart glasses.
- EvenHub/G2 HUD templates and design systems.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `boomskats/woahland` | Linux Viture head-mouse with uinput, smoothing, deadzone, roll-scroll, config reload, and Unix socket control. | Head-mouse IMU bridge |
| `Wojtekb30/EasyVXR` | Minimal thread-safe C wrapper around Viture SDK IMU/3D/frequency APIs. | Vendor SDK wrapper |
| `darkclad/uxspace` | Android and Windows spatial desktop/virtual display stack with vendor-neutral tracking vocabulary. | XR glasses spatial desktop |
| `emingenc/even_glasses` | Python BLE command library for Even Realities G1 text, RSVP, dashboard, brightness, notifications, and heartbeat. | BLE command micro-library |
| `fabioglimb/even-toolkit` | G2 design system plus per-screen glasses SDK bridge, router, layout, gestures, keep-alive, and STT modules. | Smart-glasses app framework |
| `even-realities/evenhub-templates` | Official starter templates for minimal, ASR, image, and long-text EvenHub apps. | Smart-glasses starter templates |
| `Commute773/g2-kit-unofficial` | Reverse-engineered G2 BLE transport, envelope framing, protobuf builders, audio, images, pager, and coalescer. | BLE protocol and HUD runtime |

## Dedupe Notes

Prior XR-glasses waves covered XREAL/Nreal WebHID, virtual display variants,
and head-tracked desktop helpers. This wave focuses on Viture and Even
Realities stacks that add low-level protocol/HUD implementation lessons.

## Code-Level Pass Targets

- IMU decoding, yaw/pitch mapping, smoothing, deadzone, roll-scroll, and
  runtime control.
- Vendor SDK connection/disconnection and data-copy boundaries.
- VirtualDisplay, SurfaceTexture, DDA, IddCx, and tracking abstraction layers.
- BLE session, dual-arm architecture, envelope framing, CRC, ack/magic,
  render coalescing, and paging.
- Smart-glasses text/image/audio template constraints.

## Expected Outputs

- Wave 234 landscape synthesis.
- Registry/family entries for XR glasses SDK/protocol/HUD stacks.
- Method catalog entry for constrained smart-glasses HUD runtime boundaries.
- Follow-up backlog for protocol, display, and comfort matrices.
