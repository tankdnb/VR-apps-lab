# GitHub Research Wave 195 Plan

- Date: `2026-06-06`
- Theme: `Twitch and audience-event to VRChat OSC control surfaces`
- Scope: Twitch chat, channel points, bits, follows, subs, audience commands,
  rule engines, moderation gates, and OSC action pulses into VRChat.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

VR streamer tools connect external audience events to in-world actions. Wave
195 studies the safe and reusable boundaries: trigger rules, reward identity,
permission gates, cooldowns, world guards, action queues, timed reset pulses,
chatbox/VRChat commands, and moderation surfaces.

## Search Families

- Twitch to VRChat OSC bots
- channel-point to avatar parameter controllers
- audience event rule engines
- Twitch chat command to OSC pulse tools
- stream moderation and world guard helpers

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `seluvia/crystal-relay-public` | Mature Windows Twitch/VRChat OSC rule engine with channel points, chat, bits, subs, follows, managed rewards, world guard, and OSCQuery | Strongest product/rule-engine donor |
| `AcChosen/EZTwitchOSCBot` | Electron GUI command deck with timed reset messages, profiles, whitelist, and custom OSC values | Simple GUI command donor |
| `Motscoud/VRChatTwitchOSCTrigger` | Tiny Twitch IRC command to OSC pulse proof of concept | Minimal baseline reference |
| `Killers0992/TwitchIntegration` | C# TwitchLib integration with commands, PubSub, rewards, bits/sub/follow/ban/timeout events, access gates, cooldowns, and action queues | Strong event-model donor |
| `Killers0992/TwitchVrcAvatarOSC` | Source-light successor pointer/product migration node | Thin migration reference |
| `Maikatura/LucentOSC` | Native C++/ImGui Twitch/Discord/VRChat command app | Broad native command-tree reference |
| `exmello/RizumuBot` | C# Twitch IRC bot with OSC camera command pulses | Narrow command parser donor |

## Dedupe Notes

- Earlier audience/chat overlay waves covered display surfaces; this wave is
  focused on audience event to OSC action execution.
- Source-light migration nodes are documented as product references only.
- No Twitch login, OAuth, IRC connection, VRChat OSC, or local service was
  started.

## Code-Level Pass Targets

- Trigger rule models and reward identity.
- Chat command fallback and action signature fusion.
- OSC packet building and normalized address/value handling.
- Permission gates, cooldowns, world guards, and moderation controls.
- Timed action reset pulses and queued/parallel execution.
- GUI profile import/export and simple command-slot UX.

## Expected Outputs

- Wave 195 landscape synthesis.
- Registry/family placement for Twitch/audience-event control surfaces.
- Methods around audience event rule engines and chat-command OSC pulse bots.
