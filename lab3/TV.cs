public class TV : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("TV is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV is off");
    }
}