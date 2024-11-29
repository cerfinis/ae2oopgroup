// central system class - this class is the singleton
public sealed class CentralSystem
{

    // create centralsystem as an instance
    private static CentralSystem _instance;
    private static readonly object Lock = new object();
    public List<SmartDevice> Devices { get; private set; }


    // contain all devices within the central system
    private CentralSystem()
    {
        Devices = new List<SmartDevice>();
    }

    // now get instance
    public static CentralSystem GetInstance()
    {
        lock (Lock)
        {
            if (_instance == null)
            {
                _instance = new CentralSystem();
            }
        }
        return _instance;
    }

    
    // method to add a new device
    public void AddDevice(SmartDevice device)
    {
        Devices.Add(device);
        Console.WriteLine($"{device.Name} added to the system.");
    }

    // method to remove an existing device
    public void RemoveDevice(SmartDevice device)
    {
        Devices.Remove(device);
        Console.WriteLine($"{device.Name} removed from the system.");
    }

    // method to list new devices
    public void ListDevices()
    {
        Console.WriteLine("Devices in the system:");
        foreach (var device in Devices)
        {
            Console.WriteLine($"- {device.Name}");
        }
    }
}
