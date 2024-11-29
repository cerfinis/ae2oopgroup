// user class
public class User
{

    // initialising generic user informaiton here - currently info in the UML
    public int UserID { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public List<string> Preferences { get; set; }


    // initialise user
    public User()
    {

        // additional user preferences can be added this is moreso just a basis
        Preferences = new List<string>();
    }


    // confirms if notification is received
    public void ReceiveNotification(string message)
    {
        Console.WriteLine($"{Name} received notification: {message}");
    }


    // updates any preferences by users for their smart devices
    public void UpdatePreference(string preference)
    {
        Preferences.Add(preference);
        Console.WriteLine($"Preference '{preference}' added for {Name}");
    }
}
