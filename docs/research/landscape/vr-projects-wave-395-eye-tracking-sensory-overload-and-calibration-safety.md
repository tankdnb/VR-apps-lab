# Wave 395: Eye Tracking, Sensory Overload, and Calibration Safety

## Theme

Gaze/eye tracking and calibration as accessibility/safety infrastructure:
detecting sensory overload, adapting content, and calibrating Vive Pro Eye
experiments.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `leonkoech/AutismDetector` | Studied | Magic Leap eye-tracking SDK for sensory overload detection and adaptive scene behavior |
| `mvidaldp/unity_htcvivepro_et_calibration` | Studied | Unity/SteamVR Vive Pro Eye calibration experiment project |

## Dedupe Notes

Prior gaze analytics waves focused on telemetry and eye behavior. This wave
focuses on accessibility/safety use: reducing sensory overload and making
calibration explicit.

## Code-Level Findings

### `leonkoech/AutismDetector`

- Interesting idea: monitor eye-gaze movement to detect sensory overload and
  adapt AR/VR scenes by reducing motion or changing focus.
- Code donor value: `Autiment SDK/SymptomDetector.cs`, Magic Leap eye actions,
  `EEGRecordings`, `museum`, and `solar system` scenes show a prototype SDK
  plus demo-experience split.
- Product reference value: useful for comfort/safety utilities that react to
  user state instead of static settings only.
- What to inspect next: overload classifier, gaze velocity thresholds, EEG
  correlation, adaptation policy, and clinical validation caveats.
- Caveat: autism/sensory claims are high-stakes and require conservative
  labeling; do not treat prototype thresholds as medical logic.

### `mvidaldp/unity_htcvivepro_et_calibration`

- Interesting idea: eye-tracking calibration should be kept as its own
  experiment project with SteamVR/Vive Pro Eye dependencies and UI interaction
  surfaces.
- Code donor value: Unity project, SteamVR interaction scripts, assets, and
  project settings show calibration-project packaging.
- Product reference value: useful for eye-tracking test harnesses and
  calibration-required analytics tools.
- What to inspect next: calibration targets, sample recording, validation
  metrics, failure states, and user comfort flow.
- Caveat: bundled SteamVR/interaction assets are not the reusable method; focus
  on calibration workflow and artifact provenance.

## Reusable Pattern Extraction

- Pattern candidate: gaze safety and calibration loop.
- Problem solved: eye-tracking utilities need calibration, confidence,
  adaptation policy, user consent, and high-stakes caveats before use.
- Reusable core: gaze source, calibration target, sample quality metric,
  fixation/velocity feature, overload signal, adaptation rule, user override,
  consent label, clinical caveat, and calibration artifact.
- Source evidence: `Autiment SDK/SymptomDetector.cs`, demo scene folders,
  EEGRecordings, and Vive Pro Eye calibration Unity project layout.
- Abstraction boundary: gaze sensing should not own medical conclusions or
  irreversible scene changes.
- What not to copy: diagnostic claims, fixed thresholds as medical truth,
  calibration flows without failure UI, or eye data retention without consent.
- Method catalog action: add Method 840.

## Family Placement

Creates an eye-tracking safety/calibration family connected to gaze analytics
and accessibility research.

## Follow-Up Gaps

- Draft eye-tracking consent/calibration/failure-state checklist.
- Compare overload adaptation rules with comfort and accessibility methods.
- Define what eye data can be retained in research utilities.
