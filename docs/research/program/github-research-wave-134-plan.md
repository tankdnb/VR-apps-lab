# GitHub Research Wave 134 Plan

- Date: `2026-06-05`
- Goal: study SteamVR operational support utilities around startup/shutdown
  automation, dynamic render resolution, Linux device permissions, and vendor
  driver support.

## Why this wave exists

Many useful VR tools are not visible overlays. They are operational helpers:
they start/stop companion scripts with SteamVR, adjust runtime settings based
on performance, repair Linux device access, or proxy vendor drivers to expose
unsupported hardware.

## Search scope

Primary search directions:

- OpenVR startup automation;
- dynamic SteamVR resolution;
- Linux SteamVR udev rules;
- Vive Pro 2 Linux driver support;
- SteamVR settings and application manifest helpers.

## Frozen shortlist for code-level study

- `BOLL7708/OpenVRStartup`
- `Erimelowo/OpenVR-Dynamic-Resolution`
- `ValveSoftware/steam-devices`
- `CertainLach/VivePro2-Linux-Driver`

## Execution model

### Step 1: Search and deduplicate

- search by operational support and runtime-helper families;
- deduplicate against previous OpenVR startup, performance, Linux, and driver
  waves.

### Step 2: Freeze the shortlist

- include one startup lifecycle micro-utility, one performance controller, one
  Linux device-permission reference, and one vendor driver proxy stack.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- SteamVR application manifest and autolaunch calls;
- startup/shutdown event handling;
- frame timing, VRAM, and supersample setting flow;
- Linux udev device rules;
- driver proxy/vtable wrapping, settings, properties, HID config, and install
  packaging.

### Step 5: Promote findings into repository structure

Update Wave 134 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when runtime-support and operational-helper methods are
documented with clear donor value, caveats, and support-boundary lessons.
