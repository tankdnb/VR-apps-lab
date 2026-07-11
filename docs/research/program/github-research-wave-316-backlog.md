# GitHub Research Wave 316 Backlog - XR WebView Browser Panels, Native WebView Event Bridges, and Input Surfaces

## Executed Scope

- Searched and deduplicated XR browser-panel and Unity WebView candidates.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted native Android WebView hosting, texture transport, pointer/UV
  routing, callback/event surfaces, and XRI/Meta integration seams.

## Studied Projects

- `rwpersson/OpenWebView-Unity`
- `t-34400/SimpleUnity3DWebView`
- `vuplex/meta-xr-webview-example`
- `vuplex/xr-interaction-webview-example`

## Backlog Findings

- Deepen the native/GPU transport side of `OpenWebView-Unity`.
- Compare keyboard and focus ownership more directly across browser-panel
  implementations and keyboard/text-entry waves.
- Look for non-Unity or non-Android browser-panel donors to separate engine and
  platform constraints.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an XR WebView/browser surface method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
