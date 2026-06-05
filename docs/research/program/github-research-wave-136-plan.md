# GitHub Research Wave 136 Plan

- Date: `2026-06-05`
- Goal: study audience chat overlays, stream-facing browser surfaces, and
  captured-window HUD patterns that can inform VR companion overlays.

## Why this wave exists

Many practical VR overlay tools are not VR-native at first. Stream chat,
browser-source overlays, and transparent desktop windows teach useful lessons
about click-through modes, setup vs overlay states, query-string configuration,
provider fan-in, and glanceable text surfaces that can later be captured into
VR or rebuilt as native overlays.

## Search scope

Primary search directions:

- transparent Twitch/chat overlays;
- multi-provider desktop chat companions;
- static browser-source chat overlays;
- query-configured overlay builders;
- animated emote/event overlays;
- OBS/browser surfaces that could become VR companion panels.

## Frozen shortlist for code-level study

- `baffler/Transparent-Twitch-Chat-Overlay`
- `Enubia/ghost-chat`
- `giambaJ/jChat`
- `BenDMyers/showmy.chat`
- `teklynk/twitch_chat_emotes`

## Execution model

### Step 1: Search and deduplicate

- search by Twitch chat overlay, transparent window, browser source, emote
  overlay, and OBS overlay families;
- deduplicate against prior overlay, notification, stream, and captured-window
  references.

### Step 2: Freeze the shortlist

- include native desktop transparent-window apps and browser-source projects;
- exclude previously studied VR-native overlay shells unless they add new chat
  or audience-surface lessons.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- setup mode vs overlay mode;
- click-through or vanish behavior;
- provider normalization for Twitch, YouTube, Kick, BTTV, FFZ, and 7TV;
- query-string configuration and preview builders;
- message pruning, fade, animation, and emote display models.

### Step 5: Promote findings into repository structure

Update Wave 136 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when chat/audience overlay patterns are documented with
donor/reference value, caveats, family placement, and reusable methods for
future VR companion surfaces.
