# Wave 450: Haptic pattern libraries and device feedback routing

## Theme

This wave studies haptic pattern repositories and playback libraries. The
reusable method is an event-to-haptic routing layer with pattern assets, device
position targets, runtime player/service dependency, directional mapping, and
fallback labels.

## Shortlist

| Project | Status | Family placement |
|---|---|---|
| `bhaptics/haptic-guide` | New study | Haptic pattern guide and game-event catalog |
| `bhaptics/haptic-library` | Deepened existing node | bHaptics playback library and Unity/C# samples |

## Project notes

### `bhaptics/haptic-guide`

- Interesting idea:
  a catalog of haptic patterns and integration notes across multiple VR games,
  showing how gameplay events map to tactile feedback assets.
- Code donor value:
  moderate for taxonomy: attacked, shooting, recoil, footsteps, explosion,
  healing, low health, directional enemy position, and device coverage.
- Product reference value:
  strong reference for building a haptic-event vocabulary before implementation.
- Architecture pattern:
  authored `.tact` pattern files plus per-game event lists plus Unity/Unreal
  integration pointers.
- Source evidence:
  README states patterns are generated in bHaptics Designer and links Unity and
  Unreal integration paths. Game notes list feedback events such as attack,
  death, shooting, respawn, recoil, heart thump, item pickup, healing, and
  directional feedback based on player/enemy transforms.
- Reusable core:
  haptic event name, target device/body part, pattern asset, direction source,
  intensity/duration, loop/one-shot mode, gameplay trigger, and fallback when a
  device is absent.
- What not to copy:
  game-specific pattern names, proprietary `.tact` assets, or tactile design
  claims without user testing.
- Method catalog action:
  creates `Haptic event routing and pattern library`.
- What to inspect next:
  normalize pattern names into a provider-neutral haptic intent schema.

### `bhaptics/haptic-library`

- Interesting idea:
  SDK/library samples for registering and submitting haptic patterns to bHaptics
  devices from C#, Unity, and platform-specific players.
- Code donor value:
  high for playback API shape: register file/pattern, submit dot/path points,
  submit registered pattern, check active devices, and package Unity samples.
- Product reference value:
  useful for a real haptic device adapter with honest player/service dependency.
- Architecture pattern:
  external player/service dependency plus SDK wrapper plus Unity plugin sample
  plus WPF/C# example.
- Source evidence:
  README requires bHaptics Player on Windows and points to Unity plugin samples.
  WPF sample uses `HapticPlayer`, `Register`, `Submit`, `SubmitRegistered`,
  `PositionType`, `DotPoint`, `PathPoint`, and `IsActive`. Unity sample README
  notes Windows player, Quest VR Player, migration guides, and plugin packages.
- Reusable core:
  provider client, app id/name, pattern registration, dynamic dot/path submit,
  device target enum, active-device query, platform player dependency, and
  migration/version caveat.
- What not to copy:
  obsolete SDK versions, bundled device assets, or a provider-locked event
  vocabulary as the only abstraction.
- Method catalog action:
  creates `Haptic event routing and pattern library`.
- What to inspect next:
  compare bHaptics with OpenXR haptics and controller haptic pulses.

## Synthesis

The reusable haptic layer should be intent-first:

- event name
- body/device target
- direction/source transform
- pattern asset id
- intensity/duration
- loop/stop behavior
- provider adapter
- device availability and fallback

## Follow-up backlog

- Define a provider-neutral haptic intent schema.
- Compare bHaptics pattern playback with OpenXR controller haptics.
- Track device availability and consent/fallback in future haptic utilities.
