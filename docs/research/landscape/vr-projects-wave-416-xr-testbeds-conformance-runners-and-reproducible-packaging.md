# VR Projects Wave 416 - XR Testbeds Conformance Runners And Reproducible Packaging

- Date: `2026-07-13`
- Scope: XR system testbeds, conformance runners, and reproducible Linux XR package overlays.
- Rule: source/documentation reading only; no builds, installs, launches, or device tests were performed.

## Shortlist

- `ILLIXR/ILLIXR`
- `nix-community/nixpkgs-xr`
- `KhronosGroup/OpenXR-CTS`
- `rpavlik/openxr-cts-runner`

## Project Notes

### `ILLIXR/ILLIXR`

- Interesting idea: large modular XR research testbed with switchboard-style plugin dataflow, profiles for headless/native/Monado/offload modes, and documented plugins for hand tracking, lighthouse, timewarp, OpenWarp, ZED, webcam, and remote rendering.
- Code donor value: useful as a system architecture donor for plugin manifests, profile-driven runtime selection, dataflow docs, logging/metrics, and clear subsystem README files.
- Product reference value: validates a `research harness for XR subsystems` direction where pose, VIO, render, hand tracking, and offload components can be studied independently.
- Source evidence: `profiles/*.yaml`, `plugins/*/README*`, `docs/docs/dataflow.md`, `docs/docs/illixr_plugins.md`, and Monado integration docs.
- Reusable core: plugin registry, switchboard data channels, profile files, documented subsystem contracts, headless/native/Monado mode split, and per-plugin debug viewers.
- What not to copy: monolithic research-testbed scale, external dependency weight, or old platform assumptions as a default utility baseline.
- What to inspect next: profile schema, switchboard/phonebook abstractions, and how per-plugin docs map to runtime diagnostics.

### `nix-community/nixpkgs-xr`

- Interesting idea: Nix overlay collecting XR packages, overrides, pinned sources, and NixOS module wiring for Monado, WiVRn, WayVR, OpenComposite, xrizer, xrbinder, xr-chaperone, and smaller XR utilities.
- Code donor value: strong distribution-pattern reference for reproducible XR toolchains, source pinning, package override boundaries, and update automation.
- Product reference value: shows that XR utility ecosystems need package orchestration, not just app code.
- Source evidence: `flake.nix`, `nixos/default.nix`, `pkgs/overlay.nix`, `_sources/generated.nix`, `nvfetcher.toml`, and `pkgs/overrides/*.nix`.
- Reusable core: curated source table, overlay injection, package overrides, module enable flag, maintainer metadata, patch provenance, and runtime-tool package grouping.
- What not to copy: Nix-specific assumptions into Windows docs, or package pins without clear update/verification policy.
- What to inspect next: whether `VR-apps-lab` should track a distribution matrix for studied runtime helpers.

### `KhronosGroup/OpenXR-CTS`

- Interesting idea: official OpenXR conformance suite with CLI runner, generated dispatch, conformance layer generation, runtime manifests, test runtimes, graphics backends, and Android/Windows release workflows.
- Code donor value: already known, but deepened here as a validation harness model rather than an implementation donor.
- Product reference value: gives vocabulary for future `XR doctor` tools: runtime manifest discovery, layer reporting, feature capability tests, and conformance-style result grouping.
- Source evidence: `src/conformance/conformance_cli/main.cpp`, `src/scripts/*generator.py`, `src/tests/test_runtimes/`, `src/loader/*`, and `changes/conformance/`.
- Reusable core: test grouping, generated dispatch, manifest generation, runtime/layer discovery, platform build matrix, and artifact organization.
- What not to copy: conformance authority claims or the full CTS scope for small diagnostics.
- What to inspect next: extract a tiny `runtime/layer capability report` checklist inspired by CTS.

### `rpavlik/openxr-cts-runner`

- Interesting idea: experimental GUI wrapper for running OpenXR CTS tests with config, process management, state, and app UI separation.
- Code donor value: useful as a small operator-shell reference around an external validation executable.
- Product reference value: supports a future `diagnostic runner UI` pattern: configure target, run external tool, capture process state, surface result.
- Source evidence: `src/app.rs`, `src/config.rs`, `src/process.rs`, `src/state.rs`, and `README.md`.
- Reusable core: config model, process runner, state machine, UI shell, and explicit separation from the validation binary.
- What not to copy: assuming CTS is appropriate for normal end users.
- What to inspect next: compare with existing `OpenXR doctor` method notes for a smaller user-facing harness.

## Extracted Method Candidate

`XR validation and packaging harness`: treat runtime/tool reliability as a combination of profile selection, source pinning, package overrides, external validation runners, subsystem manifests, and small operator UIs rather than one opaque app launch.
