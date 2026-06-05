# GitHub Research Wave 131 Plan

- Date: `2026-06-05`
- Goal: study DIY/open-source headset hardware bring-up, OpenVR drivers, PCBs,
  controller firmware, RF/HID/UART transport, and configuration GUI tooling.

## Why this wave exists

DIY headset projects expose a complete physical-to-runtime stack: sensors,
firmware, transport, driver pose update, display settings, controller inputs,
PCB/BOM/STL files, and user-facing calibration/settings tooling.

## Search scope

Primary search directions:

- DIY VR headset hardware projects;
- Relativty and HadesVR ecosystem repositories;
- OpenVR HMD driver shells;
- controller firmware and RF payloads;
- HMD PCB and controller PCB references;
- settings GUI and calibration support tools.

## Frozen shortlist for code-level study

- `relativty/Relativty`
- `HadesVR/HadesVR`
- `HadesVR/Wand-Controller`
- `HadesVR/Basic-HMD-PCB`
- `JX5S/HadesVR_GUI_Tool`
- `dmcke5/DIY_VR_Controllers`
- `dietzus/DietzVR`

## Execution model

### Step 1: Search and deduplicate

- search by DIY headset, OpenVR HMD driver, controller firmware, HadesVR,
  Relativty, PCB, and settings GUI families;
- deduplicate against earlier no-HMD, virtual-HMD, OpenVR driver, tracker, and
  hardware bridge waves.

### Step 2: Freeze the shortlist

- include two full-stack headset references, controller PCB/firmware nodes, a
  settings GUI, one variant controller repo, and one weak candidate for honest
  rejection.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- OpenVR driver factory and HMD display components;
- HID/UART/RF packet formats and demux;
- IMU filtering and calibration;
- controller/tracker input components;
- driver settings schema and GUI editor;
- PCB/BOM/Gerber/STL repository structure.

### Step 5: Promote findings into repository structure

Update Wave 131 landscape, registry, families, methods, backlog, current
focus, and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, flashed, or launched;
- local source cache is cleaned after integration.

## Definition of done

This wave is complete when DIY headset hardware/driver bring-up patterns are
documented and placed in the canonical research system.
