# GitHub Research Wave 126 Plan

- Date: `2026-06-05`
- Goal: study immersive browser shells, WebXR runtime projects, and spatial
  home/front-end references for reusable shell architecture.

## Why this wave exists

Immersive browsers are large, but their architecture is useful for smaller VR
tools: windows, sessions, widgets, keyboard, navigation, permissions,
interstitials, environments, and WebXR session/input boundaries.

## Search scope

Primary search directions:

- standalone headset browsers;
- Firefox Reality and Wolvic lineage;
- PC VR browser shells;
- Exokit/WebXR runtime projects;
- spatial home/startpage scenes.

## Frozen shortlist for code-level study

- `Igalia/wolvic`
- `MozillaReality/FirefoxReality`
- `MozillaReality/FirefoxRealityPC`
- `exokitxr/exokit`
- `exokitxr/exokit-browser`
- `exokitxr/exokit-frontend`
- `madjin/home-space`

## Execution model

### Step 1: Search and deduplicate

- search by immersive browser, WebXR browser, Exokit, Firefox Reality, Wolvic,
  and spatial home families;
- deduplicate against WebXR samples, A-Frame, spatial desktop, and overlay
  families.

### Step 2: Freeze the shortlist

- include current, historical, PC shell, runtime shim, frontend, and home-space
  representatives.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep local study sources untracked.

### Step 4: Perform the code-level pass

Inspect:

- session/window/widget architecture;
- native render world and placement logic;
- WebXR interstitials and permission surfaces;
- engine/runtime/session input modeling;
- spatial home or frontend composition.

### Step 5: Promote findings into repository structure

Update Wave 126 landscape, registry, families, methods, backlog, and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- large browser projects are framed as architecture references.

## Definition of done

This wave is complete when browser-shell and WebXR runtime boundary lessons are
documented and placed in the canonical research system.
