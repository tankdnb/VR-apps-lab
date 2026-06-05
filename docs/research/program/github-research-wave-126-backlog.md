# GitHub Research Wave 126 Backlog

- Date: `2026-06-05`
- Scope: immersive browser shells, WebXR runtime/session modeling, spatial home
  scenes, and browser-front-end architecture.

## Completed in this wave

- Studied `Igalia/wolvic` as the strongest current reference for standalone
  headset browser shell architecture.
- Studied `MozillaReality/FirefoxReality` as historical Android VR browser and
  WebXR rendering lineage.
- Studied `MozillaReality/FirefoxRealityPC` as a Unity/OpenVR shell around
  Firefox Desktop.
- Studied `exokitxr/exokit` as a JavaScript WebXR runtime/session/input shim.
- Studied `exokitxr/exokit-browser` as a minimal static browser shell.
- Studied `exokitxr/exokit-frontend` as a split frontend/menu/engine UI.
- Studied `madjin/home-space` as a spatial home/startpage product reference.

## Reuse candidates

- `wolvic` is the strongest architecture reference for session/window/widget
  and native render-world split.
- `exokit` is the strongest code-level reference for explicit WebXR
  session/input/layer modeling.
- `FirefoxRealityPC` is useful for launcher, dependency readiness, and
  companion shell patterns.
- `home-space` is useful as product reference for spatial browser homes.

## Follow-up backlog

1. Extract an immersive browser shell boundary matrix.
2. Compare WebXR interstitial/escape UX across Wolvic and Firefox Reality.
3. Keep spatial home scenes in product-reference status unless cleaner code
   donors appear.
4. Revisit browser-backed overlay shell waves if a small browser utility host
   prototype starts.

## Quality notes

- No found project was built, launched, installed, or run.
- Large browser codebases are documented as references, not imported
  dependencies.
