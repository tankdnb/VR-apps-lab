# GitHub Research Wave 73 Plan

- Date: `2026-04-20`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on the
  `WayVR ecosystem`, `Linux dashboard extensions`, and
  `IPC-backed overlay surfaces`.

## Why this wave exists

`VR-apps-lab` already had Linux overlay control shells and browser-backed
overlay runtimes in scope, but it still lacked a clearer picture of the
`host ecosystem around WayVR`
where compositor core, protocol crate, dashboard client, and scriptable
extensions are split into distinct repos.

This wave exists to make several donor branches explicit:

- embedded compositor cores that provide VR app surfaces;
- external dashboards that talk to a host over explicit IPC;
- standalone protocol crates for host ecosystems;
- panel and script add-ons that mutate live overlay content.

## Search scope

Primary search directions for this wave:

- WayVR and adjacent Linux overlay host repos;
- dashboard or panel clients for Linux desktop-in-VR shells;
- local-socket IPC crates around overlay hosts;
- script-driven plugins or panel extensions for VR surfaces.

## Frozen shortlist for code-level study

- `oo8dev/wayvr`
- `oo8dev/wayvr-dashboard`
- `oo8dev/wayvr-ipc`
- `noideaman/WayvrWalltaker`

## Secondary candidates surfaced in the same wave

- `devnet82-ship-it/wivrn-stack-control`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for WayVR repos, dashboard extensions, and IPC surfaces;
- compare results against `catalog/project-registry.md`;
- prefer repos that expose host-extension boundaries rather than generic
  desktop utilities.

### Step 2: Freeze the shortlist

- keep the wave centered on `WayVR ecosystem layers`, not all Linux XR shells;
- allow one small script/plugin repo when it shows how the host is extended in
  practice.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- how host core, dashboard, and IPC contracts are split;
- whether local sockets, shell scripts, or panel XML act as extension points;
- whether the repo is strongest as a code donor, an architecture reference, or
  a product-line reference.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 73 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- WayVR ecosystem repos stay distinct from generic overlay hosts;
- protocol crates and dashboards are represented as different layers of the
  same family;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 73 synthesis document exists with code-level findings;
4. the registry and families represent this WayVR ecosystem more clearly;
5. new methods are captured where this wave clarified reusable patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
