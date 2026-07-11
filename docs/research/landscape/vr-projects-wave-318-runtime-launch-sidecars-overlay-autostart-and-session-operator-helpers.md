# Wave 318 - Runtime Launch Sidecars, Overlay Autostart, and Session Operator Helpers

This wave studies small operator-facing runtime helpers as reusable references
for autostart hooks, launch orchestration, runtime switching, overlay-sidecar
companions, and session-control UX.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- runtime-attached launch and shutdown helpers;
- overlay-sidecar operator utilities that react to runtime/session state;
- runtime switching or install/orchestration helpers;
- thin launcher-style product references that expose useful session-control UX.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `dreiekk/OpenVR-Autostarter` | OpenVR autostart and task-orchestration sidecar | Studied | Strong donor for runtime-detection hooks, manifest registration, and start/stop task policy |
| `Eidenz/monadeck` | Linux runtime and game-orchestration control shell | Studied | Strong donor for shared core plus operator UI, OpenXR runtime switching, install/recovery policy, and game launch orchestration |
| `Eidenz/monado-frame` | Overlay companion for screenshots and gesture config | Studied | Strong donor for file-decoupled overlay helpers, input arbitration, and runtime-aware wrist/surface panels |
| `EllieWasteland/CaronteLauncherVR` | Thin launcher/product-reference shell | Studied | Source-light but useful product reference for runtime choice, capture-method choice, profile/addon loading, and session bring-up UX |

## Code-Level Findings

### `dreiekk/OpenVR-Autostarter`

- Interesting idea:
  a runtime-adjacent sidecar does not need deep graphics logic to be valuable;
  it can simply bind to runtime lifecycle and make start/stop policy explicit.
- Code donor value:
  high. `MainForm.cs` shows the key shape clearly: poll for OpenVR runtime
  availability, register a manifest, enable autostart, launch configured tasks
  on first runtime connect, watch `VREvent_Quit`, and stop tasks on shutdown.
  `AutostarterConfig.cs`, `AutostartTask.cs`, and stop-policy handling expose
  useful small patterns such as prevent-already-running, graceful-close loops,
  optional force-kill, reverse mode, and hidden/background operation.
- Product reference value:
  high for session bring-up utilities, app launch coordinators, and runtime
  micro-helpers that exist mainly to start or stop the right supporting tools.
- What to inspect next:
  task failure/retry reporting, richer dependency ordering, and whether the
  same orchestration pattern maps cleanly to OpenXR-centric stacks.
- Reusable pattern extraction:
  keep `runtime watcher`, `task registry`, and `start/stop policy` separate.

### `Eidenz/monadeck`

- Interesting idea:
  an operator shell can share one core between desktop and in-headset surfaces
  while still keeping runtime switching, install state, and per-game launch
  logic explicit.
- Code donor value:
  high. `active_runtime.rs` is especially strong: it manages
  `active_runtime.json`, preserves backups, prefers symlink-based runtime
  switching, and avoids clobbering existing state. The broader core makes Steam
  library scanning, compatdata inspection, game launchability, and optional
  UEVR injection explicit instead of burying them in a UI layer.
- Product reference value:
  very high for Linux-focused XR operator shells, runtime managers, and
  hybrid desktop-plus-in-headset control surfaces.
- What to inspect next:
  the overlay/dashboard crate boundaries, install/update state handling, and
  how runtime-switch rollback should be generalized for other stacks.
- Reusable pattern extraction:
  keep `runtime switcher`, `library/game inventory`, `launch policy`, and
  `desktop/in-headset surface adapters` separate.

### `Eidenz/monado-frame`

- Interesting idea:
  an overlay helper can deliver value by watching files and writing config into
  another runtime-owned subsystem instead of tightly embedding itself into the
  runtime.
- Code donor value:
  very high. `config.rs` makes the split between gesture config and app-local
  settings explicit. The project watches screenshot output and writes gesture
  config as a decoupled sidecar path. `blocker.rs` is an especially strong
  donor: input arbitration is tied to runtime client state via libmonado, so
  the helper blocks the active visible non-overlay session without brittle
  name-matching.
- Product reference value:
  very high for wrist panels, screenshot-review helpers, file-decoupled
  operator surfaces, and input-sensitive overlay companions.
- What to inspect next:
  overlay lifecycle and panel routing in `main.rs`, screenshot-processing
  queues, and how far the file-coupled sidecar pattern can be generalized to
  other runtime-owned assets.
- Reusable pattern extraction:
  keep `external file contract`, `overlay helper UI`, and `input arbitration`
  separate.

### `EllieWasteland/CaronteLauncherVR`

- Interesting idea:
  even a source-light launcher can reveal the user-facing sequence that makes a
  complex VR bring-up feel manageable: choose runtime, choose capture path,
  load a view profile, add a game-specific addon, then attach to the surface.
- Code donor value:
  low. The visible repository is mostly website/product framing rather than the
  runtime/helper implementation itself.
- Product reference value:
  medium-high. The drag-and-drop addon framing, capture/runtime selection, and
  "connect after the game is ready" UX are useful session-operator ideas even
  though the repo is not a strong code donor.
- What to inspect next:
  whether the actual launcher/runtime code is published elsewhere, how addon
  profiles are structured, and which parts of the wizard flow should become a
  generic operator-helper pattern.
- Reusable pattern extraction:
  keep this one as `wizard UX and product framing`, not as a main
  implementation donor.

## Reusable Pattern Extraction

- Pattern candidate:
  runtime operator sidecar boundary across runtime detection, autostart hooks,
  task orchestration, runtime switching, file-coupled overlay helpers, and
  session bring-up UX.
- Problem solved:
  XR operator tools become fragile when runtime probing, process orchestration,
  overlay helper logic, and rollback/recovery behavior are fused into one
  monolith.
- Reusable core:
  runtime watcher, manifest or activation hook, task registry, start/stop
  policy, runtime switcher with backup/restore, library or session inventory,
  overlay or helper UI, file-based companion contract, input arbitration, and
  operator-facing setup wizard.
- Source evidence:
  `dreiekk/OpenVR-Autostarter`, `Eidenz/monadeck`,
  `Eidenz/monado-frame`, and `EllieWasteland/CaronteLauncherVR`.
- Abstraction boundary:
  keep runtime lifecycle detection, task policy, runtime switching, overlay
  helper surfaces, and wizard/product framing separate.
- What not to copy:
  runtime-switch writes without backup/restore, task orchestration with hidden
  kill behavior, input blocking tied to app-name heuristics when better runtime
  state exists, or product-copy UX treated as sufficient implementation
  architecture.
- Method catalog action:
  add a runtime operator sidecar method.

## Follow-Up Gaps

- Compare Windows/OpenVR task-orchestration helpers against Linux/OpenXR
  runtime-switching helpers more directly.
- Deepen `monadeck` dashboard and install/update boundaries.
- Revisit file-coupled overlay companions as a broader pattern for
  screenshot-driven, config-writing, or asset-review helpers.
