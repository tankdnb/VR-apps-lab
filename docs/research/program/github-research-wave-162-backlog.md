# GitHub Research Wave 162 Backlog

- Date: `2026-06-05`
- Theme: `Resonite creator import/export, inspection, and screenshot utility helpers`
- Status: `Completed`

## Completed Pass

1. Search Resonite Unity SDK, exporter, Unity package importer, component
   search, and screenshot metadata projects.
2. Deduplicate against Wave 130 Resonite mod-loader/headless/external-SDK
   coverage.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect README architecture notes, generated bindings, converter systems,
   IPC/import processors, Unity package extraction/cache logic, UI patching,
   search ranking, XMP metadata serialization, restore-on-import, and webhook
   flows.
5. Promote all five repositories into registry/families/methods.
6. Add creator-pipeline follow-up gaps.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `Yellow-Dog-Man/Resonite.UnitySDK` | Added as official Unity-to-Resonite SDK and generated binding/converter donor |
| `Phylliida/ResoniteUnityExporter` | Added as Unity exporter, shared DTO, and IPC import processor reference |
| `dfgHiatus/ResoniteUnityPackagesImporter` | Added as `.unitypackage` extraction/cache/import mod donor |
| `BlueCyro/CherryPick` | Added as component selector search QoL reference |
| `hantabaru1014/ResoniteScreenshotExtensions` | Added as screenshot metadata, restore, and webhook utility donor |

## Useful Follow-Up Work

- Build a creator import/export matrix across Unity SDK, Unity exporter, Unity
  package importer, VRC avatar pipelines, and generic asset import tools.
- Extract a reusable "generated bindings plus converters" checklist for future
  editor-side data-model bridges.
- Compare screenshot/photo metadata preservation across Resonite, VRChat
  camera tools, and mixed-reality capture utilities.

## Not Pursued In This Wave

- No Resonite client, mod loader, Unity editor, exporter executable, package
  importer, component selector, screenshot pipeline, or webhook was launched.
- No found repository was run, built, installed, imported, or tested.
