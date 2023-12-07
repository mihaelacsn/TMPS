public class RemoteControl
{
    private ICommand turnOnCommand;
    private ICommand turnOffCommand;

    public RemoteControl(ICommand turnOnCommand, ICommand turnOffCommand)
    {
        this.turnOnCommand = turnOnCommand;
        this.turnOffCommand = turnOffCommand;
    }

    public void TurnOn()
    {
        Console.WriteLine("Remote Control: Pressing Turn On button");
        turnOnCommand.Execute();
    }

    public void TurnOff()
    {
        Console.WriteLine("Remote Control: Pressing Turn Off button");
        turnOffCommand.Execute();
    }
}