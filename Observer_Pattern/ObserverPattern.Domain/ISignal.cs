namespace Observer_Pattern.Domain;

// Subject
public interface ISignal
{
    public string Symbol { get; }
    public decimal EnterPrice { get; }
    public decimal StopLoss { get; }
    public decimal TrailingStart { get;}
    public bool IsShort { get; }
    void Notify(decimal enterPrice);
}
