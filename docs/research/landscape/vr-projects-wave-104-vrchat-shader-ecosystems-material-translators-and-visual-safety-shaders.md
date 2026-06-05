# VR Projects Wave 104: VRChat Shader Ecosystems, Material Translators, and Visual-Safety Shaders

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `VRChat shader ecosystems`, `material translators`, and
  `avatar visual-safety shaders`.

## Why this wave exists

The repository already covered many runtime and overlay branches, but it had
less structure around avatar visual tooling. This wave treats shaders as
creator tooling: inspector UX, material migration, optimization passes,
reusable include layouts, and accessibility surfaces.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by shader and material-migration families;
2. deduplicate against the registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `poiyomi/PoiyomiToonShader` | Large VRChat shader ecosystem with built-in material translation logic |
| `lilxyzw/lilToon` | Large shader ecosystem with custom inspector, multi-material tooling, optimizer, and conversion utilities |
| `MochiesCode/Mochies-Unity-Shaders` | Modular shader pack with shared includes across several effect families |
| `LinesGuy/lilToonToPoiyomiToon` | Narrow one-shot material translator from lilToon to Poiyomi |
| `LesseVR/EpilepsyProtection` | Visual-safety avatar addon that dims bright areas with a small shader surface |

## Deep-pass notes by project

## `poiyomi/PoiyomiToonShader`

