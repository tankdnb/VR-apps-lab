# GitHub Research Wave 48 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `mobile chatbox relays`, `translation and transcription shells`, and
  `avatar text-surface installers`.

## Why this wave exists

`VR-apps-lab` already had strong notes on chatbox composition and textbox
micro-utilities, but the broader `social text workflow` branch was still
missing several important donor shapes:

- mobile-first chatbox entry surfaces that work as a relay instead of a desktop
  textbox;
- translation and transcription shells that span desktop UI, overlay output,
  `OSC`, and local model management;
- avatar text-surface installers that automate parameter, animator, and menu
  setup;
- ultra-thin chatbox utilities that show the minimum useful product shape.

This wave exists to make
`mobile chatbox relays, translation shells, and avatar text surfaces`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- VRChat chatbox relays on mobile or handheld devices;
- VRChat translation, transcription, and overlay-assisted speech shells;
- avatar text-surface installers and prefab-like parameter-grid workflows;
- minimal desktop chatbox senders that clarify rate-limited text output.

## Frozen shortlist for code-level study

- `BoiHanny/vrcosc-magicchatbox`
- `ScrapW/Chatbox`
- `misyaguziya/VRCT`
- `killfrenzy96/KillFrenzyAvatarText`
- `dbqt/VRCOSCChatbox`

## Secondary candidates surfaced in the same wave

- `MaurerKrisztian/vrc-tts-osc`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRChat chatbox, translation, mobile relay, and avatar-text
  installers;
- compare results against `catalog/project-registry.md`;
- reject repos that only duplicate one already-studied textbox or STT path
  without a clearer mobile, translation, avatar-installer, or rate-limiting
  lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `text workflows that are not only desktop textbox
  utilities`;
- allow one revisited repo if it helps compare the broader family against the
  newer donors.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how text is composed, buffered, rate-limited, or paged;
- whether the repo is relay-first, transcription-shell-first, avatar-installer-
  first, or micro-utility-first;
- where overlay, `OSCQuery`, translation, or avatar-setup boundaries sit.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 48 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies
  chatbox-relay, avatar-text, and translation-shell methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `text workflow` donors stay distinct from captions, generic social overlays,
  and broader OSC automation utilities;
- the family clearly separates mobile relays, translation shells, avatar text
  surfaces, and thin chatbox micro-tools;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 48 synthesis document exists with code-level findings;
4. the registry and families clearly represent mobile relays, translation
   shells, and avatar text-surface installers;
5. new text-workflow methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
