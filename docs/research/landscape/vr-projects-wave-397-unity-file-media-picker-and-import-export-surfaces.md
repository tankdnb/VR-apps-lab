# Wave 397: Unity File, Media Picker, and Import/Export Surfaces

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device
  tests.

## Theme

This wave studies file/media intake primitives that future VR utilities need
for loading videos, models, configs, datasets, screenshots, and exports from
desktop, Android, iOS, or Quest-like environments.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `yasirkula/UnitySimpleFileBrowser` | Studied | Runtime in-app file browser |
| `yasirkula/UnityNativeFilePicker` | Studied | Mobile native document picker |
| `yasirkula/UnityNativeGallery` | Studied | Mobile gallery/photo/video bridge |
| `gkngkc/UnityStandaloneFileBrowser` | Studied | Desktop native file dialog bridge |

## Findings

### `yasirkula/UnitySimpleFileBrowser`

- Interesting idea: provide an in-app uGUI browser with filters, quick links,
  multi-select, folder picking, coroutine/callback APIs, Android SAF support,
  and recycled-list performance.
- Code donor value: `FileBrowser.cs`, `DisplayedEntriesFilter`,
  `CustomSearchHandler`, `ShowLoadDialog`, `ShowSaveDialog`, permission gate,
  quick links, and active-dialog guard.
- Product reference value: useful for VR media/model/config pickers where a
  spatial shell still needs a file-system-like surface.
- What to inspect next: adapting list rows to spatial input, Quest SAF
  friction, and save/load callback cancellation semantics.
- Caveat: Quest visibility issues are called out upstream; a VR wrapper needs a
  fallback path and user-facing permission explanation.

### `yasirkula/UnityNativeFilePicker`

- Interesting idea: abstract Android/iOS document providers through async
  pick/export APIs and MIME/UTI filters.
- Code donor value: `NativeFilePicker.cs`, `PickFile`,
  `PickMultipleFiles`, `ExportFile`, `RequestPermissionAsync`, Android Java
  bridge, and iOS document picker bridge.
- Product reference value: good pattern for importing external configs,
  datasets, model files, or study exports from mobile XR devices.
- What to inspect next: persistent-copy policy, MIME registry, busy-state UX,
  and VR lifecycle timing workaround.
- Caveat: raw paths are not portable; iOS picked files may disappear unless
  copied into persistent storage.

### `yasirkula/UnityNativeGallery`

- Interesting idea: separate media gallery/photo/video read/write from general
  document picking with explicit permission type and media type.
- Code donor value: `NativeGallery.cs`, `SaveImageToGallery`,
  `SaveVideoToGallery`, media pick callbacks, thumbnail loading, iOS
  permission-free mode, and Android/iOS native bridges.
- Product reference value: useful for screenshot capture, video import, and
  gallery-based spatial media utilities.
- What to inspect next: permission UX, media retention, thumbnail cache, and
  Quest/Android 13+ access quirks.
- Caveat: platform-specific permission semantics should not be hidden behind a
  generic "open media" button.

### `gkngkc/UnityStandaloneFileBrowser`

- Interesting idea: wrap Windows/Mac/Linux native open/save dialogs behind
  sync/async Unity APIs and extension filters.
- Code donor value: `StandaloneFileBrowser`, extension filters, desktop
  platform plugins, async callback API, sample scenes, and WebGL caveats.
- Product reference value: good desktop companion pattern for VR utilities that
  import models, datasets, logs, or media while the headset app stays thin.
- What to inspect next: focus loss, async behavior differences by platform,
  IL2CPP compatibility, and WebGL fallback rules.
- Caveat: native dialogs are not head-mounted UI; they need clear desktop-vs-VR
  ownership.

## Reusable Pattern Extraction

- Pattern candidate: `XR file and media intake boundary`.
- Problem solved: VR tools need safe import/export without pretending every
  platform returns normal filesystem paths.
- Reusable core: provider type, permission state, MIME/UTI/filter schema,
  picker mode, multi-select support, cancel callback, busy guard,
  persistent-copy rule, thumbnail/media loader, quick links, and platform
  capability label.
- Source evidence: SimpleFileBrowser runtime browser, NativeFilePicker
  document bridge, NativeGallery media bridge, and StandaloneFileBrowser
  desktop dialog wrapper.
- Abstraction boundary: keep platform picker APIs behind a file-intake service
  and let VR UI own only the request, progress, preview, and result handling.
- What not to copy: raw path assumptions, hidden permission prompts, blocking
  desktop dialogs in headset-only flows, or unsupported Quest/SAF behavior
  without fallback.
- Method catalog action: add Method 842.
