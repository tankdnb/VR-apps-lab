# VR Projects Wave 438: Inclusive VR Wheelchair and Impairment Simulation Tools

Date: 2026-07-13

Theme: inclusive-design and empathy-oriented VR samples that simulate mobility,
vision, or motor constraints and expose practical UI/comfort lessons.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `rehabnj/vr-wheelchair-simulator` | Wheelchair accessibility awareness simulation | Code-level pass |
| `VlasiosKasapakis/VR4ALL` | Impairment simulation asset reference | README/thin source pass |

## Project Notes

### `rehabnj/vr-wheelchair-simulator`

- Interesting idea: Unity VR wheelchair simulator that teaches accessibility
  barriers through first-person navigation and environment interaction.
- Code donor value: moderate donor for accessibility options such as caption
  trigger panels, brightness overlay, audio preference persistence, and a simple
  environment-building/control surface around the simulation.
- Product reference value: useful reference for empathy/awareness experiences
  where mobility constraints, ramps, obstacles, captions, audio, and visual
  brightness are part of the product framing.
- Architecture pattern: Unity/XRI project with custom scripts layered over
  imported XRI starter assets and URP samples.
- Reusable method: `inclusive mobility simulation loop`.
- UX/product lesson: accessibility simulations should pair constrained movement
  with explanatory/supporting surfaces such as captions, brightness control, and
  saved audio preferences.
- Caveats: many inspected files are imported Unity samples, project contains
  large generated/sample assets, and custom wheelchair-specific logic is thinner
  than the README suggests.
- Source evidence: README documents wheelchair navigation, accessibility
  awareness, Android APK, and design docs; `ActivateCaptions.cs` reveals
  trigger-based captions; `BrightnessController.cs` stores brightness in
  `PlayerPrefs`; `AudioManager.cs` applies persisted audio toggle state.
- Reusable core: constrained mobility scenario, obstacle/ramp task framing,
  captions on proximity, brightness overlay, audio preference, and reflection
  documents.
- What not to copy: imported XRI/URP sample folders as custom donor code or APK
  distribution links without provenance.
- Method catalog action: create inclusive simulation method with caveats.
- What to inspect next: find wheelchair-controller projects with stronger
  locomotion code and accessibility assessment metrics.

### `VlasiosKasapakis/VR4ALL`

- Interesting idea: IVR asset for inclusive product design education, simulating
  visual and motor impairments such as Parkinson's tremor, wheelchair use, limb
  loss, colorblindness, and glaucoma.
- Code donor value: low in the public repo because the asset source was not
  present; useful mainly as a product/reference node.
- Product reference value: strong framing reference for impairment-switching UX,
  education workflows, and inclusive-design teaching materials.
- Architecture pattern: public landing repo pointing to a Unity/XR Toolkit asset
  and external materials.
- Reusable method: `impairment profile switching simulation`.
- UX/product lesson: impairment simulations need clear condition labels,
  switchable profiles, caveats, and educational context so they do not become
  shallow effects.
- Caveats: source not available in the inspected repo, external SharePoint asset
  link, and third-party asset credits for CVD filter and wheelchair controller.
- Source evidence: README lists simulated conditions, Unity/XR Toolkit
  compatibility, profile switching, educational goals, and asset credits.
- Reusable core: impairment profile registry, filter/effect routing,
  first-person embodiment mode, educator-facing explanation, and caveat labels.
- What not to copy: external assets, medical claims, or impairment effects
  without validation and consent framing.
- Method catalog action: include as product reference in inclusive simulation
  method, not as a code donor.
- What to inspect next: locate source-available impairment filters, tremor
  simulators, locomotion constraints, and low-vision shader examples.

## Reusable Pattern Extraction

- Pattern candidate: `inclusive simulation profile loop`.
- Problem solved: teams need repeatable ways to experience and discuss access
  barriers without confusing empathy demos with validated medical tools.
- Reusable core: profile/condition catalog, constrained movement or perception
  effect, explanatory UI, saved comfort/accessibility settings, scenario tasks,
  caveats, and reflection/export materials.
- Source evidence: wheelchair simulator supplies scenario/supporting UI scripts;
  VR4ALL supplies impairment-profile product framing.
- Abstraction boundary: profile taxonomy and support UI are reusable; clinical
  claims, external assets, and unvalidated impairment effects are not.

## Follow-Up Gaps

- Study source-available wheelchair locomotion, tremor, colorblindness,
  low-vision, and hearing-loss simulation components.
- Draft a reusable "accessibility simulation caveat" note format that separates
  educational empathy value from medical or lived-experience claims.
