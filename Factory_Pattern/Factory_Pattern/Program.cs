using Factorry_Pattern.Core;
using Factorry_Pattern.Core.Classes;
using Factorry_Pattern.Core.Interfaces;

namespace Factory_Pattern;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which Client?");
        var client = Console.ReadLine();

        IPublishFactory _factory;

        if (client == "a")
            _factory = new ClientAPublishFactory();
        else if (client == "b")
            _factory = new ClientBPublishFactory();
        else
            return;

        Console.WriteLine("How many history books?");
        var historyBooks = Console.ReadLine();

        Console.WriteLine("How many fiction books?");
        var fictionBooks = Console.ReadLine();

        Console.WriteLine("How many Children books?");
        var childrenBooks = Console.ReadLine();

        var order = new Order
        {
            FictionBooks = fictionBooks.ConvertToInt32(),
            HistoryBooks = historyBooks.ConvertToInt32(),
            ChildrenBooks = childrenBooks.ConvertToInt32(),
        };

        var publisher = new Publisher(_factory);

        publisher.Publish(order);

        Console.WriteLine($"Published {publisher.HistoryBooks.Count()} History Books");
        Console.WriteLine($"Published {publisher.FictionBooks.Count()} Fiction Books");
        Console.WriteLine($"Published {publisher.ChildrenBooks.Count()} Children Books");
    }
}
