# VR Projects Wave 154: Virtual Displays, Spatial-Display OpenXR Runtimes, and Desktop Fallback Surfaces

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 154 looks at display surfaces from several directions: creating a virtual
monitor on Linux, making OpenXR target spatial displays instead of headsets,
viewing stereo images in OpenXR, preserving historical DIY display lessons, and
letting an XR app run from desktop inputs when no headset is present.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `VirtualDrivers/Linux-Virtual-Display-Driver` | Virtual display workflow tools | Strong code and UX donor |
| `dfattal/openxr-3d-display` | Spatial-display OpenXR runtimes | Strong architecture donor |
| `maximum-game-22/openxr-3d-display` | Fork/variant comparison | Variant only |
| `newilia/SbsImageViewer` | Stereo media utility surfaces | Medium code/product donor |
| `r57zone/VR-Display` | Historical display hardware references | Source-light concept reference |
| `tejasXR/Virtual-Desktop-VR` | Desktop-in-VR historical POCs | Low donor, historical reference |
| `Malcolmnixon/GodotXRDesktop` | No-HMD engine fallback surfaces | Strong engine-pattern donor |

## `VirtualDrivers/Linux-Virtual-Display-Driver`

- Interesting idea:
  a GTK Linux app creates and manages virtual displays through xrandr, modeline
  generation, EDID files, NVIDIA setup, and persistent display state.
- Code donor value:
  high for virtual-display workflow architecture.
- Product reference value:
  high. It packages a fragile display-server workflow behind a clear GUI.
- What to inspect next:
  compare with Windows virtual display drivers, XR-glasses desktop helpers, and
  streaming tools that require a stable virtual monitor.
- Architecture pattern:
  Python/GTK app detects display server/GPU, parses xrandr outputs, generates
  CVT modelines, selects disconnected outputs, adds/enables modes, positions
  virtual displays relative to a primary output, saves state under
  `~/.config/linux-vdd/displays.json`, and provides NVIDIA EDID/xorg setup via
  privileged helpers.
- Reusable method:
  xrandr virtual-output state machine with persistent config, virtual EDID,
  login-screen monitor handling, and GPU-specific setup path.
- Caveats:
  X11-focused with no complete Wayland-native path.

## `dfattal/openxr-3d-display`

- Interesting idea:
  DisplayXR turns OpenXR into a runtime for spatial displays and 3D monitors
  instead of assuming a headset-first presentation model.
- Code donor value:
  high as architecture/reference material, not as something to copy wholesale.
- Product reference value:
  high. It demonstrates how a specialized OpenXR runtime can serve a non-HMD
  display class with explicit app classes and compositor boundaries.
- What to inspect next:
  map DisplayXR app classes and layer boundaries against headsetless, virtual
  display, and XR-glasses workflows.
- Architecture pattern:
  Monado-derived runtime split into OpenXR state tracker, graphics-specific
  native compositors, device drivers, display processors, and shell/controller
  policy. App classes include handle, texture, hosted, and IPC/service modes.
- Reusable method:
  spatial-display runtime split where display processors own atlas-to-display
  conversion while compositors own graphics API targets and the state tracker
  owns OpenXR validation/session dispatch.
- Caveats:
  large runtime-scale project; reuse the boundary model and docs, not code
  fragments without a dedicated runtime plan.

## `maximum-game-22/openxr-3d-display`

- Interesting idea:
  a fork/variant of the DisplayXR spatial-display runtime line.
- Code donor value:
  low in this wave because the canonical upstream is clearer.
- Product reference value:
  medium as a variant marker.
- What to inspect next:
  compare only if the fork diverges materially from `dfattal/openxr-3d-display`.
- Architecture pattern:
  fork/variant lineage rather than a separate family anchor.
- Caveats:
  keep as comparison node, not a full standalone donor.

## `newilia/SbsImageViewer`

- Interesting idea:
  a Russian OpenXR stereo image viewer supports side-by-side images, separate
  left/right files, angular size/distance controls, labels, drag/drop launch,
  and remembered paths.
- Code donor value:
  medium. The stereo source handling and desktop launcher are useful, but the
  code also bundles external example material.
- Product reference value:
  medium-high. It is a compact reference for projection/source-aware media
  utility UX.