- GitHub:
  [poiyomi/PoiyomiToonShader](https://github.com/poiyomi/PoiyomiToonShader)
- What it is:
  a feature-rich Unity Built-In Render Pipeline shader ecosystem widely used
  by VRChat avatars.
- Interesting idea:
  treat shader migration as a first-class editor feature, not as a wiki-only
  manual checklist.
- Code-level notes:
  `LiltoonToPoiyomiToonTranslation.cs`
  uses a `ScriptedShaderTranslator` flow that detects lilToon materials,
  chooses a target Poiyomi shader variant for fake shadow, fur, two-pass, pro,
  or toon cases, sets render presets before translation, applies a property
  mapping table, and restores the previous render queue afterward.
- Code donor value:
  very high for shader translator architecture and compatibility-preserving
  material migration.
- Product reference value:
  high because it shows how a shader ecosystem can include upgrade and
  migration affordances instead of leaving users stranded.
- What to inspect next:
  deeper pass on editor locking, generated variants, preset UX, and material
  validation.

## `lilxyzw/lilToon`

- GitHub:
  [lilxyzw/lilToon](https://github.com/lilxyzw/lilToon)
- What it is:
  a large Unity toon shader ecosystem with UPM import, English and Japanese
  docs, rich editor tooling, and conversion utilities.
- Interesting idea:
  build the shader as an authoring environment: inspector modes, localization,
  multi-material editing, optimization, and conversion sit next to shader code.
- Code-level notes:
  `lilInspector.cs`
  provides custom `ShaderGUI` modes such as Advanced, Preset, and Settings,
  supports multi-material editing, initializes shader managers, handles
  localization, and includes editor-side compatibility workarounds.
  `lilOptimizer.cs`
  scans materials and animation clips, decides which shader properties are
  constants versus animated values, and rewrites HLSL inputs into defines when
  safe.
  `lilMaterialConvertUtility.cs`
  maps material properties into other shader families and can bake textures
  during conversion.
- Code donor value:
  very high for inspector architecture, optimizer design, and material
  conversion utilities.
- Product reference value:
  very high because it models a mature creator-facing shader ecosystem.
- What to inspect next:
  deeper pass on constant-prop rewrite boundaries, generated variant outputs,
  and conversion UX.

## `MochiesCode/Mochies-Unity-Shaders`

- GitHub:
  [MochiesCode/Mochies-Unity-Shaders](https://github.com/MochiesCode/Mochies-Unity-Shaders)
- What it is:
  a collection of Unity Built-In Forward shaders covering toon, standard
  replacement, particles, water, glass, screen-space effects, and shared
  includes.
- Interesting idea:
  keep a shader pack modular by sharing common include substrates instead of
  letting every effect family become its own isolated island.
- Code-level notes:
  the repository groups specialized shader families under folders such as
  `Water Shader`, `Glass Shader`, `ScreenFX Shader`, and `Particle Shader`,
  while `Common` exposes reusable pieces such as `AudioLink.cginc`,
  `LightVolumes.cginc`, noise helpers, and sampling helpers.
- Code donor value:
  high for shader-pack layout and common include substrate.
- Product reference value:
  high for specialized visual-effect families around one shared authoring
  identity.
- What to inspect next:
  compare the shared include model against future AudioLink or world-reactive
  shader studies.

## `LinesGuy/lilToonToPoiyomiToon`

- GitHub:
  [LinesGuy/lilToonToPoiyomiToon](https://github.com/LinesGuy/lilToonToPoiyomiToon)
- What it is:
  a focused Unity editor material converter from lilToon to Poiyomi Toon.
- Interesting idea:
  a narrow migration micro-tool can be more reusable than a broad shader suite
  because it exposes the whole conversion workflow in one file.
- Code-level notes:
  `MaterialConverter.cs`
  runs from an editor menu over selected objects, checks for Poiyomi Toon or
  Pro availability, backs up original materials, chooses target shader variants
  based on lilToon two-pass or refraction cases, maps render mode, culling,
  ZWrite, render queue, main color, HSV, decal, alpha, shadow, normal,
  reflection, and related properties, and reports unsupported skipped
  materials.
- Code donor value:
  high for one-shot migration utility structure.
- Product reference value:
  high for a small tool with one clear user value.
- What to inspect next:
  compare its backup and skipped-material reporting against Poiyomi's built-in
  translator.

## `LesseVR/EpilepsyProtection`

- GitHub:
  [LesseVR/EpilepsyProtection](https://github.com/LesseVR/EpilepsyProtection)
- What it is:
  a VRChat avatar addon shader that dims bright areas and offers blackout or
  night-mode style protection.
- Interesting idea:
  visual comfort can be shipped as a small avatar-installed utility rather
  than only as a runtime-level feature.
- Code-level notes:
  `EPShader.shader`
  uses an overlay queue shader with a GrabPass background texture, luminance
  threshold, softness, blackout, HDR clamp, night mode, and distance-hide
  controls. The README frames it as a simple VRCFury-installed addon and
  explicitly warns that dimming bright regions is not the same as preventing
  all strobing.
- Code donor value:
  medium-high for luminance thresholding and comfort-filter controls.
- Product reference value:
  high for accessibility product framing and honest caveats.
- What to inspect next:
  future accessibility waves can compare this against overlay-level comfort
  filters and runtime-side brightness guards.

## Main takeaways from Wave 104

- VRChat shader projects are not only visual assets. They often contain rich
  creator-facing editor systems.
- Material migration is a reusable tool pattern with clear steps: detect source
  shader, choose target variant, set render presets, map properties, restore
  compatibility-sensitive fields, and report unsupported cases.
- Visual-safety shader addons are useful even when narrow because they show how
  accessibility can live inside avatar packaging constraints.
- Large ecosystems and tiny migration tools should be compared together: the
  large repos show architecture, while the micro-tools show the cleanest user
  journey.

## Reusable methods clarified by this wave

- `Shader material translator table that preserves render mode and render queue`
- `Multi-material shader inspector with constant-property shader optimization`
- `Modular shader pack built around shared include substrate`
- `Avatar visual-safety grabpass dimmer with threshold, blackout, and HDR clamp`

## Recommended next moves after this wave

1. Keep `PoiyomiToonShader` and `lilToon` visible as the strongest current
   shader ecosystem donors.
2. Keep `LinesGuy/lilToonToPoiyomiToon` visible as a small migration
   micro-utility reference.
3. Use `EpilepsyProtection` as a seed for future visual comfort and
   accessibility shader research.
4. Revisit shader inspector UX if `VR-apps-lab` later prototypes creator-side
   material migration or validation tools.
