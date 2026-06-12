# Wave 265 - VRChat Creator/User Utility Microtools and Service Dev Helpers

This wave studies smaller VRChat utility projects outside the already-covered
large companion, OSC, and menu families: creator editor batches, API CLIs,
Udon packet helpers, Meta Quest developer companions, social monitors, and
avatar OSC controllers.

## Scope

The wave was bounded to VRChat utility projects that expose narrow reusable
lessons:

- Unity editor batch operations for avatar setup and repair;
- VRChat service login, 2FA, token, and file-management CLI surfaces;
- Udon byte-packet serialization helpers;
- developer workflow helpers for Quest/ADB and Oculus/Meta tooling;
- friend-list/log monitoring;
- local OSC avatar controller surfaces;
- source-light repositories that should not be over-promoted.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `crestudio/VRSuya-Utility` | VRChat creator editor workbench | Studied | Avatar material, texture, PhysBone, scale, and editor batch helper suite |
| `te260ku/VRMenuUtility` | Source-light Unity skeleton | Source-light | Minimal Unity project with little donor evidence |
| `AkitaIkeda/VRCFileUtility` | VRChat service CLI | Studied | Spectre.Console login, token persistence, 2FA, and file feature routing |
| `thymespace/VRCPacketUtility` | Udon packet micro-library | Studied | Sequential byte buffer helper for UdonSharp data packets |
| `korinVR/VRDeveloperUtility` | Quest/VRChat developer companion | Studied | ADB discovery, device status, app launch, screenshots, and Meta service actions |
| `namoshika/VRChatUtility_FriendListMonitor` | Social/log monitor pipeline | Studied | AWS, Notion, VRChat API polling, and desktop log event extraction |
| `kikookraft/vrc-utility` | Artifact-only/source-light | Source-light | Diagram/logo-only repo with no code donor value |
| `falnen/Python-VRC-utility` | Local OSC avatar controller | Studied with caveats | Python OSC, avatar config discovery, log events, and per-avatar controllers |

## Code-Level Findings

### `crestudio/VRSuya-Utility`

- Interesting idea:
  collect many small avatar editor maintenance tasks into one creator
  workbench rather than one large avatar optimizer.
- Code donor value:
  strong for custom inspectors, localized labels, before/after texture and
  material replacement UI, detail foldouts, Undo integration, dirty marking,
  PhysBone batch actions, humanoid bone/collider pairing, and avatar scaling
  helpers.
- Product reference value:
  good creator-tool reference because the value is in repeated small fixes.
- What to inspect next:
  package manifest, optional dependency handling, Undo coverage per tool, and
  localization maintenance.
- Caveats:
  editor-only, VRC SDK dependent, and README output indicates Korean-first
  documentation.

### `te260ku/VRMenuUtility`

- Interesting idea:
  a Unity project shell that appears intended for menu utilities.
- Code donor value:
  very low; source pass found project settings and a sample scene but no
  meaningful implementation entry point.
- Product reference value:
  useful only as a source-light classification example.
- What to inspect next:
  whether releases or branches contain real menu logic.
- Caveats:
  do not treat the repository as a studied menu donor yet.

### `AkitaIkeda/VRCFileUtility`

- Interesting idea:
  expose VRChat account/file utility actions through a console workflow with
  explicit login and feature selection.
- Code donor value:
  useful for Spectre.Console prompts, BasicAuth fallback, TFA loop, token
  credential XML persistence, feature routing, and dependency-injected app
  structure.
- Product reference value:
  good CLI service-tool reference if credential storage is redesigned.
- What to inspect next:
  file endpoint coverage, secure credential storage, rate-limit behavior, and
  logout/token invalidation.
- Caveats:
  XML token storage is sensitive and the VRChat API dependency may be stale.

### `thymespace/VRCPacketUtility`

- Interesting idea:
  make UdonSharp network payloads easier to construct and read with a
  sequential `DataPacket` buffer.
- Code donor value:
  useful for fixed-size byte arrays, consumed-byte cursor state, write/read
  overloads, reset-head behavior, and sliced packet construction.
- Product reference value:
  narrow but useful as a reminder that small serialization helpers can be
  valuable for Udon authors.
- What to inspect next:
  bounds checks, endianness, type coverage, late-join behavior, and tests.
- Caveats:
  `Write(Byte)` appears to advance by two bytes; treat this as a bug risk, not
  a copy target.

### `korinVR/VRDeveloperUtility`

