# GitHub Research Wave 132 Plan

- Date: `2026-06-05`
- Goal: study VR keyboard, text-entry, avatar-keyboard, and OSC input
  surfaces as reusable patterns for entering text or emitting control input
  while a user stays inside VR.

## Why this wave exists

Text entry remains one of the least pleasant VR utility problems. This wave
looks at several different answers:

- modal WebVR keyboard surfaces;
- raycast/canvas keyboards;
- physical fingertip key presses;
- native OpenVR keyboard bridges for mod hosts;
- VRChat OSC input emitters;
- deprecated avatar-contained keyboard ideas.

## Search scope

Primary search directions:

- VR keyboard;
- WebVR and React 360 keyboard;
- Unity VR keyboard;
- OpenVR keyboard overlay;
- VRChat OSC keyboard/control emitters;
- avatar-contained keyboard surfaces.

## Frozen shortlist for code-level study

- `danielbuechele/react-360-keyboard`
- `erosmarcon/vr-keyboard`
- `jcorvinus/VRKeyboard`
- `mrowrpurr/VR_Keyboard`
- `anosatsuk124/VRC-KeyboardController-in-VR_OSC`
- `killfrenzy96/KillFrenzyVRCAvatarKeyboard`

## Execution model

### Step 1: Search and deduplicate

- search by keyboard/text-entry families rather than random overlay links;
- deduplicate against existing overlay, VRChat OSC, avatar text, and menu waves.

### Step 2: Freeze the shortlist

- include WebVR, Three.js, Unity, OpenVR, VRChat OSC, and avatar-keyboard
  variants;
- keep deprecated/broken projects only when they preserve an architectural
  lesson.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep source clones local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- keyboard lifecycle and modal promise/callback model;
- layout switching and target-field binding;
- raycast or fingertip input flow;
- native OpenVR keyboard event polling;
- OSC address model and reset cadence;
- host integration and fallback behavior.

### Step 5: Promote findings into repository structure

Update Wave 132 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when VR text-entry and control-input patterns are
documented with donor value, caveats, family placement, and reusable methods.
