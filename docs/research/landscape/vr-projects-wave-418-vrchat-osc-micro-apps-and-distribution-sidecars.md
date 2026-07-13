# VR Projects Wave 418 - VRChat OSC Micro Apps And Distribution Sidecars

- Date: `2026-07-13`
- Scope: small VRChat OSC apps, parameter senders, UI shells, and packaging collections.
- Rule: source/documentation reading only; no builds, installs, launches, or device tests were performed.

## Shortlist

- `99oblivius/Livi-s-VRChatOSC-Tools`
- `theepicsnail/vrchat_osc_app`
- `niwaniwa/VRChat-OSC-app`
- `noideaman/ArchOSCApps`

## Project Notes

### `99oblivius/Livi-s-VRChatOSC-Tools`

- Interesting idea: Rust VRChat OSC tool with explicit `osc_inputs.rs` and small binary structure.
- Code donor value: useful as a tiny typed OSC sender/receiver reference where the tool should remain script-sized but compiled.
- Product reference value: validates micro-utilities around avatar parameters without requiring a large companion suite.
- Source evidence: `Cargo.toml`, `src/main.rs`, and `src/osc_inputs.rs`.
- Reusable core: minimal Rust app, OSC input mapping module, command loop, and small deployment surface.
- What not to copy: project-specific parameter names without abstraction.
- What to inspect next: identify parameter schema and whether it supports bidirectional state.

### `theepicsnail/vrchat_osc_app`

- Interesting idea: minimal Python package for a VRChat OSC app with package entry point and small app module.
- Code donor value: useful as a Python micro-sidecar shape for quick OSC experiments.
- Product reference value: supports a `single-purpose OSC companion` direction for small avatar or accessibility helpers.
- Source evidence: `setup.py`, `vrchat_osc_app/app.py`, `vrchat_osc_app/__main__.py`, and README.
- Reusable core: Python package entry, app module, small runtime dependency surface.
- What not to copy: thin docs or untyped parameter flow.
- What to inspect next: whether the app has a stable config format.

### `niwaniwa/VRChat-OSC-app`

- Interesting idea: WPF/WPF UI/R3 GUI-based OSC app with dashboard, chat, data, and settings pages.
- Code donor value: useful as a desktop companion shell reference around OSC state, MVVM pages, configuration model, and Rug.Osc dependency.
- Product reference value: shows a Windows-native path for VRChat OSC utilities that want pages instead of scripts.
- Source evidence: `OSCApp.sln`, `Models/AppConfig.cs`, `Models/OscChatModel.cs`, `ViewModels/Pages/*`, `Views/Pages/*`, `Services/*`, and README.
- Reusable core: page service, app host service, config model, chat/data/settings pages, WPF UI shell, and OSC dependency.
- What not to copy: checked-in `bin/` and `obj/` artifacts or UI text without localization policy.
- What to inspect next: extract the OSC command/data model from UI code.

### `noideaman/ArchOSCApps`

- Interesting idea: Arch Linux PKGBUILD collection for VRChat OSC apps including ARCOSC Client, OSCLeash, tinyoscquery, and avatar scaler.
- Code donor value: packaging/distribution reference rather than runtime code donor.
- Product reference value: highlights a distribution problem for OSC sidecars: small tools need desktop entries, wrapper scripts, icons, package metadata, and dependency declarations.
- Source evidence: `README.md`, `*/PKGBUILD`, `*.desktop`, wrapper scripts, and `scaler_config.json`.
- Reusable core: package collection, launcher scripts, desktop entries, config file, and upstream-source references.
- What not to copy: distro-specific packaging without license/upstream freshness checks.
- What to inspect next: compare with `nixpkgs-xr` for a cross-distro XR utility packaging matrix.

## Extracted Method Candidate

`OSC micro-sidecar with packaging shell`: model avatar/OSC utilities as small apps with a clear parameter schema, optional GUI pages, config file, desktop/package wrapper, and distribution notes.
