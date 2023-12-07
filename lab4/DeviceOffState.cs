public class DeviceOffState : IDeviceState
{
    public void HandleTurnOn()
    {
        Console.WriteLine("Turning device on");
    }

    public void HandleTurnOff()
    {
        Console.WriteLine("Device is already off");
    }
}