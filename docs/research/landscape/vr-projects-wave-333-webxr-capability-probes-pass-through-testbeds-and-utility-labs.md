# Wave 333 - WebXR Capability Probes, Pass-Through Testbeds, and Utility Labs

This wave studies browser-side WebXR utility pages and helper libraries:
capability probing, report export, pass-through/video surface experiments, AR
placement helpers, loading indicators, and thin utility lab references.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to:

- browser-only XR capability checks;
- WebXR/WebGL/WebRTC/media/WebGPU feature probes;
- pass-through/video plane testbeds;
- small WebXR helper/toolbox repositories.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `rwth-acis/i5-Toolkit-for-WebXR` | WebXR helper library and examples | Studied | Useful donor for AR hit-test placement helper, boundary-box helper, and simple loading indicator abstraction around Three.js/WebXR |
| `gareth-morgan-nv/WebXR-utils` | WebXR capability probe and pass-through test pages | Studied | Strong donor for standalone browser feature matrix, spec-linked checks, JSON export, WebXR/WebGPU/media/WebRTC probes, and WebGL pass-through plane experiments |
| `webvrdev/webvrdev-labs` | Thin WebXR utility lab index | Thin reference | Product-reference placeholder for a lightweight public lab surface; current repo only contains README/license, so no code donor value yet |

## Code-Level Findings

### `rwth-acis/i5-Toolkit-for-WebXR`

- Interesting idea: package common WebXR helper affordances as small Three.js
  classes rather than full app templates.
- Code donor value: medium. `PlacementHelper` owns reticle creation, controller
  select handling, viewer reference space requests, hit-test source lifecycle,
  session end cleanup, and hit matrix application. `BoundaryBox` reuses the
  hit-test flow to move an object while in edit mode. `LoadingIndicator`
  creates a grouped cube spinner with a simple render hook.
- Product reference value: medium for AR placement, edit handles, and loading
  affordances.
- What to inspect next: example app integration, package publishing state,
  object editing beyond placement, and cleanup around event listeners.
- Architecture pattern: tiny helper class + render hook + WebXR session/hit
  test dependency injection.
- Reusable method: WebXR helper microclass for placement and loading.
- Constraints / caveats: older, small, and not a complete utility app.

### `gareth-morgan-nv/WebXR-utils`

- Interesting idea: a static site can act as an XR capability doctor and as a
  pass-through rendering testbed without native tooling.
- Code donor value: high for diagnostics. `CapabilitiesCheck` defines
  specification URLs, runs browser/media/WebRTC/WebXR/WebGPU checks with
  timeouts, stores a report, and exposes export behavior. `PassThrough` builds
  a WebGL2 texture plane pipeline, separates texture upload, GL reset, shader
  creation, tessellated plane geometry, source choice, VR/AR session buttons,
  and frame updates.
- Product reference value: very high for browser-side XR doctors, headset
  browser diagnostics, and WebXR surface experiments.
- What to inspect next: export report schema, full list of capability rows,
  pass-through source switching, and how it behaves across headset browsers.
- Architecture pattern: static page + capability matrix + spec evidence +
  exportable report + optional rendering testbed.
- Reusable method: browser XR capability report.
- Constraints / caveats: browser permissions affect results; local clone showed
  LFS pointer warnings for media assets, but code reading was unaffected.

### `webvrdev/webvrdev-labs`

- Interesting idea: present a small public lab as a landing page for texture,
  editor, generator, productivity, and WebXR workflow utilities.
- Code donor value: low currently. The cloned repo contains README/license only.
- Product reference value: low-medium as a naming/positioning pattern for a
  public utility lab.
- What to inspect next: watch for published tools under the same organization
  or GitHub Pages branch.
- Caveat: no code-level donor content yet.

## Reusable Pattern Extraction

- Pattern candidate: browser XR capability and pass-through testbed.
- Problem solved: developers need a quick way to tell whether a headset browser
  supports the APIs required for WebXR utilities before building native
  diagnostics.
- Reusable core: static entry page, grouped feature checks, timeout wrapper,
  spec/source evidence links, permission-aware results, JSON export, optional
  rendering plane test, and clear pass/fail summary.
- Source evidence: `gareth-morgan-nv/WebXR-utils` and
  `rwth-acis/i5-Toolkit-for-WebXR`.
- Abstraction boundary: keep capability collection, report formatting, export,
  and rendering experiments separate.
- What not to copy: unversioned reports, hardcoded media assumptions,
  browser-permission side effects without explanation, or thin lab READMEs as
  proof of implementation.
- Method catalog action: add browser XR capability and pass-through testbed.

## Follow-Up Gaps

- Compare browser capability probes with native OpenXR doctor and validation
  waves.
- Define a minimal JSON schema for headset browser capability reports.
- Search later for maintained WebXR utility labs with real published code.
