namespace Cash.BanknotesHandler.RublesHandlers
{
    public class FiftyRubleHandler : RubleHandler
    {
        public FiftyRubleHandler(BanknotHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 50;
    }
}