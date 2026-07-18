# GitHub Research Wave 479 Plan

- Date: `2026-07-18`
- Theme: VRM/GLB pose-scene authoring and downstream generator adapters.

## Frozen Scope

- `ketle-man/comfyui-vrm-pose-editor`
- `hidenoji1/comfyui-vrm-scene-editor`
- `k3peta/web-vrm-poser`
- `Module-Code/WebXR_DePanther`

## Research Questions

- How do browser/ComfyUI tools turn 3D editor state into reusable downstream
  artifacts?
- Which boundaries separate model storage, editor UI, capture channels, and
  generator node integration?
- What can Unity WebXR packaging teach without copying generated project bulk?

## Required Extraction

- VRM/GLB/GLTF intake and provenance
- pose schema and bone mapping
- capture/export channel model
- ComfyUI route and preview-node plumbing
- browser-only conversion and download flow
- WebXR package/template evidence and caveats
