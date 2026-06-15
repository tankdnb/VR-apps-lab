# GitHub Research Wave 306 Plan - XR Testing, Simulation, Input Validation, and Performance Harnesses

## Goal

Study XR testing, live input inspection, functional validation, performance
measurement, and editor simulation projects as reusable references for XR
doctor tools, reproduction scenes, runtime capability reports, and performance
metadata.

## Research Questions

- How do projects expose live XR device inventory, feature values, and haptic
  capabilities?
- Which automated functional tests are useful as reusable validation patterns?
- How are performance samples, runtime metadata, and result JSON captured?
- Where should editor simulation sit relative to runtime code and production
  builds?

## Shortlist

- `Unity-Technologies/XRInputTests`
- `Unity-Technologies/xr.sdk.functionaltests`
- `Unity-Technologies/com.unity.xr.test-framework.performance`
- `needle-tools/ar-simulation`

## Required Checks

- Deduplicate against earlier OpenXR diagnostics, conformance, and runtime
  doctor waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep editor-only, package/license, simulation, haptic, and measurement
  environment caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 306.
- Registry/family entries for XR testing, simulation, and validation
  harnesses.
- Method catalog entry for XR validation harness boundaries.
- Follow-up gaps around XRInputTests export workflow, performance result
  schema, and XR doctor report design.
