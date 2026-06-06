# VR Projects Wave 214: VRChat/Udon Menu Package Surfaces, World Admin, and Creator Prefabs

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-214-plan.md`
- `docs/research/program/github-research-wave-214-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

VR menus are not only radial buttons. In creator worlds they become local
panels, player selectors, permission gates, diagnostics consoles, update
dispatchers, package ecosystems, and operator surfaces.

Wave 214 studies VRChat/Udon menu and package projects because they show how
small world utilities expose actions to users without needing a standalone app.

## Project Findings

### `Varneon/UdonEssentials`

- Interesting idea: a world utility collection can expose reusable prefabs for
  player settings, player lists, music control, groups, diagnostics console,
  and update event dispatch.
- Code donor value: medium to high despite deprecation. `EventDispatcher.cs`
  centralizes Fixed/Update/Late/PostLateUpdate callbacks through
  `SendCustomEvent`, add/remove arrays, counts, and leave cleanup.
  `UdonConsole.cs` implements in-world log entries, filters, timestamps,
  warnings/errors, overflow reuse, and scroll/layout rebuilds. `Playerlist.cs`
  tracks join time, master, player count, VR indicator, and optional groups.
- Product reference value: high for in-world diagnostics and prefab utility
  packaging.
- Architecture pattern: Udon prefab collection with shared runtime helper
  components.
- Reusable method: provide small prefab-level services such as event dispatch,
  console, player list, and settings rather than one giant world manager.
- Constraints and caveats: deprecated in favor of VUdon, older UdonSharp style,
  and VRChat-specific APIs.
- What to inspect next: migration path to VUdon, prefab setup docs, and how
  console/event dispatcher contracts changed.
- Why it matters for `VR-apps-lab`: it is a useful reference for tiny in-world
  diagnostics and runtime helper prefabs.

### `Varneon/VUdon`

- Interesting idea: a deprecated monolithic utility collection can become a
  package ecosystem with focused modules and visible package status.
- Code donor value: low from the index itself, but high as product/package
  reference. The package map includes Simple Player Settings, Noclip,
  Playerlist, Logger, Array Extensions, Udonity, Common, Event Dispatcher,
  Quick Menu, Menus, Events, Music Player, Player Tracker, Roles, World
  Markers, and Footsteps.
- Product reference value: very high for modular creator tooling and installable
  utility packages.
- Architecture pattern: VPM/package ecosystem replacing one broad prefab repo.
- Reusable method: split world utilities by user value and shared dependencies,
  then expose status and install routes clearly.
- Constraints and caveats: index-level evidence only for many packages; deeper
  package-specific source passes are still needed.
- What to inspect next: VUdon Menus, Quick Menu, Logger, Common, Event
  Dispatcher, and Roles packages as separate donors.
- Why it matters for `VR-apps-lab`: it informs how this repo can treat reusable
  VR utility code as small modules rather than one app.

### `SylanTroh/GMMenu`

- Interesting idea: a VRChat roleplay/admin menu can combine VR/desktop
  activation, permission gates, synced pings, teleport/summon/undo, remote
  watch camera, settings panels, and HUD messages.
- Code donor value: high. `GMMenu.cs` gathers module references for toggle,
  messages, voice modes, teleport, permissions, mover, watch camera, selectors,
  viewports, and settings. `GMMenuToggle.cs` supports VR joystick gestures,
  desktop Tab, hand/head placement, avatar-height scaling, left/right hand
  pivots, permission gates, and event listeners. `PlayerPermissions.cs` handles
  base and temporary permissions plus name and URL-loaded lists.
  `MessageSyncManager.cs` manages per-player message slots and sorted unread or
  urgent messages. `Teleporter.cs` implements previous-pose save, teleport,
  undo, summon, ownership slots, and events.
- Product reference value: very high for world-operator menus and
  permission-gated action surfaces.
- Architecture pattern: central menu shell plus UdonSharp action modules plus
  permissions and player selectors.
- Reusable method: make high-impact actions go through visible permissions,
  selected target state, reversible commands, and event-driven UI feedback.
- Constraints and caveats: roleplay/admin domain, VRChat world constraints, and
  actions such as teleport/summon need social and safety rules.
- What to inspect next: watch-camera module, ping HUD, voice manager, and how
  permissions are explained to non-admin users.
- Why it matters for `VR-apps-lab`: it is the strongest donor in this wave for
  permissioned VR command menus.

#### Reusable Pattern Extraction

- Pattern candidate: permission-gated in-world operator menu.
- Problem solved: expose powerful world actions without making them hidden,
  accidental, or available to the wrong users.
- Reusable core: activation gesture, hand/head placement, module registry,
  player selector, permission provider, action dispatch, undo state, synced
  messages, HUD feedback, and close/open lifecycle.
- Source evidence: `GMMenu.cs`, `GMMenuToggle.cs`, `PlayerPermissions.cs`,
  `MessageSyncManager.cs`, and `Teleporter.cs`.
- Abstraction boundary: menu shell, permission model, target selection,
  reversible action modules, and feedback/HUD each remain separate.
- What not to copy: roleplay-specific permissions or teleport/summon behavior
  without target-specific consent and safety review.
- Method catalog action: create Method 659.

### `kurotori4423/KurotoriUdonMenu`

- Interesting idea: a lightweight local Udon menu can be activated by both
  controller triggers or a desktop key, animate into view, generate tabs from
  configured menu items, and apply option objects.
- Code donor value: medium. `UdonMenu.cs` instantiates tab buttons, tracks the
  active tab, scales inversely to player scale, uses hold-both-triggers or `M`
  to open, places the menu in front of the player/head, and animates open
  progress. `MenuActivater.cs` controls tab labels and active state.
  `UdonMenuOptionApplyer.cs` calls `FirstSetup` on configured option objects.
  `TeleportButtonManager.cs` preallocates player buttons and updates them on
  join/leave. `UdonMenuPlayerVoiceRangeSlider.cs` adjusts voice distance.
- Product reference value: high for small local options and player utility
  menus.
- Architecture pattern: local menu shell plus generated tab buttons plus option
  appliers and player-action panels.
- Reusable method: treat each menu item as a configured surface and keep opening
  gesture, placement, animation, and option setup in a small shell.
- Constraints and caveats: older Udon style, Japanese README, local-only
  assumptions, and VRChat-specific voice/teleport APIs.
- What to inspect next: option object interface, animation timings, and how the
  menu avoids conflicts with other world controls.
- Why it matters for `VR-apps-lab`: it is a minimal donor for tabbed local VR
  utility menus.

## Cross-Project Lessons

- Menu systems need activation, placement, target selection, permissions,
  dispatch, and feedback as explicit parts.
- In-world diagnostics can be a small prefab rather than a full developer panel.
- Package ecosystems are a product pattern: small installable utility modules
  can be easier to reuse than a single broad toolkit.
- Powerful actions need visible permission and undo/feedback paths.

## Method Catalog Actions

- Added Method 659: VRChat/Udon world menu package surface with prefab-state
  contracts.

## Follow-Up Gaps

- Deepen VUdon's Menus, Quick Menu, Logger, Roles, Common, and Event Dispatcher
  packages separately.
- Compare Udon menus with previous VR menu, radial menu, command-surface, and
  overlay-control families.
- Build a generic VR command-menu checklist based on Wave 214.
