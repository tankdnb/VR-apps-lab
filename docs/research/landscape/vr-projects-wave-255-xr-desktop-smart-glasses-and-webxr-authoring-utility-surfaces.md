# VR Projects Wave 255: XR Desktop Smart Glasses And WebXR Authoring Utility Surfaces

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies lightweight XR desktop and WebXR authoring utility surfaces:
Linux smart-glasses desktop helpers, Android desktop-mode configuration,
desktop session indicators, lab-assistant glasses runtimes, WebXR dev helpers,
Blender-to-WebXR export tools, and annotated WebXR scene surfaces.

## Why It Matters For `VR-apps-lab`

XR utility work is not only headset overlays. A reusable tool often sits at the
edge of OS display routing, glasses IMU data, development visibility, authoring
export, or scene annotation. These projects show useful boundaries for those
edge utilities.

## Project Notes

### `ProjectBlueSkies/xr-desktop`

- Interesting idea:
  a Linux GNOME/Wayland virtual desktop for Viture XR Pro glasses reads glasses
  IMU quaternions and world-locks desktop surfaces.
- Code donor value:
  README defines a clean architecture:
  Viture glasses -> C IMU daemon -> `/dev/shm/xr-desktop` -> GNOME Shell
  extension -> display. `daemon/src/main.c` opens shared memory and the IMU,
  then writes pose updates. `imu.c` discovers Viture devices through udev and
  vendor SDK calls, registers a pose callback, and opens IMU pose mode.
  `shared/ipc.h` defines a seqlock-style quaternion shared-memory struct.
  `extension/extension.js` polls shared memory at about 60 Hz, guards against
  torn reads, computes relative yaw/pitch, and offsets the GNOME window group.
- Product reference value:
  strong donor for smart-glasses desktop runtime boundaries.
- What to inspect next:
  track phases for virtual displays, curved shaders, settings, and real
  Wayland/Mutter display integration.
- Reusable pattern:
  glasses IMU daemon -> shared-memory pose -> shell extension world-lock
  transform.
- Caveats:
  early phased project, specific Viture hardware, GNOME 46/Wayland, vendor SDK,
  and currently window-group transform rather than full virtual display stack.

### `mhalder/xreal-desktop-mode`

- Interesting idea:
  a small shell tool enables Android desktop mode for Xreal One Pro glasses by
  applying persistent and runtime ADB settings.
- Code donor value:
  `setup.sh` separates commands for `init`, `usb`, `connect`, `density`, and
  `auto`, stores a wireless-debugging address, sets persistent Android desktop
  and freeform-window settings, finds external display IDs through
  `dumpsys display`, and applies per-display density.
- Product reference value:
  useful micro-utility reference for display-mode enablement and setup docs.
- What to inspect next:
  compare with other XR glasses desktop tools and add device/version detection.
- Reusable pattern:
  persistent platform settings -> runtime reconnect -> external display detect
  -> density/pointer tuning.
- Caveats:
  Android version/device specific, ADB-dependent, modifies global settings, and
  runtime density resets.

### `marbetschar/wingpanel-indicator-xrdesktop`

- Interesting idea:
  a desktop panel indicator exposes XR desktop enabled state through a small
  DBus-backed Wingpanel plugin.
- Code donor value:
  `src/Indicator.vala` owns a session DBus name, registers
  `/io/elementary/pantheon/xrdesktop`, provides display and popover widgets,
  and wires dynamic icons to a DBus service. `DBusService.vala` exposes an
  `enabled` property and `enabled_changed` signal.
- Product reference value:
  useful donor for tiny desktop companion indicators around XR services.
- What to inspect next:
  connect this indicator model to modern GNOME/KDE tray or portal surfaces.
- Reusable pattern:
  panel indicator -> DBus service state -> popover/control widget.
- Caveats:
  elementary/Wingpanel-specific, older XRDesktop ecosystem context, and no
  direct runtime control in the inspected files.

### `cong-lab/LabOS-Runtime`

- Interesting idea:
  a VITURE glasses lab-assistant runtime connects glasses hardware, local
  dashboard, speech, media streaming, protocol steps, and remote model/agent
  services.
- Code donor value:
  README defines a client runtime split across glasses gRPC, MediaMTX, voice
  bridge, dashboard, STT/wake word, TTS pusher/mixer, and remote agent/model
  services. `scripts/glass_connectors/base.py` defines a connector interface
  for detecting glasses and reading/writing config. `usb_connector.py` detects
  USB/MTP-mounted VITURE storage and writes `sop_config.json`.
  `update_glasses.py` guides the operator through network interface selection,
  device wait, current config display, and config write.
- Product reference value:
  strong product reference for XR glasses operational onboarding and local
  dashboard/runtime split.
- What to inspect next:
  inspect dashboard API, audio bridge, MediaMTX config, and protocol runner in
  a separate lab/XR-assistant wave.
