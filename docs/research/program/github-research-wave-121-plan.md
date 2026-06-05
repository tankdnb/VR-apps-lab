# GitHub Research Wave 121 Plan

- Date: `2026-06-05`
- Goal: study XR-glasses desktop, WebHID, IMU, and virtual-display
  micro-utilities as reusable references for head-tracked screen tools,
  spatial desktop helpers, browser-side device probing, and menu-bar display
  companions.

## Why this wave exists

Earlier waves covered stronger XR-glasses anchors such as `XRLinuxDriver`,
`breezy-desktop`, `OpenVR-xrealAirGlassesHMD`, and `PhoenixHeadTracker`. This
wave deliberately looks at smaller adjacent projects that expose different
implementation slices: WebHID protocol probing, X11 capture/cropping, firmware
or IMU utilities, README-only product framing, and macOS virtual-display
surface management.

## Search scope

Primary search directions for this wave:

- XREAL/Nreal WebHID device access and protocol inspection;
- Linux multi-display and virtual-display POCs for glasses;
- desktop-control tools for Nreal Air/XREAL glasses;
- low-level protocol utilities around brightness, firmware, and IMU packets;
- macOS virtual ultrawide display and head-tracked viewport tools.

## Frozen shortlist for code-level study

- `jakedowns/xreal-webxr`
- `alexwilson1/nreal_linux_test`
- `Mailbot/Nreal_Air_Desktop_tool`
- `edwatt/real_utilities`
- `DannyDesert/XReal-Ultrawide`

## Execution model

### Step 1: Search and deduplicate

- search GitHub by XREAL, Nreal, WebXR, WebHID, virtual display, ultrawide, and
  IMU utility families;
- compare candidates against prior XR-glasses waves and registry entries;
- exclude already studied anchors while keeping overlap notes clear.

### Step 2: Freeze the shortlist

- include browser WebHID, Linux X11 desktop POC, thin desktop-control product
  reference, C++ protocol utility, and macOS menu-bar virtual-display app.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- HID device filtering, command/report flow, and IMU packet logging;
- display capture/cropping and multi-monitor viewport mapping;
- product framing around simple desktop control;
- protocol/firmware/brightness utility surfaces;
- virtual display lifecycle, mirroring, ScreenCaptureKit, IMU service, and
  head-orientation-to-viewport mapping.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 121 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- small and README-only utilities are labelled honestly;
- private API and platform caveats remain explicit;
- found projects are not built, launched, or installed;
- `.research-sources/` remains local-only;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in local cache;
3. a Wave 121 synthesis document exists with code-level findings;
4. registry and families represent XR-glasses micro-utilities clearly;
5. methods capture WebHID probing, virtual-display lifecycle, and
   IMU-to-viewport mapping;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
