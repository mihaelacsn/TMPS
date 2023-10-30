public class DeviceControlProxy : DeviceControlFacade
{
    private bool isAdmin = false;

    public DeviceControlProxy(bool isAdmin)
    {
        this.isAdmin = isAdmin;
    }

    public void TurnOnAllDevices()
    {
        if (isAdmin)
        {
            base.TurnOnAllDevices();
        }
        else
        {
            Console.WriteLine("You are not authorized to perform this action.");
        }
    }

    public void TurnOffAllDevices()
    {
        if (isAdmin)
        {
            base.TurnOffAllDevices();
        }
        else
        {
            Console.WriteLine("You are not authorized to perform this action.");
        }
    }
}