<div align="center">

# 🧱 Brick Breaker
### Physics-Based Arcade Game — Built in Unity (C#)

![Unity](https://img.shields.io/badge/Unity-2D-black?logo=unity)
![C#](https://img.shields.io/badge/C%23-Gameplay-239120?logo=csharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Complete-brightgreen)
![License](https://img.shields.io/badge/License-MIT-blue)

A fully playable 2D arcade game recreating the classic brick-breaking genre with custom physics, level progression, and a complete UI/UX loop — from menu to game over.

[Live Demo](#) · [Gameplay Video](#) · [Report Bug](#) · [Repo](https://github.com/jeswanth90630/brickbreaker)

</div>

---

## 📌 Why This Project

Most tutorials stop at "ball bounces off paddle." This build goes further — a working **level system with progression, scoring, and win/loss states**, built to understand how a game holds together end-to-end, not just one mechanic in isolation.

---

## 🎮 Core Systems

| System               | Description                                                                          |
|:---------------------|:--------------------------------------------------------------------------------------|
| **Paddle Controller** | Smooth, frame-rate-independent movement mapped to arrow-key input                    |
| **Ball Physics**      | Custom collision response — bounce angle reacts to paddle contact point               |
| **Brick Manager**     | Tracks brick state across the grid, updates score and win-condition in real time      |
| **Level Manager**     | Loads distinct brick layouts per level, handles transitions and progression           |
| **Game State Machine**| Governs flow: Start → Playing → Level Complete → Game Over → Restart                  |
| **UI Layer**          | Live score, lives counter, level-complete screen with Next Level / Restart / Exit     |

---

## 🛠️ Tech Stack

<div align="center">

| Category         | Tools                                  |
|:-----------------|:----------------------------------------|
| Engine            | Unity                                   |
| Language          | C#                                      |
| Physics           | Unity 2D Physics Engine                 |
| UI                | TextMeshPro / Unity UI                  |
| Version Control   | Git, GitHub                             |

</div>

---

## 📊 Project Snapshot

<div align="center">

| Metric              | Value                     |
|:---------------------|:--------------------------|
| Levels shipped        | [X] distinct layouts      |
| Build duration         | May 2025 – July 2025      |
| Development mode       | Solo (internship project) |
| Core scripts           | Paddle, Ball, Brick, LevelManager, GameManager, UIManager |
| Lines of C#             | ~[X]                      |

</div>

---

## 🧠 Engineering Decisions

- **Collision-based bounce angle** instead of a fixed reflection — the ball's exit angle depends on where it hits the paddle, giving the player real control over shot placement.
- **Centralized GameManager** as a single source of truth for score, lives, and level state — avoids scattered state across scripts.
- **Event-driven UI updates** rather than per-frame polling, keeping the UI layer decoupled from gameplay logic.

---

## 🚀 Getting Started

```bash
git clone git@github.com:jeswanth90630/brickbreaker.git
```

| Step | Action |
|:-----|:-------|
| 1 | Open Unity Hub → **Add Project from Disk** |
| 2 | Select the cloned `brickbreaker` folder |
| 3 | Open with Unity [version] or later |
| 4 | Open the main scene under `Assets/Scenes` |
| 5 | Press **Play ▶** |

---

## 🔮 Roadmap

- [ ] Power-ups (multi-ball, paddle-extend, slow-motion)
- [ ] Difficulty tiers with adaptive brick layouts
- [ ] Persistent high-score leaderboard
- [ ] WebGL deployment for browser play
- [ ] Sound design pass

---

<div align="center">

## 👨‍💻 Developer

**D V Jeswanth Kumar**
B.Tech Computer Science Engineering

[![GitHub](https://img.shields.io/badge/GitHub-jeswanth90630-181717?logo=github)](https://github.com/jeswanth90630)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Connect-0077B5?logo=linkedin&logoColor=white)](#)

</div>
