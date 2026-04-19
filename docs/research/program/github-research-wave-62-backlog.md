# GitHub Research Wave 62 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `desktop-adjacent companion overlays`, `phone bridges`, and
  `media or text control surfaces`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for phone bridges, desktop proxy overlays, and narrow media or text surfaces
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans a Linux desktop proxy, an encrypted phone bridge, a text-paste overlay, and a browser-based volume shell

## Work package B: Local source acquisition

- `Done` Confirm `OVR_SLDO` in local cache
- `Done` Confirm `OVRPhoneBridge` in local cache
- `Done` Confirm `ViveOverlayPaster` in local cache
- `Done` Confirm `VolumeVR` in local cache
- `Done` Confirm `EmyOverlay` as a surfaced comparison node
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect the shared-memory `X11` desktop capture baseline in `OVR_SLDO`
- `Done` Inspect the encrypted TCP bridge, Qt UI, notifications, keyboard, and SMS flow in `OVRPhoneBridge`
- `Done` Inspect the Windows Forms plus bitmap-to-overlay path in `ViveOverlayPaster`
- `Done` Inspect the `CEF` runtime shell and assess the limited public donor surface in `VolumeVR`
- `Done` Confirm that `EmyOverlay` is too thin for mainline promotion in this pass

## Work package D: Repository updates

- `Done` Add Wave 62 plan document
- `Done` Add Wave 62 backlog document
- `Done` Add Wave 62 synthesis document
- `Done` Update the project registry for companion overlays and phone bridges
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes where needed
- `Done` Update the methods catalog with new companion-bridge and operator-surface methods
- `Done` Update documentation indexes to include Wave 62

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `OVRPhoneBridge` visible whenever a future branch needs a secure `phone companion -> VR overlay` pattern
- `Next` Keep `ViveOverlayPaster` visible whenever a future branch needs a tiny `desktop operator pushes text into VR` reference
- `Next` Revisit `VolumeVR` only if a future pass needs a sharper comparison between full browser runtime hosts and narrower `CEF` control shells
