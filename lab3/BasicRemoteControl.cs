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