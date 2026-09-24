# 🚗 Delivery Package

A 2D delivery-driving game developed in **Unity using C#**. The player controls a delivery vehicle, collects packages, and delivers them to customers while navigating through the level.

This project was developed as part of my journey learning **Unity game programming and C# gameplay systems**.

## 🎮 Gameplay

The player controls a delivery vehicle and must:

* Drive around the level
* Pick up packages
* Deliver packages to customers
* Navigate through different areas
* Use boost zones to temporarily increase speed
* Avoid areas that temporarily slow the vehicle

## ✨ Features

### 🚗 Vehicle Movement

* 2D vehicle movement using Unity's input system.
* Forward and backward movement.
* Steering and rotation using frame-rate-independent movement.

### 📦 Package Pickup & Delivery

* Detects packages using trigger collisions.
* Prevents the player from carrying multiple packages at once.
* Changes the player's visual state when carrying a package.
* Removes the package after pickup.
* Allows the package to be delivered to the correct customer trigger.

### ⚡ Speed Boost System

* Implemented temporary speed boosts using **C# Coroutines**.
* Boost zones increase the vehicle's movement speed for a limited duration.
* Vehicle automatically returns to normal speed after the boost expires.

### 🐌 Slow Zones

* Collision with specific areas temporarily reduces vehicle speed.
* Uses the same temporary-speed system with a timed Coroutine.

### 🎥 Follow Camera

* Implemented a custom camera-follow system using `LateUpdate()`.
* Camera continuously follows the player vehicle while maintaining a fixed offset.

## 🛠️ Technologies

* **Engine:** Unity
* **Language:** C#
* **Genre:** 2D Arcade / Delivery
* **Physics:** Unity 2D Physics
* **Version Control:** Git & GitHub

## 🧠 Programming Concepts

This project helped me practice:

* C# scripting
* Unity MonoBehaviour
* `Update()` and `LateUpdate()`
* Input handling
* Collision and trigger detection
* GameObject tags
* Coroutines
* Temporary gameplay states
* Object destruction
* Basic camera systems
* 2D gameplay programming

## 📂 Main Scripts

| Script            | Responsibility                                                   |
| ----------------- | ---------------------------------------------------------------- |
| `Driver.cs`       | Handles vehicle movement, steering, boost and slowdown mechanics |
| `Delivery.cs`     | Handles package pickup and delivery                              |
| `FollowCamera.cs` | Follows the player vehicle with the camera                       |

## 🎯 What I Learned

Through this project, I gained practical experience implementing gameplay mechanics in Unity and learned how different gameplay systems communicate through collisions, triggers, player states, and timed events.

The project also introduced me to using **Coroutines** for temporary gameplay effects such as speed boosts and slowdowns.

## 🚀 Future Improvements

Possible improvements include:

* Multiple delivery missions
* Delivery timer and scoring system
* Different vehicle types
* More levels
* Fuel system
* Traffic and obstacles
* Improved UI
* Main menu and level selection
* High-score system

## 📸 Screenshots

Add gameplay screenshots here.

```text
Coming soon
```

## 🎥 Gameplay

Add a gameplay video/GIF here.

```text
Coming soon
```

## 👨‍💻 Author

**Harshil Patel**

Game Programming Student | Unity | C# | Unreal Engine

[GitHub](https://github.com/Harshil2308)
