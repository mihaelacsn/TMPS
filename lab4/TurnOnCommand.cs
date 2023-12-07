public class TurnOnCommand : ICommand
{
    private IDevice device;

    public TurnOnCommand(IDevice device)
    {
        this.device = device;
    }

    public void Execute()
    {
        device.TurnOn();
    }
}
