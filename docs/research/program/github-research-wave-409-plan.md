# GitHub Research Wave 409 Plan - WebView Browser Panel Bridges And Texture-Backed Web Surfaces

- Date: `2026-07-13`
- Theme: browser-backed panels, WebView lifecycle bridges, JavaScript callbacks,
  and texture/synthetic-input web surfaces.

## Frozen Scope

- `gree/unity-webview`
- `umetaman/UnityWebView2`
- `olegmrzv/UnityWebViewInEditor`
- `t-34400/UnityWebViewLib`

## Research Questions

- Which projects create native overlays and which create true texture-backed
  surfaces?
- How are JS callbacks, permissions, focus, and native lifecycle handled?
- What architecture is safe to generalize for VR utility panels?

## Expected Outputs

- Wave landscape synthesis.
- Registry and family placement.
- Method candidate for texture-backed WebView panels with synthetic input.
- Follow-up queue entry for native-overlay versus scene-surface variants.
