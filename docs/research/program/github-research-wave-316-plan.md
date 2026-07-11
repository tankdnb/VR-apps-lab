# GitHub Research Wave 316 Plan - XR WebView Browser Panels, Native WebView Event Bridges, and Input Surfaces

## Goal

Study XR browser-panel implementations as reusable references for native
WebView hosting, texture capture, pointer and keyboard routing, event-policy
callbacks, and engine-side integration seams.

## Research Questions

- How do Unity and Quest browser-panel projects separate native WebView hosting
  from the XR-facing panel layer?
- What callback and policy surfaces are explicit versus hidden?
- Which projects are strong browser-core donors versus thin setup/integration
  samples only?
- What parts of the browser-panel problem belong to text entry and interaction
  stacks rather than the browser core itself?

## Shortlist

- `rwpersson/OpenWebView-Unity`
- `t-34400/SimpleUnity3DWebView`
- `vuplex/meta-xr-webview-example`
- `vuplex/xr-interaction-webview-example`

## Required Checks

- Deduplicate against earlier browser-surface, text-entry, and overlay waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep Quest/Android assumptions, keyboard ownership, and interaction-stack
  caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 316.
- Registry/family entries for XR WebView and browser-panel donors.
- Method catalog entry for XR WebView/browser surface boundaries.
- Follow-up gaps for text-entry, focus, GPU transport, and engine-neutral
  browser-shell comparisons.
