# GitHub Research Wave 238 Backlog

Date: 2026-06-06

Theme: VR training, rehabilitation, and simulated-user evaluation harnesses.

## Completed In This Wave

- Studied `fl0fischer/sim2vr` as a Unity/UitB evaluation harness with
  abstract `RLEnv` reward/reset/time/log hooks, ZMQ request/reply state
  exchange, simulated HMD/controller anchors, RGB-D camera rendering,
  observation payloads, time-scale negotiation, and recorder output.
- Studied `kaayran/ShootingRangeVR` as a realistic training scenario reference
  with weapon/ammunition/grenade/equipment modules, hit detection, average
  target accuracy panel, remote target movement, audio one-shots, and
  controller-binding caveats.
- Studied `GxRay/Trunk-Rehabilitation-VR-Training-Simulator-` as a rehab
  biofeedback system with TCP EMG/accelerometer ingress, notch/IIR filters,
  Spaceball command sender, gaze-menu framing, live graph widgets, player
  statistics, and training difficulty movement commands.
- Checked `Nelliel2/VR-training-simulator` as an asset-heavy Unity training
  tree with construction/worksite animations and project metadata; retained as
  a scenario reference requiring deeper script extraction if revisited.
- Checked `NagashreeSP/VR-Fire-Safety-Training-Simulator`; the repository
  currently exposes only README/ignore metadata, so it is recorded as a
  source-light concept note.
- Studied `superjaviko/RESILIENCE` as an AI-assisted VR training reference with
  UPBGE logic scripts, operator training-session lookup, Google Sheets access,
  socket request helpers, voice coach flow, navigation-arrow setup, and a
  strong security caveat around hardcoded secrets and local paths.
- Added a reusable method entry for scenario training harnesses with sensor,
  coach, and evaluation loops.

## Follow-Up Queue

1. Build a training/evaluation matrix across simulated users, scenario reset,
   scoring, sensor capture, coach feedback, and reporting.
2. Extract a `scenario state -> observation -> reward/log -> reset` harness
   pattern for future VR utility tests.
3. Compare rehab biofeedback ingestion with broader sensor-to-XR bridge
   families.
4. Document a security checklist for AI coach and cloud spreadsheet examples:
   no embedded API keys, no local absolute paths, no unbounded voice capture.

## Do Not Spend Time On Yet

- Do not run Unity, UPBGE, Blender, or external service scripts.
- Do not copy credentials, local paths, training assets, weapon assets, or
  patient/research artifacts.
- Do not promote README-only training repos as code donors.
