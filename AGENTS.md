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
5. `docs/research/current-focus.md`
6. `docs/research/program/new-session-quickstart.md`
7. `docs/research/program/research-operator-quick-reference.md`
8. `docs/research/program/repository-documentation-playbook.md`
9. `docs/research/catalog/project-registry.md`
10. `docs/research/landscape/project-families.md`
11. `docs/research/landscape/not-yet-studied-deeply.md`
12. `docs/research/methods/vr-utility-methods-catalog.md`

When documenting reusable methods and patterns, also use:

- `docs/research/program/project-information-and-reuse-patterns-audit.md`
- `docs/research/templates/project-study-template.md`

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

1. inspect `git status` and start only from a clean or understood workspace
2. recover context from the required docs listed above
3. choose one coherent family or theme
4. search GitHub by family, not by random links
5. deduplicate against `project-registry.md`, `project-families.md`, and
   recent wave documents
6. freeze a bounded shortlist
7. sync shortlisted source code into local-only cache only
8. perform a code-level pass without running, building, or installing the found
   projects
9. extract repository facts, reusable methods, UX/product lessons, caveats, and
   follow-up gaps
10. decide family placement, study status, method catalog action, and whether a
    reuse plan is warranted
11. create or update the wave plan, backlog, and landscape synthesis document
12. update registry, families, not-yet-studied queue, methods catalog, and
    navigation docs when needed
13. run a repository consistency pass
14. clean local-only study cache that is no longer needed
15. commit, push, and verify GitHub reflects the new material

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

Do not run, build, install, or smoke-test found external repositories during
research waves. Read source and documentation only. This repository is a
research base and pattern library, not a CI harness for third-party projects.

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

For any repository that reveals a reusable pattern, also capture the
`Reusable pattern extraction` bridge:

- `pattern candidate`
- `problem solved`
- `reusable core`
- `source evidence`
- `abstraction boundary`
- `what not to copy`
- `method catalog action`

Use `method catalog action` to decide whether the finding should:

- stay as a project-local observation
- update an existing method
- create a new method
- become a reuse-plan candidate

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
- `docs/research/current-focus.md` only when priorities or strongest donor
  clusters materially change
- navigation docs such as `README.md`, `docs/README.md`, or
  `docs/research/README.md` only when the public route changes

If the repo is an especially strong donor, also add or update a file under:

- `docs/research/reuse/`

When a new reusable method is added, keep the existing method shape and add
extra traceability fields only when they improve clarity:

- `source evidence`
- `reusable core`
- `do not copy directly`
- `maturity`

## Validation Rules

This repository is not validated like one shipping application.

For `research` and `documentation` changes, the main quality checks are:

- structure remains coherent
- navigation remains clear
- links are not obviously broken
- registry, families, methods, and backlog stay aligned
- the repo description remains honest about support boundaries
- reusable methods are tied back to source evidence when the pattern is new or
  strategically important
- local-only cache such as `.research-sources/` and `.tmp/` is cleaned when no
  longer needed

For `prototype code` changes, add build or smoke checks only if the changed
component is actually runnable and affected by the change.

## What Not to Do

Do not:

- dump random GitHub links without synthesis
- duplicate already tracked repositories
- treat forks as new work unless they add something meaningful
- store downloaded source repos in tracked git history
- leave local study cache around after the research is complete
- run, build, or install third-party repositories found for study
- leave a new wave without updating registry and families
- describe projects only superficially when they are strategically important
- promote a project note into a method without reusable-core and
  source-evidence reasoning
- assume passthrough is still the main product objective of the whole repo

## Expected End State of a Good Wave

At the end of a good wave, the repository should contain:

- a coherent wave theme
- a studied shortlist of new repositories
- extracted methods and product lessons
- reusable pattern extraction with source evidence where new methods emerged
- updated overlap families
- updated registry entries
- backlog updates
- clear next gaps for deeper study
- cleaned local-only study cache

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
2. `docs/research/current-focus.md`
3. `docs/research/program/new-session-quickstart.md`
4. `docs/research/program/research-operator-quick-reference.md`
5. `docs/research/landscape/project-families.md`
6. `docs/research/catalog/project-registry.md`
7. latest wave documents

That should be enough to resume useful work without relying on private chat
history.
