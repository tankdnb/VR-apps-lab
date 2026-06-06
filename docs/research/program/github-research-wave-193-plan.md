# GitHub Research Wave 193 Plan

- Date: `2026-06-06`
- Theme: `VRChat OSC physical-output safety and device-control bridge variants`
- Scope: DG-LAB, PiShock, OpenShock, serial, and avatar-parameter physical
  output bridges with emphasis on safety gates, cooldowns, panic stops,
  consent, and UX boundaries.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Wave 191 studied VRC haptics server and firmware lineage. Wave 193 looks at a
nearby but riskier class: avatar OSC to physical-output bridges. The useful
knowledge is in routing, safety, rate limits, UI transparency, parameter
schemas, OSCQuery discovery, and what should not be copied without explicit
consent and safety design.

## Search Families

- VRChat OSC to DG-LAB bridges
- VRChat OSC to PiShock/OpenShock bridges
- avatar contact receiver physical-output tools
- OSCQuery physical-output controllers
- device-control bridge safety patterns

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `ccvrc/DG-LAB-VRCOSC` | PySide6 multi-source DG-LAB bridge with OSCQuery, command queue, chatbox telemetry, and source cooldowns | Strong physical-output router donor |
| `amoeet/VRChat_X_DGLAB` | C# Windows DG-LAB bridge variant | Thin GUI/reference variant |
| `boyqiu-001/VRCHAT-OSC-to-DGLAB` | Tkinter rule editor mapping avatar parameters to waveform/intensity/ticks | Simple threshold mapper donor |
| `ion-aluminium/VRC-DGLAB` | FastAPI + React rewrite with service split, job engine, OSC service, and device service | Strong service-boundary donor |
| `Null-K/DG-LAB-VRChat-Sensora` | Python app with HTTP/WebSocket/OSC, channel modes, chatbox status, safety window, and rate limits | Strong safety-mode donor |
| `noideaman/ShockVRC` | Avatar expression menu to PiShock/OpenShock bridge | Thin avatar-menu schema reference |
| `DesMakesStuff/PiShockTouch` | Contact receiver and installer that patches avatar OSC JSON | Installer/contact schema reference |
| `poprox24/VRChat-Shocker-Link-CPP` | C++ ImGui bridge with OSCQuery, PiShock/OpenShock/serial, queue, panic hotkey, dynamic cooldown, and notifications | Strongest safety architecture donor |

## Dedupe Notes

- The wave is related to haptics, but the selected projects focus on
  physical-output control bridges rather than firmware/hardware lineage.
- Source-light and narrow repositories are retained as variants only when they
  expose a distinct parameter schema, installer pattern, or safety lesson.
- No hardware, credentials, APIs, VRChat, or network services were used.

## Code-Level Pass Targets

- OSC/OSCQuery ingress and avatar parameter discovery.
- Rule/job engines mapping avatar values to device commands.
- Source priority, cooldown, debounce, and queue behavior.
- Panic stop, global disable, rate limits, and safety windows.
- Chatbox/status feedback and configuration UI.
- Installer behavior that patches local avatar OSC JSON.

## Expected Outputs

- Wave 193 landscape synthesis.
- Registry/family placement for physical-output bridge variants.
- Methods around safety-first avatar OSC physical-output routers and
  threshold/mode mappers.
