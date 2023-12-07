public class BasicRemoteControl
{   
  private IDevice device;

    public BasicRemoteControl(IDevice device)
    {
        this.device = device;
    }

    public void TurnOn()
    {
        Console.WriteLine("Basic Remote: Turning the device on");
        device.TurnOn();
    }

    public void TurnOff()
    {
        Console.WriteLine("Basic Remote: Turning the device off");
        device.TurnOff();
    }
}