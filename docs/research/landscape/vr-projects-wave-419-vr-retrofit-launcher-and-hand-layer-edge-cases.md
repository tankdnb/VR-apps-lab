# VR Projects Wave 419 - VR Retrofit Launcher And Hand Layer Edge Cases

- Date: `2026-07-13`
- Scope: flatscreen-to-VR retrofit, placeholder launchers, and hand-tracking API-layer caveats.
- Rule: source/documentation reading only; no builds, installs, launches, or device tests were performed.

## Shortlist

- `TheNewJavaman/unreal-vr`
- `gamenew09/RobloxVRLauncher`
- `ultraleap/OpenXRHandTracking`

## Project Notes

### `TheNewJavaman/unreal-vr`

- Interesting idea: flatscreen Unreal Engine game retrofit aiming for stereoscopic rendering, 6DoF headset movement, configurable profiles, and future input binding/controller tracking.
- Code donor value: useful as a high-risk retrofit architecture reference with loader DLL, launcher app, D3D11 service, OpenXR service, UE4 service, hooks, shaders, pipe client/server, and profile model.
- Product reference value: shows why retrofit tools need explicit support boundaries, profile sharing, engine-version detection, and service abstraction before user-facing promises.
- Source evidence: `UnrealVRLoader/*`, `UnrealVRLauncher/*`, `docs/writeup/`, `README.md`, and `rizin_to_uml.py`.
- Reusable core: launcher/profile UI, injected loader, graphics service, OpenXR service, game-engine service, hook helper, IPC pipe, shader path, and reverse-engineering notes.
- What not to copy: binary-hook assumptions, game-specific offsets, or no-release project status as stable product value.
- What to inspect next: service interfaces and launcher/loader IPC shape.

### `gamenew09/RobloxVRLauncher`

- Interesting idea: intended OpenVR dashboard overlay launcher for Roblox games without leaving VR.
- Code donor value: none currently; the cloned repository is empty.
- Product reference value: still useful as a placeholder signal that `in-VR launcher for non-VR/flat content` is a recurring product desire.
- Source evidence: empty repository clone and GitHub description.
- Reusable core: product idea only, not code.
- What not to copy: do not cite as implementation donor.
- What to inspect next: replace with a maintained launcher/overlay project if found.

### `ultraleap/OpenXRHandTracking`

- Interesting idea: archived implicit OpenXR API layer that injects `XR_EXT_hand_tracking` from Ultraleap tracking into OpenXR applications.
- Code donor value: deepened as a caveat source: changelog documents extension-gating, multiple-layer initialization, conformance fixes, tracking-service timeouts, logging path changes, UWP/WebXR support, installer/uninstaller behavior, and velocity/support-reporting caveats.
- Product reference value: excellent reminder that capability injection layers need honest active/inactive reporting, device-presence semantics, service connection state, and conformance-test feedback loops.
- Source evidence: `README.md`, `README.original.md`, `CHANGELOG.md`, `NOTICES.md`, and archived distribution notice.
- Reusable core: implicit layer distribution, extension request gating, service connection timeout, active-state reporting, logs, installer/uninstaller, and conformance-driven fixes.
- What not to copy: archived distribution path or reporting `supportsHandTracking` as true without clear device-active semantics.
- What to inspect next: compare against ILLIXR hand-tracking API-layer interface and current Ultraleap package.

## Extracted Method Candidate

`Retrofit launcher and capability-injection boundary`: split user-facing launcher/profile state from injected loader/layer services, and treat capability claims as dynamic runtime state rather than static feature labels.
