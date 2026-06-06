# GitHub Research Wave 216 Backlog

Date: 2026-06-06

Theme: OpenXR conformance, specification, validation layers, and runner
toolchain.

## Completed In This Wave

- Studied `KhronosGroup/OpenXR-CTS` as the official CTS architecture: CLI
  launcher, Catch2 test library, launch settings, graphics plugins,
  conformance API layer, generated dispatch, and report output.
- Studied `rpavlik/openxr-cts-runner` as a thin GUI/process wrapper around
  `conformance_cli`, including graphics API options, noninteractive filtering,
  additional arguments, output polling, and cancellation.
- Studied `KhronosGroup/OpenXR-Docs` as the spec/registry/tooling boundary for
  generated headers, extension inclusion, helper scripts, registry checks, and
  extension process rules.
- Deepened `KhronosGroup/OpenXR-SDK-Source` for API dump, core validation,
  loader tests, and runtime inventory/list-json helpers.
- Added a reusable method entry for an OpenXR conformance/diagnostics harness
  boundary.

## Follow-Up Queue

1. Build an OpenXR doctor matrix that separates runtime inventory, enabled API
   layers, extension support, graphics binding, CTS-style checks, API dump, and
   validation-message capture.
2. Compare `openxr-cts-runner` with earlier GUI runner/doctor patterns for
   progress display, output parsing, cancellation, and persisted presets.
3. Treat `OpenXR-CTS` as source evidence for harness boundaries, not as code to
   copy wholesale into a product.
4. Revisit earlier OpenXR layer waves and mark which projects can reuse CTS/SDK
   inventory and report concepts.
5. Consider a future reuse plan for a lightweight OpenXR capability report
   schema.

## Do Not Spend Time On Yet

- Do not run CTS, SDK tests, or loader examples as part of research waves.
- Do not imply a utility can certify conformance unless it follows Khronos
  conformance process requirements.
- Do not copy official tests, generated layer code, or spec material without a
  licensing and scope review.
