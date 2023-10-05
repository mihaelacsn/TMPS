# Laboratory Work Nr.1 SOLID Principles
## Course: Tehnici si Mecanisme de Proiectare Software
## Author: Mihaela Cușnir
****
## Theory
  Creational design patterns are a category of design patterns that focus on the process of object creation. They provide a way to create objects in a flexible and controlled manner, 
  while decoupling the client code from the specifics of object creation. Creational design patterns address common problems encountered in object creation, such as how to create objects 
  with different initialization parameters, how to create objects based on certain conditions, or how to ensure that only a single instance of an object is created. There are several creational 
  design patterns that have their own strengths and weaknesses. Each of it is best suited for solving specific problems related to object creation. By using creational design patterns, 
  developers can improve the flexibility, maintainability, and scalability of their code.

   Some examples of this kind of design patterns are:

  *Singleton
  *Builder
  *Prototype
  *Object Pooling
  *Factory Method
  *Abstract Factory

****
## Tasks
    1. Choose an OO programming language and a suitable IDE or Editor (No frameworks/libs/engines allowed).

    2. Select a domain area for the sample project.

    3. Define the main involved classes and think about what instantiation mechanisms are needed.

    4. Based on the previous point, implement at least 2 creational design patterns in your project.

****
## Implementation
  * **Singleton pattern:**
This pattern involves a single class which is responsible to create an object while making sure that only single object gets created. 
This class provides a way to access its only object which can be accessed directly without need to instantiate the object of the class.
In the `TodoList class`, I've implemented a basic form of the **Singleton pattern**, using the `__new__` method. This ensures that there is only one instance of `TodoList` throughout the program.
The _instance attribute keeps track of whether an instance has been created, and the __new__ method creates the instance if it doesn't exist.
<br>

  * **Factory method:**
This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.
-The `SimpleTaskFactory` and `EditorTaskFactory` classes act as factories to create instances of different task types.
-The `TaskFactory` interface ensures a common way to create tasks. This is a simple form of the Factory Method pattern.
<br>

* **Abstract Factory pattern:**
Abstract Factory patterns work around a super-factory which creates other factories. This factory is also called as factory of factories.
This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
In Abstract Factory pattern an interface is responsible for creating a factory of related objects without explicitly specifying their classes. Each generated factory can give the objects as per the Factory pattern.
Similarly, the `AbstractTaskFactory` interface defines methods to create both regular tasks and task editors.
The `SimpleTaskFactory` implements this interface to create instances of related classes, adhering to the principles of the Abstract Factory pattern.
 
