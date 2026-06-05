# GitHub Research Wave 161 Backlog

- Date: `2026-06-05`
- Theme: `OSCQuery VRChat discovery libraries and client primitives`
- Status: `Completed`

## Completed Pass

1. Search VRChat OSCQuery, mDNS, zeroconf, Rust, C#, Python, and multi-app OSC
   helper projects.
2. Deduplicate against the canonical VRChat OSCQuery library and previously
   studied full OSC applications.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect CLI builders, service profiles, endpoint registration, mDNS caches,
   sidecar subprocess contracts, HTTP root/HOST_INFO responses, and avatar
   parameter fetch/update flows.
5. Promote all five repositories into registry/families/methods.
6. Add follow-up gaps around OSCQuery plumbing matrices and discovery
   reliability.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `galister/VrcAdvert` | Added as minimal OSCQuery app advertiser |
| `minetake01/vrchat_osc` | Added as Rust VRChat OSC/OSCQuery client and registration crate |
| `Natsumi-sama/OscQueryLibrary` | Added as C# parameter-discovery and service-advertisement library |
| `Raphiiko/oyasumivr_oscquery` | Added as limited Rust OSCQuery plus dotnet mDNS sidecar reference |
| `theepicsnail/vrchat_oscquery` | Added as Python asyncio/threaded helper and multi-app proxy reference |

## Useful Follow-Up Work

- Build an OSCQuery transport matrix across C#, Rust, Python, and official
  VRChat library patterns.
- Define a reusable "OSC sidecar discovery checklist" for future VRChat
  utilities.
- Keep Quest/LAN/VPN and multicast caveats explicit before designing any
  networked OSC utility.

## Not Pursued In This Wave

- No VRChat client, OSC endpoint, mDNS daemon, Python package, Rust crate, C#
  app, or sidecar executable was run.
- No found repository was built, installed, launched, or tested.
