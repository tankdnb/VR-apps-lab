# Wave 351: Multisensory Hardware Feedback Olfactory Thermal Vibration and Drag Haptics

## Scope

This wave studies VR/MR projects where virtual events drive physical sensory
outputs. The reusable pattern is a multisensory output router: semantic events
from a scene should map through capability, safety, intensity, and device
adapters before reaching scent, thermal, vibration, drag, or robotic feedback.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `mimuc/RoboThermalHaptics` | Studied | Encountered-type thermal haptic display with Kinova cobot, Vive Pro Eye, Ultraleap, calibration between robot and VR scene, and Cobity dependency |
| `Ultimatonium/sensoricFramework` | Studied | Unity sender/receiver/device framework for tactile, thermal, olfactory, bHaptics, Cilia, ThermoReal, manager singleton, modifiers, and Doxygen docs |
| `egekaraca/Multisensory-VR-Gardens` | Source-light marker | Multisensory garden direction marker; useful as a future product-reference candidate if source becomes richer |
| `CUXR/Olfactory-Display` | Hardware reference | Scent-generating device with PCB/Gerber/parts list around Seeed XIAO Sense, MOSFETs, atomizers, converter, headers, and batteries |
| `jdthamores/BioEssence` | Studied | Physio-olfactory wearable display with self-contained cardio-respiratory sensing, up to three simultaneous scents, PCB/electronics/case/Android app framing |
| `amarqu88/Multisensory-Proximity-and-Transition-Cues` | Studied | VR/AR limited-FOV awareness study with visual/audio/tactile proximity and transition cues, Steam Audio, extOSC, Raspberry Pi vibration setup, and log files |
| `AndreZenner/dragon` | Studied | Drag:on DIY VR controller with air-resistance and weight-shift haptics, Arduino firmware, Unity package, circuit, 3D-print files, Vive Tracker alignment, and patent caveat |

## Reusable Pattern Extraction

- Pattern candidate: `multisensory output router`.
- Problem solved: scent, heat, vibration, drag, and robotic haptics need one
  semantic event layer but many hardware-specific adapters and safety gates.
- Reusable core: sensory event schema, receiver/body target, sender/source
  component, modifier/intensity stack, capability manifest, device adapter,
  transport adapter, calibration state, latency/cooldown limits, safety stop,
  consent/onboarding UI, fallback cue, and logging channel.
- Source evidence: sensoricFramework separates SensoricManager,
  SensoricReceiver, SensoricSender, SensoricDevice, and modifiers; Drag:on
  separates physical build, Arduino firmware, Unity serial interface, and Vive
  Tracker alignment; Multisensory Proximity uses visual/audio/tactile cue
  combinations and Raspberry Pi OSC vibration; BioEssence and Olfactory-Display
  provide olfactory hardware references; RoboThermalHaptics adds robot/cobot
  thermal encounter constraints.
- Abstraction boundary: scene objects should emit semantic events; hardware
  adapters should own transport, safety limits, calibration, and device state.
- What not to copy: patented mechanisms for commercial use, unbounded thermal
  output, scent exposure without consent/cooldown, robot movement without
  safety zones, hardcoded Raspberry Pi IPs, or asset-store/proprietary plugins
  without replacement paths.
- Method catalog action: create a new multisensory output-router method.

## Project Notes

### `mimuc/RoboThermalHaptics`

- Interesting idea: thermal feedback is delivered through an encountered-type
  haptic display mounted on a robotic arm and aligned to VR scene positions.
- Code donor value: moderate-to-high for calibration, Cobity/Kinova boundary,
  thermal scene interaction, and hardware safety concerns.
- Product reference value: strong as a high-end thermal/robotic haptics
  reference.
- What to inspect next: robot calibration scripts, thermal command interface,
  collision/safety zones, and scene-to-robot transforms.
- Caveats: hardware-heavy and not suitable for casual reuse without strict
  safety engineering.

### `Ultimatonium/sensoricFramework`

- Interesting idea: multisensory feedback is modeled as senders, receivers,
  device implementations, and modifiers under one manager.
- Code donor value: high for framework abstraction, device adapters, sender
  subclasses, and body-target routing.
- Product reference value: strong for a reusable sensory event bus.
- What to inspect next: device lifecycle, modifier stacking, failure handling,
  and whether modern Unity package structure can replace `.unitypackage`.
- Caveats: includes bHaptics/Cilia/SteamVR dependencies and older packaging.

### `egekaraca/Multisensory-VR-Gardens`

- Interesting idea: garden/therapy settings are a natural product frame for
  scent, audio, visuals, and possibly gentle haptics.
- Code donor value: low in this pass.
- Product reference value: modest as a source-light direction marker.
- What to inspect next: whether source assets/scripts exist outside the
  visible README-only signal.
- Caveats: do not promote beyond marker until deeper evidence appears.

### `CUXR/Olfactory-Display`

- Interesting idea: a compact olfactory display can be documented as PCB,
  parts, atomizers, MOSFETs, and battery/converter choices.
- Code donor value: moderate for hardware bill-of-material and PCB reference.
- Product reference value: useful for scent hardware feasibility.
- What to inspect next: firmware, command protocol, enclosure, scent-cartridge
  safety, and Unity/VR integration.
- Caveats: hardware-only/source-light; no application layer in this pass.

### `jdthamores/BioEssence`

- Interesting idea: olfactory output is combined with physiological sensing in
  a wearable self-contained display.
- Code donor value: moderate for PCB/electronics/case/app framing and
  cardio-respiratory sensing concept.
- Product reference value: strong for physio-olfactory research products.
- What to inspect next: Android app, sensing protocol, scent timing, and
  consent/clinical study workflows.
- Caveats: older repository with limited visible implementation beyond README.

### `amarqu88/Multisensory-Proximity-and-Transition-Cues`

- Interesting idea: limited-FOV awareness can be improved through separated
  proximity and transition cues using visual, audio, and tactile channels.
- Code donor value: high for cue taxonomy, Steam Audio, extOSC vibration,
  Raspberry Pi setup, study logging, and VR/AR setup docs.
- Product reference value: strong for accessibility and attention-assist cues.
- What to inspect next: cue scheduler, FOV simulator, tactor controller, and
  noise-condition logging.
- Caveats: old Unity/SteamVR/HoloLens setup and study-specific assets.

### `AndreZenner/dragon`

- Interesting idea: drag and weight-shift haptics can be implemented as a DIY
  tracked controller with fans, servos, Arduino, serial Unity control, and Vive
  Tracker alignment.
- Code donor value: high for hardware/software split, serial controller
  interface, standalone test mode, Unity prefab, and calibration steps.
- Product reference value: strong for physical-controller inspiration.
- What to inspect next: `Dragon.cs`, Arduino state machine, serial protocol,
  and safe commercial/legal boundaries.
- Caveats: explicit patent/commercial-use caveat and hardware assembly burden.

## Product Direction

This wave supports a `multisensory VR output` branch for VR-apps-lab: a semantic
event router that can target scent, thermal, tactile, air-resistance, and
robotic haptic devices through safe, capability-labeled adapters.

