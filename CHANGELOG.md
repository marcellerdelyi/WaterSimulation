# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.1.0] - 2026-02-28
### Added
- Wave physics: `WaveManager`:
  - Configurable wave parameters (amplitude, length, speed).
  - Time-based wave offset update.
  - Compute a sinusoidal height (wave height): `GetWaveHeight(float x)`.

- Deforming water surface: `WaterManager`:
  - Mesh vertex displacement based on sampled wave height.
  - Automatic normal recalculation: `recalculateNormals`

- Floating physics: `Floater`:
  - Buoyancy force applied when object is below the wave surface.
  - Configurable submersion depth and displacement strength.
  - Water resistance forces:
    - Linear drag (dampening velocity in water).
    - Angular drag (dampening rotation in water).

- 3D model asset:
  - `FishCage_1_50_Model.fbx`