namespace Factorry_Pattern.Core.Interfaces;

public interface IPublishFactory
{
    IFiction PublishFictionBook();
    IHistory PublishHistoryBook();
    IChildren PublichIChildrenBook();
}
