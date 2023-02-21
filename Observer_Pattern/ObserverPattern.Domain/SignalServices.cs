namespace Observer_Pattern.Domain;

public class SignalServices : ISignal
{
    private decimal _enterPrice;
    private readonly List<IUser> _users = new List<IUser>();

    public SignalServices(decimal enterPrice)
    {
        _enterPrice = enterPrice;
    }
    public string Symbol => "XBTUSDTM"; // A sample symbol

    public decimal EnterPrice { get { return _enterPrice; } set { Notify(value); } }

    public decimal StopLoss => 16243;

    public decimal TrailingStart => 16422;

    public bool IsShort => false;

    public void AddSubscriber(IUser user)
    {
        _users.Add(user);
    }

    public void RemoveSubscriber(IUser user)
    {
        _users.Remove(user);
    }

    public void Notify(decimal enterPrice)
    {
        _enterPrice= enterPrice;

        _users.ForEach(u => u.SendOrder(this));
    }
}
