# Laboratory Work Nr.1 SOLID Principles
## Course: Tehnici si Mecanisme de Proiectare Software
## Author: Mihaela Cușnir
****
## Theory
SOLID is a set of five object-oriented design principles intended to make software designs more maintainable, flexible, and easy to understand. 
The acronym stands for Single Responsibility Principle, Open-Closed Principle, Liskov Substitution Principle, Interface Segregation Principle, and 
Dependency Inversion Principle. Each principle addresses a specific aspect of software design, such as the organization of responsibilities, 
the handling of dependencies, and the design of interfaces. By following these principles, software developers can create more modular, testable, 
and reusable code that is easier to modify and extend over time. These principles are widely accepted and adopted in the software development community 
and can be applied to any object-oriented programming language.
****
## Tasks
    1. Choose an OO programming language and a suitable IDE or Editor (No frameworks/libs/engines allowed).

    2. Select a domain area for the sample project.

    3. Define the main involved classes and think about what instantiation mechanisms are needed.

    4. Respect SOLID Principles in your project.

****
## Implementation
The main idea of my project is to make the simpliest To do List app using Python and SOLID principles, as much as possible.
* **Single Responsability Principle:**
I saw the best use of this principle in the classes:
  1. `Task()`, that has one job to do, representing the basic task;
  2. In the `TodoList()` class is responsible for managing tasks, not handling display logic.
* **Open_Closed Principle:**
  1. `TaskEditor()` - extends `Task` and implements the `AbstractTask()` interface.
  2. The `Task()` class is kept simple and can be extended for different task types. This was important for when I want to have different type of task, so I had to create an abstract base class for tasks and have specific task types inherit from it.
  3. This allowed me to extend the system without modifying existing code.
  4. 
* **Liskov Substitution Principle**
  1. `TaskEditor()` is a subtype of `Task` and can be used where `Task()` is expected.
  2. `AbstractTask()` defines a common interface for tasks.
* **Interface Segregation Principle**
  1. `TaskEditor()` implements only the methods it needs from the interface.
  2. The `AbstractTask()` class defines a common interface for tasks with methods display and `mark_complete`.

****
 
