# GitHub Research Wave 104 Plan

- Date: `2026-06-05`
- Goal: run the next focused GitHub research wave for repositories that map
  `VRChat shader ecosystems`, `material translators`, and
  `avatar visual-safety shaders`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of overlays, runtime helpers, media
surfaces, and VRChat creator tooling, but the avatar visual layer was still
thin.

This wave exists to make shader ecosystems and material migration utilities
visible as reusable creator-tooling patterns rather than treating shaders as
opaque art assets.

## Search scope

Primary search directions for this wave:

- VRChat shader ecosystems with large custom inspector surfaces;
- shader material translators and one-shot migration tools;
- modular shader packs with reusable includes and effect families;
- avatar visual-safety shaders that solve a narrow accessibility problem;
- editor-side material conversion or optimization logic.

## Frozen shortlist for code-level study

- `poiyomi/PoiyomiToonShader`
- `lilxyzw/lilToon`
- `MochiesCode/Mochies-Unity-Shaders`
- `LinesGuy/lilToonToPoiyomiToon`
- `LesseVR/EpilepsyProtection`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for VRChat shader, material translator, lilToon, Poiyomi,
  shader optimizer, and visual-safety addon queries;
- compare surfaced repositories against `catalog/project-registry.md` and
  `landscape/project-families.md`;
- reject pure forks or shader packs where the source adds no reusable tooling
  lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on avatar visual infrastructure;
- include both large ecosystems and narrow micro-utilities so the family covers
  heavy editor shells and small donor-worthy conversion tools.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- shader inspector architecture;
- material translation logic;
- render mode and render queue handling;
- shared include layout;
- shader optimization and multi-material workflows;
- accessibility or visual-safety behavior.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 104 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- shader projects are placed as creator-tooling and avatar-visual donors;
- material translators are not reduced to link-list entries;
- visual-safety shaders are represented as accessibility references;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 104 synthesis document exists with code-level findings;
4. registry and families represent shader ecosystem and material translator
   donors clearly;
5. new methods are captured where this wave clarified shader migration,
   inspector, optimizer, modular effect-pack, or visual-safety patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
