# GitHub Research Wave 14 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on `tracker-ingress drivers`,
  `OSC/input export`, `SteamVR role reuse`, and `direct-to-consumer bridge
  utilities` that were not yet fully represented in `VR-apps-lab`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for named-pipe and local-socket OpenVR bridge drivers
- `Done` Search GitHub for WebSocket tracker-driver variants and forks
- `Done` Search GitHub for OpenVR pose-to-OSC exporters and VRChat-adjacent input-export tools
- `Done` Search GitHub for no-HMD engine-side tracking adapters and role-binding helpers
- `Done` Deduplicate all results against the registry
- `Done` Freeze a bounded shortlist for code-level inspection
- `Done` Record secondary candidates for future follow-up

## Work package B: Local source acquisition

- `Done` Confirm `ju1ce/Simple-OpenVR-Bridge-Driver` in local cache
- `Done` Confirm `3NekoSystem/OpenVR-Tracker-Websocket-Driver` in local cache
- `Done` Confirm `v0xie/OpenVR-Tracker-Websocket-Driver` in local cache
- `Done` Confirm `BarakChamo/OpenVR-OSC` in local cache
- `Done` Confirm `choyai/SteamVRTrackerUtility` in local cache
- `Done` Confirm `biosmanager/unity-openvr-tracking` in local cache
- `Done` Confirm `JLChnToZ/axis-vrc-osc-bridge` in local cache
- `Done` Confirm `I5UCC/VRCThumbParamsOSC` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect named-pipe driver ingress, tracker lifecycle, and sync helpers in `Simple-OpenVR-Bridge-Driver`
- `Done` Inspect simplified JSON/WebSocket tracker creation flow in `3NekoSystem/OpenVR-Tracker-Websocket-Driver`
- `Done` Inspect richer local web-service and HTTPS side channels in `v0xie/OpenVR-Tracker-Websocket-Driver`
- `Done` Inspect minimal OpenVR pose-export loop and implementation caveats in `OpenVR-OSC`
- `Done` Inspect serial-based tracker identity helper pattern in `SteamVRTrackerUtility`
- `Done` Inspect role reuse, pose prediction, and no-HMD flow in `unity-openvr-tracking`
- `Done` Inspect standalone vendor-tracker-to-VRChat OSC bridge flow in `axis-vrc-osc-bridge`
- `Done` Inspect action-manifest, OSCQuery, and configurable parameter export model in `VRCThumbParamsOSC`

## Work package D: Repository updates

- `Done` Add Wave 14 plan document
- `Done` Add Wave 14 backlog document
- `Done` Add Wave 14 synthesis document
- `Done` Update project registry with newly studied repositories and new secondary candidates
- `Done` Update overlap families with the new nodes and variant decisions
- `Done` Update `not-yet-studied-deeply.md` with the new follow-up gaps
- `Done` Update methods catalog with Wave 14 bridge and OSC-export patterns
- `Done` Update documentation navigation to include Wave 14

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the main documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare `Simple-OpenVR-Bridge-Driver` and `OpenVR-Tracker-Websocket-Driver` directly as one `named pipe vs WebSocket ingress` design note
- `Next` Revisit `3NekoSystem/OpenVR-Tracker-Websocket-Driver` only if the lighter JSON/WebSocket branch becomes more actively maintained than the main WebSocket line
- `Next` Revisit `v0xie/OpenVR-Tracker-Websocket-Driver` only if its extra HTTP/HTTPS side channels become a real reused product pattern
- `Next` Inspect `TheNexusAvenger/Enigma` as a consumer-side tracker-role export path outside normal XR apps
- `Next` Inspect `ThatGuyThimo/leapmotion-osc` as a finger-only OSC complement to `HandOfLesser` and `VRCThumbParamsOSC`
- `Next` Compare `unity-openvr-tracking`, `ViveTrackerExample`, and no-HMD tooling as one `engine-side role reuse` subfamily
- `Next` Compare `OpenVR-OSC`, `VRCThumbParamsOSC`, and `axis-vrc-osc-bridge` as one `direct OSC export` product family
