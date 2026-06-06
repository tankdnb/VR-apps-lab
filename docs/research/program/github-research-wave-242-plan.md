# GitHub Research Wave 242 Plan

Date: 2026-06-06

Theme: CV, mocap, and industrial VR training control loops.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Training, rehab, teleoperation, and diagnostic utilities often need to turn
real-world sensor input into safe VR state. This wave studies repos that expose
camera-marker tracking, mocap alignment, condition logging, industrial safety
framing, and narrative rehab metaphors.

## Search Families

- Quest passthrough and ArUco marker tracking.
- Physical tool tracking and controller-free MR interaction.
- OptiTrack-backed Unity studies.
- Industrial robot VR training and safety HMI concepts.
- Rehab/medical education VR references.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `WestCoastGod/XR-CV-Forceps-Tracking-Unity` | ArUco-tracked laparoscopic forceps with rigid pose estimation, One Euro smoothing, marker-visibility clamp control, and XRI grab/release. | Strong sensor-control donor |
| `jghanania/MotionCapture-AgilityLadder-XR-Study` | Quest/OptiTrack study harness with condition order, AR/VR/real-world modes, path sequencing, camera alignment, and CSV logging. | Study orchestration donor |
| `jesusfernandorl/Industrial_Twin_XR-Safe-Robotics-and-6-Axis-VR-Control` | Source-light industrial robot VR training concept with deadman, soft limits, interlocks, HMI, and staged roadmap. | Safety/product reference |
| `purva-rana/MindscapeVR` | Source-light neuro-rehabilitation narrative reference with clinical-to-abstract world transition and difficulty escalation. | Rehab UX reference |

## Dedupe Notes

Prior waves cover teleoperation, training scenarios, rehab biofeedback, and XR
research data lifecycles. This wave focuses specifically on external sensing,
calibration, safety, and task state as a reusable loop.

## Code-Level Pass Targets

- ArUco marker detection, pose estimation, smoothing, and validity boundaries.
- Tool state derived from marker visibility.
- Mocap camera alignment and avatar scaling.
- Study condition sequencing and logging schemas.
- Safety gates: deadman, soft limits, interlocks, HMI feedback.
- Source-light concept caveats.

## Expected Outputs

- Wave 242 landscape synthesis.
- Registry/family entries for sensor-tracked training control loops.
- Method catalog entry for calibration/smoothing/logging boundaries.
- Follow-up backlog for a sensor-ingress training matrix.