- Reusable pattern:
  hardware connector -> runtime IP config -> local dashboard -> media/audio
  bridge -> remote agent/model services.
- Caveats:
  broad lab-specific stack, external services/secrets, Docker/Tailscale/VITURE
  app requirements, and not a generic VR utility donor without slicing.

### `sawa-zen/three-fiber-webxr-toolbox`

- Interesting idea:
  a React Three Fiber WebXR toolbox brings debugging and development surfaces
  into immersive mode: XR error windows, in-XR console, passthrough portal,
  remote display, and passthrough hands.
- Code donor value:
  `ConsoleProvider` keeps the last 24 console messages and renders a
  `ConsoleSprite` in XR. `RemoteDisplay/index.tsx` renders a curved video
  texture or connect prompt on a cylinder surface and handles XR select/click.
  `remoteDisplayServer.ts` adds a Vite middleware page and Socket.IO signaling
  for WebRTC offer/answer/candidate relay.
- Product reference value:
  strong donor for XR developer tooling surfaces.
- What to inspect next:
  study the WebRTC hooks, error sprite, passthrough hand component, and
  security model for open Socket.IO signaling.
- Reusable pattern:
  immersive dev helper component -> local dev server plugin -> XR-visible
  console/error/remote display.
- Caveats:
  dev-focused, Vite/server assumptions, open CORS in signaling, and React/Three
  dependency boundary.

### `laffan/blender-webxr-tools`

- Interesting idea:
  a Blender sidebar groups WebXR-oriented export chores: bake-node setup,
  transform application, rebake, GLB/GLTF export, and `gltfjsx` JSX update.
- Code donor value:
  `__init__.py` registers a Blender panel, stores scene properties for model
  and JSX paths, exposes update modes, and wires operator buttons to scripts.
  `scripts/gltfjsxExport.py` exports GLB/GLTF, runs `npx gltfjsx`, renames
  transformed outputs, and can update only JSX return statements or selected
  mesh attributes.
- Product reference value:
  useful authoring-pipeline microtool for WebXR asset iteration.
- What to inspect next:
  make process execution, path handling, and JSX mutation safer before reuse.
- Reusable pattern:
  DCC panel -> export action -> converter command -> selective frontend code
  update.
- Caveats:
  README says ChatGPT-assisted and Mac-tested only; script uses shell commands,
  clipboard writes, regex JSX mutation, and fixed path assumptions.

### `pravinpoudel/building-annotation`

- Interesting idea:
  a WebXR/Three.js scene can use manually captured annotation camera/target
  coordinates to make scanned spaces explorable and labeled.
- Code donor value:
  `src/client/house_annotation.js` stores annotation text, descriptions,
  look-at coordinates, and camera positions. README explains a developer mode
  where raycasting captures positions for scanned models whose scene hierarchy
  is not reliable.
- Product reference value:
  useful lightweight reference for annotation overlays over messy scanned
  environments.
- What to inspect next:
  inspect the client navigation and annotation rendering flow if the repository
  later studies scanned-space workbenches.
- Reusable pattern:
  manual annotation capture -> coordinate list -> camera/target transitions ->
  labeled WebXR scene.
- Caveats:
  bundled build artifacts/assets, manual coordinate workflow, and limited
  architecture beyond the annotation data model.

## Reusable Pattern Extraction

- Pattern candidate:
  XR edge-utility surface with explicit OS, hardware, authoring, and web
  boundaries.
- Problem solved:
  useful XR helpers often sit outside the runtime itself and need clean
  contracts for hardware pose, display state, local config, dev visibility, or
  asset export.
- Reusable core:
  edge source, local adapter, transport or config contract, visible surface,
  operator flow, and caveats around platform/version/security.
- Source evidence:
  `xr-desktop`, `xreal-desktop-mode`, `wingpanel-indicator-xrdesktop`,
  `LabOS-Runtime`, `three-fiber-webxr-toolbox`, `blender-webxr-tools`, and
  `building-annotation`.
- Abstraction boundary:
  do not bury hardware/device setup, OS display mutation, dev-server signaling,
  or DCC export mutation inside the rendering surface.
- What not to copy:
  broad lab stacks wholesale, shell scripts that mutate device settings without
  checks, open WebRTC signaling defaults, and regex JSX mutation as a general
  code update strategy.
- Method catalog action:
  add a method for XR edge utilities spanning OS/hardware/WebXR authoring
  surfaces.

## Family Placement

This wave extends XR glasses desktop, WebXR developer-tooling, and
creator-authoring families. It also links to operational dashboard and
smart-glasses HUD/runtime work without duplicating earlier large framework
waves.

## Follow-Up Gaps

- Build an XR edge-utility matrix across hardware connector, OS display
  settings, local dashboard, dev-server surface, and authoring export.
- Deepen `LabOS-Runtime` separately only if the repository wants more
  voice/assistant/lab-operation patterns.
- Compare WebXR remote display developer surfaces with native desktop-in-VR
  overlays.
