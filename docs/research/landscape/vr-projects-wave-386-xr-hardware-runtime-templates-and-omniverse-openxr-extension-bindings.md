# Wave 386: XR Hardware Runtime Templates and Omniverse OpenXR Extension Bindings

## Theme

Bootstrap templates and runtime bindings for hardware-heavy XR work: SenseGlove
Unity scenes, Omniverse OpenXR compact API, and headset/tracker setup caveats.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `Adjuvo/Unity-Template` | Studied | SenseGlove Unity template with grab/squeeze/drawer/door/snapping/buttons/dials and headset-specific settings |
| `Toni-SM/semu.xr.openxr` | Studied | NVIDIA Omniverse OpenXR extension with Python binding, GUI launcher, action subscription, haptics, and stereo rendering |

## Dedupe Notes

Previous waves covered OpenXR runtimes and Unity interaction modules. This wave
focuses on hardware/runtime onboarding templates that package setup knowledge,
sample scenes, and API loops as reusable starting points.

## Code-Level Findings

### `Adjuvo/Unity-Template`

- Interesting idea: provide a ready Unity project with SenseGlove plugin,
  headset settings, and small interaction scenes for hardware onboarding.
- Code donor value: `Template-Project`, example scenes, SenseGlove settings,
  and README interaction list cover grabbing, squeezing, highlight placement,
  breakables, drawers, doors, snapping, buttons, switches, dials, and
  gesture-based teleport.
- Product reference value: useful for future hardware templates where the most
  valuable part is setup/scene convention rather than novel code.
- What to inspect next: scene prefab names, SenseGlove setting assets, headset
  switching workflow, and Pico/Vive wrist tracker differences.
- Caveat: plugin licensing and hardware dependencies must stay explicit.

### `Toni-SM/semu.xr.openxr`

- Interesting idea: expose OpenXR to Omniverse/Isaac Sim as a compact Python
  extension with a GUI launcher and action/render loop.
- Code donor value: `exts/semu.xr.openxr`, `extension.toml`, Python package,
  `_openxr` binding, UI extension, tests, native loader bins, and `src`
  OpenXR C++ sources show a complete extension boundary.
- Product reference value: strong reference for XR-enabling non-game
  workbenches such as simulation, robotics, and data visualization tools.
- What to inspect next: action subscription lifecycle, haptic API, stereo view
  setup, frame transforms, and extension enable/disable behavior.
- Caveat: bundled native binaries and Omniverse-version assumptions need
  provenance review.

## Reusable Pattern Extraction

- Pattern candidate: XR hardware/runtime bootstrap template.
- Problem solved: hardware-specific XR work fails when setup knowledge is not
  packaged with sample scenes, settings, runtime loops, and capability caveats.
- Reusable core: template project, sample scene, hardware setting profile,
  interaction checklist, runtime loader/extension manifest, action
  subscription, stereo render setup, haptic output, GUI launcher, and version
  caveat.
- Source evidence: SenseGlove template README/scene list and
  `semu.xr.openxr` `exts`, `extension.toml`, Python bindings, UI extension,
  tests, and `src/xr.cpp`.
- Abstraction boundary: template setup and runtime binding should not own
  product logic; product scenes consume hardware/runtime adapters.
- What not to copy: plugin binaries without provenance, hardware settings as
  universal defaults, or runtime loops without enable/disable lifecycle.
- Method catalog action: add Method 831.

## Family Placement

Creates an XR hardware/runtime bootstrap family. It connects vendor hardware
templates with OpenXR extension binding patterns for workbench-style tools.

## Follow-Up Gaps

- Create a hardware template checklist: plugin version, headset setting,
  sample scene, fallback, and license.
- Compare Omniverse extension lifecycle with Unity package/template lifecycle.
- Track which runtime bindings include haptics and action subscription.
