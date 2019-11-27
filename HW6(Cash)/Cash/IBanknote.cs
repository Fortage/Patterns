namespace Cash
{ 
    public interface IBanknote
    {
        CurrencyType Currency { get; }
        int Value { get; }
    }
}