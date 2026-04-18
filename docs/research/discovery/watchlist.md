# Discovery Watchlist

- Date: `2026-04-18`
- Goal: keep the repository expansion focused on the highest-value areas instead
  of growing randomly.

## Highest-priority discovery streams

### 1. WebSocket tracker drivers and pose bridges

Why:

- strongest path toward a future `Tracker Bridge Service`
- rich overlap with OSC, remote control, and virtual tracker tooling

What to look for:

- tracker driver forks
- pose streaming services
- WebSocket/JSON tracking transports
- body-state bridge tools

### 2. Vendor enhancement tooling

Why:

- useful pattern for augmenting official stacks without replacing them

What to look for:

- PSVR2 enhancement tools
- vendor-specific developer APIs
- runtime augmentation layers
- headset-specific utility mods

### 3. Battery, device health, and notification micro-tools

Why:

- repeated high-value utility class
- good source of tiny, practical VR product ideas

What to look for:

- tray tools
- overlay battery widgets
- charger/discharge notifications
- device inventory views

### 4. Accessibility overlays

Why:

- still underrepresented as a formal product branch in `VR-apps-lab`

What to look for:

- captions
- assistive HUDs
- warning/status overlays
- comfort guidance tools

### 5. Desktop and dashboard overlay UX variants

Why:

- huge overlap family with many product lessons

What to look for:

- watch-based controls
- low-overhead desktop overlays
- dashboard suites
- window portal UX patterns

### 6. Overlay implementation templates and host scaffolds

Why:

- useful for extracting methods, not only product ideas
- strongest path to better `VR-apps-lab` implementation guidance

What to look for:

- minimal overlay samples
- browser-backed overlay shells
- Vulkan/OpenGL/Unity/Godot reference implementations
- scene-host helpers for overlay-first workflows

### 7. SteamVR environment helpers and runtime hygiene tools

Why:

- small but high-value problem-solving tools are underrepresented in the repo
- they often reveal unusual but very practical engineering tricks

What to look for:

- dashboard fixes
- SteamVR toggles
- compositor or distortion adjustment helpers
- performance support scene apps

## Next recommended discovery pass

If expanding `VR-apps-lab` further, the next best pass should combine:

1. `tracker bridges`
2. `OSC/control export`
3. `vendor enhancement`
4. `battery/device monitoring micro-tools`
5. `overlay implementation references and runtime hygiene helpers`
