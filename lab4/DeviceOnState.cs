public class DeviceOnState : IDeviceState
{
    public void HandleTurnOn()
    {
        Console.WriteLine("Device is already on");
    }

    public void HandleTurnOff()
    {
        Console.WriteLine("Turning device off");
    }
}
