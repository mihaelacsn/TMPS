public class DeviceControlFacade
{
    private IDevice tv;
    private IDevice radio;
    private IDevice light;

    public DeviceControlFacade()
    {
        tv = new TV();
        radio = new Radio();
        light = new Light();
    }

    public void TurnOnAllDevices()
    {
        tv.TurnOn();
        radio.TurnOn();
        light.TurnOn();
    }

    public void TurnOffAllDevices()
    {
        tv.TurnOff();
        radio.TurnOff();
        light.TurnOff();
    }
}