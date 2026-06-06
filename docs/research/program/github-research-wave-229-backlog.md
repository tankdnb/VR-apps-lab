# GitHub Research Wave 229 Backlog

Date: 2026-06-06

Theme: Immersive data, robotics, and scientific visualization workbenches.

## Completed In This Wave

- Studied `vuer-ai/vuer` as a Python async WebSocket scene bridge with
  `sess.set`/`sess.update` style scene operations, typed event payloads,
  workspace asset serving, robotics schemas, hand/body tracking docs, and
  teleoperation examples.
- Studied `thomann/plotAR` as a generated immersive plot workflow with QR
  pairing, VR/keyboard pages, glTF/USDZ export, simple WebSocket control
  commands, and older WebVR/security caveats.
- Studied `TsatsuAmable/nemosyne` as a data-native WebXR visualization engine
  with artifact registration, semantic property mapping, layout algorithms,
  transform DSL, WebSocket stream extension, and research-preview caveats.
- Studied `smrghsh/brahma` as a collaborative scientific room shell with
  environment modules, selectable/grasp/controller modules, remote embodiment,
  WebSocket networking, callouts, and hardcoded endpoint caveats.
- Studied `jurmy24/mechaverse` as a browser robotics viewer dispatch shell
  that detects URDF, MJCF, and USD file groups, routes them to specialized
  viewers, and centralizes drag/drop payload events.
- Added a reusable method entry for data-to-spatial-encoding workbench
  pipelines.

## Follow-Up Queue

1. Compare Python-to-XR scene delta protocols across `vuer`, `plotAR`, and
   earlier teleoperation/browser-shell waves.
2. Build a data-to-spatial-encoding matrix across semantic fields, mappings,
   layout algorithms, interaction, legend/UI, and export paths.
3. Compare robotics viewer dispatch patterns across URDF, MJCF, USD, MuJoCo,
   and ROS/teleoperation tools.
4. Extract security guidance for local data servers, public WebSocket demos,
   QR pairing, and live scientific collaboration rooms.
5. Revisit whether any data workbench deserves a focused reuse plan after the
   matrix pass.

## Do Not Spend Time On Yet

- Do not run Python servers, web demos, or robotics simulators.
- Do not treat desktop-only robotics viewers as finished VR tools.
- Do not copy hardcoded collaboration endpoints or old WebVR pages.
