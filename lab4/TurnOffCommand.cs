public class TurnOffCommand : ICommand
{
    private IDevice device;

    public TurnOffCommand(IDevice device)
    {
        this.device = device;
    }

    public void Execute()
    {
        device.TurnOff();
    }
}