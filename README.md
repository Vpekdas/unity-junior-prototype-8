# unity-junior-counting-prototype-8

## Screenshots

https://github.com/user-attachments/assets/21c94d18-aa9a-48d6-925d-f9892e95235e

## Table of Contents
1. [Description](#description)
2. [Installation](#installation)
3. [Run](#run)
4. [Credits](#credits)
5. [Contributing](#contributing)
6. [License](#license)

## Description

This prototype is part of the Junior Programmer Pathway from Unity Learn. Its purpose is to teach the fundamentals of gameplay mechanics through scripting in C#.
Unlike earlier prototypes, this project begins with a simple scenario: Each time a ball lands in the box, a counter increases. The main goal is to understand how this counting mechanism works, then repurpose it to create a different game concept using the same logic.

### Purpose

The goal of this prototype is to create a simple basketball-style game. The player must throw as many balls into the box as possible within a limited time. 

## Controls

Use the mouse to grab and throw the ball. The faster you move the mouse while releasing the ball, the farther it will travel. Your throw strength depends on the velocity at the moment of release.

### Technologies used

- **Unity** – Version 6000.0.47f1
- **C#** – Used for gameplay scripting
  
### Challenges and Future Features

One of the main challenges I faced was understanding how to implement a grabbing mechanic for the ball, and then how to translate mouse movement into a realistic throwing force.

Initially, I tried tracking the position where the mouse started and ended the drag. However, this approach didn’t work well even slow mouse movements caused the ball to launch with too much force.

To solve this, I now calculate the vector distance continuously while the object is being dragged. When the mouse is released, I use that data to determine the final throw strength based on movement velocity.

## Installation

You can download pre-built releases for your supported operating system from the GitHub Releases page. Available builds include:
- MacOS
- Windows
- Linux

## Run

To run the program, simply double-click the executable file for your operating system.

### MacOS

Unzip and open the .app file.

### Windows

Unzip and double-click the .exe file.

### Linux

```bash
chmod +x Prototype_8_Linux.x86_64
./Prototype_8_Linux.x86_64
```

### Web

Play on [browser](https://vpekdas.github.io/unity-junior-counting-prototype-8)

## Credits

This project is based on the Unity **Junior Programmer Pathway** by Unity Learn.
Many thanks to the instructors for their excellent step-by-step video tutorials and guidance.

## Contributing

To report issues, please create an issue here:  [issue tracker](https://github.com/Vpekdas/unity-junior-counting-prototype-8/issues).

If you'd like to contribute, please follow the steps outlined in [CONTRIBUTING.md](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE).
