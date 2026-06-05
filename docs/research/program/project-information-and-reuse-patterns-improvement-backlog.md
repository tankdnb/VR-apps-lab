# Project Information and Reuse Pattern Documentation Improvement Backlog

- Date: `2026-06-05`
- Scope: small documentation-system improvements that make project studies more
  useful for reuse without rewriting the accumulated research archive.

## Status legend

- `Done`
- `Next`

## Work package A: Audit and decision

- `Done` Review the documentation playbook, study template, quick reference,
  methods catalog shape, and recent wave examples
- `Done` Identify that the strongest gap is traceability from project notes to
  reusable methods and patterns
- `Done` Decide not to mass-migrate old wave documents

## Work package B: Future-facing template improvements

- `Done` Add explicit `Reusable pattern extraction` fields to the project study
  template
- `Done` Make method catalog action explicit: `none`, `update existing method`,
  `add new method`, or `reuse plan candidate`
- `Done` Add short prompts for source evidence, abstraction boundary, and what
  not to copy

## Work package C: Playbook and operator guidance

- `Done` Add a method traceability convention to the repository documentation
  playbook
- `Done` Add reusable-core and source-evidence checks to the quick reference
- `Done` Clarify that old method entries do not need to be rewritten

## Work package D: Future optional cleanup

- `Next` When a future wave touches an older family, add method IDs to that
  wave's `Reusable methods clarified` section if the mapping is obvious
- `Next` When adding new methods, include `Source evidence`, `Reusable core`,
  `Do not copy directly`, and `Maturity` only when they add signal
- `Next` If a family becomes active prototype scope, create focused reuse plans
  for the strongest donor repos instead of broad archive rewrites
- `Next` Consider a lightweight methods index by theme only if the methods
  catalog becomes hard to browse again

## Non-goals

- `Next` Do not rewrite all previous waves just to fit the new template
- `Next` Do not add fake method entries for observations that are only
  project-specific
- `Next` Do not turn `project-registry.md` into a method or evidence index
- `Next` Do not create reuse plans for every interesting repository
