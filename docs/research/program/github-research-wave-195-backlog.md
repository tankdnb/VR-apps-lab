# GitHub Research Wave 195 Backlog

- Date: `2026-06-06`
- Theme: `Twitch and audience-event to VRChat OSC control surfaces`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for Twitch VRChat OSC, channel point OSC, chat command
  avatar parameter, Twitch integrations, and audience command bots.
- `Done` Dedupe against earlier audience overlay and chatbox waves.
- `Done` Freeze a rule-engine and command-bot shortlist.

## Source Sync

- `Done` Confirm `crystal-relay-public` in local-only cache.
- `Done` Confirm `EZTwitchOSCBot` in local-only cache.
- `Done` Confirm `VRChatTwitchOSCTrigger` in local-only cache.
- `Done` Confirm `TwitchIntegration` in local-only cache.
- `Done` Confirm `TwitchVrcAvatarOSC` in local-only cache.
- `Done` Confirm `LucentOSC` in local-only cache.
- `Done` Confirm `RizumuBot` in local-only cache.

## Code Reading

- `Done` Inspect Crystal Relay trigger rules, action models, chat-command
  fallback fusion, manual OSC packet construction, managed rewards, world
  command blacklist, avatar/input/chatbox actions, and moderation/product UX.
- `Done` Inspect Electron/tmi.js/osc-js command slots, timed second OSC
  messages, settings save/load, whitelist, custom ports, and renderer IPC in
  `EZTwitchOSCBot`.
- `Done` Inspect minimal Twitch IRC parsing and hardcoded OSC pulse commands in
  `VRChatTwitchOSCTrigger`.
- `Done` Inspect TwitchLib chat/PubSub event handlers, command access gates,
  global/user cooldowns, reward/bits/sub/follow/ban/timeout event configs, and
  OSC action queues in `TwitchIntegration`.
- `Done` Mark `TwitchVrcAvatarOSC` as source-light successor/product migration
  reference.
- `Done` Inspect native Twitch IRC command tree, VRChat command classes,
  parameter/avatar/speak/movement commands, and ImGui settings in `LucentOSC`.
- `Done` Inspect RizumuBot command parser, camera aliases, timed OSC pulses,
  bot/self filtering, and settings structure.

## Integration

- `Done` Create Wave 195 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for audience-event rule engines and Twitch chat
  command OSC pulse bots.
- `Next` Build an audience-control safety matrix covering permission gates,
  per-user cooldowns, world guards, reward lifecycle, action queues, and
  emergency reset behavior.
