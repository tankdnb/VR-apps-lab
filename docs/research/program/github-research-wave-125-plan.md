# GitHub Research Wave 125 Plan

- Date: `2026-06-05`
- Goal: study Unity VR experiment frameworks and data-capture helpers for
  reusable lifecycle, tracker, settings, and export patterns.

## Why this wave exists

Research frameworks are useful beyond lab studies. They show how to make VR
tools repeatable: session metadata, blocks, trials, settings, trackers, data
handlers, remote configuration, fallback, resume, and upload.

## Search scope

Primary search directions:

- Unity experiment frameworks;
- UXF-based VR projects;
- trial managers and CSV/JSON condition loops;
- VR pose/motion tracking study shells;
- remote settings and upload sidecars.

## Frozen shortlist for code-level study

- `immersivecognition/unity-experiment-framework`
- `BioMotionLab/TUX`
- `jinwook31/Unity-Experiment-Trial-Manager`
- `Nesbi/PsyWueVR`
- `social-spatial-interaction-lab/VR_Motion_Tracker`
- `SensoriMotorControlLab/vr_experiment_framework_v3`
- `jackbrookes/uxf-s3-uploader`
- `jackbrookes/uxf-web-settings`

## Execution model

### Step 1: Search and deduplicate

- search by Unity VR experiment, UXF, trial manager, and data-capture families;
- deduplicate against Unity toolkit and teleoperation/data-capture waves;
- keep only repositories with lifecycle, data, tracker, or deployment lessons.

### Step 2: Freeze the shortlist

- include one canonical framework, one editor-heavy toolkit, small managers,
  study shells, and deployment sidecars.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones out of git history.

### Step 4: Perform the code-level pass

Inspect:

- session/block/trial lifecycle;
- settings and design data sources;
- tracker and measurement rows;
- data handlers and output managers;
- remote settings, fallback, resume, and upload behavior.

### Step 5: Promote findings into repository structure

Update the Wave 125 synthesis, registry, families, methods, backlog, and
research indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- findings are documented as reusable methods, not runnable dependencies.

## Definition of done

This wave is complete when the study-harness and data-capture patterns are
documented across landscape, registry, families, methods, and indexes.
