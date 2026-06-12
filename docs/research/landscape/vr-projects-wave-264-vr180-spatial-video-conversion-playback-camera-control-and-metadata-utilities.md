# Wave 264 - VR180 Spatial Video Conversion, Playback, Camera Control, and Metadata Utilities

This wave studies VR180 and stereo-media utilities that are useful beyond one
viewer: conversion pipelines, camera companions, projection metadata parsers,
browser components, and host-player shader controls.

## Scope

The wave was bounded to VR180 or stereo media projects that expose reusable
pipeline boundaries:

- fisheye, side-by-side, and equirectangular conversion;
- camera or lens-specific remapping and calibration;
- metadata, mesh projection, EXIF, XMP, and right-eye payload handling;
- web or host-player playback shells;
- shader-controlled projection state and fallback UX.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `34j/vr180-convert` | VR180 conversion CLI | Studied | OpenCV remap pipeline with stereo pair auto-matching and feature-based calibration |
| `silverqsy/VR180-Silver-Bullet` | Professional VR180 media processor | Studied | GoPro Max 2 style decode, gyro, stabilization, GPU, and export pipeline reference |
| `nallic/convert_VR180` | Camera-specific image converter | Studied | ST-map single-resample conversion for Canon dual-fisheye workflows |
| `aosoft/VR180MeshProjection` | Projection metadata parser | Studied | Unity parser for MP4 Mesh Projection Box metadata and mesh reconstruction |
| `Vargol/VR180PhotoTools` | VR180 photo format tools | Studied | EXIF/XMP/right-eye embedding and extraction utilities for VR180 photos |
| `ganeshv/egarim` | VR180 camera companion | Studied | Mirage camera Bluetooth pairing, encrypted API, capture, media, and viewfinder control |
| `Verdi/VR180-Web-Player` | Browser VR180 player | Studied | WebXR-capable 180-degree video player with non-XR draggable fallback |
| `steren/stereo-img` | Declarative stereo image web component | Studied | Custom element with parser registry for stereo, VR180, anaglyph, depth, and XMP data |
| `kasper93/mpv360` | Host-player projection shader control | Studied | mpv Lua plus GLSL projection controls, SBS eye output, OSD, and key bindings |

## Code-Level Findings

### `34j/vr180-convert`

- Interesting idea:
  make VR180 conversion a small CLI with composable OpenCV remap transforms
  instead of a monolithic media application.
- Code donor value:
  strong for Typer commands, image-pair auto-search by closest timestamp,
  split-image handling, interpolation and border options, remap map
  generation, AKAZE feature matching, and robust rotation calibration.
- Product reference value:
  useful as a narrow "convert this stereo capture" utility that can sit inside
  a larger spatial-media toolkit.
- What to inspect next:
  batch UX, calibration persistence, transform string safety, and preview
  output quality checks.
- Caveats:
  transformer expressions should not be exposed to untrusted users; the CLI is
  image-first rather than a full video pipeline.

### `silverqsy/VR180-Silver-Bullet`

- Interesting idea:
  treat VR180 processing as a professional media pipeline with decode,
  metadata, stabilization, rolling-shutter timing, denoise, and export stages.
- Code donor value:
  strong for platform-aware logging, log rotation, optional import gates,
  FFmpeg/PyAV/Numba/CUDA capability detection, GoPro GPMF gyro parsing,
  timestamp handling, Apple Vision Pro export helpers, and bundled binary
  resolution.
- Product reference value:
  excellent reference for how a serious desktop VR180 processor communicates
  constraints and operator state.
- What to inspect next:
  pipeline decomposition, GUI state machine, export presets, APMP/MV-HEVC
  metadata, calibration files, and GPU fallback behavior.
- Caveats:
  hardware-specific, large top-level scripts, platform/GPU constraints, and
  duplicated build-kit material mean this is a concept donor, not a copy target.

### `nallic/convert_VR180`

- Interesting idea:
  use precomputed ST maps to convert dual-fisheye captures with one resampling
  pass.
- Code donor value:
  useful for batch image conversion, camera/lens-specific map selection, EXR
  map assets, and parallel processing boundaries.
- Product reference value:
  good reference for a calibrated camera profile folder rather than fully
  automatic projection inference.
- What to inspect next:
  map generation provenance, new camera profile creation, resolution mismatch
  handling, and output QA.
- Caveats:
  the included maps are specific to Canon dual-fisheye workflows.

### `aosoft/VR180MeshProjection`

- Interesting idea:
  parse projection metadata from video containers into a Unity mesh that can be
  inspected or rendered.
- Code donor value:
  useful for MP4 Mesh Projection Box parsing, `dfl8` deflate handling,
  big-endian readers, signed delta decoding, vertex lists, UV-like coordinate
  reconstruction, and primitive index mode handling.
- Product reference value:
  valuable for a future projection-aware validator or debug viewer.
- What to inspect next:
  error handling, unsupported box types, modern Unity compatibility, and
  integration with a player texture path.
- Caveats:
  the author marks the implementation as incomplete; treat it as parser
  evidence, not production code.

### `Vargol/VR180PhotoTools`

