# GitHub Research Wave 238 Plan

Date: 2026-06-06

Theme: VR training, rehabilitation, and simulated-user evaluation harnesses.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Training and rehabilitation projects expose reusable patterns for future VR
utilities: reward/evaluation loops, scenario reset state, sensor and EMG
ingress, live graph feedback, equipment simulation, remote actuator commands,
AI coaching, and research logging.

## Search Families

- VR training simulators.
- Rehabilitation and biofeedback systems.
- Simulated-user and evaluation harnesses.
- Scenario logging and coaching tools.
- Training micro-utilities with realistic interaction state.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `fl0fischer/sim2vr` | Unity plus User-in-the-Box bridge for simulated VR users, reward, reset, RGB-D observations, and ZMQ. | Evaluation harness donor |
| `kaayran/ShootingRangeVR` | SteamVR training scene with weapon/equipment mechanics, target accuracy, and remote range controls. | Training scenario reference |
| `GxRay/Trunk-Rehabilitation-VR-Training-Simulator-` | VR rehab system with EMG/accelerometer TCP ingress, filters, graphs, Spaceball commands, and gaze menu framing. | Rehab/biofeedback donor |
| `Nelliel2/VR-training-simulator` | Construction/worksite Unity training tree with mostly asset-heavy source. | Scenario reference |
| `NagashreeSP/VR-Fire-Safety-Training-Simulator` | README-only fire safety training concept. | Source-light exclusion note |
| `superjaviko/RESILIENCE` | AI-assisted linguistic-barrier VR training with UPBGE scripts, voice coach, Sheets/session data, and navigation helpers. | AI training coach reference |

## Dedupe Notes

Prior waves cover research data lifecycles and teleoperation safety. This wave
focuses specifically on training-loop design: simulated user evaluation,
scenario mechanics, rehab biofeedback, and AI/voice coaching caveats.

## Code-Level Pass Targets

- Reward, reset, episode state, logging, and recorder boundaries.
- Sensor/EMG ingress, filters, and live graph feedback.
- Scenario control, target scoring, and equipment interaction.
- Voice/AI coach and external data integration.
- Source-light and security caveats.

## Expected Outputs

- Wave 238 landscape synthesis.
- Registry/family entries for training and rehab harnesses.
- Method catalog entry for scenario training harness boundaries.
- Follow-up backlog for training/evaluation matrix.
