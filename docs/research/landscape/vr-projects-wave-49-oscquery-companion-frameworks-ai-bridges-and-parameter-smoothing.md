# VR Projects Wave 49: OSCQuery Companion Frameworks, AI Bridges, and Parameter Smoothing

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `OSCQuery companion frameworks`, `AI and automation bridges`, and
  `avatar-parameter smoothing layers`.

## Why this wave exists

`VR-apps-lab` already had routers, avatar-parameter bridges, and narrow desktop
automation helpers, but one companion-framework branch was still not explicit
enough:

- diagnostics-rich desktop hosts that treat `OSC` and `OSCQuery` as a service
  backplane instead of a one-off transport;
- reusable discovery libraries and examples that can be adopted by future tools
  directly;
- relay patterns that let AI or automation clients interact with VRChat
  without embedding raw `OSC` everywhere;
- editor-side layers that make noisy parameter streams usable on avatars.

This wave exists to make
`OSCQuery companion frameworks, AI bridges, and parameter smoothing`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with VRChat `OSCQuery`, diagnostics companion, automation
   relay, and smoothing-tool queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `OscToys/OscGoesBrrr` | Strong donor for a diagnostics-rich desktop companion with typed IPC and service boundaries |
| `lenoobkinda/VRCOSCUtils` | Useful comparison node for the weaker monolithic `mixed helper` end of the family |
| `vrchat-community/vrc-oscquery-lib` | Strong donor for reusable `OSCQuery` discovery and auto-connect primitives |
| `Krekun/vrchat-mcp-osc` | Strong donor for an automation or AI relay into VRChat `OSC` over a safer WebSocket boundary |
| `regzo2/OSCmooth` | Strong donor for editor-generated smoothing layers over avatar-facing `OSC` parameters |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `DASPRiD/vrc-osc-manager` | Strong repo, but it ultimately fit a better family as an avatar-facing accessory and plugin host rather than a pure companion-framework donor |

## Deep-pass notes by project

## `OscToys/OscGoesBrrr`

