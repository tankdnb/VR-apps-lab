# New Session Quickstart

- Date: `2026-04-18`
- Purpose: help a new session, contributor, or assistant recover repository
  intent quickly without needing prior chat history.

## When to use this file

Use this file when:

- opening `VR-apps-lab` in a fresh session
- returning after a long gap
- switching to a new local clone
- trying to understand what should be read before making changes

## Fast orientation

`VR-apps-lab` is not a single product repo.

Treat it as a combination of:

- `research base`
- `pattern library`
- `prototype lab`

The most common mistake is to open `src/` first and assume the repository is
only about the old `Reality Window` prototype.

That prototype still matters, but it is only one branch of the repository.

## Required reading order

Read these in order:

1. `docs/foundation/repository-positioning.md`
2. `docs/foundation/current-operating-context.md`
3. `docs/foundation/platform-foundation.md`
4. `docs/research/README.md`
5. `docs/research/methods/vr-utility-methods-catalog.md`
6. `docs/research/landscape/project-families.md`
7. `docs/research/catalog/project-registry.md`
8. `docs/research/landscape/not-yet-studied-deeply.md`

Then choose the branch of work:

- `research/discovery` if the task is to find new repositories
- `research/landscape` if the task is to synthesize or deepen existing studies
- `research/reuse` if the task is to extract donor patterns
- `src/` or `spikes/` if the task is to extend examples or prototypes

## Standard workflow for a new GitHub research wave

Follow this sequence:

1. Search GitHub by family, not by random keywords only.
2. Deduplicate against `project-registry.md`.
3. Freeze a shortlist for the wave.
4. Download source into local-only cache.
5. Perform a code-level pass.
6. Extract methods, product patterns, and reuse value.
7. Update the registry, families, methods, and backlog.
8. Add one canonical wave document.

This prevents the repository from turning back into a flat pile of links.

## Local-only data model

Some useful research data should stay outside git history:

- `.research-sources/`
- `.tmp/`
- `artifacts/`
- generated Android or .NET build outputs

These support research and experiments, but they are not part of the canonical
public repository history.

## Validation rule

Use the correct validation model for the type of change.

For `documentation / research` changes:

- verify navigation
- verify link consistency
- verify registry/families/methods alignment
- verify that the new material has a correct place in the structure

For `prototype code` changes:

- add the relevant build or smoke-check only if the change actually affects a
  runnable prototype

## If the task is vague

If a new session only receives a vague instruction like:

- "continue the research"
- "find more VR projects"
- "expand the repo"

then the safest next step is:

1. inspect `not-yet-studied-deeply.md`
2. inspect the latest `wave` documents
3. choose one coherent family for the next wave
4. continue using the standard wave process

## If the task is about product direction

If the session is choosing what the repository should build or prioritize next,
start from:

1. `docs/foundation/public-roadmap.md`
2. `docs/research/landscape/project-families.md`
3. `docs/research/methods/vr-utility-methods-catalog.md`

This keeps product direction tied to studied evidence instead of guesswork.
