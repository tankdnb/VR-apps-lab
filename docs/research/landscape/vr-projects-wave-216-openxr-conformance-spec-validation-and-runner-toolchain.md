# VR Projects Wave 216: OpenXR Conformance, Spec Validation, and Runner Toolchain

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-216-plan.md`
- `docs/research/program/github-research-wave-216-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

OpenXR diagnostic tools need a clear boundary between runtime inventory,
validation layers, conformance-style checks, generated registry knowledge,
graphics binding selection, and user-facing report UX. Wave 216 studies the
official Khronos conformance/specification stack and a thin runner shell to
extract architecture patterns for future OpenXR doctor and developer harnesses.

## Project Findings

### `KhronosGroup/OpenXR-CTS`

- Interesting idea: conformance is structured as a command-line launcher, a
  reusable test library, graphics plugins, a conformance API layer, generated
  dispatch, and report output rather than a single monolithic executable.
- Code donor value: very high as architecture evidence. `conformance_cli`
  builds launch settings and calls `xrcRunConformanceTests`; the conformance
  test library owns option parsing, test enumeration, runtime property and API
  layer/extension reporting, Catch2 listener/report integration, graphics
  plugin selection, and skip/filter behavior. The conformance layer adds API
  hooks, handle state, graphics validators, runtime failure reporting, and
  generated layer manifests.
- Product reference value: very high for OpenXR doctor, runtime bring-up,
  capability reports, and validation flows.
- Architecture pattern: CLI harness plus test library plus API layer plus
  generated registry/dispatch plus report writer.
- Reusable method: split runtime inventory, test execution, validation hooks,
  graphics binding, and report emission into separate components.
- Constraints and caveats: official conformance process, licensing, runtime and
  hardware requirements, large generated source, and test scope that is much
  wider than a normal utility should own.
- What to inspect next: report schema, graphics plugin coverage, extension test
  selection, and how noninteractive filtering should map into a friendly doctor
  UI.
- Why it matters for `VR-apps-lab`: it is the strongest source-level reference
  for OpenXR validation harness boundaries.

#### Reusable Pattern Extraction

- Pattern candidate: OpenXR conformance/diagnostics harness boundary.
- Problem solved: OpenXR utilities need trustworthy capability and validation
  reports without merging runtime inventory, API tracing, test execution, and
  UI into one brittle flow.
- Reusable core: launch settings, graphics binding selector, runtime/layer
  inventory, test case enumeration, skip/noninteractive filters, API-layer
  hooks, generated dispatch, report writer, and process/exit status handling.
- Source evidence: `conformance_cli/main.cpp`,
  `conformance_test/conformance_test.cpp`, `conformance_layer/*`,
  generated dispatch scripts, and extension test files.
- Abstraction boundary: official tests stay separate from product diagnostics;
  a product can reuse harness concepts and report shape without becoming CTS.
- What not to copy: conformance claims, heavy generated internals, full test
  suite scope, or hardware-dependent assumptions without target review.
- Method catalog action: create Method 661.

### `rpavlik/openxr-cts-runner`

- Interesting idea: a small Rust/egui app can make a CLI test harness usable by
  wrapping configuration, launch, stdout/stderr capture, completion, and cancel
  state without reimplementing the underlying test logic.
- Code donor value: high for product UX. `config.rs` maps graphics API choices
  to CTS `-G` arguments and adds noninteractive filtering; `process.rs` starts
  `conformance_cli` or `conformance_cli.exe` and polls combined output;
  `state.rs` owns running/done/error state; `app.rs` renders configuration and
  running panes.
- Product reference value: high for thin doctor/runner shells.
- Architecture pattern: persisted GUI state plus command builder plus process
  wrapper plus output console.
- Reusable method: prefer a thin runner around authoritative CLI tools when the
  CLI already owns the hard validation logic.
- Constraints and caveats: experimental, output is text-first, no rich result
  parser, and the underlying CTS location is assumed.
