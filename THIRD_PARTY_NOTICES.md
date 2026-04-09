# Third-Party Notices

This repository includes or depends on the following third-party components.

## Valve OpenVR SDK bindings

Files:

- `src/VRRealityWindow.OpenVr/OpenVrSdk/openvr_api.cs`
- runtime dependency copied from `assets/openvr_api.dll`

Source:

- `ValveSoftware/openvr`
- <https://github.com/ValveSoftware/openvr>

Notes:

- `openvr_api.cs` is an auto-generated binding from the OpenVR SDK.
- `openvr_api.dll` is used as a runtime dependency for the desktop OpenVR path.
- The original Valve copyright notice is preserved in the vendored source file.

## Khronos OpenXR headers

Files:

- `spikes/PicoOpenXrExtensionProbe/app/src/main/cpp/third_party/openxr/openxr.h`
- `spikes/PicoOpenXrExtensionProbe/app/src/main/cpp/third_party/openxr/openxr_platform_defines.h`

Source:

- `KhronosGroup/OpenXR-SDK`
- <https://github.com/KhronosGroup/OpenXR-SDK>

License:

- `Apache-2.0 OR MIT`

Notes:

- The original SPDX notices are preserved in the copied headers.

## Repository research sources

The `docs/` directory contains implementation notes and reuse analysis based on
public repositories, SDKs, and official documentation. Those docs summarize the
projects; they do not vendor the upstream code unless explicitly noted above.
