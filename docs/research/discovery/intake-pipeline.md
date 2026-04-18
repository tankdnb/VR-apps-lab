# Intake Pipeline

- Date: `2026-04-18`
- Goal: define how a newly discovered repository should be processed and added
  to `VR.app`.

## Step 1: Candidate intake

When a new repo is found, record:

- name
- URL
- likely family
- one-line reason it matters

## Step 2: Quick triage

Ask:

1. Is it a utility, tool, helper app, overlay, API layer, driver, or workflow
   tool?
2. Does it overlap with an existing family?
3. Is it likely a:
   - `code donor`
   - `architecture reference`
   - `product reference`
   - `research only`

## Step 3: Registry placement

Add or update the repo in:

- `../catalog/project-registry.md`

and give it an honest status:

- `Already studied`
- `Partially studied`
- `Not studied deeply`
- `Fork / variant only`

## Step 4: Family update

If the repo changes the overlap model, update:

- `../landscape/project-families.md`

## Step 5: Deep-study queue update

If the repo deserves follow-up, update:

- `../landscape/not-yet-studied-deeply.md`

## Step 6: Method extraction

If the repo demonstrates a method not yet represented clearly, update:

- `../methods/vr-utility-methods-catalog.md`

## Step 7: Deep pass

Use:

- `../templates/project-study-template.md`
- `../program/study-method.md`

Deep passes should inspect:

- README and public docs
- top-level tree
- app/driver/plugin/service boundaries
- settings/config model
- runtime assumptions
- reusable UX or architecture patterns

## Step 8: Link into the right research layer

Decide where the result belongs:

- `landscape/` for family or wave synthesis
- `reuse/` for donor-focused extraction
- `catalog/` for canonical tracking
- `methods/` for extracted approaches

## Step 9: Product impact note

Always answer:

- does this repo unlock or strengthen a possible `VR.app` module?

If yes, note the likely product category:

- overlay
- dashboard
- tracker bridge
- diagnostics
- accessibility
- device manager
- creator tool
- API layer

## Done condition

A repository is "properly added" only when it is:

1. in the registry;
2. in the right family;
3. reflected in the deep-study queue if needed;
4. connected to at least one reusable method or product direction.
