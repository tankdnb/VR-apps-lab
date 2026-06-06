# GitHub Research Wave 180 Backlog

- Date: `2026-06-06`
- Theme: `XR text-entry keyboards, input surfaces, and pointer/text bridges`
- Status: executed as static source-reading pass
- Build/run status: not run, not built, not installed, not launched

## Completed Intake

- Shortlisted XR text-entry projects across WebView, WebXR, Unity, A-Frame,
  Bevy/OpenXR, and Stardust XR plugin families.
- Deduplicated against earlier VR keyboard/text-entry and overlay research.
- Read source entry points without executing found projects.
- Integrated keyboard/input-surface methods into the canonical research docs.

## Follow-Up Work

- Create a `VR text-entry matrix` comparing:
  WebView, mesh/UV, canvas texture, physical collider, hand-attached, and OS
  key-event injection approaches.
- Compare keyboard UX for controller ray, direct physical press, hand pinch,
  and remote/browser pointer input.
- Track accessibility requirements for future VR text input:
  focus state, spoken feedback, large keys, hand tremor tolerance, and language
  switching.
- Compare `ultraleap/XR-Keyboard` against Wave 180 keyboard donors in a future
  consolidation pass, without duplicating it in the registry.

## Reuse Candidates

- Browser-rendered keyboard bridge from `vuplex/unity-keyboard`.
- Raycast-to-UV key-mask model from `felixtrz/xrkeys`.
- Canvas dirty-texture keyboard with swipe suggestions from
  `VirtualKeyboard-VR-Ready`.
- Physical collider key press state from `XRSimpleKeyboard`.
- Minimal A-Frame keyboard plus WebSocket bridge from `vr-virtual-keyboard`.
- Shell key-event plugin boundary from `stardust-xr-keyboard-plugin`.

## Caveats To Preserve

- Several keyboard samples are engine-specific, old, or thin.
- Generated Unity folders and package artifacts from study repos should not be
  copied into `VR-apps-lab`.
- Keyboard input is privacy-sensitive; future prototypes should make focus,
  destination, and text visibility explicit.
