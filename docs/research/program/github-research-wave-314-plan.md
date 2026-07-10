# GitHub Research Wave 314 Plan - PSVR2Toolkit Downstream Clients, Gaze Capture, Haptics, and Installer Microtools

## Goal

Study downstream PSVR2Toolkit clients as reusable references for gaze-image
capture adapters, headset-rumble relays, signed-driver install/rollback tools,
and game-specific IPC consumers.

## Research Questions

- How do downstream tools consume only narrow PSVR2Toolkit capabilities such as
  eye images, rumble, or trigger effects?
- What boundaries recur across C API adapters, local IPC clients, and
  install-state managers?
- How safely do these projects handle modified SteamVR driver installation,
  rollback, and update checks?
- Which consumer patterns are generic versus game-specific?

## Shortlist

- `BnuuySolutions/PSVR2Toolkit.Baballonia`
- `tabithamoon/PSVR2HeadpatHaptics`
- `MaidScientistIzutsumiMarin/psvr2toolkit-installer`
- `Kingoooooooo/Pistol-Whip-Adaptive-Triggers`

## Required Checks

- Deduplicate against earlier PSVR2, gaze, haptics, and runtime-helper waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep driver patching, safety, authentication, and game-specific consumer
  caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 314.
- Registry/family entries for PSVR2Toolkit downstream clients.
- Method catalog entry for PSVR2 toolkit downstream client boundaries.
- Follow-up gaps for installer safety, consumer policy, and cross-client
  comparison.
