# VR Projects Wave 195: Twitch and Audience-Event to VRChat OSC Control Surfaces

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 195 studies Twitch and audience-event bridges that turn external events
into VRChat OSC actions. The reusable value is rule modeling, reward identity,
permission gates, cooldowns, world guards, action queues, timed reset pulses,
and streamer-facing control surfaces.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `seluvia/crystal-relay-public` | Mature Twitch/VRChat OSC relay | Strongest rule-engine/product donor |
| `AcChosen/EZTwitchOSCBot` | Electron Twitch chat command deck | Simple GUI command donor |
| `Motscoud/VRChatTwitchOSCTrigger` | Minimal Twitch IRC to OSC pulse script | Tiny baseline reference |
| `Killers0992/TwitchIntegration` | TwitchLib event integration and OSC action queues | Strong event-model donor |
| `Killers0992/TwitchVrcAvatarOSC` | Source-light successor pointer | Thin migration reference |
| `Maikatura/LucentOSC` | Native C++ Twitch/Discord/VRChat command app | Broad command-tree reference |
| `exmello/RizumuBot` | Twitch IRC camera-command OSC bot | Narrow parser/pulse donor |

## `seluvia/crystal-relay-public`

- Interesting idea:
  a mature Windows desktop app maps Twitch chat, channel points, bits, subs,
  follows, cash payments, avatar changes, movement, chatbox, scaling, managed
  rewards, and world guards into VRChat OSC actions.
- Code donor value:
  very high for universal trigger rules, action models, reward lifecycle,
  OSC address/value normalization, chat-command fallback fusion, moderation,
  world guard, and product-level UX.
- Product reference value:
  very high as the strongest streamer/audience-control product in this wave.
- What to inspect next:
  storage model, credential safety, Cloudflare world guard dependency,
  queue/execution semantics, and public rule import/export.
- Source evidence:
  `Services/UniversalTriggerFusionService.cs`,
  `Services/VrChatOscClient.cs`, `Models/UniversalTriggerRule.cs`,
  `Models/UniversalTriggerAction.cs`, and
  `Services/WorldCommandBlacklistService.cs`.
- Reusable pattern extraction:
  audience-event rule engine for VRChat OSC actions.
- Reusable core:
  represent every audience trigger as a typed rule, keep reward identity and
  cooldown metadata, normalize commands into action signatures, support
  queued/parallel actions with target/default values and durations, construct
  bounded OSC packets for avatar/input/chatbox paths, and apply world or
  moderation guards before executing actions.
- Do not copy directly:
  credentials, hosted dependencies, exact reward-management behavior, or
  fail-closed world guard policy without product-specific review.
- Caveats:
  strongest donor, but too broad to copy as a small utility.

## `AcChosen/EZTwitchOSCBot`

- Interesting idea:
  an Electron GUI lets streamers configure up to 12 Twitch chat commands, each
  with OSC address/value/type, optional timed second OSC message, bot response,
  whitelist, delay, and save/load profiles.
- Code donor value:
  medium for a simple command-slot GUI and timed reset action.
- Product reference value:
  high for approachable streamer setup.
- What to inspect next:
  data-driven refactor, command validation, secrets handling, and rate limits.
- Source evidence:
  `main.js` and `render.js`.
- Reusable pattern extraction:
  GUI command deck for Twitch chat to OSC actions.
- Reusable core:
  expose command slots, validate bot/channel/OAuth/ports, let users configure
  OSC value types and optional reset messages, save/load profiles, apply a
  command delay, and keep streamer-visible status.
- Do not copy directly:
  hardcoded 12-slot imperative state or raw OAuth handling as a final design.
- Caveats:
  good small-product reference, weaker architecture donor.

## `Motscoud/VRChatTwitchOSCTrigger`

- Interesting idea:
  a tiny Python script connects to Twitch IRC as an anonymous user, parses chat
  commands, sends OSC avatar parameters, and resets them shortly after.
- Code donor value:
  low-to-medium as the minimal Twitch IRC to OSC pulse baseline.
- Product reference value:
  medium for proof-of-value.
- What to inspect next:
  config, auth, command table, cooldown, and reset guarantees.
- Source evidence:
  `Patches VRCOSC Twitch.py`.
- Reusable pattern extraction:
  minimal chat command to timed OSC pulse.
- Reusable core:
  connect to Twitch IRC, respond to PING, parse `PRIVMSG`, map a command to an
  OSC path/value, send the value, wait briefly, and send a reset value.
- Do not copy directly:
  hardcoded channel, hardcoded commands, no moderation, no cooldown, and no
  config.
- Caveats:
  useful because it shows the smallest possible shape.

## `Killers0992/TwitchIntegration`

- Interesting idea:
  a C# TwitchLib integration handles chat commands, PubSub channel-point
  rewards, bits, subscriptions, follows, hosts, bans, timeouts, access gates,
  user/global delays, random actions, and OSC action queues.
