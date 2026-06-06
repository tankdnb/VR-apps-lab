# GitHub Research Wave 209 Backlog

Date: 2026-06-06

Theme: XR glasses WebHID protocol workbenches and head-tracked desktop helpers.

## Completed In This Wave

- Deepened `jakedowns/xreal-webxr` as a browser WebHID protocol workbench.
- Deepened `alexwilson1/nreal_linux_test` as an X11 yaw-driven desktop slicing proof of concept.
- Deepened `edwatt/real_utilities` as a native hidapi command/calibration utility.
- Deepened `Mailbot/Nreal_Air_Desktop_tool` as a product/UX reference for AR desktop layout and drift correction.
- Added a reusable method entry for protocol workbench plus head-tracked desktop viewport design.

## Follow-Up Queue

1. Build a safer comparison matrix for WebHID, hidapi, Monado/OpenXR driver integration, and vendor SDK approaches.
2. Extract a protocol-reader pattern that can explicitly exclude firmware-writing flows unless a future project needs them.
3. Compare `Nreal_Air_Desktop_tool` UX ideas against virtual display and desktop-in-VR projects already in the registry.
4. Track whether newer Xreal/Nreal projects expose cleaner calibration and drift-correction abstractions.
5. Revisit Linux display-surface helpers only for compositing/window-placement lessons, not for direct code reuse.

## Do Not Spend Time On Yet

- Do not run firmware update helpers or device commands from these repos.
- Do not treat X11 root/docker setup from `nreal_linux_test` as a recommended deployment model.
- Do not promote README-only desktop products into code donors without source evidence.
