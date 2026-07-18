# 🧱 Brick Breaker

A **2D arcade-style Brick Breaker game** developed using **Unity and C#** as an internship project.

The player controls a paddle to keep the ball in play and destroy all bricks on the screen. The game includes multiple levels, score tracking, level progression, restart functionality, and interactive game UI.

---

## 🎮 Gameplay

The objective is simple:

* Control the paddle and prevent the ball from falling.
* Bounce the ball toward the bricks.
* Destroy all bricks to complete the level.
* Progress through different levels with changing layouts.
* Try to achieve the highest possible score.

---

## ✨ Key Features

* 🎯 Classic brick-breaking gameplay
* 🕹️ Smooth paddle movement
* ⚽ Ball movement and collision physics
* 🧱 Brick collision and destruction system
* 🏆 Real-time score tracking
* ❤️ Player life/game-state management
* 🎮 Multiple playable levels
* 🔄 Level progression system
* ✅ Level Complete screen
* ⏭️ Next Level functionality
* 🔁 Restart functionality
* 🚪 Exit option
* 🎨 Custom game UI and level layouts

---

## 🎥 Gameplay Preview

The gameplay demonstrates the complete game flow:

**Start Game → Control Paddle → Break Bricks → Complete Level → View Score → Progress to Next Level**

> Add your gameplay video or GIF here to give recruiters a quick preview of the game.

---

## 🛠️ Tech Stack

| Technology                 | Usage                                    |
| -------------------------- | ---------------------------------------- |
| **Unity**                  | Game development and scene management    |
| **C#**                     | Gameplay logic and game systems          |
| **Unity 2D Physics**       | Ball movement and collision handling     |
| **TextMeshPro / Unity UI** | Score and game interface                 |
| **Git**                    | Version control                          |
| **GitHub**                 | Source-code hosting and project showcase |

---

## 🎮 Controls

| Control         | Action            |
| --------------- | ----------------- |
| `← Left Arrow`  | Move paddle left  |
| `→ Right Arrow` | Move paddle right |

Use the paddle to redirect the ball and destroy every brick in the level.

---

## 🧩 Game Systems

### Ball & Paddle System

The paddle is controlled by the player while the ball uses collision-based movement to bounce between the paddle, walls, and bricks.

### Brick System

Bricks detect collisions with the ball and are removed when successfully hit, contributing to the player's score and level progression.

### Score System

The player's score increases as bricks are destroyed and is displayed when the level is completed.

### Level Management

The game contains multiple levels with different brick arrangements.

After completing a level, the player can:

* Continue to the **Next Level**
* **Restart** the level
* **Exit** the game

### Level Completion

When all required bricks are destroyed, the game displays a **Level Complete** screen containing the player's score and navigation options.

---

## 📂 Project Structure

```text
BrickBreaker/
│
├── Assets/
│   ├── Scenes/
│   ├── Scripts/
│   ├── Sprites/
│   ├── Audio/
│   └── Prefabs/
│
├── Packages/
├── ProjectSettings/
├── .gitignore
└── README.md
```

> The exact contents inside `Assets` may vary depending on the final Unity project organization.

---

## 🚀 How to Run the Project

1. Clone the repository:

```bash
git clone git@github.com:jeswanth90630/brickbreaker.git
```

2. Open **Unity Hub**.

3. Select **Add Project from Disk**.

4. Choose the cloned `brickbreaker` folder.

5. Open the project with a compatible Unity version.

6. Open the starting scene.

7. Click the **Play ▶** button in the Unity Editor.

---

## 💡 What I Learned

Building this project helped me gain practical experience in:

* Unity game development
* C# scripting
* 2D physics and collision detection
* Player input handling
* Game-state management
* Score and level systems
* Scene management
* UI implementation
* Debugging gameplay issues
* Organizing a Unity project
* Git and GitHub version control

---

## 🔮 Possible Future Improvements

* Add power-ups and special abilities
* Introduce different brick types
* Add difficulty modes
* Improve animations and visual effects
* Add background music and enhanced sound effects
* Add a high-score system
* Add pause/settings menus
* Create additional levels
* Deploy a WebGL version for browser-based gameplay

---

## 👨‍💻 Developer

**Divi Venkata Jeswanth Kumar**

Developed as an **internship game-development project** using Unity and C#.

This project demonstrates practical experience in **gameplay programming, collision systems, UI development, level management, debugging, and game-state handling**.
