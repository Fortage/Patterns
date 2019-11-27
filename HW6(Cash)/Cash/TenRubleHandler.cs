namespace Cash.BanknotesHandler.RublesHandlers
{
    public class TenRubleHandler : RubleHandler
    {
        public TenRubleHandler(BanknotHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 10;
    }
}