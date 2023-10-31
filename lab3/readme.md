# Laboratory Work Nr.3 Structural Design Patterns
## Course: Tehnici si Mecanisme de Proiectare Software
## Author: Mihaela Cușnir
****
## Theory
Structural design patterns explain how to assemble objects and classes into larger structures, while keeping these structures flexible and efficient. These patterns focus on, how the classes inherit from each other and how they are composed from other classes. 
<br>
There are following 7 types of structural design patterns:
</br>
  1. Adapter Pattern -> Adapting an interface into another according to client expectation.
  2. Bridge Pattern -> Separating abstraction (interface) from implementation.
  3. Composite Pattern -> Allowing clients to operate on hierarchy of objects.
  4. Decorator Pattern -> Adding functionality to an object dynamically.
  5. Facade Pattern -> Providing an interface to a set of interfaces.
  6. Flyweight Pattern -> Reusing an object by sharing it.
  7. Proxy Pattern -> Representing another object.
<br>
These design patterns are about organizing different classes and objects to form larger structures and provide new functionality.

## Implementation
The Structural Patterns I used was the Bridge Pattern, Facade Pattern and the Proxy Pattern.
### Facade Pattern
In the `DeviceControlFacade` class is an example of a design pattern called the facade pattern. It provides a simplified interface to a set of interfaces in a subsystem, making it easier to use. It has the goal to simplify the process of turning on and off various devices (TV, radio, light) by providing two methods: TurnOnAllDevices and TurnOffAllDevices. I have an Interfaces (`IDevice`), that allows to treat these devices uniformly through a common interface. Facade Class (`DeviceControlFacade`) acts as a facade, providing a simplified interface for controlling multiple devices at once. The constructor initializes instances of the concrete device classes (TV, radio, light). Last, but not least, the methods call the respective `TurnOn()` and `TurnOff()` methods on each device. This encapsulates the complexity of interacting with individual devices.

```
public class DeviceControlFacade
{
    private IDevice tv;
    private IDevice radio;
    private IDevice light;

    public DeviceControlFacade()
    {
        tv = new TV();
        radio = new Radio();
        light = new Light();
    }

    public void TurnOnAllDevices()
    {
        tv.TurnOn();
        radio.TurnOn();
        light.TurnOn();
    }

    public void TurnOffAllDevices()
    {
        tv.TurnOff();
        radio.TurnOff();
        light.TurnOff();
    }
}
```
### Proxy Pattern
The `DeviceControlProxy` class is implementing the Proxy pattern, which allows to control access to the `DeviceControlFacade` class based on certain conditions. Here it checks if the user has administrative privileges before allowing them to turn on or off all devices.
  1. Inheritance: `DeviceControlProxy` -> inherits from `DeviceControlFacade`. This means that `DeviceControlProxy` has the same methods as `DeviceControlFacade` and can override or extend their behavior.
  2. Additional State: DeviceControlProxy introduces a new boolean variable `isAdmin` to determine whether the user has administrative privileges or not.
  3.Overriding Methods (`TurnOnAllDevices`, `TurnOffAllDevices`): These methods override the corresponding methods in the base class (`DeviceControlFacade`). They first check if the user is an admin. If yes, it calls the corresponding method in the base class. If not, it prints a message indicating that the user is not authorized.
```
public class DeviceControlProxy : DeviceControlFacade
{
    private bool isAdmin = false;

    public DeviceControlProxy(bool isAdmin)
    {
        this.isAdmin = isAdmin;
    }

    public void TurnOnAllDevices()
    {
        if (isAdmin)
        {
            base.TurnOnAllDevices();
        }
        else
        {
            Console.WriteLine("You are not authorized to perform this action.");
        }
    }

    public void TurnOffAllDevices()
    {
        if (isAdmin)
        {
            base.TurnOffAllDevices();
        }
        else
        {
            Console.WriteLine("You are not authorized to perform this action.");
        }
    }
}
```
### Bridge Pattern
The Bridge Pattern is a structural design pattern that separates abstraction from implementation so that the two can vary independently. In the code I have: abstraction (`RemoteControl`), implementor (`IDevice`) and the `BasicRemoteControl` is a refined abstraction that extends the abstraction (`RemoteControl`) and delegates its operations to the implementor (`IDevice`). By having `BasicRemoteControl` extend `RemoteControl` and take an `IDevice` in its constructor, the Bridge Pattern allows different implementations of `IDevice` to be used interchangeably with different `RemoteControl` objects. 

```
public class BasicRemoteControl : RemoteControl
{
    public BasicRemoteControl(IDevice device) : base(device) { }

    public override void TurnOn()
    {
        Console.WriteLine("Basic Remote: Turning the device on");
        device.TurnOn();
    }

    public override void TurnOff()
    {
        Console.WriteLine("Basic Remote: Turning the device off");
        device.TurnOff();
    }
}

```

****
## Conclusion
For ***Facade***: It simplifies the client code by providing a high-level interface to interact with the devices, rather than dealing with the details of each device individually. It promotes encapsulation and reduces dependencies between the client code and the subsystem of devices.
<br>
For ***Proxy***: This pattern is useful when adding an additional layer of control or behavior to an existing class without modifying its code directly. In this case, the proxy ensures that only users with administrative privileges can control the devices.
<br>
For ***Bridge***:  This pattern is useful for avoiding a permanent binding between an abstraction and its implementation, allowing them to vary independently. This separation also makes it easier to add new abstractions or implementations without modifying the existing code.
