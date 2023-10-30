public abstract class RemoteControl
{
    protected IDevice device;

    public RemoteControl(IDevice device)
    {
        this.device = device;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
}