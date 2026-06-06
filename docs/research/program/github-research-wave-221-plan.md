# GitHub Research Wave 221 Plan

Date: 2026-06-06

Theme: vendor OpenXR extension stacks, feature wrappers, and sample matrices.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Many advanced XR features live behind optional OpenXR extensions, engine
plugins, vendor SDKs, or experimental flags. This wave studies how projects
wrap those capabilities safely: feature discovery, lifecycle hooks, function
pointer loading, editor/build gates, sample matrices, and caveat reporting.

## Search Families

- Microsoft OpenXR samples and Unreal feature plugins.
- Meta Quest native OpenXR samples.
- Unity OpenXR extension wrappers.
- Optional feature registry and lifecycle helpers.
- Vendor extension caveat documentation.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `microsoft/OpenXR-MixedReality` | C++ samples mapping HoloLens/WMR features to explicit OpenXR extensions and sample files. | Microsoft OpenXR sample matrix |
| `microsoft/Microsoft-OpenXR-Unreal` | Unreal plugin that registers optional Microsoft OpenXR feature modules and Blueprint wrappers. | Engine feature registry |
| `meta-quest/Meta-OpenXR-SDK` | Quest native SDK with broad extension sample matrix and helper classes for optional features. | Vendor native sample matrix |
| `mikeskydev/unity-openxr-extensions` | Unity `OpenXRFeature` wrappers for FB/META extensions with lifecycle hooks and Android manifest build hooks. | Small Unity extension wrapper |

## Dedupe Notes

Earlier waves covered OpenXR samples, extension layers, and vendor feature
sets, but these four were chosen as a focused comparison of extension wrapping
styles rather than as generic sample-app material.

## Code-Level Pass Targets

- Instance/session lifecycle and extension enablement.
- Function pointer loading and required-extension checks.
- Modular feature registration in engine plugins.
- Build-time manifest/package gates.
- Sample matrices that map features to files.
- Experimental/license/platform caveats.

## Expected Outputs

- Wave 221 landscape synthesis.
- Registry/family entries for vendor OpenXR extension stacks.
- Method catalog entry for OpenXR extension wrappers with lifecycle,
  capability, and build gates.
- Follow-up backlog for extension-wrapper matrices.
