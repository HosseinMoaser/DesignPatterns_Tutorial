namespace Observer_Pattern.Domain;

public interface IUser
{
    // In RiseSpot auto-trading platform output of this method was string (OrderId that comin from exchange)
    void SendOrder(ISignal signal);
}
