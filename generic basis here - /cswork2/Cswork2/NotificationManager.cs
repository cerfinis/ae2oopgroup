// notification manager - this is our observer class
public class NotificationManager
{
    private List<User> Observers = new List<User>();
    private List<string> Events = new List<string>();

    // add a new observer - new notification subscriber
    public void AddObserver(User user)
    {
        Observers.Add(user);
        Console.WriteLine($"User {user.Name} subscribed to notifications.");
    }

    // remove existing subscriber
    public void RemoveObserver(User user)
    {
        Observers.Remove(user);
        Console.WriteLine($"User {user.Name} unsubscribed from notifications.");
    }

    // method to notify current subscribers
    public void NotifyUsers(string message)
    {
        Events.Add(message);
        foreach (var user in Observers)
        {
            user.ReceiveNotification(message);
        }
    }

    // view previous notifications
    public void GetEventHistory()
    {
        Console.WriteLine("Notification history:");
        foreach (var evt in Events)
        {
            Console.WriteLine($"- {evt}");
        }
    }
}
