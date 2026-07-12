# GitHub Research Wave 325 Plan - SteamVR Hardware Provisioning, Session Autolaunch, and Watchman Dongle Utilities

## Goal

Study narrow SteamVR operational utilities that do not render VR content but
make hardware/session bring-up easier: USB-triggered runtime launch, Watchman
dongle flashing, and multi-device dongle hardware.

## Research Questions

- Which operational helper patterns are reusable for VR session startup and
  hardware readiness tools?
- How should destructive firmware/provisioning actions be documented and gated?
- What can be reused from source-light hardware repos without treating them as
  software donors?

## Shortlist

- `The-Graze/PSVR2-SteamVR-AutoLaunch`
- `ykeara/SteamVR-Dongle-Flash`
- `ugokutennp/flowing-dongle-ccd`

## Required Checks

- Deduplicate against runtime autostart, watchman pairing, SteamVR utility, and
  PSVR2 helper waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, flash, build, install,
  or launch any found project.
- Keep irreversible firmware and hardware caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 325.
- Registry/family entries for hardware provisioning and session autolaunch
  utilities.
- Method catalog entry for VR hardware/session microhelpers with irreversible
  action gates.
