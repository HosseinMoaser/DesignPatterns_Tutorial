using Observer_Pattern.Domain;
using ObserverPattern.Domain;

namespace Observer_Pattern;

public class Program
{
    static void Main(string[] args)
    {
        SignalServices _signalServices = new SignalServices(16330);

        var firstUser = new User();
        var secondUser = new User();

        _signalServices.AddSubscriber(firstUser);
        _signalServices.AddSubscriber(secondUser);

        _signalServices.EnterPrice = 16335;

        Console.Read();
    }
}