# Fuzzy Ninject Warrior

Fuzzy Ninject Warrior is a web-based adventure game built using the ASP.NET MVC architecture. The project demonstrates a clean dependency injection solution using [Ninject](https://github.com/ninject/ninject) and utilizes SQLite as a lightweight, free database for data storage.

---

## 🚀 Project Purpose

This project is designed as an educational resource to **demonstrate how to implement Ninject-based dependency injection in an MVC application**. It features best practices of code organization, separation of concerns, and extensibility in a real-world game scenario.

---

## 🗂️ Project Structure

```
NinjectWarriorAdventure/
│
├── App_Start/
│   └── NinjectWebCommon.cs       # Ninject DI setup
│
├── Controllers/
│   └── AdventureController.cs    # Game logic controller
│
├── Models/
│   ├── Player.cs
│   ├── Enemy.cs
│   ├── Weapon.cs
│   └── GameEvent.cs
│
├── Services/
│   ├── IAdventureService.cs
│   └── AdventureService.cs
│
├── Repositories/
│   ├── IPlayerRepository.cs
│   ├── PlayerRepository.cs
│   ├── IEnemyRepository.cs
│   └── EnemyRepository.cs
│
├── APIs/
│   ├── IGameLogger.cs
│   └── ApiGameLogger.cs
│
├── Views/
│   └── Adventure/
│       ├── Index.cshtml
│       └── Attack.cshtml
│
├── Content/                     # CSS, images, etc.
│
├── Scripts/                     # JavaScript files
│
├── App_Data/
│   └── NinjectWarriorAdventure.sqlite  # SQLite DB file
│
├── Web.config
└── README.md
```

---

## ⚙️ Setup Instructions

### Prerequisites

- [.NET Framework 4.7.2 or later](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
- [Visual Studio 2019/2022](https://visualstudio.microsoft.com/)
- [Ninject.MVC5 NuGet package](https://www.nuget.org/packages/Ninject.MVC5/)
- [System.Data.SQLite NuGet package](https://www.nuget.org/packages/System.Data.SQLite/)

### Getting Started

1. **Clone the Repository**
   ```sh
   git clone https://github.com/YOUR_USERNAME/NinjectWarriorAdventure.git
   cd NinjectWarriorAdventure
   ```

2. **Open the Solution**
   - Open `NinjectWarriorAdventure.sln` in Visual Studio.

3. **Restore NuGet Packages**
   - Right-click on the solution and select **Restore NuGet Packages**.

4. **Database Setup**
   - The project uses SQLite. The database file is located at `App_Data/NinjectWarriorAdventure.sqlite`.
   - On first run, the app will create and seed the database if it doesn't exist.
   - No manual setup is required.

5. **Run the Application**
   - Press `F5` or click **Start** in Visual Studio.
   - The game will open in your browser at `http://localhost:xxxx/Adventure/Index`.

---

## 🕹️ How to Play

- **Start**: Visit the main game page.
- **Attack**: Choose an enemy and attack using your equipped weapon.
- **Progress**: Defeat enemies to gain experience and develop your character.

---

## 🗃️ Database Details

- **SQLite** is used for simplicity and portability.
- All data files are in the `App_Data` directory.
- If you want to reset the game data, simply delete the `.sqlite` file (it will be recreated at startup).

---

## ✨ Key Features

- **Ninject-based Dependency Injection:** All controllers, services, repositories, and API clients are injected using Ninject, promoting loose coupling and testability.
- **Gameplay Mechanics:** Classic turn-based combat system; player and enemy stats; weapon selection.
- **Character Development:** Players gain experience and level up by defeating enemies.
- **User Interface:** Simple, responsive web UI with clear feedback and action prompts.
- **External API Integration:** Game events (like attacks and victories) are logged via a simulated API client.
- **Extensible Architecture:** Easily add new features, weapons, enemies, or services due to the modular MVC and DI structure.

---

## 📝 Code Quality

- The project is organized by MVC best practices.
- Each class and method is commented for clarity.
- Interfaces abstract all business logic, data access, and external communications.

---

## 📣 Contributing

Pull requests, bug reports, and feature suggestions are welcome! Keep in mind that this project is started as a learning experience.

---

## 📜 License

MIT License

---

## 🏷️ Tags

`ASP.NET MVC` `Ninject` `Dependency Injection` `Game` `Sample Project` `SQLite`
