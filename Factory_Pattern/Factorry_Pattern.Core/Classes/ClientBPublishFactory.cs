using Factorry_Pattern.Core.Interfaces;

namespace Factorry_Pattern.Core.Classes;

public class ClientBPublishFactory : IPublishFactory
{
    public IChildren PublichIChildrenBook()
    {
        return new ClientBChildren();
    }

    public IFiction PublishFictionBook()
    {
        return new ClientBFiction();
    }

    public IHistory PublishHistoryBook()
    {
        return new ClientBHistory();
    }
}
