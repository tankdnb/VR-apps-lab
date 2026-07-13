# GitHub Research Wave 341 Backlog - visionOS Unity Plugin Bridges, WebView Surfaces, and Controller Adapters

## Executed Scope

- Searched and deduplicated visionOS Unity plugin bridge, webview surface,
  controller adapter, and template/checklist projects.
- Froze a four-project shortlist spanning Apple framework plug-ins, Vuplex
  Metal WebView adaptation, Surreal Touch controller SDK, and a Unity visionOS
  setup template.
- Read source and documentation statically from local-only cache with LFS
  smudge disabled.
- Extracted package/build-step design, accessibility/haptics/PHASE/spatial
  controller bridges, world-space webview scene adaptation, OVR-style input API
  mapping, permission postprocessing, and template checklist patterns.

## Studied Projects

- `apple/unityplugins`
- `vuplex/visionos-metal-webview-example`
- `surreal-interactive/SDK`
- `TonGarcia/UnityVisionVRTemplate`

## Backlog Findings

- Treat Apple framework plug-ins as bridge architecture references with clear
  build-step and native-wrapper boundaries.
- Keep webview surface work separate from native plugin ownership and
  passthrough/Metal mode configuration.
- Capture controller-adapter migration maps because they reduce porting cost
  from Oculus/SteamVR-style code.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include studied projects.
- Method catalog captures visionOS Unity adapter packaging.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
