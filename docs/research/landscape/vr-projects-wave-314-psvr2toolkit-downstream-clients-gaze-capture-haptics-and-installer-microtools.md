# Wave 314 - PSVR2Toolkit Downstream Clients, Gaze Capture, Haptics, and Installer Microtools

This wave studies downstream PSVR2Toolkit clients as reusable references for
vendor C API capture adapters, OSC/WebSocket haptic relays, signed-driver
patch management, and game-specific IPC consumers.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- PSVR2Toolkit downstream utility clients rather than the core toolkit;
- gaze-image capture consumers;
- headset rumble and adaptive-trigger consumers;
- install/uninstall/update helpers around the modified SteamVR driver;
- game-specific consumers that treat PSVR2Toolkit as a local runtime service.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `BnuuySolutions/PSVR2Toolkit.Baballonia` | PSVR2 eye-image capture adapter | Studied | Tiny C API capture provider that converts toolkit gaze-image memory into an OpenCV-backed consumer surface |
| `tabithamoon/PSVR2HeadpatHaptics` | PSVR2 headset-rumble OSC/WebSocket relay | Studied | Exposes headset rumble over OSCQuery and optional WebSockets with a small CLI utility shape |
| `MaidScientistIzutsumiMarin/psvr2toolkit-installer` | PSVR2 driver installer/rollback microtool | Studied | Signed-driver validation, reversible install/uninstall flow, GitHub release updates, and configuration toggles |
| `Kingoooooooo/Pistol-Whip-Adaptive-Triggers` | Game-specific PSVR2 adaptive-trigger IPC consumer | Studied | MelonLoader mod that maps in-game gun state to PSVR2Toolkit trigger-effect commands |

## Code-Level Findings

### `BnuuySolutions/PSVR2Toolkit.Baballonia`

- Interesting idea:
  a vendor toolkit can expose a narrow "capture provider" boundary so another
  app can consume only the gaze camera feed without importing the rest of the
  toolkit stack.
- Code donor value:
  medium-high. `Vr2Capture.cs` statically initializes the PSVR2 C API,
  launches a capture task, calls `GetGazeImage`, validates a `VI` header, skips
  a fixed image header, copies the single-channel BC4 payload into an OpenCV
  matrix, and feeds it into the host capture abstraction with minimal glue.
  `Vr2CaptureFactory.cs` shows the provider registration shape.
- Product reference value:
  high for vendor image-feed adapters and for "thin consumer around native
  capture DLL" composition.
- What to inspect next:
  frame timestamping, backpressure, actual consumer expectations inside
  Baballonia, and whether the BC4/header assumptions stay stable across toolkit
  releases.
- Reusable pattern extraction:
  keep `vendor C API`, `capture task loop`, and `host-app capture provider`
  explicit.

### `tabithamoon/PSVR2HeadpatHaptics`

- Interesting idea:
  hardware-specific haptics can be opened up as a tiny network-facing utility
  instead of being locked inside one game or avatar stack.
- Code donor value:
  high. `HeadpatOSC.cs` parses CLI flags, initializes the PSVR2Toolkit C API,
  optionally starts a WebSocket server, starts an OSCQuery service with a
  write-only avatar parameter endpoint, and maps either raw parameter values or
  derived velocity into `SetHmdRumble` frequency commands. The tool exposes a
  very small but reusable physical-output relay shape.
- Product reference value:
  high for micro-utilities, playful interaction surfaces, and safety-relevant
  haptic routing sidecars.
- What to inspect next:
  rate limiting, authentication, cool-down/panic-stop behavior, and whether
  headset rumble should be bounded by stronger consent rules.
- Reusable pattern extraction:
  keep `network endpoint`, `parameter interpretation`, and `vendor actuator
  call` separate.

### `MaidScientistIzutsumiMarin/psvr2toolkit-installer`

- Interesting idea:
  a modified runtime driver can be managed safely when the tool models it as a
  reversible swap between a signed original file and an unsigned replacement,
  with digest checks and UI locks around the critical path.
- Code donor value:
  high. `__main__.py` builds a NiceGUI desktop UI with a bindable lock, clear
  install/uninstall/update paths, release changelogs, and eyelid-estimation
  toggles. `drivers.py` resolves the Steam install path, verifies
  Authenticode-signed originals, distinguishes installed versus uninstalled
  states by signature/original backup presence, and performs reversible replace
  operations on the driver DLL.
- Product reference value:
  very high for runtime-adjacent maintenance tools, especially when a repo
  needs install-state validation and rollback instead of "copy files and hope".
- What to inspect next:
  failure recovery during replace operations, release asset assumptions,
  multi-platform path strategy, and whether more explicit backup verification is
  needed.
- Reusable pattern extraction:
  keep `driver-state validation`, `signed/original backup management`, and
  `update UI` separate.

### `Kingoooooooo/Pistol-Whip-Adaptive-Triggers`

- Interesting idea:
  game-specific state can stay outside the toolkit while a tiny consumer maps
  that state onto a shared vendor IPC vocabulary.
- Code donor value:
  medium. `Core.cs` is a MelonLoader mod that connects once to the toolkit IPC,
  watches gun and dual-wield state, disables existing effects before applying
  new ones, and selects among trigger patterns based on weapon type. The IPC
  layer (`IpcClient.cs` and `IpcProtocol.cs`) shows a local socket handshake,
  gaze-data polling cadence, and a struct-based command vocabulary for feedback,
  weapon, vibration, and multi-position effects.
- Product reference value:
  medium-high for adaptive-trigger consumers and for comparing runtime toolkit
  IPC against app-specific decision logic.
- What to inspect next:
  log volume, effect debouncing, reconnect behavior, and whether a generic
  policy layer could replace hardcoded per-gun mappings.
- Reusable pattern extraction:
  keep `game-state observer`, `local IPC client`, and `vendor command profile`
  separate.

## Reusable Pattern Extraction

- Pattern candidate:
  PSVR2 toolkit downstream client boundary across gaze capture, haptic relays,
  reversible driver patching, and game-state IPC consumers.
- Problem solved:
  vendor runtime toolkits become reusable only when clients can consume narrow
  slices such as eye images, haptics, install state, or trigger effects
  without inheriting the whole stack.
- Reusable core:
  native toolkit client boundary, local C API or TCP IPC, capture-provider
  adapter, network relay endpoint, driver validation and rollback layer,
  release-update checker, consumer-side policy logic, and explicit hardware
  command vocabulary.
- Source evidence:
  `BnuuySolutions/PSVR2Toolkit.Baballonia`,
  `tabithamoon/PSVR2HeadpatHaptics`,
  `MaidScientistIzutsumiMarin/psvr2toolkit-installer`, and
  `Kingoooooooo/Pistol-Whip-Adaptive-Triggers`.
- Abstraction boundary:
  keep toolkit core/runtime ownership, downstream capture/haptics clients,
  install-state management, and game-specific decision logic separate.
- What not to copy:
  silent driver replacement without validation, unauthenticated public haptic
  endpoints, hardcoded polling/logging loops, or game-specific trigger logic
  presented as a generic toolkit API.
- Method catalog action:
  add a PSVR2 toolkit downstream client method.

## Follow-Up Gaps

- Build a comparison matrix across PSVR2Toolkit capture, VRCFT, calibration,
  haptics, and trigger-consumer lines.
- Deepen the installer's rollback and failure UX story.
- Revisit adaptive-trigger consumers for more generic policy and safety gates.
