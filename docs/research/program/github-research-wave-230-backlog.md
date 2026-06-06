# GitHub Research Wave 230 Backlog

Date: 2026-06-06

Theme: Scriptable WebXR modeling, viewer, editor, and creative display
surfaces.

## Completed In This Wave

- Studied `vipenzo/ridley` as a CAD-as-code workbench with ClojureScript/SCI
  runtime evaluation, turtle geometry, editor/REPL, pilot-mode code generation,
  WebXR VR/AR session hooks, PeerJS desktop-headset sync, voice input, and a
  Windows checkout caveat caused by an invalid `?` path.
- Studied `id3vi5er/fusion360_webxr_viewer` as a Fusion 360 add-in bridge that
  creates toolbar commands, exports OBJ/MTL to a bundled web directory, runs a
  local HTTPS server inside the add-in, and lets a Three/WebXR page reload,
  center, scale, grab, and rotate the model.
- Studied `felipereigosa/kairon` as a VR code editor with tab/terminal model,
  emacs/chrome-like keyboard bindings, code execution, desktop input window,
  VR locomotion, controller polling, haptics, and editor visibility toggles.
- Studied `phobi82/webxr_butterchurn` as a no-build modular WebXR visualizer
  with app shell normalization, audio source/analyser modules, visualizer
  modes, in-headset menu sections/sliders, depth/passthrough, lighting,
  runtime loop, movement, TestLab, and desktop menu preview.
- Added a reusable method entry for scriptable XR workbench and display-surface
  shells.

## Follow-Up Queue

1. Compare in-headset editor input strategies across `Ridley`, `Kairon`,
   earlier keyboard/text-entry waves, and VR creator workbench waves.
2. Build a host-app export bridge matrix for Fusion, FreeCAD, browser CAD,
   Blender-like flows, glTF/OBJ/STL, local HTTPS, and live reload.
3. Extract an in-headset menu texture/playbook from `webxr_butterchurn`,
   A-Frame GUI waves, MRTK waves, and Udon menu waves.
4. Compare passthrough/depth display-surface modules across `webxr_butterchurn`,
   Quest MR samples, OpenXR passthrough, and index camera passthrough.
5. Decide whether `webxr_butterchurn` deserves a focused reuse plan for menu,
   depth, runtime, and audio-reactive shell modules.

## Do Not Spend Time On Yet

- Do not run CAD, Fusion, browser, or WebXR sessions.
- Do not copy `ridley` source without resolving checkout/path and project
  maturity caveats.
- Do not reuse intense visualizer defaults without comfort/photosensitivity
  review.
