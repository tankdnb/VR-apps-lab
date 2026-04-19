# Repository Documentation Playbook

- Date: `2026-04-20`
- Purpose: define the canonical way to document a repository inside
  `VR-apps-lab`, including what goes where, what must be updated, and what must
  stay out of each document.

## When to use this file

Use this playbook when:

- adding a newly found repository;
- deepening a repository that is already tracked;
- promoting a repo from `Not studied deeply` to `Partially studied` or
  `Already studied`;
- deciding whether a repo needs a new family, a new method, or a reuse plan;
- checking whether a documentation update is complete before commit.

## Core rule

Do not add repositories as isolated notes.

Every meaningful addition should strengthen the repository as a system:

- `registry`
- `family model`
- `deep-study queue`
- `methods`
- `wave history`
- `reuse guidance` when needed

## The documentation layers

### Foundation

Use `docs/foundation/` for:

- public framing;
- operating assumptions;
- roadmap and direction;
- current repository state.

Do not put per-repository study notes here.

### Research system

Use `docs/research/` for:

- repository tracking;
- family overlap;
- study waves;
- methods and patterns;
- discovery and intake workflow;
- reuse plans for strong donors.

### Root entry docs

Use:

- `README.md`
- `docs/README.md`
- `docs/research/README.md`

only when navigation, public entry points, or the documentation map changes.

Do not update these for every normal repo addition unless the user-facing route
really changed.

## Canonical file roles

| File | Canonical role | Update when | Do not use it for |
|---|---|---|---|
| `docs/research/catalog/project-registry.md` | source of truth for tracked repos and their status | every meaningful repo addition or status change | long family comparisons, method extraction, priority rationale |
| `docs/research/landscape/project-families.md` | overlap model, family synthesis, and product direction | when a repo is placed into a family, when a family gets stronger, or when a new family is justified | owning the primary status truth |
| `docs/research/landscape/not-yet-studied-deeply.md` | active deep-study and follow-up queue | when a repo remains underexplored or should be queued for deeper work | being a second full registry |
| `docs/research/methods/vr-utility-methods-catalog.md` | extracted reusable methods and patterns | when a repo reveals a reusable implementation pattern worth reusing elsewhere | per-repo inventory or generic summaries |
| `docs/research/landscape/vr-projects-wave-*.md` | coherent synthesis of one research wave | every real wave | ad hoc one-repo dumping without theme |
| `docs/research/program/github-research-wave-*-plan.md` | frozen scope and research intent for one wave | every real wave | final synthesis |
| `docs/research/program/github-research-wave-*-backlog.md` | executed checklist and follow-up notes for one wave | every real wave | public-facing summary |
| `docs/research/reuse/*.md` | explicit reuse plan for strong donor repos | only when a repo is strong enough to influence future implementation directly | generic mention of a repo |
| `docs/research/current-focus.md` | short current-state view of active directions | only when priorities, strongest donor clusters, or immediate next steps materially change | full chronology or deep archive |

## Study statuses

Use these statuses consistently.

### `Not studied deeply`

Use when:

- the repo is known and relevant;
- family placement is clear enough to track it;
- but the code-level pass is still weak or absent.

### `Partially studied`

Use when:

- there has already been a meaningful code or structure pass;
- some useful extraction exists;
- but key modules, boundaries, or donor value still need a stronger pass.

### `Already studied`

Use when:

- the repo has received a real code-level pass;
- its role in the family is clear;
- the extraction is strong enough for future reference;
- and no urgent follow-up is required before it can be cited as a real donor or
  reference.

### `Fork / variant only`

Use when:

- the repo is mainly valuable as comparison against an upstream or stronger
  sibling;
- it does not justify a full standalone line of attention yet;
- or its differences are too thin to treat it like a separate mainline donor.

## Minimum fields for a meaningful repository addition

Whenever a repository is studied beyond a trivial mention, capture at least:

- `interesting idea`
- `code donor value`
- `product reference value`
- `what to inspect next`

When the material supports it, also capture:

- architecture pattern
- reusable method
- interesting UX behavior
- constraints or caveats
- why it matters for `VR-apps-lab`

## What to update in each common scenario

### Scenario A: new repo, only lightly understood

Update:

- `project-registry.md`
- `project-families.md`
- `not-yet-studied-deeply.md` if it deserves future follow-up

Do not add:

- a new method unless a reusable pattern is already visible;
- a reuse plan;
- a fake deep-pass wave note if the study is too thin.

### Scenario B: new repo added through a real research wave

Update:

- wave plan
- wave backlog
- wave landscape document
- `project-registry.md`
- `project-families.md`
- `not-yet-studied-deeply.md` when some repos stay underexplored
- `vr-utility-methods-catalog.md` when reusable methods emerge

Update additionally if needed:

- `current-focus.md`
- root or docs indexes only when the navigation picture materially changes

### Scenario C: deepen an existing tracked repo

