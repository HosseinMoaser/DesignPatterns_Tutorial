using Factorry_Pattern.Core.Interfaces;

namespace Factorry_Pattern.Core.Classes;
public class ClientAPublishFactory : IPublishFactory
{
    public IChildren PublichIChildrenBook()
    {
        return new ClientAChildren();
    }

    public IFiction PublishFictionBook()
    {
        return new ClientAFiction();
    }

    public IHistory PublishHistoryBook()
    {
        return new ClientAHistory();
    }
}
