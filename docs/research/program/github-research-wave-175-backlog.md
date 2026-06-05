# GitHub Research Wave 175 Backlog

- Date: `2026-06-05`
- Theme: `VRChat OSC web panels, debug surfaces, controller helpers, and sensor bridges`
- Status: `Completed`

## Completed Pass

1. Search VRChat OSC web panel, diagnostics, controller helper, finger tracking,
   and biometric bridge families.
2. Deduplicate against previous VRChat OSC, OSCQuery, companion app, and sensor
   bridge waves.
3. Freeze a bounded shortlist of eight micro-to-medium projects.
4. Sync shortlisted sources into local-only cache for static reading.
5. Inspect Leap Motion OSC scripts, Flask chat panel routes/templates, C# OSC
   wrapper/listener, Python/Tk debugger, Avalonia OSCQuery debugger, TypeScript
   OSC router/web panel, VRCLens drone-control documentation, and heart-rate
   SDK/manager/parameter bridges.
6. Mark source-light and package-only projects as product references where
   appropriate.
7. Integrate results into registry, families, methods, current focus,
   not-yet, and indexes.

## Studied Repositories

| Project | Outcome |
|---|---|
| `ThatGuyThimo/leapmotion-osc` | Added as Leap Motion finger distance/spread to VRChat OSC bridge |
| `a2942/VRChat-OSC-WEB-Chat` | Added as browser chatbox panel and OSC chat/typing micro-utility |
| `qbitzvr/Drone-OSC-Controller` | Added as VRCLens drone-control avatar/menu workflow reference |
| `ChrisFeline/VRChatOSCLib` | Added as C# VRChat OSC client, input, chatbox, and listener primitive donor |
| `firocore/VRChatOSCDebugger` | Added as lightweight Python/Tk OSC live debugger and ignore-list donor |
| `Misaka-L/VRChatOscDebugger` | Added as Avalonia OSCQuery service/parameter browser reference |
| `networkpenetrationtester/VRChat-OSC-WebPanel` | Added as TypeScript OSC router, avatar JSON loader, and Svelte parameter panel donor |
| `200Tigersbloxed/HRtoVRChat_OSC` | Added as biometric heart-rate to VRChat OSC bridge and SDK/plugin ingress donor |

## Useful Follow-Up Work

- Build a VRChat OSC diagnostics matrix across Python/Tk, Avalonia/OSCQuery,
  Svelte web panels, C# libraries, and generic OSCQuery clients.
- Extract a reusable avatar-parameter bridge schema for sensors: source status,
  normalized value, raw value, active/connected booleans, and heartbeat.
- Compare OSC chatbox web panels with prior speech/TTS/chatbox composition
  sidecars.
- Decide whether a future prototype should be a tiny OSC doctor, a parameter
  browser, or a sensor bridge template.

## Not Pursued In This Wave

- No VRChat client, OSC sender/listener, web server, Unity project, debugger,
  sensor, heart-rate service, or SDK was launched.
- No found repository was run, built, installed, imported, or tested.