- Code donor value:
  high for event-type-specific config, permission gates, cooldowns, reward id
  matching, range matching, and action queue dispatch.
- Product reference value:
  high for streamer moderation-aware action design.
- What to inspect next:
  plugin host boundaries, persistence, UI config, and relation to later
  Interfuse/Steam product.
- Source evidence:
  `Bot/TwitchEventHandlers.cs`, `Models/Twitch/TwitchCommand.cs`,
  `MainClass.cs`, and action dialog/model files.
- Reusable pattern extraction:
  Twitch event model with gated OSC action queues.
- Reusable core:
  route Twitch chat/PubSub events by type, filter by access roles and reward
  identity, apply global and per-user delays, select deterministic or random
  OSC actions, and enqueue duration/default-value actions for execution.
- Do not copy directly:
  plugin-specific dependencies, old host assumptions, or incomplete event paths.
- Caveats:
  strong model donor despite integration-context coupling.

## `Killers0992/TwitchVrcAvatarOSC`

- Interesting idea:
  source-light project pointing users toward a successor product.
- Code donor value:
  low.
- Product reference value:
  low-to-medium as a migration/lineage signal.
- What to inspect next:
  successor architecture if available and whether older code remains elsewhere.
- Source evidence:
  README.
- Reusable pattern extraction:
  source-light product migration reference.
- Do not copy directly:
  product claims without source.
- Caveats:
  keep as lineage only.

## `Maikatura/LucentOSC`

- Interesting idea:
  a native C++/ImGui app includes Twitch/Discord/VRChat command trees, Twitch
  IRC client code, and VRChat commands for movement, look, parameters, avatar
  change, and speech.
- Code donor value:
  medium for command-tree organization and native app framing.
- Product reference value:
  medium for broad social/command utility ambition.
- What to inspect next:
  command permissions, persistence, safety gates, and external dependency
  boundaries.
- Source evidence:
  `App/src/Twitch/TwitchApi.*`, `App/src/bot/Bot/VRChat/Commands/...`, and
  `Application.cpp`.
- Reusable pattern extraction:
  native command-tree app for chat/social commands to VRChat OSC.
- Reusable core:
  keep platform clients separate, parse chat messages into command nodes, map
  commands to VRChat-specific action classes, expose settings through a native
  UI, and reuse command abstractions across Twitch/Discord/local control.
- Do not copy directly:
  bundled dependencies, broad app assumptions, or movement/avatar commands
  without user-visible permission gates.
- Caveats:
  useful command taxonomy reference, less focused than Crystal Relay.

## `exmello/RizumuBot`

- Interesting idea:
  a C# Twitch IRC bot filters known bots/self messages, maps camera aliases to
  OSC commands, sends a timed float pulse, and replies to Twitch chat.
- Code donor value:
  medium for readable command parsing and timed OSC pulse behavior.
- Product reference value:
  medium for camera/stage control bots.
- What to inspect next:
  config validation, cooldowns, richer command tables, and error handling.
- Source evidence:
  `RizumuBot.cs`, `Commands/CameraCommand.cs`, and
  `VRChat/OSC/VrcOscSender.cs`.
- Reusable pattern extraction:
  Twitch command parser with timed OSC pulse actions.
- Reusable core:
  filter unwanted senders, parse prefixed commands, resolve aliases to a
  command id, send an OSC float pulse, wait a fixed duration, reset to zero,
  and send user-facing chat feedback.
- Do not copy directly:
  narrow camera-path assumptions or incomplete moderation handlers.
- Caveats:
  compact and readable; best as a micro-pattern.

## Cross-Project Lessons

- Audience-to-OSC tools need rule identity, not just command strings.
- Timed reset pulses are common and should be abstracted.
- Permission gates, global/user cooldowns, and world guards protect users from
  chat spam and malicious commands.
- Mature tools separate trigger detection from action execution.
- Simple command decks are valuable if they keep profile import/export and
  reset behavior visible.

## Reuse Recommendations

1. Use `crystal-relay-public` as the primary product and rule-engine donor.
2. Use `TwitchIntegration` for event-type models and permission/cooldown gates.
3. Use `EZTwitchOSCBot` for approachable command-slot GUI behavior.
4. Use `RizumuBot` and `VRChatTwitchOSCTrigger` for minimal pulse-command
   baselines.
5. Use `LucentOSC` for native command-tree organization.

## Follow-Up Gaps

- Build an audience-control safety matrix across command permissions,
  cooldowns, reward lifecycle, world guards, queue clearing, and reset actions.
- Extract a provider-neutral event rule schema that could accept Twitch,
  Discord, Stream Deck, local web panels, or OSCQuery inputs.
- Compare chatbox feedback strategies for streamer tools.
- Decide whether streamer/audience controls belong with overlay surfaces,
  VRChat OSC companions, or remote command panels.
