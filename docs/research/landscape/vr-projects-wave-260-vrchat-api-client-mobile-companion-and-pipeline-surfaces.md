# Wave 260 - VRChat API Client, Mobile Companion, and Pipeline Surfaces

This wave studies VRChat API clients and companion-app surfaces that wrap
authentication, cookies, two-factor flows, typed API modules, pipeline
WebSocket access, desktop log sync, mobile notification tasks, and social
state presentation.

## Scope

The wave was bounded to projects that make VRChat service data reusable for
utilities:

- language-specific API clients;
- mobile or desktop companion shells;
- generated OpenAPI bindings and wrapper functions;
- session, cookie, and two-factor handling;
- pipeline/WebSocket and notification surfaces;
- log/session analytics and friend/world state helpers.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `LinaTsukusu/vrchat-client` | TypeScript API module wrapper | Studied | Simple module-per-domain client with cookie-based login |
| `ccamgr/vrcp` | Mobile/desktop VRChat companion | Studied | Expo/Tauri companion with generated clients, 2FA, log sync, notifications, and analytics |
| `binn/VRChat.API.Client` | .NET fluent API wrapper | Studied | Builder/factory pattern around generated VRChat API clients |
| `calmery/vrchat` | Compact TypeScript auth wrapper | Studied | Small auth/TFA/cookie and CRUD helper library |
| `Ox0017/vrc` | Java API client | Studied | DTO-heavy Java client with request context and auth verification |
| `VRCMG/vrcapi-client` | TypeScript API and pipeline client | Studied | API helpers plus WebSocket pipeline token flow |

## Code-Level Findings

### `LinaTsukusu/vrchat-client`

- Interesting idea:
  split the VRChat API into domain modules (`user`, `avatar`, `favorite`,
  `world`, `moderation`, `notification`) behind one login-created API object.
- Code donor value:
  useful as a compact module-per-domain wrapper with axios base URL switching,
  cookie capture from login, and shared `getReq`/`postReq`/`putReq` helpers.
- Product reference value:
  good baseline for a small scriptable VRChat data helper.
- What to inspect next:
  modern VRChat auth requirements, 2FA support, rate limiting, user-agent
  expectations, and cookie persistence.
- Caveats:
  old API assumptions, no visible 2FA path, and no privacy/rate-limit policy.

### `ccamgr/vrcp`

- Interesting idea:
  treat VRChat as a cross-device companion surface: mobile auth, background
  notification polling, desktop log ingestion, local analytics, and
  friend/world/instance helpers.
- Code donor value:
  strong for generated API bindings, `AuthContext` state machine,
  SecureStore/StorageWrapper split, TFA mode routing, auth/twoFactor cookie
  extraction, desktop log sync, session timeline analysis, notification
  background task, and typed location/instance parsing helpers.
- Product reference value:
  excellent reference for a future companion app that helps a user understand
  VRChat activity outside the headset.
- What to inspect next:
  desktop API protocol, database schema, privacy copy, credential storage
  hardening, notification throttling, and API compliance.
- Caveats:
  active developing state, credential persistence risk, background API polling
  constraints, and broad personal-data scope.

### `binn/VRChat.API.Client`

- Interesting idea:
  wrap generated VRChat API clients with a fluent builder and ASP.NET-style
  factory/hosting integration.
- Code donor value:
  useful for `VRChatClientBuilder`, named client factory, user-agent/timeout
  configuration, auth cookie injection, and `IVRChat` domain API interface.
- Product reference value:
  good server-side companion reference where multiple named VRChat clients may
  be created from configuration.
- What to inspect next:
  current official API package state, auth token retention, dependency
  injection lifetime, and secure secret configuration.
- Caveats:
  comments flag possible factory/lifetime flaws; generated client age and
  auth assumptions need review.

### `calmery/vrchat`

- Interesting idea:
  keep the public API tiny: `login`, `verifyTfa`, `logout`, and generic CRUD
  methods around explicit auth and two-factor cookies.
- Code donor value:
  useful for cookie parsing, typed auth error classes, TFA validation,
  `createAxios(auth)` helper, and authenticated CRUD wrappers.
- Product reference value:
  good minimal library reference for a small sidecar that should not grow into
  a full companion app.
- What to inspect next:
  TFA regex bug risk, API key/user-agent freshness, and 401 recovery.
- Caveats:
  hardcoded old API key, narrow endpoint coverage, and no rate/backoff layer.

### `Ox0017/vrc`

- Interesting idea:
  make an explicit request context carry API key/auth/session state across a
  DTO-heavy Java client.
- Code donor value:
  useful for `VrcRequestContext`, request construction, response DTOs,
  custom serializers/deserializers, auth verification that can refresh or clear
  session tokens, and mock-backed tests.
- Product reference value:
  good older-language example for service-client architecture and generated or
  hand-written DTO boundaries.
- What to inspect next:
  context copy/restore semantics, session headers, modern endpoints, and
  null/error handling.
- Caveats:
  old Cloudflare/auth assumptions and broad DTO surface make reuse mostly
  conceptual.

### `VRCMG/vrcapi-client`

- Interesting idea:
  combine REST helpers with VRChat pipeline WebSocket initialization through a
  token verification step.
- Code donor value:
  useful for typed endpoint modules, axios default setup, login with API config
  fetch, `set-cookie` handling, `WebSocket` token retrieval, and per-domain
  tests.
- Product reference value:
  useful for notification or presence tools that need pipeline events rather
  than only polling REST endpoints.
- What to inspect next:
  pipeline token lifetime, event parsing, reconnect/backoff, and compliance
  with modern VRChat API guidance.
- Caveats:
  older API URLs, global axios defaults, and direct pipeline token in URL
  require security review.

## Reusable Pattern Extraction

- Pattern candidate:
  VRChat API companion boundary with auth/TFA, typed service modules, pipeline
  events, local logs, and privacy gates.
- Problem solved:
  utility apps need VRChat data, but raw API access couples credentials,
  cookies, rate limits, event streams, local logs, and user-facing social state
  unless these boundaries are named.
- Reusable core:
  credential source, auth/TFA flow, cookie/token store, generated or typed API
  modules, REST/pipeline/log adapters, cache/local database, background task,
  privacy filter, rate/backoff policy, and visible account/session state.
- Source evidence:
  module wrappers in `vrchat-client`, SecureStore and desktop-log sync in
  `vrcp`, fluent factories in `VRChat.API.Client`, compact auth wrappers in
  `calmery/vrchat`, request contexts in `Ox0017/vrc`, and pipeline WebSocket
  setup in `vrcapi-client`.
- Abstraction boundary:
  auth and personal data should remain below a companion-service layer; UI
  features should consume normalized friend/world/notification/session models.
- What not to copy:
  stale hardcoded API keys, raw credential logging, unaudited auto-login,
  unbounded background polling, global axios cookies, or direct pipeline URLs
  without lifecycle and security handling.
- Method catalog action:
  create a method for VRChat API companion service boundaries.

## Family Placement

This wave creates a VRChat API client and companion data-surface family. It
overlaps with VRCX, VRChat OBS metadata adapters, notification relays, and
chatbox/status tools, but the core reusable lesson is lower-level: how to
turn VRChat service data into typed, privacy-aware utility inputs.

## Backlog Impact

- Build a VRChat API companion checklist covering credentials, TFA, cookies,
  user-agent, rate limits, pipeline events, local logs, and privacy.
- Compare polling, pipeline WebSocket, VRCX SQLite/logs, and official API
  wrappers as separate data adapters.
- Revisit `vrcp` as a strong donor if a mobile/desktop VRChat companion track
  becomes active.
