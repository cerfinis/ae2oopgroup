class Program
{
    static void Main(string[] args)
    {
        // CentralSystem - this is our Singleton
        CentralSystem centralSystem = CentralSystem.GetInstance();

        // list of devices
        Light light = new Light { DeviceID = 1, Name = "Living Room Light", Brightness = 75, Colour = "White" };
        SecurityCamera camera = new SecurityCamera { DeviceID = 2, Name = "Front Door Camera", Resolution = "4K", IsRecording = false };
        Thermostat thermostat = new Thermostat { DeviceID = 3, Name = "Home Thermostat", Temperature = 22.5f, Humidity = 50 };

        // adding these devices to the central system
        centralSystem.AddDevice(light);
        centralSystem.AddDevice(camera);
        centralSystem.AddDevice(thermostat);

        // listing all devices
        centralSystem.ListDevices();

        // creating the notification manager
        NotificationManager notificationManager = new NotificationManager();

        // users
        User user1 = new User { UserID = 1, Name = "aldjaslkdj", ContactInfo = "laskdjlskaj@gmail.com" };
        User user2 = new User { UserID = 2, Name = "BOB", ContactInfo = "bob@gmail.com" };

        // adding these users to notification manager
        notificationManager.AddObserver(user1);
        notificationManager.AddObserver(user2);

        // event experimentation here - mainly just for testing purposes
        light.SetBrightness(80);
        notificationManager.NotifyUsers("Brightness of Living Room Light updated.");

        thermostat.SetTemperature(20);
        notificationManager.NotifyUsers("Temperature set to 20°C in Home Thermostat.");
    }
}
