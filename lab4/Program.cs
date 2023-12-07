class Program
{
    static void Main(string[] args)
    {
        // Create TV
        IDevice tv = new TV();

        // Create Command objects
        ICommand turnOnCommand = new TurnOnCommand(tv);
        ICommand turnOffCommand = new TurnOffCommand(tv);

        // Create Remote Control with Commands
        RemoteControl remoteControl = new RemoteControl(turnOnCommand, turnOffCommand);

        // Create Observer
        IDeviceObserver observer = new DeviceObserver();
        tv.RegisterObserver(observer);

        // Turn on and off using the Remote Control
        remoteControl.TurnOn();
        remoteControl.TurnOff();
    }
}