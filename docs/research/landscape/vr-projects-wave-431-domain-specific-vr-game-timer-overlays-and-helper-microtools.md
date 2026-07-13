# VR Projects Wave 431: Domain-Specific VR Game Timer Overlays and Helper Microtools

Date: 2026-07-13

Theme: narrow game-helper timer tools that translate domain events into overlays,
hotkeys, browser panels, and VR-friendly visual timing references.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `84z0r/PhasmoTimer` | External game-helper overlay | Code-level pass |
| `SteveMarkhamGIT/PhasmoTimer` | SteamVR/OpenVR timer surface generator | Code-level pass |
| `DrBrad/phastimer` | Browser/OBS timer helper | Code-level pass |

## Cross-Project Synthesis

These projects are intentionally narrow. They are not generic overlay platforms;
they encode Phasmophobia-specific events such as smudge, hunt, candle, stamina,
Obake/Mimic-like phases, and ghost speed helpers. That makes them valuable for a
different reason: they show how a tiny VR-adjacent helper can be useful without
reading game memory or becoming a full mod.

The reusable lesson is a `domain timer overlay`: maintain explicit timing models,
let the user trigger state changes through focus-aware hotkeys or simple UI, and
separate the domain data from the rendering shell so freshness can be audited.

## Project Notes

### `84z0r/PhasmoTimer`

- Interesting idea: a lightweight external overlay with timers and bars for a
  specific VR-played game, while explicitly avoiding game-memory reads.
- Code donor value: JSON configuration, foreground-window gating, global hotkey
  mapping, timer defaults, UI colors/sizes, and process-name targeting.
- Product reference value: strong reference for "one game, one useful helper"
  overlays that can remain outside the game process.
- Architecture pattern: external overlay utility with configurable hotkeys,
  timer state, and optional active-window checks.
- Reusable method: `domain-specific timer overlay without memory reading`.
- UX/product lesson: user trust improves when the overlay states that it does not
  read memory and when all timers are manually controlled.
- Caveats: domain constants age with game patches, global hotkeys need focus
  ownership, and the tool is game-specific by design.
- Source evidence: `src/config.h` defines active-window checks, feature toggles,
  hotkey defaults, timing constants, UI colors, and `Phasmophobia.exe`;
  `src/config.cpp` reads/writes JSON configuration and validates key binds.
- Reusable core: no-memory policy, process/focus gate, feature toggles, hotkey
  routing, JSON config, timer reset modes.
- What not to copy: hard-coded game constants without freshness notes or global
  hotkeys that fire outside the intended context.
- Method catalog action: add/update domain-helper timer overlay method.
- What to inspect next: whether the overlay shell is ImGui/Win32-based and how it
  handles DPI/multi-monitor placement.

### `SteveMarkhamGIT/PhasmoTimer`

- Interesting idea: a resource-driven timer host that renders a smudge/ghost-speed
  surface from bitmap layers and custom digit fonts.
- Code donor value: `SmudgeTimerHost`, bitmap layer composition, per-digit font
  loader, pointer hover/touch thresholds, and domain-specific speed/timer math.
- Product reference value: useful for VR overlay surfaces where the visible panel
  can be rendered as a texture rather than a full retained UI tree.
- Architecture pattern: C# timer/image generator plus resource folders for images,
  highlights, and digit glyphs.
- Reusable method: `bitmap-rendered timer panel for VR overlay textures`.
- UX/product lesson: a timer overlay can be built as a deterministic image buffer,
  making it portable to OpenVR texture surfaces or streaming panels.
- Caveats: sparse README, resource-heavy implementation, and unclear OpenVR host
  integration from the inspected files.
- Source evidence: `SmudgeTimerHost.cs` loads images, hover/pressed overlays,
  digit glyphs, pointer state, speed settings, and draws timer output into an
  `Image<Rgba32>` buffer.
- Reusable core: resource-backed layers, bitmap font map, pointer hit mask,
  hover/press states, timer-to-text renderer, output image buffer.
- What not to copy: domain imagery/resources and hard-coded timer math without
  separating game rules from render shell.
- Method catalog action: update domain-helper timer overlay method.
- What to inspect next: locate the OpenVR overlay uploader path or pair this with
  prior OpenVR texture-surface donors.

### `DrBrad/phastimer`

- Interesting idea: a browser/OBS-friendly timer helper that encodes smudge,
  Obambo, and ghost-speed calculations in a very small web app.
- Code donor value: simple DOM event model, 16 ms update loop, phase timer,
  ghost-speed slider, and speed multiplier calculations.
- Product reference value: good reference for fallback companion panels that can
  run in a browser, OBS, desktop overlay, or webview.
- Architecture pattern: static web timer with domain states and interaction loops.
- Reusable method: `browser companion timer panel`.
- UX/product lesson: a web fallback can make a niche helper usable before building
  a native VR overlay.
- Caveats: no VR integration, hard-coded game logic, and domain freshness risk.
- Source evidence: `scripts/main.js` wires `smudge`, `obombo`, `ms`,
  `ghost-speed`, and `blood-moon` controls; tracks CALM/AGGRO phases; and updates
  timers on a 16 ms interval.
- Reusable core: DOM controls, domain timer state, phase labels, speed slider,
  update loop, OBS/browser portability.
- What not to copy: game-specific constants without update metadata.
- Method catalog action: update domain-helper timer overlay method.
- What to inspect next: compare browser panels with SteamVR overlay webview shells
  and desktop capture overlays.

## Reusable Pattern Extraction

- Pattern candidate: `domain-specific VR game helper timer`.
- Problem solved: VR players often need lightweight timing or state reminders
  without installing a mod, reading memory, or leaving the headset context.
- Reusable core: explicit domain timer model, no-memory policy, focus/process
  gating, hotkeys or simple UI controls, reset modes, visual timer surface, config,
  and data freshness notes.
- Source evidence: `84z0r/PhasmoTimer` supplies config/hotkey/overlay policy,
  `SteveMarkhamGIT/PhasmoTimer` supplies bitmap timer rendering, and `phastimer`
  supplies browser-panel fallback logic.
- Abstraction boundary: overlay shell and timer engine are reusable; game names,
  timings, images, and hotkeys should live in data/config with freshness labels.
- Method catalog action: add/update domain-helper timer overlay method.

## Follow-Up Gaps

- Find non-Phasmophobia VR-adjacent game helpers to compare timer and hotkey UX.
- Study OpenVR texture upload paths for bitmap-rendered timer panels.
- Define a small schema for domain timers: event, duration, reset rule, warning
  threshold, freshness/source, and display mode.
