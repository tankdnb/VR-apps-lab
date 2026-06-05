# Project Information and Reuse Pattern Documentation Audit

- Date: `2026-06-05`
- Purpose: evaluate how convenient and informative the repository's project
  documentation is, with special attention to reusable methods and patterns.
- Scope: documentation workflow only. This audit intentionally avoids rewriting
  the existing wave archive.

## Summary

The current system is strong at answering:

- which repositories are known;
- what family they belong to;
- whether they are lightly or deeply studied;
- what each wave found;
- which reusable methods have already been extracted.

The weaker part is traceability from a specific repository to a reusable
method. A future reader can usually find the project note and the method note,
but often has to infer the bridge between them:

- what exact source files or modules proved the pattern;
- what part is reusable versus project-specific;
- whether the pattern should become a new method, update an existing method, or
  stay only as a project-level observation;
- which future `VR-apps-lab` tool direction the pattern best supports.

The recommended improvement is not a large refactor. The repository should add
a future-facing `reuse extraction` layer to templates and instructions, while
leaving the old archive intact.

## What already works well

- `project-registry.md` is a useful source of truth for per-repository status.
- `project-families.md` gives strong family placement and synthesis.
- `not-yet-studied-deeply.md` keeps follow-up work visible without pretending
  every repo is equally studied.
- Wave documents capture context better than a flat link list.
- The methods catalog answers a valuable second question: not only "what repos
  exist?" but "what ways of building VR utilities have been observed?"
- Recent wave notes already include useful fields such as `interesting idea`,
  `code donor value`, `product reference value`, `caveats`, and `what to
  inspect next`.

## Main friction points

### 1. Reuse extraction is present, but not explicit enough

Project notes often imply reusable patterns inside `Interesting idea` or
`Code-level notes`, then the wave later lists `Reusable methods clarified`.
That works for humans who read the whole wave, but it is less convenient when
someone wants to quickly answer:

- what exact reusable pattern came from this repo?
- is it already in the methods catalog?
- which method number should I cite later?

### 2. Method entries are readable, but not always traceable to evidence

The current method entry shape is good:

- `What it is`
- `Good for`
- `Why it matters`
- `Strong references`
- `Best fit for VR-apps-lab`

However, method entries usually do not record:

- source evidence level;
- concrete source files or modules;
- abstraction boundary;
- what should not be copied;
- whether the method is mature, candidate, or historical.

Adding all of this to every old method would be too disruptive. Future method
entries can adopt a slightly stronger convention without changing old ones.

### 3. Project study template underplays method extraction

The template captures reuse value, but it does not force the author to decide
whether a discovered idea should:

- stay as a project-local note;
- update an existing method;
- create a new method;
- become a reuse plan.

That decision is exactly where future maintainers need the most help.

### 4. Wave documents are strong, but method IDs are optional by habit

Wave documents often list reusable methods by title. That is readable, but less
stable than citing method IDs after the method is added to the catalog.

Future waves should prefer:

- method title while drafting;
- method ID after catalog integration;
- source projects that prove the pattern.

### 5. Reuse plans are intentionally rare, but the threshold should be more visible

The current rule is good: do not create reuse plans for every interesting repo.
The gap is discoverability. A reader should quickly see why a repo stayed as a
method reference instead of becoming a direct reuse plan.

## Non-disruptive improvement strategy

Keep the existing archive as-is. Improve future work through four small
changes:

1. Add a `Reusable pattern extraction` section to the project study template.
2. Add a method traceability convention to the documentation playbook.
3. Add reuse-focused bullets to the one-screen quick reference.
4. Document the improvement backlog so future cleanup can happen gradually,
   family by family, only when touched.

This approach avoids a mass rewrite while improving all new research waves.

## Recommended future project-note shape

For each important repository, future wave notes should continue to capture the
existing fields, then add a short reusable-pattern block when useful:

- `Reusable pattern candidate`
- `Problem solved`
- `Reusable core`
- `Source evidence`
- `Abstraction boundary`
- `What not to copy`
- `Method catalog action`

This block should be short. It is a bridge from project-level observation to
method-level reuse, not a second full method entry.

## Recommended future method-entry additions

Do not rewrite old method entries. For future methods, add these fields only
when they are useful:

- `Source evidence`
- `Reusable core`
- `Do not copy directly`
- `Maturity`

Suggested maturity values:

- `Observed`
- `Validated by multiple repos`
- `Historical`
- `Prototype-ready`

## Definition of a good reuse pattern

A finding is a good reusable pattern when it is:

- portable beyond one repository;
- tied to a real user or developer problem;
- supported by code-level evidence;
- expressible as an implementation boundary or product behavior;
- useful for future `VR-apps-lab` utility, overlay, diagnostic, tracker,
  runtime, media, or MR tool design.

If a finding is only a nice implementation detail, keep it in the project note.
Do not promote it to the methods catalog.

## Quality bar after these improvements

A future reader should be able to start from any studied repository and answer:

1. what the repo does;
2. why it matters;
3. what reusable pattern it contributes;
4. where the pattern is documented in the methods catalog;
5. what evidence supports it;
6. what should be inspected or avoided next.

That is the desired improvement in convenience and informativeness.
