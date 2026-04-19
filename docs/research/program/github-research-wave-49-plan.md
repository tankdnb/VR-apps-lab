# GitHub Research Wave 49 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `OSCQuery companion frameworks`, `AI and automation bridges`, and
  `avatar-parameter smoothing or refinement layers`.

## Why this wave exists

`VR-apps-lab` already had strong notes on routers and narrow OSC bridges, but a
broader `avatar-facing desktop bus` branch still needed clarification:

- typed desktop companions that expose diagnostics, services, and discovery;
- reusable `OSCQuery` frameworks and examples instead of one-off discovery
  logic;
- relay patterns that let automation or AI tools reach VRChat `OSC` safely;
- editor-side smoothing and refinement layers for noisy parameter streams.

This wave exists to make
`OSCQuery companion frameworks, AI bridges, and parameter smoothing`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- VRChat `OSCQuery` libraries, examples, and service frameworks;
- broader avatar-facing companion shells with diagnostics and routing;
- automation or AI bridges that proxy VRChat `OSC` through safer desktop or
  network boundaries;
- Unity-side helpers that smooth, adapt, or refine `OSC`-driven avatar
  parameters.

## Frozen shortlist for code-level study

- `OscToys/OscGoesBrrr`
- `lenoobkinda/VRCOSCUtils`
- `vrchat-community/vrc-oscquery-lib`
- `Krekun/vrchat-mcp-osc`
- `regzo2/OSCmooth`

## Secondary candidates surfaced in the same wave

- `DASPRiD/vrc-osc-manager`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRChat `OSCQuery`, automation bridge, diagnostics companion,
  and smoothing-tool queries;
- compare results against `catalog/project-registry.md`;
- reject repos that only expose one narrow avatar toggle without a clearer
  companion-shell, discovery-framework, bridge, or smoothing lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `desktop and editor frameworks around avatar-facing
  OSC`;
- allow one broader comparison repo if it clarifies the weaker end of the
  family.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where discovery, diagnostics, config, and transport boundaries sit;
- whether the repo is companion-shell-first, framework-first, relay-first, or
  editor-refinement-first;
- how WebSocket, HTTP, `OSC`, `OSCQuery`, or editor code cooperate.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 49 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies
  companion-framework, relay, and smoothing-layer methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `avatar-facing OSC companions` stay distinct from chatbox-only tools and
  biometric or hardware-control bridges;
- the family clearly separates diagnostics companions, `OSCQuery` libraries,
  automation relays, and animator-side smoothing;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 49 synthesis document exists with code-level findings;
4. the registry and families clearly represent companion frameworks,
   automation relays, and smoothing helpers;
5. new companion or automation methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
