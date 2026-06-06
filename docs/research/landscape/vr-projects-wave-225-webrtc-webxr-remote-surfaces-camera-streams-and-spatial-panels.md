# VR Projects Wave 225: WebRTC/WebXR Remote Surfaces, Camera Streams, and Spatial Panels

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-225-plan.md`
- `docs/research/program/github-research-wave-225-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

Many practical VR tools are not full applications. They are surface-ingress
helpers: a desktop screen, IP camera, stereo camera, local monitor, or remote
control channel appears as a panel in XR. This wave extracts how small WebRTC
and WebXR projects split signaling, media, data/control channels, security, and
spatial panel behavior.

## Project Findings

### `binzume/webrtc-rdp`

- Interesting idea: remote desktop in XR works best when screen media, control
  events, file service, pairing, auth, and persisted peer devices are explicit
  services rather than one hidden stream.
- Code donor value: high. `app/webrtc-rdp.js` defines settings backed by local
  storage, a `BaseConnection` for Ayame signaling and media/data-channel state,
  a PIN-based `PairingConnection`, and a `PlayerConnection` with
  `controlEvent` data channel messages for auth, service requests, stream
  info, redirects, and RPC results. `webxr/aframe-rdp.js` ports the client side
  into A-Frame/WebXR and maps VR controller actions to desktop interaction.
- Product reference value: very high for desktop-in-VR, remote support, and
  thin productivity panels.
- Architecture pattern: signaling/pairing plus media stream plus capability
  data channels plus spatial client.
- Reusable method: treat each remote-surface capability as a named service and
  expose control paths separately from media tracks.
- Constraints and caveats: demo signaling dependency, experimental security,
  Electron/native requirements for full desktop input, and browser capability
  differences.
- What to inspect next: Electron capture/input code, file service behavior,
  tray-device lifecycle, and disconnect/reconnect edge cases.
- Why it matters for `VR-apps-lab`: it is a strong donor for any remote window
  or companion-control surface.

#### Reusable Pattern Extraction

- Pattern candidate: WebRTC surface ingress into XR panels with media, data,
  and control separation.
- Problem solved: remote panels become unsafe and brittle when pairing,
  signaling, media, control events, file transfer, and spatial manipulation are
  mixed into one opaque connection.
- Reusable core: bounded signaling/pairing, media tracks for screen or camera,
  data channels or WebSockets for auth/control/files/input, capability
  negotiation, spatial video panel creation, controller manipulation, and
  explicit security caveats.
- Source evidence: `webrtc-rdp` connection classes and WebXR client,
  WebCaster `xr.ts`, stereo viewer `webxr-manager.ts`, WebXR-IPCam WHEP page,
  and VRMonitor WebSocket/PHP/Babylon flow.
- Abstraction boundary: source capture, signaling, media transport, control
  transport, panel renderer, spatial interaction, and trust policy should be
  separate.
- What not to copy: public demo signaling keys, hardcoded ngrok/LAN endpoints,
  bundled dependencies, no-auth flows, or PHP/browser prototypes as production
  architecture.
- Method catalog action: create Method 670.

### `DiscreteTom/WebCaster`

- Interesting idea: a tiny WebXR screen surface can still provide useful
  spatial window management: grab, release, push/pull, scale, and multi-screen
  placement.
- Code donor value: high as a compact interaction reference. `src/xr.ts`
  creates a Three.js/WebXR scene, enables VRButton, represents each stream as a
  video texture on a mesh, lays screens out side by side, attaches stream audio,
  raycasts screens from controllers, attaches selected screens to controllers,
  and uses squeeze/joystick state for scale versus movement.
- Product reference value: high for quick in-headset screen panels and small
  remote-display tools.
- Architecture pattern: WebRTC stream to video texture to selectable XR panel.
- Reusable method: make panel manipulation controller-driven and visible even
  in a minimal proof of concept.
- Constraints and caveats: simple signaling, no strong security, limited
  persistence, and basic layout policy.
- What to inspect next: peer setup, screen source discovery, audio behavior,
  and multi-screen lifecycle.