- What to inspect next:
  compare with earlier immersive video/image viewers and separate viewer code
  from vendored examples before reuse.
- Architecture pattern:
  Tkinter launcher handles drag/drop and remembered path state, starts the
  viewer process without blocking on stdout, while the OpenXR viewer splits SBS
  images or loads separate eye files, creates OpenGL textures, labels images,
  and exposes in-XR distance/angular-size controls.
- Reusable method:
  stereo media utility with desktop launch shell and in-XR projection controls.
- Caveats:
  separate reusable viewer logic from bundled pyopenxr examples.

## `r57zone/VR-Display`

- Interesting idea:
  a historical DIY HDMI/MIPI display and USB gyro concept for Cardboard-like VR
  hardware without a built-in screen.
- Code donor value:
  low. The repository is mostly README/images.
- Product reference value:
  medium as a hardware checklist and historical concept.
- What to inspect next:
  revisit only for DIY headset display BOM or hardware-bring-up comparisons.
- Architecture pattern:
  concept-level bill-of-materials and hardware wiring notes around HDMI/MIPI
  controller, STM32 USB gyro, IMU, brightness, power, and axis/orientation
  tests.
- Caveats:
  historical/source-light, not a software donor.

## `tejasXR/Virtual-Desktop-VR`

- Interesting idea:
  an old Unity/SteamVR virtual desktop POC.
- Code donor value:
  low. The repository is mostly bundled SteamVR plugin material with little
  project-specific implementation.
- Product reference value:
  low-medium as a historical desktop-in-VR signal.
- What to inspect next:
  no urgent follow-up unless historical Unity/SteamVR student examples become
  useful.
- Architecture pattern:
  source-light Unity project with minimal project-specific script surface.
- Caveats:
  do not treat as a current desktop overlay donor.

## `Malcolmnixon/GodotXRDesktop`

- Interesting idea:
  a Godot addon lets an XR game be driven as a normal desktop 3D experience by
  injecting synthetic XR trackers and action values when XR is not active.
- Code donor value:
  high for no-HMD testing and desktop fallback design.
- Product reference value:
  high. It turns headset absence into a deliberate workflow instead of a hard
  blocker.
- What to inspect next:
  compare with WebXR emulators, fake OpenVR drivers, and `AutoHandSimulator`
  to design a cross-engine no-HMD testing pattern.
- Architecture pattern:
  Godot script synthesizes `XRPositionalTracker` and `XRControllerTracker`
  objects, registers them with `XRServer`, maps desktop movement/head-look/right
  mouse drag to head/controller poses, and converts Godot Input Map entries into
  OpenXR action values.
- Reusable method:
  no-HMD desktop fallback by injecting synthetic XR trackers and action values
  into the engine XR server.
- Caveats:
  Godot-specific, but the boundary is broadly reusable: fake trackers and
  action injection should sit behind the same interface as real XR input.

## Cross-Project Lessons

- `Virtual display` is not one thing. It can mean OS-level fake outputs,
  runtime-level special-display support, media viewers, DIY hardware, or
  engine-level no-HMD fallbacks.
- The most reusable display utilities document their state machine: create,
  enable, position, persist, disable, remove, and recover.
- DisplayXR adds an important architecture lesson: display-specific processing
  should be separated from OpenXR session validation and graphics API swapchain
  management.
- No-HMD workflows are not only test hacks. They are a serious productivity
  layer for VR utility development.

## Reusable Methods Extracted

- Xrandr virtual display manager with CVT modelines, virtual EDID, NVIDIA
  setup, and persistence.
- Spatial-display OpenXR runtime split with native compositor and display
  processor boundaries.
- Projection/source-aware stereo image viewer with desktop launcher.
- Desktop/no-HMD synthetic XR trackers and action injection.

## Follow-Up Backlog

- Build a `display surface taxonomy` that separates OS virtual monitor, runtime
  spatial display, captured desktop, stereo media surface, and fake-XR fallback.
- Compare `Linux-Virtual-Display-Driver` with Windows virtual display driver
  lines and XR-glasses workspace helpers.
- Use `GodotXRDesktop` and `AutoHandSimulator` as anchors for a no-HMD workflow
  synthesis.
