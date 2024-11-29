using System;
using System.Collections.Generic;

// smartdevice base class for each device
public abstract class SmartDevice
{
    // generic device information
    public int DeviceID { get; set; }
    public string Status { get; set; }
    public string Name { get; set; }
    public DateTime LastUpdate { get; set; }

    // updates for all devices
    public virtual void StatusUpdate()
    {
        Console.WriteLine($"Status of {Name} updated.");
    }

    // get status of a given device
    public string GetStatus()
    {
        return Status;
    }

    public abstract void NotifyObserver();
}

// light as a derived class of smartdevice established with its given features
// brightness and colour as settings and methods that can be configured by the user
// option to notify observer if subscribed to notifications
public class Light : SmartDevice
{
    public int Brightness { get; set; }
    public string Colour { get; set; }

    public void SetBrightness(int brightness)
    {
        Brightness = brightness;
        Console.WriteLine($"Brightness set to {Brightness}");
    }

    public void ChangeColour(string colour)
    {
        Colour = colour;
        Console.WriteLine($"Colour changed to {Colour}");
    }

    public override void NotifyObserver()
    {
        Console.WriteLine($"Light {Name} notified observers.");
    }
}

// securitycamera as a derived class of smartdevice established with its given features
// resolution can be set by the user
// isrecording is configured by the startrecording() and stoprecording() methods
// option to receive camera feed and gallery
// notify the observer if subscribed to notifications
public class SecurityCamera : SmartDevice
{
    public string Resolution { get; set; }
    public bool IsRecording { get; set; }
    public int Storage { get; set; }

    public void StartRecording()
    {
        IsRecording = true;
        Console.WriteLine("Recording started.");
    }

    public void StopRecording()
    {
        IsRecording = false;
        Console.WriteLine("Recording stopped.");
    }

    public string GetCamFeed()
    {
        return "Camera feed data...";
    }

    public override void NotifyObserver()
    {
        Console.WriteLine($"Security Camera {Name} notified observers.");
    }
}

// thermostat as a derived class of smartdevice established with its given features
// temperature, humidity, and mode as settings and methods that can be configured by the user
// option to notify observer if subscribed to notifications
public class Thermostat : SmartDevice
{
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public string Mode { get; set; }

    public void SetTemperature(float temp)
    {
        Temperature = temp;
        Console.WriteLine($"Temperature set to {Temperature}°C");
    }

    public void ChangeMode(string mode)
    {
        Mode = mode;
        Console.WriteLine($"Thermostat mode changed to {Mode}");
    }

    public override void NotifyObserver()
    {
        Console.WriteLine($"Thermostat {Name} notified observers.");
    }
}
