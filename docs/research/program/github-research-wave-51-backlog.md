# GitHub Research Wave 51 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `biometric bridges`, `neurofeedback OSC paths`, and
  `avatar-facing accessory-control platforms`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for heart-rate bridges, biosignal OSC, avatar-facing accessory-control hosts, and embedded OSC controller platforms
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans thin wearable bridges, rich biometric companions, browser-plus-node wearables, plugin-based accessory managers, embedded controller firmware, and biosignal pipelines

## Work package B: Local source acquisition

- `Done` Confirm `PulsoidToOSC` in local cache
- `Done` Confirm `iron-heart` in local cache
- `Done` Confirm `vrc-osc-miband-hrm` in local cache
- `Done` Confirm `vrc-osc-manager` in local cache
- `Done` Confirm `OpenShock-ESP-Legacy` in local cache
- `Done` Confirm `BrainFlowsIntoVRChat` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect Pulsoid auth, `OSCQuery` auto-config, and chatbox templating in `PulsoidToOSC`
- `Done` Inspect multi-input host state, charts, logs, and output boundaries in `iron-heart`
- `Done` Inspect browser-to-node bridge flow and parameter encodings in `vrc-osc-miband-hrm`
- `Done` Inspect plugin registry, settings callbacks, and accessory plugins in `vrc-osc-manager`
- `Done` Inspect WiFi onboarding, config storage, safety surfaces, and OSC handling in `OpenShock-ESP-Legacy`
- `Done` Inspect biosignal modules, nested parameter schema, and OSC reporting in `BrainFlowsIntoVRChat`

## Work package D: Repository updates

- `Done` Add Wave 51 plan document
- `Done` Add Wave 51 backlog document
- `Done` Add Wave 51 synthesis document
- `Done` Update the project registry for biometric, biosignal, and accessory-control platforms
- `Done` Add a new overlap family for biometric and accessory-control bridges
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes
- `Done` Update the methods catalog with biometric, biosignal, and accessory-control methods
- `Done` Update documentation indexes to include Wave 51

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare `PulsoidToOSC`, `iron-heart`, and `vrc-osc-manager` directly as `thin bridge`, `rich companion`, and `plugin-oriented accessory host`
- `Next` Keep `OpenShock-ESP-Legacy` visible whenever a future branch needs `embedded accessory-control` instead of a desktop-only bridge
- `Next` Revisit `samyk/myo-osc` only if a later pass needs a historical `wearable input to OSC` comparison node
