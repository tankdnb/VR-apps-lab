# GitHub Research Wave 219 Plan

Date: 2026-06-06

Theme: VRChat external content ingress: image, GLB, synced texture, and
avatar-data surfaces.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

VRChat worlds often need external or late-bound content even when the runtime
restricts file IO, arbitrary decoding, and network behavior. The reusable
question is how projects move data into world surfaces: URL images, captions,
runtime model reconstruction, synced textures, persisted URL inputs, and
avatar-thumbnail encoded text.

Wave 219 studies external content ingress patterns and documents their product
and implementation boundaries.

## Search Families

- VRChat image downloaders and gallery surfaces.
- VRChat URL input and persistence surfaces.
- Runtime GLB/VRM model loaders.
- Texture synchronization packages.
- Avatar image/text encoding and decoding.
- World surfaces for externally controlled content.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `vrchat-community/examples-image-loading` | Official remote image/caption slideshow sample using `VRCImageDownloader`, `VRCStringDownloader`, cached textures, server-time slide selection, and GitHub Pages hosting. | Minimal URL image surface |
| `vr-voyage/vrchat-glb-loader` | Runtime GLB/VRM model loader that reconstructs meshes, materials, textures, and scenes inside VRChat with preconverted texture constraints. | Runtime model ingress |
| `DrBlackRat/VRC-Picture-Loader` | Productized VPM image loader with manager/lite/url-input/persistence/tablet modes, texture settings, loading/error textures, and UI. | Productized image ingress UX |
| `Narazaka/SyncTexture` | Texture2D synchronization package using chunked color encoding, async GPU readback or GetPixels, progress, manager sequencing, and late-join support. | Synced texture surface |
| `Miner28/AvatarImageReader` | Avatar thumbnail image text encoder/decoder with editor encoder, runtime pedestal texture readback, UTF-8/UTF-16 decoding, avatar chaining, and deprecation caveat. | Avatar image data carrier |

## Dedupe Notes

`Miner28/AvatarImageReader` was partially studied earlier; this wave deepens it
as an external-content data carrier and records the README deprecation note.
The other shortlisted projects were not already represented as studied nodes.

## Code-Level Pass Targets

- `VRCImageDownloader` lifecycle, texture caching, callback receiver, and
  material/UI application.
- URL input ownership, lock, persistence, network sync, and tablet UX.
- GLB parse states, DataDictionary/DataList parsing, material/texture
  extension handlers, and unsupported asset limitations.
- SyncTexture chunking, color encoders, progress, manager sequencing, receive
  callbacks, and late-join behavior.
- Avatar-image encoder header/data layout, runtime render-texture readback,
  avatar chaining, platform capacity, and decode loops.

## Expected Outputs

- Wave 219 landscape synthesis.
- Registry/family entries for VRChat external content ingress surfaces.
- Method catalog entry for external content ingress through image/model/texture
  and avatar-data surfaces.
- Follow-up backlog for a VRChat content-ingress matrix.
