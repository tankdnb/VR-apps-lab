# GitHub Research Wave 140 Plan

- Date: `2026-06-05`
- Goal: study WebXR engine/export bridges, device-display adapters, composition
  layers, browser test scaffolds, and Quest showcase examples as reusable
  browser-XR utility foundations.

## Why this wave exists

`VR-apps-lab` already has strong native OpenVR/OpenXR overlay and runtime
references. This wave expands the browser-native side: how Unity exports to
WebXR, how non-HMD displays can masquerade as XR devices, how composition
layers are shimmed, how WebXR can be tested without hardware, and how small
showcase apps gate features such as hit-test, anchors, plane detection, and
controller input.

## Search scope

Primary search directions:

- Unity-to-WebXR export packages;
- minimal Unity WebXR bridges and simulators;
- non-HMD WebXR device/display adapters;
- WebXR layers and test API infrastructure;
- Quest/WebXR showcase apps with reusable interaction flows.

## Frozen shortlist for code-level study

- `De-Panther/unity-webxr-export`
- `Rufus31415/Simple-WebXR-Unity`
- `Looking-Glass/looking-glass-webxr`
- `immersive-web/webxr-layers-polyfill`
- `immersive-web/webxr-test-api`
- `meta-quest/webxr-showcases`

## Execution model

### Step 1: Search and deduplicate

- search by WebXR export, Unity WebGL XR, layers, test API, Looking Glass, and
  Quest showcase families;
- deduplicate against prior WebXR sample, emulator, polyfill, and React/Three
  XR waves.

### Step 2: Freeze the shortlist

- include engine export packages, minimal bridges, display adapters, layer/test
  infrastructure, and product-scale WebXR showcases.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- Unity loader/subsystem boundaries;
- JavaScript/C# bridge payloads;
- reference-space and feature-gating configuration;
- custom XRDevice and multi-view display adaptation;
- session patching and layer renderer shims;
- deterministic WebXR test-device patterns;
- showcase feature requirements, controller flows, and AR placement UX.

### Step 5: Promote findings into repository structure

Update Wave 140 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when browser-XR export, display adaptation, layer/test,
and showcase patterns are documented as reusable foundations for future
`VR-apps-lab` browser-backed utility prototypes.
