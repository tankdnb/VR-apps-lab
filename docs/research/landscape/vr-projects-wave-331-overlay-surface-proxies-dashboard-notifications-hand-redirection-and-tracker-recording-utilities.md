# Wave 331 - Overlay Surface Proxies, Dashboard Notifications, Hand Redirection, and Tracker Recording Utilities

This wave studies overlay-adjacent and interaction utility projects: desktop
lyrics proxying for VR capture, OpenVR dashboard notifications, hand
redirection research tooling, and SteamVR tracker recording utilities.

No external project was run, installed, or launched.

## Scope

The wave was bounded to:

- desktop/window/region proxy surfaces for VR capture tools;
- OpenVR dashboard overlay rendering and remote notification ingestion;
- Unity hand redirection and analysis toolkits;
- SteamVR tracker assignment, recording, and replay scaffolds.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Eldon27232/KugouLyricsMirror` | Desktop lyrics to VR-capturable proxy window | Studied | Strong donor for HWND capture, PrintWindow/BitBlt fallback, DWM proxy mode, chroma-key processing, click-through/no-focus preview, region fallback, and normal top-level capture target |
| `ZephyrVR/tempest-overlay` | OpenVR dashboard overlay with socket notifications | Studied | Useful older architecture donor for Qt Quick to OpenVR texture submission, dashboard/thumbnail handles, manifest/autolaunch helpers, keyboard events, token file, Socket.IO notification rooms, and logging |
| `AndreZenner/hand-redirection-toolkit` | Unity hand redirection research toolkit | Studied | Strong research-method donor for RedirectionManager, HandRedirector subclasses, virtual/real target links, edit-mode analysis, threshold visualization, Leap/SteamVR packaging, and movement logging |
| `Avdbergnmf/SteamVR-Utils` | Unity SteamVR tracker assignment, recording, replay, and UI utilities | Studied | Useful donor for tracker serial mapping, UI row assignment, threaded pose sampling, circular queues, UXF integration seams, and replay scaffolding |

## Code-Level Findings

### `Eldon27232/KugouLyricsMirror`

- Interesting idea:
  problematic desktop lyrics/tool windows can be converted into a normal
  capturable top-level preview window for SteamVR, OVR Toolkit, Desktop+, and
  similar VR tools.
- Code donor value:
  high. The app separates forms, core capture logic, interop, and models.
  `WindowCapture` uses DWM frame bounds, `PrintWindow`, and `GetWindowDC +
  BitBlt` fallback. README documents HWND chroma-key capture, DWM thumbnail
  proxy mode, region chroma-key fallback, VR overlay mode, click-through,
  `SWP_NOACTIVATE`, and why `WS_EX_NOACTIVATE` can break SteamVR capture.
- Product reference value:
  very high for reference-window, lyrics, subtitle, and desktop-surface helper
  utilities.
- What to inspect next:
  `ChromaKeyProcessor`, source-window follow loop, config persistence, and DPI
  behavior across monitors.
- Architecture pattern:
  `source HWND/region resolver + capture/proxy backend + chroma-key processor
  + normal top-level preview sink + VR capture compatibility rules`.
- Reusable method:
  VR-capturable desktop proxy surface.
- UX pattern:
  mode chooser, window scan/bind, region picker, eyedropper/manual color,
  preview window, black backdrop, and clear instruction to capture the proxy
  window rather than the original app.
- Constraints / caveats:
  Windows-specific APIs, PrintWindow limitations, capture compatibility quirks,
  and language/localization cleanup.
- Why it matters for `VR-apps-lab`:
  it gives a practical proxy-window pattern for turning any fragile desktop
  surface into a VR-friendly capture target.

### `ZephyrVR/tempest-overlay`

- Interesting idea:
  an OpenVR dashboard overlay can render a Qt Quick surface into an FBO, submit
  it as an OpenGL texture, and receive remote notifications through a socket
  room.
- Code donor value:
  high as an older architecture reference. `main.cpp` owns manifest
  install/remove/autolaunch, update/version files, desktop mode, logging, and
  QML app startup. `overlaycontroller.cpp` creates a dashboard overlay and
  thumbnail, sets mouse input and scroll flags, renders the Qt item into an FBO,
  submits `Texture_t`, polls overlay events, shows keyboard, watches token
  files, and relays Socket.IO notifications into OpenVR notifications.
- Product reference value:
  high for dashboard overlay lifecycle and remote notification architecture.
- What to inspect next:
  QML surface layout, token storage, reconnect policy, and modern OpenVR/Qt
  replacement options.
- Caveat:
  unmaintained, older Qt/OpenVR stack, vendored binaries, and GPL license.

### `AndreZenner/hand-redirection-toolkit`

- Interesting idea:
  VR hand redirection can be packaged as a modular toolkit with algorithm
  subclasses, edit-mode analysis, visualization, logging, and optional
  hardware/provider add-ons.
- Code donor value:
  high for interaction research patterns. `RedirectionManager` owns real hand,
  virtual hand, body, warp origin, default technique, target list, reset target,
  and target cycling. `HandRedirector` defines `Init`, `ApplyRedirection`, and
  threshold checks. Analysis scripts draw connection/threshold state and log
  target/hand/body positions.
- Product reference value:
  medium-high for hand UI, haptic retargeting, and evaluation tooling.
- What to inspect next:
  concrete redirection subclasses, target collision manager, calibration
  packages, and logging export quality.
- Caveat:
  Unity 2019/SteamVR/Leap/SRAnipal-era toolkit; reuse conceptually, not as a
  current package baseline without dependency updates.

### `Avdbergnmf/SteamVR-Utils`

- Interesting idea:
  tracker-heavy Unity projects need reusable utilities for serial-to-device
  mapping, operator assignment, jitter/alignment helpers, and recording/replay.
- Code donor value:
  high for data tooling. `tracker_config.txt` maps friendly names to LHR
  serials. `TrackerConfigurationLoader` avoids fragile activation-order
  indexes by resolving SteamVR tracked objects from serials and falling back
  with warnings. `SteamVRRecorder` samples poses on a separate thread, uses
  recorder/replayer prefabs, stores recordings under `Recordings/`, has a
  thread-safe circular queue, and provides UXF integration seams.
- Product reference value:
  high for lab/training/diagnostic utilities.
- What to inspect next:
  CSV schema, replay maturity, thread-to-main handoff, and tracker UI file
  naming consistency.
- Caveat:
  some scripts look like evolving Unity utilities; replay is marked TODO and
  UXF dependency must be gated.

## Reusable Pattern Extraction

- Pattern candidate:
  proxy-surface and interaction-data utility boundary.
- Problem solved:
  useful VR utilities often need to turn external surfaces or physical motion
  into stable in-headset references and reconstructable data without merging
  capture, rendering, input, and analysis into one blob.
- Reusable core:
  source resolver, capture/proxy backend, compatibility preview sink, overlay
  render bridge, remote event source, manifest lifecycle, interaction manager,
  provider add-ons, tracker serial map, threaded sampler, bounded queues,
  recording schema, replay scaffold, and analysis visualization.
- Source evidence:
  `Eldon27232/KugouLyricsMirror`, `ZephyrVR/tempest-overlay`,
  `AndreZenner/hand-redirection-toolkit`, and
  `Avdbergnmf/SteamVR-Utils`.
- Abstraction boundary:
  keep source discovery, render/capture backend, output surface, runtime
  manifest, remote transport, interaction algorithm, tracker identity, and data
  recording/replay separate.
- What not to copy:
  vendor-binary payloads, stale Qt/OpenVR assumptions, direct desktop capture
  without compatibility notes, tracker index ordering as identity, or replay
  features without schema/version metadata.
- Method catalog action:
  add a proxy-surface and interaction-data utility method.

## Follow-Up Gaps

- Compare `KugouLyricsMirror` with DWM mirror and desktop-in-VR capture waves.
- Build a modern OpenVR dashboard overlay lifecycle checklist from `tempest`.
- Compare tracker recording with prior study/replay and mocap waves.
