# GitHub Research Wave 253 Plan

Date: 2026-06-06

Theme: SteamVR dashboard menu, keyboard, and gamepad navigation shims.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Many VR utilities are small control shims rather than visual overlays. This
wave studies alternate SteamVR dashboard/menu input paths and runtime control
proxies.

## Search Families

- SteamVR dashboard keyboard navigation.
- Quest/SteamVR system-button forwarding.
- Gamepad to synthetic OpenVR controller.
- SteamVR keyboard layout patching.
- Dashboard/volume to audio backend bridges.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `mbucchia/SteamVR-Dashboard-KeyboardNav` | Driver shim and companion utility for keyboard/facemouse dashboard navigation. | Dashboard shim donor |
| `lmore377/quest-steamvr-system-button` | ADB/logcat Quest system button to SteamVR dashboard toggle. | Platform button bridge |
| `AJBats/pad-vr` | XInput gamepad exposed as synthetic Index-style SteamVR controller. | Synthetic controller donor |
| `MagnaLunas/SteamVRKeyboardLayoutChanger` | Historical dashboard keyboard web-resource layout patcher. | Dashboard patch caveat |
| `bpbwaite/ahk-svrvmr` | SteamVR dashboard volume slider to Voicemeeter bus gain bridge. | Audio control microtool |

## Dedupe Notes

The obvious SteamVR overlay repositories were mostly already tracked. This
wave intentionally keeps smaller dashboard/control shims that were not in the
registry.

## Code-Level Pass Targets

- Driver/shim entry points.
- Input profiles, synthetic components, and dashboard actions.
- Companion process and shared-memory contracts.
- Platform log/debug URI adapters.
- Obsolete dashboard resource patching caveats.

## Expected Outputs

- Wave 253 landscape synthesis.
- Registry/family entry for SteamVR dashboard/menu input shims.
- Method catalog entry for dashboard control shims.
- Follow-up backlog for input ownership and conflict checks.
