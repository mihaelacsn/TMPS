public class TV : IDevice
{
    private List<IDeviceObserver> observers = new List<IDeviceObserver>();
    private IDeviceState currentState;

    public TV()
    {
        currentState = new DeviceOffState();
    }

    public void TurnOn()
    {
        currentState.HandleTurnOn();
        NotifyObservers($"TV is on");
        currentState = new DeviceOnState();
    }

    public void TurnOff()
    {
        currentState.HandleTurnOff();
        NotifyObservers($"TV is off");
        currentState = new DeviceOffState();
    }

    public void RegisterObserver(IDeviceObserver observer)
    {
        observers.Add(observer);
    }

    public void UnregisterObserver(IDeviceObserver observer)
    {
        observers.Remove(observer);
    }

    private void NotifyObservers(string state)
    {
        foreach (var observer in observers)
        {
            observer.UpdateState(state);
        }
    }
}