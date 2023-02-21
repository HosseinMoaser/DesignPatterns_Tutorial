using Observer_Pattern.Domain;

namespace ObserverPattern.Domain;

public class User : IUser
{
    public void SendOrder(ISignal signal)
    {
        // 1. Create exchange client using API-Keys
        // 2. Send Order
        Console.WriteLine($"Order sent for {signal.Symbol} at the price of {signal.EnterPrice}");
    }
}
