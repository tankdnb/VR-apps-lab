# GitHub Research Wave 116 Plan

- Date: `2026-06-05`
- Goal: study Godot XR toolkit, template, OpenXR/OpenVR plugin, vendor
  extension, and legacy mobile VR repositories as reusable engine-side
  references for VR utility prototyping.

## Why this wave exists

Recent waves covered WebXR, Unity XR, Quest MR samples, and Linux spatial
desktop clients. Godot is a useful additional substrate because it exposes XR
interaction as scenes, scripts, plugins, templates, export presets, and
GDExtension layers rather than as one monolithic app.

This wave studies the Godot XR ecosystem as a reusable pattern library for
future utility prototypes, vendor-extension exploration, runtime diagnostics,
and lightweight interaction baselines.

## Search scope

Primary search directions for this wave:

- Godot XR interaction toolkits and scene packs;
- Godot OpenXR and OpenVR backend plugins;
- Godot XR project templates and action maps;
- vendor-specific OpenXR extension packaging for Quest, Pico, Lynx, Android
  XR, Magic Leap, and Khronos features;
- deprecated mobile VR bridges that still preserve useful API-shaping lessons.

## Frozen shortlist for code-level study

- `GodotVR/godot-xr-tools`
- `GodotVR/godot-xr-template`
- `GodotVR/godot_openxr_for_godot_3.x`
- `GodotVR/godot_openxr_vendors`
- `GodotVR/godot_openvr`
- `GodotVR/godot_oculus_mobile`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for Godot XR tools, OpenXR plugin, OpenVR plugin, vendor
  extension, and Quest/mobile Godot families;
- compare candidates against `project-registry.md` and `project-families.md`;
- avoid treating archived or deprecated repositories as current support
  targets, but keep them as migration references if they teach an architecture
  pattern.

### Step 2: Freeze the shortlist

- include one scene-pack toolkit, one starter template, one legacy OpenXR
  backend, one vendor-extension stack, one OpenVR backend, and one deprecated
  Oculus Mobile bridge.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep all downloaded sources local-only and outside public git history.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- project structure and addon/plugin boundaries;
- action maps, controller functions, hands, locomotion, pointers, and
  interactables;
- OpenXR/OpenVR interface classes, action-system glue, skeletons, and device
  metadata;
- vendor extension wrappers, export plugins, and project-setup helpers;
- deprecated mobile APIs and migration caveats.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 116 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- Godot runtime/plugin/template boundaries are not collapsed into one generic
  "Godot app" bucket;
- deprecated repositories are clearly marked as migration references;
- vendor-extension findings are captured as export/setup patterns, not as a
  promise of current device support;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 116 synthesis document exists with code-level findings;
4. registry and families represent Godot XR donors clearly;
5. new methods capture scene-pack toolkits and vendor extension packaging;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
