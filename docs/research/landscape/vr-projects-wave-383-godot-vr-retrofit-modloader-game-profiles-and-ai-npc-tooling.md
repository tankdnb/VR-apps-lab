# Wave 383: Godot VR Retrofit, Modloader, Game Profiles, and AI NPC Tooling

## Theme

Godot VR retrofit and tooling projects: injector/profile workflows,
modloader-based XR patching, per-game profiles, and AI NPC interaction
surfaces that may become utility modules.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `teddybear082/UGVR` | Studied | Godot VR retrofit/injector shell with override config and XR injector folders |
| `teddybear082/UGVR_game_profiles` | Studied | Per-game profile collection for retrofit workflows |
| `teddybear082/CrueltySquadVR-Modloader` | Studied | Modloader-style VR patch project with override config and XR Tools class registration |
| `teddybear082/godot-ai-npc-example` | Studied | Godot AI NPC example with scripts, assets, and demo surface for conversational XR tools |

## Dedupe Notes

Previous waves covered OpenXR layers, game injection, voice/AI, and runtime
helpers. This wave focuses on Godot-side retrofit/config/profile patterns and
one AI NPC example as a utility-surface comparison.

## Code-Level Findings

### `teddybear082/UGVR`

- Interesting idea: use a Godot project plus `xr_injector` and override config
  folders as a retrofit envelope for adding VR behavior to existing games.
- Code donor value: `xr_injector`, `overridecfg`, `project.godot`, and README
  show the profile/injector boundary.
- Product reference value: useful for thinking about safe "VR adapter shells"
  where configuration and target identity must be explicit.
- What to inspect next: target game detection, rollback, compatibility matrix,
  and injector safety checks.
- Caveat: retrofit tooling has high user-risk; any future local tool needs
  dry-run, backup, and provenance UX.

### `teddybear082/UGVR_game_profiles`

- Interesting idea: separate per-game retrofit profiles from the injector/tool
  project so compatibility knowledge can evolve independently.
- Code donor value: game-named folders such as `(a)woken`, `Brutal Katana`,
  `CRUEL`, `Ex-Zodiac`, `Omega`, and `Road to Vostok Demo` show profile-pack
  organization.
- Product reference value: strong reference for future VR utility profile
  stores: per-target folder, compatibility notes, overrides, and provenance.
- What to inspect next: profile schema, target version matching, user edits,
  and conflict resolution.
- Caveat: profiles are only useful if target identity and version assumptions
  are documented.

### `teddybear082/CrueltySquadVR-Modloader`

- Interesting idea: modloader-style projects can register XR Tools classes and
  override config to retrofit a specific game with VR controls.
- Code donor value: `Install-Modloader.ps1`, `install_modloader.bat`,
  `modloader.gd`, `override.cfg`, `cs-vr-mod-vr-files`, and
  `cs-vr-mod-xr-tools` show install, override, and toolkit graft points.
- Product reference value: useful warning/reference for building reversible
  patchers and explicit class/asset registration.
- What to inspect next: install rollback, file target selection, XR Tools
  class registration, and user-facing error messages.
- Caveat: install scripts are not to be executed during research; study source
  only and design future tools with dry-run previews.

### `teddybear082/godot-ai-npc-example`

- Interesting idea: conversational AI NPC examples can be treated as XR utility
  surfaces when separated into scripts, assets, demos, fonts, and add-ons.
- Code donor value: `scripts`, `demo`, `assets`, `addons`, `fonts`, and
  `project.godot` show a compact AI interaction example envelope.
- Product reference value: relevant for future VR assistants, training guides,
  and in-world diagnostic helpers.
- What to inspect next: provider credentials, prompt/state handling, TTS/STT
  boundaries, offline fallback, and privacy labels.
- Caveat: do not reuse credential patterns or cloud assumptions without a
  consent/privacy design.

## Reusable Pattern Extraction

- Pattern candidate: VR retrofit profile/modloader plus AI NPC adapter shell.
- Problem solved: retrofit and assistant tools need a clear split between
  target-specific profiles, installer/injector logic, reusable XR assets, and
  user-visible safety/privacy state.
- Reusable core: injector shell, override config, game profile folder, target
  identity, dry-run target preview, backup/rollback, toolkit graft point,
  class-registration manifest, AI provider adapter, prompt/state boundary, and
  privacy/credential caveat.
- Source evidence: UGVR `xr_injector/overridecfg`, UGVR profile folders,
  CrueltySquadVR `Install-Modloader.ps1`, `override.cfg`, `modloader.gd`,
  `cs-vr-mod-xr-tools`, and AI NPC `scripts/demo/assets/addons` layout.
- Abstraction boundary: profile data should stay separate from installer code,
  and AI provider integration should stay separate from in-world NPC behavior.
- What not to copy: installer scripts without dry-run, target-specific patches
  as generic code, hidden backups, checked-in secrets, or cloud NPC behavior
  without privacy labels.
- Method catalog action: add Method 828.

## Family Placement

Creates a Godot VR retrofit/profile/modloader and AI NPC tooling family. It
connects injection/profile research with assistant/voice and safety UX work.

## Follow-Up Gaps

- Draft a reversible patcher/profile schema for retrofit utilities.
- Compare UGVR profile folders with prior runtime/operator helper methods.
- Inspect AI NPC provider boundaries for privacy-safe in-world assistants.