- Why it matters for `VR-apps-lab`: it gives a clean micro-reference for
  remote surface manipulation without a heavy desktop shell.

### `hideki5123/stereo-webrtc-viewer`

- Interesting idea: stereo camera viewing can be implemented by keeping left
  and right WebRTC streams separate, then assigning the correct video texture
  per XR view.
- Code donor value: medium to high. `webxr-manager.ts` checks immersive VR
  support, starts a session with local-floor reference space, creates a WebGL2
  XR layer, creates left/right video textures and shader program, and renders
  each XR view with the corresponding eye texture.
- Product reference value: high for telepresence, stereo camera debugging, and
  robot/camera monitoring.
- Architecture pattern: dual WebRTC connection plus per-eye WebGL texture
  routing.
- Reusable method: decouple stereo stream acquisition from XR per-eye
  projection.
- Constraints and caveats: Sora dependency, minimal synchronization logic, and
  simple quad rendering.
- What to inspect next: Sora signaling setup, frame sync tolerance, and fallback
  behavior outside immersive VR.
- Why it matters for `VR-apps-lab`: it adds a concrete per-eye media routing
  reference distinct from ordinary SBS video playback.

### `rclarke87/WebXR-IPCam`

- Interesting idea: two IP camera feeds can become simple A-Frame video panels
  with WHEP endpoints and glanceable mute controls.
- Code donor value: low to medium. `index.html` creates hidden video elements,
  A-Frame `a-video` screens, fixed camera labels, WHEP receive-only
  PeerConnections, SDP POST flow, and mute buttons that update visual state.
- Product reference value: medium for micro camera monitors and home/lab
  utility panels.
- Architecture pattern: WHEP endpoint to HTML video to A-Frame video surface.
- Reusable method: use small labeled panels and direct mute affordances for
  camera monitor UX.
- Constraints and caveats: hardcoded endpoints, no config/security layer,
  source-light project, and demo-level code quality.
- What to inspect next: configurable endpoint lists, reconnect UX, and
  per-camera status display.
- Why it matters for `VR-apps-lab`: it is a useful reminder that narrow camera
  monitors can be valuable without a full desktop environment.

### `JYJang476/VRMonitor`

- Interesting idea: local VR monitor pairing can use QR discovery plus a tiny
  WebSocket relay before the stream becomes a Babylon video texture.
- Code donor value: low to medium. `streamServer.php` uses `getDisplayMedia`,
  connects to a local WebSocket server, shows a QR code, and sends SDP/candidate
  messages. `streamClient.php` receives the offer and candidate messages, then
  displays the remote stream through Babylon texture code. `Signaling/server.js`
  pairs server/client roles and relays WebRTC messages.
- Product reference value: medium for local monitor onboarding and QR pairing.
- Architecture pattern: local IP discovery plus QR code plus WebSocket
  signaling plus WebRTC media plus 3D texture output.
- Reusable method: make the connection ritual visible to the user when local
  networking is involved.
- Constraints and caveats: no README, checked-in dependencies, no auth, PHP and
  browser script mix, local network assumptions, and incomplete documentation.
- What to inspect next: Babylon texture helper, QR generation, reconnect path,
  and how client/server role errors are surfaced.
- Why it matters for `VR-apps-lab`: it provides a small onboarding pattern for
  local capture-to-headset surfaces.

## Cross-Project Synthesis

The reusable architecture is:

- source capture: desktop, camera, stereo camera, or local browser capture;
- signaling: PIN, QR, room, WHEP, WebSocket, or service-specific signaling;
- media: WebRTC video/audio track or receive-only WHEP stream;
- control: data channel or WebSocket messages for input, auth, files, or
  service requests;
- panel: WebXR/Three/A-Frame/Babylon video texture surface;
- spatial UX: grab, drag, scale, mute, input, or per-eye routing;
- trust model: auth, endpoint config, local-only scope, and demo caveats.

For `VR-apps-lab`, this wave strengthens remote-surface, overlay-window,
camera-monitor, and desktop-in-VR product lines.
