# Wave 464: WebXR AR measurement and triangulation microtools

- Date: `2026-07-16`
- Scope: browser-delivered AR measuring tools, hit-test reticles, point-pair
  distance labels, anchor-backed endpoints, fallback triangulation, and
  measurement-quality UX.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `woll-an/WebXR-Measure` | Studied | Compact Three.js/WebXR hit-test measuring reference with reticle, line, and DOM label overlay |
| `Narendra-Kamath/webxr-measuring-tape` | Studied | Babylon.js WebXR measuring tape with anchors, GUI labels, multi-unit output, and persistent line updates |
| `benmoussa96/ar-tape-measure` | Lightly studied | Three.js AR tape measure variant with bundled WebXR/Three libraries and simple utility framing |
| `cs-util-com/ARTapeMeasure.js` | Studied | Modern WebXR tape measure with unit persistence, CSS2D labels, triangulation fallback, and quality feedback |
| `rtkCode/Sizer` | Cross-wave reference | Already studied Wave 243; useful overlap for measurement plus modelling/projection |

## Project notes

### `woll-an/WebXR-Measure`

- Interesting idea: a minimal AR measure loop built from `requiredFeatures:
  ['hit-test']`, a reticle matrix, two select taps, a Three.js line, and a DOM
  label projected to screen space.
- Code donor value: medium; `src/xr-session.js` clearly separates reticle
  update, `matrixToVector`, `initLine`, `updateLine`, distance calculation, and
  label repositioning.
- Product reference value: medium; shows that a useful AR utility can be a
  small browser tool rather than a full app.
- Source evidence: `src/index.js`, `src/xr-session.js`, `README.md`.
- Reusable core: hit-test source lifecycle, reticle visibility, endpoint pair,
  live provisional line, final measurement label, and screen-space label update.
- What not to copy: old Three geometry API assumptions, centimetre-only output,
  no saved history/export, and no explicit tracking-quality state.
- What to inspect next: modern WebXR hit-test compatibility, anchor support,
  label occlusion, and measurement history UX.

### `Narendra-Kamath/webxr-measuring-tape`

- Interesting idea: Babylon.js implementation that wraps WebXR hit-test,
  anchors, GUI labels, and multi-unit display in one browser AR scene.
- Code donor value: medium; `js/loader-script.js` is a readable example of
  `createDefaultXRExperienceAsync`, `WebXRHitTest`, `WebXRAnchorSystem`,
  cloned endpoint dots, line refresh, and unit conversion.
- Product reference value: medium; the `Last Measure` panel is a simple but
  useful operator readout.
- Source evidence: `README.md`, `index.html`, `js/loader-script.js`.
- Reusable core: AR support gate, enter-AR UI, hit-test dot, anchor-backed
  endpoint creation, distance panel, and persistent pair list.
- What not to copy: bundled Babylon/WebXR polyfill files, old browser support
  assumptions, and demo-only global state.
- What to inspect next: whether anchor fallback should be abstracted for
  engines without WebXR anchor support.

### `benmoussa96/ar-tape-measure`

- Interesting idea: thin Three.js AR tape measure package with a large bundled
  dependency snapshot, useful mainly as a cautionary packaging variant.
- Code donor value: low to medium; `app.js`, `index.html`, and local
  `libs/three` show a self-contained deployment approach, but the reusable
  logic is less isolated.
- Product reference value: low; confirms the same micro-utility value but with
  weaker maintainability.
- Source evidence: `README.md`, `app.js`, `index.html`, bundled Three/WebXR
  helpers.
- Reusable core: single-page AR measuring shell and local dependency fallback.
- What not to copy: checked-in framework bulk, old library snapshots, and
  unclear source provenance.
- What to inspect next: compare with `woll-an/WebXR-Measure` before using it as
  anything more than a variant marker.

### `cs-util-com/ARTapeMeasure.js`

- Interesting idea: AR measurement UX that explicitly handles no-hit moments by
  suggesting a triangulation mode, then grades triangulation geometry with
  green/yellow/red feedback.
- Code donor value: high; `src/app.js`, `src/triangulation.js`, and
  `src/triangulation-ui.js` separate measurement state, units, reticle labels,
  ray triangulation, baseline guidance, quality chips, accept/redo/cancel, and
  tests.
- Product reference value: high; it treats measurement confidence as a user
  interface problem, not just math.
- Source evidence: `src/app.js`, `src/triangulation.js`,
  `src/triangulation-ui.js`, `src/*.test.js`, `docs/triangulation-suggestion-spec.md`.
- Reusable core: measurement records, metric/imperial persistence,
  triangulate-rays fallback, baseline target/minimum, miss/angle classifier,
  quality banner, and quick actions.
- What not to copy: project-specific Tailwind/UI classes, AI-template docs, and
  GPL code into incompatible modules.
- What to inspect next: whether this triangulation fallback can become a
  provider-neutral `measurement confidence` schema.

## Reusable pattern extraction

- Pattern candidate: `Browser AR measurement confidence loop`.
- Problem solved: AR utility measurements often fail silently when hit-test or
  anchors are weak; the user needs visible reticle, endpoint, unit, history, and
  confidence state.
- Reusable core: WebXR support gate, hit-test source, reticle, endpoint pair,
  line/label rendering, unit formatter, history list, optional anchor, optional
  ray-triangulation fallback, and quality feedback.
- Source evidence: `woll-an/WebXR-Measure/src/xr-session.js`,
  `Narendra-Kamath/webxr-measuring-tape/js/loader-script.js`,
  `cs-util-com/ARTapeMeasure.js/src/app.js`,
  `cs-util-com/ARTapeMeasure.js/src/triangulation.js`.
- Abstraction boundary: keep browser APIs, math, labels, and measurement
  records separate so the same model can later serve Unity/Quest/desktop tools.
- What not to copy: demo-only global state, old bundled libraries, medical or
  precision claims, and unlabelled measurement accuracy.
- Method catalog action: add `Method 909`.

## Why this matters for VR-apps-lab

Measurement is a utility primitive for calibration, room setup, model review,
whiteboards, accessibility placement, and diagnostics. This wave strengthens
the repo's ability to talk about AR/VR measurement tools as a reusable method:
not just "draw a ruler", but expose quality, units, history, and fallbacks.

