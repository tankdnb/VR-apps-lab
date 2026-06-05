# GitHub Research Wave 108 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on `VRChat companion apps`,
  `OSC routers`, `plugin senders`, `data hubs`, and `web debug surfaces`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for VRChat companion apps, OSC routers, OSC GUI tools,
  local data hubs, and browser debug surfaces
- `Done` Deduplicate surfaced repositories against registry and families
- `Done` Freeze a bounded shortlist spanning companion overlay feeds, OSC
  fan-out routing, plugin-hosted senders, TCP forwarding, and browser controls

## Work package B: Local source acquisition

- `Done` Confirm `VRCX` in local cache
- `Done` Confirm `VOR` in local cache
- `Done` Confirm `VRCOSCGUI` in local cache
- `Done` Confirm `VRCOSCDataHub` in local cache
- `Done` Confirm `VRCOSCWeb` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect VRCX Electron, Vue, VR overlay, Linux shared-memory offscreen
  rendering path, event feed, and device-status surfaces
- `Done` Inspect VOR Rust OSC routing, packet filtering, debug event stream,
  sync and async app route modes, and malformed-packet handling
- `Done` Inspect VRCOSCGUI plugin contract, holder status model, send request
  event, plugin settings, and OSC receive callback surface
- `Done` Inspect VRCOSCDataHub OSC receive, type-tag extraction, semicolon and
  pipe payload formatting, and TCP forwarding implementation
- `Done` Inspect VRCOSCWeb Quart, WebSocket, avatar JSON loading, D3 controls,
  avatar parameter state tracking, chatbox, and movement input bridge

## Work package D: Repository updates

- `Done` Add Wave 108 plan document
- `Done` Add Wave 108 backlog document
- `Done` Add Wave 108 synthesis document
- `Done` Update the project registry for VRChat companion and OSC routing
  donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with overlay feed, OSC router, plugin
  sender, data hub, and browser debug-surface methods
- `Done` Update documentation indexes to include Wave 108

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare VRCX overlay feed design against other desktop companion apps
  and OpenVR overlay-first shells
- `Next` Revisit OSC fan-out routers together with avatar speech, haptics, and
  tracking sidecars whenever OSC port contention becomes a design topic
- `Next` Use VRCOSCWeb as a browser-control reference for future debug panels
  that inspect live avatar parameters without a full desktop app