- What to inspect next: preset storage, result parsing, and how to turn command
  output into actionable cards.
- Why it matters for `VR-apps-lab`: it is a compact UX donor for wrapping
  diagnostic CLIs.

### `KhronosGroup/OpenXR-Docs`

- Interesting idea: the OpenXR specification project treats registry XML,
  generated headers, extension inclusion, extension process docs, style guides,
  and spec/link checks as one governed documentation/tooling system.
- Code donor value: high as process and metadata evidence. The repository has
  `registry/xr.xml`, Asciidoctor spec sources, helper scripts such as
  `makeSpec`, extension-specific build helpers, generated-header targets,
  schema/link checks, extension process documentation, and release/version
  metadata.
- Product reference value: high for any OpenXR utility that needs to explain
  extension status, provisional/vendor/KHR/EXT distinctions, or registry-backed
  capabilities.
- Architecture pattern: registry-driven spec/tooling source of truth with
  generated outputs and validation checks.
- Reusable method: tie runtime capability reports back to registry/spec names,
  extension category, and caveat text instead of displaying raw strings only.
- Constraints and caveats: documentation repository, not app logic; official
  text should be referenced rather than copied.
- What to inspect next: registry parsing, extension dependency extraction, and
  public spec anchor mapping for validation messages.
- Why it matters for `VR-apps-lab`: it strengthens OpenXR extension literacy
  inside future diagnostics.

### `KhronosGroup/OpenXR-SDK-Source`

- Interesting idea: the SDK source provides practical validation and inventory
  layers around the OpenXR loader: API dump, core validation, list/list-json,
  loader tests, and sample scaffolding.
- Code donor value: very high for diagnostics. `api_dump.cpp` negotiates as an
  API layer, wraps `xrGetInstanceProcAddr`, records command parameters, and
  writes text/HTML output. `core_validation.cpp` tracks handles/objects,
  reads environment output settings, emits validation IDs, and routes messages
  through stdout/file/HTML or `XR_EXT_debug_utils`. `list_json.cpp` creates an
  instance, reads runtime properties, extensions, platform, vendor hints, view
  configurations, and emits JSON-style inventory. `loader_test.cpp` shows
  Catch2-driven loader environment and runtime/layer test scaffolding.
- Product reference value: very high for OpenXR doctor, API trace viewers,
  runtime inventory tools, and debug-layer UX.
- Architecture pattern: API layer interception plus generated dispatch table
  plus structured runtime inventory helper plus loader test harness.
- Reusable method: make diagnostics composable: inventory first, trace/validate
  only when explicitly enabled, and expose output sinks clearly.
- Constraints and caveats: official SDK internals, generated code, API layer
  activation semantics, environment variables, and platform-specific loader
  behavior.
- What to inspect next: debug-utils output mapping, layer manifest discovery,
  and how list-json schema could become a stable local report format.
- Why it matters for `VR-apps-lab`: it complements CTS with everyday developer
  diagnostics.

## Cross-Project Lessons

- OpenXR diagnostics should have layers: inventory, registry/spec explanation,
  validation/API dump, conformance-style test invocation, and report UI.
- A thin GUI runner is valuable when it keeps CLI authority intact and only
  improves configuration, output capture, cancellation, and presets.
- Validation messages become more useful when they link back to spec anchors,
  VUID-like IDs, runtime/layer metadata, and extension category context.
- Official CTS material is best treated as source evidence and process
  boundary, not product code to absorb.

## Method Catalog Actions

- Added Method 661: OpenXR conformance and diagnostics harness boundary.

## Follow-Up Gaps

- Build a lightweight OpenXR doctor report schema that separates runtime,
  loader, API layers, extensions, graphics binding, validation output, and
  skipped checks.
- Compare CTS runner UX against earlier runtime inspector and overlay doctor
  ideas.
- Add a future reuse plan if an OpenXR doctor prototype becomes active.
