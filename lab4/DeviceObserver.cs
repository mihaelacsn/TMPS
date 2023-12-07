public class DeviceObserver : IDeviceObserver
{
    public void UpdateState(string state)
    {
        Console.WriteLine($"Observer: {state}");
    }
}