# GitHub Research Wave 240 Plan

Date: 2026-06-06

Theme: VR WebView browser surfaces, spatial keyboards, and Quest-native web
content.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

VR utility products often need embedded web surfaces for dashboards, docs,
settings, remote controls, local web UIs, or media panels. This wave focuses
on Unity Quest WebView samples where the reusable knowledge is the input and
surface boundary: native Android WebView rendering, XR keyboard routing, search
bars, focus events, prefab packaging, and device caveats.

## Search Families

- Unity Quest WebView samples.
- XR Interaction Toolkit browser prefabs.
- Meta XR WebView sample variants.
- Spatial keyboard and browser text-entry bridges.
- Native WebView capture-mode and graphics fallback documentation.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `TLabAltoh/TLabWebViewVR` | Main Quest WebView VR sample with Meta XR and XRI prefabs, spatial keyboard bridge, and Android rendering caveats. | Strong WebView surface donor |
| `TLabAltoh/TLabWebViewVR-XRInteractionToolkit-2022` | Minimal Unity 2022 XRI sample with searchbar and version-pinned compatibility notes. | XRI WebView baseline |
| `TLabAltoh/TLabWebViewVR-OculusIntegration-2022` | Meta XR variant with searchbar and JavaScript focus/focusout keyboard visibility reference. | Meta XR WebView variant |

## Dedupe Notes

Prior waves cover VR text entry, WebView-like surfaces, browser XR media, and
overlay web panels. This wave is narrower: Quest-native Unity WebView surfaces
and the XR input/focus bridge around them.

## Code-Level Pass Targets

- Prefab/package split for Meta XR and XRI.
- Searchbar and LoadUrl callback wiring.
- XR keyboard to native WebView key-event routing.
- Input focus, blur, and keyboard visibility.
- Android-only and Unity/device caveats.
- Graphics API and capture-mode fallback guidance.

## Expected Outputs

- Wave 240 landscape synthesis.
- Registry/family entries for the TLab WebView sample family.
- Method catalog entry for VR WebView surface input boundaries.
- Follow-up backlog for comparing WebView surfaces with prior text-entry waves.