Update:

- existing status in `project-registry.md`
- family note in `project-families.md`
- `not-yet-studied-deeply.md` if the repo leaves or changes position in the
  queue
- methods catalog if the deeper pass revealed a real reusable pattern
- a new wave doc only if the deepening happened as part of a coherent new wave

### Scenario D: repo proves to be a strong direct donor

Update:

- normal canonical files as above
- one focused file in `docs/research/reuse/`

Do this only when the repo is strong enough to shape future implementation, not
just because it is interesting.

### Scenario E: repo is mainly a fork or variant

Update:

- `project-registry.md`
- `project-families.md`

Update `not-yet-studied-deeply.md` only if the fork genuinely deserves a later
comparison pass.

## Step-by-step: adding a new repository correctly

### Step 1: deduplicate

Before writing anything, check:

- `project-registry.md`
- `project-families.md`
- relevant recent wave docs

Decide whether the repo is:

- new;
- already tracked but under another family note;
- a fork/variant;
- or only a thin duplicate of something stronger.

### Step 2: choose the family first

Do not add a repo before answering:

- what family does it belong to now?
- is the current family good enough?
- does this repo justify expanding an existing family note?
- does it reveal a genuinely new family direction?

### Step 3: decide study depth

Choose the honest current depth:

- mention only;
- light registry/family placement;
- deep pass within a wave;
- donor extraction;
- reuse-plan-worthy donor.

### Step 4: inspect code, not only README

Look at:

- repository structure;
- entry points;
- module boundaries;
- runtime, overlay, service, driver, or layer flow;
- configuration model;
- IPC, OSC, WebSocket, BLE, or file contracts;
- debug or diagnostics surfaces;
- UX and product framing.

### Step 5: write the canonical updates

Start with the canonical documents in this order:

1. `project-registry.md`
2. `project-families.md`
3. `not-yet-studied-deeply.md` if needed
4. `vr-utility-methods-catalog.md` if needed
5. wave docs if this belongs to an actual wave
6. reuse plan if warranted
7. navigation docs only if the public route changed

## How to decide whether to add a method

Add a method only when the repo teaches a reusable pattern that can be applied
outside that one repo.

A pattern is method-worthy when it clarifies one of these:

- overlay host structure;
- runtime/layer registration flow;
- service-companion split;
- tracker/controller bridge pattern;
- settings or persistence model;
- remote-control or IPC contract;
- diagnostics or validation workflow;
- calibration or synthetic-device pattern;
- focused micro-utility architecture.

Do not add a method for:

- generic project summaries;
- one-off implementation trivia;
- naming differences without reusable architectural meaning.

## How to decide whether to add a reuse plan

Add a file under `docs/research/reuse/` only if the repository is strong enough
to directly influence future implementation inside `VR-apps-lab`.

Good signs:

- clear donor modules or patterns;
- strong product framing worth reusing;
- clear implementation slices that could be translated into future repo work;
- enough code-level confidence to talk about reuse intentionally.

## What should not be duplicated

Avoid these common mistakes:

- do not let `project-families.md` become a second primary status registry;
- do not let `not-yet-studied-deeply.md` become a second full catalog;
- do not add the same repo to multiple places with conflicting status wording;
- do not create a new wave just to hold one weak repo note;
- do not update entry docs for every trivial addition.

## Naming and placement conventions

Use these conventions:

- wave plan:
  `docs/research/program/github-research-wave-XX-plan.md`
- wave backlog:
  `docs/research/program/github-research-wave-XX-backlog.md`
- wave synthesis:
  `docs/research/landscape/vr-projects-wave-XX-*.md`
- reuse plan:
  `docs/research/reuse/*-reuse-plan.md`

Prefer names that explain the family theme, not just the date.

## Final consistency check before commit

Before committing a repo addition or deepening pass, verify:

1. the repo is placed in the right family;
2. the status in `project-registry.md` is honest;
3. `project-families.md` reflects the right overlap and not a contradictory
   status truth;
4. `not-yet-studied-deeply.md` was updated if follow-up is still needed;
5. `methods` changed only if a real reusable pattern emerged;
6. wave docs exist if this was a real wave;
7. navigation docs changed only if the information architecture changed;
8. no local-only source cache paths were turned into public broken links;
9. local-only cache such as `.research-sources/` and `.tmp/` is cleaned when no
   longer needed.

## Short reference checklist

When adding or deepening a repo, ask:

1. `Is it already tracked?`
2. `What family owns it?`
3. `What is the honest study status now?`
4. `Does it belong in a real wave or only in canonical tracking docs?`
5. `Did it reveal a reusable method?`
6. `Does it deserve a reuse plan?`
7. `Which canonical files must change before commit?`

## Related documents

Use this playbook together with:

- `new-session-quickstart.md`
- `research-operator-quick-reference.md`
- `study-method.md`
- `../templates/project-study-template.md`
- `../current-focus.md`
