# VR Projects Wave 428: PCVR Launch Profile and Quest Operator Companion Tools

Date: 2026-07-13

Theme: small Windows-side tools that reduce PCVR/Quest setup friction through launch
profiles, generated shortcuts, managed tooling, device status, and safety-gated
operator surfaces.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `harryeffinpotter/VRL` | PCVR launch-profile generators | Code-level pass |
| `MesmerPrism/Rusty-XR-Companion-Apps` | Quest operator companion surfaces | Code-level pass |

## Cross-Project Synthesis

This wave is about operator ergonomics rather than a single overlay runtime.
`VRL` is a narrow launcher generator: it inspects a game folder, guesses Unity or
Unreal launch targets, applies PCVR mode arguments, and emits shortcuts/wrappers
for Virtual Desktop, Link, and Oculus-oriented launch flows. `Rusty-XR Companion
Apps` is broader: it centralizes Quest app profiles, ADB/Meta tooling, diagnostics,
scrcpy/cast helpers, OSC utilities, and CLI/MCP/WPF operation surfaces around a
shared planner.

The reusable lesson is a `profiled operator companion`: keep runtime-specific
commands as catalog data, keep side-effecting actions behind an explicit plan, and
make device/app state visible before asking the user to run anything.

## Project Notes

### `harryeffinpotter/VRL`

- Interesting idea: a PCVR launcher that creates per-game launch wrappers for
  Quest users who need Virtual Desktop, Link, or Oculus flags without manually
  editing shortcuts every time.
- Code donor value: target-exe detection heuristics in `Form1.cs`, launch-mode
  batch templates, AppData settings, and desktop shortcut creation via
  `IWshRuntimeLibrary`.
- Product reference value: a tiny "make the right launcher for this headset path"
  utility is a useful VR-apps-lab micro-tool pattern.
- Architecture pattern: Windows Forms shell plus generated batch/exe wrappers and
  persistent profile settings.
- Reusable method: `PCVR launch-profile shortcut generator`.
- UX/product lesson: users understand launch modes better when each mode becomes
  a named desktop artifact instead of a hidden command-line flag.
- Caveats: bundled helper binaries, weak README, Windows-only assumptions, and
  heuristics that should be treated as inspiration rather than copied directly.
- Source evidence: `Form1.cs` scans folders for Unity `_data`, Unreal
  `*-Win64-Shipping.exe`, `win64`, and filtered executable names; `VD.bat`,
  `Link.bat`, and related templates encode launch profiles.
- Reusable core: target discovery, launch profile templates, generated shortcut
  output, readable fallback settings.
- What not to copy: bundled binary converters and opaque executable generation
  without provenance, signatures, or user-facing trust boundaries.
- Method catalog action: update a launch-profile/operator companion method.
- What to inspect next: whether a future VR-apps-lab launcher should generate
  transparent `.cmd`/`.ps1` launchers instead of opaque `.exe` wrappers.

### `MesmerPrism/Rusty-XR-Companion-Apps`

- Interesting idea: a Quest companion surface that shares one operation catalog
  across WPF, CLI, and MCP, with side effects planned before execution.
- Code donor value: `CompanionOperationSurface`, `CompanionOperationPlanner`,
  `QuestAdbService`, `CatalogLoader`, `ScrcpyService`, diagnostics report writers,
  managed tool cache logic, and app/runtime catalog schemas.
- Product reference value: a strong model for a VR utility "control room" that can
  expose the same safe actions to UI, CLI, and automation surfaces.
- Architecture pattern: shared core library, declarative catalogs, side-effect
  planner, multiple frontends, diagnostics bundle writer.
- Reusable method: `Quest operator companion with catalog-backed runtime profiles`.
- UX/product lesson: expose app state, headset/controller status, tool readiness,
  and the command plan before executing a side effect.
- Caveats: broad repo scope and source-workspace-specific profiles make it a
  pattern donor, not a drop-in dependency.
- Source evidence: `docs/api-cli-mcp.md` describes shared operation ids and
  side-effect gates; `catalogs/rusty-xr-quest-composite-layer.catalog.json`
  captures package ids and runtime profiles; `docs/architecture.md` documents the
  CLI/MCP/WPF split.
- Reusable core: operation catalog, safety label, command plan, managed tool
  location, app profile, runtime extras, diagnostics bundle.
- What not to copy: project-specific package ids, private workspace assumptions,
  and automation paths that can perform side effects without visible planning.
- Method catalog action: update a launch-profile/operator companion method.
- What to inspect next: whether VR-apps-lab should define a generic
  `vr-tool-operation-catalog.json` shape for future helper apps.

## Reusable Pattern Extraction

- Pattern candidate: `profiled VR operator companion`.
- Problem solved: VR utility workflows often require fragile launch flags, ADB
  commands, runtime extras, and diagnostic commands that users should not have to
  memorize.
- Reusable core: declarative app/profile catalog, device/tool readiness checks,
  explicit command plan, safety-gated execution, diagnostics bundle, and multiple
  operator surfaces.
- Source evidence: `VRL` shows the narrow launch-profile generator; `Rusty-XR
  Companion Apps` shows the larger shared planner/catalog model.
- Abstraction boundary: profile data and command planning should be reusable;
  third-party tool binaries and project-specific package ids should stay outside
  the core method.
- Method catalog action: add/update method for PCVR launch profiles and Quest
  operator companion surfaces.

## Follow-Up Gaps

- Compare launch-profile generation against Steam shortcuts, OpenComposite
  launchers, Virtual Desktop helper scripts, and OpenXR runtime switchers.
- Design a minimal transparent launcher format that avoids opaque generated
  binaries.
- Prototype a small catalog schema for headset app profiles, launch modes, and
  diagnostics actions.