- Interesting idea:
  make a Windows developer companion for VRChat/Quest iteration tasks:
  discover ADB, query device state, launch apps, capture screenshots, and
  restart runtime services.
- Code donor value:
  strong for ADB candidate discovery from server path, PATH, Android SDK and
  Unity Hub, device parsing, battery/IP/SSID/model queries, async command
  guards, UI status refresh, log output, native Quest screenshot capture, and
  media pull flow.
- Product reference value:
  excellent developer-workflow reference for a future Quest/VRChat helper
  surface.
- What to inspect next:
  safety confirmations, command rollback, device multi-select, path
  configuration, and ADB error taxonomy.
- Caveats:
  if run, it can launch apps, restart services, and manipulate devices; use
  only as a conceptual/static donor here.

### `namoshika/VRChatUtility_FriendListMonitor`

- Interesting idea:
  combine VRChat API polling and local log extraction into a cloud-backed
  friend/session monitoring pipeline.
- Code donor value:
  useful for API wrapper shape, friend online/offline paging, desktop log
  regex extraction, room/join/leave event models, local log upload, AWS
  Lambda/Dynamo queueing, and Notion output.
- Product reference value:
  good reference for social/session audit systems with a heavy privacy label.
- What to inspect next:
  consent UX, API key freshness, Notion schema, queue failure handling, and
  local log rotation.
- Caveats:
  credentials, Notion, AWS, and friend/session data are privacy-sensitive; the
  hardcoded API key and API age require caution.

### `kikookraft/vrc-utility`

- Interesting idea:
  diagram and logo repository around an unspecified utility.
- Code donor value:
  none found in the cloned default branch.
- Product reference value:
  only useful as an example of why source-light triage exists.
- What to inspect next:
  releases or linked projects if this name reappears.
- Caveats:
  do not count as implementation evidence.

### `falnen/Python-VRC-utility`

- Interesting idea:
  create a local avatar controller surface that reacts to OSC avatar changes
  and VRChat logs.
- Code donor value:
  useful for python-osc dispatcher setup, queue-based message ingestion,
  avatar ID to local JSON/log matching, per-avatar controller lifecycle,
  persistent state, and event routing between logs, OSC, and UI.
- Product reference value:
  good rough concept for local-first avatar parameter workbenches.
- What to inspect next:
  syntax/packaging repair, avatar config discovery, UI state model, OSC
  address validation, and concurrency.
- Caveats:
  source contains likely invalid f-string quoting and amateur-project caveats;
  do not copy directly.

## Reusable Pattern Extraction

- Pattern candidate:
  VRChat utility helper boundary across creator editor, service, Udon, device
  dev, social monitor, and avatar OSC surfaces.
- Problem solved:
  VRChat utility repos are often small and cross many risk levels. A useful
  intake must separate editor-only actions, service credentials, Udon runtime
  code, device operations, social data, and local OSC control.
- Reusable core:
  surface type, credential/device/privacy gate, data source, action scope,
  Undo/rollback or cooldown, visible operator feedback, package state, and
  donor/reference/source-light classification.
- Source evidence:
  `VRSuya-Utility`, `VRCFileUtility`, `VRCPacketUtility`,
  `VRDeveloperUtility`, `VRChatUtility_FriendListMonitor`,
  `Python-VRC-utility`, plus source-light `VRMenuUtility` and `vrc-utility`.
- Abstraction boundary:
  editor workbenches, service CLIs, Udon libraries, Quest developer helpers,
  social monitors, and OSC avatar controllers should not share one generic
  "VRChat tool" bucket.
- What not to copy:
  insecure token storage, unreviewed byte serializers, destructive ADB or
  service actions without confirmation, public social logging without privacy
  gates, and artifact-only repositories as donor evidence.
- Method catalog action:
  create a method for VRChat helper surface triage and safety boundaries.

## Family Placement

This wave creates a VRChat creator/user utility helper family. It overlaps
with OSC micro-control, service companions, Quest helpers, Udon libraries, and
editor diagnostics, but its purpose is to classify small helper surfaces by
risk and reuse boundary.

## Backlog Impact

- Add a VRChat helper matrix comparing editor Undo, service auth, Udon
  serialization, Quest/ADB actions, social monitoring, and OSC control.
- Deepen `VRDeveloperUtility` if a Quest/VRChat developer companion becomes an
  implementation target.
- Deepen `VRSuya-Utility` if avatar editor workbench and batch-repair tools
  become active priorities.
