# New Chat Prompt Block

- Purpose: short ready-to-paste prompt for starting a fresh chat that should
  continue research work in `VR-apps-lab`.

## Short Version

Copy and paste this into a new chat:

```text
You are working in VR-apps-lab, which is not one standalone app but a public knowledge repository, pattern library, and working lab for VR utilities, overlays, diagnostics, tracker bridges, runtime tools, and experimental XR integrations.

Before doing work, recover context from:
- docs/foundation/current-operating-context.md
- docs/research/program/new-session-quickstart.md
- docs/research/catalog/project-registry.md
- docs/research/landscape/project-families.md
- docs/research/landscape/not-yet-studied-deeply.md
- docs/research/methods/vr-utility-methods-catalog.md

If the task is a new research wave:
1. search GitHub by family
2. deduplicate against the registry
3. freeze a shortlist
4. clone shortlisted repos into local-only cache
5. do a code-level pass
6. extract interesting idea, code donor value, product reference value, and what to inspect next
7. update registry, families, methods, backlog, and wave docs
8. run a consistency pass
9. commit and push

Do not treat the repo as only src/. Do not dump random links. Focus on reusable methods, interesting engineering solutions, product patterns, and donor-worthy implementation ideas for future VR tools.
```

## Strict Version

Use this if you want the new chat to behave more rigidly:

```text
You are continuing work in VR-apps-lab.

Important: VR-apps-lab is a research base and working lab for VR utilities, not a single end-user application.

First recover context from:
- docs/foundation/repository-positioning.md
- docs/foundation/current-operating-context.md
- docs/foundation/platform-foundation.md
- docs/research/program/new-session-quickstart.md
- docs/research/catalog/project-registry.md
- docs/research/landscape/project-families.md
- docs/research/landscape/not-yet-studied-deeply.md
- docs/research/methods/vr-utility-methods-catalog.md

If doing GitHub research, follow the established wave process:
- search by family
- deduplicate against registry
- freeze shortlist
- sync local-only source cache
- study code, not just README
- extract reusable methods and product lessons
- place every repo into a logical family
- update registry, methods, families, backlog, and wave docs
- verify structure and navigation consistency
- commit and push

For each studied repo, always capture:
- interesting idea
- code donor value
- product reference value
- what to inspect next

Do not:
- add random repos without synthesis
- duplicate already tracked repos
- treat forks as fully new work unless they add meaningful differences
- store downloaded source repos in tracked git history
- assume passthrough is still the main objective of the whole repository

Prioritize interesting implementation techniques, reusable architecture, micro-utility patterns, overlay UX ideas, runtime diagnostics, bridges, accessibility, tracking/device tooling, and other solutions that help build future VR tools.
```

## When To Use

Use this file when:

- starting a fresh assistant session
- switching to a new local clone
- reopening the repo after a long gap
- beginning a new GitHub research wave

## Companion Files

For deeper recovery, pair this with:

- `AGENTS.md`
- `docs/foundation/current-operating-context.md`
- `docs/research/program/new-session-quickstart.md`
- `docs/research/program/research-operator-quick-reference.md`
