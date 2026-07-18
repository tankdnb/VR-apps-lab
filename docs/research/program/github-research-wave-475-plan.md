# GitHub Research Wave 475 Plan

- Date: `2026-07-18`
- Theme: XR file/model/media intake and local viewer surfaces.

## Frozen scope

- `ClassOutside/WebXR-Model-Viewer`
- `Betakontext/rgbtoxyzpointcloud`
- `immerse-zhaw/VR_Video_Player_GLB`
- `lxseguin/local-vr-viewer`
- `jjhna/UnityBrowserAssetsVR`

## Research questions

- How do XR utilities expose local files and folders without turning the viewer
  into an unsafe filesystem browser?
- Which local transport patterns recur across HTTPS, WebSocket, browser cache,
  and Unity persistentData folders?
- What viewer controls and provenance labels are needed for models, images,
  point clouds, and videos?

## Required extraction

- file/folder scope and format whitelist
- local transport and model-info endpoint
- viewer loading/progress/error UX
- WebXR/Unity import and command bridge
- security, provenance, and device-performance caveats
