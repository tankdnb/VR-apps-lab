# GitHub Research Wave 216 Plan

Date: 2026-06-06

Theme: OpenXR conformance, specification, validation layers, and runner
toolchain.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

OpenXR utility work needs a stronger validation branch. A useful doctor,
runtime inspector, or developer harness should be able to explain what runtime
is present, which extensions and layers are exposed, how API calls are traced,
and where a conformance-style test or report boundary begins.

Wave 216 studies the official OpenXR conformance/specification toolchain plus a
thin runner UI to extract reusable diagnostic patterns without treating CTS as
product code.

## Search Families

- OpenXR conformance and CTS harnesses.
- OpenXR specification, registry, and extension-process tooling.
- OpenXR API dump and core validation layers.
- Thin runner shells around command-line test tools.
- Runtime inventory/list helpers and report formats.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `KhronosGroup/OpenXR-CTS` | Official conformance test suite with CLI, Catch2 harness, conformance API layer, graphics plugins, generated dispatch, and report output. | OpenXR conformance harness |
| `rpavlik/openxr-cts-runner` | Experimental Rust/egui GUI wrapper around `conformance_cli` with graphics API selection, noninteractive filtering, output capture, and cancel/OK flow. | Thin CTS runner UI |
| `KhronosGroup/OpenXR-Docs` | Specification, registry, extension process, header generation, helper scripts, and validation/check tooling. | Spec and registry governance |
| `KhronosGroup/OpenXR-SDK-Source` | Already studied, deepened here for API dump, core validation, list-json inventory, and loader-test scaffolding. | Validation layer and inventory substrate |

## Dedupe Notes

`KhronosGroup/OpenXR-SDK-Source` was already present in the registry. This wave
does not duplicate it as a new repo; it deepens the existing entry specifically
for validation/API-layer/inventory lessons. `OpenXR-CTS`, `OpenXR-Docs`, and
`openxr-cts-runner` were not already represented as separate studied nodes.

## Code-Level Pass Targets

- CLI harness, launch settings, and report boundaries.
- Test enumeration, filtering, skip/noninteractive behavior, and extension
  coverage.
- API layer hooks, validation message output, API dump capture, and generated
  dispatch.
- Runtime inventory JSON/list helpers.
- Specification registry, extension process, and generated-header flow.
- Thin GUI process wrapper and output-capture UX.

## Expected Outputs

- Wave 216 landscape synthesis.
- Registry and family entries for OpenXR conformance/spec validation tooling.
- Method catalog entry for an OpenXR conformance/diagnostics harness boundary.
- Follow-up backlog for a reusable OpenXR doctor/report matrix.