- GitHub:
  [OscToys/OscGoesBrrr](https://github.com/OscToys/OscGoesBrrr)
- What it is:
  an Electron and TypeScript desktop companion with typed IPC, diagnostics,
  update state, and `OSC` or `OSCQuery`-aware services.
- Why it matters:
  it is the clearest donor in the repo for
  `avatar-facing desktop companion with typed IPC and diagnostics surfaces`.
- Interesting ideas:
  make diagnostics first-class; keep frontend and backend communication typed;
  expose service status, config state, and transport health directly to the UI;
  build a broader shell instead of only a script.
- Interesting implementation choices:
  `electron-main.js`,
  `ipcContract.ts`, and
  the typed status payloads in the main app
  make the `desktop shell -> typed IPC -> discovery, config, and transport
  services` split unusually explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the product is broad and the licensing is more restrictive than many other
  donors, but the shell architecture remains strong.
- What to inspect next:
  keep it visible whenever a future branch needs
  `desktop host plus diagnostics surface plus service backplane`.

## `lenoobkinda/VRCOSCUtils`

- GitHub:
  [lenoobkinda/VRCOSCUtils](https://github.com/lenoobkinda/VRCOSCUtils)
- What it is:
  a mixed console utility that bundles Spotify, Soundpad, status, and related
  VRChat `OSC` helpers into one monolithic app.
- Why it matters:
  it is a useful comparison node for the `mixed helper repo` end of the family.
- Interesting ideas:
  one tool can bundle many narrow helper modes; console-menu UX can still be
  enough for some automation helpers; even weaker architecture donors can help
  show what stronger repos avoid.
- Interesting implementation choices:
  `Program.cs`
  makes the `console menu -> mode selection -> fixed localhost OSC sender`
  structure explicit.
- Code donor value:
  medium.
- Product reference value:
  medium.
- Architecture reference value:
  low-medium.
- Caveats:
  it is much weaker than the best donors in this family, so it is most useful
  as a comparison node rather than a mainline reference.
- What to inspect next:
  revisit only if a future pass needs clearer evidence of how
  `mixed helper` repos differ from better-structured companion shells.

## `vrchat-community/vrc-oscquery-lib`

- GitHub:
  [vrchat-community/vrc-oscquery-lib](https://github.com/vrchat-community/vrc-oscquery-lib)
- What it is:
  a reusable C# library and example set for `OSCQuery` discovery, HTTP
  advertising, and VRChat-compatible chatbox or tracker scenarios.
- Why it matters:
  it is the clearest donor in the repo for
  `OSCQuery-aware discovery and auto-connect primitives`.
- Interesting ideas:
  package discovery and service hosting as reusable library surfaces; ship
  examples for chatbox, trackers, and monitoring; let future tools discover
  peers instead of assuming hardcoded ports and hosts.
- Interesting implementation choices:
  the `OSCQueryExplorer` examples and
  `ChatboxSender.cs`
  make the `discover compatible service -> connect -> send chatbox or tracker
  traffic` flow explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  it is a framework donor more than a complete end-user product.
- What to inspect next:
  keep it visible whenever a future branch needs
  `discovery and auto-connect` as a shared utility layer.

## `Krekun/vrchat-mcp-osc`

- GitHub:
  [Krekun/vrchat-mcp-osc](https://github.com/Krekun/vrchat-mcp-osc)
- What it is:
  a monorepo that bridges VRChat `OSC` into an MCP-facing server through a
  relay server and shared WebSocket protocol.
- Why it matters:
  it is the clearest donor in the repo for
  `AI or automation bridge over a WebSocket relay into VRChat OSC`.
- Interesting ideas:
  keep raw `OSC` behind a relay; expose higher-level tools to automation
  clients; separate relay transport, shared types, and automation tools into
  explicit packages; add retries and fallback behavior around avatar data.
- Interesting implementation choices:
  `server.ts`,
  `avatarTools.ts`, and
  `relay-server.ts`
  make the `automation client -> MCP server -> WebSocket relay -> VRChat OSC`
  path explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  automation framing makes it broader than a typical VRChat utility, but the
  relay architecture is unusually reusable.
- What to inspect next:
  keep it visible whenever a future branch needs
  `higher-level tool interfaces over avatar-facing OSC`.

## `regzo2/OSCmooth`

- GitHub:
  [regzo2/OSCmooth](https://github.com/regzo2/OSCmooth)
- What it is:
  a Unity package that generates smoothing blendtrees and proxy parameters for
  `OSC`-driven avatar animations.
- Why it matters:
  it is the clearest donor in the repo for
  `editor-generated smoothing layers over avatar-facing parameter inputs`.
- Interesting ideas:
  smooth choppy inputs on the avatar side instead of forcing every sender to
  solve it; generate the animator scaffolding automatically; keep remote and
  local smoothing behavior configurable.
- Interesting implementation choices:
  `OSCmoothAnimationHandler.cs` and
  `OSCmoothBehavior.cs`
  make the `author parameter mapping -> generate smoothing assets -> decode
  runtime input` path explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium-high.
- Caveats:
  the strongest lesson is editor tooling and generated animator structure, not a
  desktop-side service.
- What to inspect next:
  keep it visible whenever a future branch needs
  `parameter cleanup on the avatar consumer side`.

## Main takeaways from Wave 49

- `Avatar-facing OSC companions` are broader than routers and narrow desktop
  actions.
- The strongest split in this family is:
  - `diagnostics-rich desktop companion shell`
  - `mixed helper comparison node`
  - `reusable OSCQuery discovery framework`
  - `AI or automation relay`
  - `avatar-side smoothing layer`
- The most reusable lesson is that `avatar-facing OSC` becomes much more
  manageable when the repo treats discovery, diagnostics, relay boundaries, and
  smoothing as first-class architecture surfaces.

## Reusable methods clarified by this wave

- `OSCQuery-aware discovery and auto-connect library for chatbox, tracker, or monitoring clients`
- `AI or automation bridge into VRChat OSC over a WebSocket relay`
- `Animator-side smoothing layer generated from avatar-facing OSC parameters`
- `Diagnostics-rich desktop companion shell over typed IPC and service status surfaces`
