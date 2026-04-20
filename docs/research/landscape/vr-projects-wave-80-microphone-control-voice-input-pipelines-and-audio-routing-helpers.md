# VR Projects Wave 80: Microphone Control, Voice-Input Pipelines, and Audio Routing Helpers

- Date: `2026-04-20`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `microphone control overlays`, `voice-input pipelines`, and
  `audio routing helpers`.

## Why this wave exists

`VR-apps-lab` already had captions, mic-state overlays, and a few routing
utilities, but it still lacked a cleaner answer to:

`what the best audio-control patterns look like when the job is microphone state, speech fan-out, or routing substrate rather than a general-purpose overlay`.

This wave exists to make that family clearer.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with microphone overlay, STT, and virtual-audio-device
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `matzman666/OpenVR-MicrophoneControl` | Strong product reference for dashboard mic mute and push-to-talk control over OS audio state |
| `I5UCC/VRCTextboxSTT` | Strong donor for `voice input -> many outputs` fan-out inside a VR-adjacent companion app |
| `VirtualDrivers/Virtual-Audio-Driver` | Useful lower-layer donor for virtual speaker and microphone routing substrate |

## Deep-pass notes by project

## `matzman666/OpenVR-MicrophoneControl`

- GitHub:
  [matzman666/OpenVR-MicrophoneControl](https://github.com/matzman666/OpenVR-MicrophoneControl)
- What it is:
  an OpenVR dashboard overlay for microphone muting, recording-volume control,
  and controller-configurable push-to-talk.
- Why it matters:
  it is still one of the clearest product references for
  `dashboard surface over OS microphone state`.
- Interesting ideas:
  make microphone state a first-class SteamVR dashboard concern; let push-to-
  talk be driven by controller or touchpad binding rather than only desktop
  hotkeys; autostart through a VR manifest so the tool behaves like a native
  runtime companion.
- Interesting implementation choices:
  `overlaycontroller.cpp`
  and
  `overlaywidget.cpp`
  split SteamVR overlay ownership from UI logic while
  `audiomanagerwindows.cpp`
  isolates Windows endpoint control behind a dedicated layer; the manifest in
  `bin/win64/microphonecontrol.vrmanifest`
  makes the runtime-launch pattern explicit.
- Code donor value:
  medium.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  the repo is explicitly deprecated in favor of `OpenVR-AdvancedSettings`, so
  it is stronger as a focused reference than as a modern mainline donor.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `mic-state dashboard overlay`
  baseline rather than a broader overlay suite.

## `I5UCC/VRCTextboxSTT`

- GitHub:
  [I5UCC/VRCTextboxSTT](https://github.com/I5UCC/VRCTextboxSTT)
- What it is:
  a local speech-to-text sidecar that uses `faster-whisper` and fans
  transcription output into VRChat textbox, avatar text, browser sources,
  WebSocket consumers, and a SteamVR overlay.
- Why it matters:
  it is the clearest donor in this wave for
  `one audio-input pipeline feeding many VR and non-VR output surfaces`.
- Interesting ideas:
  keep speech processing local and offline while still exposing many integration
  surfaces; treat SteamVR overlay as just one output sink among OSC,
  WebSocket, browser, and file consumers; make audio feedback and bindings part
  of the operator workflow rather than an afterthought.
- Interesting implementation choices:
  the repo is cleanly split between
  `listen.py`,
  `transcribe.py`,
  `osc.py`,
  `ovr.py`,
  `browsersource.py`,
  `websocket.py`,
  and
  `ui.py`,
  which makes the fan-out model explicit; `app.vrmanifest` keeps the overlay
  surface visible as part of the same pipeline instead of a separate app.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the repo serves VRChat text workflows first, so not every output surface is
  broadly reusable outside that ecosystem.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `voice input sidecar with many sinks`
  reference.

## `VirtualDrivers/Virtual-Audio-Driver`

- GitHub:
  [VirtualDrivers/Virtual-Audio-Driver](https://github.com/VirtualDrivers/Virtual-Audio-Driver)
- What it is:
  a WDK-based virtual speaker and virtual microphone driver pair for Windows.
- Why it matters:
  it is the clearest lower-layer donor in this wave for
  `audio routing substrate below any VR overlay or companion UX`.
- Interesting ideas:
  treat virtual audio devices as reusable infrastructure for headless, remote,
  streaming, or voice-routing scenarios; expose both speaker and microphone
  paths instead of only one fake endpoint; keep endpoint topology and WaveRT
  plumbing explicit rather than hidden behind a single black-box binary.
- Interesting implementation choices:
  `adapter.cpp`,
  `basetopo.cpp`,
  `mintopo.cpp`,
  and
  `minwavert.cpp`
  show the split between adapter, topology, and streaming logic while
  `speakertopo.cpp`
  and
  `micarraytopo.cpp`
  keep the endpoint roles explicit.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  the repo is not a VR product by itself; its value is as substrate for VR
  voice or streaming helpers rather than as end-user XR software.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `virtual audio routing layer`
  comparison against higher-level overlays or voice shells.

## Main takeaways from Wave 80

- `Audio control in VR`
  now splits more cleanly into:
  - `dashboard mic state and push-to-talk surface`
  - `voice input sidecar with many output sinks`
  - `virtual audio routing substrate`
- The strongest lesson from this wave is that
  `audio utility`
  is often a control-plane problem, not only a UI problem. The real value can
  live in endpoint control, routing layers, or multi-output fan-out.
- Another strong lesson is that `VR-facing voice tool` and `OS-level audio
  infrastructure` can both matter in the same family when they solve different
  layers of the same workflow.

## Reusable methods clarified by this wave

- `Dashboard microphone-control overlay with OS endpoint state and controller-driven push-to-talk`
- `Local speech-to-text sidecar that fans one audio-input pipeline into overlay, OSC, browser, and websocket outputs`
- `Virtual speaker-plus-microphone driver pair used as routing substrate for VR voice and streaming helpers`

## Recommended next moves after this wave

1. Keep `OpenVR-MicrophoneControl` visible as a focused
   `mic dashboard`
   reference.
2. Treat `VRCTextboxSTT` as the clearest donor in this wave for
   `voice input -> many outputs`.
3. Keep `Virtual-Audio-Driver` visible whenever a future utility idea needs
   `virtual audio plumbing`
   rather than only overlay UX.
