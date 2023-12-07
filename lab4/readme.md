# Laboratory Work Nr.4 Behavioral Design Patterns
## Course: Tehnici si Mecanisme de Proiectare Software
## Author: Mihaela Cușnir
****
## Theory
### State  design pattern
State is a behavioral design pattern that lets an object alter its behavior when its internal state changes. It appears as if the object changed its class. The State pattern suggests that you create new classes for all possible states of an object and extract all state-specific behaviors into these classes.
Instead of implementing all behaviors on its own, the original object, called context, stores a reference to one of the state objects that represents its current state, and delegates all the state-related work to that object.To transition the context into another state, replace the active state object with another object that represents that new state. This is possible only if all state classes follow the same interface and the context itself works with these objects through that interface.

### Command design pattern
Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations. The Command pattern suggests that GUI objects shouldn’t send these requests directly. Instead, you should extract all of the request details, such as the object being called, the name of the method and the list of arguments into a separate command class with a single method that triggers this request.

Command objects serve as links between various GUI and business logic objects. From now on, the GUI object doesn’t need to know what business logic object will receive the request and how it’ll be processed. The GUI object just triggers the command, which handles all the details.
### Observer design pattern
Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing. The Observer pattern suggests that you add a subscription mechanism to the publisher class so individual objects can subscribe to or unsubscribe from a stream of events coming from that publisher. In reality, this mechanism consists of 1) an array field for storing a list of references to subscriber objects and 2) several public methods which allow adding subscribers to and removing them from that list.

## Implementation




****
## Conclusion
In conclusion, the Observer, State, and Command design patterns are valuable tools in the software developer's toolbox, offering solutions to common challenges related to object communication, state management, and command execution. When applied judiciously, these patterns contribute to code that is modular, flexible, and easy to maintain, supporting the principles of object-oriented design. As with any design pattern, it's important to consider the specific requirements of the application and choose the pattern that best fits the problem at hand.
