public class RemoteControlDisplay : IDeviceObserver
{
    public void UpdateState(string state)
    {
        Console.WriteLine($"Remote Control Display: {state}");
    }
}