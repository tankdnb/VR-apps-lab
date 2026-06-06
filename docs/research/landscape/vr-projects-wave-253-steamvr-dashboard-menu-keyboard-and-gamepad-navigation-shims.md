# VR Projects Wave 253: SteamVR Dashboard Menu Keyboard And Gamepad Navigation Shims

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies narrow SteamVR dashboard and menu-control helpers: keyboard
navigation shims, Quest system-button forwarding, synthetic gamepad-to-controller
drivers, keyboard layout patching, and dashboard volume routing.

## Why It Matters For `VR-apps-lab`

SteamVR utility UX often lives in the seams between dashboard input, system
buttons, web dashboard resources, and audio/session controls. These projects
show how small helpers can solve one missing input path without becoming full
overlay products.

## Project Notes

### `mbucchia/SteamVR-Dashboard-KeyboardNav`

- Interesting idea:
  a shim driver wraps an existing HMD driver so the SteamVR dashboard can be
  navigated with keyboard/facemouse-style input.
- Code donor value:
  `driver_shim/Driver.cpp` exposes `HmdDriverFactory` and installs a
  `TrackedDeviceAdded` hook. `HmdShimDriver.cpp` wraps the HMD driver, sets a
  custom input profile, creates `/input/system/click`, creates a shared-memory
  mapping, and launches `client_utility.exe`. `client_utility.cpp` runs as a
  background OpenVR app, installs a low-level keyboard hook for the Windows
  key, toggles dashboard visibility, and writes click events through shared
  memory.
- Product reference value:
  strong donor for "driver shim plus tiny companion process" architecture.
- What to inspect next:
  compare with safer app-level dashboard control paths and SteamVR version
  compatibility risk.
- Reusable pattern:
  early-loaded OpenVR shim -> input profile override -> shared-memory command
  flag -> background utility.
- Caveats:
  low-level keyboard hooks, runtime driver hooking, early load ordering, and
  Windows-specific implementation.

### `lmore377/quest-steamvr-system-button`

- Interesting idea:
  Quest system-button logcat events can be translated into SteamVR dashboard
  toggles for OculusKiller/Link workflows.
- Code donor value:
  `oculus-button-watcher.py` connects to ADB, reads Quest logcat lines for
  `SetHomeButtonDownState` and `SetHomeButtonUpState`, checks whether
  `vrdashboard.exe` is running, and dispatches
  `vrmonitor://debugcommands/system_dashboard_toggle`.
- Product reference value:
  useful micro-utility reference for event-source adapters around platform
  quirks.
- What to inspect next:
  add robust device selection, reconnect/backoff, and avoid shelling through
  browser URI commands without user-visible state.
- Reusable pattern:
  external platform log event -> state gate -> SteamVR debug URI.
- Caveats:
  Quest/ADB/OculusKiller specific, bundled executable, brittle log strings,
  and potential conflict with Oculus dashboard behavior.

### `AJBats/pad-vr`

- Interesting idea:
  a conventional XInput gamepad can be exposed to SteamVR as a synthetic
  Index-style controller for dashboard navigation and gamepad-friendly VR
  games.
- Code donor value:
  `src/PadVRProvider.cpp` registers a controller device. `PadVRController.cpp`
  sets model/manufacturer/controller type, exposes trigger/system/thumbstick
  components, reports a chest-mounted pose derived from HMD pose, zeros stale
  input when inactive, and mirrors thumbstick/joystick paths. `TriggerIPC.cpp`
  reads a shared-memory state block. `companion/main.cpp` polls XInput only
  while SteamVR is running, handles Guide-button tap/hold dashboard/recenter
  actions, and writes trigger/stick state with sequence counters.
- Product reference value:
  strong donor for synthetic controller boundary and passive companion gating.
- What to inspect next:
  compare with OpenVR2Key and no-HMD drivers for input ownership conflicts.
- Reusable pattern:
  gamepad companion -> shared memory -> synthetic OpenVR controller -> input
  profile.
- Caveats:
  steals right-hand controller role when active, requires disabling SteamVR
  built-in gamepad driver, and has UEVR-specific caveats.

### `MagnaLunas/SteamVRKeyboardLayoutChanger`

- Interesting idea:
  SteamVR's dashboard keyboard layout can be patched by replacing dashboard web
  resources and layout JSON.
- Code donor value:
  `keyboard.js` is a bundled dashboard web resource and
  `keyboards/layout_base_overlay*.json` provide alternate keyboard layouts.
  README documents copying files into SteamVR dashboard resources, clearing
  HTML cache, and marking files read-only.
- Product reference value:
  useful historical reference for dashboard web-resource patching.
- What to inspect next:
  study only as an example of why utility docs must separate supported API use
  from fragile resource replacement.
- Reusable pattern:
  dashboard web asset replacement -> cache invalidation -> alternate layout.
- Caveats:
  explicitly obsolete after SteamVR 2.0, fragile against updates, and not a
  recommended implementation path.

### `bpbwaite/ahk-svrvmr`

- Interesting idea:
  the SteamVR dashboard volume slider can be repurposed to control a
  Voicemeeter bus gain curve for HMD audio.
- Code donor value:
  `SVRVMR.ahk` loads Voicemeeter Remote DLLs, logs in, polls the Windows master
  volume through Vista Audio Library, maps normalized volume through an
  exponential gain curve, clamps to -60..0 dB, and calls
  `VBVMR_SetParameterFloat` for a configurable bus.
- Product reference value:
  useful micro-utility reference for using an existing dashboard slider as a
  proxy control for a real audio backend.
- What to inspect next:
  compare with modern dashboard audio APIs and explicit user feedback.
- Reusable pattern:
  dashboard/OS volume value -> transform curve -> external audio backend
  parameter.
- Caveats:
  AutoHotkey, Windows-only DLL calls, Voicemeeter dependency, and no VR-visible
  status beyond the dashboard slider.

## Reusable Pattern Extraction

- Pattern candidate:
  SteamVR dashboard control shim with explicit input ownership boundary.
- Problem solved:
  users need dashboard/menu/audio control from alternate input devices or
  platform buttons that SteamVR does not handle well by default.
- Reusable core:
  event source, activation gate, runtime command adapter, input profile or
  dashboard patch, state feedback, cleanup, and conflict caveats.
- Source evidence:
  `SteamVR-Dashboard-KeyboardNav`, `quest-steamvr-system-button`, `pad-vr`,
  `SteamVRKeyboardLayoutChanger`, and `ahk-svrvmr`.
- Abstraction boundary:
  keep external input capture outside the driver where possible, and make
  synthetic controller/dashboard ownership explicit.
- What not to copy:
  obsolete dashboard asset replacement, hidden global hooks, broad shell URI
  dispatch, or input stealing without a visible disable path.
- Method catalog action:
  add a method for dashboard/menu navigation shims.

## Family Placement

This wave extends SteamVR operational support, VR command surfaces, and
runtime-dashboard helper families. It overlaps with earlier OpenVR overlay
work, but focuses on menu/control input rather than display surfaces.

## Follow-Up Gaps

- Build a comparison matrix for dashboard control paths: driver shim, debug
  URI, synthetic controller, web-resource patch, and external audio proxy.
- Extract an "input ownership" checklist for SteamVR helper tools.
- Compare gamepad/keyboard dashboard shims with accessibility and no-controller
  workflows.
