# GitHub Research Wave 321 Backlog - SteamVR Performance HUDs, Sensor Fan-In, and Overlay QoL Patch Packs

## Executed Scope

- Searched and deduplicated SteamVR performance overlays and XSOverlay QoL
  patch projects.
- Froze a two-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted provider fan-in, metric selection, overlay placement, refresh-rate
  control, pointer/keyboard/wrist friction, and patch-pack caveats.

## Studied Projects

- `Karlan-Trade/VR-Performance-Profiler`
- `chaixshot/xsoverlay-tweak`

## Backlog Findings

- Compare HWiNFO/MSI/SteamVR sensor-provider fan-in with other telemetry HUDs.
- Build a friction taxonomy for pointer, wrist, keyboard, overlay attach, and
  haptics patches across XSOverlay-like tools.
- Revisit patch-pack safety boundaries for runtime/app updates.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a performance HUD fan-in method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
