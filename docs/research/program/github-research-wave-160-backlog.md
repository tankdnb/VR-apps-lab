# GitHub Research Wave 160 Backlog

- Date: `2026-06-05`
- Theme: `Foveated rendering, quad-view settings, and graphics-layer adaptation helpers`
- Status: `Completed`

## Completed Pass

1. Search foveated rendering, quad-view, OpenVR wrapper, OpenXR layer, and
   Unity native plugin projects.
2. Deduplicate against existing OpenXR Toolkit, Quad-Views-Foveated,
   OpenVR/OpenXR layer, and runtime-tool entries.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect settings flows, OpenVR hooks, OpenXR API-layer overrides, vendor
   SDK shims, Unity command buffers, native plugin events, and VRS capability
   checks.
5. Promote all five repositories into registry/families/methods with explicit
   source-light caveats where needed.
6. Integrate results into indexes and current focus.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `TallyMouse/QuadViewsCompanion` | Added as source-light quad-view settings companion reference |
| `mbucchia/PimaxMagic4All` | Added as vendor foveation SDK emulation and eye-provider fallback donor |
| `fholger/openvr_foveated` | Added as OpenVR DLL replacement foveated-rendering wrapper donor |
| `mbucchia/_ARCHIVE_Varjo-Foveated` | Added as archived OpenXR quad-view/foveation API-layer reference |
| `ViveSoftware/ViveFoveatedRendering` | Added as Unity native VRS command-buffer plugin reference |

## Useful Follow-Up Work

- Build a rendering-adaptation matrix across OpenXR Toolkit, Quad-Views
  Foveated, Varjo-Foveated, OpenVR FSR, OpenVR Foveated, and Unity native VRS.
- Separate safe settings companions from invasive runtime hooks in future
  product planning.
- Compare user-facing fallback UX for unsupported VRS, missing eye tracking,
  and incompatible target games.

## Not Pursued In This Wave

- No headset, game, runtime, Unity project, installer, or native plugin was
  launched.
- No found repository was run, built, installed, or tested.
