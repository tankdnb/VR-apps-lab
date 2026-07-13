# Wave 389: MR Templates, World Transform, and Scene-Aware Game Samples

## Theme

Mixed-reality app templates and world-aware samples: baseline MR setup,
AI/world transformation, official Scene API/MRUK showcase, and recenter/mesh
caveats.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `noritsune/quest-mr-template` | Studied | Small Unity MR template with MRUK setup and recentering caveats |
| `DecartAI/Decart-XR` | Studied | Quest real-time AI world transformation sample with WebRTC/voice/service boundary |
| `oculus-samples/Unity-TheWorldBeyond` | Studied | Official MR showcase with Scene API, Passthrough, Voice SDK, Interaction SDK, and Audio Spatializer |

## Dedupe Notes

MRUK and Depth API samples were already studied. This wave looks at template
shape, world transformation product framing, and an official scene-aware sample
as an MR app composition reference.

## Code-Level Findings

### `noritsune/quest-mr-template`

- Interesting idea: a small MR template can encode practical setup warnings,
  such as MRUK recenter behavior causing scene mesh/world mismatch.
- Code donor value: `Assets`, `Packages`, `ProjectSettings`,
  `RuntimeActionBindings.json`, and README setup notes show a compact MR
  baseline.
- Product reference value: useful for future starter templates that should
  document platform quirks before code.
- What to inspect next: MRUK prefab layout, interaction building blocks,
  recenter disable setting, and runtime action binding defaults.
- Caveat: Japanese README/setup notes need careful translation before reuse.

### `DecartAI/Decart-XR`

- Interesting idea: real-time world transformation can be framed as a Quest
  app plus external AI/WebRTC service boundary rather than a local shader only.
- Code donor value: `DecartAI-Quest-Unity`, `assets`, README latency/product
  framing, and included Meta Voice/WebSocket code show a service-backed MR
  transformation envelope.
- Product reference value: good reference for future live-filter/passthrough
  utilities that need latency, privacy, and provider state.
- What to inspect next: WebRTC pipeline, provider auth, frame transform timing,
  fallback mode, and voice command role.
- Caveat: vendor AI/service dependencies and credentials must stay outside
  reusable utility code.

### `oculus-samples/Unity-TheWorldBeyond`

- Interesting idea: a vendor MR sample can serve as a composition map for Scene
  API, Passthrough, Voice SDK, Interaction SDK, Audio Spatializer, and MRUK.
- Code donor value: `Assets`, `Documentation`, `Media`, `Packages`, and
  `ProjectSettings` show a large official reference project and setup path.
- Product reference value: useful for deciding how much vendor sample structure
  is appropriate in `VR-apps-lab` examples.
- What to inspect next: scene anchors, voice triggers, audio spatializer usage,
  scene-object mapping, and sample dependency gates.
- Caveat: large official samples are reference ecosystems, not minimal donors.

## Reusable Pattern Extraction

- Pattern candidate: MR template and world-transformation envelope.
- Problem solved: MR apps need explicit setup, recenter rules, room/scene data,
  passthrough state, service/provider boundaries, and fallback UX.
- Reusable core: MR template, runtime action bindings, MRUK scene bootstrap,
  recenter policy, room mesh caveat, world transform service, WebRTC pipeline,
  voice trigger, scene anchor map, and dependency gate.
- Source evidence: `quest-mr-template` `RuntimeActionBindings.json` and setup
  notes, `Decart-XR` Quest Unity/service folders, and `Unity-TheWorldBeyond`
  documentation/project layout.
- Abstraction boundary: MR scene bootstrap and provider/service adapters should
  be separate from domain-specific gameplay or AI styling.
- What not to copy: hidden recenter behavior, service credentials, full vendor
  sample bulk, or world-transform claims without latency/fallback labels.
- Method catalog action: add Method 834.

## Family Placement

Creates an MR template/world-transform family. It connects setup templates,
MRUK composition, and provider-backed world filters.

## Follow-Up Gaps

- Draft an MR template checklist with recenter, action bindings, scene mesh,
  passthrough, and fallback labels.
- Compare world transform service boundaries with Quest vision streaming.
- Separate vendor showcase dependencies from minimal MR utility baselines.
