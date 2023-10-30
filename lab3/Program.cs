class Program
{
    static void Main(string[] args)
    {
        IDevice tv = new TV();
        IDevice radio = new Radio();
        IDevice light = new Light();

        RemoteControl basicRemote = new BasicRemoteControl(tv);
        basicRemote.TurnOn();
        basicRemote.TurnOff();

        DeviceControlFacade facade = new DeviceControlFacade();
        facade.TurnOnAllDevices();
        facade.TurnOffAllDevices();

        DeviceControlProxy proxy = new DeviceControlProxy(isAdmin: false);
        proxy.TurnOnAllDevices();
        proxy.TurnOffAllDevices();
    }

}