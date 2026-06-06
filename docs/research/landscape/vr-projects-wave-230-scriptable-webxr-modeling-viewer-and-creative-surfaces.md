# VR Projects Wave 230: Scriptable WebXR Modeling, Viewer, and Creative Surfaces

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies work-surface projects rather than ordinary demos: CAD-as-code
environments, host-app-to-WebXR export bridges, VR code editors, and modular
audio-reactive WebXR display shells with menu, depth, passthrough, and runtime
layers.

## Why It Matters For `VR-apps-lab`

Many future VR utility tools will need a durable surface where the user can
inspect, configure, edit, or generate content. The important lesson is how a
tool separates editor/model state, runtime scene, input, export/reload,
in-headset UI, and display effects.

## Project Notes

### `vipenzo/ridley`

- Interesting idea:
  CAD-as-code can combine a live code editor, REPL, turtle geometry, mesh/SDF
  representations, pilot-mode steering, AI/voice, desktop-headset sync, and
  WebXR session hooks.
- Code donor value:
  `src/ridley/viewport/xr.cljs` exposes VR/AR session management, controller
  state, panel visibility, drag state, and view toggles. `src/ridley/sync/peer.cljs`
  uses PeerJS short codes and QR-style pairing concepts for desktop-headset
  script/REPL sync. `src/ridley/editor/pilot_mode.cljs` converts interactive
  movement into source code.
- Product reference value:
  strong reference for a future in-headset CAD/modeling utility where
  interactive manipulation must preserve textual source, not just mutate a
  scene.
- What to inspect next:
  revisit WebXR/voice maturity, resolve Windows checkout caveats, and compare
  editor input against Kairon and text-entry waves.
- Architecture pattern:
  scriptable workbench with runtime evaluation, generated code, and optional
  headset sync.
- Caveats:
  current checkout has a Windows-invalid `?` path in docs, WebXR/voice areas
  are described as paused or in design work, and the project scope is broad.

### `id3vi5er/fusion360_webxr_viewer`

- Interesting idea:
  a host CAD app can own export and local serving, while a WebXR page owns
  immersive inspection and manipulation.
- Code donor value:
  `FusionToWebXR.py` creates Fusion toolbar commands, starts/stops a threaded
  HTTPS `http.server`, exports visible geometry as OBJ, and lists LAN URLs.
  `addin/www/index.html` loads OBJ/MTL with cache-busting, centers/scales the
  model, checks file changes with `HEAD`, and supports controller grabbing.
- Product reference value:
  useful pattern for "host app exports, headset reloads" workflows without
  building a native headset app.
- What to inspect next:
  replace polling with a clearer manifest/version file and harden certificate,
  local-network, and file-serving behavior.
- Architecture pattern:
  host-app export bridge plus local HTTPS WebXR viewer.
- Caveats:
  self-signed certificate setup, local network trust, OBJ/MTL limitations, and
  simple polling reload.

### `felipereigosa/kairon`

- Interesting idea:
  keep real text input on the desktop while the editor, terminal tab, and
  generated world are visible and controllable in VR.
- Code donor value:
  `src/editor.js` implements tabs, terminal tab behavior, keyboard bindings,
  code execution, persistence, pointer events, and visibility toggles.
  `src/index.js` sets up Three/WebXR, controllers, haptics, locomotion,
  controller polling, physics, hand models, and the editor surface.
- Product reference value:
  strong UX reference for serious VR tools where typing entirely in headset is
  the wrong cost center.
- What to inspect next:
  compare desktop companion input, WebSocket/input window, and browser focus
  constraints against keyboard/text-entry waves.
- Architecture pattern:
  desktop keyboard companion plus in-headset editor/world surface.
- Caveats:
  old setup assumptions, Quest 2/Ubuntu-tested flow, ADB reverse instructions,
  and direct global state.

### `phobi82/webxr_butterchurn`

- Interesting idea:
  a WebXR visualizer can be structured as a reusable app shell with separate
  modules for audio, visualizer modes, menu, passthrough, depth, lighting,
  locomotion, render, runtime, and desktop mirror.
- Code donor value:
  `xr-app.js` normalizes app shell/config and composes controllers. `xr-menu.js`
  builds stateful menu sections, choice rows, sliders, cyclers, checkboxes,
  and session actions. `xr-depth.js`, `xr-passthrough.js`, `xr-lighting.js`,
  and `xr-runtime.js` keep depth packets, visibility, passthrough policy,
  lighting, and frame orchestration separate.
- Product reference value:
  high-value donor for in-headset menus, desktop mirrored menu previews,
  audio-reactive state, depth-aware passthrough controls, and no-build WebXR
  utility shells.
- What to inspect next:
  consider a focused reuse plan for menu/runtime/depth/audio module separation.
- Architecture pattern:
  modular XR display surface with menu texture, desktop mirror, depth/passthrough,
  and audio-reactive state bus.
- Caveats:
  intense visual effects, explicit photosensitivity/motion-sickness warnings,
  browser depth support variability, and demo-specific defaults.

## Reusable Pattern Extraction

- Pattern candidate:
  Scriptable XR workbench and display-surface shell.
- Problem solved:
  work tools need stable boundaries between source/model state, host export,
  runtime display, input, menu, and effects; otherwise every feature becomes a
  scene-specific tangle.
- Reusable core:
  keep domain state outside rendering, expose an import/export or live-eval
  boundary, use a desktop companion when text input is heavy, route controller
  input through explicit commands, build in-headset menu state separately from
  drawing, and make desktop mirror/debug surfaces first-class.
- Source evidence:
  `vipenzo/ridley`, `id3vi5er/fusion360_webxr_viewer`,
  `felipereigosa/kairon`, and `phobi82/webxr_butterchurn`.
- Abstraction boundary:
  separate source/editor/host app, asset reload, runtime scene, menu state,
  input adapters, and special display layers.
- What not to copy:
  self-signed local server defaults as production, ADB-heavy setup as normal
  UX, broad CAD codebases wholesale, or intense visualizer parameters without
  comfort review.
- Method catalog action:
  add a method entry for scriptable XR workbench and display-surface shells.

## Follow-Up Gaps

- Build an in-headset editor/input strategy matrix.
- Build a host-app-to-WebXR export bridge matrix.
- Extract a reusable menu texture/desktop mirror playbook from
  `webxr_butterchurn`.
- Decide whether `webxr_butterchurn` gets a dedicated reuse plan.
