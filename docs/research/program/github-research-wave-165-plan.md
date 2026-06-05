# GitHub Research Wave 165 Plan

- Date: `2026-06-05`
- Theme: `Open Brush, Tilt asset pipelines, browser viewers, shader loaders, and collaborative drawing`
- Scope: Open Brush app/tooling internals, Tilt/Open Brush asset viewers,
  shader/material restoration, raw `.tilt` loading, conversion utilities, and
  collaborative stroke protocols.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier creative-tool waves covered Tilt Brush lineage, in-headset tool menus,
and creative authoring apps. Wave 165 deepens the asset-pipeline side: how
sketches, strokes, brushes, shaders, metadata, exports, and collaborative draw
messages become reusable infrastructure for future VR creative utilities.

## Search Families

- Open Brush and Tilt Brush evolution
- `.tilt` file loaders and converters
- Three.js Open Brush/Tilt viewers
- brush shader/material replacement
- C# and Python Tilt manipulation tools
- collaborative drawing protocols

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `icosa-foundation/open-brush` | Active Tilt Brush evolution with app state, external load, API/Lua/editor/export systems | Creative VR app and sketch pipeline donor |
| `icosa-foundation/gallery-viewer` | Browser viewer for Open Brush/Tilt, glTF, USDZ, VOX, and splat formats with XR mode | Browser creative asset viewer |
| `icosa-foundation/three-icosa` | Three.js material/shader restoration for Open Brush/Tilt exports | Creative export shader loader |
| `icosa-foundation/three-tiltloader` | Raw `.tilt` parser and stroke-to-geometry loader | Raw sketch file ingestion |
| `Prystopia/c-sharp-tiltbrush-toolkit` | Programmatic C# `.tilt` parse/edit/write toolkit | Creative asset manipulation |
| `Phylliida/P2PDraw` | Minimal Unity collaborative stroke protocol and peer message model | Collaborative drawing primitive |
| `DrHibbitts/TiltBrushConverter` | Python OBJ/FBX conversion with merge/backface/export options | Export conversion utility |

## Dedupe Notes

- `icosa-foundation/open-brush` was already tracked as partially studied and is
  promoted by this pass around external loading, API/editor/export systems, and
  app-state boundaries.
- Earlier creative authoring waves remain product/UX comparison context; this
  wave focuses on asset pipeline and donor methods.

## Code-Level Pass Targets

- Open Brush external `.tilt` loading, user sketch paths, and app commands;
- editor/Lua/API/docs generation hooks;
- browser viewer metadata restoration and XR/desktop navigation;
- glTF material extension and brush shader loading;
- raw `.tilt` unzip/binary stroke parsing;
- C#/Python manipulation/conversion utilities;
- collaborative stroke add/remove messages and peer queues.

## Expected Outputs

- New Wave 165 landscape synthesis.
- Registry and family updates for Open Brush/Tilt creative asset pipelines.
- Methods around external sketch loading, metadata restoration, shader
  replacement, raw file ingestion, conversion options, and collaborative stroke
  protocols.
