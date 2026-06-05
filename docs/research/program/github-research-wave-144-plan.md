# GitHub Research Wave 144 Plan

- Date: `2026-06-05`
- Goal: study WebXR hand-tracking examples, gesture micro-controllers, and
  hand-data export bridges as reusable input patterns for browser-native VR
  utilities.

## Why this wave exists

Earlier waves covered broad WebXR samples, A-Frame components, and engine
wrappers. This wave narrows the lens to hands as a first-class utility input
surface: pinch, fingertip rays, hand meshes, simple object grabbing, and
streaming joint data out of a headset/browser session.

## Search scope

Primary search directions:

- WebXR hand-tracking examples;
- A-Frame hand controls and pinch interaction samples;
- Babylon.js hand tracking bridges;
- Quest browser hand-tracking demos;
- WebSocket hand-pose export and teleoperation references.

## Frozen shortlist for code-level study

- `marlon360/webxr-handtracking`
- `TakashiYoshinaga/webxr-hand-tracking-sample`
- `rick98033/webxr-hand-tracking-websocket`
- `danielklinkhammer/webxr-quest2`

## Execution model

### Step 1: Search and deduplicate

- search by WebXR hand tracking, Quest hand tracking, A-Frame hands, Babylon
  hand tracking, and hand pose WebSocket bridge families;
- deduplicate against prior WebXR, A-Frame, MediaPipe, avatar, and tracker
  bridge waves.

### Step 2: Freeze the shortlist

- keep a mix of low-level hand joint readers, gesture examples, A-Frame
  interaction surfaces, and a data-export bridge.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/`;
- keep all source clones local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- `XRHand` joint enumeration and `XRFrame.getJointPose`;
- pinch thresholds and release hysteresis;
- fingertip ray construction;
- hand-mesh and dot-model UI affordances;
- A-Frame component boundaries;
- Babylon.js hand feature enablement;
- WebSocket payload shape, update-rate limiting, and reconnect behavior.

### Step 5: Promote findings into repository structure

Update Wave 144 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when WebXR hand tracking is documented as both an
interaction method and an external-data bridge pattern for future
`VR-apps-lab` browser-backed tools.
