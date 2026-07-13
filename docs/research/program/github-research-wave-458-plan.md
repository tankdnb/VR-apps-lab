# GitHub Research Wave 458 Plan

- Wave: `458`
- Theme: `Quest ADB device-operator sidecars`
- Status: `completed`

## Frozen scope

- `thedroidgeek/oculus-wireless-adb`
- `project-SIMPLE/adb-auto-enable`
- `DevOculus-Meta-Quest/QuestADBServices`
- `mitchv2020/QuestToolbox`

## Research questions

- How do Quest operator tools enable/discover ADB, keep transport alive, expose
  status, and package desktop/headset commands?
- Which safety gates are required for privileged settings, accessibility
  automation, and bundled binaries?
- What can become a reusable device-operator sidecar pattern?

## Dedupe notes

- Exact repositories were not present in the registry.
- Existing overlap includes Quest operator companions and ADB telemetry tools,
  but this pass focuses on ADB enablement and operator sidecars.

## Expected outputs

- Wave landscape document.
- Registry/family entries for Quest ADB sidecars.
- Method catalog entry for Quest operator sidecars with explicit safety gates.
- Follow-up backlog for operation schemas, dry-run UX, and privileged action
  labels.

