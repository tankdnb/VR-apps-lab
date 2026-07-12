# Wave 323 - Narrow OpenXR API Layers, Cockpit Anchors, Inline Profilers, and Game Injection Toolkits

This wave studies narrow runtime/game-layer projects that change one important
thing: treadmill locomotion, seated cockpit anchoring, layer profiling, or
minimal-injection video/overlay plumbing.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- narrow OpenXR API layers with explicit hook points;
- cockpit/reference-space anchoring helpers;
- inline profiling libraries for API layers;
- game injection toolkits that isolate heavy work outside the target process;
- projects not already tracked in registry/families.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Majed6/KATOXR` | OpenXR treadmill-to-stick input micro-layer | Studied | Strong donor for action-state interception, HMD-relative velocity conversion, calibration, and OpenComposite compatibility handling |
| `robogears/cockpit-anchor` | OpenXR seated cockpit anchoring layer | Studied | Strong donor for STAGE-space anchor capture, LOCAL-space rebasing, hotkey/audio feedback, shared/per-game anchor files, and control-panel sidecar |
| `mledour/xrprof` | Inline OpenXR API-layer profiler library | Studied | Strong donor for CPU/GPU RAII scopes, per-session probes, CSV traces, D3D11/D3D12 attachment seams, and layer-owned profiling config |
| `AndrewAltimit/game-mods` | Minimal-injection game overlay/toolkit architecture | Studied | Strong architecture reference for keeping injected code minimal while daemons, IPC, shared memory, video decode, and overlays do heavy work |

## Code-Level Findings

### `Majed6/KATOXR`

- Interesting idea:
  treadmill locomotion can be injected as an OpenXR API layer by tracking
  locomotion actions and overriding left-hand stick values from external KAT
  device state.
- Code donor value:
  high. `layer_main.cpp` intercepts action creation, suggested bindings,
  action sync, action-state reads, frame waits, and view/location calls.
  `Treadmill.cpp` converts body/device movement into HMD-relative stick input,
  clamps vector magnitude, handles calibration, and uses trailing stop logic.
- Product reference value:
  high for input remappers, locomotion adapters, and vendor-device enhancement
  layers.
- What to inspect next:
  layer negotiation/manifest details, multi-runtime behavior, lifecycle under
  session churn, and user-facing calibration UX.
- Reusable pattern extraction:
  keep `external device poll`, `HMD/reference pose`, `action detection`,
  `input override`, and `calibration state` separate.

### `robogears/cockpit-anchor`

- Interesting idea:
  a seated/cockpit utility can persist a physical seat anchor in STAGE space and
  rebase game LOCAL spaces onto that anchor so the cockpit returns to the same
  real-world seat.
- Code donor value:
  very high. `layer.cpp` captures anchors to `%LOCALAPPDATA%`, supports shared
  versus per-game anchor files, hooks reference-space/session/view functions,
  starts a hotkey thread, uses audio feedback for save/bypass states, and
  includes Virtual Desktop bounce handling as a documented workaround.
- Product reference value:
  very high for seated VR calibration, cockpit tools, operator controls, and
  persistent-space utilities.
- What to inspect next:
  UI sidecar config, game allowlist behavior, anchor-mode migration, and how
  this compares with non-game seated calibration tools.
- Reusable pattern extraction:
  keep `anchor capture`, `anchor persistence`, `reference-space rebasing`,
  `bypass/calibration hotkeys`, and `operator sidecar` separate.

### `mledour/xrprof`

- Interesting idea:
  API layers need inline self-profiling that measures the layer's own CPU/GPU
  work without adding a separate submission or external monitor.
- Code donor value:
  high. `xrprof.h` exposes `Probe::Create`, live enable toggles, D3D11/D3D12
  attachment points, `CpuScope`, `GpuScope`, and `endFrame(displayTime)` with
  CSV output owned by the consuming layer.
- Product reference value:
  high for runtime-tool diagnostics, layer development, and performance
  investigations.
- What to inspect next:
  implementation details in `src/xrprof.cpp`, CSV schema, async GPU resolve,
  and overhead when disabled.
- Reusable pattern extraction:
  keep `probe`, `config`, `CPU/GPU scopes`, `frame commit`, and `trace output`
  independent from the layer's business logic.

### `AndrewAltimit/game-mods`

- Interesting idea:
  game retrofit tooling is safer when injected code remains minimal and heavy
  work moves to external daemons, shared memory, IPC, and optional overlays.
- Code donor value:
  very high as architecture reference. The repo names reusable crates for
  protocol, shared memory, IPC, sync, video, networking, daemon, overlay, and
  platform injectors. The README and architecture describe a launcher,
  daemon, injector, and overlay split with single-writer seqlock shared memory
  and crash-isolated processes.
- Product reference value:
  high for video-in-cockpit tools, game-specific VR overlays, and controlled
  retrofit experiments.
- What to inspect next:
  seqlock implementation, Vulkan/OpenVR hooks, wire protocol evolution, and
  game-specific No Man's Sky cockpit video flow.
- Reusable pattern extraction:
  keep `injected shim`, `daemon`, `shared memory`, `IPC command plane`,
  `overlay`, and `launcher` separate.

## Reusable Pattern Extraction

- Pattern candidate:
  narrow runtime/game-layer boundary across interception point, external data,
  calibration or profiling state, persistent config, and safety/operator
  controls.
- Problem solved:
  runtime helpers become risky when invasive hooks own too much policy or when
  heavy work happens inside the target process.
- Reusable core:
  hook/intercept layer, external device or daemon source, calibration or anchor
  state, action/reference-space mapping, inline probe scopes, persistent files,
  operator hotkeys/UI, IPC/shared-memory transport, and rollback/bypass paths.
- Source evidence:
  `Majed6/KATOXR`, `robogears/cockpit-anchor`, `mledour/xrprof`, and
  `AndrewAltimit/game-mods`.
- Abstraction boundary:
  keep invasive runtime hooks narrow and move heavy processing, UI, logging,
  and policy into external or clearly separated components.
- What not to copy:
  global API-layer state without lifecycle guards, hidden input overrides,
  unbounded injected-process work, or game/runtime workarounds presented as
  general-purpose behavior without capability gates.
- Method catalog action:
  add OpenXR micro-layer and minimal-injection toolkit methods.

## Follow-Up Gaps

- Compare treadmill locomotion layers with other OpenXR action remappers.
- Deepen seated/cockpit anchoring as a calibration family.
- Use `xrprof` as a reference when designing profiling hooks for future
  API-layer prototypes.
- Compare ITK-style minimal injection against other VR game retrofit projects.
