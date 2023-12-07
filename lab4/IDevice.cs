public interface IDevice
{
    void TurnOn();
    void TurnOff();
    void RegisterObserver(IDeviceObserver observer);
    void UnregisterObserver(IDeviceObserver observer);
}