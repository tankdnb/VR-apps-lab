# Current Operating Context

- Date: `2026-04-18`
- Purpose: capture the working context that used to live only in chat history,
  so a new session can understand what `VR-apps-lab` is, what it is not, and
  how to continue work safely.

## What this repository is now

`VR-apps-lab` is no longer one standalone VR application.

It is a public:

- `knowledge repository`
- `pattern library`
- `working lab`

for VR utilities, overlays, diagnostics, tracking helpers, runtime tools, and
experimental XR integrations.

## What changed over time

The repo started from a concrete passthrough idea:

- a `Reality Window` overlay in VR
- showing part of the real world through a headset camera
- originally targeted at `SteamVR/OpenVR`
- then investigated further for `PICO/OpenXR`

That work was valuable, but it also produced a hard product lesson:

- `Pico Connect` passthrough did not become a reliable production path for the
  original idea
- vendor passthrough support is inconsistent
- runtime-level access to headset cameras is often blocked or constrained

Because of that, the repository evolved into a broader lab for reusable VR
tooling knowledge instead of staying locked to one product hypothesis.

## What remains valuable from the original project

The original work still matters and should stay in the repo as reusable
engineering knowledge:

- `OpenVR` overlay prototype code in `src/`
- camera/provider abstractions
- frame processing pipeline experiments
- `doctor / probe / overlay` desktop app structure
- `PICO/OpenXR` spike app under `spikes/`
- feasibility documents and dead-end analysis

These are not failures to hide. They are part of the reference base.

## Current repository operating model

The repo now has three equally important layers:

1. `Foundation`
   Stable positioning, roadmap, repository rules, and high-level architecture.
2. `Research system`
   Discovery, intake, catalog, overlap families, methods, waves, and reuse
   plans.
3. `Prototype code and experiments`
   Runnable samples, spikes, and example code that future tools can reuse.

## Current naming and path assumptions

- Canonical project name: `VR-apps-lab`
- Canonical GitHub repository:
  [tankdnb/VR-apps-lab](https://github.com/tankdnb/VR-apps-lab)
- Preferred local path:
  `C:\Users\Username\Documents\VR-apps-lab`

There may still be an older local workspace at:

- `C:\Users\Username\Documents\VR.app`

That old path may exist only as a temporary workspace shell or backup. It is
not the preferred long-term location anymore.

## What a new session should assume

A new session should assume:

- the repo is primarily a `research and reusable-solutions base`
- documentation integrity matters more than product build checks for docs-only
  changes
- new GitHub research should follow the established `wave` process
- every newly studied repository must be integrated into:
  - `catalog/project-registry.md`
  - `landscape/project-families.md`
  - `methods/vr-utility-methods-catalog.md`
  - the relevant `wave` document
  - backlog or watchlist if follow-up work remains

## What a new session should not assume

Do not assume:

- there is one single end-user app to finish
- passthrough is still the main product objective
- every change should be validated with a build
- `src/` alone explains the repo

That would misunderstand the current identity of the project.

## Primary current directions

The strongest repository directions right now are:

- VR utility overlays
- wrist dashboards and micro-utilities
- runtime/layer diagnostics
- tracking bridges and device tooling
- accessibility overlays
- repository research and reusable implementation methods

## Recommended continuation rule

If a future session is unsure how to proceed, it should start with:

1. `docs/foundation/repository-positioning.md`
2. `docs/foundation/platform-foundation.md`
3. `docs/research/program/new-session-quickstart.md`

That is the minimum path to recover project intent without relying on private
chat history.
