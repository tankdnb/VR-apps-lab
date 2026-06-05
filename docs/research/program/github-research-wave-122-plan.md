# GitHub Research Wave 122 Plan

- Date: `2026-06-05`
- Goal: study camera/MediaPipe tracking bridges that convert face, body, hand,
  or VRM landmarks into SlimeVR, VRChat OSC, Unity pipes, or virtual-controller
  messages.

## Why this wave exists

Earlier waves covered larger vision-tracking and SlimeVR ecosystems. This wave
looks at smaller camera/MediaPipe bridge projects because they expose reusable
conversion seams: landmark selection, coordinate conversion, smoothing,
calibration, transport, and target-specific output formatting.

## Search scope

Primary search directions for this wave:

- MediaPipe-to-SlimeVR trackers;
- webcam face tracking for VRChat;
- browser MediaPipe-to-VRM facial/hand tracking;
- Unity avatar pose streams from Python camera processes;
- MediaPipe hand landmarks as virtual controller or OSC messages.

## Frozen shortlist for code-level study

- `TkskKurumi/SlimeVR-Tracker-Mediapipe`
- `hotaru86/MediapipeFaceTracking_VRC`
- `how-people-lived/mediapipe-vrm-tracking`
- `Metastazius/VRBodyTrack`
- `vwitted/mediapipe_VR_controller`

## Execution model

### Step 1: Search and deduplicate

- search GitHub by MediaPipe VR, SlimeVR MediaPipe, VRChat face tracking,
  webcam VR controller, and VRM tracking families;
- deduplicate against earlier vision-tracking waves and SlimeVR ecosystem
  entries;
- treat these projects as micro-bridges, not replacements for stronger
  tracking hosts.

### Step 2: Freeze the shortlist

- include body-to-SlimeVR UDP, face-to-VRChat OSC, browser VRM tracking,
  Python-to-Unity named-pipe body tracking, and hand-to-virtual-controller OSC.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- camera capture and MediaPipe model use;
- landmark-to-axis, landmark-to-blendshape, or landmark-to-controller mapping;
- smoothing, calibration, and visibility handling;
- UDP, OSC, named-pipe, browser-local, or Unity transport;
- target-specific payload schema and caveats.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 122 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- micro-utilities are documented as references, not production trackers;
- transport and calibration caveats remain visible;
- found projects are not built, launched, or installed;
- `.research-sources/` remains local-only;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in local cache;
3. a Wave 122 synthesis document exists with code-level findings;
4. registry and families represent camera/MediaPipe bridge patterns clearly;
5. methods capture landmark-to-tracker, face-expression, and simple
   virtual-controller transport patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
