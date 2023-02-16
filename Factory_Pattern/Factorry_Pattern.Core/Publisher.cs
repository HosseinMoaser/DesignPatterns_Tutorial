using Factorry_Pattern.Core.Classes;
using Factorry_Pattern.Core.Interfaces;

namespace Factorry_Pattern.Core;

public class Publisher
{
    #region Properties
    private readonly IPublishFactory _factory;
    private readonly List<IHistory> _historyBooks;
    private readonly List<IFiction> _fictionBooks;
    private readonly List<IChildren> _childrenBooks;

    public IEnumerable<IHistory> HistoryBooks { get { return _historyBooks.ToArray(); } }
    public IEnumerable<IFiction> FictionBooks { get { return _fictionBooks.ToArray(); } }
    public IEnumerable<IChildren> ChildrenBooks { get { return _childrenBooks.ToArray(); } }
    #endregion

    #region Constructor
    public Publisher(IPublishFactory factory)
    {
        _factory = factory;
        _historyBooks = new List<IHistory>();
        _fictionBooks = new List<IFiction>();
        _childrenBooks = new List<IChildren>();
    }
    #endregion

    #region Methods
    public void Publish(Order order)
    {
        PublishChildrenBooks(order.ChildrenBooks);
        PublishFictionBooks(order.FictionBooks);
        PublishHistoryBooks(order.HistoryBooks);
    }

    private void PublishChildrenBooks(int count)
    {
        while (_childrenBooks.Count < count)
        {
            _childrenBooks.Add(_factory.PublichIChildrenBook());
        }
    }

    private void PublishHistoryBooks(int count)
    {
        while (_historyBooks.Count < count)
        {
            _historyBooks.Add(_factory.PublishHistoryBook());
        }
    }

    private void PublishFictionBooks(int count)
    {
        while (_fictionBooks.Count < count)
        {
            _fictionBooks.Add(_factory.PublishFictionBook());
        }
    }
    #endregion Methods
}
