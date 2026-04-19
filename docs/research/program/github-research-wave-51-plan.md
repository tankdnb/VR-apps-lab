# GitHub Research Wave 51 Plan

- Date: `2026-04-19`
- Goal: run the next focused GitHub research wave for repositories that were
  still underrepresented in `VR-apps-lab`, focusing on
  `biometric bridges`, `neurofeedback OSC paths`, and
  `avatar-facing accessory-control platforms`.

## Why this wave exists

`VR-apps-lab` already had wearable-haptics notes and some avatar-driven
automation tools, but another adjacent branch was still too diffuse:

- heart-rate or wearable bridges that turn biometric data into avatar
  parameters, chatbox messages, or other side effects;
- richer desktop shells that combine BLE, WebSocket, logging, and OSC outputs;
- plugin or embedded platforms that turn avatar-facing `OSC` into accessory or
  actuator control with safety surfaces;
- neurofeedback or biosignal stacks that flatten more complex signal trees into
  VRChat-friendly parameters.

This wave exists to make
`biometric bridges, neurofeedback OSC, and accessory-control platforms`
clearer inside `VR-apps-lab`.

## Search scope

Primary search directions for this wave:

- heart-rate or wearable-to-OSC bridges for VRChat and avatar consumers;
- richer biometric desktop companions with charts, logs, and multiple outputs;
- plugin-based or embedded accessory-control stacks that consume avatar-facing
  `OSC`;
- neurofeedback or biosignal systems that translate structured measurements into
  OSC trees.

## Frozen shortlist for code-level study

- `Honzackcz/PulsoidToOSC`
- `nullstalgia/iron-heart`
- `vard88508/vrc-osc-miband-hrm`
- `DASPRiD/vrc-osc-manager`
- `nullstalgia/OpenShock-ESP-Legacy`
- `ChilloutCharles/BrainFlowsIntoVRChat`

## Secondary candidates surfaced in the same wave

- `samyk/myo-osc`

## Execution model

### Step 1: Search and deduplicate

- search GitHub for Pulsoid, heart-rate, brainflow, accessory-control,
  `OSCQuery`, and wearable-control repos;
- compare results against `catalog/project-registry.md`;
- reject repos that only duplicate the already-studied haptics bridges without
  a clearer biometric, neurofeedback, plugin-host, or embedded-control lesson.

### Step 2: Freeze the shortlist

- keep the wave centered on `biometrics and accessory control`, not generic
  haptics only;
- allow both desktop-host and embedded-firmware donors because the family
  crosses that boundary in practice.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- where inputs, smoothing, logging, and `OSC` fan-out boundaries sit;
- whether the repo is thin wearable bridge, rich host platform, plugin manager,
  embedded firmware, or biosignal pipeline;
- how accessory safety, discovery, or configuration surfaces are exposed.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 51 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md` for honest follow-up nodes;
- `methods/vr-utility-methods-catalog.md` where this wave clarifies biometric,
  biosignal, and accessory-control methods.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- `biometric and accessory-control` donors stay distinct from ordinary haptics
  bridges;
- the family clearly separates thin wearable bridges, richer host platforms,
  plugin managers, embedded controllers, and biosignal pipelines;
- `.research-sources/` stays ignored by git;
- documentation indexes link to the new wave cleanly.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 51 synthesis document exists with code-level findings;
4. the registry and families clearly represent biometric, biosignal, and
   accessory-control platforms;
5. new biometric and accessory-control methods are added where justified;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
