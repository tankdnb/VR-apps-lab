# GitHub Research Wave 129 Plan

- Date: `2026-06-05`
- Goal: study VMC/VRM motion-capture protocol, OSC transform receivers,
  Quest transform senders, and recording/export tools.

## Why this wave exists

Pose-stream utilities are a recurring need across VR diagnostics, avatars,
tracking helpers, teleoperation, and replay tools. VMC Protocol is a useful
case because it has protocol docs, Unity components, Quest senders, and small
export/record CLIs.

## Search scope

Primary search directions:

- VMC Protocol and VRM OSC motion streams;
- Unity VMC receiver packages;
- Quest OSC transform senders;
- motion stream recorders and replay tools;
- BVH export from VMC/VRM streams.

## Frozen shortlist for code-level study

- `sh-akira/VirtualMotionCapture`
- `sh-akira/VirtualMotionCaptureProtocol`
- `gpsnmeajp/EasyVirtualMotionCaptureForUnity`
- `sh-akira/QuestOSCTransformSender`
- `infosia/vmc2bvh`
- `infosia/vmcrec`

## Execution model

### Step 1: Search and deduplicate

- search by VMC, VRM, OSC transform, mocap receiver, BVH export, and motion
  recording families;
- deduplicate against VRChat OSC, MediaPipe, SlimeVR, VMT, and tracker bridge
  waves.

### Step 2: Freeze the shortlist

- include the canonical app/protocol, Unity receiver package, Quest sender,
  BVH exporter, and typed record/replay utility.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- OSC message addresses and role model;
- receiver filtering, validation, and daisy-chain patterns;
- root/bone/blendshape/camera/device flow;
- control panel and IPC boundaries;
- export, record, replay, and file formats.

### Step 5: Promote findings into repository structure

Update Wave 129 landscape, registry, families, methods, backlog, current
focus, and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after integration.

## Definition of done

This wave is complete when VMC/OSC pose-stream patterns are documented and
placed in the canonical research system.
