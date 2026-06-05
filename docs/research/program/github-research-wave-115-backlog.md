# GitHub Research Wave 115 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on Linux spatial desktops,
  Stardust workspace clients, virtual monitors, launchers, workspace grouping,
  and desktop-to-XR helper bridges.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for Linux VR desktop, Stardust client, virtual monitor,
  spatial launcher, workspace grouping, xrdesktop, and picom companion projects
- `Done` Deduplicate surfaced repositories against registry and families
- `Done` Freeze a bounded shortlist spanning full desktop shell, Stardust panel
  bridge, virtual monitor shell, launcher, workspace grouping, and
  compositor/DBus companion helper

## Work package B: Local source acquisition

- `Done` Confirm `Simula` in local cache
- `Done` Confirm `flatland` in local cache
- `Done` Confirm `kiara` in local cache
- `Done` Confirm `protostar` in local cache
- `Done` Confirm `magnetar` in local cache
- `Done` Confirm `picom-xrdesktop-companion` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect Simula desktop UX, gaze-active windows, keyboard/mouse grab,
  workspace shortcuts, Godot/OpenXR/OpenHMD/Monado backend glue, and HUD timing
  references
- `Done` Inspect flatland panel/toplevel state, resize handles, pointer input,
  touch input, close button, panel-shell transfer, and initial placement logic
- `Done` Inspect kiara Stardust client launch, Niri compositor startup, ring
  virtual monitor mapping, panel event forwarding, and surface material setup
- `Done` Inspect protostar desktop-entry scanning, Stardust connection
  environment, startup token, systemd/double-fork launch, and hex/app-grid
  launcher surfaces
- `Done` Inspect magnetar workspace root, fields, cells, zones, capture queue,
  root movement, and grab/ring affordances
- `Done` Inspect picom-xrdesktop-companion README, picom DBus window metadata,
  X11/composite/damage texture path, xrdesktop/gxr/gulkan surface path, input
  synthesis, and stacking/overlay caveats

## Work package D: Repository updates

- `Done` Add Wave 115 plan document
- `Done` Add Wave 115 backlog document
- `Done` Add Wave 115 synthesis document
- `Done` Update the project registry for Linux spatial desktop donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with desktop shell, panel bridge,
  launcher, workspace grouping, and compositor helper methods
- `Done` Update documentation indexes to include Wave 115

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare Stardust panel input with earlier WayVR and desktop-overlay
  families before designing a local panel/window helper
- `Next` Revisit Simula only as a full-shell reference; keep Stardust clients
  visible as smaller reusable micro-utility donors
- `Next` Keep picom/xrdesktop companion caveats explicit when discussing X11
  desktop mirroring
