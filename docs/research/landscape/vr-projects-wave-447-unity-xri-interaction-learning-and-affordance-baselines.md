# Wave 447: Unity XRI interaction learning and affordance baselines

## Theme

This wave studies an asset-heavy Unity/XRI learning repository as a donor map
for common interaction primitives. The value is not in importing the project,
but in cataloging small reusable affordance patterns: grab variants, sockets,
tag/key constraints, knobs, hands, room-scale correction, and validation helpers.

## Shortlist

| Project | Status | Family placement |
|---|---|---|
| `mattdway/CreateWithVR` | New study | Unity XRI learning/affordance baseline |

`Unity-Technologies/XR-Interaction-Toolkit-Examples` was considered as a
comparison node, but it was not re-synced into the local cache during this
heartbeat pass, so it is intentionally not claimed as newly studied here.

## Project notes

### `mattdway/CreateWithVR`

- Interesting idea:
  a large Unity learning project that collects XRI/Oculus-style interaction
  examples, completed scripts, starter assets, and helper/editor utilities in a
  single course-like workspace.
- Code donor value:
  moderate-to-high for individual small scripts, but low for wholesale reuse
  because the repository is asset-heavy and mixes imported samples with course
  code.
- Product reference value:
  strong as a pattern index for practical VR interaction affordances.
- Architecture pattern:
  learning repository with "completed example" scripts, imported XRI examples,
  Oculus sample framework content, starter assets, and local utility scripts.
- Source evidence:
  source search found `XRKnob`, `XRLockSocketInteractor`, key/lock/keychain
  assets, `RoomScalePlayerControllerFix_Complete`, animated physics hand
  scripts, `AutoSocket_Completed`, `XRAlyxGrabInteractable_Completed`,
  `TagSocket_Completed`, XRI starter asset validation, gaze fallback, and
  XR Hands post-processing samples.
- Reusable core:
  each interaction primitive should be extracted as a small note with required
  component, input source, state machine, validation rule, and caveat.
- What not to copy:
  large imported assets, Unity sample bulk, Oculus SDK bulk, course-specific
  scene layout, or scripts without provenance review.
- Method catalog action:
  creates `XRI interaction learning baseline`.
- What to inspect next:
  separate original course scripts from imported Unity/Oculus samples and build
  a smaller cross-reference matrix.

## Interaction primitives observed

- `XRKnob`:
  grab/select events drive a rotational UI control through XRI interactable
  lifecycle.
- `XRLockSocketInteractor` plus key/lock/keychain assets:
  socket acceptance is constrained by attached key metadata rather than object
  name alone.
- Room-scale controller fix:
  character controller height/center follows XROrigin camera height and
  position.
- Animated/physics hands:
  action-based controller values feed grip/trigger hand animation and basic
  physics hand positioning.
- Auto/tag sockets:
  socket selection can be narrowed by quick-select rules or object tags.
- Starter validation:
  XRI sample code can validate/fix required interaction-layer naming for
  teleportation.
- Gaze fallback:
  sample code shows fallback management when eye tracking is unavailable.

## Synthesis

Asset-heavy learning repos can be valuable if treated as maps, not imports. The
right reusable unit is a primitive record:

- primitive name
- required package/component
- input source
- interaction lifecycle hook
- state/constraint model
- feedback/affordance
- validation rule
- provenance and copy caveat

## Follow-up backlog

- Build an XRI affordance matrix from small scripts only.
- Separate course-original scripts from Unity/Oculus imported samples.
- Compare socket constraints across key, tag, grid, and lock styles.
- Document headsetless/simulator fallback for XRI learning examples.
