# Wave 312 - VRCFaceTracking Vendor Modules, Shared Memory, Vendor SDKs, and Loopback Bridges

This wave studies vendor-specific VRCFaceTracking modules as reusable
references for shared-memory ingestion, vendor DLL bootstrap, local UDP/JSON
bridges, eye-data fallback, stale gating, and slot coexistence.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- vendor-specific VRCFaceTracking headset modules;
- shared-memory, vendor SDK, and loopback transport variants;
- eye-only versus eye-plus-expression module behavior;
- local configuration, smoothing, fallback, and stale-data handling;
- slot coexistence with other tracking modules.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `BigscreenVR/VRCFT-Beyond` | Shared-memory eye-only VRCFT consumer | Studied | Minimal memory-mapped gaze/openness module that keeps vendor capture outside the module |
| `benaclejames/VRCFTPimaxModule` | Vendor DLL-backed eye-tracking VRCFT module | Studied | DLL extraction, JSON-tuned smoothing, tracking-loss fallback, and blink/wink timing |
| `UikaMisumi/DreamAirTracking.VrcftModule` | Loopback UDP/JSON VRCFT bridge module | Studied | Local JSON packet ingest, optional expression export, stale timeout, and coexistence with another lip/face module |

## Code-Level Findings

### `BigscreenVR/VRCFT-Beyond`

- Interesting idea:
  a VRCFT module can stay intentionally tiny when another process owns the
  real headset integration and publishes a stable shared-memory schema.
- Code donor value:
  medium. `BeyondExtTrackingModule.cs` opens a memory-mapped file named
  `VRCFTMemmapData`, reads a `SharedGazeData` struct with left/right/combined
  gaze vectors, confidence, timestamp, validity, and eyelid closure amounts,
  converts 3D gaze vectors into normalized 2D gaze coordinates, maps
  eyelid-closed values into openness, and writes only the eye slot of
  `UnifiedTracking`.
- Product reference value:
  high for "producer process plus very thin module" thinking. It shows that a
  module does not need to own calibration, camera access, or vendor session
  logic when those concerns can stay outside VRCFT.
- What to inspect next:
  the external producer that writes `VRCFTMemmapData`, versioning of the shared
  schema, confidence semantics, and session-loss behavior.
- Reusable pattern extraction:
  keep `shared-memory transport`, `thin consumer module`, and
  `external-producer ownership` explicit.

### `benaclejames/VRCFTPimaxModule`

- Interesting idea:
  a vendor SDK module can absorb unreliable eye data through config-driven
  smoothing, blink timers, and one-eye fallback rather than exposing raw vendor
  jitter directly to VRCFT consumers.
- Code donor value:
  high. `VRCFTPimaxModule.cs` extracts `PimaxEyeTracker.dll` into a
  deployment-local dependency directory, loads it with `LoadLibrary`,
  registers callbacks, and reads config from `VRCFTPimaxModule.json`.
  `EyeTracker.cs` applies moving averages, blink/wink timing, axis ranges,
  movement multipliers, and "mirror the other eye or last good value" fallback
  when one eye reports zero or drops out.
- Product reference value:
  high for ruggedized vendor modules and for understanding what practical
  cleanup is usually required before eye data becomes avatar-safe.
- What to inspect next:
  whether the config deserialize path is intentionally incomplete, thread
  safety around callbacks, and how errors surface when the vendor DLL or
  runtime is missing.
- Reusable pattern extraction:
  keep `vendor DLL bootstrap`, `config-tuned signal cleanup`, and
  `tracking-loss fallback heuristics` separate from VRCFT slot publication.

### `UikaMisumi/DreamAirTracking.VrcftModule`

- Interesting idea:
  a local loopback bridge can treat VRCFT as an output slot while an external
  app owns the real tracking stack and JSON packet schema.
- Code donor value:
  high. `DreamAirTrackingModule.cs` binds UDP loopback `127.0.0.1:9400`,
  receives JSON packets non-blockingly, applies sign/gain/offset and
  pupil-range options, publishes neutral values on stale data, optionally
  emits pupil diameter and eye-related expressions, and explicitly avoids
  claiming lip tracking so it can coexist with another face module.
- Product reference value:
  very high for reusable "external tracker app -> local bridge module" design,
  especially when the real tracker stack is experimental or language/toolchain
  specific.
- What to inspect next:
  the upstream Dream Air tracker app, packet schema evolution, diagnostics for
  dropped packets, and more explicit multi-module slot arbitration.
- Reusable pattern extraction:
  keep `loopback JSON transport`, `stale timeout and neutralization`, and
  `slot coexistence policy` explicit.

## Reusable Pattern Extraction

- Pattern candidate:
  vendor-specific VRCFaceTracking module boundary across shared memory, vendor
  DLLs, loopback transport, stale gating, eye fallback, and slot coexistence.
- Problem solved:
  vendor eye/face integrations are often unstable to embed directly in one
  monolithic module. Reuse gets stronger when capture, normalization, fallback,
  transport, and slot publication are separated.
- Reusable core:
  vendor signal producer, transport adapter (memory map, DLL callback, or UDP),
  schema parser, normalization layer, smoothing and fallback policy,
  stale-data detector, eye/expression slot publisher, and coexistence gates.
- Source evidence:
  `BigscreenVR/VRCFT-Beyond`, `benaclejames/VRCFTPimaxModule`, and
  `UikaMisumi/DreamAirTracking.VrcftModule`.
- Abstraction boundary:
  keep headset/vendor capture ownership, transport parsing, signal cleanup,
  stale-state policy, and VRCFT slot publication separate.
- What not to copy:
  hidden assumptions about an already-running producer, vendor DLL placement
  without diagnostics, blocking sleeps as the only pacing strategy, config
  deserialization bugs, or slot claims that ignore other active modules.
- Method catalog action:
  add a vendor VRCFT module boundary method.

## Follow-Up Gaps

- Compare these modules directly against earlier Quest Pro, PICO, Omnicept,
  Virtual Desktop, and VRCFT template references.
- Deepen the external producer side behind `VRCFT-Beyond` and
  `DreamAirTracking`.
- Revisit `VRCFTPimaxModule` for config-load correctness and failure UX when
  the vendor DLL/runtime is unavailable.
