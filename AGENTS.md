# AGENTS.md

This repository is not one standalone VR application.

`VR-apps-lab` is a public:

- `knowledge repository`
- `pattern library`
- `working lab`

for VR utilities, overlays, diagnostics, tracking helpers, runtime tools, and
experimental XR integrations.

If you work in this repo, your job is not just to "find more repos".
Your job is to extract reusable engineering knowledge from VR-related projects
and integrate it into the repository in a structured way.

## Start Here First

Before doing research or making structural changes, read:

1. `README.md`
2. `docs/foundation/repository-positioning.md`
3. `docs/foundation/current-operating-context.md`
4. `docs/foundation/platform-foundation.md`
5. `docs/research/program/new-session-quickstart.md`
6. `docs/research/catalog/project-registry.md`
7. `docs/research/landscape/project-families.md`
8. `docs/research/landscape/not-yet-studied-deeply.md`
9. `docs/research/methods/vr-utility-methods-catalog.md`

## Core Working Principle

Treat this repository as a system with three layers:

1. `Foundation`
   Positioning, roadmap, repository rules, and current operating assumptions.
2. `Research system`
   Discovery, intake, catalog, methods, overlap families, waves, and reuse
   plans.
3. `Prototype code and experiments`
   Runnable examples, spikes, helper scripts, and reusable technical samples.

Do not reduce the repo to `src/` only.

## Main Research Goal

The goal is not to collect the largest possible list of VR repositories.

The goal is to make `VR-apps-lab` a strong public base of:

- studied VR utility projects
- reusable implementation methods
- product patterns
- architecture references
- donor-worthy code ideas
- backlog-ready future directions

## How to Find New Repositories

Search by `families`, not by random links only.

Main family types:

- OpenXR runtime and layer tools
- OpenVR and SteamVR overlays
- desktop-in-VR tools
- notification and remote-control overlays
- accessibility overlays
- battery and device monitors
- Lighthouse managers
- tracker bridges
- OSC bridges
- WebSocket bridges
- driver tutorials and custom-device plumbing
- vendor enhancement layers
- calibration tools
- validation tools
- virtual displays
- headsetless workflows
- mirror and capture helpers
- passthrough and camera utilities

## How to Run a New Research Wave

Every serious research pass should be treated as a `wave`.

Use this order:

1. search GitHub by family
2. deduplicate against `project-registry.md`
3. freeze a shortlist
4. sync source code into local-only cache
5. perform a code-level pass
6. extract methods, features, product lessons, and caveats
7. update registry, families, methods, and backlog
8. create the wave documents
9. run a repository consistency pass
10. commit and push

Do not skip the dedupe step.

## Local Source Code Cache Rule

Download shortlisted repositories only into local-only cache directories such
as:

- `.research-sources/`
- `.tmp/`

These are useful for code study, but they must not become part of public git
history.

## How to Study a Repository

Do not stop at the README.

Inspect:

- repository structure
- entry points
- important modules
- runtime integration model
- overlay/session/input flow
- settings/configuration flow
- IPC/network/OSC/WebSocket design
- abstraction boundaries
- diagnostics/debug tooling
- deployment pattern
- UX and product framing

## Mandatory Extraction Fields

For each new repository, extract at least:

- `interesting idea`
- `code donor value`
- `product reference value`
- `what to inspect next`

When useful, also capture:

- architecture pattern
- reusable method
- UX pattern
- constraints and caveats
- why it matters for `VR-apps-lab`

## What Counts as a Valuable Finding

A repository is valuable if it contributes at least one of these:

- a reusable implementation method
- a strong utility UX pattern
- a runtime/service split worth reusing
- a diagnostic or validation approach
- a bridge pattern for trackers, controllers, or external tools
- a configuration or persistence model
- a deployable micro-utility idea
- a concrete product branch for future VR tools

## Family Placement Rule

No repository should be added as an isolated note only.

Every studied project must be placed into a logical family.

Ask:

- what family does it belong to?
- what similar tools already exist in the repo?
- is it a fork, a variant, or a genuinely new direction?
- does it strengthen an existing family or justify creating a new one?

## Required Repository Updates After a Study

After a serious study pass, update the appropriate combination of:

- `docs/research/catalog/project-registry.md`
- `docs/research/landscape/project-families.md`
- `docs/research/landscape/not-yet-studied-deeply.md`
- `docs/research/methods/vr-utility-methods-catalog.md`
- the relevant wave document in `docs/research/landscape/`
- the relevant wave plan/backlog in `docs/research/program/`
- navigation docs such as `README.md`, `docs/README.md`, or `docs/research/README.md`

If the repo is an especially strong donor, also add or update a file under:

- `docs/research/reuse/`

## Validation Rules

This repository is not validated like one shipping application.

For `research` and `documentation` changes, the main quality checks are:

- structure remains coherent
- navigation remains clear
- links are not obviously broken
- registry, families, methods, and backlog stay aligned
- the repo description remains honest about support boundaries

For `prototype code` changes, add build or smoke checks only if the changed
component is actually runnable and affected by the change.

## What Not to Do

Do not:

- dump random GitHub links without synthesis
- duplicate already tracked repositories
- treat forks as new work unless they add something meaningful
- store downloaded source repos in tracked git history
- leave a new wave without updating registry and families
- describe projects only superficially when they are strategically important
- assume passthrough is still the main product objective of the whole repo

## Expected End State of a Good Wave

At the end of a good wave, the repository should contain:

- a coherent wave theme
- a studied shortlist of new repositories
- extracted methods and product lessons
- updated overlap families
- updated registry entries
- backlog updates
- clear next gaps for deeper study

## Git Completion Rule

When the research pass is complete:

1. inspect `git status`
2. stage the intended changes
3. commit with a clear wave or scope-based message
4. push to GitHub
5. verify the public repo reflects the new material

## Fastest Recovery Path for a Fresh Session

If context is missing, the fastest recovery path is:

1. `docs/foundation/current-operating-context.md`
2. `docs/research/program/new-session-quickstart.md`
3. `docs/research/landscape/project-families.md`
4. `docs/research/catalog/project-registry.md`
5. latest wave documents

That should be enough to resume useful work without relying on private chat
history.
