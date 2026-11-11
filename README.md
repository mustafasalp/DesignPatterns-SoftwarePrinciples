# 🏛️ DesignPatterns-SoftwarePrinciples

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-13.0-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Status](https://img.shields.io/badge/Status-Active%20Development-success)]()

A comprehensive, hands-on repository containing practical implementations, real-world examples, and architectural notes for **Software Design Patterns (GoF)** and **Software Design Principles (SOLID & Clean Code)** built with modern **C#** and **.NET 10**.

---

## 📑 Table of Contents

- [About The Project](#-about-the-project)
- [Design Patterns Catalog](#-design-patterns-catalog)
  - [Creational Patterns](#1-creational-patterns)
  - [Behavioral Patterns](#2-behavioral-patterns)
  - [Structural Patterns](#3-structural-patterns)
- [Software Engineering Principles](#-software-engineering-principles)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
- [Curated Learning Resources](#-curated-learning-resources)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 About The Project

Writing maintainable, scalable, and loosely-coupled code requires a solid understanding of proven architectural solutions and design principles. 

This repository serves as:
- A practical reference for **Gang of Four (GoF)** design patterns implemented with modern C# idioms.
- A demonstration of how design patterns directly apply and reinforce **SOLID** principles.
- Real-world inspired scenarios (such as order processing pipelines, dynamic payment gateways, and stateful lifecycle transitions) rather than purely abstract theory.

---

## 🧩 Design Patterns Catalog

### 1. Creational Patterns
Creational patterns focus on class instantiation and object creation mechanisms, abstracting the instantiation process and increasing flexibility.

| Pattern | Project | Description & Implementation Details |
| :--- | :--- | :--- |
| **Singleton** | [`Singleton`](./Singleton) | Ensures a class has only one instance while providing a global access point. Demonstrates multiple thread-safety evolution strategies: <ul><li>`NonThreadSafeSingleton`: Basic single-threaded variant</li><li>`SimpleThreadSafelyViaLockingh`: Safe via standard locking</li><li>`DoubleCheckThreadSafe`: High-performance double-checked locking</li><li>`EagerSingleton`: CLR-driven thread-safe static initialization</li><li>`LazyTypeSingleton`: Idiomatic modern C# using `Lazy<T>`</li></ul> |

---

### 2. Behavioral Patterns
Behavioral patterns identify common communication patterns between objects and realize these patterns, increasing flexibility in carrying out communication.

| Pattern | Project | Description & Implementation Details |
| :--- | :--- | :--- |
| **Chain of Responsibility** | [`ChainOfResponsibility`](./ChainOfResponsibility) | Passes a request along a chain of handlers. Implemented as an **E-Commerce Order Validation Pipeline**: <ul><li>`StockHandler`: Validates warehouse product inventory</li><li>`PaymentHandler`: Verifies customer payment completion</li><li>`FraudHandler`: Assesses risk and fraud indicators</li><li>`ShippingHandler`: Ensures customer address and delivery validity</li></ul> |
| **State** | [`State`](./State) <br> [`StateSakizMachine`](./StateSakizMachine) | Allows an object to alter its behavior when its internal state changes. Demonstrates: <ul><li>**Order Lifecycle (`State`)**: Transitions seamlessly through `NewOrderState` ➔ `ProcessingState` ➔ `ShippedState` ➔ `DeliveredState`.</li><li>**Gumball Machine (`StateSakizMachine`)**: Classic finite state machine implementation managing `NoCoinState`, `HasCoinState`, and `SoldState`.</li></ul> |
| **Strategy** | [`Strategy`](./Strategy) | Defines a family of interchangeable algorithms and encapsulates each one. Implemented as a **Multi-Bank Payment Gateway**: <ul><li>Dynamically switches payment providers at runtime (`GarantiBankPaymentService`, `AkbankPaymentService`, `IsBankPaymentService`) without modifying client code.</li></ul> |

---

### 3. Structural Patterns
Structural patterns explain how to assemble objects and classes into larger structures while keeping these structures flexible and efficient.

| Pattern | Status | Description |
| :--- | :---: | :--- |
| **Adapter** | 📋 Planned | Allows objects with incompatible interfaces to collaborate. |
| **Decorator** | 📋 Planned | Attaches new behaviors to objects dynamically by placing them inside wrapper objects. |
| **Facade** | 📋 Planned | Provides a simplified interface to a library, a framework, or any other complex set of classes. |
| **Proxy** | 📋 Planned | Provides a surrogate or placeholder for another object to control access to it. |

*Legend: ✅ Completed | 🚧 In Progress | 📋 Planned*

---

## 📐 Software Engineering Principles

Good design pattern usage stems from foundational design principles. This repository embraces and illustrates:

### SOLID Principles
- **S - Single Responsibility Principle (SRP):** Every class or module should have one, and only one, reason to change.
- **O - Open/Closed Principle (OCP):** Software entities should be open for extension, but closed for modification (evident in the Strategy and Chain of Responsibility patterns).
- **L - Liskov Substitution Principle (LSP):** Subtypes must be substitutable for their base types without altering program correctness.
- **I - Interface Segregation Principle (ISP):** Clients should not be forced to depend upon interfaces that they do not use.
- **D - Dependency Inversion Principle (DIP):** High-level modules should depend on abstractions, not concrete implementations.

### General Design Guidelines
- **DRY (Don't Repeat Yourself):** Avoid duplicate domain logic.
- **KISS (Keep It Simple, Stupid):** Avoid premature over-engineering; patterns should simplify solutions, not complicate them.
- **Favor Composition Over Inheritance:** Build flexible architectures by delegating behavior to interchangeable components.

---

## 📂 Project Structure

```text
DesignPatterns-SoftwarePrinciples/
├── .slnx / DesignPatterns.slnx      # Solution file (.NET 10 SLNX format)
├── ChainOfResponsibility/           # Chain of Responsibility pattern
│   ├── AbstractClass/               # BaseOrderHandler base class
│   ├── ConcreteClasses/             # Fraud, Payment, Shipping, Stock handlers
│   ├── Interfaces/                  # IHandler interface
│   └── Model/                       # Order entity
├── Singleton/                       # Singleton pattern implementations
│   ├── DoubleCheckThreadSafe.cs     # Double-checked locking
│   ├── EagerSingleton.cs            # Static eager initialization
│   ├── LazyTypeSingleton.cs         # System.Lazy<T> implementation
│   ├── NonThreadSafeSingleton.cs    # Naive implementation
│   └── SimpleThreadSafelyViaLockingh.cs # Mutex/lock thread safety
├── State/                           # Order lifecycle state pattern
│   ├── States/                      # NewOrder, Processing, Shipped, Delivered
│   ├── IOrderState.cs               # State interface
│   └── Order.cs                     # Context class
├── StateSakizMachine/               # Gumball machine state pattern
│   ├── States/                      # NoCoin, HasCoin, Sold states
│   ├── IState.cs                    # State interface
│   └── SakizMakinesi.cs             # Machine context class
├── Strategy/                        # Payment strategy pattern
│   ├── Context/                     # PaymentService context
│   ├── Interface/                   # IPaymentService strategy contract
│   └── Strategies/                  # Akbank, Garanti, IsBank implementations
└── README.md                        # Documentation
```

---

## 🚀 Getting Started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download) (or later)
- An IDE of choice: [Visual Studio 2022 / 2025](https://visualstudio.microsoft.com/), [JetBrains Rider](https://www.jetbrains.com/rider/), or [Visual Studio Code](https://code.visualstudio.com/) with C# Dev Kit.

### Installation & Execution

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-username/DesignPatterns-SoftwarePrinciples.git
   cd DesignPatterns-SoftwarePrinciples
   ```

2. **Restore dependencies & build the solution:**
   ```bash
   dotnet build
   ```

3. **Run a specific pattern project:**
   ```bash
   # Run Chain of Responsibility
   dotnet run --project ./ChainOfResponsibility

   # Run Strategy Pattern
   dotnet run --project ./Strategy

   # Run Singleton Pattern
   dotnet run --project ./Singleton
   ```

---

## 📚 Curated Learning Resources

To dive deeper into design patterns, architectural styles, and software craftsmanship, check out the following references:

- 🌐 **[Refactoring.Guru](https://refactoring.guru/)**  
  An outstanding and visually rich resource breaking down Design Patterns, Refactoring techniques, and Code Smells with crystal-clear explanations, diagrams, and code snippets across multiple languages.

- 🎥 **[Design Patterns Video Series by Salih Cantekin (YouTube Playlist)](https://www.youtube.com/watch?v=Spq_ClIy-AM&list=PLRp4oRsit1bzcZhzv-xvHGn1SS0wwLIvR)**  
  A comprehensive, tutorial-driven video playlist explaining Design Patterns in depth with practical C# demonstrations and clean code paradigms.

- 📖 **"Design Patterns: Elements of Reusable Object-Oriented Software"** *(Gang of Four)*  
  The seminal literature that established classic software design patterns.

- 📖 **"Clean Architecture: A Craftsman's Guide to Software Structure and Design"** *(Robert C. Martin)*  
  A must-read guide on structuring software for longevity, testability, and clarity.

---

## 🤝 Contributing

Contributions, issues, and pattern additions are very welcome! If you'd like to contribute:
1. Fork the Project.
2. Create your Feature Branch (`git checkout -b feature/NewDesignPattern`).
3. Commit your Changes (`git commit -m 'Add Factory Method pattern'`).
4. Push to the Branch (`git push origin feature/NewDesignPattern`).
5. Open a Pull Request.

---

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.
