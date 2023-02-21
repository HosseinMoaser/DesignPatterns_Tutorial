namespace Observer_Pattern.Domain;

// Concrete Observer
public class UserService : IUser
{
    public void SendOrder(ISignal signal)
    {
        // 1. Create User Client using API-Keys
        // 2. Send Order based on input signal
        Console.WriteLine($"The Order For {signal.Symbol} Is Sent At Price Of {signal.EnterPrice}");

    }
}
