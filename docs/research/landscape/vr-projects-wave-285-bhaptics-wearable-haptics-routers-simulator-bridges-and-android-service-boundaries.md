# Wave 285 - bHaptics Wearable Haptics Routers, Simulator Bridges, and Android Service Boundaries

This wave studies bHaptics and wearable-haptics projects as reusable references
for event-to-pattern routing, simulator telemetry, VRChat/avatar haptics,
WebSocket/player APIs, Unreal/Unity packaging, and Android bound-service
interfaces.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- bHaptics player/client transport boundaries;
- simulator telemetry to haptic pattern routers;
- VRChat/avatar haptic event surfaces;
- Unity/Unreal package and asset references;
- Android haptic service interfaces for standalone VR ports.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `cercata/pysim2bhap` | Simulator telemetry to bHaptics router | Studied | Thresholded flight/car telemetry mapped to registered `.tact` patterns |
| `HerpDerpinstine/bHapticsLib` | C# bHaptics WebSocket client | Studied | Queue/cache boundary for register/submit/stop/device status APIs |
| `NovaVoidHowl/VRCBhapticsIntegration` | VRChat avatar-to-bHaptics integration | Studied | Camera/render-texture motor parsing and avatar package helper |
| `Team-Beef-Studios/HapticsService` | Android bound haptic service | Studied | AIDL boundary for app-independent haptic events on Quest/Android ports |
| `SeekND/YAWVR-and-BHaptics-addons` | Input/motion simulator haptic scripts | Studied with script caveats | Direct dot motor patterns from keyboard, mouse, joystick, and simulator state |
| `bhaptics/TactUnrealEngine4` | Unreal bHaptics content/plugin reference | Studied with blueprint-heavy caveat | Device UI, feedback assets, pairing panels, and packaged `.uasset` references |

## Code-Level Findings

### `cercata/pysim2bhap`

- Interesting idea:
  simulator telemetry is normalized into named haptic events with thresholds,
  force/duration multipliers, registered `.tact` files, and alternate keys.
- Code donor value:
  high: `baseBHap.py` shows a reusable `BaseSim` class with pattern
  registration, `play` scale/rotation options, impact/RPM/AoA/speed/G-force
  mapping, and full-arms/car variants; `Sim2bHap.py` shows config presets,
  simulator module selection, and Tk status logging.
- Product reference value:
  high for telemetry-to-haptics companions, cockpit tools, racing/flight
  feedback, and user-tunable thresholds.
- What to inspect next:
  per-simulator modules, `.tact` pattern naming, stale telemetry behavior, and
  how it avoids overwhelming the player API.

### `HerpDerpinstine/bHapticsLib`

- Interesting idea:
  the bHaptics player is wrapped as a threaded WebSocket connection with
  register and submit queues, pattern cache, reconnect policy, device status,
  and frame/dot/key APIs.
- Code donor value:
  very high: `bHapticsConnection.cs` shows `RegisterQueue`, `SubmitQueue`,
  `RegisterCache`, reconnect settings, `WebSocketConnection`, device status
  reads, pattern registration from `.tact` JSON, swapped patterns, dot/path
  frame submission, and stop/turn-off APIs.
- Product reference value:
  high for any wearable-haptics router that needs to decouple event production
  from player connectivity.
- What to inspect next:
  `WebSocketConnection`, request/response packet schema, thread shutdown,
  retry/backoff, and how device status should be exposed in UI.

### `NovaVoidHowl/VRCBhapticsIntegration`

- Interesting idea:
  VRChat avatar haptics are represented through avatar cameras/render textures
  and parsed into bHaptics motor values, with Unity editor helpers for VRChat
  layers and package setup.
- Code donor value:
  medium/high: `Project/Main.cs` hooks VRChat avatar instantiation via MelonMod
  and Harmony, searches avatar cameras by configured render texture names, and
  attaches `VRCBhaptics_CameraParser`; `CameraParser.cs` reverses/normalizes
  pixel arrays by haptic position and submits values; Unity helper scripts set
  VRChat layers.
- Product reference value:
  high for avatar-authored haptic event surfaces and "visual/haptic motor map"
  UX, with modding caveats.
