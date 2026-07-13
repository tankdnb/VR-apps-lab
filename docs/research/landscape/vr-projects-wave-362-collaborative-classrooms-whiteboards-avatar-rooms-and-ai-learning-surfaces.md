# Wave 362: Collaborative Classrooms Whiteboards Avatar Rooms and AI Learning Surfaces

## Scope

This wave studies classroom and whiteboard projects where the reusable value is
a shared learning surface: room/session setup, avatar presence, pen/board
interaction, reset/debug controls, AI tutor adapters, and network/voice package
boundaries.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `SimonCzy/Whiteboard-UnityXR` | Studied | Oculus/Photon/Meta Avatar whiteboard with board creation gesture, pen texture writing, poke/grab interaction, voice/network dependencies, and reset/debug controls |
| `AnnavarapuGanesh/VR-CLASSROOM` | Studied | Unity classroom with Gemini AI tutor adapter, room/lobby scripts, board/text framing, and single-user/multiplayer boundary caveats |
| `AnnavarapuGanesh/VR-CLASSROOM-MULTIPLAYER` | Partially studied | Multiplayer classroom variant with Photon-style room/avatar direction and AI-powered learning environment framing |

## Reusable Pattern Extraction

- Pattern candidate: `collaborative classroom and whiteboard surface shell`.
- Problem solved: educational VR tools need a shared surface and room context
  before lessons, AI tutors, voice chat, or multiplayer interactions become
  coherent.
- Reusable core: room/session manager, participant/avatar spawner, entitlement
  gate, board creation gesture, board object model, pen/touch sampler,
  texture/stroke writer, reset/debug controls, network authority, voice channel,
  AI tutor adapter, prompt/response history, and privacy/credential labels.
- Source evidence: Whiteboard-UnityXR includes `Pen`, `NetworkAvatarSpawner`,
  `ConnectionManager`, and user entitlement scripts; VR-CLASSROOM includes
  Gemini request/response data classes and Photon room utilities; the
  multiplayer variant confirms the same classroom surface as a network branch.
- Abstraction boundary: board drawing should be separate from networking; AI
  tutor requests should be separate from room/session state; avatar presence
  should not own educational content.
- What not to copy: API keys, vendor package trees, hardcoded room names,
  duplicated typo scripts, or networked classroom claims without authority,
  failure, and privacy states.
- Method catalog action: create a new classroom/whiteboard surface method.

## Project Notes

### `SimonCzy/Whiteboard-UnityXR`

- Interesting idea: users can create/pull out a whiteboard by drawing a
  horizontal gesture, then draw on it with a pen while avatars, voice, and
  Photon packages provide a collaboration shell.
- Code donor value: high for pen texture-writing, board reset/debug controls,
  avatar spawner, connection manager, entitlement check, and interaction
  packaging.
- Product reference value: strong for shared board utilities, teaching rooms,
  and collaborative annotation surfaces.
- What to inspect next: stroke synchronization, board ownership, eraser/undo,
  voice failure states, and multi-board persistence.
- Caveats: vendor-heavy Oculus/Photon/Meta Avatar stack; reuse boundaries and
  flow, not package assumptions.

### `AnnavarapuGanesh/VR-CLASSROOM`

- Interesting idea: a classroom shell combines 3D room framing with a Gemini AI
  tutor and simple room/lobby scripts.
- Code donor value: moderate for AI tutor request/response wrapper, prompt
  history, and classroom product framing.
- Product reference value: useful for AI tutor surfaces and web/mobile/VR
  learning direction.
- What to inspect next: credential hygiene, prompt lifecycle, board content
  binding, and whether XR Toolkit support is implemented or aspirational.
- Caveats: source contains typo/duplicate room scripts and service-key risk;
  do not copy credentials or assume production-ready AI handling.

### `AnnavarapuGanesh/VR-CLASSROOM-MULTIPLAYER`

- Interesting idea: the classroom concept is extended toward real-time avatars,
  Photon rooms, virtual board, and AI tutor interaction.
- Code donor value: moderate as a networked-classroom variant and follow-up
  direction.
- Product reference value: useful for comparing single-user AI tutoring against
  shared classroom surfaces.
- What to inspect next: room authority, avatar sync, board stroke sync, AI
  request ownership, and user identity model.
- Caveats: treated as a partial study because the important signal is the
  product/family variant, not a fully isolated reusable code module yet.

## Product Direction

This wave supports a `collaborative classroom surface` branch: future tools can
reuse a neutral room, participant, board, pen stroke, AI-response, and reset
schema before choosing Photon, WebSocket, OSC, or another transport.

