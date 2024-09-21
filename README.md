# Space Invaders Console Game

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Requirements](#requirements)
- [Usage](#usage)
- [Game Objects](#game-objects)
- [Controls](#controls)
- [Points and Scoring](#points-and-scoring)
- [Contributing](#contributing)
- [License](#license)

## Introduction
This project is a console-based game, **Space Invaders**, developed in C#. The aim is to create a playable version of the classic arcade game, where the player controls a ship to defend the Earth from alien invaders. The game logic simulates the basic mechanics, including user controls, alien shooting, and the destruction of Earth’s surface.

## Features
- **Basic Game Mechanics**: Primitive representation of core game objects (player ship, alien ships, rockets, etc.).
- **User Control**: Control your player ship using keyboard input and shoot down incoming alien invaders.
- **Enemy Behavior**: Alien ships move and shoot towards the Earth’s surface and the player.
- **Collision Detection**: Aliens, player, and surface take damage based on rocket hits.
- **GameOver State**: The game ends if the player’s ship is hit or if all surface objects are destroyed.
- **Scoring System**: Track how many aliens are destroyed and how much of Earth’s surface remains intact.

## Requirements
- The source code is hosted on GitHub. Make sure you have a Git client installed to clone the repository.
- Install any necessary development tools like the .NET SDK to run and compile the C# code.

## Usage
Once the game is running in the console, you can control the player ship using the following keyboard commands.

## Game Objects
The game includes several basic objects:
- **Player Ship**: Controlled by the player to shoot down alien ships.
- **Alien Ship**: Moves across the screen and shoots rockets toward Earth.
- **Player Rocket**: Fires from the player ship to destroy alien ships.
- **Alien Rocket**: Fired by alien ships to damage the player or the Earth’s surface.
- **Earth Surface**: Protect the Earth’s surface from being destroyed by alien rockets.

## Controls
- `Left Arrow`: Move player ship left.
- `Right Arrow`: Move player ship right.
- `Spacebar`: Fire player rocket.
- `P`: Pause the game.
- `Enter`: Restart the game after GameOver.
- `Escape`: Quit the game.

## Points and Scoring
- Gain points by destroying alien ships.
- Lose points or surface health when an alien rocket hits the Earth’s surface.
- The score is displayed at the bottom of the screen.

## Contributing
If you would like to contribute to the project:
1. Fork the repository.
2. Create a new branch.
3. Make your changes.
4. Submit a pull request.

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.
