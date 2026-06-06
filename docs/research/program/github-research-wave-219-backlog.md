# GitHub Research Wave 219 Backlog

Date: 2026-06-06

Theme: VRChat external content ingress: image, GLB, synced texture, and
avatar-data surfaces.

## Completed In This Wave

- Studied `vrchat-community/examples-image-loading` as a minimal official
  remote image/caption slideshow with persistent `VRCImageDownloader`, cached
  `Texture2D[]`, `VRCStringDownloader`, server-time slide selection, and
  GitHub Pages content hosting.
- Studied `vr-voyage/vrchat-glb-loader` as a runtime GLB/VRM loader with GLB
  string download, DataDictionary parser states, meshes/materials/textures,
  material extension handlers, DDS/preconverted textures, and explicit
  unsupported bones/animations/blendshapes/cameras/lights.
- Studied `DrBlackRat/VRC-Picture-Loader` as a productized VPM image ingress
  package with manager, lite downloader, URL input, persistence, tablet,
  texture settings, loading/error states, and UI progress.
- Studied `Narazaka/SyncTexture` as a chunked Texture2D synchronization package
  with source readback, color encoders, `BulkCount`, progress, partial apply,
  callback events, manager sequencing, resend, and late-join support.
- Deepened `Miner28/AvatarImageReader` as a deprecated but valuable
  avatar-thumbnail text/data carrier with editor encoder, runtime pedestal
  texture readback, UTF-8/UTF-16 decode loops, avatar chaining, and platform
  capacity notes.
- Added a reusable method entry for VRChat external content ingress surfaces.

## Follow-Up Queue

1. Build a VRChat external content-ingress matrix: URL image, caption string,
   URL input, persistence, GLB model, synced texture, avatar image, and shader
   data bus.
2. Compare `VRC-Picture-Loader` manager/lite/url-input modes with the official
   slideshow sample to separate minimal API use from product UX.
3. Revisit previous Udon encoding/string-loading waves and link
   `AvatarImageReader` as historical/deprecated context after string loading.
4. Compare `SyncTexture` with AudioLink and other texture buses as a general
   surface/data transport pattern.
5. Inspect release/package docs for GLB texture converter companions if a
   model-ingress prototype becomes active.

## Do Not Spend Time On Yet

- Do not import or run Unity/VRChat packages.
- Do not treat deprecated avatar-image encoding as the first choice now that
  VRChat string loading exists.
- Do not claim full GLB/VRM parity: bones, armatures, animations, blendshapes,
  cameras, lights, and texture conversion remain caveats.