- What to inspect next:
  `Config.cs`, render-texture naming contract, camera pixel format, consent
  and moderation risk, and modern VRChat compatibility.

### `Team-Beef-Studios/HapticsService`

- Interesting idea:
  standalone Android VR ports can call a common external haptic service through
  AIDL rather than embedding each game's haptics transport directly.
- Code donor value:
  high: `IHapticService.aidl` defines `hapticEvent`, update, stop, frame tick,
  enable, and disable calls; `HapticServiceClient.java` shows bind/unbind,
  service connection callbacks, and remote service state handling.
- Product reference value:
  high for Quest helper services, game-port haptic bridges, and permissioned
  wearable-output boundaries.
- What to inspect next:
  concrete service implementation, application/event naming conventions,
  intensity/angle/y-height semantics, safety gates, and failure UX when the
  service is missing.

### `SeekND/YAWVR-and-BHaptics-addons`

- Interesting idea:
  small Python scripts can turn keyboard, mouse, joystick, and motion-platform
  states into immediate dot haptic frames without a full game integration.
- Code donor value:
  medium: `bhaptics.py` shows direct `player.submit_dot` calls, joystick axis
  mapping to intensity, key toggles, weapon-like pattern sequences, and simple
  timing loops.
- Product reference value:
  medium for micro-utility haptic routing and quick cockpit/game feedback
  prototypes.
- What to inspect next:
  YawVR integration scripts, debouncing, safety stop, user remapping, and
  whether event loops can starve or spam the haptic player.

### `bhaptics/TactUnrealEngine4`

- Interesting idea:
  the official Unreal integration is valuable as a content/package reference:
  pairing UI, feedback effect assets, device visualization, and example
  blueprints.
- Code donor value:
  low/medium in this pass because the inspected repository is heavily `.uasset`
  based and exposes limited readable custom source.
- Product reference value:
  high for Unreal-side UX inventory: Android pairing UI, device list panels,
  feedback assets, visualize widgets, and example player content.
- What to inspect next:
  generated/plugin source if available, Blueprint graph details, device pairing
  state, and how the integration handles Android permissions.

## Reusable Pattern Extraction

- Pattern candidate:
  wearable haptics routing boundary across event sources, tact patterns,
  player APIs, avatar triggers, and Android services.
- Problem solved:
  haptic feedback often starts from many unrelated event sources: simulator
  telemetry, avatar render targets, keyboard/mouse/joystick input, game ports,
  or Unreal/Unity triggers. A reusable router needs to normalize events,
  enforce safety, and decouple device/player connectivity from event logic.
- Reusable core:
  event schema, source adapter, registered pattern catalog, direct frame/dot
  fallback, intensity/duration/angle scaling, device-position map, queue and
  reconnect layer, service boundary, enable/disable gate, stop-all path, config
  presets, and consent/cooldown policy.
- Source evidence:
  `pysim2bhap`, `bHapticsLib`, `VRCBhapticsIntegration`,
  `HapticsService`, `YAWVR-and-BHaptics-addons`, and
  `TactUnrealEngine4`.
- Abstraction boundary:
  keep event capture, pattern selection, transport queue, service binding,
  device status, user configuration, and safety/consent policy separate.
- What not to copy:
  unbounded haptic spam loops, hardcoded weapon/game assumptions, mod hooks
  without compatibility caveats, direct physical output without panic stop, or
  asset-only packages as if they were complete architecture evidence.
- Method catalog action:
  add a wearable haptics router method.

## Follow-Up Gaps

- Build a wearable haptics matrix across `.tact` catalogs, dot/frame APIs,
  simulator telemetry, avatar camera triggers, Android AIDL services, Unreal
  pairing UI, device status, consent, and emergency stop.
- Deepen `HerpDerpinstine/bHapticsLib` as the strongest transport donor.
- Deepen `Team-Beef-Studios/HapticsService` for standalone Android/Quest
  service boundaries.
- Treat `NovaVoidHowl/VRCBhapticsIntegration` as a high-value product reference
  with modding and VRChat compatibility caveats.
