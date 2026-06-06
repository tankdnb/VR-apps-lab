# Wave 262 - VPM Package Index Generation, Flatpak, and Repository Publication Tooling

This wave studies VRChat Package Manager (VPM) repository tooling. The focus is
how creator packages are indexed, validated, distributed, and presented to VCC
or ALCOM users.

## Scope

The wave was bounded to projects that help publish or consume VPM package
repositories:

- VPM index generation from GitHub releases;
- manifest/lockfile management;
- package URL validation and hash checking;
- VCC protocol links and public listing pages;
- Flatpak packaging for VRChat's VPM CLI;
- minimal public VPM repository shapes.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Limitex/voyager-vpm` | VPM index generator CLI | Studied | Crash-safe Rust CLI for fetching package manifests and generating/validating indexes |
| `NathMorgan/vrchat-vpm` | Flatpak VPM CLI package | Studied | Linux packaging wrapper for VRChat VPM CLI with license notices |
| `tamakiii/vrchat-vpm` | Static VPM listing reference | Studied | Minimal GitHub Pages `vcc://vpm/addRepo` landing page and JSON |
| `cuebitt/vpm` | Public VPM repository listing | Studied | Package repo with source manifest, generated listing website, search, modals, and add-to-VCC links |

## Code-Level Findings

### `Limitex/voyager-vpm`

- Interesting idea:
  treat VPM repository generation as a crash-safe CI/CD pipeline with
  manifest, lock, fetch, generate, validate, and recovery steps.
- Code donor value:
  strong for `voyager.toml` config, `voyager.lock` hash checks,
  transaction log recovery, GitHub release pagination, release asset download
  with retry/backoff, manifest validation, SemVer checks, ZIP URL validation,
  package ID rules, URL validation, and `index.json` generation from lockfile.
- Product reference value:
  excellent donor for any future package-index or repository-maintenance
  helper in `VR-apps-lab`.
- What to inspect next:
  generated output compatibility with VCC/ALCOM, release asset conventions,
  GitHub token UX, and reusable validation report format.
- Caveats:
  actively specific to GitHub releases and VPM package manifests; not a
  general package manager.

### `NathMorgan/vrchat-vpm`

- Interesting idea:
  package VRChat's VPM CLI as a Flatpak-style Linux command with explicit
  license separation.
- Code donor value:
  useful for packaging boundary: dotnet SDK extension, local NuGet source,
  pinned VRChat.VPM.CLI package, host filesystem permission, network share,
  and third-party license notices.
- Product reference value:
  good reminder that VRChat tooling workflows need Linux distribution
  wrappers, not just Unity editor packages.
- What to inspect next:
  Flatpak permission minimization, update cadence, upstream VPM CLI versions,
  and official license constraints.
- Caveats:
  depends on VRChat components under separate licenses and broad filesystem
  access.

### `tamakiii/vrchat-vpm`

- Interesting idea:
  a tiny static page can turn VPM JSON files into clickable VCC add-repository
  links.
- Code donor value:
  useful for minimal `vcc://vpm/addRepo?url=...` URL generation and a simple
  handcrafted package index JSON.
- Product reference value:
  good low-friction publication reference for tiny creator packages.
- What to inspect next:
  schema completeness, URL encoding, version naming, and whether the package
  `versions` key should use normalized SemVer.
- Caveats:
  minimal index data and manual maintenance.

### `cuebitt/vpm`

- Interesting idea:
  combine source package references with an attractive generated listing site
  that exposes search, package metadata, dependency lists, copyable URLs, and
  Add-to-VCC buttons.
- Code donor value:
  useful for source manifest shape (`githubRepos`), landing-page template,
  package search, detail modal, dependency/keyword/license display, VCC URL
  copy buttons, and `vcc://vpm/addRepo` deep links.
- Product reference value:
  strong public-facing package repository reference for creator tooling.
- What to inspect next:
  GitHub Actions workflow, package-list generator, schema source of truth, and
  accessibility of generated site.
- Caveats:
  template-generated JS, external Fluent UI dependency, and package metadata
  quality depends on upstream releases.

## Reusable Pattern Extraction

- Pattern candidate:
  VPM package repository pipeline with manifest, lock, release fetch,
  validation, generated index, and public listing.
- Problem solved:
  creator tools become reusable only when users can add, update, and inspect
  packages safely through VCC/ALCOM-compatible repositories.
- Reusable core:
  package source manifest, release asset fetcher, package manifest validator,
  lockfile and hash guard, crash-recoverable write, URL validator, generated
  `index.json`, VCC protocol link, public listing UI, license notices, and
  packaging/distribution constraints.
- Source evidence:
  `voyager-vpm` for the CLI pipeline, `vrchat-vpm` for Linux/Flatpak
  packaging, `tamakiii/vrchat-vpm` for minimal static links, and `cuebitt/vpm`
  for public package-listing UX.
- Abstraction boundary:
  package-index generation should be separate from package authoring; both
  should expose validation results before users add repositories.
- What not to copy:
  broad host filesystem permissions without warnings, manual schema drift,
  unvalidated package URLs, unpinned release assets, and public pages that hide
  license/dependency information.
- Method catalog action:
  create a method for VPM package repository publication and validation.

## Family Placement

This wave creates a VPM package index and creator package publication family.
It overlaps with VRChat creator package/composition waves and VRCOSC module
distribution, but the reusable center is distribution infrastructure rather
than avatar logic.

## Backlog Impact

- Build a VPM publication checklist for future reusable packages:
  `package.json`, release assets, generated index, validation, license notes,
  VCC add link, and update cadence.
- Compare `voyager-vpm`, VRChat template-package automation, and static
  hand-authored indexes.
- Track Linux packaging constraints for VRChat creator CLI workflows.
