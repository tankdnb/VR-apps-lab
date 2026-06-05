# GitHub Research Wave 130 Plan

- Date: `2026-06-05`
- Goal: study Resonite/Neos modding, manifest, mod manager, external SDK,
  headless deployment, companion client, and metrics tooling.

## Why this wave exists

Resonite/Neos tooling is a useful social VR ecosystem case study. It contains
loader lifecycle, manifests, GUI managers, external data-model SDKs, headless
deployment, companion apps, and in-world diagnostics.

## Search scope

Primary search directions:

- Resonite and Neos mod loaders;
- mod manifests and GUI mod managers;
- external SDKs, WebSocket control, and REPL tools;
- headless deployment;
- social companion apps;
- metrics and creator diagnostics.

## Frozen shortlist for code-level study

- `resonite-modding-group/ResoniteModLoader`
- `Gawdl3y/Resolute`
- `resonite-modding-group/resonite-mod-manifest`
- `Yellow-Dog-Man/ResoniteLink`
- `shadowpanther/resonite-headless`
- `Nutcake/ReCon`
- `esnya/ResoniteMetricsCounter`

## Execution model

### Step 1: Search and deduplicate

- search by Resonite/Neos modding, headless, SDK, companion, and metrics
  families;
- deduplicate against VRChat creator, companion, diagnostics, audio, and media
  waves.

### Step 2: Freeze the shortlist

- include loader, manifest, manager, external SDK, headless, companion, and
  metrics representatives.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- mod loader lifecycle and config;
- manifest schema and artifact metadata;
- manager install/update/delete state;
- external WebSocket/REPL SDK;
- headless deployment packaging;
- companion API and live-event client;
- metrics collection and in-world UI.

### Step 5: Promote findings into repository structure

Update Wave 130 landscape, registry, families, methods, backlog, current
focus, and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after integration.

## Definition of done

This wave is complete when Resonite/Neos ecosystem tooling patterns are
documented and placed in the canonical research system.
