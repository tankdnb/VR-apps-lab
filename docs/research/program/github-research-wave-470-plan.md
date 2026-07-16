# GitHub Research Wave 470 Plan

- Date: `2026-07-16`
- Theme: virtual display and spatial desktop sidecars.

## Frozen scope

- `StevenRice99/Virtual-Monitors`
- `arigandores/AirPin`
- `KtzeAbyss/Easy-Virtual-Display`
- `timminator/Virtual-Display-Driver`
- existing XR-glasses and remote desktop families as overlap references

## Research questions

- How do virtual-display tools expose driver lifecycle, monitor inventory, and
  safe teardown?
- How do capture and layout tools turn monitors into XR panels or pinned
  spatial screens?
- What should be treated as dependency boundary instead of donor code?

## Required extraction

- driver lifecycle and safety gates
- monitor inventory/layout schema
- capture and spatial placement boundary
- caveats for privileged operations, bundled binaries, and Windows-only scope

