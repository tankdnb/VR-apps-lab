# GitHub Research Wave 141 Backlog

- Date: `2026-06-05`
- Scope: browser-based XR editors, live-coding sandboxes, visual workspaces,
  template systems, and Three.js UI/text infrastructure.

## Completed in this wave

- Studied `playcanvas/editor` as a browser editor with method bus, observer
  history, asset APIs, realtime document loading, room presence, and plugin
  tools.
- Studied `tentone/nunuStudio` as a self-contained web/desktop scene editor
  with project files, action history, resource crawling, tabs, run/stop, and
  VR mode toggle.
- Studied `pmndrs/triplex` as a source-code-driven React Three Fiber workspace
  that extracts JSX component metadata and injects provider/scene preview
  modules.
- Studied `brianpeiris/RiftSketch` as an in-VR live-coding sandbox with text
  panels, scene interception, local storage, runtime eval, and error feedback.
- Studied `teliportme/remixvr` as a template-based VR creation and classroom
  publishing system with backend activities, submissions, reactions, and
  A-Frame templates.
- Studied `protectwise/troika` as a Three.js UI/text toolkit with facade
  architecture, flex/UI blocks, worker utilities, SDF glyph generation, and
  instanced text rendering.

## Reuse candidates

- `playcanvas/editor` and `nunuStudio` are strongest for editor architecture.
- `triplex` is strongest for source-code-to-visual-workspace ideas.
- `RiftSketch` is strongest for in-headset live-coding UX.
- `remixvr` is a useful product/reference model for template-based creation.
- `troika` is a high-value donor for readable 3D text/UI infrastructure.

## Follow-up backlog

1. Build an editor architecture matrix: method bus, history, asset path,
   project file, realtime room, and preview isolation.
2. Compare in-VR live coding with command/history patterns from creative-tool
   waves.
3. Extract a small `3D text/readability surface` note using `troika`,
   subtitles, chat overlays, and VR keyboard references.
4. Queue template-based VR creation as a product branch only if educational or
   no-code authoring becomes active.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
