# Circus Train Challenge

## Overview

The Circus Train Challenge is a C# application developed as an introductory software engineering assignment focused on object-oriented programming and SOLID design principles.

The goal of the challenge was to simulate the process of placing circus animals into train wagons while respecting a set of predefined safety and compatibility rules.

Although relatively small in scope, the project focused heavily on clean code structure, logical problem solving, and applying software engineering fundamentals.

---

# Project Goal

The application receives a collection of circus animals with different:

- Sizes
- Diet types (Carnivore / Herbivore)

The system must then determine the optimal distribution of animals across train wagons while following specific rules:

- Carnivores cannot eat other animals inside the same wagon
- Large carnivores create stricter placement constraints
- Wagon capacity is limited
- Animals should be distributed as efficiently as possible

The challenge focuses on building a logical placement algorithm using object-oriented design.

---

# Features

- Animal classification system
- Wagon capacity management
- Placement validation logic
- Carnivore/herbivore compatibility checks
- Train composition generation
- Object-oriented domain structure

---

# Technologies Used

- C#
- .NET
- Object-Oriented Programming (OOP)

---

# Software Engineering Focus

This project was mainly focused on learning and applying:

- SOLID principles
- Object-oriented design
- Separation of responsibilities
- Domain modeling
- Algorithmic problem solving
- Clean code structure

---

# Architecture

The project was structured around multiple domain entities such as:

- Animal
- Wagon
- Train

The placement logic was separated into dedicated classes to improve maintainability and readability.

---

# Challenge Logic

Examples of placement constraints:

- Carnivores cannot share wagons with smaller animals
- Wagon capacity cannot exceed the allowed limit
- Herbivores can only be placed safely with compatible animals

The system evaluates these conditions dynamically while building the train configuration.

---

# Learning Outcomes

This assignment helped improve skills in:

- Applying SOLID principles
- Building object-oriented systems
- Designing reusable classes
- Logical reasoning and validation
- Structuring small software projects cleanly

---

# Repository Structure

```text
src/
├── Animals/
├── Wagons/
├── Train/
├── Logic/
└── Program.cs
```

---
# Documentation

Additional documentation can be found in the `/Docs` folder, including:

- Requirements
- Use cases
- Flow diagrams
- Class diagrams
- Implementation explanation

  
---
# Notes

This project was developed as an academic software engineering challenge and served primarily as an introduction to structured software design and clean architecture principles.

---

# Author

Ayoub Lafhailat  
HBO-ICT Software Engineering Student  
Specialization: AI, Data & Machine Learning
