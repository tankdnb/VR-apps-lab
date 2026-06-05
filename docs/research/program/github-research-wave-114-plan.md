# GitHub Research Wave 114 Plan

- Date: `2026-06-05`
- Goal: run a focused GitHub research wave for Meta Quest mixed-reality
  samples around passthrough camera access, depth occlusion, shared spatial
  anchors, presence-style app composition, and reusable MR motifs.

## Why this wave exists

Many useful VR utilities are becoming mixed-reality utilities: camera feeds,
depth-aware overlays, anchored markers, colocated rooms, and shared activities.
Meta's sample repositories are useful because they show concrete permission
gates, camera-to-world math, depth/occlusion configuration, anchor sharing,
and product motifs for recurring MR interactions.

This wave studies Quest MR samples as reusable references for camera/depth
diagnostics, anchored utility markers, colocated helper tools, and MR product
patterns.

## Search scope

Primary search directions for this wave:

- Quest passthrough camera API samples;
- environment depth and occlusion samples;
- spatial anchor and shared anchor examples;
- full MR sample app structure;
- reusable MR motif libraries.

## Frozen shortlist for code-level study

- `oculus-samples/Unity-PassthroughCameraApiSamples`
- `oculus-samples/Unity-DepthAPI`
- `oculus-samples/Unity-SharedSpatialAnchors`
- `oculus-samples/Unity-Discover`
- `oculus-samples/Unity-MRMotifs`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for Meta Quest camera, depth, shared anchor, Discover, and MR
  motif sample families;
- compare surfaced repositories against registry and family docs;
- keep sample repositories as implementation references while documenting
  requirements and platform constraints clearly.

### Step 2: Freeze the shortlist

- include camera access, depth API, spatial anchors, full sample app, and
  reusable motif library coverage.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- permission gates and platform requirements;
- camera-to-world, ray, texture, and ML-object marker flows;
- depth, occlusion, cutout, and bias control;
- spatial anchor create/save/share/load/bind/alignment sequences;
- full-app composition and documentation structure;
- MR motifs such as passthrough transitions, shared activities, placement, and
  space sharing.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 114 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- Quest-specific requirements and caveats stay explicit;
- camera, depth, anchors, and motifs are separated instead of merged;
- sample-app references are not represented as generic cross-platform support;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 114 synthesis document exists with code-level findings;
4. registry and families represent Quest MR sample donors clearly;
5. new methods capture camera, depth, shared-anchor, and motif patterns;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