- Interesting idea:
  expose VR180 photo packaging as paired command-line tools for
  equirectangular-to-VR180 and VR180-to-equirectangular conversion.
- Code donor value:
  useful for JPEG parsing, EXIF/XMP write-back, left/right and top/bottom
  format flags, field-of-view options, right-eye payload handling, and quality
  settings.
- Product reference value:
  a good "format repair and conversion" micro-utility for spatial photos.
- What to inspect next:
  XMP schema coverage, modern .NET migration, sample compatibility, and batch
  reporting.
- Caveats:
  older .NET/Mono era code and narrow format assumptions.

### `ganeshv/egarim`

- Interesting idea:
  build a desktop companion for a VR180 camera that handles pairing, encrypted
  transport, camera configuration, capture, media inventory, and viewfinder.
- Code donor value:
  strong for Bluetooth bootstrap, ECDH-style shared key flow, message framing,
  signed HTTP requests, capture/live/viewfinder commands, media listing, and
  ST3D/SV3D metadata fetches.
- Product reference value:
  useful for device-companion state machines where a VR utility owns hardware
  setup and media control.
- What to inspect next:
  crypto boundary, key storage, transport errors, camera disconnect recovery,
  and privacy UX.
- Caveats:
  Linux Bluetooth assumptions, shell-based Java crypto helpers, secrets on
  disk, and abandoned camera ecosystem.

### `Verdi/VR180-Web-Player`

- Interesting idea:
  make a VR180 player that progressively upgrades from draggable 2D fallback
  to immersive WebXR when headset support exists.
- Code donor value:
  useful for WebXR session capability checks, dynamic UI creation, world-space
  controls, 2D yaw/pitch fallback, auto-hide timings, canvas button textures,
  and simple SBS 2:1 media assumptions.
- Product reference value:
  good browser shell reference for public demos, Vision Pro and Quest style
  viewing, and graceful non-XR fallback.
- What to inspect next:
  media format detection, control accessibility, mobile browser quirks, and
  MV-HEVC/APMP support gaps.
- Caveats:
  author notes limited support; it does not solve all spatial-video formats.

### `steren/stereo-img`

- Interesting idea:
  wrap stereo and VR180 images in a declarative web component with explicit
  attributes instead of per-site viewer code.
- Code donor value:
  strong for custom element attributes, microtask render batching, parser
  registry, stereo half-detection, XMP/GPano parsing, embedded right-eye image
  extraction, Three.js display modes, VRButton integration, and anaglyph/flat
  fallbacks.
- Product reference value:
  excellent reference for reusable web components around spatial still images.
- What to inspect next:
  parser failure UX, CORS behavior, image memory pressure, and format matrix
  coverage.
- Caveats:
  heuristic stereo detection and browser metadata access constraints.

### `kasper93/mpv360`

- Interesting idea:
  control 360 or stereo media projection from a host player through Lua state
  and GLSL shader parameters.
- Code donor value:
  useful for mpv script options, projection and eye mode enums, key-binding
  state changes, OSD status feedback, mouse-look enable/disable, shader option
  updates, and SBS output control.
- Product reference value:
  good local-player reference when a full VR app is overkill.
- What to inspect next:
  shader projection math, stereo output paths, config profile UX, and host
  player lifecycle.
- Caveats:
  mpv-specific and global controls can conflict with user input while enabled.

## Reusable Pattern Extraction

- Pattern candidate:
  spatial media utility pipeline boundary.
- Problem solved:
  VR180 utilities tend to mix capture, remap, metadata, playback, and export.
  Reuse becomes easier when each stage names its inputs, calibration state,
  projection assumptions, and output contract.
- Reusable core:
  source media adapter, camera or lens profile, calibration/remap transform,
  metadata parser, optional stabilization, format writer, player fallback, and
  diagnostics/report output.
- Source evidence:
  `vr180-convert`, `VR180-Silver-Bullet`, `convert_VR180`,
  `VR180MeshProjection`, `VR180PhotoTools`, `egarim`,
  `VR180-Web-Player`, `stereo-img`, and `mpv360`.
- Abstraction boundary:
  conversion, metadata repair, device control, and playback should be
  separate modules even if a future product presents them as one workflow.
- What not to copy:
  unsafe transform evaluation, hardware-specific scripts as generic logic,
  stale camera APIs, and format-specific viewers that hide unsupported cases.
- Method catalog action:
  create a method for spatial-video utility pipeline decomposition.

## Family Placement

This wave creates a VR180 spatial-video utility family. It overlaps with
browser panoramic players, engine-side stereo viewers, Quest media helpers,
and immersive media substrates, but its unique value is the conversion and
metadata pipeline around VR180 capture rather than playback alone.

## Backlog Impact

- Add a VR180/spatial-video matrix comparing conversion, metadata, device
  control, playback fallback, and export stages.
- Deepen `stereo-img`, `vr180-convert`, and `VR180-Silver-Bullet` if spatial
  media tooling becomes an implementation branch.
- Keep camera-specific projects caveated until their calibration profile
  boundaries are separated from hardware assumptions.
